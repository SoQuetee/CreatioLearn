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

	#region Class: MkpInstalledAppNewsSchema

	/// <exclude/>
	public class MkpInstalledAppNewsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MkpInstalledAppNewsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MkpInstalledAppNewsSchema(MkpInstalledAppNewsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MkpInstalledAppNewsSchema(MkpInstalledAppNewsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			RealUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			Name = "MkpInstalledAppNews";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3364ce9a-4a9f-4dbc-81be-9558a29167cf");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("698996e3-5a2e-4378-bfe3-28393053fc92")) == null) {
				Columns.Add(CreateMkpNotesColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			return column;
		}

		protected virtual EntitySchemaColumn CreateMkpNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("698996e3-5a2e-4378-bfe3-28393053fc92"),
				Name = @"MkpNotes",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53"),
				ModifiedInSchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53"),
				CreatedInPackageId = new Guid("42204ac4-9e89-423e-9f95-836c2df050a9")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MkpInstalledAppNews(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MkpInstalledAppNews_MkpNotificationsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MkpInstalledAppNewsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MkpInstalledAppNewsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53"));
		}

		#endregion

	}

	#endregion

	#region Class: MkpInstalledAppNews

	/// <summary>
	/// Installed app news.
	/// </summary>
	public class MkpInstalledAppNews : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MkpInstalledAppNews(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MkpInstalledAppNews";
		}

		public MkpInstalledAppNews(MkpInstalledAppNews source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Notes.
		/// </summary>
		public string MkpNotes {
			get {
				return GetTypedColumnValue<string>("MkpNotes");
			}
			set {
				SetColumnValue("MkpNotes", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MkpInstalledAppNews_MkpNotificationsEventsProcess(UserConnection);
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
			return new MkpInstalledAppNews(this);
		}

		#endregion

	}

	#endregion

	#region Class: MkpInstalledAppNews_MkpNotificationsEventsProcess

	/// <exclude/>
	public partial class MkpInstalledAppNews_MkpNotificationsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : MkpInstalledAppNews
	{

		public MkpInstalledAppNews_MkpNotificationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MkpInstalledAppNews_MkpNotificationsEventsProcess";
			SchemaUId = new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0c92974f-4dbe-4990-968e-3d1fa1719a53");
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

	#region Class: MkpInstalledAppNews_MkpNotificationsEventsProcess

	/// <exclude/>
	public class MkpInstalledAppNews_MkpNotificationsEventsProcess : MkpInstalledAppNews_MkpNotificationsEventsProcess<MkpInstalledAppNews>
	{

		public MkpInstalledAppNews_MkpNotificationsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MkpInstalledAppNews_MkpNotificationsEventsProcess

	public partial class MkpInstalledAppNews_MkpNotificationsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: MkpInstalledAppNewsEventsProcess

	/// <exclude/>
	public class MkpInstalledAppNewsEventsProcess : MkpInstalledAppNews_MkpNotificationsEventsProcess
	{

		public MkpInstalledAppNewsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

