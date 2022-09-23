﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CasePortalServiceSchema

	/// <exclude/>
	public class CasePortalServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CasePortalServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CasePortalServiceSchema(CasePortalServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a");
			Name = "CasePortalService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,223,111,219,54,16,126,118,129,254,15,172,7,20,50,96,200,123,78,28,119,73,150,22,30,154,214,139,187,229,33,8,10,70,58,39,66,37,81,37,169,180,94,154,255,125,199,95,18,45,89,118,28,44,107,31,250,102,138,199,227,221,119,223,29,143,116,78,51,16,5,141,128,124,0,206,169,96,11,25,30,179,124,145,92,151,156,202,132,229,225,49,21,48,99,92,210,116,14,252,54,137,224,249,179,187,231,207,122,165,72,242,107,50,95,10,9,217,126,99,140,26,210,20,34,181,92,132,111,32,7,158,68,45,25,171,237,148,197,144,110,156,12,207,225,106,179,192,33,110,117,171,173,173,229,124,119,178,172,107,134,67,120,146,203,68,38,32,214,11,120,72,108,21,208,80,89,195,214,9,163,31,181,49,56,255,11,135,107,92,70,142,83,42,196,30,89,3,52,10,93,216,1,238,36,57,141,228,165,250,118,40,138,119,32,81,87,129,27,95,37,105,34,151,103,240,185,76,56,100,144,75,17,248,3,5,17,57,32,91,150,40,169,208,126,136,7,106,147,162,188,74,147,136,68,202,184,182,109,100,143,28,213,222,162,248,157,182,182,246,9,67,47,41,42,222,35,51,174,130,99,188,233,21,102,64,34,53,79,132,228,58,166,146,202,82,76,227,119,72,70,52,181,111,198,225,52,238,239,111,91,35,102,180,20,208,90,105,63,63,96,253,235,36,167,105,107,185,254,250,128,213,103,32,88,122,187,102,127,55,209,223,183,184,64,30,27,104,214,224,196,203,72,50,174,160,210,152,27,137,209,104,68,198,162,204,50,202,151,19,247,97,154,35,87,105,154,252,3,36,135,47,36,209,32,99,52,216,2,101,1,141,228,176,56,232,183,162,213,31,85,26,198,35,95,167,13,114,107,65,48,32,42,201,123,189,195,52,197,220,192,124,46,179,252,148,22,232,163,218,247,247,68,39,55,106,25,27,64,134,22,152,73,48,208,160,221,63,137,15,97,165,179,160,156,102,36,71,212,15,250,17,74,30,113,246,9,120,127,50,237,86,102,69,80,203,120,164,151,239,10,73,173,132,212,91,14,52,74,189,61,34,111,18,81,161,246,177,22,64,196,234,129,143,77,23,35,102,156,21,192,85,69,82,169,195,36,214,81,136,109,242,24,211,186,209,39,205,112,221,145,107,144,251,196,113,88,168,193,46,251,123,124,116,58,60,24,62,54,60,235,8,247,246,144,32,122,84,162,149,44,2,33,192,148,27,2,170,48,47,195,173,81,178,198,120,63,77,16,208,115,251,171,199,65,150,60,247,237,37,175,94,145,96,53,76,138,140,181,146,96,96,152,172,194,181,53,102,167,32,111,88,220,85,235,110,89,18,147,195,56,54,97,17,129,62,113,150,243,232,6,50,250,103,9,124,73,64,124,30,146,233,73,94,102,192,233,85,10,99,23,207,200,44,113,188,90,224,129,69,163,27,18,216,50,164,167,49,131,154,114,205,180,189,208,243,151,232,36,238,20,86,166,4,250,243,32,84,213,171,237,172,51,255,138,177,148,76,197,59,128,248,12,144,27,185,117,192,6,200,237,105,49,14,108,216,222,128,252,176,44,192,238,244,55,77,75,24,43,77,147,160,105,91,187,146,95,14,200,183,111,198,145,222,163,213,249,165,249,114,48,32,47,95,26,141,132,144,13,58,223,148,73,220,169,211,25,247,226,64,19,69,215,110,97,78,125,45,96,224,129,120,26,239,111,192,145,73,125,186,152,37,27,177,124,241,104,231,171,83,237,114,123,61,214,178,170,26,171,108,232,72,183,181,69,23,207,231,137,206,212,36,86,134,46,18,224,237,218,234,47,18,22,70,187,204,12,31,188,58,74,153,40,57,162,30,155,157,205,16,169,31,119,90,176,146,129,206,79,181,119,160,226,76,140,19,67,162,7,206,56,59,92,217,205,197,229,150,114,149,65,182,88,180,242,56,248,75,0,71,86,228,166,247,13,125,129,83,154,211,107,224,67,162,43,95,223,22,23,149,142,88,51,20,206,90,131,137,36,246,15,135,233,23,186,20,115,80,109,52,110,135,45,130,205,80,175,142,232,170,129,134,92,92,98,157,111,247,51,247,118,15,203,176,223,148,183,182,2,32,161,204,215,134,197,67,11,137,93,121,124,67,243,107,168,249,29,104,29,67,15,170,38,157,135,13,220,182,146,239,88,29,13,233,78,212,227,16,49,30,111,35,223,74,232,205,46,117,224,157,10,23,215,21,106,184,201,225,250,36,55,186,154,211,181,215,102,30,226,163,165,194,246,65,24,224,226,221,178,239,49,16,168,77,254,35,4,148,170,214,180,135,128,158,127,184,255,166,108,62,53,0,102,151,110,4,126,252,220,214,199,207,112,205,205,103,184,254,62,242,168,2,80,193,178,185,4,108,57,255,134,43,13,195,118,10,232,71,2,21,42,248,26,65,161,44,193,150,16,57,145,51,108,11,153,16,9,54,69,186,180,192,40,210,249,53,226,15,35,141,57,73,69,215,197,64,211,190,118,224,196,237,142,61,233,120,228,214,250,84,170,36,42,147,13,66,141,245,213,77,192,54,106,192,57,227,167,216,220,34,79,44,195,222,178,72,101,156,106,247,230,90,168,201,176,115,198,63,233,167,153,80,69,181,228,17,202,49,142,10,134,166,145,89,115,69,66,6,182,212,170,0,185,234,119,162,204,8,117,3,225,88,106,91,13,101,81,23,24,129,111,253,3,202,153,6,68,71,198,29,241,52,175,14,84,125,94,239,210,101,24,158,218,68,183,13,209,143,213,101,180,116,20,28,226,36,66,110,244,39,51,247,147,72,70,176,88,68,159,20,177,213,99,66,156,104,26,97,75,111,160,138,20,108,24,175,13,37,188,153,139,54,177,107,148,90,173,76,181,253,216,8,76,72,101,155,97,81,187,215,65,122,198,176,160,101,42,117,157,28,56,38,39,11,18,52,4,15,244,118,225,73,86,212,173,107,111,250,54,17,178,218,174,178,13,219,84,71,124,127,254,206,179,158,220,27,74,246,146,92,18,110,107,137,114,87,173,172,111,102,161,41,42,239,243,99,7,98,224,239,50,244,92,212,181,117,224,180,162,3,13,173,7,228,215,202,238,158,188,225,236,203,182,180,182,186,238,205,109,137,64,170,78,31,84,252,194,179,79,159,127,107,205,91,174,24,87,135,105,5,87,107,117,101,216,14,118,237,118,87,221,246,216,52,7,41,12,55,49,32,200,94,211,170,25,171,31,121,80,155,225,198,68,114,85,215,61,52,114,16,5,30,52,16,174,22,228,139,247,5,152,103,87,255,101,180,119,113,14,87,211,252,22,227,16,24,71,213,171,220,236,253,252,3,214,70,245,188,9,66,190,102,60,163,234,224,69,81,91,212,204,167,240,15,161,78,192,35,22,47,231,114,153,194,138,72,245,53,60,231,180,192,203,152,201,159,51,107,221,102,165,250,65,181,122,179,240,223,140,173,151,78,141,223,169,218,163,99,93,159,226,48,113,175,22,27,52,58,106,72,190,116,132,82,26,76,159,79,108,6,207,40,247,218,62,71,114,207,150,149,107,193,61,174,150,234,21,162,62,12,97,80,63,181,216,112,213,147,216,114,120,244,116,39,142,19,220,122,158,52,105,168,187,229,159,44,124,82,22,86,151,133,239,79,194,202,148,31,136,131,182,249,252,73,194,167,36,161,119,97,251,238,44,244,108,249,159,104,216,117,124,87,186,196,6,186,158,120,183,40,12,69,12,18,120,150,228,216,242,232,177,33,178,208,15,199,250,174,110,47,85,16,111,166,116,245,87,152,254,79,176,235,186,64,246,234,253,213,42,131,70,203,206,206,255,130,118,185,164,213,170,71,45,221,43,201,151,25,34,246,39,250,10,68,236,112,37,229,28,41,59,175,65,150,133,118,237,0,253,188,82,132,168,198,119,100,67,255,101,190,174,126,196,111,255,2,107,245,153,238,128,31,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCancelCaseErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCancelCaseErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f7aa1416-1f16-46f2-8b35-6285fd72bd50"),
				Name = "CancelCaseError",
				CreatedInPackageId = new Guid("e575f8b9-fb60-4dfe-8829-1e1af76dbac8"),
				CreatedInSchemaUId = new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a"),
				ModifiedInSchemaUId = new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("debb6152-95c5-4972-8ad8-0499f3e41f2a"));
		}

		#endregion

	}

	#endregion

}

