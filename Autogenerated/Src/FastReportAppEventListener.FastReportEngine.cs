namespace Terrasoft.Configuration.Reporting.FastReportEngine
{
	using Terrasoft.Reporting.FastReport.Connection;
	using Terrasoft.Reporting.FastReport;
	using Terrasoft.Web.Common;
	using global::Common.Logging;

	#region Class: FastReportAppEventListener

	public class FastReportAppEventListener : AppEventListenerBase
	{

		#region Fields: Private

		private ILog _logger = LogManager.GetLogger("Terrasoft");

		#endregion

		#region Methods: Public

		public override void OnAppStart(AppEventContext context) {
			base.OnAppStart(context);
			ReportDataSourceConnectionInitializer.Initialize();
			var fontListFileWasCreated = FontListFileCreator.TryCreate();
			if (!fontListFileWasCreated) {
				this._logger.Error("font.list file was not created.");
			}
		}

		#endregion

	}

	#endregion

}

