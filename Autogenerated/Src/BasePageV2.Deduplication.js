define("BasePageV2", ["css!DuplicatesWidgetModule"], function() {
	return {
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		attributes: {
			/**
			 * Is duplicates widget feature enabled.
			 */
			"DuplicatesWidgetFeatureEnabled": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": Terrasoft.Features.getIsEnabled("DuplicatesWidget")
			},
			/**
			 * Is elstic search deduplication feature enabled.
			 */
			"ESDeduplicationFeatureEnabled": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": Terrasoft.Features.getIsEnabled("ESDeduplication")
			},

			/**
			 * Is duplicates widget feature enabled.
			 */
			"IsDuplicationRuleExists": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},

			/**
			 * Is duplicates widget module loaded.
			 */
			"IsDuplicatesWidgetLoaded": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": false
			},
		},
		messages: {

			/**
			 * @message GetDuplicatesWidgetConfig
			 * Returns duplicates widget config.
			 */
			"GetDuplicatesWidgetConfig": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.SUBSCRIBE
			},

			/**
			 * @message RefreshDuplicatesWidget
			 * Message for refresh duplicates widget data.
			 */
			"RefreshDuplicatesWidget": {
				mode: Terrasoft.MessageMode.PTP,
				direction: Terrasoft.MessageDirectionType.PUBLISH
			},
		},
		mixins: {},
		methods: {

			//region Methods: Private

			/**
			 * @private
			 */
			_geDuplicatesWidgetModuleId: function() {
				return this.sandbox.id + "_DuplicatesWidgetModule";
			},

			/**
			 * @private
			 */
			_loadDuplicatesWidgetModule: function() {
				if (this.getIsDuplicatesWidgetVisible() && !this.$IsDuplicatesWidgetLoaded) {
					this.Terrasoft.require(["DuplicatesWidgetModule"], function() {
						this.sandbox.loadModule("DuplicatesWidgetModule", {
							renderTo: "DuplicatesWidgetContainer"
						});
						this.$IsDuplicatesWidgetLoaded = true;
					}, this);
				}
			},

			/**
			 * @private
			 */
			_getIsDuplicatesRulesExist: function(callback, scope) {
				if (this.$ESDeduplicationFeatureEnabled
					&& this.$DuplicatesWidgetFeatureEnabled
					&& !this.$IsDuplicatesWidgetLoaded) {
					var config = this.getDuplicatesRuleConfig();
					var data = this._getEntityDeduplicationRules(config);
					if (data && data.IsActive && data.DeduplicationColumns.length > 0) {
						this.$IsDuplicationRuleExists = true;
					}
				}
				this.Ext.callback(callback, scope);
			},

			/**
			 * Returns get duplicates rules configuration.
			 * @protected
			 * @virtual
			 */
			getDuplicatesRuleConfig: function() {
				return {
					findByActiveRules: true,
					isGetCommunicationsFromDb: true,
					duplicationSettingsSchemaNamePrefix: "ActiveRules_"
				};
			},
			
			//endregion

			//region Methods: Protected

			/**
			 * Returns included pages for duplicates widget.
			 * @protected
			 */
			getIncludedDuplicatesWidgetPages: function() {
				return [
					"ContactPageV2",
					"AccountPageV2",
					"LeadPageV2"
				];
			},
			
			/**
			 * Returns is duplicates widget visible.
			 * @protected
			 */
			getIsDuplicatesWidgetVisible: function() {
				var includedPagesList = this.getIncludedDuplicatesWidgetPages();
				return this.$ESDeduplicationFeatureEnabled
					&& this.$DuplicatesWidgetFeatureEnabled
					&& this.$IsDuplicationRuleExists
					&& includedPagesList.includes(this.name)
					&& !this.isNewMode();
			},

			/**
			 * @inheritdoc Terrasoft.BasePageV2#onEntityInitialized
			 * @overridden
			 */
			onEntityInitialized: function() {
				this.callParent(arguments);
				this.loadDuplicatesWidgetData();
			},

			/**
			 * Loads duplicates widget data.
			 * @protected
			 */
			loadDuplicatesWidgetData: function() {
				this.Terrasoft.chain(
					this._getIsDuplicatesRulesExist,
					this.findDuplicatesByActiveRules,
					function(next) {
						this._loadDuplicatesWidgetModule();
						this.Ext.callback(next, this);
					},
					function() {
						if (this.getIsDuplicatesWidgetVisible()) {
							this.sandbox.publish("RefreshDuplicatesWidget", null, [this._geDuplicatesWidgetModuleId()]);
						}
					}, this);
			},

			/**
			 * Calls service to find duplicates by active duplicates rules.
			 * @protected
			 * @virtual
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Callback function context.
			 */
			findDuplicatesByActiveRules: function(callback, scope) {
				if (this.getIsFeatureEnabled("ESDeduplication")) {
					var config = this.getDuplicatesRuleConfig();
					this.findDuplicates(callback, scope || this, config);
				} else {
					this.Ext.callback(callback, scope || this);
				}
			},

			/**
			 * @overridden
			 */
			onSaved: function() {
				this.setDuplicates(this.Terrasoft.emptyFn);
				this.callParent(arguments);
				if (this.getIsDuplicatesWidgetVisible()) {
					this.loadDuplicatesWidgetData();
				}
			},
			
			/**
			 * @inheritDoc Terrasoft.BasePageV2#subscribeSandboxEvents
			 * @overriden
			 */
			subscribeSandboxEvents: function() {
				this.callParent(arguments);
				if (this.$DuplicatesWidgetFeatureEnabled) {
					this.sandbox.subscribe("GetDuplicatesWidgetConfig",
						this.getDuplicatesConfig, this, [this._geDuplicatesWidgetModuleId()]);
				}
			},

			/**
			 * Returns duplicates config.
			 * @return {Object} Duplicates config.
			 */
			getDuplicatesConfig: function() {
				return {
					entitySchemaName: this.entitySchemaName,
					entityId: this.$Id,
					duplicates: this.$DuplicatesRecords,
				};
			},

			//endregion
			
		},
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "DuplicatesWidgetContainer",
				"parentName": "LeftModulesContainer",
				"propertyName": "items",
				"values": {
					"id": "DuplicatesWidgetContainer",
					"selectors": {"wrapEl": "#DuplicatesWidgetContainer"},
					"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
					"classes": {
						"wrapClassName": ["duplicates-widget-wrap-container"]
					},
					"items": [],
					"markerValue": "DuplicatesWidgetContainer",
					"collapseEmptyRow": true,
					"visible": { "bindTo": "getIsDuplicatesWidgetVisible"},
				},
			},
		]/**SCHEMA_DIFF*/
	};
});
