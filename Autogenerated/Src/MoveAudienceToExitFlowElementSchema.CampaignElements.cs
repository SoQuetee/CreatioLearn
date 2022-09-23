﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MoveAudienceToExitFlowElementSchema

	/// <exclude/>
	public class MoveAudienceToExitFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MoveAudienceToExitFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MoveAudienceToExitFlowElementSchema(MoveAudienceToExitFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149");
			Name = "MoveAudienceToExitFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,89,91,111,219,54,20,126,246,128,253,7,206,3,54,25,48,148,97,79,67,46,14,210,212,105,3,52,109,23,39,203,195,48,12,140,116,108,19,149,69,133,164,154,100,69,254,251,14,111,146,40,211,151,14,24,182,60,36,21,121,46,31,207,141,135,167,164,164,43,144,21,205,128,220,128,16,84,242,185,74,207,121,57,103,139,90,80,197,120,249,237,55,95,190,253,102,80,75,86,46,200,236,89,42,88,29,245,190,145,190,40,32,211,196,50,125,3,37,8,150,173,209,220,192,147,106,23,187,186,86,43,94,198,119,58,40,210,115,186,170,40,91,148,211,2,86,80,42,25,231,16,208,16,110,36,120,253,106,227,214,71,193,51,144,90,54,82,124,47,96,129,154,201,121,65,165,60,36,87,252,51,156,213,57,131,50,131,27,62,125,98,234,162,224,143,14,142,97,56,56,56,32,199,178,94,173,168,120,158,184,239,233,19,100,181,162,247,5,144,204,1,35,96,121,200,227,146,101,75,178,66,185,146,100,188,84,52,83,146,40,78,178,90,8,189,223,48,48,109,64,175,224,160,163,161,170,239,11,150,145,76,35,220,14,144,28,18,111,152,0,246,224,139,129,222,30,22,125,168,40,218,247,144,124,52,194,237,118,37,216,103,170,64,195,148,138,72,37,180,241,206,45,230,27,125,186,247,24,70,228,132,232,104,226,243,196,237,140,142,156,112,40,115,43,63,84,134,230,174,64,40,6,90,155,213,16,170,123,83,179,156,124,164,72,146,177,10,81,205,20,85,181,188,204,201,201,132,92,74,127,160,55,156,22,154,107,112,218,156,177,57,70,19,14,29,41,215,64,179,37,228,154,205,11,52,236,135,251,177,107,203,66,238,57,143,66,196,51,208,153,208,152,134,107,167,184,181,47,100,1,234,136,72,253,235,229,43,12,211,113,67,63,194,204,194,53,231,138,204,121,145,131,32,18,15,182,162,198,13,105,195,208,141,24,31,50,206,133,23,134,109,102,184,172,11,39,61,31,90,10,239,201,40,128,219,146,61,212,64,88,142,17,197,230,12,97,240,57,81,75,112,160,182,3,49,46,182,74,174,33,227,34,71,239,70,44,21,85,124,81,208,133,203,34,86,230,44,67,7,96,2,45,169,106,82,140,201,38,139,126,148,100,129,30,39,92,144,146,171,237,160,238,57,47,122,1,246,117,160,48,139,61,34,11,72,103,57,161,46,59,53,172,251,103,50,103,133,218,101,30,131,228,45,149,23,134,118,127,16,150,28,97,4,138,247,139,137,141,170,124,144,91,119,189,133,2,131,148,252,57,239,124,109,11,147,51,44,100,38,173,208,0,46,64,142,37,96,77,17,48,63,25,118,101,14,15,38,41,154,159,216,26,61,71,143,93,241,236,19,169,106,81,113,9,114,251,41,2,112,193,199,23,147,229,120,42,29,229,1,108,114,122,74,146,112,5,107,25,60,6,252,201,72,103,1,74,144,49,9,39,228,51,45,106,48,20,59,178,251,10,212,146,231,155,106,222,229,180,172,87,32,116,81,61,214,201,49,33,111,64,157,21,88,180,33,95,43,133,32,147,17,98,49,176,34,117,50,157,62,212,180,144,201,63,45,139,35,35,24,235,42,218,226,247,63,156,1,241,103,47,121,205,63,21,122,209,75,28,127,149,136,176,212,58,214,23,251,247,208,131,218,175,106,71,209,144,151,120,249,190,44,153,114,245,111,86,223,219,197,196,237,89,175,219,143,145,51,201,103,138,165,215,172,116,75,105,64,154,206,120,45,50,152,62,85,2,59,12,221,209,180,164,71,141,16,215,6,92,230,216,82,213,171,18,101,172,139,93,187,101,201,41,25,94,230,67,188,226,135,231,158,127,104,101,178,57,73,2,20,88,74,144,38,103,186,167,242,232,141,102,120,98,82,155,166,217,149,253,3,52,59,233,121,193,75,184,130,100,148,222,9,90,189,42,48,57,19,151,27,131,141,44,64,69,156,232,110,9,2,146,117,253,142,248,165,111,156,198,35,13,169,75,214,95,107,16,207,205,98,18,126,222,60,87,96,211,161,57,246,59,152,171,214,31,161,16,109,253,118,47,233,123,97,220,247,148,205,148,23,11,121,35,208,244,154,45,150,29,157,50,61,203,243,36,18,173,166,167,26,119,253,233,172,17,88,14,153,219,227,110,84,58,38,182,199,78,223,241,5,222,72,197,7,44,87,182,167,62,43,115,39,86,128,170,69,25,248,187,91,201,250,221,141,0,252,242,189,166,75,143,245,186,85,173,87,171,177,23,209,71,219,205,36,26,8,118,126,113,90,110,37,8,60,89,105,159,27,174,62,13,82,235,132,109,150,212,38,180,212,233,133,224,171,141,164,163,244,76,110,222,116,18,108,200,110,243,155,219,106,181,14,210,75,105,194,47,177,88,83,228,194,64,194,155,54,105,137,71,94,1,122,102,47,241,248,48,8,85,188,231,106,151,22,195,179,175,38,95,41,59,58,202,53,217,50,137,184,58,208,48,74,167,58,191,229,90,148,142,8,149,164,19,112,131,208,249,233,172,130,140,205,159,223,243,119,88,100,222,50,44,238,73,24,178,33,253,150,160,213,183,104,64,107,50,61,241,129,167,43,101,172,107,215,229,182,46,218,162,225,212,234,181,93,245,9,35,55,122,145,68,212,140,218,43,32,98,74,20,180,163,7,8,76,18,77,207,104,50,174,121,35,102,191,219,42,55,111,49,192,194,149,21,117,222,72,182,6,52,191,27,55,152,175,110,50,215,134,219,18,217,76,182,242,122,153,60,38,59,114,110,144,206,64,37,253,200,215,181,109,175,56,119,236,77,56,71,24,35,253,211,26,55,84,87,60,215,111,156,252,67,25,147,241,26,79,118,195,240,241,117,171,178,247,252,49,194,143,181,184,42,144,54,10,97,142,205,26,140,194,42,19,88,54,237,92,222,152,56,214,148,214,249,29,67,167,119,76,45,109,178,104,131,95,243,71,159,61,77,15,235,66,165,195,180,61,117,46,58,55,67,144,51,225,211,77,23,185,85,165,48,173,144,134,236,204,24,233,243,164,219,103,167,61,117,191,253,220,100,140,159,52,140,215,30,174,227,222,27,210,247,153,189,251,162,237,138,100,60,189,221,27,8,132,224,226,10,47,105,186,0,23,182,104,66,90,176,191,52,132,153,33,234,69,112,122,199,197,39,51,73,75,175,65,154,102,111,166,184,64,1,30,203,112,235,132,6,227,97,184,166,67,166,175,193,68,75,240,26,119,192,210,223,244,139,195,119,6,3,181,20,252,209,64,237,205,202,94,9,254,9,74,12,77,138,9,12,149,233,22,236,57,211,11,46,86,84,37,221,227,234,76,52,52,250,81,164,77,59,10,26,49,231,77,185,71,185,181,15,201,72,204,56,229,120,91,161,233,63,136,187,37,118,249,51,109,185,196,178,140,254,191,238,176,182,180,48,255,75,55,216,236,161,34,91,106,129,104,147,105,153,97,101,66,89,183,55,23,191,232,20,122,245,172,240,102,112,6,109,227,254,187,32,213,206,151,144,125,154,53,114,154,65,67,36,227,90,109,99,210,203,170,125,46,71,144,15,145,60,127,253,140,111,25,150,217,229,233,236,215,175,211,219,158,202,72,223,239,166,70,210,20,229,156,229,43,86,154,118,220,60,116,116,225,13,42,163,38,67,128,221,86,33,166,125,99,240,71,46,121,243,84,239,12,115,78,35,73,114,184,94,108,119,12,81,59,211,4,174,144,1,242,45,51,24,59,142,214,243,102,55,99,158,99,196,251,105,217,134,185,138,89,169,244,29,101,30,158,39,67,221,53,192,147,26,78,110,150,128,239,70,45,81,3,113,203,233,241,129,33,110,121,173,69,229,228,156,215,168,145,207,219,193,118,167,41,145,110,144,247,136,119,30,169,236,28,30,114,61,38,243,80,61,202,227,3,47,208,90,222,157,154,160,157,133,96,57,16,188,231,200,140,206,193,29,54,113,83,125,251,105,159,152,26,168,7,236,3,38,218,253,109,116,101,27,123,49,190,239,108,44,146,31,126,136,141,130,227,175,112,23,120,247,84,66,218,133,239,97,70,170,240,79,221,24,140,15,135,173,169,130,201,91,103,234,102,2,123,120,48,33,143,216,49,104,131,248,183,191,226,122,252,215,78,44,241,219,57,101,91,148,120,199,216,118,207,200,180,67,206,86,80,171,99,183,35,173,152,78,227,238,91,246,147,201,198,118,126,219,4,114,107,244,91,184,13,206,7,163,187,131,118,207,228,48,2,28,210,161,51,132,158,96,234,255,195,9,204,121,223,9,243,127,45,103,36,118,156,123,38,12,38,70,209,196,92,167,169,143,244,244,15,174,155,223,244,36,8,248,130,170,106,56,83,175,37,40,161,189,250,102,87,195,69,92,251,27,210,249,164,124,176,28,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDeletedContactFolderMessageLocalizableString());
			LocalizableStrings.Add(CreateBrokenFilterMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDeletedContactFolderMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54e63929-cf70-48a2-aca7-039392c5e3a9"),
				Name = "DeletedContactFolderMessage",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149"),
				ModifiedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBrokenFilterMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5ebb106e-ae06-b237-e049-c3729c30a5c6"),
				Name = "BrokenFilterMessage",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149"),
				ModifiedInSchemaUId = new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("54a6ee92-6fb5-462d-bbf6-d17aa2e54149"));
		}

		#endregion

	}

	#endregion

}

