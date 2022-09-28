﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignConstsSchema

	/// <exclude/>
	public class CampaignConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignConstsSchema(CampaignConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("345971cb-fd9e-4a62-a27a-77e6ca98c60d");
			Name = "CampaignConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("87c82e9d-12e0-47a8-bdbc-f68fbefb89eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,90,91,115,219,198,21,126,78,102,242,31,48,238,75,242,176,242,222,47,78,219,153,189,186,237,216,113,38,114,166,15,157,62,192,36,36,51,38,9,6,0,227,168,109,254,123,207,130,23,139,12,45,222,208,106,60,150,68,1,7,223,183,123,246,59,223,217,197,188,156,85,237,162,28,85,197,219,170,105,202,182,190,235,110,124,61,191,155,220,47,155,178,155,212,243,226,223,95,125,249,197,178,157,204,239,139,219,135,182,171,102,223,126,245,37,124,242,135,166,186,207,127,245,211,178,109,95,20,190,156,45,202,201,253,28,110,109,187,182,191,226,249,243,231,197,31,219,229,108,86,54,15,127,94,255,14,127,238,202,201,188,45,202,98,148,175,44,231,93,241,75,57,93,86,109,113,87,55,197,104,29,5,126,107,234,217,234,162,140,100,5,100,60,25,229,239,101,51,169,218,155,205,3,158,63,122,194,98,249,110,58,25,21,16,182,131,111,163,140,108,15,88,38,3,23,254,14,219,10,220,250,82,8,80,45,138,238,97,81,21,168,24,53,85,217,85,197,180,42,199,55,219,59,31,63,116,239,169,112,249,184,158,79,31,138,151,203,201,184,240,253,221,175,224,179,77,240,91,136,253,22,66,255,117,92,252,169,152,87,31,251,235,190,126,70,168,231,58,88,142,52,195,2,113,107,21,50,212,26,68,189,18,193,139,192,133,118,207,190,249,246,92,244,113,86,78,166,231,195,118,203,233,135,254,214,35,168,49,85,216,18,18,144,96,220,35,142,163,71,218,42,138,60,55,152,6,105,147,195,230,2,212,213,47,213,188,59,31,117,204,183,29,65,172,132,195,73,7,138,44,75,28,113,69,4,178,129,41,100,5,38,130,51,155,168,244,128,184,56,23,114,185,28,79,170,249,168,58,31,181,93,223,121,4,56,147,2,51,175,36,50,130,83,196,133,147,200,26,198,145,149,36,81,103,156,143,92,95,2,252,190,46,47,72,144,151,112,215,49,192,56,58,170,163,67,206,145,132,120,32,26,25,38,52,18,240,37,131,198,65,51,118,9,224,234,215,201,37,185,1,119,29,1,236,20,215,30,214,26,114,92,105,196,99,32,72,59,65,145,32,130,176,24,185,137,225,212,100,94,148,13,64,152,44,178,188,101,56,203,22,128,111,63,236,64,75,15,51,248,199,155,119,109,61,173,186,10,18,245,134,208,27,82,252,167,248,177,221,149,230,166,186,217,60,231,102,71,220,224,97,237,246,147,239,63,33,248,254,241,115,111,123,52,192,28,68,184,131,17,122,246,205,63,143,106,216,169,33,31,15,38,200,149,33,78,74,68,133,116,8,6,54,193,18,147,22,254,115,10,51,169,169,136,242,154,193,204,89,240,255,29,198,156,65,213,120,152,241,219,139,181,35,169,73,57,66,148,65,44,122,16,168,196,18,50,60,74,148,132,177,148,217,16,152,38,23,72,234,180,156,143,63,59,94,79,161,127,85,245,55,30,89,59,34,154,192,56,134,21,131,185,130,233,102,12,57,147,48,242,212,235,192,130,115,81,210,167,81,63,134,189,89,48,0,122,94,141,207,199,252,253,234,198,79,152,15,140,51,229,78,99,165,57,162,4,10,22,212,43,6,227,108,3,242,150,164,16,18,164,104,8,103,35,110,71,239,171,241,114,122,9,230,219,205,173,79,162,14,66,88,206,157,67,201,74,200,14,145,64,173,52,3,212,34,38,229,131,146,20,235,243,81,119,144,153,151,96,254,97,57,127,18,45,55,222,99,203,19,2,15,3,37,0,116,21,170,23,115,8,39,107,185,129,36,161,228,130,49,238,234,197,162,186,200,140,213,179,69,86,133,167,135,24,4,202,80,110,56,10,28,103,208,212,33,80,175,128,172,83,194,130,19,99,204,218,203,64,195,50,186,0,245,237,250,214,167,243,130,56,97,56,53,8,99,237,50,104,13,70,18,52,55,24,102,179,216,2,165,35,160,183,152,33,25,238,171,110,128,85,184,137,248,182,15,184,130,189,94,153,251,166,44,40,72,95,163,144,15,86,2,250,160,145,139,176,32,157,245,82,37,151,20,11,234,28,205,187,155,76,187,170,233,59,138,181,238,1,15,248,109,86,180,203,119,179,201,69,185,254,106,21,40,65,148,219,117,144,205,67,83,255,184,125,78,36,58,33,85,68,156,101,191,198,225,63,23,96,90,20,78,56,49,154,20,149,234,44,251,243,121,82,243,186,27,134,216,119,117,119,18,55,39,92,180,58,81,132,121,0,130,240,35,216,80,207,192,83,11,79,120,72,82,159,87,163,30,81,219,118,30,64,238,61,212,153,102,58,153,127,128,86,110,50,250,112,9,185,191,108,66,248,85,132,167,167,44,218,148,36,147,40,90,151,13,160,11,72,19,101,145,72,78,83,104,107,116,34,71,210,240,237,251,85,167,184,157,161,190,250,78,198,208,151,76,238,38,85,115,193,242,207,189,227,122,138,14,212,93,73,157,38,30,178,204,121,208,41,30,193,189,106,206,9,104,151,150,142,105,158,132,58,162,176,25,114,223,111,109,22,254,112,208,251,126,108,181,250,63,207,192,91,76,169,131,18,70,89,2,185,5,220,160,92,134,34,29,164,160,152,59,76,56,235,25,124,241,197,103,57,188,153,142,183,91,7,3,224,134,112,91,237,58,208,215,104,3,43,91,43,36,104,128,18,108,161,17,115,217,56,68,21,105,194,65,210,104,253,137,201,63,173,239,215,58,251,162,136,77,83,95,2,118,19,236,85,189,54,226,125,160,29,196,209,19,73,48,181,40,26,14,242,202,4,172,84,229,20,146,74,131,222,70,170,116,60,98,206,14,34,190,93,142,70,85,219,14,129,121,29,106,55,181,163,209,218,218,136,68,4,105,225,66,131,128,226,192,16,241,142,123,43,19,199,103,161,6,81,155,245,185,241,162,120,100,196,139,114,220,39,251,215,179,114,190,44,167,211,135,111,174,163,147,243,229,117,31,202,142,119,211,38,57,34,20,124,161,128,77,222,224,145,12,82,220,91,164,105,138,50,96,15,93,209,169,27,60,123,116,30,187,141,166,187,30,255,35,163,209,116,187,137,20,164,9,218,130,198,8,145,55,79,24,252,100,29,172,90,28,162,17,64,1,139,116,53,135,122,49,36,133,122,177,187,120,173,52,80,162,4,146,125,229,194,12,35,27,146,71,62,38,206,25,51,44,29,211,203,227,12,54,70,126,168,249,216,118,6,191,159,16,233,141,161,62,247,214,30,36,19,218,46,40,4,73,17,20,83,180,17,76,149,135,89,25,144,206,16,83,243,136,205,222,220,248,192,84,132,254,6,9,176,171,208,249,82,14,181,12,82,76,128,175,133,98,198,19,20,187,193,200,84,191,86,163,101,222,77,30,144,17,180,67,187,201,6,206,143,167,32,80,244,185,89,35,193,67,39,129,161,41,6,130,132,137,104,201,245,132,86,205,80,81,142,70,117,179,42,219,245,150,229,0,212,86,225,221,195,134,227,110,246,57,237,188,134,38,73,106,3,34,16,161,223,215,49,57,100,188,73,81,40,80,111,126,173,28,52,213,192,162,246,195,42,224,110,243,132,149,178,66,56,68,160,124,231,121,162,200,194,250,1,71,18,44,182,130,49,129,241,149,60,6,76,183,109,204,157,221,12,140,21,113,204,162,164,64,205,56,211,1,186,13,176,133,90,115,207,192,150,83,16,231,203,40,196,105,53,203,238,112,203,224,69,62,196,25,79,250,19,153,187,105,253,113,0,70,155,120,9,194,237,174,32,176,83,156,17,141,130,134,30,131,91,146,144,150,210,33,41,188,54,65,121,206,36,31,140,214,109,245,243,50,111,196,15,196,106,19,238,119,164,148,149,65,198,36,144,1,171,152,123,117,176,99,54,187,27,159,82,138,209,83,174,46,92,54,7,72,101,27,210,159,165,221,213,211,241,69,110,120,143,22,4,220,156,88,236,137,65,140,18,58,37,68,161,146,34,110,120,64,22,67,66,170,96,99,146,132,166,96,47,20,187,67,83,213,175,225,22,46,46,167,67,168,28,68,187,237,131,237,110,95,113,39,8,183,24,57,105,243,162,130,234,106,34,81,136,6,176,108,46,122,203,205,169,7,2,199,41,189,46,155,15,85,222,210,46,170,220,254,14,97,67,39,211,28,110,103,146,48,9,22,10,15,74,193,64,234,73,5,206,193,194,116,57,5,222,20,19,146,180,57,181,113,63,206,40,111,114,239,22,166,85,14,230,67,221,213,122,191,178,119,232,89,214,191,84,7,243,209,40,47,163,76,12,170,81,110,230,137,212,224,183,243,118,12,104,58,252,163,58,134,83,119,196,142,83,93,183,183,197,162,188,31,160,234,110,162,237,110,185,112,101,13,180,63,33,130,123,229,193,97,100,20,52,204,148,106,129,85,48,50,94,106,92,159,18,141,97,121,65,216,117,192,131,51,70,137,161,140,48,208,13,222,235,34,39,200,112,7,118,16,138,115,226,210,8,129,79,61,50,58,141,34,100,100,191,69,113,61,179,62,204,174,118,56,74,65,43,192,27,121,11,100,140,6,239,23,140,70,208,51,81,197,156,193,220,30,217,168,191,100,190,6,162,3,241,250,72,7,167,201,130,73,247,18,60,146,33,96,153,184,87,28,25,169,40,210,198,37,150,28,166,74,12,55,77,111,39,179,33,138,86,31,102,183,217,224,58,70,78,193,177,38,168,196,92,19,130,44,53,12,225,200,96,178,2,40,5,63,117,203,249,168,231,43,62,150,109,209,126,152,92,122,108,177,87,173,86,129,246,155,13,154,4,39,14,210,44,40,2,197,42,191,26,160,49,206,89,135,173,100,130,105,198,46,156,150,79,132,246,231,231,127,66,108,147,5,187,234,23,193,194,114,143,168,193,176,154,56,205,251,38,204,35,73,37,166,80,193,112,8,226,74,114,163,6,74,210,8,28,192,180,236,170,249,213,251,90,189,175,93,135,124,181,142,184,155,128,12,58,116,199,18,138,18,43,196,105,110,221,13,49,8,166,138,11,232,57,168,195,195,89,219,229,98,156,95,98,2,180,163,247,69,247,190,234,223,250,88,111,228,93,207,243,135,28,118,243,89,126,51,100,183,187,226,44,96,111,9,194,76,5,232,18,99,68,214,133,148,95,20,18,34,40,227,48,137,67,19,173,250,243,245,149,38,110,55,134,135,162,155,125,77,130,200,7,27,177,168,192,29,42,154,79,148,61,129,105,213,2,26,49,168,100,62,9,66,24,199,78,164,11,119,45,15,176,45,65,247,235,119,63,85,163,97,52,255,77,31,106,247,48,20,124,161,151,34,31,228,139,204,41,193,194,227,66,33,70,67,212,36,6,26,241,112,116,214,147,55,20,163,31,251,112,7,72,17,145,223,66,17,30,26,48,1,25,153,233,89,233,20,82,96,51,56,24,16,42,211,112,13,88,187,152,130,13,190,7,36,31,203,135,1,68,50,135,123,185,138,182,251,222,136,197,96,55,104,4,135,65,114,255,133,65,79,56,88,251,152,79,37,44,145,152,177,225,118,0,198,213,120,9,64,70,101,119,237,153,69,230,20,30,69,219,173,105,38,186,144,95,209,147,184,207,62,224,100,25,216,41,234,152,212,80,208,20,20,235,147,207,25,251,227,236,170,63,28,153,129,24,159,237,104,219,174,201,86,120,247,24,190,63,108,121,189,10,7,208,159,189,153,67,254,194,3,150,211,110,178,152,86,155,146,217,22,119,208,141,85,189,229,92,13,99,117,243,236,52,220,219,29,203,89,61,206,47,242,52,80,247,55,135,21,87,12,61,216,135,215,235,40,175,33,240,254,203,49,212,100,27,1,34,141,125,110,158,132,70,54,154,144,15,96,172,228,60,6,121,178,123,189,221,39,80,118,125,5,106,23,213,40,31,208,193,152,128,57,187,152,201,252,254,118,19,40,155,188,3,92,68,140,76,103,59,20,160,233,3,191,74,32,137,8,176,130,2,203,140,49,196,217,120,164,17,252,174,156,193,172,222,245,176,183,213,228,167,250,93,113,223,212,203,69,49,153,23,63,47,203,166,251,215,85,249,244,183,250,221,203,28,174,127,24,100,210,254,231,79,166,203,143,243,201,207,203,199,167,158,25,238,22,106,254,176,123,232,83,105,86,66,242,140,154,186,45,62,214,205,135,171,172,117,236,163,222,246,65,95,247,49,255,222,135,220,63,161,230,62,89,13,134,13,70,158,230,215,64,25,210,62,42,48,218,66,51,18,161,89,248,180,51,249,219,234,205,242,106,62,94,189,92,158,127,253,237,191,2,193,203,136,161,46,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("345971cb-fd9e-4a62-a27a-77e6ca98c60d"));
		}

		#endregion

	}

	#endregion

}
