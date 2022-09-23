define("MeetingInvitationsMixin", ["terrasoft", "ServiceHelper", "TimezoneUtils", "MeetingInvitationsMixinResources"],
	function(Terrasoft, ServiceHelper, TimezoneUtils, Resources) {

		/**
		 * @class Terrasoft.configuration.mixins.MeetingInvitationsMixin
		 * The mixin can add signature to body.
		 */
		Ext.define("Terrasoft.configuration.mixins.MeetingInvitationsMixin", {
			alternateClassName: "Terrasoft.MeetingInvitationsMixin",

			//region Fields: Public

			/**
			 * Meeting service url.
			 * @type {String}
			 */
			meetingServiceName: "MeetingService",

			/**
			 * Change meeting response enumerable.
			 * @returns {{Yes: 0, No: 1, YesWithNotification: 2, YesWithObsoleteNotification: 3}}
			 */
			changeMeetingResponseEnum: {
				"Yes": 0,
				"No": 1,
				"YesWithNotification": 2, 
				"YesWithObsoleteNotification": 3
			},

			/**
			 * User confirmation result of sending meeting invitations.
			 */
			userResultOfSendingInvitations: false,

			//endregion

			//region Methods: Private

			/**
			 * Gets configs for calling the service with the ability to send invitations.
			 * @param {Guid} meetingId Meeting unique identifier.
			 * @param {String} methodName Meeting service method name.
			 * @param {Function} methodName Callback function.
			 * @return {Object} Send invitations service config.
			 * @private
			 */
			getMeetingServiceConfig: function (meetingId, methodName, callback) {
				return {
					"serviceName": this.meetingServiceName,
					"methodName": methodName,
					"data":{
						"meetingId": meetingId
					},
					"callback": callback,
					"scope": this
				};
			},

			/**
			 * Show confirmation dialog.
			 * @param {String} message Confirmation dialog message.
			 * @param {Function} resolveCallback Resolve callback.
			 * @param {Function} rejectCallback Reject callback.
			 * @param {Array} buttons Array buttons.
			 * @private
			 */
			showConfirmationDialogInternal: function (message, resolveCallback, rejectCallback, buttons) {
				this.showConfirmationDialog(message, function(result) {
					if (result === Terrasoft.MessageBoxButtons.YES.returnCode) {
						Ext.callback(resolveCallback, this);
					} else if(result === Terrasoft.MessageBoxButtons.NO.returnCode
							|| Terrasoft.MessageBoxButtons.OK.returnCode){
						Ext.callback(rejectCallback, this);
					}
				}, buttons);
			},

			/**
			 * Process send invitations response.
			 * @param {Guid} meetingId Meeting unique identifier.
			 * @param {String} response Response string code.
			 * @param {Function} resolveCallback Resolve callback.
			 * @param {Function} rejectCallback Reject callback.
			 * @private
			 */
			canUserChangeMeetingCallback: function (meetingId, response, resolveCallback, rejectCallback) {
				let notificationMessage;
				switch (response) {
					case this.changeMeetingResponseEnum.Yes:
						return Ext.callback(resolveCallback, this);
					case this.changeMeetingResponseEnum.YesWithNotification:
						notificationMessage = notificationMessage
							|| this.get("Resources.Strings.CanUserChangeMeetingResolveMessage")
							|| Resources.localizableStrings.ResendMeetingInvitationsMessage;
					case this.changeMeetingResponseEnum.YesWithObsoleteNotification:
						const config = this.getMeetingServiceConfig(meetingId, "GetMeetingInvitationInfo",
							function(responseData, response) {
								if (response && responseData) {
									const syncSinceDate = new Date(responseData.CalendarSyncSinceDate);
									if (this.$StartDate >= syncSinceDate || this.$OldStartDate >= syncSinceDate) {
										notificationMessage = notificationMessage
											|| Resources.localizableStrings.ResendObsoleteMeetingInvitationsMessage;
										this.showConfirmationDialogInternal(notificationMessage,
											function() {
												this.userResultOfSendingInvitations = true;
												Ext.callback(resolveCallback, this);
											}, rejectCallback, [Terrasoft.MessageBoxButtons.YES, Terrasoft.MessageBoxButtons.NO]);
										} else {
											Ext.callback(resolveCallback, this);
										}
									}
								}
							);
						ServiceHelper.callService(config)
						break;
					case this.changeMeetingResponseEnum.No:
						Terrasoft.showInformation(Resources.localizableStrings.CanNotChangeMeetingMessage)
						Ext.callback(rejectCallback, this);
						break;
				}
			},

			//endregion

			//region Methods: Public

			/**
			 * Confirm user sending invitation action.
			 * @param {Guid} meetingId Meeting identifier.
			 */
			confirmInvitationsSending: function(meetingId) {
				if (this.entitySchema.name === "Activity" && this.userResultOfSendingInvitations) {
					this.sendInvitations(meetingId, Terrasoft.emptyFn, this);
				}
			},

			/**
			 * Check the user ability send invitations.
			 * @param {Guid} meetingId Meeting unique identifier.
			 * @param {Function} resolveCallback Resolve callback.
			 * @param {Function} rejectCallback Reject callback.
			 */
			canUserChangeMeeting: function(meetingId, resolveCallback, rejectCallback) {
				this.userResultOfSendingInvitations = false;
				if (Terrasoft.Features.getIsEnabled("MeetingInvitation")) {
					const config = this.getMeetingServiceConfig(meetingId, "CanUserChangeMeeting",
						function(response) {
							if (response >= 0) {
								this.canUserChangeMeetingCallback(meetingId, response, resolveCallback, rejectCallback);
							} else {
								Ext.callback(rejectCallback, this);
							}
						});
					return ServiceHelper.callService(config);
				} else {
					Ext.callback(resolveCallback, this);
				}
			},

			/**
			 * Send invitations to activity participants.
			 * @param {Guid} meetingId Meeting unique identifier.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Execution context.
			 */
			sendInvitations: function(meetingId, callback, scope) {
				Terrasoft.MaskHelper.ShowBodyMask();
				const config = this.getMeetingServiceConfig(meetingId, "SendInvitations",
					function (response) {
						Terrasoft.MaskHelper.HideBodyMask();
						if (!response) {
							return Terrasoft.showInformation(Resources.localizableStrings.ErrorSendingInvitationMessage);
						}
						if (response.success) {
							Terrasoft.showInformation(Resources.localizableStrings.SuccessSendingInvitationMessage);
							return Ext.callback(callback, scope || this);
						}
						if (response.errorInfo) {
							this.error(response.errorInfo.message);
						}
						Terrasoft.showInformation(Resources.localizableStrings.ErrorSendingInvitationMessage);
					});
				ServiceHelper.callService(config);
			},

			/**
			 * Initializing the display properties of the send invitations button.
			 * @param {Guid} meetingId Meeting unique identifier.
			 * @param {Function} callback Callback function.
			 * @param {Object} scope Execution context.
			 */
			initMeetingInvitationInfo: function(meetingId, callback, scope) {
				const config = this.getMeetingServiceConfig(meetingId, "GetMeetingInvitationInfo",
					function(responseData, response) {
						if (response && responseData) {
							this.set("ParticipantsInvited", responseData.IsParticipantsInvited);
							this.set("MeetingExported", responseData.IsSynchronized);
							this.set("ParticipantsExist", responseData.IsParticipantsExist);
							this.set("InvitationButtonEnabled", responseData.HasCalendarIntegration);
							this.set("OutdatedMeeting", responseData.IsOutdatedMeeting);
							this.set("CalendarSyncSinceDate", responseData.CalendarSyncSinceDate);
						}
						Ext.callback(callback, scope || this);
					});
				ServiceHelper.callService(config)
			},

			/**
			 * Checking that meeting invitation was sent.
			 * @returns {Boolean} True, if meeting invitations was sent, otherwise false.
			 * @protected
			 */
			isInvitationsSent: function() {
				return this.get("MeetingExported") && this.get("ParticipantsInvited");
			}

			//endregion

		});
	});
