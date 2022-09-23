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

	#region Class: UsrTourOfferFileSchema

	/// <exclude/>
	public class UsrTourOfferFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public UsrTourOfferFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourOfferFileSchema(UsrTourOfferFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourOfferFileSchema(UsrTourOfferFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3ec8d7c2-1df5-46fc-a9f6-dea6bbb09648");
			RealUId = new Guid("3ec8d7c2-1df5-46fc-a9f6-dea6bbb09648");
			Name = "UsrTourOfferFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8adaab5a-18f9-479e-af14-6c1caeabf85d")) == null) {
				Columns.Add(CreateUsrTourOfferColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrTourOfferColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8adaab5a-18f9-479e-af14-6c1caeabf85d"),
				Name = @"UsrTourOffer",
				ReferenceSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("3ec8d7c2-1df5-46fc-a9f6-dea6bbb09648"),
				ModifiedInSchemaUId = new Guid("3ec8d7c2-1df5-46fc-a9f6-dea6bbb09648"),
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
			return new UsrTourOfferFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTourOfferFile_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourOfferFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourOfferFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3ec8d7c2-1df5-46fc-a9f6-dea6bbb09648"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferFile

	/// <summary>
	/// Файл и ссылка объекта Турпредложения.
	/// </summary>
	public class UsrTourOfferFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public UsrTourOfferFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOfferFile";
		}

		public UsrTourOfferFile(UsrTourOfferFile source)
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
			var process = new UsrTourOfferFile_Test_workEventsProcess(UserConnection);
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
			return new UsrTourOfferFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferFile_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTourOfferFile_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : UsrTourOfferFile
	{

		public UsrTourOfferFile_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTourOfferFile_Test_workEventsProcess";
			SchemaUId = new Guid("3ec8d7c2-1df5-46fc-a9f6-dea6bbb09648");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3ec8d7c2-1df5-46fc-a9f6-dea6bbb09648");
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

	#region Class: UsrTourOfferFile_Test_workEventsProcess

	/// <exclude/>
	public class UsrTourOfferFile_Test_workEventsProcess : UsrTourOfferFile_Test_workEventsProcess<UsrTourOfferFile>
	{

		public UsrTourOfferFile_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTourOfferFile_Test_workEventsProcess

	public partial class UsrTourOfferFile_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourOfferFileEventsProcess

	/// <exclude/>
	public class UsrTourOfferFileEventsProcess : UsrTourOfferFile_Test_workEventsProcess
	{

		public UsrTourOfferFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

