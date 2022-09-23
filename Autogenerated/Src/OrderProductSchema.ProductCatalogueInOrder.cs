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

	#region Class: OrderProduct_ProductCatalogueInOrder_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_ProductCatalogueInOrder_TerrasoftSchema : Terrasoft.Configuration.OrderProduct_Order_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(OrderProduct_ProductCatalogueInOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(OrderProduct_ProductCatalogueInOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6a489998-7f84-4171-815d-5894a5826838");
			Name = "OrderProduct_ProductCatalogueInOrder_Terrasoft";
			ParentSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreatePriceListColumn() {
			EntitySchemaColumn column = base.CreatePriceListColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"fa689c95-c63c-4908-8fd2-19a95e0425bd"
			};
			column.ModifiedInSchemaUId = new Guid("6a489998-7f84-4171-815d-5894a5826838");
			column.CreatedInPackageId = new Guid("205fe81c-724a-4cdd-84e3-8959f298b37c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderProduct_ProductCatalogueInOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_ProductCatalogueInOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_ProductCatalogueInOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a489998-7f84-4171-815d-5894a5826838"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_ProductCatalogueInOrder_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_ProductCatalogueInOrder_Terrasoft : Terrasoft.Configuration.OrderProduct_Order_Terrasoft
	{

		#region Constructors: Public

		public OrderProduct_ProductCatalogueInOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_ProductCatalogueInOrder_Terrasoft";
		}

		public OrderProduct_ProductCatalogueInOrder_Terrasoft(OrderProduct_ProductCatalogueInOrder_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_ProductCatalogueInOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("OrderProduct_ProductCatalogueInOrder_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("OrderProduct_ProductCatalogueInOrder_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_ProductCatalogueInOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_ProductCatalogueInOrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_ProductCatalogueInOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderProduct_OrderEventsProcess<TEntity> where TEntity : OrderProduct_ProductCatalogueInOrder_Terrasoft
	{

		public OrderProduct_ProductCatalogueInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_ProductCatalogueInOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6a489998-7f84-4171-815d-5894a5826838");
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

	#region Class: OrderProduct_ProductCatalogueInOrderEventsProcess

	/// <exclude/>
	public class OrderProduct_ProductCatalogueInOrderEventsProcess : OrderProduct_ProductCatalogueInOrderEventsProcess<OrderProduct_ProductCatalogueInOrder_Terrasoft>
	{

		public OrderProduct_ProductCatalogueInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderProduct_ProductCatalogueInOrderEventsProcess

	public partial class OrderProduct_ProductCatalogueInOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void UpdatePrimaryAmounts() {
			if (NeedRecalcPrimaryValues){
				base.UpdatePrimaryAmounts();
			}
		}

		#endregion

	}

	#endregion

}

