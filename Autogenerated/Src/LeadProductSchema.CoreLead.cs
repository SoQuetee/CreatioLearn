namespace Terrasoft.Configuration
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

	#region Class: LeadProduct_CoreLead_TerrasoftSchema

	/// <exclude/>
	public class LeadProduct_CoreLead_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LeadProduct_CoreLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadProduct_CoreLead_TerrasoftSchema(LeadProduct_CoreLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadProduct_CoreLead_TerrasoftSchema(LeadProduct_CoreLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f66152e-4108-49d8-9953-69045f06df88");
			RealUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88");
			Name = "LeadProduct_CoreLead_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("54134837-7fc8-4b56-b76f-58aae2c14bff");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2c4beb45-d959-4300-bbbe-fe4c9fab6f18")) == null) {
				Columns.Add(CreateLeadColumn());
			}
			if (Columns.FindByUId(new Guid("7390f3c9-0ef9-4fd7-a0e3-0be9d9e26f01")) == null) {
				Columns.Add(CreateProductColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2c4beb45-d959-4300-bbbe-fe4c9fab6f18"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				ModifiedInSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				CreatedInPackageId = new Guid("54134837-7fc8-4b56-b76f-58aae2c14bff")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7390f3c9-0ef9-4fd7-a0e3-0be9d9e26f01"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				ModifiedInSchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88"),
				CreatedInPackageId = new Guid("54134837-7fc8-4b56-b76f-58aae2c14bff")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadProduct_CoreLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadProduct_CoreLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadProduct_CoreLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadProduct_CoreLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f66152e-4108-49d8-9953-69045f06df88"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadProduct_CoreLead_Terrasoft

	/// <summary>
	/// Product in lead.
	/// </summary>
	public class LeadProduct_CoreLead_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LeadProduct_CoreLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadProduct_CoreLead_Terrasoft";
		}

		public LeadProduct_CoreLead_Terrasoft(LeadProduct_CoreLead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadId {
			get {
				return GetTypedColumnValue<Guid>("LeadId");
			}
			set {
				SetColumnValue("LeadId", value);
				_lead = null;
			}
		}

		/// <exclude/>
		public string LeadLeadName {
			get {
				return GetTypedColumnValue<string>("LeadLeadName");
			}
			set {
				SetColumnValue("LeadLeadName", value);
				if (_lead != null) {
					_lead.LeadName = value;
				}
			}
		}

		private Lead _lead;
		/// <summary>
		/// Lead.
		/// </summary>
		public Lead Lead {
			get {
				return _lead ??
					(_lead = LookupColumnEntities.GetEntity("Lead") as Lead);
			}
		}

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadProduct_CoreLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadProduct_CoreLead_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("LeadProduct_CoreLead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadProduct_CoreLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadProduct_CoreLeadEventsProcess

	/// <exclude/>
	public partial class LeadProduct_CoreLeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : LeadProduct_CoreLead_Terrasoft
	{

		public LeadProduct_CoreLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadProduct_CoreLeadEventsProcess";
			SchemaUId = new Guid("1f66152e-4108-49d8-9953-69045f06df88");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1f66152e-4108-49d8-9953-69045f06df88");
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

	#region Class: LeadProduct_CoreLeadEventsProcess

	/// <exclude/>
	public class LeadProduct_CoreLeadEventsProcess : LeadProduct_CoreLeadEventsProcess<LeadProduct_CoreLead_Terrasoft>
	{

		public LeadProduct_CoreLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadProduct_CoreLeadEventsProcess

	public partial class LeadProduct_CoreLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

