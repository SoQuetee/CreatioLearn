﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignBaseFragmentSyncManagerSchema

	/// <exclude/>
	public class CampaignBaseFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignBaseFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignBaseFragmentSyncManagerSchema(CampaignBaseFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9d0b93ec-700f-4d30-b684-52db669e1a7f");
			Name = "CampaignBaseFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,27,219,110,220,186,241,121,15,112,254,129,216,22,168,22,221,202,73,139,190,248,118,96,59,206,233,22,118,156,99,59,205,99,193,149,184,187,130,181,146,66,73,182,183,65,254,189,195,155,72,74,212,205,78,26,31,52,47,78,86,26,14,135,115,231,204,40,193,91,146,103,56,32,232,150,80,138,243,116,85,248,103,105,178,138,214,37,197,69,148,38,63,255,244,249,231,159,38,101,30,37,107,116,179,203,11,178,61,168,253,6,248,56,38,1,3,206,253,95,73,66,104,20,52,96,46,162,228,83,227,225,237,134,18,28,194,3,255,22,231,119,185,126,111,210,178,221,166,137,251,13,37,109,207,253,55,167,250,21,123,112,134,183,25,142,214,9,28,45,47,114,116,196,31,250,234,169,111,189,198,73,97,144,178,142,211,37,142,247,247,5,33,254,69,186,94,195,99,120,15,16,127,160,100,13,167,70,103,49,206,243,125,164,176,156,226,156,188,165,120,189,37,73,113,179,75,130,75,156,224,53,161,124,201,222,222,30,58,204,203,237,22,211,221,177,252,253,134,228,1,141,150,36,71,75,88,137,114,88,178,161,105,18,253,135,80,180,74,41,74,51,34,100,129,99,84,224,101,76,208,95,0,7,33,40,160,100,117,52,85,219,190,199,180,136,130,40,3,250,175,178,41,218,59,246,213,126,123,198,134,89,185,140,163,0,225,101,94,80,28,20,40,96,180,247,145,142,246,209,66,129,56,79,54,249,204,79,167,57,162,24,185,143,222,211,180,0,237,32,161,128,200,212,79,20,48,24,4,100,112,33,185,14,113,203,14,251,14,52,20,4,150,192,63,233,202,115,194,205,14,198,97,30,134,119,44,214,69,178,74,135,97,102,144,99,177,95,101,195,241,11,216,177,59,156,111,113,20,223,98,186,38,45,172,223,102,0,79,139,32,171,193,62,99,163,225,219,12,218,100,1,94,165,131,69,236,117,39,158,211,50,190,147,123,54,144,84,239,58,49,128,69,132,52,138,227,107,2,103,141,136,173,107,83,3,63,59,211,244,64,90,13,129,69,220,112,28,86,68,203,160,72,41,51,36,110,185,2,162,238,70,248,3,3,156,251,13,135,143,104,177,239,233,222,177,112,4,126,133,124,175,142,253,48,195,20,111,57,55,142,166,129,226,104,56,61,254,144,68,159,74,130,162,16,112,70,171,8,188,69,186,66,10,192,63,220,227,235,122,208,128,96,122,81,161,8,160,248,193,30,54,81,176,65,69,202,93,37,202,180,102,229,214,118,210,213,245,156,221,251,181,140,66,164,15,52,71,246,3,78,218,12,177,40,56,153,84,154,20,130,56,245,154,3,251,37,95,98,2,240,7,28,232,75,183,196,193,89,130,179,47,34,194,29,103,116,143,11,162,220,38,255,129,22,16,128,208,191,99,136,66,132,30,52,94,92,240,231,232,232,88,129,160,95,126,65,158,250,255,17,123,47,79,13,129,186,16,208,94,51,62,86,241,80,64,48,237,157,205,122,116,213,166,220,114,249,78,101,189,33,44,103,64,32,110,186,227,66,173,196,108,202,19,109,101,0,218,224,92,9,92,198,198,22,85,213,118,41,119,48,28,79,126,155,50,193,203,23,159,17,152,224,1,202,217,159,49,98,233,51,195,110,37,102,15,139,93,27,241,66,99,185,2,26,170,38,41,85,162,54,41,30,78,65,148,68,69,4,25,68,159,57,57,229,48,134,94,161,253,29,52,183,113,249,146,20,155,52,108,211,252,251,52,98,50,45,206,41,77,233,77,129,139,50,127,155,210,69,18,164,219,44,38,32,112,83,208,222,135,156,80,80,230,68,228,165,168,180,126,42,107,190,199,20,149,89,200,176,131,155,39,15,232,3,255,225,217,208,243,158,228,100,198,113,77,124,160,205,155,10,194,192,151,193,170,52,46,183,137,255,158,249,35,160,175,211,208,204,232,168,207,7,126,199,66,190,200,175,33,95,222,9,45,118,237,0,222,159,84,75,62,110,8,37,176,72,200,221,22,207,116,230,47,242,243,79,37,142,189,38,153,182,231,147,232,38,254,73,18,214,73,232,192,178,194,113,14,180,32,176,91,193,85,225,35,5,187,253,143,81,177,249,71,196,4,197,255,250,215,233,195,69,26,220,205,44,160,243,71,18,148,32,142,153,233,57,45,117,56,197,69,176,33,161,2,236,20,250,28,65,36,4,43,40,76,39,18,158,165,37,100,122,134,62,88,222,231,168,213,123,72,30,203,157,207,147,114,11,57,58,40,132,199,189,47,119,175,130,37,255,194,113,73,14,153,133,28,3,247,128,241,51,255,54,189,136,242,66,30,107,194,40,50,55,229,20,193,206,150,249,241,135,26,126,201,206,125,3,244,3,28,219,73,74,236,60,38,44,184,157,148,33,100,30,1,249,141,249,214,83,5,90,211,106,115,119,154,6,36,207,37,51,0,229,43,241,14,252,2,220,53,188,218,235,195,38,181,138,127,156,129,88,238,206,55,174,159,227,230,46,202,106,8,129,31,248,142,120,213,145,36,97,147,54,206,179,235,105,24,177,35,248,103,49,193,212,235,93,112,69,67,66,79,119,76,159,243,161,107,132,241,116,27,254,28,113,129,42,251,88,36,13,43,200,61,139,27,51,181,109,67,3,209,159,143,208,34,129,21,112,199,187,209,47,221,50,155,212,36,2,107,43,238,73,8,118,159,246,223,144,24,239,188,215,175,102,254,71,28,85,250,246,165,205,152,46,211,123,114,13,75,248,69,222,147,65,146,170,7,226,247,28,45,211,52,70,15,56,7,91,11,77,187,169,0,65,228,181,69,14,43,121,100,86,98,40,13,85,233,50,172,126,108,49,158,70,106,253,129,113,255,64,35,49,52,173,3,141,235,62,102,227,89,170,44,189,3,75,149,201,27,107,41,41,74,154,32,175,58,204,220,36,105,174,241,42,73,48,87,112,66,41,8,73,89,227,138,173,150,204,99,190,117,155,21,240,178,178,47,177,131,33,71,17,194,108,183,215,228,191,237,23,191,149,27,169,118,85,110,68,159,132,63,241,158,225,114,108,220,51,91,117,228,43,229,112,244,182,35,188,13,195,20,37,112,180,130,31,87,48,196,44,25,164,149,218,85,54,178,224,240,141,108,193,38,104,94,25,139,220,201,216,165,22,225,190,129,97,75,43,182,207,98,121,58,101,232,89,203,123,43,87,170,43,90,219,34,167,198,49,12,129,211,161,154,89,185,72,196,36,109,173,68,9,140,189,216,124,97,185,53,175,223,187,76,6,119,177,216,51,156,188,122,196,72,252,24,37,97,250,192,229,248,182,76,248,57,61,25,10,216,107,200,104,222,149,219,37,161,54,196,108,110,192,240,87,2,229,249,99,70,65,242,12,164,55,232,0,99,11,28,112,175,245,53,176,81,2,154,18,94,37,144,154,204,252,147,220,155,10,210,167,131,153,124,147,129,105,172,118,239,82,150,194,137,172,78,174,149,30,209,144,104,205,123,212,56,157,151,203,169,21,85,253,183,52,221,122,189,36,8,186,217,234,90,242,43,17,170,19,181,167,171,175,69,170,42,208,185,242,205,133,142,94,34,6,212,140,234,42,91,132,82,71,199,152,84,230,196,80,217,66,151,225,246,24,135,228,125,215,6,61,129,89,98,104,11,129,58,242,125,177,50,244,1,215,187,254,242,192,53,223,59,135,123,35,231,4,220,95,205,42,184,78,54,138,13,46,208,6,223,19,118,127,93,18,180,133,36,38,100,89,126,10,175,136,70,175,43,97,238,242,34,171,128,241,218,122,87,5,76,48,36,63,54,107,23,254,225,158,122,108,151,31,170,10,187,246,193,87,250,8,205,104,114,155,178,4,76,202,86,85,91,94,22,111,208,3,92,219,208,71,17,207,208,42,198,235,111,201,45,182,201,87,226,216,34,9,112,150,151,176,142,176,146,82,148,160,56,93,71,65,71,221,73,103,232,124,175,234,156,11,86,108,96,217,17,127,172,185,203,26,55,240,59,231,174,16,48,243,82,10,59,82,65,214,59,180,220,177,42,49,48,185,16,237,29,85,214,26,90,110,181,189,230,244,120,193,187,43,1,97,178,55,228,103,71,93,16,91,179,250,170,184,47,18,12,88,110,94,69,90,106,63,189,50,99,25,157,235,246,210,93,132,25,161,226,102,149,48,219,54,165,197,53,253,1,114,33,14,211,38,187,145,76,62,73,88,70,248,76,62,59,202,156,227,15,208,38,128,251,136,22,16,205,58,179,60,158,21,12,47,135,229,142,44,204,25,179,157,233,17,143,214,195,170,101,67,47,216,67,235,77,102,233,75,212,170,250,113,187,43,99,18,199,100,108,133,76,213,25,88,59,215,51,211,170,90,98,49,201,7,166,77,121,35,25,249,106,182,18,224,68,71,132,21,72,173,217,100,254,221,152,205,144,179,60,213,130,140,0,51,216,132,234,25,87,35,141,51,83,197,182,236,206,214,4,88,207,186,87,173,180,185,179,234,11,178,42,174,32,189,163,255,76,35,231,69,64,27,37,207,159,131,76,23,179,174,18,254,219,190,109,84,22,1,175,210,218,187,202,106,120,153,88,46,213,93,194,33,245,230,16,150,176,220,114,90,47,97,11,108,18,203,187,50,142,61,187,40,45,169,17,0,174,42,92,93,36,109,201,126,167,125,137,139,123,175,78,190,164,232,179,120,26,201,125,214,34,208,106,155,97,154,104,234,230,200,152,19,8,45,178,84,218,117,247,105,87,120,93,96,248,36,171,55,44,124,153,100,182,152,8,100,45,105,183,101,40,69,227,13,24,237,212,245,197,249,116,199,187,61,166,178,91,150,1,63,140,166,208,180,22,109,212,5,126,2,64,36,187,76,67,214,175,147,27,176,39,103,170,187,229,120,100,133,93,121,76,23,47,109,95,194,57,52,88,233,101,123,76,107,80,94,66,142,155,176,161,45,183,50,253,233,69,25,192,135,177,228,143,182,5,177,131,113,107,17,191,171,109,158,97,23,142,214,164,83,153,157,13,74,51,209,49,29,187,208,227,154,18,170,78,226,77,90,210,128,200,196,174,191,114,84,75,156,236,61,158,223,9,149,76,36,97,189,27,90,237,96,26,195,19,15,81,179,168,230,14,150,77,62,121,11,3,75,215,41,158,183,137,137,102,54,34,39,159,163,4,130,170,29,116,251,219,111,245,24,108,196,104,25,233,135,42,80,173,21,227,192,219,222,189,126,94,146,111,238,81,41,172,198,174,156,243,243,20,24,188,128,214,96,221,16,55,175,4,141,182,184,44,33,171,171,129,167,90,135,18,176,247,238,80,234,158,251,147,220,252,203,207,109,26,174,253,91,250,243,69,242,158,166,107,86,83,255,225,207,159,236,160,148,121,253,240,226,63,188,248,239,200,139,107,219,127,233,94,60,36,76,111,12,151,88,77,34,200,82,9,166,214,231,5,225,119,117,224,111,234,212,246,150,162,123,157,183,68,9,110,91,252,207,40,70,135,85,219,96,144,215,62,226,59,240,190,170,64,213,114,129,108,179,75,247,48,125,173,174,209,98,57,172,134,209,90,23,98,154,39,40,26,82,63,111,104,68,141,199,142,136,249,255,164,19,35,3,184,228,166,8,224,79,82,11,83,23,132,165,11,156,254,73,24,86,46,121,128,215,158,179,81,238,40,192,113,213,32,99,62,208,118,30,161,210,146,110,231,113,18,48,54,1,55,114,119,251,7,46,244,5,75,91,244,164,240,74,14,209,163,136,21,197,170,249,91,180,36,0,195,1,3,242,34,82,69,19,177,61,139,159,79,143,217,12,166,57,23,205,199,161,163,48,31,245,133,65,67,219,248,36,93,197,210,97,170,85,128,174,203,150,251,224,249,102,103,1,236,11,72,144,205,64,121,231,143,1,201,248,142,228,177,26,150,18,195,252,62,199,239,253,177,114,62,226,224,188,179,203,198,182,237,16,251,5,173,192,143,193,249,128,21,88,157,202,230,7,4,93,216,164,57,130,212,233,151,132,129,91,72,117,223,186,181,43,251,93,93,211,111,138,100,34,134,38,144,253,133,13,203,189,196,250,33,181,211,225,211,101,221,51,205,66,178,230,108,10,255,156,69,124,195,34,254,206,142,53,107,219,199,55,155,117,211,186,138,181,214,74,93,159,115,73,125,96,254,0,51,133,52,7,245,64,22,154,162,74,59,197,120,0,31,48,201,61,59,183,118,14,126,58,170,74,10,169,207,116,247,245,204,125,69,178,99,109,31,150,191,214,176,200,217,7,215,58,197,84,123,129,57,39,218,183,217,223,102,166,25,141,171,215,178,106,175,219,129,115,149,229,211,172,122,200,214,176,53,171,95,38,186,101,10,167,112,130,224,228,75,62,238,193,162,177,24,42,51,67,177,176,134,239,224,225,91,124,47,139,150,134,140,245,64,243,224,40,47,92,210,181,61,67,43,250,17,227,198,81,0,159,61,83,237,196,92,13,136,238,35,241,205,132,110,102,48,190,59,233,24,63,26,211,160,197,129,219,160,132,119,211,237,49,56,197,109,54,236,49,120,88,120,48,211,239,153,225,87,223,101,155,31,160,251,55,59,160,175,40,162,100,205,62,47,47,184,139,168,87,76,132,205,77,7,17,5,118,248,247,87,175,236,92,233,18,23,27,255,18,63,122,156,142,57,122,53,27,124,233,226,163,63,85,60,147,77,120,247,80,145,48,168,7,112,101,172,97,253,98,46,98,45,211,68,66,41,216,240,87,247,232,86,179,135,222,217,171,254,150,163,40,170,45,173,103,47,186,33,120,239,174,21,198,232,94,183,129,52,250,223,117,8,93,142,232,219,165,86,210,104,224,177,171,79,29,96,86,253,104,8,220,152,241,29,94,125,76,213,224,231,211,39,89,250,135,68,251,62,179,20,17,207,182,47,150,196,26,243,66,124,68,17,65,246,0,81,42,83,222,203,245,21,100,20,42,172,106,58,210,85,130,253,142,115,49,38,226,198,199,67,211,150,105,190,214,107,139,101,253,39,40,225,115,234,108,57,14,195,230,58,203,234,197,7,159,85,164,29,52,233,55,224,203,59,123,129,127,182,33,193,221,9,93,151,204,139,243,129,143,58,59,165,126,181,221,148,219,70,167,197,133,223,121,121,50,110,97,181,207,10,93,167,105,158,228,127,113,5,51,118,109,191,132,77,10,0,121,24,120,33,107,179,162,94,131,25,99,41,112,143,109,110,145,150,133,101,171,71,60,233,64,193,6,39,107,32,41,231,142,147,29,122,202,217,53,253,97,119,210,238,222,178,250,202,75,48,62,93,230,112,26,84,251,119,140,157,38,228,14,16,226,169,253,16,158,253,23,114,195,214,159,191,72,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d0b93ec-700f-4d30-b684-52db669e1a7f"));
		}

		#endregion

	}

	#endregion

}
