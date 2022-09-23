﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchServiceSchema

	/// <exclude/>
	public class GlobalSearchServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchServiceSchema(GlobalSearchServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69");
			Name = "GlobalSearchService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,90,221,115,219,54,18,127,118,103,250,63,160,234,76,75,77,84,58,233,189,217,150,114,138,44,39,202,37,182,79,82,46,15,153,27,15,37,66,50,27,138,84,0,208,177,46,245,255,126,187,248,32,1,18,148,149,220,181,115,115,125,136,69,112,1,236,247,254,118,217,44,218,80,190,141,150,148,204,41,99,17,207,87,34,28,229,217,42,89,23,44,18,73,158,133,47,211,124,17,165,51,26,177,229,237,247,223,125,249,254,187,163,130,39,217,154,204,118,92,208,205,105,237,25,54,167,41,93,226,78,30,190,164,25,101,201,178,65,243,38,201,62,53,22,47,169,104,172,205,40,187,75,150,244,109,30,211,116,239,203,112,8,87,222,73,134,247,211,189,167,139,6,193,252,150,209,40,134,133,246,55,225,60,226,31,121,227,61,156,6,199,115,14,215,206,68,36,104,69,48,202,25,13,47,162,165,200,89,66,173,141,107,169,205,147,147,81,190,217,128,114,223,228,235,181,115,241,37,253,44,64,117,104,134,215,220,22,102,74,185,152,221,70,108,91,45,29,98,177,115,145,127,221,134,87,52,221,82,230,223,3,34,157,191,168,94,161,244,74,14,31,185,125,168,239,253,101,145,184,166,57,143,68,4,124,9,6,90,243,109,120,155,103,9,170,211,86,151,255,186,71,72,43,190,13,3,211,188,16,123,136,95,9,177,13,135,11,46,89,67,207,174,8,199,140,229,108,146,173,114,210,175,171,202,22,206,200,21,150,244,112,4,28,242,35,163,107,56,144,140,210,136,243,19,98,11,161,183,75,178,227,227,99,114,198,139,205,38,98,187,129,126,86,180,132,75,98,248,35,169,201,150,229,247,187,208,108,57,182,246,124,208,7,26,86,254,137,107,231,116,21,21,169,176,212,64,229,250,140,111,27,107,67,190,133,24,5,197,109,193,107,22,73,154,136,221,148,126,42,18,70,55,52,19,60,176,31,80,104,208,200,35,91,144,42,212,11,113,23,47,217,22,139,52,89,146,37,170,195,167,13,114,66,94,68,156,234,167,30,153,76,33,62,175,178,116,103,71,33,156,243,69,170,173,84,239,69,66,211,24,244,123,205,48,73,40,157,30,109,213,3,153,188,165,2,178,212,148,110,115,38,40,35,55,27,247,185,175,172,163,130,121,7,73,77,156,213,182,12,130,238,169,115,34,6,235,40,77,64,70,114,195,202,223,14,77,51,230,200,205,218,27,135,229,22,14,194,129,114,48,37,229,32,50,153,64,246,32,55,41,252,211,39,240,243,109,148,69,107,202,144,65,76,43,148,5,29,251,146,78,247,84,43,133,102,177,210,139,171,164,107,150,195,141,2,210,85,139,162,60,44,59,15,88,27,142,142,214,84,232,95,71,201,138,4,30,161,72,191,79,178,34,77,187,134,238,200,75,212,84,123,147,129,65,144,209,207,144,108,51,136,205,2,9,135,108,93,160,111,5,157,2,66,2,94,100,170,24,117,122,250,170,163,119,206,122,87,89,238,232,232,65,253,97,84,20,44,107,53,133,34,123,112,245,2,119,203,154,96,59,234,59,150,54,245,161,15,15,212,134,174,204,18,110,38,134,186,50,163,2,115,17,86,79,241,143,40,45,104,224,114,220,35,142,89,225,162,78,183,157,183,4,92,16,35,12,156,112,158,108,40,4,115,59,91,64,219,37,223,204,20,166,111,45,252,223,11,202,118,250,186,125,204,217,113,98,253,244,251,81,21,71,198,127,200,79,63,145,31,28,39,153,179,29,48,232,250,189,201,99,229,246,78,143,160,26,172,3,187,150,39,218,215,16,116,46,155,49,98,116,216,175,43,245,193,239,70,181,224,119,180,112,88,28,230,2,52,76,99,69,82,175,3,158,66,176,84,54,201,25,185,85,113,148,64,108,68,25,164,206,51,78,41,89,50,186,234,59,250,25,153,13,202,205,59,199,131,176,188,202,174,31,222,52,80,219,236,198,77,237,165,206,101,90,32,114,151,48,81,0,223,251,142,219,247,174,205,141,247,177,64,158,63,87,180,68,253,23,236,37,238,107,159,208,196,123,211,81,109,239,87,228,37,82,79,72,158,128,241,218,221,178,167,170,137,218,219,147,40,77,254,37,13,89,218,254,17,139,250,182,147,155,223,0,127,86,207,53,235,121,183,188,118,118,180,91,200,61,25,140,2,134,168,173,169,216,243,221,18,28,172,160,17,138,158,166,50,137,17,145,127,164,153,55,24,108,178,57,82,237,11,129,186,247,54,54,123,86,188,249,12,49,37,66,49,122,15,112,177,96,12,243,203,15,85,94,243,188,6,164,196,183,224,81,212,208,85,89,75,43,118,223,166,80,165,161,243,132,235,12,65,99,201,157,55,111,53,100,8,47,243,140,30,158,194,0,30,221,230,13,192,229,53,210,69,146,2,130,226,100,11,193,5,122,21,187,45,229,100,177,35,209,114,9,144,142,176,100,125,43,56,201,87,100,169,149,132,241,211,98,30,185,178,141,88,180,33,25,244,181,253,14,158,214,25,32,214,143,126,225,20,223,160,237,224,20,0,162,132,47,111,233,38,146,148,60,60,59,150,251,170,99,148,38,248,33,155,201,74,202,0,47,129,111,155,77,87,8,184,195,28,234,65,15,74,15,115,96,248,197,110,40,183,77,229,46,13,22,164,98,140,193,239,34,6,233,94,181,34,16,41,248,74,153,47,156,109,1,99,7,63,247,126,238,234,133,247,183,192,88,173,88,67,19,55,163,192,39,200,49,206,160,253,164,152,205,38,124,44,37,155,73,193,166,170,237,29,166,105,254,25,160,185,178,188,118,14,197,80,248,58,79,178,160,211,131,4,102,88,81,100,181,26,143,229,83,215,74,240,6,84,35,213,143,193,68,133,182,126,148,160,65,87,49,123,169,71,90,52,128,207,51,245,170,111,152,154,240,75,8,140,43,54,222,108,197,46,80,59,116,202,215,20,242,13,57,113,214,46,114,182,137,32,53,31,127,121,250,0,242,180,154,66,158,135,82,254,8,17,124,57,158,207,230,195,203,243,225,244,252,215,155,167,242,188,10,42,132,152,185,16,3,170,60,246,142,37,193,204,189,11,174,250,242,236,225,248,70,9,252,92,253,185,193,27,250,241,138,223,124,66,209,111,196,45,205,110,86,84,0,122,215,248,181,14,50,123,150,26,20,107,52,229,180,157,155,63,129,11,201,68,22,39,171,210,82,76,219,191,2,84,198,35,116,2,83,249,2,222,171,31,225,203,241,92,223,164,9,21,191,64,128,40,83,61,200,249,136,166,122,93,47,30,238,130,202,91,149,221,46,166,195,183,227,247,87,211,191,105,183,150,87,132,195,56,126,145,199,187,160,233,130,174,94,45,122,188,102,239,158,82,13,123,176,66,56,220,110,129,112,4,9,4,147,75,148,242,64,95,225,198,157,94,244,5,25,218,183,172,14,16,204,114,202,96,22,130,137,210,184,126,205,244,143,158,53,187,160,214,20,195,174,44,104,188,68,45,87,36,80,174,209,140,213,238,210,136,156,67,3,10,180,230,10,53,237,208,235,218,84,114,105,164,198,3,37,157,97,14,219,247,130,135,243,92,185,82,208,45,45,7,127,94,108,55,38,97,104,81,184,251,168,49,67,131,76,243,55,43,84,54,238,147,21,232,216,225,71,139,142,162,218,55,42,223,85,167,160,169,181,99,129,253,238,0,160,135,165,131,93,45,126,3,123,6,134,84,155,13,59,115,165,129,192,205,51,127,237,184,242,158,16,8,67,211,158,218,42,131,23,207,202,23,178,176,103,2,214,126,125,232,17,179,106,78,130,229,191,96,238,66,17,194,82,199,250,217,88,160,82,184,62,172,231,136,215,173,229,121,71,139,62,183,187,203,147,24,218,222,210,183,46,1,120,92,176,124,19,52,109,176,168,175,128,251,205,106,52,148,215,72,36,55,7,21,9,219,97,1,166,139,75,10,193,20,191,74,196,4,179,74,227,114,57,107,12,223,0,97,208,13,39,241,169,179,119,146,197,244,30,197,24,227,19,78,121,112,19,96,70,221,15,212,217,12,203,199,34,21,33,220,137,14,252,38,193,179,181,149,194,139,36,139,229,177,193,61,233,15,76,177,26,127,42,48,216,239,129,131,94,157,235,158,206,212,114,118,198,18,176,78,56,201,128,195,36,202,196,8,238,41,24,157,172,51,232,213,71,16,250,198,112,77,57,141,69,176,66,54,148,22,202,55,79,246,11,253,132,60,243,153,126,145,231,41,102,26,100,249,77,30,197,83,186,204,89,204,113,134,0,62,133,191,71,121,129,14,118,128,43,24,227,225,222,232,46,74,210,104,145,210,105,117,136,207,130,229,12,224,57,121,74,78,218,44,44,183,59,78,237,61,255,204,102,185,85,218,87,17,31,154,221,165,150,148,212,7,2,25,20,80,228,34,74,47,224,162,216,226,192,104,160,22,121,214,113,70,220,223,127,223,99,72,207,155,25,164,39,144,207,123,235,33,118,69,7,186,134,220,113,88,72,255,167,122,80,175,88,171,98,60,14,231,56,155,199,181,176,151,106,55,156,143,59,191,133,124,202,114,11,235,248,30,64,181,160,215,121,9,111,2,27,234,152,154,174,37,194,15,74,103,206,1,3,34,96,77,87,96,229,180,2,20,168,171,151,126,103,129,58,235,62,60,108,200,119,217,210,32,135,94,179,133,51,131,78,60,40,124,31,65,155,96,250,104,178,140,0,219,145,96,124,191,164,91,217,44,211,251,178,183,44,191,59,213,138,180,156,70,23,252,180,234,104,233,61,73,184,153,144,149,103,85,77,170,218,160,101,240,29,25,226,222,248,170,208,17,11,21,212,157,196,135,234,71,80,162,15,53,133,39,95,180,223,217,208,194,198,91,229,122,88,78,235,202,169,47,65,88,71,42,246,175,0,144,73,157,41,253,209,184,82,10,132,94,32,173,96,181,233,82,153,19,110,136,187,95,35,237,112,129,82,197,127,152,176,250,252,134,176,135,115,40,207,250,195,248,211,161,40,23,44,38,43,183,107,64,86,167,129,112,193,221,81,205,59,251,218,63,205,216,223,134,85,136,102,239,13,40,210,183,158,58,243,15,102,131,30,205,146,126,37,45,174,106,189,157,18,30,159,132,200,47,91,123,6,33,211,34,211,95,135,117,206,60,116,200,33,155,52,133,22,58,3,157,116,21,192,104,12,53,236,109,186,107,87,93,255,37,44,117,6,102,14,165,95,153,89,7,210,239,63,203,74,194,56,110,193,154,154,175,224,152,84,13,203,212,107,207,144,165,57,171,193,174,91,207,83,246,147,175,160,228,117,6,23,9,227,166,96,64,237,0,12,67,86,57,51,10,108,29,234,24,228,142,21,193,153,163,214,235,135,51,68,117,231,55,31,170,84,97,125,81,61,250,240,158,46,0,169,65,198,13,202,174,182,115,125,53,155,3,56,175,55,179,64,170,189,208,110,105,9,118,148,51,177,75,169,67,82,174,134,239,89,4,29,99,220,51,93,190,228,116,255,161,242,227,170,249,186,234,124,175,50,243,37,203,139,202,137,75,195,69,26,245,217,25,206,160,164,29,69,178,82,152,243,169,13,237,182,192,210,101,33,151,79,203,69,111,177,5,146,95,20,234,60,12,253,59,53,243,0,160,226,208,127,190,77,64,211,129,15,243,120,16,206,193,128,161,231,192,152,178,46,120,153,183,63,51,226,44,78,143,87,96,59,181,41,3,215,70,77,227,56,134,209,234,238,73,91,152,236,234,78,99,106,243,56,175,108,56,242,210,155,253,115,4,56,199,131,124,220,9,134,196,7,45,221,62,150,211,214,10,132,237,79,74,33,135,84,133,21,69,160,110,54,111,76,60,106,157,120,153,188,221,177,80,213,192,7,246,129,181,74,36,239,227,13,7,178,7,1,231,148,187,163,128,179,122,111,59,168,164,215,173,183,173,153,189,29,165,231,107,249,159,83,137,31,85,90,171,218,123,254,1,145,61,34,234,40,30,208,139,80,70,64,94,20,7,179,213,103,122,155,235,142,28,218,42,117,116,52,193,67,253,203,253,30,173,168,187,74,181,156,235,15,219,136,3,234,154,159,231,249,199,74,5,104,251,45,203,113,108,4,72,144,91,230,119,66,246,90,145,140,107,135,53,236,90,66,240,150,164,231,185,10,24,2,90,203,87,90,59,225,202,63,124,249,206,115,180,31,21,182,116,210,195,56,158,70,25,228,68,31,143,72,81,179,134,151,85,171,41,39,131,190,175,207,107,187,191,125,136,51,143,62,82,187,9,236,150,195,23,227,198,190,1,149,39,179,55,166,79,190,49,147,43,164,78,177,79,158,120,112,98,107,212,52,123,84,27,71,250,191,240,83,65,162,245,26,32,101,164,190,249,44,118,170,94,255,111,35,68,47,218,74,193,54,8,14,125,168,107,88,201,248,255,5,188,62,40,254,79,136,38,184,70,69,65,89,99,1,170,21,25,53,223,208,58,62,164,6,246,127,201,242,2,174,158,105,178,175,66,109,246,112,20,220,168,244,243,189,24,100,88,18,126,45,14,233,218,195,243,22,168,225,103,163,7,248,81,239,254,118,172,241,223,131,26,223,92,255,156,255,67,65,3,136,161,37,241,193,32,194,10,136,71,145,4,38,189,51,95,40,13,200,26,157,135,183,86,45,207,45,129,143,97,247,243,64,171,90,212,109,78,86,171,117,199,106,213,93,132,181,127,3,1,192,185,123,140,46,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69"));
		}

		#endregion

	}

	#endregion

}

