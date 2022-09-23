define("WidgetDesignerLoader", ["ext-base", "terrasoft", "BaseViewModule", "AngularPostMessageConnector"], function() {

	Ext.define("Terrasoft.configuration.WidgetDesignerLoader", {
		extend: "Terrasoft.BaseViewModule",
		alternateClassName: "Terrasoft.WidgetDesignerLoader",

		messageChannel: null,

		widgetConfig: null,

		/**
		 * @inheritDoc
		 * @override
		 */
		constructor: function() {
			this.callParent(arguments);
			this._registerMessages();
			this.messageChannel = Ext.create('Terrasoft.AngularPostMessageConnector', {
				channelName: "widget-designer-channel",
				target: window.parent
			});
		},
		
		/**
		 * @private
		 */
		_getMessages: function() {
			return {
				"LoadModule": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"RefreshCacheHash": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"NavigationModuleLoaded": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"HistoryStateChanged": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"GetHistoryState": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.PTP
				},
				"PushHistoryState": {
					"direction": Terrasoft.MessageDirectionType.PUBLISH,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"WidgetConfigChanged": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"GetModuleConfig": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.PTP
				},
				"DesignerLoaded": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"ModalOpening": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
				"ModalClosing": {
					"direction": Terrasoft.MessageDirectionType.SUBSCRIBE,
					"mode": Terrasoft.MessageMode.BROADCAST
				},
			}
		},
		
		/**
		 * @private
		 */
		_registerMessages: function() {
			const messages = this._getMessages();
			this.sandbox.registerMessages(messages);
		},

		/**
		 * @private
		 */
		_unRegisterMessages: function() {
			const messages = this._getMessages();
			this.sandbox.unRegisterMessages(messages);
		},

		/**
		 * @private
		 */
		_subscribeMessages: function() {
			const widgetDesignerModuleId = this._getWidgetDesignerModuleId();
			this.sandbox.subscribe("GetModuleConfig", () => this.widgetConfig, this, [widgetDesignerModuleId]);
			this.sandbox.subscribe("WidgetConfigChanged", ({ resources, ...config }) => {
				this.widgetConfig.itemConfig.config = config;
				this.widgetConfig.resources = resources;
				this.messageChannel.sendMessage("SaveWidgetConfig", { itemConfig: this.widgetConfig.itemConfig, 
						resources });
			}, this, [widgetDesignerModuleId]);
			this.sandbox.subscribe("DesignerLoaded", () => {
				this.messageChannel.sendMessage("DesignerLoaded");
			}, this, [widgetDesignerModuleId]);
			this.sandbox.subscribe("ModalOpening", () => {
				this.messageChannel.sendMessage("ModalOpening");
			}, this, [widgetDesignerModuleId]);
			this.sandbox.subscribe("ModalClosing", () => {
				this.messageChannel.sendMessage("ModalClosing");
			}, this, [widgetDesignerModuleId]);
		},

		/**
		 * @private
		 */
		_getWidgetDesignerModuleId: function() {
			return this.sandbox.id + "_" + this._getWidgetSchemaName();
		},

		/**
		 * @private
		 */
		_getWidgetSchemaName: function() {
			const search = window.location.search;
			const parameters = new URLSearchParams(search);
			const designSchemaName = parameters.get("designSchemaName");
			if (!designSchemaName) {
				throw new Terrasoft.ArgumentNullOrEmptyException({
						argumentName: "designSchemaName"
					});
			}
			return designSchemaName;
		},

		/**
		 * @inheritDoc
		 * @overridden
		 */
		initHomePage: function(callback, scope) {
			Ext.callback(callback, scope);
		},

		/**
		 * @inheritDoc
		 * @overridden
		 */
		loadMainPanelsModules: Terrasoft.emptyFn,

		/**
		 * @inheritDoc Terrasoft.BaseObject#onDestroy
		 * @overridden
		 */
		onDestroy: function() {
			this._unRegisterMessages();
			this.callParent(arguments);
		},


		// region Methods: Public

		/**
		 * Initializes module.
		 * @param {Function} callback The callback function.
		 * @param {Object} scope The scope of callback.
		 */
		init: function(callback, scope) {
			this._subscribeMessages();
			this.callParent([() => {
				this.messageChannel.connect(result => {
					if (result === false) {
						throw Ext.create("Terrasoft.InvalidOperationException");
					}
					this.messageChannel.on('ResponseWidgetConfig', function(config) {
						this.widgetConfig = config;
						Ext.callback(callback, scope);
					}, this);
					this.messageChannel.sendMessage("RequestWidgetConfig");
				});
			}]);
		},

		/**
		 * Renders module.
		 */
		render: function(renderTo) {
			this.callParent(arguments);
			this.sandbox.loadModule("BaseSchemaModuleV2", {
				id: this._getWidgetDesignerModuleId(),
				instanceConfig: {
					generateViewContainerId: false,
					useHistoryState: false,
					schemaName: this._getWidgetSchemaName(),
					isSchemaConfigInitialized: true
				},
				keepAlive: true,
				renderTo: renderTo,
			});
		}

		//endregion
	});
	
	return Terrasoft.WidgetDesignerLoader;
 });
