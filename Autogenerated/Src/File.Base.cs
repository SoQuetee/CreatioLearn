namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.File;
	using Terrasoft.File.Abstractions;

	#region Class: File_BaseEventsProcess

	public partial class File_BaseEventsProcess<TEntity>
	{

		#region Properties: Public

		/// <summary>
		/// Flag, indicates that file api should not be notified when record is deleting. For internal usage only.
		/// </summary>
		public bool SkipDeletingFileUsingFileApi { get; set; }

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Notifies file API that file should be removed.
		/// </summary>
		protected virtual void DeleteFileUsingFileApi() {
			if (!GlobalAppSettings.FeatureUseFileApi || SkipDeletingFileUsingFileApi) {
				return;
			}
			var fileLocator = new EntityFileLocator(Entity.Schema.Name, Entity.PrimaryColumnValue);
			IFileFactory fileFactory = UserConnection.GetFileFactory();
			var options = new FileOptions {
				UseRights = false,
				RemoveMetadataOnDelete = false
			};
			options.Context.Add($"Entity_{fileLocator.EntitySchemaName}_{fileLocator.RecordId}", Entity);
			IFile file = fileFactory.Get(fileLocator, options);
			file.Delete();
		}

		#endregion

		#region Methods: Public

		public virtual void OnFileSaving() {
			Nullable<int> version = Entity.GetTypedOldColumnValue<int>("Version") as Nullable<int>;
			version = (version == null) ? 1 : version;
			var increaseVersion = false;
			var changedColumnValues = Entity.GetChangedColumnValues();
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			EntityColumnValue dataColumnValue = changedColumnValues.FirstOrDefault(col => col.Name == "Data");

			// TODO #RND-15156, #RND-15155: Revert changes when both tasks are completed.
			if (dataColumnValue != null) {
				if (Entity.GetColumnValue("Data") is byte[] data) {
					Entity.SetColumnValue("Size", data.Length);
				}
			}
			if (fileType == Terrasoft.WebApp.FileConsts.FileTypeUId) {
				if (dataColumnValue != null) {
					increaseVersion = true;
				}
			} else {
				var nameOldValue = Entity.GetTypedOldColumnValue<string>("Name");
				var nameNewValue = Entity.GetTypedColumnValue<string>("Name");
				if (nameNewValue != nameOldValue) {
					increaseVersion = true;
				}
			}
			if (increaseVersion) {
				Entity.SetColumnValue("Version", version + 1);
			} else {
				Entity.SetColumnValue("Version", version);
			}
		}

		public virtual void OnFileSaved() {
		}

		public virtual void OnFileDeleted() {
		}

		public virtual void OnFileUpdated() {
		}

		#endregion

	}

	#endregion

}
