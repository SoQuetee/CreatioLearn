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

	#region Class: UsrTourStatusListSchema

	/// <exclude/>
	public class UsrTourStatusListSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public UsrTourStatusListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourStatusListSchema(UsrTourStatusListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourStatusListSchema(UsrTourStatusListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("140901a2-2d07-4202-85d5-a0ab4f91d779");
			RealUId = new Guid("140901a2-2d07-4202-85d5-a0ab4f91d779");
			Name = "UsrTourStatusList";
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
			return new UsrTourStatusList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTourStatusList_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourStatusListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourStatusListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("140901a2-2d07-4202-85d5-a0ab4f91d779"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourStatusList

	/// <summary>
	/// Состояние тура.
	/// </summary>
	public class UsrTourStatusList : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public UsrTourStatusList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourStatusList";
		}

		public UsrTourStatusList(UsrTourStatusList source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTourStatusList_Test_workEventsProcess(UserConnection);
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
			return new UsrTourStatusList(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourStatusList_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTourStatusList_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : UsrTourStatusList
	{

		public UsrTourStatusList_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTourStatusList_Test_workEventsProcess";
			SchemaUId = new Guid("140901a2-2d07-4202-85d5-a0ab4f91d779");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("140901a2-2d07-4202-85d5-a0ab4f91d779");
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

	#region Class: UsrTourStatusList_Test_workEventsProcess

	/// <exclude/>
	public class UsrTourStatusList_Test_workEventsProcess : UsrTourStatusList_Test_workEventsProcess<UsrTourStatusList>
	{

		public UsrTourStatusList_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTourStatusList_Test_workEventsProcess

	public partial class UsrTourStatusList_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourStatusListEventsProcess

	/// <exclude/>
	public class UsrTourStatusListEventsProcess : UsrTourStatusList_Test_workEventsProcess
	{

		public UsrTourStatusListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

