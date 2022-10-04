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
              		"columns": ["LrnAmount", "LrnModel.LrnRecommendedAmount"],
				}
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
                this.addColumnValidator("LrnName", this.deleteSymbols);
				this.addColumnValidator("LrnCredit", this.checkCreditDateEnd);
				this.addColumnValidator("LrnAuto", this.setSummaByUsedAuto);
            },
			
			//фильтрация ввода пользователя в поле Название
			deleteSymbols: function() {
				var name = this.$LrnName;
				if (typeof name == "string" && name.match(/[^-\d]/g)) {
					//this.set("LrnName", this.$LrnName.replace(/[^-\d]/g, ""));
					this.$LrnName = name.replace(/[^-\d]/g, "");
				}
				return {
					invalidMessage: ""
				};
			},
			//проверка срока окончания кредитной программы
			checkCreditDateEnd: function() {
				var invalidMessage = "";
				var creditData = this.$LrnCredit;
				//спросить Станислава по этому поводу
				if (creditData.LrnDateEnd) {
					if (creditData.LrnDateEnd.getTime() < this.$LrnDate.getTime()) {
						invalidMessage = "Срок этой кредитной программы истек, выберите другую!";
					}
					//подставляем значение в кредитный период
					this.$LrnCreditPeriod = creditData.LrnCreditPeriod;
				}
				else {
					invalidMessage = "Укажите дату договора";
					this.showInformationDialog("Укажите дату договора");
				}
				return {
					invalidMessage: invalidMessage
				};
			},
			
			//установить значение поля Сумма
			setSummaByUsedAuto: function() {
				var autoId = this.$LrnAuto;
				if (autoId) {
					var esq = this.Ext.create("Terrasoft.EntitySchemaQuery", {
    							rootSchemaName: "LrnAuto"
							});
					esq.addColumn("LrnModel.LrnRecommendedAmount", "ModelAmount");
					esq.addColumn("LrnUsed");
					esq.addColumn("LrnAmount");
					esq.getEntity(autoId.value, function(result) {
						if (!result.success) {
							this.showInformationDialog("Ошибка запроса данных");
							return;
						}
						if (result.entity.get("LrnUsed")) {
							this.$LrnSumma = result.entity.get("ModelAmount");
						}
						else {
							this.$LrnSumma = result.entity.get("LrnAmount");
						}
					}, this);
				}
				return {
					invalidMessage: ""
				};
			},
			/*checkUsedAuto: function() {
				var auto = this.$LrnAuto;
				console.log(auto);
				if (auto != null) {
					if (auto.LrnUsed) {
						this.$LrnSumma = auto.LrnAmount;
					}
					else {
						console.log(auto.LrnModel.LrnRecommendedAmount);
						this.$LrnSumma = auto.LrnModel.LrnRecommendedAmount;
					}
				}
			},*/
			
			//логика кнопки Пересчитать кредит
			onRecalculateCreditClick: function() {
				var summa = this.$LrnSumma;
				var initialFee = this.$LrnInitialFee;
				var percent = this.$LrnCredit.LrnPercent;
				var creditPeriod = this.$LrnCreditPeriod;
				var creditAmount = summa - initialFee;
				
				this.$LrnCreditAmount = creditAmount;
				var fullCreditAmount = (percent / 100 * creditPeriod * creditAmount) + creditAmount;
				console.log(fullCreditAmount);
				this.$LrnFullCreditAmount  = fullCreditAmount.toFixed(2);
				
			},
			//условия активности кнопки
			isCreditInfoSet: function() {
				var result = false;
				var summa = this.$LrnSumma;
				var initialFee = this.$LrnInitialFee;
				if (summa > 0 && initialFee > 0) {
					result = true;
				}
				return result;
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
