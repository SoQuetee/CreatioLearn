﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseMessageListenerSchema

	/// <exclude/>
	public class CaseMessageListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseMessageListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseMessageListenerSchema(CaseMessageListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aeb83d7e-bd4f-4fc4-aca2-39d357ab89e4");
			Name = "CaseMessageListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("080146f8-bb59-4a0f-bbe7-1f7bf34882f8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,109,79,219,72,16,254,94,169,255,97,47,39,245,140,20,44,224,174,7,229,77,74,3,225,114,2,138,18,122,247,161,170,208,198,158,36,46,142,215,218,93,3,17,202,127,191,153,245,58,241,107,18,250,237,22,9,197,246,204,236,204,51,207,204,206,38,42,136,38,108,18,138,17,15,143,143,187,98,54,19,145,123,45,38,19,124,125,242,254,93,98,62,15,231,74,195,172,244,232,118,69,24,130,167,3,17,41,247,10,34,144,129,183,20,185,7,41,185,18,99,141,82,18,26,94,187,61,238,105,33,3,80,77,2,67,111,10,126,18,130,44,237,61,4,173,241,73,177,179,178,70,87,68,227,96,146,72,78,126,185,40,157,137,162,5,250,139,248,12,84,204,61,40,40,230,116,222,191,123,37,57,134,235,87,9,19,124,195,186,33,87,234,152,117,185,130,27,80,138,79,224,58,64,47,48,226,76,50,78,70,97,224,49,143,4,235,228,216,49,251,92,167,77,186,203,237,10,91,34,168,154,71,26,183,189,147,193,19,215,144,151,138,211,87,204,35,41,166,180,36,100,126,136,209,45,6,135,144,180,200,131,59,33,53,15,237,142,55,73,168,131,107,30,77,18,124,184,147,194,195,215,127,139,81,235,100,179,205,43,41,146,248,173,134,141,82,157,117,12,74,35,80,18,184,47,162,112,206,250,72,53,246,16,226,191,51,134,63,111,120,132,118,36,210,73,19,7,65,58,173,26,52,91,59,39,5,204,32,242,83,216,234,144,236,5,16,250,235,97,92,122,243,85,129,68,228,163,148,213,236,33,41,60,215,132,179,212,188,74,2,159,61,196,6,154,91,161,131,113,0,178,239,99,80,17,60,155,143,78,107,175,251,231,254,69,231,168,179,123,216,57,248,180,251,199,65,119,111,247,211,209,225,225,238,222,209,197,199,222,101,111,255,99,239,224,200,68,182,97,19,111,153,131,116,35,207,208,214,98,223,247,223,0,141,33,153,76,168,6,17,31,67,225,2,60,41,169,107,18,224,148,128,42,226,180,131,108,31,161,146,83,126,253,186,178,77,235,47,180,38,228,156,106,124,198,243,12,179,187,217,239,121,26,85,212,6,48,6,9,145,7,216,140,146,89,148,183,210,247,203,154,153,251,169,234,87,147,31,146,52,56,40,151,126,46,63,149,84,111,1,252,238,20,188,199,203,23,99,196,131,47,227,1,120,66,146,13,196,16,74,242,37,234,160,80,35,151,140,248,134,164,162,126,177,241,81,133,252,195,195,4,78,137,20,231,37,168,219,69,235,180,182,43,221,86,219,144,204,189,156,197,122,158,231,226,98,123,86,221,128,158,138,180,226,132,70,127,192,47,214,156,125,201,250,198,163,68,77,179,122,97,24,83,254,217,169,48,70,130,78,164,237,199,233,217,49,39,32,78,43,166,206,29,170,187,28,191,59,114,146,204,32,210,78,171,136,20,6,92,74,213,78,99,216,43,215,159,4,22,226,32,201,242,227,152,194,148,134,14,125,191,226,245,218,98,193,204,54,183,25,90,35,33,66,22,168,52,253,100,10,53,198,60,84,101,198,5,99,230,148,44,185,221,68,98,113,104,210,114,87,175,239,231,49,22,201,153,241,139,126,187,195,225,93,197,105,90,155,60,117,59,113,156,123,90,185,216,24,140,113,180,24,75,77,241,208,162,51,193,237,71,99,209,19,114,198,49,111,54,22,227,20,211,20,66,160,24,122,238,154,56,168,240,143,217,235,222,162,189,204,3,62,238,47,170,249,45,128,66,106,43,141,157,146,31,11,6,136,115,29,50,219,121,119,251,229,126,43,15,127,222,193,26,10,108,234,36,191,156,49,31,198,28,139,223,208,118,167,54,243,79,92,178,89,122,22,87,90,151,107,109,165,173,210,158,216,53,25,36,27,113,94,20,45,89,155,110,47,136,252,62,114,224,243,28,91,237,70,159,203,97,103,177,22,173,99,96,81,18,134,181,241,208,186,8,140,251,92,206,79,211,233,166,205,196,232,7,198,116,206,98,46,17,103,13,82,217,19,123,141,108,131,117,90,175,173,129,77,84,107,149,179,69,189,252,162,38,38,90,21,102,89,20,104,114,146,212,250,217,115,160,167,121,10,237,45,90,205,12,201,22,86,234,114,150,118,239,101,64,179,21,206,105,78,26,29,53,7,196,220,177,35,100,155,181,30,242,54,219,133,57,176,93,204,106,74,209,102,80,74,228,249,87,200,71,51,127,91,106,111,228,254,42,55,237,66,235,104,138,116,61,128,216,188,223,140,95,115,27,88,183,95,161,60,168,27,16,57,217,88,200,226,222,41,2,182,57,236,47,202,128,80,127,198,15,7,11,151,101,113,60,115,245,155,206,162,201,185,190,5,150,91,31,15,181,48,252,124,115,220,102,244,96,202,164,150,169,236,106,135,144,1,141,33,255,87,204,22,27,199,8,241,132,87,208,192,135,244,140,239,71,104,83,91,132,170,179,143,105,201,233,71,194,22,27,21,205,216,110,54,241,220,172,62,213,14,16,198,248,0,20,34,159,169,150,54,44,169,153,153,198,51,115,52,53,238,149,121,55,27,163,213,5,215,252,91,101,168,254,94,51,152,20,182,255,240,33,221,223,238,156,191,46,157,85,239,80,181,253,92,203,121,83,61,18,78,89,122,75,142,103,70,179,46,189,109,7,249,150,94,39,12,167,190,179,45,217,60,21,73,232,179,17,44,251,14,209,216,106,88,22,15,74,115,64,222,87,43,153,167,106,154,140,166,190,151,27,71,215,55,51,108,244,222,148,57,151,47,30,196,102,174,131,151,198,51,211,64,113,41,165,144,85,44,126,71,44,58,168,77,95,153,240,188,68,82,115,157,6,33,172,206,42,123,82,148,226,238,242,48,28,106,238,61,218,242,237,99,25,201,165,63,6,102,68,3,94,86,32,224,111,163,112,47,241,228,48,143,69,157,117,224,212,28,192,149,139,70,74,141,249,45,60,103,229,80,111,175,100,203,222,71,242,236,222,230,206,84,248,88,188,76,45,254,3,41,168,37,133,144,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aeb83d7e-bd4f-4fc4-aca2-39d357ab89e4"));
		}

		#endregion

	}

	#endregion

}
