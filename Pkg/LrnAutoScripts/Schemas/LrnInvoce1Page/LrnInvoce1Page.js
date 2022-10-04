 define("LrnInvoce1Page", ["BusinessRuleModule"], function(BusinessRuleModule) {
	return {
		entitySchemaName: "LrnInvoce",
		attributes: {
			"IsModelItemsEnabled": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": true,
				"dependencies": [{
					"methodName": "setLockoutStatus"
				}]
			}
		},
		methods: {
			onEntityInitialized: function() {
                this.callParent(arguments);
                this.setLockoutStatus();
            },
			
			setLockoutStatus: function() {
				var status = this.$LrnFact;
				if (status) {
					this.$IsModelItemsEnabled = false;
				}
				else{
					this.$IsModelItemsEnabled = true;
				}
			}
		},
		diff: /**SCHEMA_DIFF*/[
            {
                "operation": "merge",
                "name": "CardContentWrapper",
                "values": {
                    "generator": "DisableControlsGenerator.generatePartial"
                }
            }
        ]/**SCHEMA_DIFF*/
	};
 });