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

	#region Class: UsrTourOfferInTagSchema

	/// <exclude/>
	public class UsrTourOfferInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public UsrTourOfferInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourOfferInTagSchema(UsrTourOfferInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourOfferInTagSchema(UsrTourOfferInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("881b3ad8-53cc-49e4-a8c8-88fc141383a0");
			RealUId = new Guid("881b3ad8-53cc-49e4-a8c8-88fc141383a0");
			Name = "UsrTourOfferInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
			ExtendParent = false;
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("a649142e-7a47-4913-90ec-44f93805c2eb");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("881b3ad8-53cc-49e4-a8c8-88fc141383a0");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityUsrName";
			column.ModifiedInSchemaUId = new Guid("881b3ad8-53cc-49e4-a8c8-88fc141383a0");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrTourOfferInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTourOfferInTag_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourOfferInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourOfferInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("881b3ad8-53cc-49e4-a8c8-88fc141383a0"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferInTag

	/// <summary>
	/// Тег в записи раздела Турпредложения.
	/// </summary>
	public class UsrTourOfferInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public UsrTourOfferInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOfferInTag";
		}

		public UsrTourOfferInTag(UsrTourOfferInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTourOfferInTag_Test_workEventsProcess(UserConnection);
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
			return new UsrTourOfferInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferInTag_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTourOfferInTag_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_BaseEventsProcess<TEntity> where TEntity : UsrTourOfferInTag
	{

		public UsrTourOfferInTag_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTourOfferInTag_Test_workEventsProcess";
			SchemaUId = new Guid("881b3ad8-53cc-49e4-a8c8-88fc141383a0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("881b3ad8-53cc-49e4-a8c8-88fc141383a0");
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

	#region Class: UsrTourOfferInTag_Test_workEventsProcess

	/// <exclude/>
	public class UsrTourOfferInTag_Test_workEventsProcess : UsrTourOfferInTag_Test_workEventsProcess<UsrTourOfferInTag>
	{

		public UsrTourOfferInTag_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTourOfferInTag_Test_workEventsProcess

	public partial class UsrTourOfferInTag_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourOfferInTagEventsProcess

	/// <exclude/>
	public class UsrTourOfferInTagEventsProcess : UsrTourOfferInTag_Test_workEventsProcess
	{

		public UsrTourOfferInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

