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

	#region Class: UsrTourOfferTagSchema

	/// <exclude/>
	public class UsrTourOfferTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public UsrTourOfferTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourOfferTagSchema(UsrTourOfferTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourOfferTagSchema(UsrTourOfferTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a649142e-7a47-4913-90ec-44f93805c2eb");
			RealUId = new Guid("a649142e-7a47-4913-90ec-44f93805c2eb");
			Name = "UsrTourOfferTag";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
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
			return new UsrTourOfferTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTourOfferTag_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourOfferTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourOfferTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a649142e-7a47-4913-90ec-44f93805c2eb"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferTag

	/// <summary>
	/// Тег раздела Турпредложения.
	/// </summary>
	public class UsrTourOfferTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public UsrTourOfferTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOfferTag";
		}

		public UsrTourOfferTag(UsrTourOfferTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTourOfferTag_Test_workEventsProcess(UserConnection);
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
			return new UsrTourOfferTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOfferTag_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTourOfferTag_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : UsrTourOfferTag
	{

		public UsrTourOfferTag_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTourOfferTag_Test_workEventsProcess";
			SchemaUId = new Guid("a649142e-7a47-4913-90ec-44f93805c2eb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a649142e-7a47-4913-90ec-44f93805c2eb");
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

	#region Class: UsrTourOfferTag_Test_workEventsProcess

	/// <exclude/>
	public class UsrTourOfferTag_Test_workEventsProcess : UsrTourOfferTag_Test_workEventsProcess<UsrTourOfferTag>
	{

		public UsrTourOfferTag_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTourOfferTag_Test_workEventsProcess

	public partial class UsrTourOfferTag_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourOfferTagEventsProcess

	/// <exclude/>
	public class UsrTourOfferTagEventsProcess : UsrTourOfferTag_Test_workEventsProcess
	{

		public UsrTourOfferTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

