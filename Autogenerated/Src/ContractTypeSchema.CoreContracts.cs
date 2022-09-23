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

	#region Class: ContractType_CoreContracts_TerrasoftSchema

	/// <exclude/>
	public class ContractType_CoreContracts_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ContractType_CoreContracts_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContractType_CoreContracts_TerrasoftSchema(ContractType_CoreContracts_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContractType_CoreContracts_TerrasoftSchema(ContractType_CoreContracts_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("427ad733-d7ff-43c5-a65a-c22a25e4e5df");
			RealUId = new Guid("427ad733-d7ff-43c5-a65a-c22a25e4e5df");
			Name = "ContractType_CoreContracts_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContractType_CoreContracts_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContractType_CoreContractsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContractType_CoreContracts_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContractType_CoreContracts_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("427ad733-d7ff-43c5-a65a-c22a25e4e5df"));
		}

		#endregion

	}

	#endregion

	#region Class: ContractType_CoreContracts_Terrasoft

	/// <summary>
	/// Contract type.
	/// </summary>
	public class ContractType_CoreContracts_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ContractType_CoreContracts_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContractType_CoreContracts_Terrasoft";
		}

		public ContractType_CoreContracts_Terrasoft(ContractType_CoreContracts_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContractType_CoreContractsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContractType_CoreContracts_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContractType_CoreContractsEventsProcess

	/// <exclude/>
	public partial class ContractType_CoreContractsEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : ContractType_CoreContracts_Terrasoft
	{

		public ContractType_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContractType_CoreContractsEventsProcess";
			SchemaUId = new Guid("427ad733-d7ff-43c5-a65a-c22a25e4e5df");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("427ad733-d7ff-43c5-a65a-c22a25e4e5df");
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

	#region Class: ContractType_CoreContractsEventsProcess

	/// <exclude/>
	public class ContractType_CoreContractsEventsProcess : ContractType_CoreContractsEventsProcess<ContractType_CoreContracts_Terrasoft>
	{

		public ContractType_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContractType_CoreContractsEventsProcess

	public partial class ContractType_CoreContractsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

