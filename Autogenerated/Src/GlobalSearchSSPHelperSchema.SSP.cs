﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchSSPHelperSchema

	/// <exclude/>
	public class GlobalSearchSSPHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchSSPHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchSSPHelperSchema(GlobalSearchSSPHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10bd2ab5-ff5f-1410-bce9-6f92272bc8bf");
			Name = "GlobalSearchSSPHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,90,109,111,219,56,18,254,236,5,246,63,176,46,176,144,129,156,114,247,225,22,135,38,113,225,196,73,214,119,73,157,171,211,235,135,162,88,48,18,237,8,43,75,94,82,74,235,237,230,191,223,240,77,124,17,101,41,197,225,80,32,137,40,206,51,195,153,135,51,67,170,5,222,18,182,195,9,65,247,132,82,204,202,117,21,95,148,197,58,219,212,20,87,89,89,196,215,121,249,128,243,21,193,52,121,252,133,228,59,66,127,252,225,219,143,63,140,106,150,21,27,180,218,179,138,108,79,188,103,128,200,115,146,112,121,22,95,147,130,208,44,105,205,153,227,10,183,6,111,178,226,119,51,104,219,68,73,104,220,182,174,75,46,190,194,73,85,210,140,48,51,227,178,168,178,106,191,74,30,201,22,163,51,95,64,188,133,249,177,61,173,19,126,85,117,24,39,222,206,207,15,122,7,156,157,212,148,146,162,10,35,108,183,101,209,137,173,237,132,9,252,223,232,53,37,27,64,69,23,57,102,236,13,178,157,179,90,221,233,232,193,196,79,203,39,64,202,82,242,25,30,118,245,67,158,37,40,225,66,97,25,228,98,105,160,209,55,1,102,212,194,130,42,92,84,160,250,142,102,79,184,34,242,253,78,62,160,155,140,85,167,215,117,150,78,209,175,108,207,164,91,65,9,31,63,145,83,143,143,143,239,151,243,229,27,68,201,182,124,34,8,175,43,80,159,148,219,93,78,42,238,129,234,145,160,10,179,223,208,235,213,252,47,63,255,245,239,255,64,182,6,227,205,121,38,28,140,233,254,148,85,20,36,143,164,122,249,48,5,11,112,158,151,95,72,122,87,210,10,231,16,146,122,91,176,19,215,224,135,178,204,209,175,25,155,5,166,46,10,112,61,206,179,63,72,170,164,94,147,34,149,158,112,221,114,71,75,112,23,143,83,135,95,132,154,5,187,144,150,127,96,132,130,83,208,217,20,241,63,97,73,133,36,75,108,77,136,205,240,253,126,71,208,217,153,152,204,255,142,65,216,91,7,247,57,178,164,23,105,15,250,34,61,233,12,221,202,139,28,135,106,133,19,189,125,139,162,246,232,25,186,38,21,60,52,24,31,22,105,52,153,132,220,14,118,72,127,203,137,42,4,202,249,92,167,100,228,108,183,91,145,138,83,131,197,7,69,12,193,254,95,12,11,177,6,241,212,57,26,109,72,165,254,26,101,107,20,189,234,231,216,68,207,31,5,137,43,61,27,194,184,162,229,246,2,131,67,34,238,230,145,86,217,129,114,134,138,58,207,141,178,145,49,33,4,110,48,159,181,117,189,43,1,83,43,90,19,37,248,44,195,50,26,81,82,213,180,232,220,150,90,197,243,225,189,38,82,16,173,121,190,135,205,38,18,91,19,119,116,202,234,237,22,226,53,213,3,214,236,184,153,116,236,207,58,221,97,138,183,168,128,82,121,54,174,157,77,51,158,122,155,232,244,88,76,22,178,42,175,6,51,106,228,202,33,23,118,2,9,247,1,51,18,249,195,223,80,207,250,111,73,245,88,166,61,137,70,5,72,22,183,72,242,21,17,241,244,14,22,169,163,239,212,72,166,75,165,183,96,123,210,45,46,240,6,178,199,85,86,164,11,81,10,18,114,46,32,35,11,93,6,147,115,80,99,122,164,83,76,88,227,156,17,43,242,163,39,76,209,26,160,165,74,48,197,207,68,66,113,68,120,114,16,25,81,226,199,144,99,148,82,133,252,202,160,196,151,191,215,160,39,226,169,45,190,220,238,170,189,156,250,220,153,254,66,9,76,89,110,205,106,50,159,74,123,5,249,98,129,232,109,195,87,100,114,36,225,77,193,191,107,66,247,42,79,238,217,109,153,214,57,81,62,54,239,181,188,108,10,34,14,147,62,92,126,37,73,13,76,14,197,136,213,148,204,207,205,16,228,92,237,109,133,177,224,237,216,123,130,83,72,134,169,249,243,44,104,95,44,117,17,57,41,50,186,13,236,232,203,99,150,19,20,25,172,152,255,178,20,123,203,255,192,139,146,111,249,252,156,87,52,24,128,118,5,210,52,60,255,7,231,53,185,47,185,27,45,236,79,99,112,150,77,69,64,27,127,110,146,147,208,68,220,150,239,197,60,230,145,182,173,53,232,156,203,14,250,43,201,104,244,211,79,60,142,11,118,147,37,164,96,205,142,179,231,198,98,79,88,78,25,57,212,137,103,105,151,86,157,113,159,155,68,218,252,84,60,119,144,66,180,150,33,237,227,154,178,77,129,114,38,203,215,94,14,155,196,115,80,147,21,240,98,34,77,138,101,250,142,198,30,250,248,8,133,226,165,165,120,197,178,100,22,197,199,146,254,182,203,225,144,50,158,196,51,214,245,74,73,255,179,204,138,136,255,16,189,208,2,172,163,82,157,20,241,33,26,185,165,109,39,183,144,91,20,47,152,72,16,29,58,109,96,107,1,61,38,40,39,120,134,232,209,144,57,198,109,29,70,141,219,248,150,61,31,31,9,37,7,151,208,60,75,252,34,2,74,52,99,14,25,38,8,51,21,255,195,140,10,139,15,229,146,71,160,16,59,218,161,151,235,156,64,118,2,34,178,72,237,143,62,37,70,141,252,21,139,174,32,250,219,196,188,111,116,206,210,109,86,124,128,94,38,192,188,78,3,134,152,208,111,68,135,25,239,203,220,178,192,9,182,63,75,134,218,140,218,84,82,90,239,120,243,66,32,211,70,206,105,193,177,98,6,53,118,0,60,31,51,97,19,146,54,111,131,158,12,88,104,232,102,220,172,45,112,4,109,93,67,53,57,180,55,154,36,76,15,211,159,74,56,83,65,118,150,158,187,47,131,237,177,56,120,49,157,225,142,228,65,44,17,47,121,46,87,187,225,127,86,157,188,34,193,113,165,50,94,100,0,213,86,242,86,17,142,9,32,9,96,44,211,111,69,185,229,210,86,215,38,250,69,112,241,59,40,113,75,42,154,166,200,168,153,120,125,156,223,193,73,35,3,6,197,174,154,224,65,128,111,139,10,103,5,251,23,217,71,6,201,232,12,74,125,50,51,63,243,130,186,88,191,43,43,181,71,45,195,149,165,136,64,223,57,24,207,238,237,212,201,15,186,116,206,198,35,219,247,207,237,35,140,67,164,190,99,150,178,167,235,236,199,77,24,126,50,213,237,163,74,214,76,254,18,61,167,4,158,37,9,97,76,194,171,188,165,68,228,92,191,255,179,250,197,169,246,156,137,181,236,236,172,70,16,244,88,236,82,45,241,216,106,4,78,12,68,67,201,33,16,23,122,114,3,97,142,25,48,26,104,246,209,159,127,26,21,129,247,166,49,179,217,172,123,174,190,237,111,237,124,179,181,20,19,154,24,4,79,237,247,165,125,102,239,44,178,221,225,122,89,161,181,74,173,115,131,34,128,57,119,68,194,244,59,181,150,148,124,114,165,172,152,40,41,85,199,58,20,201,182,168,235,165,134,184,33,235,106,9,12,164,162,215,234,82,111,99,181,95,54,139,88,30,92,128,109,10,31,11,23,154,110,183,217,43,87,197,121,144,143,99,72,82,209,68,229,217,168,167,26,189,224,90,170,255,158,200,229,142,87,138,102,187,93,158,37,226,219,128,152,30,127,204,170,199,155,50,1,32,120,4,21,145,241,14,168,146,251,115,184,121,211,136,159,174,33,187,80,40,12,151,197,38,43,72,28,50,87,232,134,42,16,220,32,34,165,246,237,44,181,202,239,93,94,12,248,75,250,94,92,34,138,69,190,208,240,163,240,85,87,112,61,226,222,230,23,172,182,248,85,73,165,8,55,93,95,223,152,146,116,132,212,144,85,218,220,136,134,204,234,170,172,252,12,27,154,239,212,84,45,219,170,166,161,107,148,203,213,108,179,161,100,35,124,172,239,83,244,149,20,179,222,177,40,52,31,91,19,236,6,106,67,203,122,199,236,114,236,10,70,214,197,147,141,1,221,228,222,186,149,104,96,156,57,188,69,2,19,229,221,146,127,129,70,98,126,206,155,76,236,78,71,121,90,162,117,134,52,116,57,208,121,29,23,222,142,243,115,143,115,2,115,246,132,179,28,63,228,100,89,172,216,174,117,251,230,217,178,184,44,234,45,161,124,254,233,226,154,155,12,22,52,219,51,144,56,244,119,39,158,51,222,19,182,3,23,145,104,32,138,116,137,183,40,57,168,210,99,135,147,249,102,239,222,29,23,184,224,173,129,42,130,171,187,174,189,97,119,210,114,178,218,39,158,69,93,187,205,130,74,244,73,205,105,148,197,142,113,172,9,8,57,235,24,112,151,91,86,16,110,146,30,184,202,134,224,32,172,163,174,180,240,95,138,38,3,111,183,13,81,198,83,69,65,125,243,203,39,56,215,219,66,88,122,139,77,79,25,1,173,148,172,207,198,54,15,218,222,158,142,143,167,0,163,229,20,208,247,125,145,81,94,65,165,250,152,137,122,84,11,6,107,31,233,116,220,124,139,237,222,121,60,101,28,254,28,5,93,228,43,255,3,158,127,159,205,47,244,227,195,22,180,110,201,245,215,145,239,59,33,242,84,208,115,13,175,108,115,206,97,202,46,231,82,229,43,223,147,193,61,102,32,143,208,87,119,131,118,19,213,228,86,189,245,135,18,148,23,8,166,115,206,216,230,157,147,238,155,25,199,83,148,41,31,196,104,8,125,3,165,131,131,36,77,148,224,124,136,89,149,37,112,110,226,159,116,236,197,120,196,14,48,180,163,2,58,117,79,228,78,22,5,215,131,92,7,4,11,160,38,90,8,212,19,119,72,208,250,2,253,246,96,113,214,137,252,77,160,202,117,70,94,249,140,234,229,188,52,250,29,145,151,95,215,236,160,123,138,134,197,126,88,9,227,240,194,110,8,172,199,133,70,93,47,17,134,215,220,75,230,174,174,161,135,59,140,72,144,21,216,167,128,67,144,32,50,121,17,63,14,181,4,45,229,156,45,173,193,94,226,192,49,27,165,100,141,235,28,8,148,148,148,128,187,213,39,255,129,196,89,215,133,252,255,54,227,105,187,134,217,19,183,160,35,187,197,85,242,200,47,172,97,61,158,64,32,146,242,34,16,142,13,251,185,180,113,197,77,212,255,41,65,247,176,87,202,130,41,106,108,57,210,217,224,214,81,186,159,162,150,21,118,37,234,46,52,34,174,221,150,88,138,219,10,122,63,177,203,81,119,240,249,191,232,34,120,46,63,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10bd2ab5-ff5f-1410-bce9-6f92272bc8bf"));
		}

		#endregion

	}

	#endregion

}

