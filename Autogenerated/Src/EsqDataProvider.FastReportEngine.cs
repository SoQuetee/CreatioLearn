﻿namespace Terrasoft.Configuration.Reporting.FastReportEngine.Esq
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Reporting.DataSource.Abstractions;

	#region Class: EsqDataProvider

	public class EsqDataProvider : IDataProvider<EsqDataSelect>
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public EsqDataProvider(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private IReadOnlyDictionary<string, object> ConvertToDictionary(Entity entity, IReadOnlyDictionary<string, string> esqColumnMap) {
			//TODO CRM-54293
			return esqColumnMap.ToDictionary(x => x.Key, x => entity.GetColumnValue(x.Value));
		}

		#endregion

		#region Methods: Public

		public Task<IEnumerable<IReadOnlyDictionary<string, object>>> GetData(EsqDataSelect select) {
			var entityCollection = select.Esq.GetEntityCollection(_userConnection);
			return Task.FromResult(entityCollection.Select(entity => ConvertToDictionary(entity, select.EsqColumnMap)));
		}

		#endregion

	}

	#endregion

}

