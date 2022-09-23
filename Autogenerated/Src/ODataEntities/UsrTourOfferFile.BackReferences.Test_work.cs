﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: UsrTourOfferFile

	/// <exclude/>
	public class UsrTourOfferFile : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public UsrTourOfferFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrTourOfferFile";
		}

		public UsrTourOfferFile(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "UsrTourOfferFile";
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

		/// <summary>
		/// Название.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Описание.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid LockedById {
			get {
				return GetTypedColumnValue<Guid>("LockedById");
			}
			set {
				SetColumnValue("LockedById", value);
				_lockedBy = null;
			}
		}

		/// <exclude/>
		public string LockedByName {
			get {
				return GetTypedColumnValue<string>("LockedByName");
			}
			set {
				SetColumnValue("LockedByName", value);
				if (_lockedBy != null) {
					_lockedBy.Name = value;
				}
			}
		}

		private Contact _lockedBy;
		/// <summary>
		/// Заблокировал.
		/// </summary>
		public Contact LockedBy {
			get {
				return _lockedBy ??
					(_lockedBy = new Contact(LookupColumnEntities.GetEntity("LockedBy")));
			}
		}

		/// <summary>
		/// Дата блокировки.
		/// </summary>
		public DateTime LockedOn {
			get {
				return GetTypedColumnValue<DateTime>("LockedOn");
			}
			set {
				SetColumnValue("LockedOn", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private FileType _type;
		/// <summary>
		/// Тип.
		/// </summary>
		public FileType Type {
			get {
				return _type ??
					(_type = new FileType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <summary>
		/// Версия.
		/// </summary>
		public int Version {
			get {
				return GetTypedColumnValue<int>("Version");
			}
			set {
				SetColumnValue("Version", value);
			}
		}

		/// <summary>
		/// Размер файла.
		/// </summary>
		public int Size {
			get {
				return GetTypedColumnValue<int>("Size");
			}
			set {
				SetColumnValue("Size", value);
			}
		}

		/// <exclude/>
		public Guid SysFileStorageId {
			get {
				return GetTypedColumnValue<Guid>("SysFileStorageId");
			}
			set {
				SetColumnValue("SysFileStorageId", value);
				_sysFileStorage = null;
			}
		}

		/// <exclude/>
		public string SysFileStorageName {
			get {
				return GetTypedColumnValue<string>("SysFileStorageName");
			}
			set {
				SetColumnValue("SysFileStorageName", value);
				if (_sysFileStorage != null) {
					_sysFileStorage.Name = value;
				}
			}
		}

		private SysFileContentStorage _sysFileStorage;
		/// <summary>
		/// Хранилище файлов.
		/// </summary>
		public SysFileContentStorage SysFileStorage {
			get {
				return _sysFileStorage ??
					(_sysFileStorage = new SysFileContentStorage(LookupColumnEntities.GetEntity("SysFileStorage")));
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

