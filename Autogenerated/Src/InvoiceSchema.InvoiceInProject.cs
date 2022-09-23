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
	using Terrasoft.Configuration;
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

	#region Class: Invoice_InvoiceInProject_TerrasoftSchema

	/// <exclude/>
	public class Invoice_InvoiceInProject_TerrasoftSchema : Terrasoft.Configuration.Invoice_PRMPortal_TerrasoftSchema
	{

		#region Constructors: Public

		public Invoice_InvoiceInProject_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Invoice_InvoiceInProject_TerrasoftSchema(Invoice_InvoiceInProject_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Invoice_InvoiceInProject_TerrasoftSchema(Invoice_InvoiceInProject_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17");
			Name = "Invoice_InvoiceInProject_Terrasoft";
			ParentSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("85d0da72-7b6d-43fc-9279-bb96431481e2")) == null) {
				Columns.Add(CreateProjectColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("85d0da72-7b6d-43fc-9279-bb96431481e2"),
				Name = @"Project",
				ReferenceSchemaUId = new Guid("a11d7fa4-9946-494c-ae41-2169844d29be"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17"),
				ModifiedInSchemaUId = new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17"),
				CreatedInPackageId = new Guid("fe2bb0e4-061e-41b1-be85-5078c802043f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Invoice_InvoiceInProject_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Invoice_InvoiceInProjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Invoice_InvoiceInProject_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Invoice_InvoiceInProject_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17"));
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_InvoiceInProject_Terrasoft

	/// <summary>
	/// Invoice.
	/// </summary>
	public class Invoice_InvoiceInProject_Terrasoft : Terrasoft.Configuration.Invoice_PRMPortal_Terrasoft
	{

		#region Constructors: Public

		public Invoice_InvoiceInProject_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Invoice_InvoiceInProject_Terrasoft";
		}

		public Invoice_InvoiceInProject_Terrasoft(Invoice_InvoiceInProject_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ProjectId {
			get {
				return GetTypedColumnValue<Guid>("ProjectId");
			}
			set {
				SetColumnValue("ProjectId", value);
				_project = null;
			}
		}

		/// <exclude/>
		public string ProjectName {
			get {
				return GetTypedColumnValue<string>("ProjectName");
			}
			set {
				SetColumnValue("ProjectName", value);
				if (_project != null) {
					_project.Name = value;
				}
			}
		}

		private Project _project;
		/// <summary>
		/// Project.
		/// </summary>
		public Project Project {
			get {
				return _project ??
					(_project = LookupColumnEntities.GetEntity("Project") as Project);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Invoice_InvoiceInProjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Invoice_InvoiceInProject_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Invoice_InvoiceInProject_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("Invoice_InvoiceInProject_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Invoice_InvoiceInProject_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Invoice_InvoiceInProjectEventsProcess

	/// <exclude/>
	public partial class Invoice_InvoiceInProjectEventsProcess<TEntity> : Terrasoft.Configuration.Invoice_PRMPortalEventsProcess<TEntity> where TEntity : Invoice_InvoiceInProject_Terrasoft
	{

		public Invoice_InvoiceInProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Invoice_InvoiceInProjectEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b9290d9b-6832-4a26-8bd6-a0cff5aabc17");
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

	#region Class: Invoice_InvoiceInProjectEventsProcess

	/// <exclude/>
	public class Invoice_InvoiceInProjectEventsProcess : Invoice_InvoiceInProjectEventsProcess<Invoice_InvoiceInProject_Terrasoft>
	{

		public Invoice_InvoiceInProjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Invoice_InvoiceInProjectEventsProcess

	public partial class Invoice_InvoiceInProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

