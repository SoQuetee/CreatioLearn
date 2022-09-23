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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: OrderTag_Order_TerrasoftSchema

	/// <exclude/>
	public class OrderTag_Order_TerrasoftSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public OrderTag_Order_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderTag_Order_TerrasoftSchema(OrderTag_Order_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderTag_Order_TerrasoftSchema(OrderTag_Order_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("765c4500-20c0-452a-9b54-ab5cbb32cf28");
			RealUId = new Guid("765c4500-20c0-452a-9b54-ab5cbb32cf28");
			Name = "OrderTag_Order_Terrasoft";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"8d7f6d6c-4ca5-4b43-bdd9-a5e01a582260"
			};
			column.ModifiedInSchemaUId = new Guid("765c4500-20c0-452a-9b54-ab5cbb32cf28");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderTag_Order_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderTag_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderTag_Order_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderTag_Order_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("765c4500-20c0-452a-9b54-ab5cbb32cf28"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderTag_Order_Terrasoft

	/// <summary>
	/// Orders section tag.
	/// </summary>
	public class OrderTag_Order_Terrasoft : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public OrderTag_Order_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderTag_Order_Terrasoft";
		}

		public OrderTag_Order_Terrasoft(OrderTag_Order_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderTag_OrderEventsProcess(UserConnection);
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
			return new OrderTag_Order_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderTag_OrderEventsProcess

	/// <exclude/>
	public partial class OrderTag_OrderEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : OrderTag_Order_Terrasoft
	{

		public OrderTag_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderTag_OrderEventsProcess";
			SchemaUId = new Guid("765c4500-20c0-452a-9b54-ab5cbb32cf28");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("765c4500-20c0-452a-9b54-ab5cbb32cf28");
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

	#region Class: OrderTag_OrderEventsProcess

	/// <exclude/>
	public class OrderTag_OrderEventsProcess : OrderTag_OrderEventsProcess<OrderTag_Order_Terrasoft>
	{

		public OrderTag_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderTag_OrderEventsProcess

	public partial class OrderTag_OrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

