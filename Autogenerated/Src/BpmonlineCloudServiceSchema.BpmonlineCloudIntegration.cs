﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BpmonlineCloudServiceSchema

	/// <exclude/>
	public class BpmonlineCloudServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BpmonlineCloudServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BpmonlineCloudServiceSchema(BpmonlineCloudServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09b18195-8cb5-49e5-9ecd-05a1c8e2f698");
			Name = "BpmonlineCloudService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,203,110,219,58,16,93,187,64,255,129,112,55,50,96,200,251,198,54,224,184,73,111,110,145,198,136,211,155,69,112,81,208,210,216,22,34,145,42,73,37,16,130,252,123,135,34,149,232,101,89,110,218,162,45,186,178,52,47,206,204,57,28,82,102,52,2,25,83,15,200,21,8,65,37,95,43,119,206,217,58,216,36,130,170,128,179,215,175,30,94,191,234,37,50,96,27,178,76,165,130,8,245,97,8,158,86,74,247,61,48,16,129,119,84,181,89,130,184,11,60,56,231,62,132,173,74,247,26,86,237,6,51,92,234,46,203,165,102,135,190,104,43,37,234,150,138,42,120,54,40,86,35,118,200,11,85,186,243,147,101,182,154,236,100,122,137,61,195,234,97,135,181,0,247,148,122,138,139,160,217,66,167,61,231,81,148,85,132,250,55,2,54,24,153,204,67,42,229,91,114,28,163,38,12,24,204,67,158,248,182,23,153,225,141,125,193,132,148,192,21,254,215,178,153,140,63,130,194,120,49,230,183,10,194,64,165,151,240,37,9,4,68,192,148,116,138,47,186,70,50,33,123,92,180,149,107,5,254,64,47,18,39,171,48,240,136,167,19,108,206,143,96,222,84,130,125,27,146,179,75,160,254,5,11,211,34,62,24,233,33,43,228,169,228,211,0,66,31,107,94,8,141,177,169,178,23,155,151,202,66,39,108,131,143,228,179,247,252,114,84,182,255,36,65,96,107,152,33,39,249,156,148,222,173,241,27,96,190,89,188,156,9,26,74,37,18,13,155,206,39,43,216,134,55,197,55,150,237,12,200,3,121,236,96,87,201,173,156,26,6,209,1,122,149,140,17,169,90,9,189,222,99,123,29,11,193,99,16,10,169,119,72,87,139,207,38,151,13,40,251,212,11,214,196,41,182,157,76,38,132,37,97,152,167,141,137,151,180,134,200,102,11,164,56,34,212,184,105,205,169,99,157,123,12,238,139,237,159,137,77,162,121,232,244,203,213,247,135,21,132,7,131,35,19,226,209,252,8,80,137,96,85,134,228,250,61,125,59,7,181,229,126,5,250,209,104,68,198,50,137,34,42,210,105,46,184,204,150,145,132,122,30,79,152,34,1,91,115,247,201,122,84,53,31,155,180,228,116,86,180,31,143,114,177,182,187,185,64,204,178,241,82,220,218,189,27,156,20,103,236,142,223,130,99,210,195,222,246,23,23,203,43,221,10,17,92,65,20,135,26,82,148,218,224,103,24,27,149,199,220,79,151,42,13,181,10,99,156,227,30,164,27,120,146,186,215,130,198,49,248,195,172,59,122,167,131,84,167,92,68,84,149,28,140,200,253,87,114,54,36,249,208,107,183,27,152,196,77,113,111,137,53,88,80,129,7,141,2,225,124,196,223,106,190,198,199,110,159,130,162,248,236,228,100,179,32,23,136,228,150,204,138,123,164,17,190,153,239,75,34,145,5,32,136,207,35,26,32,148,251,32,140,117,254,132,97,238,147,190,241,233,79,223,101,191,8,100,166,172,195,189,108,88,226,197,168,119,5,150,116,3,213,226,255,61,129,53,109,145,117,96,237,56,212,77,41,216,104,56,138,66,7,167,128,62,45,77,219,218,64,175,248,89,135,111,134,159,172,185,32,106,11,36,22,252,46,64,109,87,62,80,191,94,149,237,126,127,122,133,1,209,160,105,65,221,89,61,120,132,177,253,201,68,170,142,143,114,17,136,251,194,182,225,183,152,38,47,36,93,161,92,103,182,27,78,210,2,245,1,76,109,139,178,151,190,120,154,74,226,109,193,187,5,159,0,250,135,146,172,5,143,14,166,173,241,237,79,79,24,30,182,130,174,16,93,190,182,17,255,14,181,10,191,176,235,115,211,243,19,211,182,50,201,10,170,124,93,82,117,113,206,158,59,61,54,67,110,106,219,221,194,157,90,20,235,177,151,39,249,37,229,192,131,238,103,206,156,218,38,248,35,71,77,77,210,118,147,105,48,126,9,210,100,149,150,142,180,108,235,119,29,16,178,245,80,251,213,15,52,220,56,181,102,30,167,127,244,161,214,94,178,179,243,84,219,5,116,251,88,170,83,117,103,156,189,20,254,20,251,8,155,204,190,118,49,29,165,112,56,202,174,60,189,135,213,63,156,223,206,226,248,157,189,153,95,27,9,126,161,197,177,101,217,110,50,254,208,175,50,83,152,254,106,93,218,170,126,11,230,117,250,56,171,215,150,223,221,171,136,12,137,85,208,68,109,63,64,218,66,172,134,160,245,104,121,152,110,151,165,177,4,32,158,128,245,196,158,56,255,209,48,240,51,88,179,2,71,83,114,31,168,45,242,78,51,4,113,179,183,42,192,227,186,51,9,255,222,166,14,160,151,5,0,76,249,101,134,53,65,68,202,14,223,118,147,170,196,104,184,71,85,254,25,50,210,178,16,101,95,1,223,82,28,215,50,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09b18195-8cb5-49e5-9ecd-05a1c8e2f698"));
		}

		#endregion

	}

	#endregion

}
