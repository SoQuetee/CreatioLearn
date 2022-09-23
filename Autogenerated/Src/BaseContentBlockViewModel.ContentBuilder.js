﻿define("BaseContentBlockViewModel", ["BaseContentBlockViewModelResources", "BaseContentItemViewModel"], function(resources) {

	/**
	 * Class for BaseContentBlockViewModel.
	 */
	Ext.define("Terrasoft.BaseContentBlockViewModel", {
		extend: "Terrasoft.BaseContentItemViewModel",
		alternateClassName: "Terrasoft.controls.BaseContentBlockViewModel",

		/**
		 * Name of the view class.
		 * @protected
		 * @type {String}
		 */
		className: null,

		serializableChildrenCollectionSource: "Items",

		/**
		 * Initializes model with resources.
		 * @protected
		 * @param {Object} resourcesObj Resources object.
		 */
		initResourcesValues: function(resourcesObj) {
			var resourcesSuffix = "Resources";
			Terrasoft.each(resourcesObj, function(resourceGroup, resourceGroupName) {
				resourceGroupName = resourceGroupName.replace("localizable", "");
				Terrasoft.each(resourceGroup, function(resourceValue, resourceName) {
					var viewModelResourceName = [resourcesSuffix, resourceGroupName, resourceName].join(".");
					this.set(viewModelResourceName, resourceValue);
				}, this);
			}, this);
		},

		/**
		 * Generates configuration object of element view.
		 * @return {Object} Configuration object of element view.
		 */
		getViewConfig: function() {
			return {
				"className": this.className,
				"wrapStyle": "$Styles",
				"items": "$Items",
				"tag": this.$Id,
				"id": this.$Id
			};
		},

		/**
		 * Checks conditions for block selection.
		 * @protected
		 * @return {Boolean} Operation result.
		 */
		checkIsSelectable: function() {
			return !this.$GroupId;
		},

		/**
		 * @inheritdoc Terrasoft.BaseViewModel#constructor
		 * @override
		 */
		constructor: function() {
			this.callParent(arguments);
			var collection = this.get("Items") || Ext.create("Terrasoft.BaseViewModelCollection");
			collection.on("itemChanged", this.onItemChanged, this);
			collection.on("add", this.onCollectionChanged, this);
			collection.on("remove", this.onCollectionChanged, this);
			this.on("change:Selected", this.onSelectedChanged, this);
			this.set("Items", collection);
			this.set("Movable", true);
			this.set("Removable", true);
			this.set("Clonable", true);
			this.initResourcesValues(resources);
		},

		/**
		 * Generates configuration object of element tools.
		 * @protected
		 * @return {Array} Configuration object of element tools.
		 */
		getToolsConfig: function() {
			var id = this.get("Id");
			return [
				{
					className: "Terrasoft.Button",
					id: id + "dragg-el",
					style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					markerValue: "move-button",
					imageConfig: "$Resources.Images.ContentBlockMove",
					classes: {wrapperClass: "content-block-move-button"},
					visible: "$Movable"
				}, {
					className: "Terrasoft.Button",
					style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					markerValue: "copy-button",
					imageConfig: "$Resources.Images.ContentBlockAdd",
					classes: {wrapperClass: "content-block-copy-button"},
					click: "$onCopyButtonClick",
					visible: "$Clonable"
				}, {
					className: "Terrasoft.Button",
					style: Terrasoft.controls.ButtonEnums.style.TRANSPARENT,
					markerValue: "remove-button",
					imageConfig: "$Resources.Images.ContentBlockRemove",
					classes: {wrapperClass: "content-block-remove-button"},
					click: "$onRemoveButtonClick",
					visible: "$Removable"
				}
			];
		},

		/**
		 * Generates configuration object of draggable block.
		 * @protected
		 * @return {Object} Configuration object of draggable block.
		 */
		getDraggableConfig: function() {
			var draggableConfig = {};
			draggableConfig[Terrasoft.DragAction.MOVE] = {
				autoGenerateDraggableElement: false,
				elementId: this.id + "dragg-el-wrapperEl",
				handlers: {
					b4StartDrag: "b4StartDrag",
					onDragEnter: "onDragEnter",
					onDragOver: "onDragOver",
					onDragOut: "onDragOut",
					onDragDrop: "onDragDrop",
					onInvalidDrop: "onInvalidDrop"
				}
			};
			return draggableConfig;
		},

		/**
		 * Returns block properties.
		 * @public
		 * @param {Array[String]} propNames Names of the properties.
		 * @return {Object} Block properties.
		 */
		getProperties: function(propNames) {
			var item = {
				id: this.$Id,
				data: {}
			};
			Terrasoft.each(propNames, function(propName) {
				item.data[propName] = this.get(propName);
			}, this);
			return item;
		},

		/**
		 * Applies changes to the block.
		 * @public
		 * @param {Object} data The properties of the block.
		 */
		setProperties: function(data) {
			if (data) {
				Terrasoft.each(data, function(propValue, propName) {
					this.set(propName, propValue);
				}, this);
			}
		},

		/**
		 * Handler of event 'itemChanged' of Terrasoft.Collection.
		 * @protected
		 * @param {Terrasoft.BaseViewModel} item Changed collection item.
		 * @param {Object} config Event parameters.
		 */
		onItemChanged: function(item, config) {
			if (config.event) {
				switch (config.event) {
					case "onselected":
						this.onItemSelected(config.arguments);
						break;
					case "elementSelected":
						this.onElementSelected(config.arguments.id);
						break;
					case "onelementcopy":
						this.onElementCopy(config.arguments);
						break;
					case "onelementmoved":
						this.fireEvent("change", this, {
							event: "onelementmoved",
							arguments: config.arguments
						});
						break;
					case "macrobuttonclicked":
						this.fireEvent("change", this, {
							event: "macrobuttonclicked",
							arguments: config.arguments
						});
						break;
					case "emailtemplatelinkclicked":
						this.fireEvent("change", this, {
							event: "emailtemplatelinkclicked"
						});
						break;
					case "selectedtextchanged":
						this.fireEvent("change", this, {
							event: "selectedtextchanged",
							arguments: config.arguments
						});
						break;
					case "onitemconfigchanged":
						this.fireEvent("change", this, {
							event: "onitemconfigchanged",
							arguments: config.arguments
						});
						break;
					default:
						break;
				}
			}
			var deprecatedEvent = config.deprecatedEvent;
			if (deprecatedEvent) {
				this.fireEvent("change", this, {
					event: deprecatedEvent,
					arguments: config.arguments
				});
			}
		},

		/**
		 * Element click handler.
		 * @protected
		 */
		onElementSelected: function(elementId) {
			this.fireEvent("change", this, {
				event: "elementSelected",
				arguments: {
					id: elementId
				}
			});
		},

		/**
		 * Handles copy of element.
		 * @protected
		 * @param {Object} config Event parameters.
		 */
		onElementCopy: function(config) {
			this.fireEvent("change", this, {
				event: "onelementcopy",
				arguments: config
			});
		},

		/**
		 * Handles select of child block.
		 * @protected
		 * @param {Object} config Event parameters.
		 */
		onItemSelected: function(config) {
			this.fireEvent("change", this, {
				event: "onselected",
				arguments: config
			});
		},

		/**
		 * Handles changes of selected element.
		 * @protected
		 */
		onSelectedChanged: function(model, value) {
			this.fireEvent("change", this, {
				event: "onselected",
				arguments: {
					Id: this.$Id,
					value: value
				}
			});
		},

		/**
		 * Generates event of block group drag.
		 * @protected
		 */
		onDragOver: function() {
			this.fireEvent("change", this, {
				event: "ondragover",
				arguments: arguments
			});
		},

		/**
		 * Generates event of block group drop.
		 * @protected
		 */
		onDragDrop: function() {
			this.fireEvent("change", this, {
				event: "ondragdrop",
				arguments: arguments
			});
		},

		/**
		 * Generates event of block group invalid drop.
		 * @protected
		 */
		onInvalidDrop: function() {
			this.fireEvent("change", this, {
				event: "oninvaliddrop",
				arguments: arguments
			});
		},

		/**
		 * Handles click of Remove button.
		 * @protected
		 */
		onRemoveButtonClick: function() {
			this.fireEvent("change", this, {
				event: "onremove",
				arguments: {Id: this.get("Id")}
			});
		},

		/**
		 * Handles click of Copy button.
		 * @protected
		 */
		onCopyButtonClick: function() {
			this.fireEvent("change", this, {
				event: "oncopy",
				arguments: {Id: this.get("Id")}
			});
		},

		/**
		 * Handles click of Edit button.
		 * @protected
		 */
		onEditButtonClick: function() {
			this.fireEvent("change", this, {
				event: "onedit",
				arguments: {Id: this.get("Id")}
			});
		},

		/**
		 * Handler on items collection changed action.
		 * @abstract
		 */
		onCollectionChanged: Terrasoft.emptyFn
	});

	return Terrasoft.BaseContentBlockViewModel;
});
