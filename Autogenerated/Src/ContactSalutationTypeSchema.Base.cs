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

	#region Class: ContactSalutationType_Base_TerrasoftSchema

	/// <exclude/>
	public class ContactSalutationType_Base_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ContactSalutationType_Base_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactSalutationType_Base_TerrasoftSchema(ContactSalutationType_Base_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactSalutationType_Base_TerrasoftSchema(ContactSalutationType_Base_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
			RealUId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
			Name = "ContactSalutationType_Base_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
			return new ContactSalutationType_Base_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactSalutationType_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactSalutationType_Base_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactSalutationType_Base_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactSalutationType_Base_Terrasoft

	/// <summary>
	/// Contact title.
	/// </summary>
	public class ContactSalutationType_Base_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ContactSalutationType_Base_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactSalutationType_Base_Terrasoft";
		}

		public ContactSalutationType_Base_Terrasoft(ContactSalutationType_Base_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactSalutationType_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactSalutationType_Base_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactSalutationType_Base_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ContactSalutationType_Base_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ContactSalutationType_Base_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ContactSalutationType_Base_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ContactSalutationType_Base_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ContactSalutationType_Base_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactSalutationType_Base_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactSalutationType_BaseEventsProcess

	/// <exclude/>
	public partial class ContactSalutationType_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : ContactSalutationType_Base_Terrasoft
	{

		public ContactSalutationType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactSalutationType_BaseEventsProcess";
			SchemaUId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847");
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

	#region Class: ContactSalutationType_BaseEventsProcess

	/// <exclude/>
	public class ContactSalutationType_BaseEventsProcess : ContactSalutationType_BaseEventsProcess<ContactSalutationType_Base_Terrasoft>
	{

		public ContactSalutationType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactSalutationType_BaseEventsProcess

	public partial class ContactSalutationType_BaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

