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

	#region Class: CampaignPeriodTimeSchema

	/// <exclude/>
	public class CampaignPeriodTimeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CampaignPeriodTimeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignPeriodTimeSchema(CampaignPeriodTimeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignPeriodTimeSchema(CampaignPeriodTimeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("84f64165-608c-46d4-96f0-fb967878a3c8");
			RealUId = new Guid("84f64165-608c-46d4-96f0-fb967878a3c8");
			Name = "CampaignPeriodTime";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d34b5367-6cd5-4297-b1fa-b11243be4bde");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("af35df79-cb4a-4f39-8166-2de881aed4df")) == null) {
				Columns.Add(CreateTimeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float4")) {
				UId = new Guid("af35df79-cb4a-4f39-8166-2de881aed4df"),
				Name = @"Time",
				CreatedInSchemaUId = new Guid("84f64165-608c-46d4-96f0-fb967878a3c8"),
				ModifiedInSchemaUId = new Guid("84f64165-608c-46d4-96f0-fb967878a3c8"),
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignPeriodTime(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignPeriodTime_CampaignsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignPeriodTimeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignPeriodTimeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("84f64165-608c-46d4-96f0-fb967878a3c8"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignPeriodTime

	/// <summary>
	/// Campaign transition time.
	/// </summary>
	public class CampaignPeriodTime : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CampaignPeriodTime(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignPeriodTime";
		}

		public CampaignPeriodTime(CampaignPeriodTime source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Time.
		/// </summary>
		public Decimal Time {
			get {
				return GetTypedColumnValue<Decimal>("Time");
			}
			set {
				SetColumnValue("Time", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignPeriodTime_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignPeriodTimeDeleted", e);
			Validating += (s, e) => ThrowEvent("CampaignPeriodTimeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignPeriodTime(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignPeriodTime_CampaignsEventsProcess

	/// <exclude/>
	public partial class CampaignPeriodTime_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : CampaignPeriodTime
	{

		public CampaignPeriodTime_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignPeriodTime_CampaignsEventsProcess";
			SchemaUId = new Guid("84f64165-608c-46d4-96f0-fb967878a3c8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("84f64165-608c-46d4-96f0-fb967878a3c8");
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

	#region Class: CampaignPeriodTime_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignPeriodTime_CampaignsEventsProcess : CampaignPeriodTime_CampaignsEventsProcess<CampaignPeriodTime>
	{

		public CampaignPeriodTime_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignPeriodTime_CampaignsEventsProcess

	public partial class CampaignPeriodTime_CampaignsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignPeriodTimeEventsProcess

	/// <exclude/>
	public class CampaignPeriodTimeEventsProcess : CampaignPeriodTime_CampaignsEventsProcess
	{

		public CampaignPeriodTimeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}
