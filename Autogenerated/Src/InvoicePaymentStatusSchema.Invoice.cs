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

	#region Class: InvoicePaymentStatus_Invoice_TerrasoftSchema

	/// <exclude/>
	public class InvoicePaymentStatus_Invoice_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public InvoicePaymentStatus_Invoice_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoicePaymentStatus_Invoice_TerrasoftSchema(InvoicePaymentStatus_Invoice_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoicePaymentStatus_Invoice_TerrasoftSchema(InvoicePaymentStatus_Invoice_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			RealUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			Name = "InvoicePaymentStatus_Invoice_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ca97d08a-da88-4e75-a732-6501bc043dcb")) == null) {
				Columns.Add(CreateFinalStatusColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateFinalStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ca97d08a-da88-4e75-a732-6501bc043dcb"),
				Name = @"FinalStatus",
				CreatedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"),
				ModifiedInSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoicePaymentStatus_Invoice_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoicePaymentStatus_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoicePaymentStatus_Invoice_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoicePaymentStatus_Invoice_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatus_Invoice_Terrasoft

	/// <summary>
	/// Invoice payment status.
	/// </summary>
	public class InvoicePaymentStatus_Invoice_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public InvoicePaymentStatus_Invoice_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoicePaymentStatus_Invoice_Terrasoft";
		}

		public InvoicePaymentStatus_Invoice_Terrasoft(InvoicePaymentStatus_Invoice_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Status is final.
		/// </summary>
		public bool FinalStatus {
			get {
				return GetTypedColumnValue<bool>("FinalStatus");
			}
			set {
				SetColumnValue("FinalStatus", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoicePaymentStatus_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("InvoicePaymentStatus_Invoice_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("InvoicePaymentStatus_Invoice_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("InvoicePaymentStatus_Invoice_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("InvoicePaymentStatus_Invoice_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("InvoicePaymentStatus_Invoice_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("InvoicePaymentStatus_Invoice_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("InvoicePaymentStatus_Invoice_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoicePaymentStatus_Invoice_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatus_InvoiceEventsProcess

	/// <exclude/>
	public partial class InvoicePaymentStatus_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : InvoicePaymentStatus_Invoice_Terrasoft
	{

		public InvoicePaymentStatus_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoicePaymentStatus_InvoiceEventsProcess";
			SchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
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

	#region Class: InvoicePaymentStatus_InvoiceEventsProcess

	/// <exclude/>
	public class InvoicePaymentStatus_InvoiceEventsProcess : InvoicePaymentStatus_InvoiceEventsProcess<InvoicePaymentStatus_Invoice_Terrasoft>
	{

		public InvoicePaymentStatus_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoicePaymentStatus_InvoiceEventsProcess

	public partial class InvoicePaymentStatus_InvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

