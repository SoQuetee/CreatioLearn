﻿define("ActivitySectionV2", ["ActivitySectionSchedulerViewModel", "MeetingInvitationsMixin"],
	function() {
		return {
			entitySchemaName: "Activity",
			mixins: {
				"MeetingInvitationsMixin": "Terrasoft.MeetingInvitationsMixin"
			},
			methods: {

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.GridUtilities#getGridRowViewModelClassName
				 * @overridden
				 */
				getGridRowViewModelClassName: function (){
					return this.isSchedulerDataView() && this.getIsFeatureEnabled("MeetingInvitation")
						? "Terrasoft.ActivitySectionSchedulerViewModel"
						: this.callParent(arguments);
				},

				/**
				 * @inheritdoc Terrasoft.GridUtilities#getDeleteConfirmationMessage
				 * @overridden
				 */
				getDeleteConfirmationMessage: function(items, callback, scope) {
					const parentMethod = this.getParentMethod();
					const parentArgs = arguments;
					if(this.getIsFeatureEnabled("MeetingInvitation") && items && items.length){
						this.initMeetingInvitationInfo(items[0], function() {
							if(this.isInvitationsSent()){
								const message = (items.length > 1)
									? this.get("Resources.Strings.MultiDeleteMeetingWithInvitationsConfirmationMessage")
									: this.get("Resources.Strings.DeleteMeetingWithInvitationsConfirmationMessage");
								Ext.callback(callback, scope || this, [message])
							} else{
								Ext.callback(parentMethod, scope || this, parentArgs)

							}
						}, scope);
					} else {
						this.callParent(arguments);
					}
				}

				//endregion

			},
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/
		};
	}
);
