﻿namespace Terrasoft.Configuration
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

	#region Class: VwDocumentProductSchema

	/// <exclude/>
	public class VwDocumentProductSchema : Terrasoft.Configuration.DocumentProductSchema
	{

		#region Constructors: Public

		public VwDocumentProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwDocumentProductSchema(VwDocumentProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwDocumentProductSchema(VwDocumentProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("433b2766-3e50-4a84-8977-756332b583c9");
			RealUId = new Guid("433b2766-3e50-4a84-8977-756332b583c9");
			Name = "VwDocumentProduct";
			ParentSchemaUId = new Guid("5bab82ce-a828-4259-8ed9-5416ea3a0113");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
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
			return new VwDocumentProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwDocumentProduct_DocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwDocumentProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwDocumentProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("433b2766-3e50-4a84-8977-756332b583c9"));
		}

		#endregion

	}

	#endregion

	#region Class: VwDocumentProduct

	/// <summary>
	/// Product in document (view).
	/// </summary>
	public class VwDocumentProduct : Terrasoft.Configuration.DocumentProduct
	{

		#region Constructors: Public

		public VwDocumentProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwDocumentProduct";
		}

		public VwDocumentProduct(VwDocumentProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwDocumentProduct_DocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("VwDocumentProductDeleting", e);
			Inserted += (s, e) => ThrowEvent("VwDocumentProductInserted", e);
			Inserting += (s, e) => ThrowEvent("VwDocumentProductInserting", e);
			Saving += (s, e) => ThrowEvent("VwDocumentProductSaving", e);
			Validating += (s, e) => ThrowEvent("VwDocumentProductValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwDocumentProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwDocumentProduct_DocumentEventsProcess

	/// <exclude/>
	public partial class VwDocumentProduct_DocumentEventsProcess<TEntity> : Terrasoft.Configuration.DocumentProduct_DocumentEventsProcess<TEntity> where TEntity : VwDocumentProduct
	{

		public VwDocumentProduct_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwDocumentProduct_DocumentEventsProcess";
			SchemaUId = new Guid("433b2766-3e50-4a84-8977-756332b583c9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("433b2766-3e50-4a84-8977-756332b583c9");
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

	#region Class: VwDocumentProduct_DocumentEventsProcess

	/// <exclude/>
	public class VwDocumentProduct_DocumentEventsProcess : VwDocumentProduct_DocumentEventsProcess<VwDocumentProduct>
	{

		public VwDocumentProduct_DocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwDocumentProduct_DocumentEventsProcess

	public partial class VwDocumentProduct_DocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwDocumentProductEventsProcess

	/// <exclude/>
	public class VwDocumentProductEventsProcess : VwDocumentProduct_DocumentEventsProcess
	{

		public VwDocumentProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

