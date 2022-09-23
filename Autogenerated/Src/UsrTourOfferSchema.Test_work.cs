namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrTourOfferSchema

	/// <exclude/>
	public class UsrTourOfferSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrTourOfferSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourOfferSchema(UsrTourOfferSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourOfferSchema(UsrTourOfferSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b");
			RealUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b");
			Name = "UsrTourOffer";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateUsrNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e48e3e7a-8b22-4e76-9ff8-7e8200028330")) == null) {
				Columns.Add(CreateUsrNotesColumn());
			}
			if (Columns.FindByUId(new Guid("b97dc353-25cc-40aa-a67e-0c781293ea91")) == null) {
				Columns.Add(CreateUsrTourOfferCodeColumn());
			}
			if (Columns.FindByUId(new Guid("aa806138-e3b2-41d0-9be1-2f11f8eb98e6")) == null) {
				Columns.Add(CreateUsrTourOfferFrequencyColumn());
			}
			if (Columns.FindByUId(new Guid("26835724-1db6-40d5-8dc8-62f852e26d55")) == null) {
				Columns.Add(CreateUsrTourOfferEmployeeColumn());
			}
			if (Columns.FindByUId(new Guid("d1174a25-217d-4f37-b2f4-b09d489218b8")) == null) {
				Columns.Add(CreateUsrTourOfferCommentColumn());
			}
			if (Columns.FindByUId(new Guid("0f4aa992-bda1-4eff-848e-817db124cf83")) == null) {
				Columns.Add(CreateUsrTourOfferIsActiveColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4a206a0b-0303-41bf-84e8-8f4efb120c69"),
				Name = @"UsrName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				ModifiedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e48e3e7a-8b22-4e76-9ff8-7e8200028330"),
				Name = @"UsrNotes",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				ModifiedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourOfferCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b97dc353-25cc-40aa-a67e-0c781293ea91"),
				Name = @"UsrTourOfferCode",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				ModifiedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourOfferFrequencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("aa806138-e3b2-41d0-9be1-2f11f8eb98e6"),
				Name = @"UsrTourOfferFrequency",
				ReferenceSchemaUId = new Guid("d60e3d28-678b-4e12-8e70-d13184457110"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				ModifiedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourOfferEmployeeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("26835724-1db6-40d5-8dc8-62f852e26d55"),
				Name = @"UsrTourOfferEmployee",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				ModifiedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourOfferCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d1174a25-217d-4f37-b2f4-b09d489218b8"),
				Name = @"UsrTourOfferComment",
				CreatedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				ModifiedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourOfferIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0f4aa992-bda1-4eff-848e-817db124cf83"),
				Name = @"UsrTourOfferIsActive",
				CreatedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				ModifiedInSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrTourOffer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTourOffer_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourOfferSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourOfferSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOffer

	/// <summary>
	/// Турпредложения.
	/// </summary>
	public class UsrTourOffer : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrTourOffer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOffer";
		}

		public UsrTourOffer(UsrTourOffer source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Название.
		/// </summary>
		public string UsrName {
			get {
				return GetTypedColumnValue<string>("UsrName");
			}
			set {
				SetColumnValue("UsrName", value);
			}
		}

		/// <summary>
		/// Заметки.
		/// </summary>
		public string UsrNotes {
			get {
				return GetTypedColumnValue<string>("UsrNotes");
			}
			set {
				SetColumnValue("UsrNotes", value);
			}
		}

		/// <summary>
		/// Код.
		/// </summary>
		public string UsrTourOfferCode {
			get {
				return GetTypedColumnValue<string>("UsrTourOfferCode");
			}
			set {
				SetColumnValue("UsrTourOfferCode", value);
			}
		}

		/// <exclude/>
		public Guid UsrTourOfferFrequencyId {
			get {
				return GetTypedColumnValue<Guid>("UsrTourOfferFrequencyId");
			}
			set {
				SetColumnValue("UsrTourOfferFrequencyId", value);
				_usrTourOfferFrequency = null;
			}
		}

		/// <exclude/>
		public string UsrTourOfferFrequencyName {
			get {
				return GetTypedColumnValue<string>("UsrTourOfferFrequencyName");
			}
			set {
				SetColumnValue("UsrTourOfferFrequencyName", value);
				if (_usrTourOfferFrequency != null) {
					_usrTourOfferFrequency.Name = value;
				}
			}
		}

		private UsrFrequencyList _usrTourOfferFrequency;
		/// <summary>
		/// Переодичность.
		/// </summary>
		public UsrFrequencyList UsrTourOfferFrequency {
			get {
				return _usrTourOfferFrequency ??
					(_usrTourOfferFrequency = LookupColumnEntities.GetEntity("UsrTourOfferFrequency") as UsrFrequencyList);
			}
		}

		/// <exclude/>
		public Guid UsrTourOfferEmployeeId {
			get {
				return GetTypedColumnValue<Guid>("UsrTourOfferEmployeeId");
			}
			set {
				SetColumnValue("UsrTourOfferEmployeeId", value);
				_usrTourOfferEmployee = null;
			}
		}

		/// <exclude/>
		public string UsrTourOfferEmployeeName {
			get {
				return GetTypedColumnValue<string>("UsrTourOfferEmployeeName");
			}
			set {
				SetColumnValue("UsrTourOfferEmployeeName", value);
				if (_usrTourOfferEmployee != null) {
					_usrTourOfferEmployee.Name = value;
				}
			}
		}

		private Contact _usrTourOfferEmployee;
		/// <summary>
		/// Ответственный.
		/// </summary>
		public Contact UsrTourOfferEmployee {
			get {
				return _usrTourOfferEmployee ??
					(_usrTourOfferEmployee = LookupColumnEntities.GetEntity("UsrTourOfferEmployee") as Contact);
			}
		}

		/// <summary>
		/// Комментарий.
		/// </summary>
		public string UsrTourOfferComment {
			get {
				return GetTypedColumnValue<string>("UsrTourOfferComment");
			}
			set {
				SetColumnValue("UsrTourOfferComment", value);
			}
		}

		/// <summary>
		/// Активно.
		/// </summary>
		public bool UsrTourOfferIsActive {
			get {
				return GetTypedColumnValue<bool>("UsrTourOfferIsActive");
			}
			set {
				SetColumnValue("UsrTourOfferIsActive", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTourOffer_Test_workEventsProcess(UserConnection);
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
			return new UsrTourOffer(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTourOffer_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTourOffer_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrTourOffer
	{

		public UsrTourOffer_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTourOffer_Test_workEventsProcess";
			SchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b");
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

	#region Class: UsrTourOffer_Test_workEventsProcess

	/// <exclude/>
	public class UsrTourOffer_Test_workEventsProcess : UsrTourOffer_Test_workEventsProcess<UsrTourOffer>
	{

		public UsrTourOffer_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTourOffer_Test_workEventsProcess

	public partial class UsrTourOffer_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourOfferEventsProcess

	/// <exclude/>
	public class UsrTourOfferEventsProcess : UsrTourOffer_Test_workEventsProcess
	{

		public UsrTourOfferEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

