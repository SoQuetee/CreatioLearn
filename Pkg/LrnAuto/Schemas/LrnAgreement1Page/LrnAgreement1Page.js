define("LrnAgreement1Page", [], function() {
	return {
		entitySchemaName: "LrnAgreement",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"Files": {
				"schemaName": "FileDetailV2",
				"entitySchemaName": "LrnAgreementFile",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "LrnAgreement"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{
			"LrnCredit": {
				"a2c9af3f-7322-4502-b445-af11f417bbce": {
					"uId": "a2c9af3f-7322-4502-b445-af11f417bbce",
					"enabled": true,
					"removed": true,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "LrnContact"
							}
						},
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "LrnAuto"
							}
						}
					]
				}
			},
			"TabCredits": {
				"4590d283-fbfb-4b68-b8d3-0941f56671a9": {
					"uId": "4590d283-fbfb-4b68-b8d3-0941f56671a9",
					"enabled": true,
					"removed": true,
					"ruleType": 0,
					"property": 0,
					"logical": 0,
					"conditions": [
						{
							"comparisonType": 2,
							"leftExpression": {
								"type": 1,
								"attribute": "LrnCredit"
							}
						}
					]
				}
			}
		}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "LrnName015f2c5c-c955-47da-a705-27aae089f4ea",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnName"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LOOKUP042f1e62-4c63-4624-9120-23a043512a43",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnAuto",
					"enabled": true,
					"contentType": 5
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LOOKUP8c9d94fd-0ccc-488f-b808-8a7d4bbe37a1",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnContact",
					"enabled": true,
					"contentType": 3
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "DATETIME0e36a338-3788-47da-b991-0635c6e2e3a5",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnDate",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "FLOATf3053378-d6ee-4fd2-a1be-760b3b424e93",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 4,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnSumma",
					"enabled": true
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "BOOLEAN0c0775b4-36f8-40a3-8579-4b61688de7f0",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 5,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnFact",
					"enabled": false
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "LOOKUP642a94e5-c7fb-4f22-9906-4559db9e3bfa",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 6,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnCredit",
					"enabled": true,
					"contentType": 3
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 6
			},
			{
				"operation": "insert",
				"name": "TabCredit",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.TabCreditTabCaption"
					},
					"items": [],
					"order": 0
				},
				"parentName": "Tabs",
				"propertyName": "tabs",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TabCredits",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.TabCreditsGroupCaption"
					},
					"itemType": 15,
					"markerValue": "added-group",
					"items": []
				},
				"parentName": "TabCredit",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "TabCreditGridLayout46c597f1",
				"values": {
					"itemType": 0,
					"items": []
				},
				"parentName": "TabCredits",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "INTEGERa058d4c5-17e0-4f72-9cf4-c052ac1880ed",
				"values": {
					"layout": {
						"colSpan": 5,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "TabCreditGridLayout46c597f1"
					},
					"bindTo": "LrnCreditPeriod",
					"enabled": true
				},
				"parentName": "TabCreditGridLayout46c597f1",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "INTEGERe461d4d3-c00e-47bf-b8d6-ea58e5514643",
				"values": {
					"layout": {
						"colSpan": 6,
						"rowSpan": 1,
						"column": 5,
						"row": 0,
						"layoutName": "TabCreditGridLayout46c597f1"
					},
					"bindTo": "LrnCreditAmount",
					"enabled": true
				},
				"parentName": "TabCreditGridLayout46c597f1",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "INTEGERbbc1a033-44dd-4ff4-830d-e7dbd714874e",
				"values": {
					"layout": {
						"colSpan": 6,
						"rowSpan": 1,
						"column": 11,
						"row": 0,
						"layoutName": "TabCreditGridLayout46c597f1"
					},
					"bindTo": "LrnFullCreditAmount",
					"enabled": true
				},
				"parentName": "TabCreditGridLayout46c597f1",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "DATETIMEc7940224-d793-4502-86a3-664944a3b54f",
				"values": {
					"layout": {
						"colSpan": 4,
						"rowSpan": 1,
						"column": 12,
						"row": 1,
						"layoutName": "TabCreditGridLayout46c597f1"
					},
					"bindTo": "LrnPaymentPlanDate",
					"enabled": false
				},
				"parentName": "TabCreditGridLayout46c597f1",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "LrnInitialFeeaf670482-d64b-4bc8-89e8-044608ca6882",
				"values": {
					"layout": {
						"colSpan": 6,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "TabCreditGridLayout46c597f1"
					},
					"bindTo": "LrnInitialFee"
				},
				"parentName": "TabCreditGridLayout46c597f1",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "INTEGERf631c740-20df-475f-866f-df299206e626",
				"values": {
					"layout": {
						"colSpan": 6,
						"rowSpan": 1,
						"column": 6,
						"row": 1,
						"layoutName": "TabCreditGridLayout46c597f1"
					},
					"bindTo": "LrnFactSumma",
					"enabled": false
				},
				"parentName": "TabCreditGridLayout46c597f1",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "remove",
				"name": "ESNTab"
			},
			{
				"operation": "remove",
				"name": "ESNFeedContainer"
			},
			{
				"operation": "remove",
				"name": "ESNFeed"
			}
		]/**SCHEMA_DIFF*/
	};
});
