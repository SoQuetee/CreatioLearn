﻿namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ContentBlockSchema

	/// <exclude/>
	public class ContentBlockSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ContentBlockSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContentBlockSchema(ContentBlockSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContentBlockSchema(ContentBlockSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e");
			RealUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e");
			Name = "ContentBlock";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b4659a49-95c8-427f-8d77-17e7fb4dcc0e")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("4ee5e4a9-1c1e-4a27-a46a-d9912ddd114a")) == null) {
				Columns.Add(CreateConfigColumn());
			}
			if (Columns.FindByUId(new Guid("c3543307-7b55-4eb1-88df-5a418bd82773")) == null) {
				Columns.Add(CreateIsAutoGeneratedImageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d239cde3-8b02-409d-a382-71f8231e0412"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				ModifiedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				CreatedInPackageId = new Guid("cfa8aacd-72c1-4f7e-bdee-ab252a95c163"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("b4659a49-95c8-427f-8d77-17e7fb4dcc0e"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				ModifiedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				CreatedInPackageId = new Guid("cfa8aacd-72c1-4f7e-bdee-ab252a95c163"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateConfigColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("4ee5e4a9-1c1e-4a27-a46a-d9912ddd114a"),
				Name = @"Config",
				CreatedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				ModifiedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				CreatedInPackageId = new Guid("cfa8aacd-72c1-4f7e-bdee-ab252a95c163"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("d1926d72-b7bf-4b5d-9a27-553743364334"),
				Name = @"Image",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				ModifiedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				CreatedInPackageId = new Guid("cfa8aacd-72c1-4f7e-bdee-ab252a95c163")
			};
		}

		protected virtual EntitySchemaColumn CreateIsAutoGeneratedImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c3543307-7b55-4eb1-88df-5a418bd82773"),
				Name = @"IsAutoGeneratedImage",
				CreatedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				ModifiedInSchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"),
				CreatedInPackageId = new Guid("bf6e6026-1cc0-44cb-99ab-3d9cfa28091b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContentBlock(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContentBlock_ContentBuilderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContentBlockSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContentBlockSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e"));
		}

		#endregion

	}

	#endregion

	#region Class: ContentBlock

	/// <summary>
	/// Content block.
	/// </summary>
	public class ContentBlock : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ContentBlock(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContentBlock";
		}

		public ContentBlock(ContentBlock source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Content block setup.
		/// </summary>
		public string Config {
			get {
				return GetTypedColumnValue<string>("Config");
			}
			set {
				SetColumnValue("Config", value);
			}
		}

		/// <exclude/>
		public Guid ImageId {
			get {
				return GetTypedColumnValue<Guid>("ImageId");
			}
			set {
				SetColumnValue("ImageId", value);
				_image = null;
			}
		}

		/// <exclude/>
		public string ImageName {
			get {
				return GetTypedColumnValue<string>("ImageName");
			}
			set {
				SetColumnValue("ImageName", value);
				if (_image != null) {
					_image.Name = value;
				}
			}
		}

		private SysImage _image;
		/// <summary>
		/// Image.
		/// </summary>
		public SysImage Image {
			get {
				return _image ??
					(_image = LookupColumnEntities.GetEntity("Image") as SysImage);
			}
		}

		/// <summary>
		/// Flag that indicates image generated automatically.
		/// </summary>
		public bool IsAutoGeneratedImage {
			get {
				return GetTypedColumnValue<bool>("IsAutoGeneratedImage");
			}
			set {
				SetColumnValue("IsAutoGeneratedImage", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContentBlock_ContentBuilderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContentBlockDeleted", e);
			Validating += (s, e) => ThrowEvent("ContentBlockValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContentBlock(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContentBlock_ContentBuilderEventsProcess

	/// <exclude/>
	public partial class ContentBlock_ContentBuilderEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ContentBlock
	{

		public ContentBlock_ContentBuilderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContentBlock_ContentBuilderEventsProcess";
			SchemaUId = new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("49ba5c34-f914-4a37-9d9e-5cf648c9967e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ContentBlock_ContentBuilderEventsProcess

	/// <exclude/>
	public class ContentBlock_ContentBuilderEventsProcess : ContentBlock_ContentBuilderEventsProcess<ContentBlock>
	{

		public ContentBlock_ContentBuilderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContentBlock_ContentBuilderEventsProcess

	public partial class ContentBlock_ContentBuilderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContentBlockEventsProcess

	/// <exclude/>
	public class ContentBlockEventsProcess : ContentBlock_ContentBuilderEventsProcess
	{

		public ContentBlockEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

