﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHistoryExportToExcelServiceSchema

	/// <exclude/>
	public class ForecastHistoryExportToExcelServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHistoryExportToExcelServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHistoryExportToExcelServiceSchema(ForecastHistoryExportToExcelServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b9a6113-1660-45d2-8131-c707ea7d4a0a");
			Name = "ForecastHistoryExportToExcelService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,75,111,219,70,16,62,171,64,255,195,64,189,80,128,64,1,61,218,146,12,199,178,83,181,137,227,74,110,46,65,80,172,201,145,180,13,69,42,187,75,203,106,160,255,222,217,7,201,229,67,138,11,228,98,104,103,231,181,223,206,126,51,116,202,182,40,119,44,66,120,68,33,152,204,86,42,188,201,210,21,95,231,130,41,158,165,225,93,38,48,98,82,125,252,21,190,253,252,83,47,151,60,93,195,242,32,21,110,47,27,107,178,76,18,140,180,153,12,223,98,138,130,71,45,157,119,60,253,90,9,239,113,175,72,91,135,253,93,102,105,181,225,167,179,221,158,218,241,19,189,125,217,101,66,61,102,183,47,17,38,221,234,2,79,201,195,219,84,113,197,81,158,84,184,99,145,202,196,9,141,251,156,135,75,20,207,60,194,247,89,140,73,56,99,138,81,122,74,144,85,101,64,18,169,36,76,190,11,246,135,167,127,8,199,143,44,201,113,129,81,38,98,99,201,82,229,69,215,33,140,198,227,97,135,53,159,103,179,9,107,118,149,187,59,158,40,20,255,211,87,101,68,142,200,213,47,2,215,116,14,184,73,152,148,206,165,61,161,217,30,141,70,48,150,249,118,203,196,97,234,214,86,9,98,114,11,81,13,140,194,96,228,89,236,242,167,132,71,176,99,66,113,150,64,212,138,163,139,148,244,90,161,108,44,7,47,5,74,242,109,10,17,219,233,72,38,120,88,90,249,241,138,128,133,229,111,92,82,21,28,52,8,14,21,93,244,228,235,198,186,210,27,159,62,67,75,6,223,96,141,234,18,164,254,115,4,242,124,180,128,97,26,91,204,218,248,93,52,163,214,42,220,133,63,137,171,219,135,85,38,0,141,161,190,229,85,129,64,44,120,146,196,217,222,30,30,84,70,74,228,181,19,244,79,51,92,177,60,81,111,120,26,147,147,64,209,125,103,171,96,94,164,215,149,215,96,8,247,196,45,84,75,125,151,125,127,240,185,186,64,119,113,223,63,31,92,192,217,56,197,125,151,200,233,135,34,114,253,86,225,156,157,181,234,190,221,46,253,224,47,105,74,44,181,252,6,121,109,57,48,220,216,235,213,165,225,205,6,163,47,215,98,157,111,49,85,247,121,146,4,41,97,66,208,53,172,7,151,198,186,17,98,210,8,98,148,142,238,184,245,186,41,143,127,199,49,137,169,114,30,4,127,102,170,56,165,93,64,39,126,127,99,135,244,242,124,148,7,145,237,80,104,186,60,17,169,113,146,198,178,246,22,94,145,98,167,112,98,158,103,175,51,125,184,186,130,160,123,103,98,223,150,101,243,3,117,41,53,238,114,63,13,204,165,156,3,225,61,170,77,118,18,107,203,73,18,40,192,18,117,83,252,51,71,113,112,210,96,126,155,82,77,8,246,148,224,248,109,206,227,41,8,67,243,114,30,23,165,244,204,4,172,156,147,9,164,184,47,93,218,253,94,141,176,171,69,56,79,237,98,104,213,168,125,18,91,114,106,174,53,213,186,56,188,253,154,179,196,89,188,195,149,126,50,2,165,180,101,168,131,191,97,18,61,161,203,161,87,137,156,119,211,71,15,203,104,131,91,102,142,92,215,8,237,142,229,71,23,175,103,87,15,76,109,52,93,204,227,190,149,31,221,254,130,175,55,94,66,26,142,18,173,208,130,27,88,193,60,166,178,248,161,233,62,48,65,47,182,66,179,87,10,28,46,213,186,136,209,107,54,230,218,58,212,215,93,56,235,25,113,121,158,121,236,228,71,7,192,32,124,204,174,169,19,31,130,129,145,28,45,79,8,84,185,72,139,234,240,105,161,168,190,25,55,47,141,248,123,76,108,72,156,61,4,175,10,45,222,211,70,109,90,233,156,102,52,25,212,58,234,202,91,248,213,25,85,6,14,140,87,133,13,28,219,105,23,146,30,222,140,139,146,240,252,80,225,146,54,237,207,171,208,83,154,192,7,17,163,40,37,75,138,68,163,200,181,140,208,180,39,139,221,85,67,171,185,127,209,220,159,97,161,96,211,211,157,146,69,27,8,170,163,2,79,235,25,182,218,124,1,79,207,195,38,188,142,227,192,174,67,221,18,135,6,170,22,46,65,105,219,115,14,9,15,103,230,4,69,217,212,51,63,7,155,255,178,74,111,166,47,95,53,176,111,225,113,159,165,56,108,61,27,119,209,214,111,37,246,146,255,49,148,80,231,4,47,241,230,11,177,151,117,244,223,133,135,253,107,90,102,197,227,102,24,56,51,62,222,80,69,40,148,192,210,24,246,130,235,159,102,104,2,42,118,100,91,61,68,37,89,196,244,58,19,108,141,70,209,37,101,155,17,124,193,195,137,65,211,72,118,154,77,64,15,9,147,190,127,169,253,233,233,49,121,60,50,86,221,78,178,230,135,132,236,79,237,199,5,60,27,238,113,76,58,132,253,134,83,181,239,105,42,132,39,116,233,98,220,246,110,207,35,167,99,137,8,145,192,213,164,95,107,160,11,250,158,36,146,198,254,104,106,229,20,194,74,200,87,97,236,205,94,157,198,154,154,106,27,127,224,225,52,41,13,193,239,167,173,111,167,41,180,81,40,234,181,54,12,44,80,79,184,227,249,2,119,153,228,90,52,94,234,155,36,175,75,115,195,182,146,167,196,106,102,185,192,152,203,74,121,137,81,78,85,113,152,233,16,140,36,53,170,179,85,89,48,101,235,249,83,91,135,130,74,79,243,114,157,138,143,151,208,49,42,116,79,28,109,8,138,214,249,162,123,230,75,72,147,135,79,204,149,135,118,198,197,91,95,100,153,178,143,215,141,250,246,251,54,108,140,211,116,33,94,220,202,160,28,80,10,96,28,68,67,127,190,145,37,189,201,142,22,216,53,186,133,15,2,169,102,209,238,5,250,223,10,148,215,51,205,171,250,67,150,190,26,249,191,104,107,36,240,78,233,14,223,205,21,93,223,106,36,251,15,204,175,34,47,61,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b9a6113-1660-45d2-8131-c707ea7d4a0a"));
		}

		#endregion

	}

	#endregion

}

