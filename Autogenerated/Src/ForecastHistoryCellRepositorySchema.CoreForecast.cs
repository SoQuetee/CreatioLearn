﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHistoryCellRepositorySchema

	/// <exclude/>
	public class ForecastHistoryCellRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHistoryCellRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHistoryCellRepositorySchema(ForecastHistoryCellRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34a2b5e5-c1f7-89c1-a01b-7b476cc8a544");
			Name = "ForecastHistoryCellRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,91,111,219,54,20,126,118,129,254,7,194,125,145,1,67,206,246,50,32,190,12,141,227,100,6,154,52,75,186,190,12,195,192,74,199,54,81,137,242,72,42,141,81,244,191,239,240,102,139,186,216,201,178,151,88,164,206,157,223,249,14,21,78,115,144,91,154,0,249,4,66,80,89,172,84,60,47,248,138,173,75,65,21,43,120,124,85,8,72,168,84,159,127,126,251,230,251,219,55,189,82,50,190,38,15,59,169,32,31,215,214,168,154,101,144,104,61,25,95,3,7,193,146,134,204,37,85,180,177,249,129,241,127,14,155,213,88,242,188,224,237,111,4,116,237,199,151,23,157,175,174,104,162,10,193,64,162,4,202,188,19,176,198,112,201,60,163,82,158,19,159,237,111,76,162,212,110,14,89,118,15,219,66,50,189,50,10,127,94,194,138,150,153,186,96,60,69,243,145,218,109,161,88,69,203,107,80,94,57,212,26,12,201,45,86,153,76,73,223,89,237,15,254,58,98,104,201,37,136,23,218,218,150,95,50,150,144,68,39,113,60,7,114,78,186,67,29,146,163,222,241,245,3,167,91,185,41,20,250,212,96,56,148,15,79,92,137,82,151,22,171,120,103,194,49,229,242,161,29,13,42,250,3,157,162,9,110,177,67,202,96,57,32,198,85,47,220,141,231,27,72,190,190,23,235,50,7,174,110,203,44,139,56,150,6,43,88,211,30,140,141,118,205,197,180,230,196,8,253,176,33,191,3,158,218,188,244,170,154,230,157,40,182,88,30,68,15,38,41,216,35,85,224,178,180,11,50,223,148,252,171,180,29,20,46,166,51,194,225,91,176,23,249,204,108,209,177,121,202,156,227,187,146,43,140,239,151,161,121,119,67,159,238,168,192,204,20,8,251,14,196,29,136,223,75,192,42,106,99,40,250,211,217,217,153,137,127,220,76,160,59,252,66,97,234,144,250,4,220,146,212,10,85,91,126,39,107,80,99,242,35,76,123,217,114,188,38,194,139,146,101,41,8,242,247,234,184,192,184,30,197,73,139,167,222,219,202,98,176,238,169,199,86,36,58,21,6,153,78,9,71,40,249,131,233,245,78,107,88,234,176,180,178,67,214,83,147,83,177,207,34,103,188,103,16,113,104,29,143,230,168,31,130,179,63,172,29,131,7,181,70,172,254,17,160,74,193,159,83,101,175,211,2,245,78,164,84,186,121,52,26,145,137,44,243,156,138,221,204,111,124,218,0,241,158,137,116,12,65,82,228,249,120,175,51,170,42,213,56,193,147,138,158,12,36,88,56,180,201,10,228,186,34,190,1,181,41,210,206,190,196,74,144,185,0,124,214,143,209,82,155,191,7,170,79,80,152,31,127,228,174,148,230,100,180,146,3,194,130,43,166,118,203,20,207,219,202,235,147,182,29,251,153,102,37,76,174,75,150,206,162,150,147,55,231,75,185,146,177,181,97,149,52,141,15,108,135,247,236,206,235,108,239,25,187,97,29,201,130,21,233,235,172,91,27,77,219,247,197,183,255,39,108,52,212,180,110,172,116,90,79,33,97,57,205,78,56,48,178,21,211,182,3,186,216,190,3,80,29,76,249,200,132,42,105,70,30,11,150,146,27,28,229,204,17,185,70,152,78,158,200,13,128,90,166,56,56,23,28,59,91,208,47,25,76,244,235,25,73,240,175,244,160,123,164,130,48,163,139,233,106,232,89,67,181,185,56,136,151,92,21,199,243,213,171,135,100,3,57,53,233,218,142,215,205,73,147,13,137,180,31,237,24,157,133,1,152,8,182,14,41,190,238,90,34,246,240,137,151,114,145,111,213,14,135,214,175,196,22,52,54,110,35,75,152,231,126,115,63,173,162,64,223,51,150,77,211,158,139,140,6,142,9,227,7,80,199,19,123,208,165,60,28,228,176,233,206,21,123,240,124,155,117,88,15,195,18,60,223,80,179,251,90,226,51,229,240,189,254,130,40,235,180,209,101,218,83,212,11,76,123,178,61,106,188,202,200,123,141,23,185,169,53,97,87,2,182,232,47,175,122,64,30,93,198,13,85,249,185,105,199,166,190,17,56,56,86,136,69,34,210,111,11,229,192,190,111,16,39,184,120,130,164,84,16,13,158,63,75,15,68,18,14,210,9,227,27,132,155,74,139,132,140,170,115,177,73,22,154,250,116,187,70,166,11,246,195,214,172,134,228,138,101,202,240,132,190,103,174,42,11,31,124,32,223,125,113,14,196,124,169,170,246,142,168,86,189,182,105,222,67,82,8,108,44,217,180,241,81,216,90,183,152,58,168,121,163,1,24,59,195,169,74,237,53,65,127,154,90,218,115,207,211,83,183,200,248,112,101,144,222,166,213,13,139,21,107,142,239,232,147,97,120,36,227,61,225,155,72,28,223,127,64,255,246,172,61,178,42,113,122,208,217,251,74,20,249,11,11,126,82,56,112,26,225,248,125,154,70,149,59,142,19,243,72,117,191,238,126,99,52,170,99,176,245,102,103,199,16,81,120,193,179,46,218,239,115,102,103,171,251,141,232,3,152,246,131,226,244,103,87,251,203,161,129,47,227,171,98,50,50,242,237,234,218,87,127,102,170,222,16,118,61,98,102,238,97,220,118,116,198,137,177,251,223,193,244,154,142,210,180,99,171,137,68,83,193,255,129,107,236,25,85,169,170,154,72,35,41,204,202,124,85,86,240,188,120,82,192,165,251,63,140,178,31,157,214,233,48,248,4,109,189,32,232,247,190,248,206,244,62,180,250,53,167,217,6,7,245,211,28,105,119,195,77,220,251,23,175,179,202,248,150,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34a2b5e5-c1f7-89c1-a01b-7b476cc8a544"));
		}

		#endregion

	}

	#endregion

}
