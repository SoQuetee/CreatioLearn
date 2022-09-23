﻿namespace Terrasoft.Configuration.Reporting.FastReportEngine.Custom
{
	using Terrasoft.Configuration.Reporting.FastReport;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Reporting.DataSource.Abstractions;

	#region Class: CustomDataSourceBuilder

	[DefaultBinding(typeof(IDataSourceBuilder), Name = "Custom")]
	public class CustomDataSourceBuilder : DataSourceBuilder<ReportDataSourceConfiguration<CustomReportDataSourceConfigurationData>, CustomDataSelect>
	{

		#region Constructors: Public

		public CustomDataSourceBuilder(UserConnection userConnection)
			: base(CreateConfigurationProvider(userConnection), CreateDataProvider(userConnection), CreateDataSelectExtractor(), CreateDataSchemaExtractor(userConnection)) {
		}

		#endregion

		#region Methods: Private

		private static IDataSourceConfigurationProvider<ReportDataSourceConfiguration<CustomReportDataSourceConfigurationData>> CreateConfigurationProvider(UserConnection userConnection) {
			return new ReportDataSourceConfigurationProvider<CustomReportDataSourceConfigurationData>(userConnection);
		}

		private static IDataProvider<CustomDataSelect> CreateDataProvider(UserConnection userConnection) {
			return new CustomDataProvider(userConnection, new FastReportDataSourceDataProviderResolver());
		}

		private static IDataSelectExtractor<ReportDataSourceConfiguration<CustomReportDataSourceConfigurationData>, CustomDataSelect> CreateDataSelectExtractor() {
			return new CustomDataSelectExtractor();
		}

		private static IDataSchemaExtractor<ReportDataSourceConfiguration<CustomReportDataSourceConfigurationData>> CreateDataSchemaExtractor(UserConnection userConnection) {
			return new CustomDataSchemaExtractor(userConnection);
		}

		#endregion

	}

	#endregion

}

