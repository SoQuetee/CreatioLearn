namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddCampaignAudienceElementHandlerSchema

	/// <exclude/>
	public class AddCampaignAudienceElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddCampaignAudienceElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddCampaignAudienceElementHandlerSchema(AddCampaignAudienceElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4");
			Name = "AddCampaignAudienceElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,91,111,211,72,20,126,14,18,255,225,16,94,28,41,114,180,111,136,38,145,10,155,208,74,129,34,90,232,3,218,135,169,125,146,140,214,158,201,206,140,67,3,234,127,231,204,205,177,221,36,5,180,82,94,50,115,46,223,124,223,185,88,176,18,245,134,101,8,55,168,20,211,114,105,210,183,82,44,249,170,82,204,112,41,158,63,251,241,252,89,175,210,92,172,224,122,167,13,150,116,95,20,152,217,75,157,190,67,129,138,103,103,93,155,5,23,255,61,58,188,193,123,179,63,108,38,84,152,158,27,163,248,93,101,80,31,53,121,203,202,13,227,43,241,164,65,58,219,162,48,23,76,228,5,170,189,181,181,137,38,215,217,26,75,6,19,104,59,182,175,201,149,156,71,163,17,140,117,85,150,76,237,166,225,63,113,100,24,23,26,74,52,107,153,107,88,74,5,37,157,216,83,155,235,60,207,225,188,202,57,10,226,22,11,44,9,144,6,46,32,139,169,98,228,81,35,244,166,186,43,120,6,26,89,129,57,100,5,211,218,70,138,168,98,192,153,143,23,30,8,175,225,13,211,120,218,104,8,151,87,34,154,124,97,5,207,153,65,202,248,195,61,177,247,82,225,138,4,181,239,210,70,85,153,145,74,191,134,143,14,142,183,8,208,158,68,147,12,192,86,76,175,135,173,227,15,84,104,196,246,59,52,55,187,13,38,131,212,30,88,105,122,15,1,1,138,220,131,104,35,122,239,9,38,48,138,111,29,102,135,198,255,129,173,228,57,220,42,110,112,206,11,131,42,188,140,28,47,197,82,38,39,120,137,162,68,184,91,70,2,162,214,108,21,112,46,178,239,215,84,146,98,69,49,43,76,30,63,103,8,125,159,244,150,155,245,7,73,212,229,220,102,190,101,202,150,64,127,112,86,7,222,182,96,189,175,211,104,151,32,157,75,85,50,147,132,244,195,8,141,170,113,99,125,66,160,118,109,166,164,68,231,181,7,179,12,161,163,122,184,94,224,22,139,52,96,29,52,149,104,113,27,75,101,46,139,28,149,78,46,103,162,42,81,177,187,2,199,39,216,157,214,53,31,249,229,75,72,94,196,195,244,92,236,146,65,188,234,41,52,149,18,254,149,15,53,105,75,159,146,104,90,72,150,7,0,238,161,117,236,64,204,26,179,127,195,253,236,158,211,172,17,186,22,76,15,99,160,134,30,225,196,11,231,69,164,52,115,46,98,154,230,77,210,246,247,154,253,65,173,184,40,167,107,197,85,114,71,213,71,239,104,98,27,66,249,255,202,236,162,182,101,110,180,252,71,166,12,207,248,134,9,115,84,104,154,132,200,178,53,36,150,232,112,105,7,95,215,206,9,65,147,78,101,235,191,153,177,163,120,38,50,153,219,126,248,124,51,127,69,171,197,188,217,209,58,136,4,164,30,91,96,202,123,187,78,8,163,37,154,145,95,93,140,194,112,179,243,253,226,184,252,172,81,17,247,194,175,175,65,186,15,112,118,8,211,5,211,251,226,112,228,95,96,177,65,149,186,138,187,126,108,151,236,3,14,27,113,134,208,73,28,178,185,158,56,144,174,166,168,119,124,180,197,241,21,66,61,236,155,231,215,7,170,52,132,7,115,127,223,93,115,238,224,147,235,76,13,102,141,80,80,103,129,92,146,17,34,100,10,151,147,254,201,210,232,143,166,245,182,3,214,221,133,105,157,115,212,77,58,222,48,197,74,16,196,226,164,239,25,237,79,99,158,32,58,85,148,54,140,2,166,227,145,51,223,123,251,105,162,167,139,128,55,147,130,208,82,165,159,0,51,30,69,47,223,26,129,25,144,91,250,194,224,57,194,47,207,189,102,249,133,232,201,129,15,15,255,138,40,180,79,30,14,211,121,33,191,69,223,244,106,105,23,230,19,77,152,12,126,111,149,54,246,250,65,217,227,56,208,71,190,99,228,254,59,166,177,219,82,240,45,129,186,158,221,223,104,86,129,144,86,3,63,240,142,233,254,245,74,145,67,242,215,224,159,198,199,134,27,77,87,245,231,74,210,220,213,53,150,201,97,202,91,116,15,126,139,198,63,216,85,209,216,206,230,121,189,183,234,16,183,107,84,152,220,195,100,10,47,238,211,125,159,251,48,221,29,123,32,88,99,119,181,110,253,184,62,146,234,68,166,48,230,15,196,58,85,73,116,74,191,159,63,25,233,251,52,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFolderWithNoConditionWarningLocalizableString());
			LocalizableStrings.Add(CreateFolderNotFoundErrorLocalizableString());
			LocalizableStrings.Add(CreateFilterWithNoConditionWarningLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFolderWithNoConditionWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7244310a-84bf-404b-baa6-2bae953fbbc1"),
				Name = "FolderWithNoConditionWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFolderNotFoundErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f6c3f61f-5296-4d52-bc90-ce76168b921f"),
				Name = "FolderNotFoundError",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFilterWithNoConditionWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b77bcf38-2f18-445a-8f83-e2935ae6e184"),
				Name = "FilterWithNoConditionWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"));
		}

		#endregion

	}

	#endregion

}

