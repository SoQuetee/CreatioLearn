namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignQueueMonitoringJobDispatcherSchema

	/// <exclude/>
	public class CampaignQueueMonitoringJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignQueueMonitoringJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignQueueMonitoringJobDispatcherSchema(CampaignQueueMonitoringJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858");
			Name = "CampaignQueueMonitoringJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,87,95,111,219,54,16,127,118,129,126,135,67,246,34,3,134,188,190,58,177,139,46,13,58,111,205,182,54,9,250,88,208,210,89,225,42,145,42,73,185,245,130,126,247,30,37,82,18,101,43,113,176,23,219,60,222,223,223,29,239,206,130,21,168,75,150,32,220,162,82,76,203,173,137,47,165,216,242,172,82,204,112,41,94,190,120,120,249,98,82,105,46,50,248,80,49,101,254,59,111,207,125,17,133,241,77,114,143,105,149,163,58,198,241,9,55,196,85,20,82,116,183,86,234,146,21,37,227,153,32,163,218,104,88,214,196,216,83,227,224,154,9,163,59,233,44,151,27,150,47,22,141,214,248,189,204,50,34,211,61,113,252,162,48,35,231,225,50,103,90,47,192,107,249,80,97,133,215,82,112,35,21,241,254,33,55,111,57,69,111,200,113,85,203,205,231,115,184,208,85,81,48,181,95,185,243,63,74,238,120,138,26,10,52,247,50,213,96,36,220,51,145,230,8,27,37,191,160,128,196,169,135,175,86,63,20,173,129,216,171,156,247,116,150,213,38,231,9,36,214,181,147,60,131,5,252,198,52,214,44,193,197,12,214,111,202,242,106,135,194,188,231,218,160,176,81,76,30,234,72,58,8,60,114,11,138,132,239,152,193,230,190,108,14,144,216,123,224,194,192,192,135,91,197,179,12,21,9,209,209,236,41,53,175,126,61,119,186,81,164,141,250,208,22,65,85,162,50,28,173,177,58,76,103,171,9,89,238,168,28,8,74,208,198,26,0,10,230,157,146,85,249,23,21,33,44,87,16,214,66,155,251,62,155,115,96,152,167,154,240,70,80,24,54,86,170,102,185,165,123,164,232,20,110,151,103,35,40,159,205,87,77,26,226,86,103,63,81,45,68,35,226,240,249,107,72,56,239,197,58,38,51,60,219,215,53,153,100,104,44,0,67,133,240,250,53,68,7,196,37,8,252,54,102,32,186,211,168,8,64,129,137,125,190,211,105,237,212,68,143,24,88,194,142,229,21,214,76,63,254,23,182,191,99,78,185,127,46,164,141,20,124,78,130,243,49,32,29,231,224,24,194,23,106,105,208,27,208,66,240,26,226,19,152,29,104,56,13,178,119,72,253,76,42,208,246,219,220,99,215,38,180,111,148,49,172,31,7,53,120,238,132,237,19,168,174,143,202,117,17,4,228,62,200,35,130,199,169,199,49,15,121,2,232,195,171,48,3,193,221,137,137,24,234,59,200,199,88,127,186,110,58,184,237,132,210,144,13,76,123,249,227,130,180,113,147,202,100,238,64,117,60,93,223,90,211,144,177,121,181,179,134,188,157,90,175,232,247,53,19,140,206,113,119,115,56,217,218,110,214,112,216,94,54,61,127,166,245,118,192,90,31,218,67,227,198,91,220,178,42,239,168,177,175,172,103,26,217,73,158,130,215,66,64,71,174,87,127,147,234,75,189,40,88,207,103,190,131,87,218,133,226,138,130,198,81,231,129,255,117,205,69,101,48,223,147,182,139,83,230,221,42,170,117,77,78,24,7,179,161,95,222,161,25,208,83,229,50,93,139,198,58,229,252,213,172,81,203,245,205,158,134,101,97,107,109,1,70,85,54,28,239,244,162,141,157,166,107,233,70,223,226,137,209,56,61,232,5,167,2,125,39,188,229,59,193,18,83,177,156,162,211,145,135,147,202,52,65,173,91,151,232,210,153,214,209,209,7,212,130,212,139,34,50,141,72,93,38,15,14,131,109,75,142,255,196,125,108,33,179,123,159,97,212,229,35,170,174,219,125,137,209,180,166,79,189,55,147,201,173,218,119,30,219,226,56,217,137,158,49,247,168,45,94,246,243,16,188,97,35,117,40,208,6,22,46,90,163,205,240,56,214,107,97,80,9,150,95,125,199,132,42,162,5,121,144,219,248,99,37,162,233,243,186,73,111,213,57,26,129,7,130,118,72,247,22,224,95,185,129,45,77,135,193,238,72,123,165,197,10,235,45,83,161,199,218,111,154,14,198,177,233,90,83,74,166,88,1,130,50,183,60,163,229,206,224,119,115,182,26,153,51,126,125,188,116,124,52,97,46,230,181,130,85,111,58,212,240,253,45,236,227,54,244,15,32,26,72,129,179,226,1,165,242,9,251,120,228,25,154,204,83,21,125,196,126,21,5,104,31,216,188,18,233,35,22,225,168,216,13,213,11,25,126,202,221,71,133,79,179,59,40,142,134,26,18,127,252,4,139,224,113,155,101,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExecutionExceptionLocalizableString());
			LocalizableStrings.Add(CreateCreateJobErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExecutionExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fe22e7df-a5c5-4b9d-824b-76db35cfd28d"),
				Name = "ExecutionException",
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"),
				ModifiedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateJobErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04db795e-fe79-4373-8e8e-a00606a0efa9"),
				Name = "CreateJobError",
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"),
				ModifiedInSchemaUId = new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("47239ecf-12fc-4c08-a358-3dca5b05f858"));
		}

		#endregion

	}

	#endregion

}

