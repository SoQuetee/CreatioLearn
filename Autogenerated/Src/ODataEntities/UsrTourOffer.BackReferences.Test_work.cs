namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTourOffer

	/// <exclude/>
	public class UsrTourOffer : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrTourOffer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOffer";
		}

		public UsrTourOffer(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrTourOffer";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<UsrTour> UsrTourCollectionByUsrTourOffers {
			get;
			set;
		}

		public IEnumerable<UsrTourOfferFile> UsrTourOfferFileCollectionByUsrTourOffer {
			get;
			set;
		}

		public IEnumerable<UsrTourOfferInFolder> UsrTourOfferInFolderCollectionByUsrTourOffer {
			get;
			set;
		}

		public IEnumerable<UsrTourOfferInTag> UsrTourOfferInTagCollectionByEntity {
			get;
			set;
		}

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
					(_usrTourOfferFrequency = new UsrFrequencyList(LookupColumnEntities.GetEntity("UsrTourOfferFrequency")));
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
					(_usrTourOfferEmployee = new Contact(LookupColumnEntities.GetEntity("UsrTourOfferEmployee")));
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

	}

	#endregion

}

