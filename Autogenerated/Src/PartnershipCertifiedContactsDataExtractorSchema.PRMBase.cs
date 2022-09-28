﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PartnershipCertifiedContactsDataExtractorSchema

	/// <exclude/>
	public class PartnershipCertifiedContactsDataExtractorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PartnershipCertifiedContactsDataExtractorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PartnershipCertifiedContactsDataExtractorSchema(PartnershipCertifiedContactsDataExtractorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34e3872b-fdd2-4294-80ff-e2fa435a376a");
			Name = "PartnershipCertifiedContactsDataExtractor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,219,78,227,72,16,125,14,18,255,208,202,190,216,18,114,118,95,73,136,196,37,160,172,24,96,129,217,121,110,218,21,232,149,221,246,244,37,144,29,205,191,111,245,197,142,29,199,33,48,251,2,78,119,213,169,58,213,117,170,109,65,115,80,37,101,64,30,65,74,170,138,133,78,206,11,177,224,207,70,82,205,11,65,14,15,126,28,30,28,30,12,140,226,226,153,60,172,148,134,124,188,241,27,93,178,12,152,181,87,201,21,8,144,156,117,108,46,168,166,235,197,102,184,60,47,196,246,29,9,125,235,237,44,123,173,46,206,122,183,102,66,115,205,65,141,29,189,223,36,60,91,186,231,25,85,234,152,220,81,169,145,134,122,225,229,57,72,205,23,28,82,140,168,41,211,202,18,153,189,105,137,207,133,116,206,163,209,136,76,148,201,115,42,87,211,240,59,88,40,82,174,161,8,171,176,8,11,96,36,69,180,164,194,24,53,64,74,243,148,113,70,152,77,104,255,124,200,49,113,196,86,237,85,196,243,199,88,19,189,228,144,165,150,169,228,75,170,193,111,110,18,113,11,127,25,144,43,60,97,147,139,217,91,41,65,41,235,191,64,84,120,227,74,219,12,141,130,164,246,111,146,24,148,30,158,40,141,7,197,136,4,154,22,34,91,245,128,58,64,117,43,0,185,161,135,208,228,132,120,163,196,173,68,127,196,227,64,3,68,234,153,180,105,57,51,105,44,105,75,206,213,112,7,183,185,192,30,160,25,255,23,246,47,113,15,83,183,130,135,77,115,34,80,85,39,67,44,138,68,0,225,133,49,156,78,20,0,97,18,22,39,195,175,237,173,209,148,112,199,151,65,130,168,14,196,87,207,247,192,222,169,69,109,96,210,78,33,182,144,131,99,242,68,21,68,27,91,228,135,221,252,185,187,184,95,64,191,20,251,53,205,21,104,242,0,118,40,184,78,97,52,99,38,243,19,229,148,177,194,224,209,118,168,16,183,254,217,242,182,169,39,205,50,58,95,9,218,72,161,166,159,77,107,50,170,16,154,125,93,161,33,223,142,163,235,241,119,142,196,215,125,176,164,146,124,183,230,216,240,2,94,3,234,230,33,57,211,65,226,21,17,13,67,156,225,17,25,134,228,231,233,112,195,232,210,8,134,207,184,23,117,196,21,199,201,169,178,48,184,91,251,93,202,34,95,67,199,201,183,23,144,16,85,187,51,135,17,245,167,88,197,237,6,171,144,125,149,24,22,175,138,57,8,65,90,123,72,42,36,97,73,37,115,53,251,110,104,214,34,189,102,59,72,78,69,218,241,159,43,101,224,194,5,66,255,107,156,49,183,210,163,132,153,114,103,59,4,52,200,200,90,61,242,28,146,175,154,221,20,175,241,78,92,28,88,92,174,129,175,112,168,33,198,254,216,85,49,175,100,97,202,179,85,223,65,142,157,153,111,186,208,28,84,133,178,143,27,106,253,168,254,26,211,164,78,82,145,37,205,76,223,16,255,223,180,247,137,140,222,151,157,173,151,186,44,228,86,148,253,229,199,182,202,23,245,216,47,237,13,176,241,231,165,92,150,237,134,222,144,47,205,64,49,136,66,83,134,14,123,40,140,100,80,33,48,234,37,227,180,124,212,182,244,119,231,239,241,14,193,55,138,55,244,86,246,189,165,54,250,179,224,34,178,127,30,87,37,36,215,176,208,183,6,203,139,17,183,85,189,66,40,215,250,188,173,73,54,28,218,202,118,1,183,201,186,229,231,130,156,99,15,60,23,114,213,48,29,212,64,29,1,222,221,127,57,195,43,175,154,68,42,185,49,249,19,10,118,81,31,43,42,26,31,85,5,27,239,136,223,34,106,171,241,201,28,206,141,148,32,244,38,170,71,236,75,224,151,163,222,226,251,196,179,19,221,6,90,252,238,73,111,215,135,63,105,108,190,246,73,135,163,108,76,179,245,57,251,78,237,222,88,225,18,168,219,64,157,162,84,150,208,112,109,181,51,190,229,65,157,117,163,76,115,161,255,182,147,195,249,221,20,218,187,134,236,182,234,233,3,130,234,42,106,223,41,189,199,59,85,161,209,7,210,254,169,62,225,2,107,196,117,90,48,50,154,110,159,213,101,5,67,138,37,126,240,240,20,200,178,224,41,194,3,86,22,252,224,170,230,94,115,196,125,100,140,198,239,222,63,251,164,218,185,86,236,183,208,61,126,33,224,4,153,246,222,33,155,23,66,135,238,124,38,76,14,146,62,101,48,185,224,46,95,140,56,193,207,2,252,10,60,34,197,211,63,232,48,157,218,79,5,116,209,174,6,247,160,76,166,163,249,69,157,1,89,39,211,188,37,236,234,3,232,48,219,175,241,37,103,87,140,40,180,199,235,11,207,128,68,107,200,196,254,139,226,10,217,65,203,226,53,192,246,35,86,128,3,52,78,78,83,108,122,20,208,81,35,215,196,29,165,237,81,39,130,73,229,231,166,106,199,217,119,247,94,254,65,8,21,68,168,131,131,65,184,176,28,58,162,146,67,48,234,147,65,88,107,46,253,252,15,63,20,142,162,145,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34e3872b-fdd2-4294-80ff-e2fa435a376a"));
		}

		#endregion

	}

	#endregion

}
