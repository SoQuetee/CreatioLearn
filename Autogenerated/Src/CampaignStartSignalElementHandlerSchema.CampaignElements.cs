﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartSignalElementHandlerSchema

	/// <exclude/>
	public class CampaignStartSignalElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartSignalElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartSignalElementHandlerSchema(CampaignStartSignalElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b");
			Name = "CampaignStartSignalElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,90,235,115,219,54,18,255,172,206,244,127,128,117,51,29,106,42,51,105,47,237,37,231,216,25,69,177,18,221,56,113,39,178,211,15,119,55,25,154,132,100,166,124,168,0,168,72,205,248,127,239,46,30,36,192,135,104,95,207,105,110,238,147,109,96,177,187,216,253,237,11,116,22,164,148,175,131,144,146,11,202,88,192,243,165,240,167,121,182,140,87,5,11,68,156,103,95,127,245,233,235,175,6,5,143,179,21,89,236,184,160,233,81,237,111,160,79,18,26,34,49,247,95,210,140,178,56,108,208,156,197,217,175,213,162,45,43,77,243,172,125,135,81,127,34,4,139,175,10,65,121,39,201,52,72,215,65,188,202,252,211,13,205,196,171,32,139,18,202,122,169,59,9,94,60,239,220,58,205,68,44,226,61,170,204,130,80,228,204,161,192,117,35,115,17,94,211,52,32,199,196,213,219,221,134,163,112,248,47,140,174,192,158,100,154,4,156,255,157,148,36,34,96,98,1,191,4,201,105,66,211,234,190,242,208,131,7,15,200,83,94,164,105,192,118,39,250,111,240,165,8,226,140,147,148,138,235,60,226,100,153,51,146,194,10,174,162,130,161,102,77,56,242,38,92,50,39,84,113,247,13,215,7,22,219,117,113,149,196,33,225,52,72,104,68,66,212,176,95,65,82,93,194,246,211,243,128,211,49,153,159,103,102,115,178,20,148,45,130,13,29,131,164,129,181,241,46,72,226,40,16,46,181,20,231,172,204,98,16,29,255,230,146,77,243,245,14,216,125,146,86,170,108,11,120,21,65,38,192,190,63,177,120,3,188,213,254,90,253,65,66,220,7,179,48,52,147,123,155,55,16,53,224,199,12,126,228,75,175,247,242,163,35,45,153,102,145,18,222,162,9,43,16,60,168,140,180,175,214,69,217,186,87,130,55,34,24,166,131,193,123,218,166,232,75,42,46,118,107,234,141,124,92,64,116,14,110,246,171,52,139,105,18,117,89,230,101,17,71,228,189,130,138,12,138,157,194,238,229,60,66,171,208,143,146,194,27,62,153,206,166,63,76,30,79,14,103,211,233,147,195,71,63,254,245,209,225,228,111,147,39,135,143,31,253,240,240,225,244,241,116,250,252,187,71,67,99,28,195,156,209,32,202,179,100,71,230,167,89,145,82,22,92,37,244,41,106,127,66,222,111,16,4,111,114,177,160,156,131,150,52,210,86,192,109,174,69,159,197,92,104,122,101,18,1,191,131,151,38,81,100,204,248,19,88,49,14,227,53,56,95,51,24,141,109,210,211,109,44,102,44,79,75,196,182,17,153,205,51,176,52,32,100,47,141,132,252,94,10,208,78,18,77,138,40,166,89,72,13,177,116,85,15,124,42,95,229,2,242,48,141,140,65,245,159,6,195,45,216,232,225,12,28,215,148,97,206,235,64,194,85,158,39,100,206,45,124,138,130,191,45,50,114,124,66,220,188,230,171,61,68,200,49,169,2,19,128,207,125,56,224,114,152,71,119,81,204,138,151,122,10,148,11,128,126,78,32,237,113,252,89,230,187,36,95,173,40,243,201,92,102,1,40,128,249,18,142,82,136,123,70,151,199,195,121,233,187,45,13,11,44,110,103,242,192,240,193,137,95,74,178,211,98,105,147,174,147,228,125,216,190,113,100,69,122,231,225,174,117,133,241,21,21,96,114,249,235,160,75,12,121,246,140,120,157,155,199,170,214,168,18,182,131,58,46,158,118,233,114,226,41,65,3,12,55,43,119,77,216,170,64,124,121,195,130,83,6,27,153,234,10,134,99,77,63,184,116,214,71,163,145,188,250,128,75,237,59,237,3,186,65,224,23,78,222,234,119,180,184,166,86,113,3,12,70,69,114,27,127,255,35,191,122,17,67,75,36,224,200,93,188,125,17,167,116,97,196,84,119,113,150,91,61,237,30,108,95,181,189,220,193,219,117,175,187,165,50,99,43,107,175,238,147,118,151,212,249,53,28,210,21,169,175,85,223,209,145,63,54,57,84,18,240,242,41,99,57,243,100,93,9,164,30,243,104,108,210,22,197,189,11,186,21,166,198,9,182,211,191,13,54,1,195,64,158,103,203,188,118,201,51,189,170,9,7,102,93,150,168,90,106,82,53,12,68,106,218,137,84,1,232,74,93,244,198,156,47,138,48,132,226,3,123,203,32,225,212,108,156,26,29,97,163,212,87,237,221,40,131,14,58,130,201,135,31,74,158,167,47,162,61,112,3,232,5,12,18,168,70,33,93,75,133,232,214,152,96,96,93,19,153,72,249,179,156,165,1,68,95,117,224,58,128,120,8,195,130,65,17,248,120,77,85,210,67,155,170,139,169,110,176,12,146,79,15,111,170,80,165,219,113,151,153,140,130,150,247,29,127,194,117,10,217,132,149,231,101,167,128,133,25,167,3,94,54,43,232,61,46,121,191,14,178,64,69,186,231,10,213,27,35,23,165,152,158,156,125,111,216,122,108,104,208,108,47,250,77,253,228,54,218,190,38,125,76,106,209,113,212,117,231,183,52,205,55,95,234,133,47,51,12,70,142,157,181,213,64,98,187,193,107,210,91,47,104,55,98,221,157,232,9,166,95,103,5,152,55,167,31,165,153,49,8,163,162,96,153,94,244,103,73,254,209,156,245,207,151,216,196,237,19,232,181,106,171,179,6,40,131,13,14,63,95,26,142,79,47,78,60,167,167,60,49,99,14,47,115,77,68,147,56,141,133,116,204,112,252,175,108,56,82,241,0,193,195,96,68,182,166,24,117,29,205,219,189,141,225,234,47,40,206,197,222,22,51,233,22,230,60,25,148,35,127,178,90,129,63,64,87,207,139,199,228,195,8,183,99,242,173,37,252,91,88,237,243,4,38,75,105,115,232,86,185,0,229,23,86,63,62,143,92,208,81,77,83,238,218,205,178,228,164,141,89,82,199,37,57,52,89,234,34,250,140,190,85,45,50,148,157,240,45,160,72,51,200,65,82,208,249,213,7,216,158,71,198,140,62,118,213,22,116,45,141,13,114,59,100,251,139,53,13,227,229,238,77,126,150,135,191,188,138,17,93,61,39,84,162,165,111,97,158,128,120,97,242,7,154,186,97,11,173,27,180,224,154,10,163,77,93,228,29,150,57,109,160,198,157,76,173,52,110,175,243,237,76,22,102,150,173,205,78,222,109,3,141,59,81,214,76,46,151,202,193,251,176,81,57,59,206,228,84,101,184,193,57,151,189,255,51,98,95,129,216,170,186,80,90,32,186,25,152,194,230,13,167,15,42,29,124,243,250,224,109,253,218,93,181,2,74,3,222,188,36,48,218,250,213,216,58,231,167,191,22,96,193,4,135,189,220,171,13,79,205,227,198,53,198,55,173,34,190,249,166,227,22,186,190,141,252,139,28,3,196,88,43,94,18,175,102,45,127,146,237,188,81,89,149,117,22,129,180,195,33,241,42,23,156,133,191,45,228,178,196,146,215,50,132,141,201,16,102,218,54,87,201,178,110,34,195,112,223,40,244,96,99,2,21,235,117,41,75,109,251,186,11,208,58,140,91,18,97,253,18,165,177,106,245,30,2,226,157,35,203,107,21,93,245,9,46,245,25,221,208,68,117,38,125,29,131,27,16,211,235,32,91,209,72,69,32,255,47,68,197,93,32,94,34,85,61,132,193,176,106,43,133,112,244,47,215,168,107,4,248,81,102,59,216,250,175,2,174,201,164,210,138,248,51,226,231,52,93,3,90,44,13,248,207,1,195,247,189,255,109,240,232,75,220,13,62,179,56,17,216,116,125,94,220,216,32,208,26,252,57,254,87,194,255,159,220,175,226,209,41,113,40,240,182,254,167,53,207,195,76,68,3,28,188,100,43,164,107,69,156,53,232,84,193,117,10,43,78,127,250,229,220,173,184,88,192,208,69,208,148,61,35,89,145,36,4,38,51,108,43,158,65,75,217,126,68,219,85,93,174,156,94,5,77,117,211,69,163,183,52,204,89,36,239,106,88,92,226,220,220,254,50,59,174,233,186,199,170,250,85,111,158,133,73,17,81,144,32,242,25,11,86,242,109,167,189,255,213,242,199,86,67,73,54,216,150,209,168,30,88,24,5,70,95,180,194,158,34,78,14,142,165,177,74,139,235,106,46,152,126,123,80,218,75,150,53,105,85,235,97,153,102,84,103,36,103,120,155,83,157,11,246,132,54,131,163,38,66,226,44,204,211,234,1,216,66,138,63,215,91,21,100,80,211,14,195,214,248,140,27,246,43,153,52,205,160,181,191,177,219,209,234,110,183,25,231,108,111,202,169,98,174,226,124,90,112,145,167,101,244,219,217,49,107,190,195,243,230,219,138,61,211,233,70,219,205,154,214,19,62,102,208,89,18,172,218,65,38,41,74,137,122,162,24,64,19,119,176,255,187,128,221,133,150,29,229,104,111,7,220,118,181,166,242,29,142,220,142,27,163,85,109,82,168,9,236,157,19,170,155,85,181,103,158,149,2,237,200,58,104,25,194,221,9,191,86,114,148,74,78,12,84,38,113,189,175,234,81,7,48,186,107,157,75,89,19,111,229,88,254,194,25,190,201,208,45,93,119,47,138,103,113,246,11,173,137,47,223,198,254,96,101,212,232,235,46,144,174,216,113,243,146,127,82,229,236,127,167,237,251,156,50,89,175,19,152,178,157,47,202,123,191,34,147,0,63,234,186,143,241,248,18,20,108,104,212,241,186,254,207,115,134,67,251,225,247,163,127,91,79,230,50,40,206,171,111,196,94,203,139,176,202,176,141,15,82,85,242,236,127,157,116,114,170,131,80,5,190,253,241,229,212,237,70,83,82,54,17,183,121,228,189,5,242,155,223,165,1,248,150,137,154,120,223,243,114,92,162,187,255,241,119,32,174,89,254,177,9,175,189,136,169,128,76,88,145,80,5,29,23,43,156,192,102,137,148,234,192,126,156,124,215,6,19,147,61,219,80,98,181,110,119,119,109,215,243,77,109,144,104,165,174,205,182,183,57,98,230,153,253,180,125,53,194,206,240,247,131,185,82,235,47,9,114,183,79,82,185,94,223,143,180,214,132,36,91,215,46,152,125,200,175,212,63,84,89,189,145,243,53,13,155,146,55,116,43,102,49,163,184,209,248,6,33,91,224,163,42,189,149,28,125,195,35,210,95,172,14,220,246,203,218,170,72,165,178,255,113,58,188,175,132,37,181,186,55,228,148,95,24,107,255,120,96,177,199,182,176,246,111,69,90,194,103,132,95,190,238,169,135,173,137,206,252,207,83,27,2,123,190,75,221,111,21,50,138,125,57,126,205,215,127,200,173,170,168,115,252,215,48,53,130,19,38,103,112,14,13,243,50,39,158,158,200,35,2,134,32,213,255,68,45,229,63,232,140,234,125,16,126,157,189,162,20,234,93,190,142,251,90,161,214,196,131,255,216,214,149,119,238,175,103,185,199,26,130,23,250,220,245,163,214,17,171,85,119,17,214,126,7,156,49,122,168,41,43,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNotExistingSignalEntityErrorLocalizableString());
			LocalizableStrings.Add(CreateEmptyEntityFilterWarningLocalizableString());
			LocalizableStrings.Add(CreateEmptyEntityColumnsWarningLocalizableString());
			LocalizableStrings.Add(CreateOnCopyExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnFinalizeExceptionLocalizableString());
			LocalizableStrings.Add(CreateLinkedCustomElementsExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNotExistingSignalEntityErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ca262bdc-02c1-4c6f-8b06-4023536955e8"),
				Name = "NotExistingSignalEntityError",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyEntityFilterWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f93cdad5-5314-4355-b8a7-65a1c2171c95"),
				Name = "EmptyEntityFilterWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyEntityColumnsWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d80e26e1-a590-4088-89f2-b131a9f1dce8"),
				Name = "EmptyEntityColumnsWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnCopyExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("26f6b121-2628-4e98-9255-f69928d66fe6"),
				Name = "OnCopyException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnFinalizeExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fa87089a-a36d-480c-97be-3fd4aa5e9335"),
				Name = "OnFinalizeException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLinkedCustomElementsExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fa959371-fb71-43a1-8b7f-27526e5c9124"),
				Name = "LinkedCustomElementsException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b"),
				ModifiedInSchemaUId = new Guid("498a4852-f998-420d-9a62-3cefc62a736b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("498a4852-f998-420d-9a62-3cefc62a736b"));
		}

		#endregion

	}

	#endregion

}

