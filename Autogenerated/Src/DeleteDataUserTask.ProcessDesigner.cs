﻿namespace Terrasoft.Core.Process.Configuration
{
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;

	#region Class: DeleteDataUserTask

	/// <exclude/>
	public partial class DeleteDataUserTask
	{

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			EntitySchemaId.CheckArgumentEmpty("EntitySchemaId");
			EntitySchemaManager entitySchemaManager =  UserConnection.EntitySchemaManager;
			EntitySchema entitySchema = entitySchemaManager.GetInstanceByUId(EntitySchemaId);
			var esq = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name) {
				UseAdminRights = false
			};
			esq.AddAllSchemaColumns();
			esq.IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks;
			ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
			bool isEmptyFilter = esq.Filters.Count == 0;
			if (!isEmptyFilter && esq.Filters.Count == 1) {
				if (esq.Filters[0] is EntitySchemaQueryFilterCollection filterGroup && filterGroup.Count == 0) {
					isEmptyFilter = true;
				}
			}
			if (isEmptyFilter) {
				throw new NullOrEmptyException(new LocalizableString("Terrasoft.Core",
					"ProcessSchemaDeleteDataUserTask.Exception.DeleteDataWithEmptyFilter"));
			}
			EntityCollection entities = esq.GetEntityCollection(UserConnection);
			while(entities.Count > 0) {
				Entity entity = entities.First.Value;
				entity.UseAdminRights = false;
				entities.RemoveFirst();
				entity.Delete();
			}
			return true;
		}

		#endregion

	}

	#endregion

}
