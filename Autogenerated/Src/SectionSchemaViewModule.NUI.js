define("SectionSchemaViewModule", ["BaseSchemaViewModule"], function() {
	Ext.define("Terrasoft.configuration.SectionSchemaViewModule", {
		alternateClassName: "Terrasoft.SectionSchemaViewModule",
		extend: "Terrasoft.BaseSchemaViewModule",

		// region Fields: Protected

		/**
		 * @protected
		 */
		componentSelector: "crt-section-component",

		/**
		 * @protected
		 */
		componentWrapSelector: "crt-section",

		// endregion

		// region Method: Private

		/**
		 * @private
		 */
		_initReloadAction: function() {
			this.sandbox.subscribe("UpdateSection", this.reloadPage, this, [this._getReloadActionTag()]);
		},

		/**
		 * @private
		 */
		_getReloadActionTag: function() {
			return this.schemaName + "_UpdateSection";
		},

		/**
		 * @private
		 */
		_getSchemaCaption: function(entitySchemaName) {
			return Terrasoft.configuration.ModuleStructure[entitySchemaName]?.moduleCaption;
		},

		// endregion

		// region Method: Protected

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#init
		 * @overridden
		 */
		init: function(callback, scope) {
			this.callParent([
				() => {
					const historyState = this.sandbox.publish("GetHistoryState");
					const {hash} = historyState;
					this.sandbox.publish("SelectedSideBarItemChanged", hash.historyState, ["sectionMenuModule"]);
					this._initReloadAction();
					Ext.callback(callback, scope);
				}
			]);
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#onInitDataView
		 * @overridden
		 * @returns {Promise}
		 */
		onInitDataView: async function({$initialEvent}) {
			const {entityName} = $initialEvent;
			const {hash} = this.sandbox.publish("GetHistoryState");
			const caption = this._getSchemaCaption(entityName);
			this.headerCaption = caption;
			const headerConfig = {
				isMainMenu: false,
				isLogoVisible: true,
				isCaptionVisible: true,
				isContextHelpVisible: true,
				hidePageCaption: true,
				caption,
				moduleName: this.schemaName
			};
			this.sandbox.publish("InitDataViews", headerConfig);
			this.sandbox.subscribe("NeedHeaderCaption", function () {
				this.sandbox.publish("InitDataViews", headerConfig);
				this.sandbox.publish("SelectedSideBarItemChanged", hash.historyState, ["sectionMenuModule"]);
			}, this);
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#getMessages
		 * @overridden
		 */
		getMessages: function() {
			const config = this.callParent(arguments);
			const messages = {
				"NeedHeaderCaption": {
					direction: this.Terrasoft.MessageDirectionType.SUBSCRIBE,
					mode: this.Terrasoft.MessageMode.BROADCAST
				},
				"UpdateSection": {
					mode: Terrasoft.MessageMode.PTP,
					direction: Terrasoft.MessageDirectionType.SUBSCRIBE
				},
				"SelectedSideBarItemChanged": {
					mode: this.Terrasoft.MessageMode.PTP,
					direction: this.Terrasoft.MessageDirectionType.PUBLISH
				}
			};
			return Ext.apply(config, messages);
		},

		/**
		 * @inheritDoc Terrasoft.BaseSchemaViewModule#initSchemaName
		 * @protected
		 */
		initSchemaName: function() {
			const historyState = this.sandbox.publish("GetHistoryState");
			const hash = historyState.hash;
			const state = historyState.state;
			this.schemaName = state.cardSchemaName || hash.entityName || "";
		},

		/**
		 * @inheritDoc Terrasoft.core.BaseObject#onDestroy
		 * @overridden
		 */
		destroy: function() {
			this.callParent(arguments);
			this.sandbox.unsubscribePtp("UpdateSection", [this._getReloadActionTag()]);
		}

		// endregion

	});
	return Terrasoft.SectionSchemaViewModule;
});
