define("LrnCredit1Page", [], function() {
	return {
		entitySchemaName: "LrnCredit",
		attributes: {},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"Files": {
				"schemaName": "FileDetailV2",
				"entitySchemaName": "LrnCreditFile",
				"filter": {
					"masterColumn": "Id",
					"detailColumn": "LrnCredit"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{}/**SCHEMA_BUSINESS_RULES*/,
		methods: {},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "Name8afd91ea-b76d-436c-898b-23c36c40bade",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "Name"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LrnDateStart5333abf1-420e-4b88-9ea9-f7e01458011b",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnDateStart"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LrnDateEnd863ec34f-6d21-492f-abcc-6f61c90ee9c5",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 2,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnDateEnd"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "LrnPercent8fd1e4c9-ed8e-40e5-9cbd-2e13378d3acc",
				"values": {
					"layout": {
						"colSpan": 24,
						"rowSpan": 1,
						"column": 0,
						"row": 3,
						"layoutName": "ProfileContainer"
					},
					"bindTo": "LrnPercent"
				},
				"parentName": "ProfileContainer",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "Tab1bd07386TabLabel",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.Tab1bd07386TabLabelTabCaption"
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
				"name": "TabCredit",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.TabCreditGroupCaption"
					},
					"itemType": 15,
					"markerValue": "added-group",
					"items": []
				},
				"parentName": "Tab1bd07386TabLabel",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Tab1bd07386TabLabelGridLayouta05f5da5",
				"values": {
					"itemType": 0,
					"items": []
				},
				"parentName": "TabCredit",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "LrnCreditPeriod6f3f4084-c00a-4033-a27c-5247cc235f2a",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "Tab1bd07386TabLabelGridLayouta05f5da5"
					},
					"bindTo": "LrnCreditPeriod"
				},
				"parentName": "Tab1bd07386TabLabelGridLayouta05f5da5",
				"propertyName": "items",
				"index": 0
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
