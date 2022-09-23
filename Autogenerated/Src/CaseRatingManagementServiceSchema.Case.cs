﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseRatingManagementServiceSchema

	/// <exclude/>
	public class CaseRatingManagementServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseRatingManagementServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseRatingManagementServiceSchema(CaseRatingManagementServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f");
			Name = "CaseRatingManagementService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1c03a3fe-87f3-466f-a6b7-a88ed4e512f8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,26,107,115,219,198,241,51,51,147,255,112,65,58,54,56,145,64,217,78,210,212,18,233,234,65,197,106,109,89,21,169,122,58,178,167,5,129,163,136,10,4,224,187,131,36,214,225,127,239,238,61,128,3,64,130,84,154,164,157,169,70,51,4,238,118,247,246,246,117,187,123,72,252,57,229,153,31,80,50,166,140,249,60,157,10,239,56,77,166,209,77,206,124,17,165,137,119,236,115,122,9,143,201,205,91,63,241,111,232,156,38,98,68,217,93,20,208,47,191,248,252,229,23,157,156,195,28,25,45,184,160,243,253,218,59,208,138,99,26,32,33,238,253,72,19,202,162,160,1,243,38,74,62,53,6,71,52,200,89,36,22,107,39,188,11,22,37,65,148,249,241,10,16,201,222,219,52,164,237,147,222,33,176,118,39,247,217,14,247,158,78,26,0,99,250,32,154,131,51,70,253,16,6,202,25,91,176,243,185,189,146,61,195,232,186,113,239,228,104,237,212,48,17,145,136,40,95,5,0,60,183,172,136,179,175,133,200,188,195,9,23,204,87,42,2,64,0,189,214,91,7,59,144,51,31,113,236,144,103,231,84,0,189,12,196,53,137,98,208,192,37,253,148,71,76,26,4,119,237,23,148,25,233,147,13,40,8,229,233,129,176,139,139,100,249,36,142,2,18,196,62,231,164,197,238,200,75,114,4,179,133,21,118,62,75,190,59,95,51,122,3,219,32,192,56,23,62,44,241,146,128,145,128,126,169,154,239,245,122,228,128,231,243,185,207,22,3,51,112,145,70,137,32,65,26,231,243,132,36,224,14,94,1,218,179,97,51,69,9,32,129,56,1,153,161,60,37,242,177,196,61,7,84,216,180,35,135,156,253,181,40,103,137,160,108,78,195,8,102,192,242,111,17,231,243,222,178,103,219,91,175,101,243,30,191,11,122,54,17,233,16,8,77,17,171,247,249,217,178,247,249,249,210,145,186,148,82,161,73,168,4,83,149,210,105,68,227,176,46,34,195,178,102,246,239,156,114,14,192,103,33,176,249,99,30,133,222,57,189,199,95,183,235,141,211,145,4,114,157,115,167,187,191,18,121,193,175,56,101,40,153,253,181,242,7,210,233,148,136,25,37,17,56,16,153,178,116,78,2,95,248,113,122,67,222,194,234,176,251,243,84,68,211,136,178,13,154,65,190,234,40,146,241,132,222,203,73,215,25,158,124,183,247,108,120,114,180,251,195,240,232,116,247,219,227,223,127,191,123,248,226,187,147,221,239,79,159,191,56,26,62,255,246,197,222,183,47,228,102,218,4,39,205,139,229,129,72,25,138,79,26,109,139,129,29,67,68,16,148,19,136,86,96,148,96,189,176,221,3,78,193,44,24,157,246,157,22,85,59,3,34,22,217,90,131,84,222,210,130,239,118,9,6,232,78,7,181,0,92,39,42,18,163,107,102,89,249,254,202,83,193,171,10,37,53,214,177,117,184,29,158,119,156,51,6,60,224,168,87,168,190,99,194,246,56,189,165,201,149,192,104,0,113,75,43,103,245,164,91,37,172,108,108,249,95,144,180,28,201,124,230,207,101,128,232,59,121,133,49,103,80,147,192,65,79,2,111,171,165,154,118,170,196,215,170,48,223,172,173,124,11,197,44,219,109,253,130,165,25,101,168,141,122,160,80,251,154,164,105,76,206,248,37,205,185,63,137,169,102,246,134,10,253,212,97,84,228,44,33,224,47,218,16,150,143,93,117,147,127,157,201,96,175,180,141,97,196,210,248,106,187,114,122,3,117,198,180,250,213,26,131,93,51,92,236,123,159,200,39,78,197,54,226,125,75,197,44,109,4,225,213,198,61,163,193,45,39,33,132,70,56,80,24,232,52,129,80,183,173,197,114,138,105,24,119,6,182,109,74,40,165,32,14,19,230,201,142,169,90,191,39,176,42,36,28,184,170,251,38,226,226,96,36,233,13,136,166,107,172,244,206,103,36,178,161,193,10,75,213,227,172,66,184,164,60,143,133,57,83,134,243,76,37,122,10,36,99,244,110,45,192,20,182,238,7,51,226,150,196,192,223,235,124,116,106,203,168,87,111,248,0,218,131,19,51,240,99,159,29,32,233,129,171,194,74,167,83,103,187,66,225,171,190,205,213,147,39,213,77,106,10,21,190,109,116,203,240,141,63,52,241,219,2,219,136,10,78,224,64,76,73,52,135,224,65,68,74,24,164,237,112,14,129,134,22,132,203,48,12,75,10,12,48,219,154,132,161,224,12,94,143,199,23,228,82,191,122,13,11,177,145,228,250,24,60,156,193,27,228,167,186,52,24,102,88,37,96,236,232,46,133,179,25,182,97,86,65,100,23,243,79,51,80,108,104,199,164,15,197,82,70,169,22,58,230,222,110,29,195,59,77,217,220,23,174,115,16,80,204,143,6,7,177,63,161,49,137,194,254,7,231,210,143,144,67,92,247,131,3,8,139,152,194,232,196,15,110,111,88,154,39,225,75,146,179,216,21,69,126,236,63,132,175,120,223,33,223,40,221,58,73,30,237,78,162,4,164,185,11,123,214,251,125,194,250,144,186,117,247,201,125,20,138,217,75,242,236,249,15,123,217,195,254,140,70,55,51,241,146,252,97,15,223,72,24,241,44,246,23,47,193,78,227,40,161,187,147,56,13,110,247,63,160,47,74,6,225,87,51,236,236,88,187,222,124,222,125,93,249,35,149,31,245,68,106,143,164,14,13,127,143,55,23,75,109,173,198,34,64,75,206,160,182,220,54,214,33,213,219,110,29,72,219,142,58,74,213,253,134,41,188,30,191,125,51,56,56,122,119,242,183,1,168,234,160,39,159,14,122,114,216,217,81,202,149,180,246,181,123,106,47,120,15,65,158,186,146,234,102,69,0,235,165,67,102,160,192,95,79,166,1,36,18,103,161,51,192,132,2,44,123,27,105,94,0,67,235,164,41,115,102,69,211,72,83,11,216,192,92,49,20,43,148,139,197,97,7,133,188,192,250,11,146,65,56,40,101,245,12,64,114,5,44,25,65,152,38,213,144,229,29,229,70,184,154,50,15,102,116,238,155,122,169,204,140,78,41,13,209,33,145,95,167,60,14,166,122,24,214,80,90,5,172,63,58,189,243,60,234,25,12,207,231,217,195,171,187,121,223,12,64,21,149,199,244,137,192,67,26,93,244,73,185,102,31,10,36,167,170,108,220,226,55,117,211,105,44,187,163,229,180,99,109,160,187,95,143,76,82,216,165,124,173,37,42,102,244,115,116,213,84,140,237,0,51,49,143,143,242,40,14,41,51,89,181,132,215,99,238,119,207,158,119,149,185,123,160,56,200,71,192,57,16,103,224,232,97,107,124,146,134,139,114,220,154,224,1,139,50,97,77,149,115,238,52,79,84,110,138,101,7,68,196,36,76,239,61,8,117,170,141,52,195,132,236,131,3,1,181,98,89,223,16,7,194,241,210,133,104,183,106,189,94,125,65,107,170,194,164,53,174,55,181,210,159,45,33,149,245,107,183,85,51,118,169,93,209,146,9,68,104,99,165,114,164,37,27,189,88,46,129,77,0,249,219,39,214,232,97,16,64,18,151,50,116,41,147,199,186,107,140,74,19,240,46,75,231,173,115,103,196,234,106,166,52,55,43,247,167,25,94,79,99,139,253,233,100,166,234,56,245,6,199,206,127,26,60,76,148,174,236,105,203,98,240,31,170,145,100,218,2,228,53,36,175,41,91,128,13,66,14,29,110,25,166,231,10,217,25,104,42,219,7,232,179,245,1,90,241,135,80,154,170,102,237,82,114,102,164,175,151,94,25,168,101,243,111,49,146,193,72,199,36,176,174,90,45,106,3,169,210,179,98,108,71,11,12,99,174,211,228,195,120,144,34,32,151,174,2,232,137,190,94,218,83,27,82,163,181,154,214,171,244,13,86,182,13,244,106,235,150,241,192,27,78,232,84,181,218,254,234,199,96,24,238,22,40,22,188,218,35,104,198,196,241,199,162,55,58,75,64,169,49,246,88,162,175,125,126,40,4,20,52,216,16,0,130,83,63,230,244,103,114,6,232,218,92,54,18,240,239,76,152,249,141,92,168,197,43,154,176,69,63,213,25,200,44,1,10,251,60,131,194,151,134,186,79,187,5,186,20,141,51,144,63,237,4,86,120,229,8,98,12,159,170,166,248,149,68,212,94,105,121,97,17,18,75,118,119,72,58,249,39,86,143,22,11,149,202,24,34,43,19,250,116,62,147,47,245,30,151,62,205,32,134,166,174,211,100,163,60,7,193,6,192,162,37,183,225,187,4,84,175,44,194,187,192,125,81,136,192,46,20,152,116,28,205,169,119,37,130,243,244,190,91,69,133,12,9,77,246,103,225,22,142,132,251,248,75,78,217,162,196,212,190,85,65,176,37,180,10,197,146,86,151,248,92,139,70,217,176,146,153,169,220,221,149,71,217,73,36,69,4,198,119,160,116,98,116,51,32,176,10,148,19,120,114,96,189,237,78,22,130,94,127,148,77,148,234,25,166,216,29,38,80,192,226,81,118,53,62,253,1,195,164,206,16,36,124,177,35,56,184,132,251,244,201,83,107,143,88,235,187,15,164,63,32,15,102,190,255,180,219,245,14,249,48,201,231,148,97,111,204,45,224,199,105,201,177,123,75,23,136,7,63,215,123,31,119,200,157,52,88,24,144,15,215,207,62,86,118,188,185,143,180,169,91,54,158,81,50,243,147,48,134,52,81,55,204,130,56,130,224,67,120,116,147,248,49,161,184,176,60,151,33,135,19,51,40,237,241,122,65,165,1,219,182,22,36,176,51,48,189,50,141,220,234,181,234,88,215,1,66,189,84,16,174,223,101,84,221,72,218,215,82,157,107,200,45,64,79,238,21,139,198,116,14,101,182,144,69,69,253,78,68,50,176,236,125,86,132,151,142,188,110,50,157,62,233,248,210,70,46,88,138,249,152,78,60,182,201,128,218,18,196,90,194,210,233,108,138,183,255,31,186,105,187,187,218,172,39,27,251,216,143,227,199,171,44,154,18,119,117,23,215,27,179,5,48,92,134,11,77,38,205,5,209,145,67,152,185,110,209,106,196,200,46,135,139,136,134,215,26,181,192,83,226,237,151,88,42,86,98,139,180,138,126,109,34,236,71,13,92,219,164,57,128,236,84,184,179,36,20,82,7,195,148,152,177,244,190,114,183,50,124,8,104,134,58,114,127,231,84,149,175,108,9,227,144,150,63,185,135,32,156,164,130,76,177,51,230,153,76,112,249,11,218,239,182,214,26,149,173,14,160,163,110,1,127,67,91,45,45,51,10,91,205,114,181,25,70,225,175,81,24,162,1,235,146,235,140,159,231,113,252,142,189,159,65,117,59,194,239,56,220,8,234,131,159,126,34,235,1,76,81,216,52,149,67,118,147,99,30,170,80,100,211,189,180,26,35,89,219,24,58,242,122,32,226,167,144,134,128,31,15,19,60,231,228,85,113,156,78,252,24,178,254,145,106,148,114,15,242,156,227,209,225,88,117,122,244,205,87,165,43,164,42,245,192,36,172,50,82,96,47,116,12,22,117,203,161,182,212,29,92,221,187,177,50,49,251,134,55,50,25,56,94,234,103,242,106,191,143,23,182,119,152,68,140,83,136,30,47,158,187,21,191,209,91,88,119,103,161,185,123,147,6,126,28,253,11,247,167,114,2,189,104,99,188,94,249,188,79,217,173,252,192,6,235,246,52,103,1,192,165,12,75,58,157,13,180,94,75,238,16,167,177,2,247,236,188,240,13,189,163,177,150,153,167,146,222,106,183,109,94,200,115,84,41,211,27,116,107,241,68,6,168,52,9,35,92,69,47,96,238,107,87,36,92,246,173,80,113,169,162,190,134,49,5,125,241,193,142,166,82,124,140,82,76,184,82,143,234,51,161,51,233,240,80,74,218,151,154,93,149,64,170,69,101,190,84,126,161,96,241,173,46,95,134,15,192,19,151,129,160,175,132,173,226,161,76,214,106,121,55,216,70,230,62,43,50,52,149,16,187,14,196,96,147,146,159,178,116,174,82,223,98,232,253,140,50,170,128,192,209,134,159,114,216,65,35,149,54,9,49,38,182,106,237,213,124,74,69,254,114,140,54,108,164,198,117,237,203,149,150,13,72,47,106,242,223,176,13,239,48,12,93,229,179,218,85,161,44,62,197,19,68,87,10,182,137,200,30,97,115,251,203,238,102,226,168,130,199,80,150,6,96,8,11,40,92,117,220,43,110,18,139,58,174,186,38,94,43,54,249,248,51,93,148,183,140,157,85,119,161,96,221,13,180,235,250,136,57,217,27,215,142,213,187,86,115,173,89,64,67,232,255,170,130,82,242,210,105,70,208,250,170,134,76,103,2,91,191,53,111,42,148,155,31,92,98,205,10,27,138,99,147,150,212,76,107,71,197,225,98,15,27,26,95,69,199,171,210,165,169,114,87,61,111,74,6,55,183,76,107,68,43,57,83,167,126,63,217,68,175,137,184,202,220,18,191,91,66,131,42,14,77,66,31,10,230,234,215,91,77,226,244,193,171,210,221,152,112,129,83,20,215,35,160,236,57,30,29,120,57,140,194,125,100,61,240,39,158,38,187,83,121,52,96,155,68,251,4,102,113,155,235,3,189,114,11,17,13,209,36,99,190,57,48,95,246,21,253,250,234,231,8,45,89,219,89,114,7,28,186,170,2,150,31,224,189,27,141,33,46,232,84,172,184,50,2,80,45,93,53,228,33,179,59,228,40,13,23,35,188,13,174,128,20,163,222,123,230,103,25,13,213,105,109,116,213,78,180,146,29,86,62,166,213,187,44,238,118,64,127,199,74,50,171,11,23,45,54,187,135,84,92,51,170,51,180,141,188,219,140,121,149,170,67,126,90,33,235,20,85,158,24,107,110,36,14,255,19,137,142,22,212,202,84,103,219,200,228,104,34,216,3,214,162,173,16,120,100,80,90,229,240,221,242,195,39,109,201,229,100,159,216,223,64,153,219,19,3,216,210,231,129,81,248,255,55,158,127,79,223,172,45,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSatisfactionLevelMessageLocalizableString());
			LocalizableStrings.Add(CreateSatisfactionCommentMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSatisfactionLevelMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab3c17d7-33c5-4de2-a399-e7879744f3df"),
				Name = "SatisfactionLevelMessage",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f"),
				ModifiedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSatisfactionCommentMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("04116657-8ba6-48bc-a1c9-4c90fcf7410b"),
				Name = "SatisfactionCommentMessage",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f"),
				ModifiedInSchemaUId = new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("07cd0230-240d-4c09-8dec-f39bc3e6322f"));
		}

		#endregion

	}

	#endregion

}

