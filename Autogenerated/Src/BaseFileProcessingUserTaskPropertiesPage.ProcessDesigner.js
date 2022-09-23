/**
 * Parent: RootUserTaskPropertiesPage
 */
define("BaseFileProcessingUserTaskPropertiesPage", ["BaseFileProcessingUserTaskPropertiesPageResources",
		"ProcessSchemaUserTaskUtilities", "EntitySchemaDesignerUtilities", "ProcessUserTaskConstants",
		"FilterModuleMixin", "SortingOrderControlsMixin"
	],
	function(resources, userTaskUtilities) {
		return {
			properties: {
				_defaultResultActionType: Terrasoft.ProcessUserTaskConstants
					.ObjectFileProcessingUserTaskResultActionType.UseInProcess
			},
			mixins: {
				filterModuleMixin: "Terrasoft.FilterModuleMixin"
			},
			messages: {
				"ChangeElementType": {
					direction: Terrasoft.MessageDirectionType.PUBLISH,
					mode: Terrasoft.MessageMode.BROADCAST
				}
			},
			attributes: {

				/**
				 * Source action type.
				 * @type {Integer}
				 */
				"SourceActionType": {
					dataValueType: Terrasoft.DataValueType.INTEGER,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Source action type list.
				 * @type {Terrasoft.Collection}
				 */
				"SourceActionTypeList": {
					dataValueType: Terrasoft.DataValueType.COLLECTION,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Collection of the source action types.
				 * @type {Object}
				 */
				"SourceActionTypeSelect": {
					dataValueType: Terrasoft.DataValueType.ENUM,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: true
				},

				/**
				 * Connected object identifier.
				 * @type {Guid}
				 */
				"ConnectedObjectId": {
					dataValueType: Terrasoft.DataValueType.MAPPING,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					parameterBindConfig: {
						onSave: "saveParameter"
					}
				},

				/**
				 * ConnectedObjectId field caption text.
				 * @type {String}
				 */
				"ConnectedObjectIdCaption": {
					dataValueType: Terrasoft.DataValueType.LOCALIZABLE_STRING,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Connected object reference schema unique identifier.
				 * @type {Object}
				 */
				"ConnectedObjectReferenceSchemaUId": {
					dataValueType: Terrasoft.DataValueType.GUID,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Connected object column unique identifier.
				 * @type {Terrasoft.Guid}
				 */
				"ConnectedObjectColumnUId": {
					dataValueType: Terrasoft.DataValueType.GUID,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					parameterBindConfig: {
						onInit: "initProperty",
						onSave: "saveParameter"
					}
				},

				/**
				 * Result action type.
				 * @type {Integer}
				 */
				"ResultActionType": {
					dataValueType: Terrasoft.DataValueType.INTEGER,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					parameterBindConfig: {
						onInit: "initProperty",
						onSave: "saveParameter"
					}
				},

				/**
				 * Result action type list.
				 * @type {Terrasoft.Collection}
				 */
				"ResultActionTypeList": {
					dataValueType: Terrasoft.DataValueType.COLLECTION,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Collection of the result action types.
				 * @type {Object}
				 */
				"ResultActionTypeSelect": {
					dataValueType: Terrasoft.DataValueType.ENUM,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: false
				},

				/**
				 * Target entity schema unique identifier.
				 * @type {Terrasoft.Guid}
				 */
				"TargetEntitySchemaUId": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					referenceSchemaName: "SysSchema",
					isRequired: false
				},

				/**
				 * Collection of columns of a target entity.
				 * @type {Object}
				 */
				"TargetEntitySchemaSelect": {
					dataValueType: Terrasoft.DataValueType.LOOKUP,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					isRequired: false
				},

				/**
				 * Report entity schema unique identifier.
				 * @type {Terrasoft.Guid}
				 */
				"ReportEntitySchemaUId": {
					dataValueType: Terrasoft.DataValueType.GUID,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN
				},

				/**
				 * Text that is shown when changing the source action type.
				 */
				"ChangeSourceActionTypeMessage": {
					dataValueType: Terrasoft.DataValueType.TEXT,
					type: Terrasoft.ViewModelColumnType.VIRTUAL_COLUMN,
					value: resources.localizableStrings.ChangeSourceActionTypeWarningMessage
				}
			},
			methods: {

				//region Methods: Private

				/**
				 * @private
				 */
				_getSourceActionTypesConfig :function() {
					const sourceActionTypes = Terrasoft.ProcessUserTaskConstants
						.ObjectFileProcessingUserTaskSourceActionType;
					const actionTypesConfig = Ext.create("Terrasoft.Collection");
					const localizableStrings = resources.localizableStrings;
					Terrasoft.each(sourceActionTypes, function(type) {
						const actionTypeCaption = Ext.String.format("SourceActionType{0}Caption", type);
						actionTypesConfig.add(type, {
							value: type,
							displayValue: localizableStrings[actionTypeCaption]
						});
					}, this);
					return actionTypesConfig;
				},

				/**
				 * @private
				 */
				_prepareSourceActionTypesList: function (filter, list) {
					if (!list) {
						return;
					}
					const sourceActionTypes = this._getSourceActionTypesConfig();
					list.clear();
					list.loadAll(sourceActionTypes);
				},

				/**
				 * @private
				 */
				_getCanRemoveElement: function() {
					const element = this.get("ProcessElement");
					const parentSchema = element.parentSchema;
					return parentSchema.canRemoveElements([element.name]);
				},

				/**
				 * @private
				 */
				_getUserTaskName: function(newSourceActionType) {
					const actionTypes = Terrasoft.ProcessUserTaskConstants
						.ObjectFileProcessingUserTaskSourceActionType;
					switch (newSourceActionType) {
						case actionTypes.ReadFiles:
							return "objectFileProcessingUserTask";
						case actionTypes.GenerateReports:
							return "reportFileProcessingUserTask";
						default:
							return "processFileProcessingUserTask";
					}
				},

				/**
				 * @private
				 */
				_changeUserTaskType: function(userTaskTypeName) {
					this.sandbox.publish("ChangeElementType", {
						id: this.get("uId"),
						type: "userTask",
						userTaskType: userTaskTypeName
					});
				},

				/**
				 * @private
				 */
				_revertUserTaskType: function(oldSourceActionType) {
					const sourceActionTypes = this._getSourceActionTypesConfig();
					const selectValue = sourceActionTypes.get(oldSourceActionType);
					this.set("SourceActionTypeSelect", selectValue);
				},

				/**
				 * @private
				 */
				_confirmUserTaskTypeChange: function(onAccepted, onDeclined) {
					const isConfigured = this.getIsElementConfigured();
					if (!isConfigured) {
						onAccepted();
						return;
					}
					const buttonCaption = resources.localizableStrings.ChangeReferenceSchemaButtonCaption;
					const messageCaption = this.get("ChangeSourceActionTypeMessage")
					const changeButton = Terrasoft.getButtonConfig("modify", buttonCaption, "Modify");
					this.showConfirmationDialog(messageCaption, function(returnCode) {
						const callback = returnCode === changeButton.returnCode ? onAccepted : onDeclined;
						Ext.callback(callback, this);
					}, [changeButton, "cancel"], {defaultButton: 0});
				},

				/**
				 * @private
				 */
				_onSourceActionTypeChanged: function(value) {
					const oldSourceActionType = this.get("SourceActionType");
					const newSourceActionType = value ? value.value : null;
					if (newSourceActionType && newSourceActionType !== oldSourceActionType) {
						const revertUserTaskType = this._revertUserTaskType.bind(this, oldSourceActionType);
						const userTaskTypeName = this._getUserTaskName(newSourceActionType);
						const changeUserTaskType = this._changeUserTaskType.bind(this, userTaskTypeName);
						const config = this._getCanRemoveElement();
						if (config.canRemove) {
							this._confirmUserTaskTypeChange(changeUserTaskType, revertUserTaskType);
						} else {
							this._showInvalidEntitySchemaChangeDialog(config.validationInfo, revertUserTaskType, this);
						}
					}
				},

				/**
				 * @private
				 */
				_initSourceActionType: function() {
					const sourceActionType = this.get("SourceActionType");
					const sourceActionTypes = this._getSourceActionTypesConfig();
					const selectValue = sourceActionTypes.get(sourceActionType);
					this.set("SourceActionTypeSelect", selectValue);
				},

				/**
				 * @private
				 */
				_getTargetSchemaUIdParameterName: function() {
					return "TargetEntitySchemaUId";
				},

				/**
				 * @private
				 */
				_prepareResultActionTypesList: function (filter, list) {
					if (!list) {
						return;
					}
					const resultActionTypes = this._getResultActionTypesConfig();
					list.clear();
					list.loadAll(resultActionTypes);
				},

				/**
				 * @private
				 */
				_getResultActionTypesConfig: function() {
					const resultActionTypes = Terrasoft.ProcessUserTaskConstants
						.ObjectFileProcessingUserTaskResultActionType;
					const actionTypesConfig = Ext.create("Terrasoft.Collection");
					const localizableStrings = resources.localizableStrings;
					Terrasoft.each(resultActionTypes, function(type) {
						const actionTypeCaption = Ext.String.format("ResultActionType{0}Caption", type);
						actionTypesConfig.add(type, {
							value: type,
							displayValue: localizableStrings[actionTypeCaption]
						});
					}, this);
					return actionTypesConfig;
				},

				/**
				 * @private
				 */
				_initConnectedObjectId: function(element) {
					const parameter = element.findParameterByName("ConnectedObjectId");
					parameter.dataValueType = Terrasoft.DataValueType.LOOKUP;
					parameter.referenceSchemaUId = this.get("ConnectedObjectReferenceSchemaUId");
					const connectedObjectId = this.getParameterValue(parameter);
					this.set("ConnectedObjectId", connectedObjectId);
				},

				/**
				 * @private
				 */
				_changeResultActionType: function(value) {
					this.set("ResultActionType", value);
					this.set("ConnectedObjectColumnUId", null);
					this.set("ConnectedObjectIdCaption", null);
					this.set("ConnectedObjectReferenceSchemaUId", null);
					const targetSchemaUIdParameterName = this._getTargetSchemaUIdParameterName();
					this.set(targetSchemaUIdParameterName, null);
					this.resetConnectedObjectId();
					this.set("TargetEntitySchemaSelect", null);
				},

				/**
				 * @private
				 */
				_onResultActionTypeChanged: function(value) {
					const oldResultActionType = this.get("ResultActionType");
					const newResultActionType = value ? value.value : null;
					if (Ext.isEmpty(newResultActionType)) {
						this._changeResultActionType(newResultActionType);
						return;
					}
					if (Ext.isEmpty(oldResultActionType)) {
						this._changeResultActionType(newResultActionType);
						return;
					}
					if (oldResultActionType === newResultActionType) {
						return;
					}
					const showChangeDialog = newResultActionType === Terrasoft.ProcessUserTaskConstants
						.ObjectFileProcessingUserTaskResultActionType.UseInProcess;
					const message = resources.localizableStrings.ChangeResultActionTypeWarningMessage;
					this.checkCanChangeElementConfig(message, showChangeDialog, function() {
						this._changeResultActionType(newResultActionType);
					}, function() {
						this.initResultActionType();
					}, this);
				},

				/**
				 * @private
				 */
				_onTargetEntitySchemaChanged: function(value) {
					this.onEntitySchemaChange(value, "Target", function(entitySchemaUId, changed) {
						if (changed) {
							this.initConnectedObjectInfo(value, function() {
								this.set("TargetEntitySchemaUId", entitySchemaUId);
								this.resetConnectedObjectId();
							}, this);
						}
					}, this);
				},

				/**
				 * @private
				 */
				_getReferencedSchemas: function(entitySchemaUIdList, callback, scope) {
					const packageUId = this.get("packageUId");
					Terrasoft.EntitySchemaDesignerUtilities.getFileEntities(packageUId, entitySchemaUIdList,
						callback, scope);
				},

				/**
				 * @private
				 */
				_getEntitySchemaInfo: function(entitySchemaUId, callback, scope) {
					if (!entitySchemaUId) {
						Ext.callback(callback, scope);
						return;
					}
					this._getReferencedSchemas([entitySchemaUId], function(entitySchemaInfo) {
						const item = entitySchemaInfo[entitySchemaUId];
						Ext.callback(callback, scope, [item]);
					}, this);
				},

				/**
				 * @private
				 */
				_showInvalidEntitySchemaChangeDialog: function(validationInfo, callback, scope) {
					Terrasoft.ProcessSchemaDesignerUtilities.showProcessMessageBox({
						caption: resources.localizableStrings.InvalidEntitySchemaChange,
						message: validationInfo,
						handler: callback,
						scope: scope
					});
				},

				/**
				 * @private
				 */
				_validateSelectAttributes: function(attributeNames) {
					let validationInfo = {
						isValid: true,
						invalidMessage: ""
					};
					Terrasoft.each(attributeNames, function(attributeName) {
						const selectValue = this.get(attributeName);
						const info = userTaskUtilities.validateSelectValue(selectValue);
						this.setValidationInfo(attributeName, info.isValid, info.invalidMessage);
						if (!info.isValid) {
							validationInfo = info;
						}
						return info.isValid;
					}, this);
					return validationInfo;
				},

				/**
				 * @private
				 */
				_getIsSourceActionTypeVisible: function() {
					return Terrasoft.Features.getIsEnabled("EnableReportFileProcessingUserTask");
				},

				//endregion

				//region Methods: Protected

				/**
				 * @inheritdoc Terrasoft.BaseObject#onDestroy
				 * @overridden
				 */
				onDestroy: function() {
					this.destroyFilterModuleMixin();
					this.callParent(arguments);
				},

				/**
				 * Prepares list for file entity select control.
				 * @protected
				 * @param {Object} filter Filter.
				 * @param {Object} list File entities list.
				 */
				prepareFileEntityList: function(filter, list) {
					if (!list) {
						return;
					}
					this._getReferencedSchemas(null, function (items) {
						list.clear();
						list.loadAll(items);
					}, this);
				},

				/**
				 * Resets the connected object identifier.
				 * @protected
				 */
				resetConnectedObjectId: function() {
					const entitySchemaUId = this.get("ConnectedObjectReferenceSchemaUId");
					const connectedObjectId = {
						value: null,
						displayValue: null,
						source: Terrasoft.ProcessSchemaParameterValueSource.None,
						dataValueType: Terrasoft.DataValueType.LOOKUP,
						referenceSchemaUId: entitySchemaUId
					};
					this.set("ConnectedObjectId", connectedObjectId);
					const element = this.get("ProcessElement");
					const parameter = element.getParameterByName("ConnectedObjectId");
					parameter.referenceSchemaUId = entitySchemaUId;
				},

				/**
				 * Determines whether an element config can be changed or not.
				 * @protected
				 */
				getCanChangeElementConfig: function() {
					return {
						canRemove: true
					};
				},

				/**
				 * Clears the filters.
				 * @protected
				 */
				clearFilters: function() {
					this.set("FilterEditData", null);
					this.updateFilterModule();
				},

				/**
				 * Returns settings for the Change button.
				 * @protected
				 * @virtual
				 * @return {Object} Change button settings.
				 */
				getChangeReferenceSchemaButtonConfig: function() {
					const caption = resources.localizableStrings.ChangeReferenceSchemaButtonCaption;
					return Terrasoft.getButtonConfig("change", caption, "Change");
				},

				/**
				 * Checks whether the element config can be changed or not.
				 * @protected
				 * @param {String} messageCaption Message caption to show prompt with.
				 * @param {Boolean} showChangeDialog Determines whether to show change dialog or not.
				 * @param {Function} successCallback Success callback.
				 * @param {Function} failCallback Fail callback.
				 * @param {Object} scope Scope.
				 */
				checkCanChangeElementConfig: function(messageCaption, showChangeDialog, successCallback, failCallback,
													  scope) {
					const config = this.getCanChangeElementConfig();
					if (config.canRemove) {
						if (!showChangeDialog) {
							Ext.callback(successCallback, scope);
							return;
						}
						const changeButton = this.getChangeReferenceSchemaButtonConfig();
						this.showConfirmationDialog(messageCaption, function(returnCode) {
							if (returnCode === changeButton.returnCode) {
								Ext.callback(successCallback, scope);
							} else {
								Ext.callback(failCallback, scope);
							}
						}, [changeButton, "cancel"], {defaultButton: 0});
					} else {
						this._showInvalidEntitySchemaChangeDialog(config.validationInfo, function() {
							Ext.callback(failCallback, scope);
						}, this);
					}
				},

				/**
				 * Executes after getting the collection of entity schemas.
				 * @param {Array} fileEntities File entities.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback function context.
				 */
				onGetEntitySchemas: function(fileEntities, callback, scope) {
					const targetSchemaUIdParameterName = this._getTargetSchemaUIdParameterName();
					const targetSchemaUId = this.get(targetSchemaUIdParameterName);
					const targetSelectItem = fileEntities[targetSchemaUId];
					this.set("TargetEntitySchemaSelect", targetSelectItem, {silent: true});
					this.initConnectedObjectInfo(targetSelectItem, function() {
						Ext.callback(callback, scope);
					}, this);
				},

				/**
				 * @inheritdoc ProcessSchemaElementEditable#onElementDataLoad
				 * @overridden
				 */
				onElementDataLoad: function(element, callback, scope) {
					this.callParent([element, function() {
						Terrasoft.chain(
							function(next) {
								const fileEntityUIds = this.getReferencedSchemaUIds(element);
								this._getReferencedSchemas(fileEntityUIds, next, scope);
							},
							function(next, fileEntities) {
								this.onGetEntitySchemas(fileEntities, next, scope);
							},
							function() {
								this.set("SourceActionTypeList", Ext.create("Terrasoft.Collection"));
								this.set("ResultActionTypeList", Ext.create("Terrasoft.Collection"));
								this._initSourceActionType();
								this.initResultActionType();
								this._initConnectedObjectId(element);
								Ext.callback(callback, scope);
							}, this);
					}, this]);
				},

				/**
				 * Initializes a filter module.
				 * @protected
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback function context.
				 */
				initFilterModule: function(callback, scope) {
					const parameterName = this.getFilterReferenceSchemaAttributeName();
					const filterConfig = {
						referenceSchemaParameterName: parameterName,
						skipInitReferenceSchema: true
					};
					this.initFilterModuleMixin(filterConfig, callback, scope);
				},

				/**
				 * Determines whether it is a file copy action or not.
				 * @protected
				 */
				getIsCopyAction: function() {
					const resultActionType = this.get("ResultActionType");
					return resultActionType === Terrasoft.ProcessUserTaskConstants
						.ObjectFileProcessingUserTaskResultActionType.SaveToFiles;
				},

				/**
				 * Determines whether the result settings controls is visible or not.
				 * @protected
				 */
				getIsResultSettingsVisible: function() {
					return false;
				},

				/**
				 * Determines whether the target schema select is visible or not.
				 * @protected
				 */
				getIsTargetSelectVisible: function() {
					return this.getIsResultSettingsVisible() && this.getIsCopyAction();
				},

				/**
				 * Determines whether the target schema is visible or not.
				 * @protected
				 */
				getIsTargetSchemaVisible: function() {
					const isCopyFiles = this.getIsCopyAction();
					const targetSchemaAttributeName = this._getTargetSchemaUIdParameterName();
					const targetEntitySchemaUId = this.get(targetSchemaAttributeName);
					return isCopyFiles && this.getIsResultSettingsVisible() &&
						!Terrasoft.isEmpty(targetEntitySchemaUId);
				},

				/**
				 * Returns referenced schemas unique identifiers.
				 * @protected
				 * @param {Object} element Element object.
				 */
				getReferencedSchemaUIds: function(element) {
					const targetSchemaUIdParameterName = this._getTargetSchemaUIdParameterName();
					this.initReferenceSchemaUId(element, targetSchemaUIdParameterName, targetSchemaUIdParameterName, true);
					const targetSchemaUId = this.get(targetSchemaUIdParameterName);
					return [targetSchemaUId];
				},

				/**
				 * Initializes a connected object information.
				 * @protected
				 * @param {Object} entitySchemaInfo Entity schema info.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback function context.
				 */
				initConnectedObjectInfo: function(entitySchemaInfo, callback, scope) {
					const packageUId = this.get("packageUId");
					if (entitySchemaInfo) {
						const config = {
							entitySchemaUId: entitySchemaInfo.value,
							packageUId: packageUId,
							connectedSchemaUId: entitySchemaInfo.entitySchemaUId,
							connectedSchemaName: entitySchemaInfo.entitySchemaName
						};
						Terrasoft.EntitySchemaDesignerUtilities.findConnectedColumn(config, function(connectedColumn) {
							connectedColumn = connectedColumn || {};
							this.set("ConnectedObjectColumnUId", connectedColumn.uId);
							this.set("ConnectedObjectIdCaption", connectedColumn.caption);
							this.set("ConnectedObjectReferenceSchemaUId", entitySchemaInfo.entitySchemaUId);
							Ext.callback(callback, scope);
						}, this);
						return;
					}
					Ext.callback(callback, scope);
				},

				/**
				 * Handler for entity schema change.
				 * @protected
				 * @param {Object} newReferenceSchema New reference schema.
				 * @param {String} target Target attribute name prefix.
				 * @param {Function} callback Callback function.
				 * @param {Object} scope Callback function context.
				 */
				onEntitySchemaChange: function(newReferenceSchema, target, callback, scope) {
					const oldReferenceSchemaUId = this.get(target + "EntitySchemaUId");
					const newReferenceSchemaUId = newReferenceSchema ? newReferenceSchema.value : null;
					if (Ext.isEmpty(newReferenceSchemaUId)) {
						Ext.callback(callback, scope, [newReferenceSchemaUId, true]);
						return;
					}
					if (Ext.isEmpty(oldReferenceSchemaUId)) {
						Ext.callback(callback, scope, [newReferenceSchemaUId, true]);
						return;
					}
					if (oldReferenceSchemaUId === newReferenceSchemaUId) {
						Ext.callback(callback, scope, [newReferenceSchemaUId, false]);
						return;
					}
					const message = resources.localizableStrings.ChangeReferenceSchemaWarningMessage;
					this.checkCanChangeElementConfig(message, true, function() {
						Ext.callback(callback, scope, [newReferenceSchemaUId, true]);
					}, function() {
						this._getEntitySchemaInfo(oldReferenceSchemaUId, function(item) {
							this.set(target + "EntitySchemaSelect", item);
							Ext.callback(callback, scope, [newReferenceSchemaUId, false]);
						}, this);
					}, this);
				},

				/**
				 * Saves referenced schemas.
				 * @protected
				 * @param {Object} element Process element.
				 */
				saveReferencedSchemas: function(element) {
					const targetSchemaUIdParameterName = this._getTargetSchemaUIdParameterName();
					this.saveReferenceSchemaUId(element, targetSchemaUIdParameterName, targetSchemaUIdParameterName);
				},

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#saveValues
				 * @overridden
				 */
				saveValues: function() {
					const element = this.get("ProcessElement");
					this.saveDataSourceFilters(element);
					this.saveReferencedSchemas(element);
					this.callParent(arguments);
				},

				/**
				 * Returns an array of the select attribute names to validate.
				 * @protected
				 */
				getSelectAttributesToValidate: function() {
					const attributesToValidate = [
						"ResultActionTypeSelect"
					];
					const isCopyAction = this.getIsCopyAction();
					if (isCopyAction) {
						attributesToValidate.push("ConnectedObjectId");
						attributesToValidate.push("TargetEntitySchemaSelect");
					}
					return attributesToValidate;
				},

				/**
				 * @inheritdoc BaseProcessSchemaElementPropertiesPage#customValidator
				 * @override
				 */
				customValidator: function() {
					const attributesToValidate = this.getSelectAttributesToValidate();
					return this._validateSelectAttributes(attributesToValidate);
				},

				/**
				 * Initializes the result action type.
				 * @protected
				 */
				initResultActionType: function() {
					let resultActionType = this.get("ResultActionType");
					if (Terrasoft.isEmpty(resultActionType)) {
						resultActionType = this._defaultResultActionType;
						this.set("ResultActionType", resultActionType);
					}
					const resultActionTypes = this._getResultActionTypesConfig();
					const selectValue = resultActionTypes.get(resultActionType);
					this.set("ResultActionTypeSelect", selectValue);
				},

				/**
				 * Determines whether the element is configured or not.
				 */
				getIsElementConfigured: Terrasoft.abstractFn

				//endregion

			},
			diff: /**SCHEMA_DIFF*/[
				{
					"operation": "insert",
					"name": "BaseFileSelectionContainer",
					"parentName": "EditorsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"classes": {
							"wrapClassName": ["object-file-processing-user-task-properties-page"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "TargetActionParametersContainer",
					"parentName": "EditorsContainer",
					"propertyName": "items",
					"values": {
						"itemType": Terrasoft.ViewItemType.GRID_LAYOUT,
						"items": [],
						"classes": {
							"wrapClassName": ["object-file-processing-user-task-properties-page"]
						}
					}
				},
				{
					"operation": "insert",
					"name": "SourceActionTypeSelectLabel",
					"parentName": "BaseFileSelectionContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "Resources.Strings.SourceActionTypeCaption"},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"visible": {"bindTo": "_getIsSourceActionTypeVisible"}
					}
				},
				{
					"operation": "insert",
					"parentName": "BaseFileSelectionContainer",
					"propertyName": "items",
					"name": "SourceActionTypeSelect",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"controlConfig": {
							"prepareList": {"bindTo": "_prepareSourceActionTypesList"},
							"change": {"bindTo": "_onSourceActionTypeChanged"},
							"list": {"bindTo": "SourceActionTypeList"}
						},
						"labelConfig": {
							"visible": false
						},
						"wrapClass": ["no-caption-control"],
						"visible": {"bindTo": "_getIsSourceActionTypeVisible"}
					}
				},
				{
					"operation": "insert",
					"name": "ResultActionTypeContainer",
					"parentName": "TargetActionParametersContainer",
					"propertyName": "items",
					"values": {
						"items": [],
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.CONTAINER,
						"visible": { "bindTo": "getIsResultSettingsVisible" }
					}
				},
				{
					"operation": "insert",
					"name": "ResultActionTypeSelectLabel",
					"parentName": "ResultActionTypeContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 0,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": { "bindTo": "Resources.Strings.ResultActionTypeCaption" },
						"classes": {
							"labelClass": ["t-title-label-proc"]
						}
					}
				},
				{
					"operation": "insert",
					"parentName": "ResultActionTypeContainer",
					"propertyName": "items",
					"name": "ResultActionTypeSelect",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"controlConfig": {
							"prepareList": {"bindTo": "_prepareResultActionTypesList"},
							"change": {"bindTo": "_onResultActionTypeChanged"},
							"list": {"bindTo": "ResultActionTypeList"}
						},
						"labelConfig": {
							"visible": false
						},
						"wrapClass": ["no-caption-control"]
					}
				},
				{
					"operation": "insert",
					"name": "TargetEntitySchemaSelectLabel",
					"parentName": "TargetActionParametersContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 1,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "Resources.Strings.TargetEntitySchemaSelectCaption"},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"visible": {"bindTo": "getIsTargetSelectVisible"}
					}
				},
				{
					"operation": "insert",
					"parentName": "TargetActionParametersContainer",
					"propertyName": "items",
					"name": "TargetEntitySchemaSelect",
					"values": {
						"layout": {
							"column": 0,
							"row": 2,
							"colSpan": 24
						},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"contentType": Terrasoft.ContentType.ENUM,
						"controlConfig": {
							"prepareList": {"bindTo": "prepareFileEntityList"},
							"filterComparisonType": Terrasoft.StringFilterType.CONTAIN,
							"change": {"bindTo": "_onTargetEntitySchemaChanged"}
						},
						"labelConfig": {
							"visible": false
						},
						"wrapClass": ["no-caption-control"],
						"visible": {"bindTo": "getIsTargetSelectVisible"}
					}
				},
				{
					"operation": "insert",
					"name": "ConnectedObjectIdLabel",
					"parentName": "TargetActionParametersContainer",
					"propertyName": "items",
					"values": {
						"layout": {
							"column": 0,
							"row": 3,
							"colSpan": 24
						},
						"itemType": Terrasoft.ViewItemType.LABEL,
						"caption": {"bindTo": "ConnectedObjectIdCaption"},
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"visible": {"bindTo": "getIsTargetSchemaVisible"}
					}
				},
				{
					"operation": "insert",
					"parentName": "TargetActionParametersContainer",
					"propertyName": "items",
					"name": "ConnectedObjectId",
					"values": {
						"layout": {
							"column": 0,
							"row": 4,
							"colSpan": 24
						},
						"labelConfig": {
							"visible": false
						},
						"wrapClass": ["no-caption-control"],
						"classes": {
							"labelClass": ["t-title-label-proc"]
						},
						"visible": {"bindTo": "getIsTargetSchemaVisible"}
					}
				}
			]/**SCHEMA_DIFF*/
		};
	}
);
