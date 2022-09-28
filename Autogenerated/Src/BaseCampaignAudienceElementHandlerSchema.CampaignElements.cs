﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCampaignAudienceElementHandlerSchema

	/// <exclude/>
	public class BaseCampaignAudienceElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCampaignAudienceElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCampaignAudienceElementHandlerSchema(BaseCampaignAudienceElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("326349f5-a353-47fc-80f8-b6d9a046a25f");
			Name = "BaseCampaignAudienceElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,89,91,111,219,54,20,126,118,129,254,7,206,123,145,49,87,65,210,110,197,154,56,129,147,58,109,134,164,25,154,180,125,24,134,129,145,104,155,168,68,121,36,237,198,43,250,223,119,120,21,69,201,118,90,116,192,128,32,176,201,195,115,253,206,133,52,195,37,17,11,156,17,116,75,56,199,162,154,202,244,172,98,83,58,91,114,44,105,197,30,63,250,252,248,81,111,41,40,155,161,155,181,144,164,60,140,190,3,125,81,144,76,17,139,244,21,97,132,211,172,69,243,18,75,220,90,188,164,236,239,122,49,84,160,44,43,214,189,195,73,58,150,146,211,187,165,36,98,35,201,25,46,23,152,206,54,243,112,4,233,100,69,152,124,141,89,94,16,94,83,43,26,71,114,147,205,73,137,209,8,53,15,54,183,225,40,28,222,219,219,67,71,98,89,150,152,175,143,237,119,240,166,196,148,9,84,18,57,175,114,129,166,21,71,37,172,168,85,37,11,47,115,74,24,68,128,20,164,4,101,4,162,12,101,78,140,227,186,23,176,93,44,239,10,154,33,124,39,36,199,153,68,89,129,133,64,167,88,120,157,199,150,231,196,176,180,246,161,23,200,17,132,102,171,131,67,116,113,205,252,233,169,36,252,6,175,200,16,132,245,130,141,179,106,177,134,165,207,218,216,222,143,156,204,32,232,232,156,146,34,23,47,208,239,188,146,128,3,146,155,237,216,25,122,225,13,224,13,85,83,36,231,222,94,52,55,106,164,254,80,104,107,111,225,184,34,176,86,249,139,52,108,82,12,15,183,8,188,5,65,239,46,114,39,83,71,35,147,231,85,145,131,63,132,142,221,78,193,175,150,52,111,158,52,65,87,124,71,136,145,79,154,34,233,143,199,79,127,30,159,159,61,123,114,118,186,191,255,228,217,193,248,215,39,167,251,207,39,79,14,206,207,39,231,251,207,159,78,38,167,191,244,7,86,219,31,9,203,141,3,155,222,4,47,46,8,151,148,40,143,234,64,111,177,110,204,0,44,66,98,5,31,107,225,145,32,4,101,156,76,71,125,163,235,107,82,0,195,254,222,241,70,59,233,10,75,130,66,106,244,215,52,248,118,168,201,12,232,26,84,141,47,170,78,244,122,51,34,237,167,30,39,114,201,89,147,21,58,57,65,73,115,197,120,48,100,149,12,6,90,100,239,139,254,47,106,150,241,201,21,46,150,36,160,253,178,221,183,87,38,5,21,84,181,205,102,215,57,224,98,194,150,37,225,248,174,32,71,91,146,233,24,189,34,242,170,202,233,148,146,60,218,19,201,192,170,186,194,28,101,75,206,97,209,237,129,190,112,178,117,162,89,72,172,229,116,138,162,141,244,130,81,73,113,225,202,17,184,109,89,20,131,200,217,145,200,208,141,74,35,106,120,124,149,70,77,193,86,63,197,76,64,234,5,156,34,222,233,111,21,101,73,164,207,208,40,219,179,180,104,116,236,142,165,144,76,110,215,30,82,187,246,99,184,155,216,19,67,183,57,80,132,110,53,53,64,82,153,57,242,167,221,90,125,100,96,152,165,31,230,132,147,228,94,113,184,79,47,160,41,237,187,157,27,162,154,90,184,117,96,109,239,118,117,58,185,207,200,66,38,161,87,204,129,47,77,152,233,106,2,110,143,42,73,226,202,27,147,84,174,205,178,42,110,33,160,166,193,17,93,73,71,45,114,244,19,178,121,223,175,35,21,18,193,153,119,130,112,40,103,204,52,237,116,18,236,94,97,134,103,80,139,207,41,203,149,205,167,107,197,52,137,5,55,61,209,100,111,128,137,78,180,161,233,164,92,200,53,52,158,144,70,69,51,244,76,103,105,123,183,200,193,91,194,119,44,165,13,250,68,229,28,101,70,117,18,213,100,4,110,85,189,85,21,193,130,10,169,10,162,107,169,27,74,159,94,89,96,142,75,196,192,170,81,223,209,247,143,47,45,135,160,156,110,169,9,170,186,30,237,105,78,141,154,186,170,64,41,99,201,153,211,218,104,43,46,216,180,74,30,92,114,156,98,14,13,96,40,193,217,28,37,58,188,182,145,194,220,16,211,5,176,209,205,202,238,251,140,72,47,132,142,16,212,173,19,19,55,44,116,224,78,84,204,34,226,195,154,165,233,156,202,134,128,105,88,75,130,112,107,75,155,152,27,180,88,153,94,218,149,22,158,71,42,98,252,245,194,179,254,115,195,166,13,109,251,69,77,110,89,217,40,5,104,243,17,123,75,178,138,231,218,12,103,170,170,71,53,139,161,119,241,224,155,154,209,238,185,233,173,206,52,209,0,55,228,1,0,19,80,230,134,197,246,40,9,58,46,72,6,157,42,211,169,1,42,210,21,228,205,246,137,171,149,21,198,206,254,177,115,142,53,220,143,30,13,232,235,211,166,48,8,159,69,15,80,21,152,184,83,205,233,203,143,185,95,211,159,219,61,173,61,209,11,223,208,54,186,253,3,167,170,6,193,152,65,115,125,29,130,41,94,8,168,144,72,86,225,42,39,98,89,60,188,204,224,72,59,112,173,191,67,185,57,174,203,65,145,151,67,150,14,128,45,94,52,87,165,23,102,21,46,28,235,59,94,125,36,204,98,118,7,95,107,111,255,248,150,220,75,199,160,237,143,237,76,10,178,34,5,176,80,224,85,31,31,200,167,198,128,174,163,58,24,239,253,145,175,43,160,177,203,237,52,161,0,122,164,234,221,177,79,97,149,52,166,21,91,157,134,190,7,53,133,95,106,83,180,65,157,101,217,151,93,202,106,230,141,194,236,10,247,168,165,30,52,96,46,228,53,127,73,166,24,144,229,198,144,112,184,137,74,142,30,25,61,195,104,58,236,65,2,74,202,220,172,108,39,194,158,181,115,213,48,235,202,34,124,100,221,0,66,121,137,101,226,189,225,106,224,25,94,132,181,60,154,26,199,121,30,197,170,83,204,208,58,176,93,55,59,19,242,108,78,178,143,2,145,123,136,27,97,66,223,122,44,142,149,155,139,10,231,0,151,204,103,64,234,82,216,102,104,148,183,84,181,149,93,215,63,13,62,45,216,182,238,137,147,254,125,224,103,131,170,124,82,229,164,112,72,20,131,8,83,91,4,132,35,64,44,202,131,64,1,228,7,151,244,99,182,246,179,173,134,83,220,236,7,53,120,154,233,96,218,244,101,246,207,141,94,126,175,174,96,14,120,193,165,124,232,230,208,55,21,116,223,37,203,39,156,87,188,239,208,242,125,177,247,205,224,219,146,217,169,86,120,208,200,152,157,248,188,4,0,138,0,145,83,173,191,130,218,148,87,37,88,85,113,85,229,190,83,159,120,64,143,112,61,181,221,96,108,174,212,93,160,187,253,118,67,84,217,249,77,131,236,38,116,214,5,243,21,175,150,11,209,85,19,245,206,169,199,173,227,109,167,204,60,184,154,186,0,152,183,133,78,19,18,75,222,40,217,51,37,161,174,215,70,149,206,89,90,241,214,212,209,69,209,167,79,122,91,41,185,73,56,234,146,104,42,246,60,116,181,79,6,223,56,65,239,184,22,70,179,115,235,134,104,95,6,172,99,148,97,225,99,76,234,103,114,19,233,88,216,48,108,156,221,58,214,188,85,62,79,192,219,206,91,147,248,246,186,85,115,199,207,215,176,60,127,139,217,140,36,181,128,198,195,145,189,158,90,242,157,55,78,117,231,21,40,95,67,238,233,121,217,64,72,93,57,171,165,68,83,90,72,37,244,129,169,107,143,199,25,187,113,230,138,39,230,142,177,109,147,70,91,51,215,204,54,202,52,27,196,15,112,250,77,117,174,207,38,219,251,79,43,53,27,135,195,228,210,82,90,25,21,49,182,76,234,244,106,182,38,179,150,222,174,23,196,116,164,43,204,63,18,152,90,102,128,40,161,70,34,77,160,246,95,154,24,65,150,249,30,85,167,215,173,42,66,22,76,150,103,12,51,184,33,190,129,241,232,154,127,152,195,112,112,163,126,255,72,236,187,79,175,119,130,250,246,210,216,119,75,47,54,49,58,12,164,207,177,240,142,105,36,144,30,29,110,8,230,217,92,253,12,242,218,209,37,145,190,46,147,210,154,246,148,50,247,236,213,235,206,45,211,213,189,236,218,33,189,142,144,169,140,113,126,174,7,71,55,13,126,217,152,58,33,143,48,141,118,95,109,119,61,96,187,87,158,250,77,135,235,203,182,233,157,40,177,87,111,184,5,178,28,213,215,247,169,254,201,97,128,176,250,165,162,190,84,130,27,208,29,129,171,77,86,45,40,201,55,228,234,31,215,28,140,74,14,6,127,6,239,218,122,200,187,214,191,112,248,55,92,201,215,97,233,199,197,215,61,156,58,255,110,121,255,9,88,186,202,5,214,72,149,60,230,57,81,121,147,220,251,168,58,1,151,213,76,189,210,233,9,197,142,72,93,19,24,185,175,39,28,59,25,25,4,215,193,151,115,94,125,122,224,240,253,31,5,75,224,213,198,88,53,163,227,127,152,218,20,162,210,62,203,55,227,180,249,177,126,119,132,98,142,255,175,48,69,9,8,171,240,247,47,26,32,176,189,212,29,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("326349f5-a353-47fc-80f8-b6d9a046a25f"));
		}

		#endregion

	}

	#endregion

}
