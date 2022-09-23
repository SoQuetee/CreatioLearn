namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTour

	/// <exclude/>
	public class UsrTour : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrTour(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTour";
		}

		public UsrTour(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrTour";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Дата создания.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Создал.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Дата изменения.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Изменил.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Активные процессы.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

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
					(_usrTourOffers = new UsrTourOffer(LookupColumnEntities.GetEntity("UsrTourOffers")));
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
					(_usrTourEmployee = new Contact(LookupColumnEntities.GetEntity("UsrTourEmployee")));
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
					(_usrTourStatus = new UsrTourStatusList(LookupColumnEntities.GetEntity("UsrTourStatus")));
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

	}

	#endregion

}

