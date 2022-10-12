define("LrnAgreement1Page", ["BusinessRuleModule", "ServiceHelper"], function(BusinessRuleModule, ServiceHelper) {
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
              		"columns": ["LrnDateEnd", "LrnCreditPeriod", "LrnPercent"],
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
			/**
			 * блокировка полей
			 */
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
			
			/**
			 * фильтрация ввода пользователя в поле Название
			 */
			deleteSymbolsInLrnName: async function() {
				let name = this.$LrnName;
				if (name && /\D/g.test(name)) {
					this.$LrnName = await name.replace(/[^-\d]/g, "");
				} 
			},


			/**
			 * проверка срока окончания кредитной программы
			 * @returns сообщение с ошибкой
			 */

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

			/**
			 * подставляем значение в кредитный период
			 */
			setCreditPeriod: function() {
				let creditData = this.$LrnCredit;
				this.$LrnCreditPeriod = creditData.LrnCreditPeriod;
			},

			/**
			 * установить значение поля Сумма
			 */
			setSummaByUsedAuto: function() {
				let auto = this.$LrnAuto;
				if (typeof auto == "object") {
					if (auto.LrnUsed) {
						this.$LrnSumma = auto["LrnModel.LrnRecommendedAmount"];
					}
					else {
						this.$LrnSumma = auto.LrnAmount;
					}
				}
			},
			
			/** 
			* логика кнопки Пересчитать кредит
			*/
			onRecalculateCreditClick: function() {
				//тут не стал их проверять, тк есть проверка в методе ниже
				let summa = this.$LrnSumma;
				let initialFee = this.$LrnInitialFee;
				let percent = this.$LrnCredit.LrnPercent;
				let creditPeriod = this.$LrnCreditPeriod;
				let creditAmount = summa - initialFee;
				
				this.$LrnCreditAmount = creditAmount;
				let fullCreditAmount = (percent / 100 * creditPeriod * creditAmount) + creditAmount;
				this.$LrnFullCreditAmount  = fullCreditAmount.toFixed(2);
				
			}
			
			// /**
			//  * условия активности кнопки "Пересчитать кредит"
			//  */
			// isCreditInfoSet: function() {
			// 	return this.$LrnSumma > 0 && this.$LrnInitialFee > 0;
			// },

			// /**
			//  * условия активности кнопки "Выписка по договору"
			//  * @returns состояние активности кнопки
			//  */
			//  isAgreementDataSet: function() {
			// 	return this.$LrnName && this.$LrnAuto && this.$LrnDate && this.$LrnSumma;
			//  },
			
			//  /**
			//   * обработка клика по кнопке "Выписка по договору"
			//   */
			//  onGetAgreementExtractClick: function() {
			// 	let id = this.$Id;
			// 	let serviceData = {
			// 		agreementId: id
			// 	};
			// 	ServiceHelper.callService("AgreementExtract", "GetAgreementExtractFile",
			// 	function(response) {
			// 		let result = response.GetAgreementExtractFileResult;
			// 		if (result) {
			// 			let file = new File([new Uint8Array(result.FileContent)], result.FileName);
			// 			const url = window.URL.createObjectURL(file);
			// 			const a = document.createElement('a');
			// 			a.style.display = "none";
			// 			a.href = url;
			// 			a.download = result.FileName;
			// 			document.body.appendChild(a);
			// 			a.click();
			// 			window.URL.revokeObjectURL(url);
			// 		}
			// 	}, serviceData, this);
			//  }
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
			// {
            //     "operation": "insert",
            //     "parentName": "LeftContainer",
            //     "propertyName": "items",
            //     "name": "GetAgreementExtractButton", 
			// 	"enabled": { bindTo: "getEnabled" },
            //     "values": {
            //         "itemType": Terrasoft.ViewItemType.BUTTON,
            //         "caption": { bindTo: "Resources.Strings.AgreementExtractButton" },
            //         "click": { bindTo: "onGetAgreementExtractClick" },
            //         "enabled": { bindTo: "isAgreementDataSet" },
            //         "layout": { "column": 1, "row": 6, "colSpan": 2, "rowSpan": 1 },
			// 		"style": Terrasoft.controls.ButtonEnums.style.GREEN
            //     }
            // }
        ]/**SCHEMA_DIFF*/
	};
});
