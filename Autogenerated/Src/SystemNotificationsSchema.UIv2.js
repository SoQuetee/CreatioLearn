define("SystemNotificationsSchema", [], function() {
	return {
		methods: {
			/**
			 * Returns true if license generation notification.
			 * @protected
			 * @returns {Boolean} True if license generation notification.
			 */
			isLicenseNotification: function() {
				return this.get("LoaderName") === "ExpireLicenseNotificationProcess";
			},

			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#onNotificationSubjectClick
			 * @overridden
			 */
			onNotificationSubjectClick: function() {
				if (!this.isLicenseNotification()) {
					this.callParent(arguments);
					return;
				}
				const url = Terrasoft.combinePath(Terrasoft.workspaceBaseUrl, "ClientApp/#/LicenseManager");
				window.open(url, "_blank");
			},

			/**
			 * @inheritdoc Terrasoft.BaseNotificationsSchema#getNotificationLinkAttributes
			 * @overridden
			 */
			getNotificationLinkAttributes: function() {
				if (!this.isLicenseNotification()) {
					return this.callParent(arguments);
				}
				return { activelink: true };
			},
		},
		diff: []
	};
});
