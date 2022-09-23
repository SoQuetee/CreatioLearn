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
	using Terrasoft.Configuration;
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

	#region Class: OrderSchema

	/// <exclude/>
	public class OrderSchema : Terrasoft.Configuration.Order_PRMOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderSchema(OrderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderSchema(OrderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403");
			Name = "Order";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			ExtendParent = true;
			CreatedInPackageId = new Guid("11b832b1-75bb-4c0d-bb5d-5aa5088efe52");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7fe04af6-f7c7-4bb2-8413-b65da9e4f33c")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7fe04af6-f7c7-4bb2-8413-b65da9e4f33c"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403"),
				ModifiedInSchemaUId = new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403"),
				CreatedInPackageId = new Guid("8aa371b9-719f-4904-b382-2e02c0a6ba74")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_OrderInSalesEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403"));
		}

		#endregion

	}

	#endregion

	#region Class: Order

	/// <summary>
	/// Order.
	/// </summary>
	public class Order : Terrasoft.Configuration.Order_PRMOrder_Terrasoft
	{

		#region Constructors: Public

		public Order(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order";
		}

		public Order(Order source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_OrderInSalesEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrderDeleted", e);
			Inserting += (s, e) => ThrowEvent("OrderInserting", e);
			Saved += (s, e) => ThrowEvent("OrderSaved", e);
			Saving += (s, e) => ThrowEvent("OrderSaving", e);
			Validating += (s, e) => ThrowEvent("OrderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Order(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_OrderInSalesEventsProcess

	/// <exclude/>
	public partial class Order_OrderInSalesEventsProcess<TEntity> : Terrasoft.Configuration.Order_PRMOrderEventsProcess<TEntity> where TEntity : Order
	{

		public Order_OrderInSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_OrderInSalesEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("243f55eb-0a8f-4508-a570-c3c2606c3403");
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

	#region Class: Order_OrderInSalesEventsProcess

	/// <exclude/>
	public class Order_OrderInSalesEventsProcess : Order_OrderInSalesEventsProcess<Order>
	{

		public Order_OrderInSalesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_OrderInSalesEventsProcess

	public partial class Order_OrderInSalesEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OrderEventsProcess

	/// <exclude/>
	public class OrderEventsProcess : Order_OrderInSalesEventsProcess
	{

		public OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

