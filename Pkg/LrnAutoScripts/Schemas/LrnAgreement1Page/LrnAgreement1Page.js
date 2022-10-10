define("LrnAgreement1Page", ["BusinessRuleModule"], function(BusinessRuleModule) {
	return {
		entitySchemaName: "LrnAgreement",
		rules: {
			//условия отображения поля Credit
			"LrnCredit": {
				"BindParametrVisibleCreditByAutoAndContact": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.VISIBLE,
					"logical": Terrasoft.LogicalOperatorType.AND,
					"conditions": [
						{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "LrnContact"
							},
							"comparisonType": 2
						},
						{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "LrnAuto"
							},
							"comparisonType": 2
						}
					]
				},
			},
			//условия отображения таба
			"TabCredits": {
				"BindTabVisibleCreditByCreditType": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.VISIBLE,
					"conditions": [
						{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "LrnCredit"
							},
							"comparisonType": 2
						}
					]
				}
			}
		},
		attributes: {
			"SetNewLrnName": {
				"dataValueType": Terrasoft.DataValueType.TEXT,
				"dependencies": [{
					"columns": ["LrnName"],
					"methodName": "deleteSymbolsInLrnName"
				}]
			},
			//выключаем поля
			"IsModelItemsEnabled": {
				"dataValueType": Terrasoft.DataValueType.BOOLEAN,
				"value": true,
				"dependencies": [{
					"columns": ["LrnDate", "LrnSumma"],
					"methodName": "setCardLockoutStatus"
				}]
			},
			"LrnAuto": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
				"lookupListConfig": {
              		"columns": ["LrnUsed", "LrnAmount", "LrnModel.LrnRecommendedAmount"],
				}
			},
			"SetAgreementSumma": { 
				"dataValueType": Terrasoft.DataValueType.FLOAT,
				"dependencies": [{
					"columns": ["LrnAuto"],
					"methodName": "setSummaByUsedAuto"
				}]
			},
			//получить поля справочника
			"LrnCredit": {
				"dataValueType": Terrasoft.DataValueType.LOOKUP,
          		"lookupListConfig": {
              		"columns": ["LrnDateEnd", "LrnCreditPeriod", "LrnModel"],
					"filters": [
						function() {
							var filterGroup = Ext.create("Terrasoft.FilterGroup");
								filterGroup.add("Credit", Terrasoft.createColumnFilterWithParameter(Terrasoft.ComparisonType.EQUAL, "[LrnAutoCredit:LrnCredit:Id].LrnAuto", this.$LrnAuto.value));
								return filterGroup;
							
						}
					]
            	}
			},
			"LrnCreditPeriod": {
				"dataValueType": Terrasoft.DataValueType.INTEGER,
				"dependencies": [{
					"columns": ["LrnCredit"],
					"methodName": "setCreditPeriod"
				}]
			}
		},
		methods: {
			setCardLockoutStatus: function() {
				this.set("IsModelItemsEnabled", false);
				
			},
				
			onEntityInitialized: function() {
                this.callParent(arguments);
                this.setCardLockoutStatus();
            },
			
			setValidationConfig: function() {
				this.callParent(arguments);
				this.addColumnValidator("LrnCredit", this.checkCreditDateEnd);
			},
			
			//фильтрация ввода пользователя в поле Название
			deleteSymbolsInLrnName: async function() {
				let name = this.$LrnName;
				if (name && /\D/g.test(name)) {
					this.$LrnName = await name.replace(/[^-\d]/g, "");
				} 
			},
			
			//проверка срока окончания кредитной программы
			checkCreditDateEnd: function() {
				let invalidMessage = "";
				let creditData = this.$LrnCredit;
				let agreementData = this.$LrnDate;
				if (creditData && creditData.LrnDateEnd && agreementData) {
					if (creditData.LrnDateEnd.getTime() < agreementData.getTime()) {
						invalidMessage = "Срок этой кредитной программы истек, выберите другую!";
					}
				}
				return {
					invalidMessage: invalidMessage
				};
			},
			
			//подставляем значение в кредитный период
			setCreditPeriod: function() {
				let creditData = this.$LrnCredit;
				this.$LrnCreditPeriod = creditData.LrnCreditPeriod;
			},
			
			//установить значение поля Сумма
			setSummaByUsedAuto: function() {
				let auto = this.$LrnAuto;
				if (typeof auto == "object") {
					if (auto.LrnUsed){
						this.$LrnSumma = auto["LrnModel.LrnRecommendedAmount"];
					}
					else {
						this.$LrnSumma = auto.LrnAmount;
					}
				}
			},
			
			//логика кнопки Пересчитать кредит
			onRecalculateCreditClick: function() {
				//тут не стал их проверять, тк есть проверка в методе ниже
				let summa = this.$LrnSumma;
				let initialFee = this.$LrnInitialFee;
				let percent = this.$LrnCredit.LrnPercent;
				let creditPeriod = this.$LrnCreditPeriod;
				let creditAmount = summa - initialFee;
				
				this.$LrnCreditAmount = creditAmount;
				var fullCreditAmount = (percent / 100 * creditPeriod * creditAmount) + creditAmount;
				this.$LrnFullCreditAmount  = fullCreditAmount.toFixed(2);
				
			},
			
			//условия активности кнопки
			isCreditInfoSet: function() {
				// let result = false;
				// let summa = this.$LrnSumma;
				// let initialFee = this.$LrnInitialFee;
				// if (summa > 0 && initialFee > 0) {
				// 	result = true;
				// }
				return this.$LrnSumma > 0 && this.$LrnInitialFee > 0;
			}
		},
		 diff: /**SCHEMA_DIFF*/[
            {
                "operation": "insert",
                "parentName": "LeftContainer",
                "propertyName": "items",
                "name": "RecalculateCreditButton",
                "values": {
                    "itemType": Terrasoft.ViewItemType.BUTTON,
                    "caption": { bindTo: "Resources.Strings.RecalculateCreditButtonCaprion" },
                    "click": { bindTo: "onRecalculateCreditClick" },
                    "enabled": { bindTo: "isCreditInfoSet" },
                    "layout": {
                        "column": 1,
                        "row": 6,
                        "colSpan": 1
                    },
					"style": Terrasoft.controls.ButtonEnums.style.BLUE
                }
            }
        ]/**SCHEMA_DIFF*/
	};
});
