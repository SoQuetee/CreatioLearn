﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignLeadQualificationHelperSchema

	/// <exclude/>
	public class CampaignLeadQualificationHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignLeadQualificationHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignLeadQualificationHelperSchema(CampaignLeadQualificationHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f2f676e-40b7-4360-96fa-f4d67d29da54");
			Name = "CampaignLeadQualificationHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9b8abc8-8efb-4353-8434-80e2246ec543");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,24,217,110,219,70,240,89,5,250,15,27,22,8,40,64,165,209,3,104,97,203,42,100,217,142,149,42,113,42,217,205,67,16,20,43,114,36,51,229,161,236,146,138,213,84,255,222,217,139,92,174,72,203,125,17,181,179,115,223,100,70,83,224,27,26,2,185,3,198,40,207,87,69,48,201,179,85,188,46,25,45,226,60,35,95,191,253,166,87,242,56,91,147,197,142,23,144,158,57,103,68,79,18,8,5,46,127,234,46,120,5,25,176,56,60,192,185,164,5,173,129,182,26,12,186,224,193,229,69,231,213,53,13,139,156,197,192,59,49,22,225,3,68,101,2,172,198,88,39,249,146,38,167,167,147,60,77,243,44,152,229,235,53,130,241,30,49,190,99,176,22,158,8,19,202,249,41,153,208,116,67,227,117,54,3,26,253,81,210,36,94,197,161,116,213,13,36,27,96,146,228,228,228,132,12,121,153,166,148,237,70,250,172,174,21,23,178,202,25,73,144,1,249,108,115,8,12,233,137,69,251,225,118,201,243,4,10,240,189,95,130,95,131,159,201,191,228,158,131,230,211,17,181,192,40,185,0,182,141,67,80,206,167,5,68,239,97,121,157,179,84,41,227,245,63,162,128,77,185,76,226,80,51,60,98,221,41,233,184,16,121,130,188,42,103,93,199,144,68,232,173,119,44,222,162,92,117,185,81,7,194,11,164,12,9,67,86,121,150,236,200,20,253,77,254,74,240,231,156,224,223,55,52,163,107,96,168,116,33,2,1,204,247,142,168,229,245,207,180,120,200,34,165,65,83,29,244,14,47,88,41,50,67,40,37,45,86,24,110,168,36,96,154,197,69,140,82,254,1,78,50,248,162,125,19,35,15,154,97,173,12,57,96,0,24,172,206,143,42,118,50,10,42,41,39,174,152,225,134,50,154,146,12,139,240,220,43,57,48,84,51,83,245,226,141,48,200,152,45,21,160,146,30,12,79,36,89,59,23,186,217,36,90,131,123,150,120,163,113,125,38,247,243,89,131,88,7,254,136,9,254,125,67,49,210,212,115,128,193,100,162,130,154,130,251,130,127,175,119,74,150,148,131,239,146,56,184,228,235,254,233,232,189,129,226,33,239,204,166,101,158,39,100,202,133,250,215,44,79,103,52,139,80,161,113,22,221,208,45,160,216,2,27,130,255,170,140,35,89,113,211,104,64,242,178,32,10,160,112,27,176,80,81,32,76,217,32,46,226,172,48,240,185,65,214,118,107,240,85,74,99,97,137,164,169,216,98,62,11,158,193,85,186,41,118,103,242,174,98,223,125,55,151,151,223,255,208,0,74,1,8,86,98,109,170,45,101,132,131,232,179,120,45,178,117,33,15,78,220,116,68,68,75,46,211,204,247,220,142,224,13,136,55,141,188,126,48,230,190,55,51,6,120,46,153,240,178,64,213,137,2,209,196,216,163,73,173,179,67,170,111,4,181,52,166,73,160,65,221,52,115,87,196,220,146,33,2,223,98,147,185,126,157,199,153,47,126,238,118,27,8,166,232,19,134,28,165,45,26,165,23,220,90,214,105,122,41,113,202,175,68,147,238,246,88,171,140,25,172,138,219,178,144,114,140,17,13,81,150,101,77,49,79,121,88,139,122,255,0,12,106,204,6,189,242,92,240,78,84,57,14,13,230,171,164,239,27,90,172,139,35,81,124,155,23,190,224,247,182,76,18,191,65,214,230,129,5,246,114,120,90,131,25,200,108,146,61,152,7,99,76,199,45,104,152,166,238,247,9,229,58,111,85,82,171,177,236,95,94,92,61,66,88,98,219,38,209,178,250,123,78,154,185,29,92,101,188,100,112,121,81,131,252,190,41,70,195,106,42,22,141,57,26,142,109,149,169,199,185,174,155,64,113,6,117,235,215,146,106,38,61,209,2,170,186,86,38,78,179,8,30,145,137,226,38,198,213,45,195,123,25,196,186,128,206,44,6,85,241,31,101,96,5,164,133,193,252,249,28,230,29,44,100,189,61,151,137,46,78,195,230,203,67,156,0,241,53,190,240,154,229,238,102,251,171,121,138,102,231,183,121,176,98,219,232,141,14,97,155,231,14,8,231,14,229,52,43,126,250,209,111,245,217,1,173,233,175,53,245,66,118,90,191,195,95,53,131,37,146,252,109,78,123,245,84,15,245,203,160,40,89,70,94,212,221,62,144,133,194,107,111,244,201,203,151,109,8,149,213,74,218,190,117,240,45,176,148,222,230,95,228,136,251,13,7,192,35,106,14,27,49,166,90,70,148,53,232,150,101,242,183,132,153,137,38,178,163,2,206,133,86,42,164,82,14,3,94,38,98,194,172,80,49,80,230,198,43,226,215,242,130,27,202,255,164,73,9,85,42,252,14,59,9,120,71,99,54,20,50,7,66,198,200,146,156,173,114,100,105,54,16,181,112,200,200,165,41,68,49,26,153,236,238,88,44,118,192,139,90,91,200,10,209,180,216,197,78,9,246,181,239,239,157,53,195,82,77,233,165,131,100,25,142,194,27,202,4,168,178,139,53,111,65,147,252,52,98,229,153,23,22,99,19,193,58,166,90,250,158,0,250,207,120,168,169,138,187,15,184,58,152,149,160,145,87,74,124,91,126,108,115,140,242,56,138,238,114,227,224,113,25,197,128,59,228,45,19,73,35,57,171,205,40,212,8,34,21,236,205,200,100,82,235,102,228,110,69,207,74,64,147,28,110,10,234,140,114,82,80,65,11,182,51,14,19,41,87,167,188,45,235,48,203,15,18,188,145,220,117,195,18,11,212,167,124,89,13,44,174,247,168,203,88,38,18,110,236,67,101,8,114,89,126,194,236,26,213,189,238,43,241,198,205,149,123,64,154,0,178,31,88,200,147,202,209,136,104,185,189,137,101,37,187,64,179,179,164,29,111,238,32,206,59,49,149,187,60,187,58,28,13,171,201,51,168,35,222,138,50,183,113,14,36,54,70,71,51,60,100,111,186,165,105,155,78,7,152,96,75,45,160,202,81,171,27,188,206,151,190,91,231,141,216,153,34,111,214,153,43,224,13,176,181,121,55,192,41,81,21,200,1,111,187,48,156,154,112,154,115,213,244,145,166,8,31,136,127,245,24,194,70,190,50,65,95,171,33,222,113,131,43,198,114,38,214,39,90,248,222,135,35,111,95,193,177,250,253,24,160,115,77,107,219,91,93,224,25,47,83,121,129,102,66,100,186,134,62,146,109,204,10,212,164,234,31,66,53,237,171,90,21,110,191,82,53,138,186,154,106,103,53,172,242,85,93,230,117,222,40,88,75,175,168,167,204,177,215,59,251,205,206,121,169,171,187,150,125,156,87,93,172,103,65,85,135,178,86,25,245,180,26,129,154,98,226,119,84,229,198,44,230,162,253,183,103,26,14,179,137,133,119,177,171,86,195,131,92,171,215,1,157,80,162,49,25,33,34,235,248,13,98,36,114,113,157,136,47,18,234,83,215,78,200,24,78,90,240,70,102,50,138,110,102,125,2,25,179,117,153,226,20,245,221,143,14,3,103,177,238,27,77,86,57,86,164,72,106,91,37,28,230,13,31,212,126,115,102,10,234,107,14,214,128,237,29,14,26,27,209,30,177,61,119,180,88,136,182,193,182,183,23,128,65,141,244,134,80,235,82,237,109,71,7,227,115,74,127,208,24,128,214,56,106,219,46,157,62,241,191,106,245,216,23,171,177,250,56,67,87,216,3,59,190,44,62,231,35,148,170,35,111,116,159,197,159,75,32,113,181,107,145,124,37,217,182,125,64,202,183,192,24,162,234,134,33,53,25,11,69,204,170,166,116,104,107,24,221,221,69,227,157,117,123,73,65,155,192,253,127,186,32,186,103,209,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f2f676e-40b7-4360-96fa-f4d67d29da54"));
		}

		#endregion

	}

	#endregion

}

