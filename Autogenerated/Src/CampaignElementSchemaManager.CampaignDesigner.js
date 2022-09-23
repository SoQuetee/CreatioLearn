define("CampaignElementSchemaManager", ["CampaignBaseAudienceSchema", "ProcessCampaignSequenceFlowSchema",
		"ProcessCampaignConditionalSequenceFlowSchema", "ProcessEmailConditionalTransitionSchema",
		"ProcessLandingConditionalTransitionSchema", "ProcessEventConditionalTransitionSchema", "MarketingEmailSchema",
		"AddCampaignParticipantSchema", "ExitFromCampaignSchema", "CampaignLandingSchema", "CampaignEventSchema",
		"CampaignTimerSchema", "CampaignStartSignalSchema", "CampaignAddObjectSchema", "CampaignUpdateObjectSchema",
		"CampaignStartLandingSchema", "CampaignStartEventSchema", "CampaignAddToEventSchema", "CampaignSplitGatewaySchema",
		"CampaignDeduplicatorSchema", "ProcessSplitGatewayTransitionSchema"],
	function() {
		Ext.define("Terrasoft.manager.CampaignElementSchemaManager", {
			extend: "Terrasoft.BaseProcessFlowElementSchemaManager",
			alternateClassName: "Terrasoft.CampaignElementSchemaManager",
			singleton: true,

			/**
			 * @inheritdoc Terrasoft.BaseSchemaManager#managerName
			 * @protected
			 * @overridden
			 */
			managerName: "CampaignElementSchemaManager",

			/**
			 * Returns if element can be copied.
			 * @param {Terrasoft.ProcessBaseElementSchema} element Element to be copied.
			 * @return {Boolean} Returns true if element can be copied.
			 */
			allowElementCopy: function(element) {
				return !!(element && element.managerItemUId);
			},

			/**
			 * @inheritdoc Terrasoft.BaseProcessFlowElementSchemaManager#initialize
			 * @protected
			 * @overridden
			 */
			initialize: function() {
				this._initCoreElementClassNames();
				this.callParent(arguments);
			},

			/**
			 * Fills coreElementClassNames property
			 * with default Campaign designer element class names.
			 * @private
			 */
			_initCoreElementClassNames: function() {
				this.coreElementClassNames = _.union([
					{ itemType: "Terrasoft.ProcessLaneSetSchema" },
					{ itemType: "Terrasoft.ProcessCampaignSequenceFlowSchema" },
					{ itemType: "Terrasoft.ProcessCampaignConditionalSequenceFlowSchema" },
					{ itemType: "Terrasoft.ProcessEmailConditionalTransitionSchema" },
					{ itemType: "Terrasoft.ProcessEventConditionalTransitionSchema" },
					{ itemType: "Terrasoft.ProcessSplitGatewayTransitionSchema" },
					{ itemType: "Terrasoft.ProcessLandingConditionalTransitionSchema" },
					{ itemType: "Terrasoft.MarketingEmailSchema" },
					{ itemType: "Terrasoft.AddCampaignParticipantSchema" },
					{ itemType: "Terrasoft.CampaignStartSignalSchema" },
					{ itemType: "Terrasoft.CampaignStartEventSchema" },
					{ itemType: "Terrasoft.CampaignStartLandingSchema" },
					{ itemType: "Terrasoft.CampaignAddToEventSchema" },
					{ itemType: "Terrasoft.CampaignEventSchema" },
					{ itemType: "Terrasoft.CampaignAddObjectSchema" },
					{ itemType: "Terrasoft.CampaignUpdateObjectSchema" },
					{ itemType: "Terrasoft.CampaignDeduplicatorSchema" },
					{ itemType: "Terrasoft.CampaignSplitGatewaySchema" },
					{ itemType: "Terrasoft.CampaignLandingSchema" },
					{ itemType: "Terrasoft.CampaignTimerSchema" },
					{ itemType: "Terrasoft.ExitFromCampaignSchema" }
				], this.coreElementClassNames);
			}
		});
	}
);
