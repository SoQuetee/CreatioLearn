define("CardSchemaViewModule", ["@creatio/sdk", "BaseSchemaViewModule", "HistoryStateUtilities"], function(sdk) {
	Ext.define("Terrasoft.configuration.CardSchemaViewModule", {
		alternateClassName: "Terrasoft.CardSchemaViewModule",
		extend: "Terrasoft.BaseSchemaViewModule",

		mixins: {
			historyStateUtilities: "Terrasoft.HistoryStateUtilities"
		},

		/**
		 * @protected
		 */
		componentSelector: "crt-card-component",
		/**
		 * @protected
		 */
		componentWrapSelector: "crt-card",

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#getMessages
		 * @overridden
		 */
		getMessages: function () {
			const config = this.callParent(arguments);
			const messages = {
				"CardModuleResponse": {
					direction: this.Terrasoft.MessageDirectionType.PUBLISH,
					mode: this.Terrasoft.MessageMode.PTP
				},
				"UpdateDetail": {
					"mode": this.Terrasoft.MessageMode.PTP,
					"direction": this.Terrasoft.MessageDirectionType.PUBLISH
				},
				"UpdateParentLookupDisplayValue": {
					direction: this.Terrasoft.MessageDirectionType.PUBLISH,
					mode: this.Terrasoft.MessageMode.BROADCAST
				},
			};
			return Ext.apply(config, messages);
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#subscribeHandlers
		 * @protected
		 */
		subscribeHandlers: function () {
			this.callParent(arguments);
			const moduleRef = this;
			this.unsubscribesHandlers.push(
				this.handlerChain.register("crt.7xRequest", new class extends sdk.BaseRequestHandler {
					handle(request) {
						switch (request.action) {
							case "CardResponse":
								const cardModuleResponse = {
									...request.$initialEvent,
									isInChain: moduleRef.isInChain
								};
								moduleRef.sandbox.publish("UpdateDetail", {
									primaryColumnValue: cardModuleResponse.primaryColumnValue
								}, [moduleRef.sandbox.id]);
								if (moduleRef.isInChain) {
									moduleRef.sandbox.publish("UpdateParentLookupDisplayValue", {
										referenceSchemaName: cardModuleResponse.referenceSchemaName,
										displayValue:  cardModuleResponse.primaryDisplayColumnValue,
										value: cardModuleResponse.primaryColumnValue,
									});
								}
								return moduleRef.sandbox.publish("CardModuleResponse", cardModuleResponse,
									[moduleRef.sandbox.id]);
							default:
								return this.next?.handle(request);
						}
					}
				}())
			);
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#onInitDataView
		 * @overridden
		 * @returns {Promise}
		 */
		onInitDataView: async function({$initialEvent}) {
			const {caption, hidePageCaption} = $initialEvent;
			this.headerCaption = caption;
			this.sandbox.publish("InitDataViews", {
				caption,
				hidePageCaption
			});
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#initSchemaName
		 * @protected
		 * @overridden
		 */
		initSchemaName: function() {
			const historyState = this.sandbox.publish("GetHistoryState");
			const state = historyState.state || {};
			this.isInChain = state.isInChain;
			if (this.Ext.isEmpty(state.schemaName) && !this.isInChain) {
				const historyStateInfo = this.getHistoryStateInfo();
				this.schemaName = historyStateInfo.schemas.pop();
				this.operation = historyStateInfo.operation;
				this.primaryColumnValue = historyStateInfo.primaryColumnValue;
			} else {
				if (state.entitySchemaName) {
					this.entitySchemaName = state.entitySchemaName;
				}
				this.schemaName = state.schemaName;
				this.operation = state.operation;
				this.primaryColumnValue = state.primaryColumnValue;
			}
		}

	});
	return Terrasoft.CardSchemaViewModule;
});
