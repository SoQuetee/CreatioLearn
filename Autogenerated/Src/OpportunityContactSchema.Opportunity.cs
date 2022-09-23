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

	#region Class: OpportunityContact_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityContact_Opportunity_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OpportunityContact_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityContact_Opportunity_TerrasoftSchema(OpportunityContact_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityContact_Opportunity_TerrasoftSchema(OpportunityContact_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			RealUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			Name = "OpportunityContact_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("545b14da-ca86-4a72-a58f-5daf3a0bbfd0")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
			if (Columns.FindByUId(new Guid("a628d3aa-7961-4943-886b-136561ddcc96")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("5c06b2ae-7c74-4fda-8952-b73989325268")) == null) {
				Columns.Add(CreateIsMainContactColumn());
			}
			if (Columns.FindByUId(new Guid("194ac7b8-2f54-4e80-b2c1-549d893f7670")) == null) {
				Columns.Add(CreateRoleColumn());
			}
			if (Columns.FindByUId(new Guid("464956de-fea2-414d-9c41-a61dbd542143")) == null) {
				Columns.Add(CreateInfluenceColumn());
			}
			if (Columns.FindByUId(new Guid("97bbbefb-b020-4887-9b6d-cf385d972a85")) == null) {
				Columns.Add(CreateContactMotivatorColumn());
			}
			if (Columns.FindByUId(new Guid("1d8a938b-f6aa-4459-b848-eb438f52d6b0")) == null) {
				Columns.Add(CreateContactLoyalityColumn());
			}
			if (Columns.FindByUId(new Guid("398febc8-14db-4f88-80f4-485ca96465ff")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			column.CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("545b14da-ca86-4a72-a58f-5daf3a0bbfd0"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a628d3aa-7961-4943-886b-136561ddcc96"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateIsMainContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5c06b2ae-7c74-4fda-8952-b73989325268"),
				Name = @"IsMainContact",
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("194ac7b8-2f54-4e80-b2c1-549d893f7670"),
				Name = @"Role",
				ReferenceSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateInfluenceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("464956de-fea2-414d-9c41-a61dbd542143"),
				Name = @"Influence",
				ReferenceSchemaUId = new Guid("e0aa5fa2-0910-478d-943b-e9c2579ad7b4"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateContactMotivatorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("97bbbefb-b020-4887-9b6d-cf385d972a85"),
				Name = @"ContactMotivator",
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateContactLoyalityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1d8a938b-f6aa-4459-b848-eb438f52d6b0"),
				Name = @"ContactLoyality",
				ReferenceSchemaUId = new Guid("90a3e9f6-12d4-45b5-9122-7c4aadb41f28"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("398febc8-14db-4f88-80f4-485ca96465ff"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				ModifiedInSchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityContact_Opportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityContact_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityContact_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityContact_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_Opportunity_Terrasoft

	/// <summary>
	/// Contact in opportunity.
	/// </summary>
	public class OpportunityContact_Opportunity_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OpportunityContact_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityContact_Opportunity_Terrasoft";
		}

		public OpportunityContact_Opportunity_Terrasoft(OpportunityContact_Opportunity_Terrasoft source)
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

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Primary contact.
		/// </summary>
		public bool IsMainContact {
			get {
				return GetTypedColumnValue<bool>("IsMainContact");
			}
			set {
				SetColumnValue("IsMainContact", value);
			}
		}

		/// <exclude/>
		public Guid RoleId {
			get {
				return GetTypedColumnValue<Guid>("RoleId");
			}
			set {
				SetColumnValue("RoleId", value);
				_role = null;
			}
		}

		/// <exclude/>
		public string RoleName {
			get {
				return GetTypedColumnValue<string>("RoleName");
			}
			set {
				SetColumnValue("RoleName", value);
				if (_role != null) {
					_role.Name = value;
				}
			}
		}

		private OppContactRole _role;
		/// <summary>
		/// Role.
		/// </summary>
		public OppContactRole Role {
			get {
				return _role ??
					(_role = LookupColumnEntities.GetEntity("Role") as OppContactRole);
			}
		}

		/// <exclude/>
		public Guid InfluenceId {
			get {
				return GetTypedColumnValue<Guid>("InfluenceId");
			}
			set {
				SetColumnValue("InfluenceId", value);
				_influence = null;
			}
		}

		/// <exclude/>
		public string InfluenceName {
			get {
				return GetTypedColumnValue<string>("InfluenceName");
			}
			set {
				SetColumnValue("InfluenceName", value);
				if (_influence != null) {
					_influence.Name = value;
				}
			}
		}

		private OppContactInfluence _influence;
		/// <summary>
		/// Influence.
		/// </summary>
		public OppContactInfluence Influence {
			get {
				return _influence ??
					(_influence = LookupColumnEntities.GetEntity("Influence") as OppContactInfluence);
			}
		}

		/// <summary>
		/// Decision-making factors.
		/// </summary>
		public string ContactMotivator {
			get {
				return GetTypedColumnValue<string>("ContactMotivator");
			}
			set {
				SetColumnValue("ContactMotivator", value);
			}
		}

		/// <exclude/>
		public Guid ContactLoyalityId {
			get {
				return GetTypedColumnValue<Guid>("ContactLoyalityId");
			}
			set {
				SetColumnValue("ContactLoyalityId", value);
				_contactLoyality = null;
			}
		}

		/// <exclude/>
		public string ContactLoyalityName {
			get {
				return GetTypedColumnValue<string>("ContactLoyalityName");
			}
			set {
				SetColumnValue("ContactLoyalityName", value);
				if (_contactLoyality != null) {
					_contactLoyality.Name = value;
				}
			}
		}

		private OppContactLoyality _contactLoyality;
		/// <summary>
		/// Loyalty.
		/// </summary>
		public OppContactLoyality ContactLoyality {
			get {
				return _contactLoyality ??
					(_contactLoyality = LookupColumnEntities.GetEntity("ContactLoyality") as OppContactLoyality);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityContact_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityContact_Opportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityContact_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityContact_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : OpportunityContact_Opportunity_Terrasoft
	{

		public OpportunityContact_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityContact_OpportunityEventsProcess";
			SchemaUId = new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fa274f3d-57a3-44ee-b644-d93441a31de2");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("efd04b81-7add-47cf-9e96-3c955826b02a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageOpportunityContactSaving;
		public ProcessFlowElement StartMessageOpportunityContactSaving {
			get {
				return _startMessageOpportunityContactSaving ?? (_startMessageOpportunityContactSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageOpportunityContactSaving",
					SchemaElementUId = new Guid("5c9b116b-ee58-42d3-a3bf-e5dafe70b539"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOpportunityContactSaving;
		public ProcessScriptTask ScriptOpportunityContactSaving {
			get {
				return _scriptOpportunityContactSaving ?? (_scriptOpportunityContactSaving = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOpportunityContactSaving",
					SchemaElementUId = new Guid("2811d4d4-b788-4dc8-b353-fa8538be439b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOpportunityContactSavingExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("e6b995b5-d3ad-49a3-b1cc-1e7179375166"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _opportunityContactSaved;
		public ProcessFlowElement OpportunityContactSaved {
			get {
				return _opportunityContactSaved ?? (_opportunityContactSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OpportunityContactSaved",
					SchemaElementUId = new Guid("d112f396-bd6c-4757-8f0c-09f6c22f9ae0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateRemindings;
		public ProcessScriptTask UpdateRemindings {
			get {
				return _updateRemindings ?? (_updateRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateRemindings",
					SchemaElementUId = new Guid("3f9a2eb3-b79e-4ffb-bf95-203818f9e310"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessageOpportunityContactSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageOpportunityContactSaving };
			FlowElements[ScriptOpportunityContactSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOpportunityContactSaving };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OpportunityContactSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { OpportunityContactSaved };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessageOpportunityContactSaving":
						e.Context.QueueTasks.Enqueue("ScriptOpportunityContactSaving");
						break;
					case "ScriptOpportunityContactSaving":
						break;
					case "EventSubProcess2":
						break;
					case "OpportunityContactSaved":
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "UpdateRemindings":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageOpportunityContactSaving");
			ActivatedEventElements.Add("OpportunityContactSaved");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageOpportunityContactSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageOpportunityContactSaving";
					result = StartMessageOpportunityContactSaving.Execute(context);
					break;
				case "ScriptOpportunityContactSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOpportunityContactSaving";
					result = ScriptOpportunityContactSaving.Execute(context, ScriptOpportunityContactSavingExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OpportunityContactSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpportunityContactSaved";
					result = OpportunityContactSaved.Execute(context);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptOpportunityContactSavingExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			Guid id = Entity.GetTypedColumnValue<Guid>("OpportunityId");
			OpportunityAnniversaryReminding remindingsGenerator = new OpportunityAnniversaryReminding(UserConnection, id);
			remindingsGenerator.GenerateActualRemindings();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "OpportunityContact_Opportunity_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessageOpportunityContactSaving")) {
							context.QueueTasks.Enqueue("StartMessageOpportunityContactSaving");
						}
						break;
					case "OpportunityContact_Opportunity_TerrasoftSaved":
							if (ActivatedEventElements.Contains("OpportunityContactSaved")) {
							context.QueueTasks.Enqueue("OpportunityContactSaved");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityContact_OpportunityEventsProcess : OpportunityContact_OpportunityEventsProcess<OpportunityContact_Opportunity_Terrasoft>
	{

		public OpportunityContact_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityContact_OpportunityEventsProcess

	public partial class OpportunityContact_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

