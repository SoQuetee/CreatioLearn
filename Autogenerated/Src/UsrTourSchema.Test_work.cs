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

	#region Class: UsrTourSchema

	/// <exclude/>
	public class UsrTourSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrTourSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrTourSchema(UsrTourSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrTourSchema(UsrTourSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381");
			RealUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381");
			Name = "UsrTour";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6444538f-f921-45bc-b53c-cbbe0e09d243")) == null) {
				Columns.Add(CreateUsrTourOffersColumn());
			}
			if (Columns.FindByUId(new Guid("74f06af7-feb8-484e-b3c1-e8bb65a26066")) == null) {
				Columns.Add(CreateUsrTourDateColumn());
			}
			if (Columns.FindByUId(new Guid("e5ece8f5-7b9f-4a2e-b72c-edee340df35a")) == null) {
				Columns.Add(CreateUsrTourEmployeeColumn());
			}
			if (Columns.FindByUId(new Guid("d15268d4-d92e-4bc4-9382-12016c54842a")) == null) {
				Columns.Add(CreateUsrTourPeopleCountColumn());
			}
			if (Columns.FindByUId(new Guid("a3623832-0529-4a60-b69d-4df7040a02b5")) == null) {
				Columns.Add(CreateUsrTourStatusColumn());
			}
			if (Columns.FindByUId(new Guid("c694ee17-a3aa-4932-aba9-e412096e5cb9")) == null) {
				Columns.Add(CreateUsrTourPriceColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrTourOffersColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6444538f-f921-45bc-b53c-cbbe0e09d243"),
				Name = @"UsrTourOffers",
				ReferenceSchemaUId = new Guid("4f981b09-8fe3-42fa-b481-89c0867d8f6b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				ModifiedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("74f06af7-feb8-484e-b3c1-e8bb65a26066"),
				Name = @"UsrTourDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				ModifiedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourEmployeeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e5ece8f5-7b9f-4a2e-b72c-edee340df35a"),
				Name = @"UsrTourEmployee",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				ModifiedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourPeopleCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d15268d4-d92e-4bc4-9382-12016c54842a"),
				Name = @"UsrTourPeopleCount",
				CreatedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				ModifiedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3623832-0529-4a60-b69d-4df7040a02b5"),
				Name = @"UsrTourStatus",
				ReferenceSchemaUId = new Guid("140901a2-2d07-4202-85d5-a0ab4f91d779"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				ModifiedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTourPriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("c694ee17-a3aa-4932-aba9-e412096e5cb9"),
				Name = @"UsrTourPrice",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
				ModifiedInSchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"),
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
			return new UsrTour(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrTour_Test_workEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrTourSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrTourSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e073961-9c7f-415f-91f8-141ad68c6381"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrTour

	/// <summary>
	/// Тур.
	/// </summary>
	public class UsrTour : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrTour(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTour";
		}

		public UsrTour(UsrTour source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid UsrTourOffersId {
			get {
				return GetTypedColumnValue<Guid>("UsrTourOffersId");
			}
			set {
				SetColumnValue("UsrTourOffersId", value);
				_usrTourOffers = null;
			}
		}

		/// <exclude/>
		public string UsrTourOffersUsrName {
			get {
				return GetTypedColumnValue<string>("UsrTourOffersUsrName");
			}
			set {
				SetColumnValue("UsrTourOffersUsrName", value);
				if (_usrTourOffers != null) {
					_usrTourOffers.UsrName = value;
				}
			}
		}

		private UsrTourOffer _usrTourOffers;
		/// <summary>
		/// Турпредложение.
		/// </summary>
		public UsrTourOffer UsrTourOffers {
			get {
				return _usrTourOffers ??
					(_usrTourOffers = LookupColumnEntities.GetEntity("UsrTourOffers") as UsrTourOffer);
			}
		}

		/// <summary>
		/// Дата тура.
		/// </summary>
		public DateTime UsrTourDate {
			get {
				return GetTypedColumnValue<DateTime>("UsrTourDate");
			}
			set {
				SetColumnValue("UsrTourDate", value);
			}
		}

		/// <exclude/>
		public Guid UsrTourEmployeeId {
			get {
				return GetTypedColumnValue<Guid>("UsrTourEmployeeId");
			}
			set {
				SetColumnValue("UsrTourEmployeeId", value);
				_usrTourEmployee = null;
			}
		}

		/// <exclude/>
		public string UsrTourEmployeeName {
			get {
				return GetTypedColumnValue<string>("UsrTourEmployeeName");
			}
			set {
				SetColumnValue("UsrTourEmployeeName", value);
				if (_usrTourEmployee != null) {
					_usrTourEmployee.Name = value;
				}
			}
		}

		private Contact _usrTourEmployee;
		/// <summary>
		/// Менеджер.
		/// </summary>
		public Contact UsrTourEmployee {
			get {
				return _usrTourEmployee ??
					(_usrTourEmployee = LookupColumnEntities.GetEntity("UsrTourEmployee") as Contact);
			}
		}

		/// <summary>
		/// Число туристов.
		/// </summary>
		public int UsrTourPeopleCount {
			get {
				return GetTypedColumnValue<int>("UsrTourPeopleCount");
			}
			set {
				SetColumnValue("UsrTourPeopleCount", value);
			}
		}

		/// <exclude/>
		public Guid UsrTourStatusId {
			get {
				return GetTypedColumnValue<Guid>("UsrTourStatusId");
			}
			set {
				SetColumnValue("UsrTourStatusId", value);
				_usrTourStatus = null;
			}
		}

		/// <exclude/>
		public string UsrTourStatusName {
			get {
				return GetTypedColumnValue<string>("UsrTourStatusName");
			}
			set {
				SetColumnValue("UsrTourStatusName", value);
				if (_usrTourStatus != null) {
					_usrTourStatus.Name = value;
				}
			}
		}

		private UsrTourStatusList _usrTourStatus;
		/// <summary>
		/// Состояние тура.
		/// </summary>
		public UsrTourStatusList UsrTourStatus {
			get {
				return _usrTourStatus ??
					(_usrTourStatus = LookupColumnEntities.GetEntity("UsrTourStatus") as UsrTourStatusList);
			}
		}

		/// <summary>
		/// Стоимость.
		/// </summary>
		public Decimal UsrTourPrice {
			get {
				return GetTypedColumnValue<Decimal>("UsrTourPrice");
			}
			set {
				SetColumnValue("UsrTourPrice", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrTour_Test_workEventsProcess(UserConnection);
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
			return new UsrTour(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrTour_Test_workEventsProcess

	/// <exclude/>
	public partial class UsrTour_Test_workEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrTour
	{

		public UsrTour_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrTour_Test_workEventsProcess";
			SchemaUId = new Guid("7e073961-9c7f-415f-91f8-141ad68c6381");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7e073961-9c7f-415f-91f8-141ad68c6381");
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

	#region Class: UsrTour_Test_workEventsProcess

	/// <exclude/>
	public class UsrTour_Test_workEventsProcess : UsrTour_Test_workEventsProcess<UsrTour>
	{

		public UsrTour_Test_workEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrTour_Test_workEventsProcess

	public partial class UsrTour_Test_workEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrTourEventsProcess

	/// <exclude/>
	public class UsrTourEventsProcess : UsrTour_Test_workEventsProcess
	{

		public UsrTourEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

