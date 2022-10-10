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
			},
			"LrnAgreement": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"lookupListConfig": {
              		"columns": ["LrnCredit", "LrnSumma"],
				}
			},
			"SetInvoiceSummaByAgreement": {
				"dataValueType": Terrasoft.DataValueType.FLOAT,
				"dependencies": [{
					"columns": ["LrnAgreement"],
					"methodName": "setInvoiceSumma"
				}]
			}
		},
		methods: {
			onEntityInitialized: function() {
                this.callParent(arguments);
                this.setLockoutStatus();
            },
			
			onSaved: function(response, config) {
				this.callParent(arguments);
				this.setLockoutStatus();
			},
			
			setLockoutStatus: function() {
				// let status = this.$LrnFact;
				// if (status) {
				// 	this.$IsModelItemsEnabled = false;
				// }
				// else {
				// 	this.$IsModelItemsEnabled = true;
				// }
				return !this.$LrnFact
			},
			
			setInvoiceSumma: function() {
				let agreement = this.$LrnAgreement;
				if (typeof agreement == "object") {
					if (!agreement.LrnCredit) {
						this.$LrnAmount = agreement.LrnSumma;
					}
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