﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TotpSendResetPasswordLinkServiceSchema

	/// <exclude/>
	public class TotpSendResetPasswordLinkServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TotpSendResetPasswordLinkServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TotpSendResetPasswordLinkServiceSchema(TotpSendResetPasswordLinkServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a936c1ba-cf15-4c87-8c2e-7a28d0e9306e");
			Name = "TotpSendResetPasswordLinkService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("feb3fbce-fb5f-42be-98ea-36fd80754622");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,75,111,219,56,16,62,187,64,255,3,87,237,65,2,2,117,247,154,52,13,156,212,110,93,196,73,224,199,246,16,44,10,90,26,59,218,74,164,74,82,73,188,129,255,251,14,95,182,228,200,118,138,237,94,18,137,28,126,156,199,55,15,153,209,2,100,73,19,32,19,16,130,74,62,87,241,5,103,243,108,81,9,170,50,206,94,191,122,122,253,170,83,201,140,45,200,120,41,21,20,39,91,239,241,168,98,42,43,32,30,131,200,104,158,253,99,206,61,147,194,221,251,44,129,33,79,33,223,187,25,119,19,149,221,31,6,137,191,194,108,35,176,200,249,140,230,199,199,23,188,40,56,139,47,249,98,129,203,155,253,186,121,90,162,125,71,192,174,245,248,227,249,206,173,30,218,175,50,144,59,5,250,52,81,92,236,144,64,51,246,232,164,119,63,43,85,198,221,153,84,2,113,208,45,53,152,17,44,62,67,94,130,32,167,187,34,24,163,76,166,207,234,23,43,220,178,180,237,234,49,40,133,111,114,11,23,141,105,130,163,180,23,69,8,4,121,35,16,155,51,114,145,83,41,143,201,132,171,114,12,44,29,129,4,117,131,75,15,92,164,151,25,251,238,66,105,206,220,186,23,132,54,54,254,165,215,186,178,188,2,133,158,41,241,166,89,150,103,106,57,130,31,85,38,160,0,166,100,88,127,209,132,64,77,15,28,209,82,177,91,72,35,125,73,89,205,242,44,33,137,214,245,160,170,228,152,156,83,9,107,197,59,79,70,249,181,197,253,12,242,20,77,190,17,154,190,214,178,78,105,95,136,84,168,82,66,4,208,148,179,124,73,6,200,80,242,45,199,63,167,4,31,135,148,209,5,6,230,19,40,77,93,16,97,208,173,212,29,106,157,37,198,209,65,116,210,132,19,58,86,223,104,89,78,69,222,216,178,241,155,74,16,232,78,6,134,49,228,155,108,89,61,113,250,163,205,214,132,166,61,55,130,35,49,52,177,119,216,212,122,83,235,226,233,7,125,174,211,170,5,57,59,35,97,251,206,41,9,219,224,162,110,89,110,222,226,86,145,159,178,141,43,60,5,169,183,206,189,122,39,119,141,143,209,6,239,110,171,177,123,62,37,24,51,20,201,93,160,112,45,140,14,93,63,4,117,199,247,112,197,220,251,9,24,96,150,193,132,127,7,22,186,197,10,205,188,194,162,29,145,39,227,210,123,42,200,194,10,114,44,2,102,173,99,114,207,22,157,165,166,212,251,129,229,182,170,74,3,246,201,31,248,16,50,120,32,232,54,68,175,180,120,87,44,42,157,43,97,80,53,252,25,28,89,228,78,171,179,45,55,59,2,47,16,108,163,78,220,180,96,173,186,145,94,237,176,249,153,47,157,161,14,92,215,66,93,38,224,17,203,81,37,4,234,74,126,59,37,172,202,115,171,225,25,193,146,57,85,58,249,49,186,218,250,27,170,165,182,96,91,112,76,105,0,169,34,11,116,188,85,9,53,212,159,52,175,160,149,147,71,36,24,103,10,16,58,56,114,198,196,189,162,84,203,40,190,132,185,186,158,143,178,197,157,42,184,196,199,48,120,23,28,112,130,47,63,23,119,148,45,52,234,174,248,187,101,165,61,108,184,184,219,227,222,133,111,131,39,75,233,213,59,172,53,25,123,167,201,49,130,132,223,131,240,247,198,84,150,143,103,170,193,154,211,39,115,203,42,216,163,122,63,99,169,118,76,175,160,217,78,157,53,103,37,228,232,56,147,225,230,41,210,68,180,143,237,57,111,131,130,221,39,175,10,22,6,40,211,77,139,140,77,89,166,208,227,129,185,48,240,82,125,193,139,48,176,164,79,208,236,245,198,0,241,196,23,158,109,35,68,241,117,11,232,32,197,141,129,236,253,168,104,222,128,211,209,174,201,106,57,119,193,215,59,16,16,246,43,150,196,211,178,212,117,124,27,84,123,34,136,54,184,53,89,107,92,140,132,69,25,133,11,107,207,69,30,191,203,210,38,228,100,89,130,161,165,86,149,61,135,112,195,75,188,125,38,214,254,141,124,90,191,252,24,198,104,238,90,224,13,23,138,230,6,167,201,48,27,220,184,247,8,73,165,96,156,208,156,138,247,150,12,31,194,86,230,223,243,44,37,211,50,197,231,70,251,69,115,123,143,37,246,107,191,208,207,233,66,238,35,86,101,64,52,177,44,156,33,150,125,220,153,184,13,38,56,71,35,239,195,160,207,5,78,37,38,7,189,2,24,194,103,206,250,61,106,156,242,162,86,243,143,120,115,219,33,189,62,209,115,243,84,37,87,252,33,238,166,233,71,186,148,225,31,24,108,71,35,199,21,207,93,71,152,61,44,57,72,143,159,14,247,255,193,18,27,34,79,143,38,33,14,119,76,51,178,217,205,219,235,18,236,28,90,159,28,59,183,216,1,6,236,30,139,85,104,143,33,27,130,155,235,241,4,195,48,21,217,4,138,50,183,28,9,70,128,90,167,181,216,158,243,116,57,86,203,92,239,34,204,16,164,196,193,108,189,26,159,99,51,177,238,112,221,2,41,82,80,213,144,182,75,241,23,169,217,133,116,46,177,191,194,126,57,51,141,250,113,180,169,148,7,32,118,54,53,101,122,89,31,79,195,109,121,163,23,142,154,45,171,62,83,18,221,242,125,209,150,85,146,160,70,78,43,237,150,201,29,224,121,139,243,64,37,193,12,72,115,61,17,89,201,57,118,219,165,109,3,157,173,84,196,211,173,23,27,34,105,1,123,74,137,165,211,196,3,128,46,224,120,186,217,65,182,58,88,39,155,19,151,252,152,14,87,168,198,181,48,93,54,52,199,35,111,30,142,154,56,90,199,95,169,96,225,219,64,195,57,124,198,21,153,243,138,165,36,124,242,216,171,40,240,240,190,128,233,154,177,35,10,254,130,206,216,250,2,85,198,217,9,124,138,116,54,94,108,186,213,237,175,220,77,171,134,241,178,154,253,141,229,232,164,177,56,67,210,213,204,110,43,94,122,38,25,200,62,80,212,26,122,140,206,48,72,97,48,172,114,156,127,176,104,85,120,111,253,83,207,53,201,141,151,204,151,235,146,168,77,70,172,63,40,53,180,207,148,243,165,185,22,97,241,154,246,42,234,205,223,51,87,25,10,92,58,181,228,250,68,227,198,109,126,27,141,189,26,131,180,125,52,88,71,207,185,81,135,196,29,49,86,96,65,74,109,233,50,149,112,221,137,130,177,149,223,132,95,187,252,197,167,117,81,240,197,25,203,243,8,240,76,130,69,251,141,55,66,39,39,142,89,111,176,172,180,142,116,155,186,237,73,65,32,175,81,108,99,142,230,227,37,79,204,175,43,24,227,177,81,1,39,146,250,207,4,56,211,197,151,156,166,32,244,148,177,237,200,33,250,113,151,185,46,161,108,57,10,127,205,93,214,57,235,32,191,208,126,251,239,229,115,192,118,121,216,112,105,103,177,108,159,1,76,117,56,242,121,120,100,114,207,129,174,8,126,53,36,119,36,236,61,38,80,154,239,210,245,192,97,203,76,79,8,142,131,222,102,159,39,9,38,74,74,50,134,197,16,173,32,165,211,128,224,199,101,2,41,110,162,223,188,214,171,250,232,116,184,242,180,214,157,189,85,103,181,167,193,218,213,91,28,70,104,189,135,54,126,24,105,237,47,207,127,255,104,124,83,215,187,180,6,31,66,49,195,129,193,181,136,192,7,46,104,52,62,87,248,124,171,32,79,248,45,169,78,112,156,196,63,191,78,125,235,206,255,166,191,243,114,83,253,25,231,57,241,225,105,209,189,13,168,176,113,106,245,131,15,234,75,221,208,92,196,181,127,1,105,205,66,7,222,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a936c1ba-cf15-4c87-8c2e-7a28d0e9306e"));
		}

		#endregion

	}

	#endregion

}

