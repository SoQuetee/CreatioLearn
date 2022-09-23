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

	#region Class: UsrTourOfferInFolderSchema

	/// <exclude/>
	public class UsrTourOfferInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public UsrTourOfferInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourOfferInFolderSchema(UsrTourOfferInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourOfferInFolderSchema(UsrTourOfferInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f");
			RealUId = new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f");
			Name = "UsrTourOfferInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9ffd63cf-8f20-487f-ae42-1ab3ed1482bc")) == null) {
				Columns.Add(CreateUsrTourOfferColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("c83d0c30-d015-4e15-a0aa-36743f4a43a8");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUsrTourOfferColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9ffd63cf-8f20-487f-ae42-1ab3ed1482bc"),
				Name = @"UsrTourOffer",
				ReferenceSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f"),
				ModifiedInSchemaUId = new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrTourOfferInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTourOfferInFolder_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourOfferInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourOfferInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferInFolder

	/// <summary>
	/// Турпредложения в группе.
	/// </summary>
	public class UsrTourOfferInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public UsrTourOfferInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOfferInFolder";
		}

		public UsrTourOfferInFolder(UsrTourOfferInFolder source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid UsrTourOfferId {
			get {
				return GetTypedColumnValue<Guid>("UsrTourOfferId");
			}
			set {
				SetColumnValue("UsrTourOfferId", value);
				_usrTourOffer = null;
			}
		}

		/// <exclude/>
		public string UsrTourOfferUsrName {
			get {
				return GetTypedColumnValue<string>("UsrTourOfferUsrName");
			}
			set {
				SetColumnValue("UsrTourOfferUsrName", value);
				if (_usrTourOffer != null) {
					_usrTourOffer.UsrName = value;
				}
			}
		}

		private UsrTourOffer _usrTourOffer;
		/// <summary>
		/// Турпредложения.
		/// </summary>
		public UsrTourOffer UsrTourOffer {
			get {
				return _usrTourOffer ??
					(_usrTourOffer = LookupColumnEntities.GetEntity("UsrTourOffer") as UsrTourOffer);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTourOfferInFolder_Test_workEventsProcess(UserConnection);
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
			return new UsrTourOfferInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferInFolder_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTourOfferInFolder_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_BaseEventsProcess<TEntity> where TEntity : UsrTourOfferInFolder
	{

		public UsrTourOfferInFolder_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTourOfferInFolder_Test_workEventsProcess";
			SchemaUId = new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a6ef28c0-cd5f-44b6-bb34-f434e5c03b2f");
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

	#region Class: UsrTourOfferInFolder_Test_workEventsProcess

	/// <exclude/>
	public class UsrTourOfferInFolder_Test_workEventsProcess : UsrTourOfferInFolder_Test_workEventsProcess<UsrTourOfferInFolder>
	{

		public UsrTourOfferInFolder_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTourOfferInFolder_Test_workEventsProcess

	public partial class UsrTourOfferInFolder_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourOfferInFolderEventsProcess

	/// <exclude/>
	public class UsrTourOfferInFolderEventsProcess : UsrTourOfferInFolder_Test_workEventsProcess
	{

		public UsrTourOfferInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

