﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: MkpInstalledAppNewsInFolder

	/// <exclude/>
	public class MkpInstalledAppNewsInFolder : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public MkpInstalledAppNewsInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MkpInstalledAppNewsInFolder";
		}

		public MkpInstalledAppNewsInFolder(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "MkpInstalledAppNewsInFolder";
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
		/// Created on.
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
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
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
		/// Modified by.
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

		private MkpInstalledAppNewsFolder _folder;
		/// <summary>
		/// Installed app news folder.
		/// </summary>
		public MkpInstalledAppNewsFolder Folder {
			get {
				return _folder ??
					(_folder = new MkpInstalledAppNewsFolder(LookupColumnEntities.GetEntity("Folder")));
			}
		}

		/// <summary>
		/// Active processes.
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
		public Guid MkpInstalledAppNewsId {
			get {
				return GetTypedColumnValue<Guid>("MkpInstalledAppNewsId");
			}
			set {
				SetColumnValue("MkpInstalledAppNewsId", value);
				_mkpInstalledAppNews = null;
			}
		}

		private MkpInstalledAppNews _mkpInstalledAppNews;
		/// <summary>
		/// Installed app news.
		/// </summary>
		public MkpInstalledAppNews MkpInstalledAppNews {
			get {
				return _mkpInstalledAppNews ??
					(_mkpInstalledAppNews = new MkpInstalledAppNews(LookupColumnEntities.GetEntity("MkpInstalledAppNews")));
			}
		}

		#endregion

	}

	#endregion

}

