define("UsrTourOffer1Page", ["ProcessModuleUtilities"], function(ProcessModuleUtilities) {
	return {
		entitySchemaName: "UsrTourOffer",
		messages: {
			"AddingTours": {
				"mode": Terrasoft.MessageMode.BROADCAST,
				"direction": Terrasoft.MessageDirectionType.SUBSCRIBE
			}
		},
		attributes: {
			"responseDailyTravelsCount": {
				"dataValueType": Terrasoft.DataValueType.INTEGER,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			},
			"maxDailyTravelsCount": {
				"dataValueType": Terrasoft.DataValueType.INTEGER,
				"type": Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
			}
		},
		modules: /**SCHEMA_MODULES*/{}/**SCHEMA_MODULES*/,
		details: /**SCHEMA_DETAILS*/{
			"UsrTours": {
				"schemaName": "UsrSchema998bd676Detail",
				"entitySchemaName": "UsrTour",
				"filter": {
					"detailColumn": "UsrTourOffers",
					"masterColumn": "Id"
				}
			}
		}/**SCHEMA_DETAILS*/,
		businessRules: /**SCHEMA_BUSINESS_RULES*/{
			"UsrTourOfferEmployee": {
				"7d62439f-006c-4aae-a2a9-be312680f23e": {
					"uId": "7d62439f-006c-4aae-a2a9-be312680f23e",
					"enabled": true,
					"removed": false,
					"ruleType": 1,
					"baseAttributePatch": "Type",
					"comparisonType": 3,
					"autoClean": false,
					"autocomplete": false,
					"type": 0,
					"value": "60733efc-f36b-1410-a883-16d83cab0980",
					"dataValueType": 10
				}
			}
		}/**SCHEMA_BUSINESS_RULES*/,
		methods: {
			onEntityInitialized: function(){
                this.callParent(arguments);
                this.getDailyActiveTravelsCount();
                this.getMaxDailyTravelsCount();
            },
			
			getMaxDailyTravelsCount: function() {
                var count;
                var callback = function(value) {
                    count = value;
                };
                this.Terrasoft.SysSettings.querySysSettingsItem("UsrMaxActiveDailyTravels", callback, this);
                if (count === undefined) {
                    return;
                }
                else {
                    this.set("maxDailyTravelsCount", count);
                }
            },
			
			
			getDailyActiveTravelsCount: function() {
                var frequency = "Ежедневно";
                var esqFrequency = this.Ext.create("Terrasoft.EntitySchemaQuery", {
                    rootSchemaName: "UsrTourOffer"
                });
                esqFrequency.addColumn("UsrName");
                var groupFilters = this.Ext.create("Terrasoft.FilterGroup");
                var filterFrequency = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL, "UsrTourOfferFrequency.Name", frequency);
                var thisId = this.get("Id");
                var filterId = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.NOT_EQUAL, "Id", thisId);
                var filterIsActive = this.Terrasoft.createColumnFilterWithParameter(this.Terrasoft.ComparisonType.EQUAL, "UsrTourOfferIsActive", true);
                groupFilters.addItem(filterFrequency);
                groupFilters.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
                groupFilters.addItem(filterIsActive);
                groupFilters.logicalOperation = this.Terrasoft.LogicalOperatorType.AND;
                groupFilters.addItem(filterId);
                esqFrequency.filters.add(groupFilters);
                esqFrequency.getEntityCollection(function(result) {
                    if (!result.success) {
                        this.showInformationDialog("Ошибка запроса");
                        return;
                    }
                    else {
                        var lengthCollection = result.collection.collection.length;
                        this.set("responseDailyTravelsCount", lengthCollection);
                    }
                }, this);
            },
			
			setValidationConfig: function() {
                this.callParent(arguments);
                this.addColumnValidator("UsrTourOfferFrequency", this.periodicityValidator);
            },
			
			periodicityValidator: function() {
                var invalidMessage= "";
                var frequency = this.get("UsrTourOfferFrequency").displayValue;
                if (frequency === "Ежедневно") {
                    var isActive = this.get("UsrTourOfferIsActive");
                    var maxDailyCount = this.get("maxDailyTravelsCount");
                    var totalDailyCount = this.get("responseDailyTravelsCount");
                    if (totalDailyCount >= maxDailyCount && isActive) {
                        invalidMessage = "Число ежедневных активных турпредложений не может превышать " + maxDailyCount;
                    }
                }
                else {
                    invalidMessage = "";
                }
                return {
                    invalidMessage: invalidMessage
                };
            },
			//доработки по автосозданию
			init: function() {
				this.callParent(arguments);
				this.sandbox.subscribe("AddingTours", this.updateTours, this);
			},
			
			getActions: function() {
				var actionMenuItems = this.callParent(arguments);
				actionMenuItems.addItem(this.getButtonMenuItem({
					"Caption": {bindTo: "Resources.Strings.AddToursActionCaption"},
					"Click": {bindTo: "getBusinessProcessAddTours"},
					"Enabled": true
				}));
				return actionMenuItems;
			},
			
			updateTours: function() {
				this.updateDetail({
					"detail": "UsrTours",
					"reloadAll": true
				});
			},
			
			
			getBusinessProcessAddTours: function() {
				var id = this.get("Id");
				var frequency = this.get("UsrTourOfferFrequency").displayValue;
				var employee = this.get("UsrTourOfferEmployee").value;
				if (!frequency) {
					return;
				}
				var args = {
					sysProcessName: "UsrAddToursProcess",
					parameters: {
						ProcessSchemaId: id,
						ProcessSchemaFrequency: frequency,
						ProcessEmployee: employee
					}
				};
				ProcessModuleUtilities.executeProcess(args);
			}
			
		},
		dataModels: /**SCHEMA_DATA_MODELS*/{}/**SCHEMA_DATA_MODELS*/,
		diff: /**SCHEMA_DIFF*/[
			{
				"operation": "insert",
				"name": "UsrNamee07afd33-7337-4890-bd42-bd28ed157e23",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "UsrName"
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "STRINGe096c098-6130-45fe-8352-2f8c469b1610",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 0,
						"layoutName": "Header"
					},
					"bindTo": "UsrTourOfferCode",
					"enabled": true
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 1
			},
			{
				"operation": "insert",
				"name": "LOOKUPf1b377dd-5961-4717-b82e-f35c61287f38",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 0,
						"row": 1,
						"layoutName": "Header"
					},
					"bindTo": "UsrTourOfferFrequency",
					"enabled": true,
					"contentType": 3
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 2
			},
			{
				"operation": "insert",
				"name": "LOOKUPdf44ca85-70fe-4d68-9852-26a94ad7f5f9",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 1,
						"layoutName": "Header"
					},
					"bindTo": "UsrTourOfferEmployee",
					"enabled": true,
					"contentType": 3
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 3
			},
			{
				"operation": "insert",
				"name": "STRINGc84b344e-7792-4740-8bef-d19cc985df84",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 2,
						"column": 0,
						"row": 2,
						"layoutName": "Header"
					},
					"bindTo": "UsrTourOfferComment",
					"enabled": true,
					"contentType": 0
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 4
			},
			{
				"operation": "insert",
				"name": "BOOLEANaac0fb0c-3962-4553-8d3c-b0a85f088849",
				"values": {
					"layout": {
						"colSpan": 12,
						"rowSpan": 1,
						"column": 12,
						"row": 2,
						"layoutName": "Header"
					},
					"bindTo": "UsrTourOfferIsActive",
					"enabled": true
				},
				"parentName": "Header",
				"propertyName": "items",
				"index": 5
			},
			{
				"operation": "insert",
				"name": "NotesAndFilesTab",
				"values": {
					"caption": {
						"bindTo": "Resources.Strings.NotesAndFilesTabCaption"
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
				"name": "UsrTours",
				"values": {
					"itemType": 2,
					"markerValue": "added-detail"
				},
				"parentName": "NotesAndFilesTab",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "merge",
				"name": "ESNTab",
				"values": {
					"order": 1
				}
			}
		]/**SCHEMA_DIFF*/
	};
});
