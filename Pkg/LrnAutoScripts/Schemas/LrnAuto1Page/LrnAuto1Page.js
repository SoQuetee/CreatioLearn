 define("LrnAuto1Page", ["BusinessRuleModule"], function(BusinessRuleModule) {
	return {
		entitySchemaName: "LrnAuto",
		rules: {
			//правило на пробег
			"LrnKm": {
				"BindParametrVisibleAutoKmByUsed": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.VISIBLE,
					"conditions": [
						{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "LrnUsed"
							},
							
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						},
					]
				}
			},
			//правило на кол-во владельцев
			"LrnOwnersCount": {
				"BindParametrVisibleAutoOwnersCountByUsed": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.VISIBLE,
					"conditions": [
						{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "LrnUsed"
							},
							
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						},
					]
				}
			},
			//правило на поле Был в дтп 
			"LrnInAccident": {
				"BindParametrVisibleAutoInAccidentByUsed": {
					"ruleType": BusinessRuleModule.enums.RuleType.BINDPARAMETER,
					"property": BusinessRuleModule.enums.Property.VISIBLE,
					"conditions": [
						{
							"leftExpression": {
								"type": BusinessRuleModule.enums.ValueType.ATTRIBUTE,
								"attribute": "LrnUsed"
							},
							
							"comparisonType": Terrasoft.ComparisonType.EQUAL,
							
							"rightExpression": {
								"type": BusinessRuleModule.enums.ValueType.CONSTANT,
								"value": true
							}
						},
					]
				}
			},
		}
	};
 });