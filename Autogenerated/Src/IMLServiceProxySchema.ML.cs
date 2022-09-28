﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLServiceProxySchema

	/// <exclude/>
	public class IMLServiceProxySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLServiceProxySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLServiceProxySchema(IMLServiceProxySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3985eb50-d2b3-4d48-8a6a-1934838eb692");
			Name = "IMLServiceProxy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,77,111,35,55,12,61,103,129,253,15,130,123,104,22,48,236,123,214,49,208,38,221,192,128,189,13,226,164,61,203,51,28,91,197,124,24,146,198,169,177,216,255,94,146,146,230,43,246,216,73,129,160,221,75,98,143,169,39,242,241,145,148,38,151,25,152,173,140,64,60,130,214,210,20,137,29,221,20,121,162,214,165,150,86,21,249,104,49,255,248,225,219,199,15,23,165,81,249,90,44,247,198,66,246,185,243,29,151,164,41,68,100,111,70,119,144,131,86,81,109,83,35,47,230,163,89,110,65,39,184,161,57,105,48,122,64,215,16,145,77,209,248,39,13,107,220,65,84,22,87,98,182,152,47,65,239,84,4,247,186,248,123,207,102,227,241,88,76,76,153,101,82,239,167,254,123,181,68,36,133,22,145,76,83,218,55,147,209,70,229,32,82,144,58,167,7,198,97,141,2,202,184,1,179,45,87,169,138,196,86,106,171,100,42,84,133,248,194,135,139,111,236,71,229,239,2,236,166,136,205,149,184,103,8,247,99,215,75,126,176,180,136,110,68,14,207,194,106,169,114,116,200,24,74,66,181,98,220,93,50,65,135,100,38,114,204,227,245,32,3,43,111,165,149,131,41,238,41,69,140,31,69,145,8,187,1,145,21,49,164,63,27,244,123,91,90,33,243,88,20,165,197,143,163,201,152,17,142,0,210,170,101,180,129,76,206,98,68,157,59,28,97,248,145,80,49,228,86,37,10,244,75,24,13,182,212,185,153,62,226,230,181,93,112,199,80,164,16,87,1,78,198,193,158,0,238,74,21,59,50,30,137,134,165,51,186,52,86,115,218,124,148,67,193,118,45,31,63,125,238,161,247,105,155,22,50,54,142,23,91,56,71,234,148,159,195,112,204,236,222,122,128,146,1,251,41,244,17,18,125,135,169,224,76,59,245,5,46,106,184,93,129,17,58,191,105,211,64,65,92,135,95,225,247,134,254,43,74,49,55,173,253,206,13,217,54,82,16,162,104,169,179,87,6,29,121,98,33,124,197,207,131,41,253,13,12,60,195,74,184,223,94,198,206,142,63,122,151,47,57,226,182,67,67,81,203,194,163,247,50,113,7,150,170,0,251,64,198,13,78,200,21,86,194,225,76,188,11,67,65,248,157,18,0,27,16,209,215,208,9,201,251,64,70,227,231,67,188,244,146,112,131,29,208,136,40,149,104,156,168,200,17,241,202,82,224,186,155,229,88,201,121,4,79,33,110,215,31,148,127,140,129,247,75,194,213,211,140,155,18,151,37,114,148,98,137,114,155,110,187,199,200,199,233,155,43,99,73,80,19,3,32,34,13,201,245,224,166,5,128,28,150,169,29,140,167,157,102,211,182,250,157,187,162,240,15,247,151,117,139,105,132,58,20,183,138,167,29,146,51,113,242,27,138,98,245,23,142,192,41,135,209,75,254,50,42,52,24,129,243,213,141,35,133,19,84,60,43,187,97,17,174,213,14,114,199,133,155,142,220,165,182,16,145,124,188,43,175,74,17,182,109,250,55,68,32,105,133,217,20,101,26,139,45,14,47,172,0,108,228,5,121,127,78,146,40,187,205,137,194,110,55,49,87,192,112,112,34,229,91,180,64,246,240,148,129,196,173,74,62,52,12,42,211,89,30,83,38,192,12,133,74,130,36,195,14,46,109,168,174,88,237,84,92,226,24,78,64,226,35,76,120,19,141,90,115,177,3,141,34,23,126,183,118,53,31,145,208,189,179,165,177,68,113,112,134,58,98,89,58,190,188,74,56,147,151,139,57,19,236,142,77,46,65,39,5,50,20,171,162,168,188,107,113,113,174,118,92,145,164,94,246,148,13,243,159,87,17,21,169,83,82,240,59,40,202,249,255,195,203,201,116,244,68,132,76,90,162,154,246,169,106,198,246,199,181,229,196,69,70,67,66,191,120,155,200,238,93,90,81,102,176,214,126,130,97,138,242,50,163,131,189,216,201,180,132,119,21,223,233,41,115,222,1,228,28,9,82,92,117,220,199,231,77,157,221,22,47,135,242,27,23,120,240,135,169,120,112,176,199,102,202,249,201,61,55,123,81,145,101,144,199,110,126,82,96,117,18,74,172,5,243,150,14,80,177,222,79,53,227,15,166,79,244,143,10,104,13,182,227,80,255,122,178,213,177,185,41,202,28,211,245,181,204,86,238,196,236,251,68,81,131,113,96,128,87,57,142,169,31,53,81,41,94,219,102,132,129,167,142,0,229,158,158,189,146,104,112,100,144,67,238,135,225,25,139,127,73,53,200,120,207,119,81,73,202,241,126,124,225,95,233,62,38,164,51,113,183,75,182,9,170,212,69,214,108,62,39,185,247,216,79,91,36,59,164,219,97,157,228,93,166,81,153,226,170,39,151,194,135,250,137,135,105,231,209,248,34,111,28,188,106,7,198,211,230,110,15,173,133,213,161,182,122,124,184,233,113,89,80,205,76,221,254,67,162,71,52,5,226,154,93,195,174,145,45,113,141,5,154,166,206,164,237,192,151,118,78,69,39,199,184,178,215,126,244,231,6,9,109,52,218,190,52,35,152,213,37,248,104,232,46,103,192,254,65,29,195,69,245,210,87,134,236,166,3,45,18,153,154,254,43,142,111,77,33,49,120,107,95,254,219,163,253,226,109,13,183,121,227,243,94,53,220,241,87,54,182,61,107,200,99,14,238,233,169,169,208,168,177,177,225,9,89,91,149,1,22,216,18,34,236,253,238,51,247,141,190,146,178,251,45,52,49,30,113,64,243,59,144,224,190,14,2,38,75,92,95,45,56,58,45,200,221,176,170,51,41,8,61,100,110,66,95,166,199,230,196,139,251,238,80,212,240,238,42,213,229,203,41,138,202,166,38,2,165,212,126,115,53,186,133,68,226,21,169,6,243,76,125,18,207,27,192,3,12,187,120,69,175,167,46,73,127,23,23,255,3,5,214,35,255,55,180,183,10,252,57,165,58,186,84,87,207,247,81,114,220,229,56,8,218,147,223,72,221,49,97,255,208,226,126,197,9,247,64,33,176,204,125,115,245,47,21,14,243,29,58,173,120,115,77,240,86,7,235,130,223,253,226,204,112,175,127,249,251,119,247,2,187,245,240,251,63,81,204,92,248,124,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3985eb50-d2b3-4d48-8a6a-1934838eb692"));
		}

		#endregion

	}

	#endregion

}
