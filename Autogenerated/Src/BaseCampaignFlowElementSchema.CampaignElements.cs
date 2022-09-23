﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCampaignFlowElementSchema

	/// <exclude/>
	public class BaseCampaignFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCampaignFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCampaignFlowElementSchema(BaseCampaignFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7f88a5b-01f8-4d24-9883-14cb920af36e");
			Name = "BaseCampaignFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,26,203,114,219,56,242,236,169,154,127,192,106,47,84,141,139,246,30,246,18,89,118,217,142,157,209,108,226,100,34,103,115,156,130,72,200,194,154,175,0,160,29,37,229,127,223,6,26,32,1,62,44,121,50,91,123,73,68,176,187,209,239,23,93,208,156,201,138,38,140,220,50,33,168,44,215,42,190,44,139,53,191,171,5,85,188,44,126,254,233,251,207,63,29,212,146,23,119,100,185,149,138,229,179,206,51,192,103,25,75,52,176,140,223,176,130,9,158,244,96,222,242,226,75,239,240,118,35,24,77,225,32,190,165,242,94,182,239,125,94,242,188,44,134,223,8,54,118,30,95,210,188,162,252,110,20,49,126,125,49,250,234,131,40,19,38,53,55,0,241,119,193,238,64,48,114,153,81,41,95,145,11,42,153,163,125,157,149,143,87,25,203,89,161,12,232,209,209,17,57,145,117,158,83,177,61,181,207,26,158,36,26,151,172,75,65,216,87,150,212,138,174,50,56,180,84,8,67,18,50,118,36,142,60,26,85,189,202,120,98,41,140,92,78,94,17,119,106,89,15,56,59,248,110,184,107,37,1,51,41,10,23,190,34,31,4,127,160,138,225,251,10,31,72,162,223,19,169,132,86,77,67,152,10,197,19,94,1,222,173,102,255,6,220,134,204,201,100,224,253,100,246,18,106,239,171,93,244,222,87,147,153,149,128,21,41,10,241,140,68,165,2,87,100,41,66,116,77,98,14,150,116,205,200,138,170,100,67,36,255,198,140,97,242,18,184,44,215,228,75,205,196,150,168,109,197,140,61,250,6,1,193,236,13,86,52,14,6,208,20,127,215,152,23,154,234,82,19,157,147,127,30,31,239,224,27,152,173,24,200,201,186,166,24,102,91,147,5,22,41,209,78,155,57,17,84,73,100,149,113,101,88,7,82,228,113,195,225,37,122,182,83,167,225,139,165,191,91,144,53,163,170,6,79,31,147,16,77,167,37,251,195,185,169,117,167,243,58,229,172,72,250,210,2,112,252,142,23,255,166,89,205,102,93,42,151,123,17,209,121,230,224,224,142,41,251,235,128,175,73,180,39,3,39,228,120,234,208,14,30,168,32,15,154,17,224,11,179,129,159,208,98,72,62,75,166,20,232,71,167,43,101,88,142,62,73,38,0,172,192,60,118,104,41,29,76,246,98,125,114,56,224,2,211,153,37,178,183,14,223,81,181,137,223,209,175,145,97,254,16,68,178,36,158,240,63,193,192,106,197,158,54,65,84,131,249,244,18,55,220,29,63,78,37,132,218,139,9,102,180,2,98,120,103,208,236,200,43,100,126,74,150,144,193,128,175,69,26,95,125,169,105,38,163,148,173,105,157,169,232,77,205,211,233,20,117,113,246,108,106,66,152,87,59,18,206,236,57,33,203,172,206,11,35,19,121,228,106,163,179,4,211,66,223,179,45,193,156,163,104,162,226,69,74,40,100,14,193,239,120,65,51,34,153,174,132,49,89,64,98,144,16,132,32,177,14,80,115,74,82,46,193,235,224,71,130,200,210,93,134,193,106,114,207,33,65,43,3,226,106,11,108,49,72,161,130,173,231,19,240,212,192,208,147,163,83,146,51,181,41,211,157,58,127,224,66,213,154,57,212,253,178,172,69,194,150,134,39,43,198,34,69,121,77,26,254,78,32,6,103,192,52,252,243,244,140,138,110,27,171,19,181,161,86,42,94,72,66,193,53,210,148,235,64,130,91,121,177,46,73,198,139,123,224,196,104,178,169,124,85,107,149,31,240,155,5,208,111,124,103,212,175,126,33,19,13,56,121,214,230,61,199,78,169,130,116,107,244,181,35,89,46,28,178,51,82,27,166,238,100,22,74,212,199,232,29,180,25,17,68,235,209,35,103,103,94,126,108,78,231,4,92,165,75,42,154,218,92,34,199,136,205,49,101,206,188,132,49,168,164,143,44,231,133,238,217,72,173,56,212,29,72,27,224,238,166,0,39,166,62,121,62,219,192,126,114,160,224,181,59,20,217,199,33,127,136,222,25,234,18,155,163,1,140,129,163,80,151,125,138,168,205,129,243,57,41,216,227,0,197,158,74,7,113,247,83,106,227,121,27,150,65,46,30,85,168,131,251,213,128,237,86,102,8,223,90,29,159,125,37,118,32,59,143,195,142,104,95,6,110,104,207,80,105,33,149,78,141,29,243,200,134,66,79,117,123,21,48,35,206,115,170,174,133,208,77,115,198,177,227,27,202,70,18,146,22,121,44,197,253,152,122,81,103,139,171,162,206,153,208,249,229,68,215,166,83,226,162,201,84,97,151,72,161,3,98,2,139,67,155,81,199,100,121,103,82,250,88,111,222,207,25,131,177,110,237,213,125,129,109,144,206,211,250,191,208,68,33,76,183,29,106,192,22,233,97,91,159,155,142,203,189,93,234,38,179,206,88,250,90,51,59,39,193,51,246,35,104,115,219,201,116,47,191,134,82,84,138,109,236,188,63,30,146,14,217,159,250,142,225,212,99,139,4,96,97,141,59,207,56,149,145,41,151,88,93,167,224,105,134,129,8,27,125,42,201,167,10,146,60,155,158,197,136,18,107,158,115,218,54,17,218,187,27,96,44,154,13,240,213,215,74,160,50,98,115,213,139,48,218,139,102,161,20,136,162,165,248,23,211,173,170,126,138,144,77,91,139,130,70,192,89,65,119,189,248,26,52,63,0,215,23,112,214,224,1,79,208,96,217,139,209,49,220,189,97,204,162,132,49,118,11,17,222,114,8,165,53,157,184,87,215,162,204,237,139,105,124,46,221,79,251,246,243,134,9,22,13,113,7,151,96,203,48,109,213,22,56,139,207,227,144,241,7,213,102,15,127,92,109,99,134,179,20,168,54,63,150,94,223,245,134,238,69,36,61,219,184,107,65,225,117,150,53,209,100,229,29,86,146,209,187,185,13,212,254,214,116,85,87,133,226,106,171,77,160,245,109,108,225,53,255,127,202,190,127,189,17,141,188,38,60,227,133,188,1,113,223,139,207,27,174,216,82,239,158,162,29,45,233,212,211,77,43,72,87,27,158,224,132,101,210,181,79,70,1,182,227,182,93,253,176,161,241,165,140,175,161,138,95,108,209,128,187,24,155,141,179,117,93,23,137,153,230,124,254,90,19,217,225,48,126,35,202,186,186,216,58,168,128,81,151,53,240,201,112,164,171,237,126,76,61,189,36,120,48,71,126,100,85,70,59,106,249,12,45,251,162,104,12,107,179,41,29,11,37,76,124,243,16,32,190,204,202,66,215,37,224,223,28,180,129,147,5,46,220,216,103,32,129,14,153,167,23,1,59,35,146,14,196,226,151,208,119,129,91,70,69,228,5,234,32,147,127,235,132,45,82,193,216,24,66,152,66,89,139,240,103,12,227,9,24,10,218,2,25,5,45,195,116,208,129,125,202,190,51,189,132,160,239,12,95,26,19,116,188,224,161,228,41,177,187,162,43,179,170,100,187,236,29,116,77,115,151,125,47,182,6,112,80,219,122,33,228,99,93,150,117,161,147,146,127,22,155,195,22,126,229,109,73,246,218,200,120,87,225,74,148,165,238,158,99,124,247,193,157,59,2,231,121,8,128,123,180,168,131,127,210,231,189,241,128,176,251,235,72,180,188,231,85,135,216,52,190,165,247,44,90,117,55,70,70,175,130,1,58,174,236,116,60,237,19,154,67,218,30,149,243,23,104,207,204,30,209,25,58,184,209,97,119,164,7,164,85,168,226,3,189,185,143,95,179,140,110,163,127,28,79,227,207,148,171,200,119,186,253,251,221,96,243,212,155,252,193,179,222,38,223,150,230,1,87,118,246,133,217,141,235,188,119,232,64,51,7,103,178,161,181,142,123,87,38,16,66,223,116,207,222,194,232,130,128,181,233,186,20,57,85,144,87,186,96,50,254,126,252,20,155,139,39,135,157,27,188,108,214,69,179,197,182,71,46,66,229,133,213,55,254,12,35,135,249,24,19,127,100,88,161,150,208,15,211,59,16,205,147,114,80,4,55,76,225,173,110,251,217,3,141,219,5,173,201,108,22,176,147,202,198,209,117,67,14,133,164,22,12,109,96,62,247,208,172,195,46,248,195,218,130,29,146,53,133,84,54,148,134,122,243,157,183,177,210,137,232,82,48,72,74,55,165,226,107,158,152,213,173,51,121,225,157,249,201,168,153,229,230,157,209,211,31,36,34,127,150,153,188,127,4,1,252,186,17,76,71,205,212,111,199,34,119,129,237,1,227,79,222,16,116,94,131,39,139,69,10,168,29,179,218,145,83,159,198,77,189,182,43,230,230,25,208,26,234,134,169,6,100,89,175,254,195,44,136,199,59,190,124,205,100,34,120,165,239,209,60,123,138,241,231,173,254,246,34,70,237,54,47,122,19,223,224,152,229,236,99,167,17,208,234,66,177,220,91,182,73,124,227,250,110,151,145,108,17,247,76,85,35,5,84,179,69,26,27,58,187,203,60,215,135,46,25,68,234,82,177,234,93,153,130,216,44,125,95,64,108,118,43,98,164,135,207,91,158,179,248,147,74,110,202,71,87,18,145,3,87,86,3,70,189,62,54,132,133,132,251,43,20,21,25,25,231,40,31,33,174,239,245,65,179,11,178,174,141,240,123,236,210,192,159,217,3,147,132,54,251,8,158,130,171,104,105,132,36,107,104,195,137,218,184,177,207,141,56,165,112,6,192,206,96,215,238,244,45,144,182,11,138,78,125,198,234,178,107,58,50,183,186,66,228,150,241,214,164,221,105,38,160,162,119,224,118,190,118,81,18,18,11,135,181,33,10,237,132,62,212,25,253,9,106,1,223,79,118,3,213,80,137,127,43,57,244,152,231,105,250,145,22,119,195,67,142,1,105,150,87,45,170,237,228,117,68,236,160,224,67,14,16,90,86,44,225,235,237,77,233,220,75,70,161,123,249,192,182,124,183,171,168,72,232,117,26,166,60,19,10,38,83,163,253,35,59,132,220,150,218,39,162,145,232,118,223,11,204,167,77,12,241,203,50,175,50,136,166,244,5,145,61,158,29,58,200,65,140,53,65,221,92,57,20,211,74,212,108,218,203,3,13,202,139,18,65,16,179,78,159,123,234,198,23,110,169,168,170,229,176,130,14,137,214,63,116,25,26,68,23,158,85,89,234,15,50,30,207,160,49,35,213,95,174,74,188,114,72,33,142,157,169,31,198,62,79,77,216,254,223,140,243,180,175,137,70,190,226,217,79,82,73,45,21,228,210,172,188,227,137,249,224,239,45,213,77,108,122,95,213,120,1,169,223,244,61,166,122,239,202,174,206,35,48,195,116,63,211,53,203,88,43,130,238,179,118,178,109,5,212,108,227,178,122,157,149,143,238,15,69,12,251,152,1,224,118,103,255,17,54,205,73,165,149,108,62,212,205,39,193,140,48,57,69,166,53,69,14,254,229,125,209,45,201,138,181,179,83,124,114,100,136,180,52,81,28,121,122,83,231,43,38,116,225,106,128,195,185,231,228,200,129,62,19,72,193,32,242,204,196,105,149,120,252,99,26,220,87,87,122,23,195,190,170,201,233,45,148,96,252,211,29,221,102,217,227,255,129,78,202,7,38,4,52,0,205,31,149,56,149,216,33,14,31,177,29,213,44,56,86,252,156,17,232,13,83,71,199,33,219,88,15,97,187,11,141,206,34,96,104,186,12,162,115,108,210,60,59,11,13,214,25,5,241,52,60,132,179,255,2,212,197,117,106,153,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7f88a5b-01f8-4d24-9883-14cb920af36e"));
		}

		#endregion

	}

	#endregion

}

