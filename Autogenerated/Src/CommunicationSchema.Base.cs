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

	#region Class: CommunicationSchema

	/// <exclude/>
	public class CommunicationSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public CommunicationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CommunicationSchema(CommunicationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CommunicationSchema(CommunicationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2875aefb-92b6-4b17-9ef6-22fa306f4c3f");
			RealUId = new Guid("2875aefb-92b6-4b17-9ef6-22fa306f4c3f");
			Name = "Communication";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new Communication(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Communication_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CommunicationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CommunicationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2875aefb-92b6-4b17-9ef6-22fa306f4c3f"));
		}

		#endregion

	}

	#endregion

	#region Class: Communication

	/// <summary>
	/// Type of Communication.
	/// </summary>
	public class Communication : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public Communication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Communication";
		}

		public Communication(Communication source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Communication_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CommunicationDeleted", e);
			Deleting += (s, e) => ThrowEvent("CommunicationDeleting", e);
			Inserted += (s, e) => ThrowEvent("CommunicationInserted", e);
			Inserting += (s, e) => ThrowEvent("CommunicationInserting", e);
			Saved += (s, e) => ThrowEvent("CommunicationSaved", e);
			Saving += (s, e) => ThrowEvent("CommunicationSaving", e);
			Validating += (s, e) => ThrowEvent("CommunicationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Communication(this);
		}

		#endregion

	}

	#endregion

	#region Class: Communication_BaseEventsProcess

	/// <exclude/>
	public partial class Communication_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : Communication
	{

		public Communication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Communication_BaseEventsProcess";
			SchemaUId = new Guid("2875aefb-92b6-4b17-9ef6-22fa306f4c3f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2875aefb-92b6-4b17-9ef6-22fa306f4c3f");
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

	#region Class: Communication_BaseEventsProcess

	/// <exclude/>
	public class Communication_BaseEventsProcess : Communication_BaseEventsProcess<Communication>
	{

		public Communication_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Communication_BaseEventsProcess

	public partial class Communication_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CommunicationEventsProcess

	/// <exclude/>
	public class CommunicationEventsProcess : Communication_BaseEventsProcess
	{

		public CommunicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

