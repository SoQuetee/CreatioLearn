namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrFrequencyListSchema

	/// <exclude/>
	public class UsrFrequencyListSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public UsrFrequencyListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrFrequencyListSchema(UsrFrequencyListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrFrequencyListSchema(UsrFrequencyListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d60e3d28-678b-4e12-8e70-d13184457110");
			RealUId = new Guid("d60e3d28-678b-4e12-8e70-d13184457110");
			Name = "UsrFrequencyList";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
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
			return new UsrFrequencyList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrFrequencyList_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrFrequencyListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrFrequencyListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d60e3d28-678b-4e12-8e70-d13184457110"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrFrequencyList

	/// <summary>
	/// Переодичность.
	/// </summary>
	public class UsrFrequencyList : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public UsrFrequencyList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrFrequencyList";
		}

		public UsrFrequencyList(UsrFrequencyList source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrFrequencyList_Test_workEventsProcess(UserConnection);
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
			return new UsrFrequencyList(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrFrequencyList_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrFrequencyList_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : UsrFrequencyList
	{

		public UsrFrequencyList_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrFrequencyList_Test_workEventsProcess";
			SchemaUId = new Guid("d60e3d28-678b-4e12-8e70-d13184457110");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d60e3d28-678b-4e12-8e70-d13184457110");
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

	#region Class: UsrFrequencyList_Test_workEventsProcess

	/// <exclude/>
	public class UsrFrequencyList_Test_workEventsProcess : UsrFrequencyList_Test_workEventsProcess<UsrFrequencyList>
	{

		public UsrFrequencyList_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrFrequencyList_Test_workEventsProcess

	public partial class UsrFrequencyList_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrFrequencyListEventsProcess

	/// <exclude/>
	public class UsrFrequencyListEventsProcess : UsrFrequencyList_Test_workEventsProcess
	{

		public UsrFrequencyListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

