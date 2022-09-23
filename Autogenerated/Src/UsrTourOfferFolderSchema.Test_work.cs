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

	#region Class: UsrTourOfferFolderSchema

	/// <exclude/>
	public class UsrTourOfferFolderSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public UsrTourOfferFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourOfferFolderSchema(UsrTourOfferFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourOfferFolderSchema(UsrTourOfferFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8");
			RealUId = new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8");
			Name = "UsrTourOfferFolder";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
			ExtendParent = false;
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrTourOfferFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTourOfferFolder_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourOfferFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourOfferFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferFolder

	/// <summary>
	/// Группа Турпредложения.
	/// </summary>
	public class UsrTourOfferFolder : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public UsrTourOfferFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOfferFolder";
		}

		public UsrTourOfferFolder(UsrTourOfferFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private UsrTourOfferFolder _parent;
		/// <summary>
		/// Родитель.
		/// </summary>
		public UsrTourOfferFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as UsrTourOfferFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTourOfferFolder_Test_workEventsProcess(UserConnection);
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
			return new UsrTourOfferFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferFolder_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTourOfferFolder_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_BaseEventsProcess<TEntity> where TEntity : UsrTourOfferFolder
	{

		public UsrTourOfferFolder_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTourOfferFolder_Test_workEventsProcess";
			SchemaUId = new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8");
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

	#region Class: UsrTourOfferFolder_Test_workEventsProcess

	/// <exclude/>
	public class UsrTourOfferFolder_Test_workEventsProcess : UsrTourOfferFolder_Test_workEventsProcess<UsrTourOfferFolder>
	{

		public UsrTourOfferFolder_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTourOfferFolder_Test_workEventsProcess

	public partial class UsrTourOfferFolder_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourOfferFolderEventsProcess

	/// <exclude/>
	public class UsrTourOfferFolderEventsProcess : UsrTourOfferFolder_Test_workEventsProcess
	{

		public UsrTourOfferFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

