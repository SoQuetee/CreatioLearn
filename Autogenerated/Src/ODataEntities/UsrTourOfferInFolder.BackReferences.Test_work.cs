namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTourOfferInFolder

	/// <exclude/>
	public class UsrTourOfferInFolder : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrTourOfferInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOfferInFolder";
		}

		public UsrTourOfferInFolder(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrTourOfferInFolder";
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

		/// <exclude/>
		public Guid FolderId {
			get {
				return GetTypedColumnValue<Guid>("FolderId");
			}
			set {
				SetColumnValue("FolderId", value);
				_folder = null;
			}
		}

		/// <exclude/>
		public string FolderName {
			get {
				return GetTypedColumnValue<string>("FolderName");
			}
			set {
				SetColumnValue("FolderName", value);
				if (_folder != null) {
					_folder.Name = value;
				}
			}
		}

		private UsrTourOfferFolder _folder;
		/// <summary>
		/// Группа Турпредложения.
		/// </summary>
		public UsrTourOfferFolder Folder {
			get {
				return _folder ??
					(_folder = new UsrTourOfferFolder(LookupColumnEntities.GetEntity("Folder")));
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
		public Guid UsrTourOfferId {
			get {
				return GetTypedColumnValue<Guid>("UsrTourOfferId");
			}
			set {
				SetColumnValue("UsrTourOfferId", value);
				_usrTourOffer = null;
			}
		}

		/// <exclude/>
		public string UsrTourOfferUsrName {
			get {
				return GetTypedColumnValue<string>("UsrTourOfferUsrName");
			}
			set {
				SetColumnValue("UsrTourOfferUsrName", value);
				if (_usrTourOffer != null) {
					_usrTourOffer.UsrName = value;
				}
			}
		}

		private UsrTourOffer _usrTourOffer;
		/// <summary>
		/// Турпредложения.
		/// </summary>
		public UsrTourOffer UsrTourOffer {
			get {
				return _usrTourOffer ??
					(_usrTourOffer = new UsrTourOffer(LookupColumnEntities.GetEntity("UsrTourOffer")));
			}
		}

		#endregion

	}

	#endregion

}

