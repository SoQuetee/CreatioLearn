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

	#region Class: KnowledgeBase_Portal_TerrasoftSchema

	/// <exclude/>
	public class KnowledgeBase_Portal_TerrasoftSchema : Terrasoft.Configuration.KnowledgeBase_SspKnowledgeBase_TerrasoftSchema
	{

		#region Constructors: Public

		public KnowledgeBase_Portal_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public KnowledgeBase_Portal_TerrasoftSchema(KnowledgeBase_Portal_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public KnowledgeBase_Portal_TerrasoftSchema(KnowledgeBase_Portal_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3f4b5a7e-3599-46f8-b426-2ef29e7fe38f");
			Name = "KnowledgeBase_Portal_Terrasoft";
			ParentSchemaUId = new Guid("0326868c-ce5e-4934-8f1f-178801bfe6c3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("929a7200-398f-4e6f-a56d-d74f21f8bfe0");
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
			return new KnowledgeBase_Portal_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new KnowledgeBase_PortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new KnowledgeBase_Portal_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new KnowledgeBase_Portal_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f4b5a7e-3599-46f8-b426-2ef29e7fe38f"));
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBase_Portal_Terrasoft

	/// <summary>
	/// Knowledge base article.
	/// </summary>
	public class KnowledgeBase_Portal_Terrasoft : Terrasoft.Configuration.KnowledgeBase_SspKnowledgeBase_Terrasoft
	{

		#region Constructors: Public

		public KnowledgeBase_Portal_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "KnowledgeBase_Portal_Terrasoft";
		}

		public KnowledgeBase_Portal_Terrasoft(KnowledgeBase_Portal_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new KnowledgeBase_PortalEventsProcess(UserConnection);
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
			return new KnowledgeBase_Portal_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBase_PortalEventsProcess

	/// <exclude/>
	public partial class KnowledgeBase_PortalEventsProcess<TEntity> : Terrasoft.Configuration.KnowledgeBase_SspKnowledgeBaseEventsProcess<TEntity> where TEntity : KnowledgeBase_Portal_Terrasoft
	{

		public KnowledgeBase_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "KnowledgeBase_PortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3f4b5a7e-3599-46f8-b426-2ef29e7fe38f");
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

	#region Class: KnowledgeBase_PortalEventsProcess

	/// <exclude/>
	public class KnowledgeBase_PortalEventsProcess : KnowledgeBase_PortalEventsProcess<KnowledgeBase_Portal_Terrasoft>
	{

		public KnowledgeBase_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: KnowledgeBase_PortalEventsProcess

	public partial class KnowledgeBase_PortalEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion

}

