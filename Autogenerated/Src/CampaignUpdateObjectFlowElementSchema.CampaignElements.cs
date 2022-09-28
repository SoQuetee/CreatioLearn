﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignUpdateObjectFlowElementSchema

	/// <exclude/>
	public class CampaignUpdateObjectFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignUpdateObjectFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignUpdateObjectFlowElementSchema(CampaignUpdateObjectFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8789f875-7dfa-4384-bf34-de1db29777b4");
			Name = "CampaignUpdateObjectFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("279db9e2-5b1e-4ae7-af81-571fcca6f075");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,75,115,219,54,16,62,43,51,249,15,104,210,3,53,163,161,115,110,108,119,28,91,242,104,106,199,73,236,180,135,78,15,48,185,146,208,128,0,13,128,182,53,142,254,123,23,4,64,130,15,229,213,92,108,3,92,124,251,254,22,176,160,5,232,146,102,64,110,64,41,170,229,202,164,167,82,172,216,186,82,212,48,41,158,63,123,122,254,108,82,105,38,214,228,122,171,13,20,175,123,107,148,231,28,50,43,172,211,115,16,160,88,54,144,185,96,226,174,221,140,117,21,133,20,227,95,20,236,219,79,79,105,81,82,182,222,123,48,61,123,179,247,211,92,24,102,24,104,20,64,145,151,10,214,104,57,57,229,84,235,223,72,0,254,88,230,212,192,213,237,191,232,216,130,203,135,57,135,2,132,169,143,28,28,28,144,67,93,21,5,85,219,99,191,158,63,66,86,25,122,203,129,20,50,103,171,45,1,171,6,127,185,131,132,26,146,121,236,52,96,28,68,32,101,117,203,89,70,50,107,198,215,172,32,173,157,111,168,134,83,85,229,35,150,78,158,106,107,27,15,47,193,108,100,142,62,190,83,236,30,97,221,215,210,45,200,173,148,156,56,125,117,128,182,201,220,59,80,255,154,145,243,138,229,36,147,194,208,204,44,115,191,46,169,50,44,99,37,21,118,207,226,77,38,167,69,89,91,142,38,205,121,7,228,26,140,193,132,232,41,121,170,69,141,218,250,191,38,11,198,189,44,86,83,85,8,157,4,189,145,202,46,74,234,37,7,251,31,64,27,172,65,3,185,151,152,190,118,74,156,92,250,81,195,73,94,48,241,129,173,55,70,147,35,178,162,92,131,151,81,96,42,37,60,100,122,77,239,33,169,63,123,140,29,102,209,100,27,146,204,31,51,40,109,205,19,120,12,254,76,66,86,46,228,122,13,42,157,43,37,213,66,170,130,154,68,96,163,201,85,18,36,78,242,97,202,166,232,201,227,172,81,157,109,160,160,111,241,152,143,235,228,215,23,203,28,173,125,242,2,152,70,91,60,206,199,63,41,175,96,71,222,197,249,176,178,157,4,237,94,76,187,94,70,142,239,236,207,93,183,38,198,50,121,14,102,222,9,247,66,201,226,66,202,79,85,153,132,56,220,83,69,120,189,53,215,119,104,133,128,7,226,15,213,78,189,175,64,109,19,76,131,66,170,17,142,58,210,88,224,146,10,138,1,156,145,16,181,161,33,211,38,232,227,233,244,65,91,174,5,246,252,25,211,37,167,219,58,72,86,194,168,10,156,215,206,249,198,216,20,243,114,194,185,179,34,84,162,149,246,129,179,158,173,24,55,160,16,165,61,117,170,0,227,181,168,63,252,197,204,6,211,128,134,227,66,39,110,19,105,14,51,193,180,20,55,219,18,41,232,174,162,220,91,184,223,69,31,18,91,2,88,26,209,162,111,180,211,161,173,241,137,179,46,50,23,60,221,117,12,110,178,216,114,119,47,31,30,129,173,72,18,16,176,225,42,36,159,163,35,242,170,9,190,213,128,19,68,99,186,80,129,237,59,177,78,125,201,119,235,228,173,52,11,60,159,55,141,115,233,142,141,120,54,49,27,37,31,92,217,4,233,196,107,153,70,229,26,202,216,10,142,196,175,239,81,176,185,213,135,38,7,231,254,126,245,143,141,138,77,79,30,181,212,161,115,233,56,249,182,52,77,3,7,58,210,114,64,239,168,217,116,53,249,134,254,81,133,3,244,72,111,93,178,63,199,175,192,158,1,124,192,171,63,213,169,33,107,79,163,22,237,49,83,191,120,27,90,66,83,218,221,55,91,31,169,11,166,77,178,156,139,170,0,101,103,244,161,29,94,199,97,180,232,89,92,23,174,247,195,76,169,23,179,81,38,28,159,105,117,203,125,129,245,98,220,255,67,97,231,92,222,82,126,82,150,205,216,91,32,7,85,10,70,196,151,226,140,26,106,187,225,134,234,79,58,102,62,216,195,121,17,129,100,113,181,197,93,19,79,226,94,65,182,228,225,41,97,169,223,86,156,95,169,121,81,98,99,14,32,91,54,247,45,157,195,138,86,60,112,72,155,210,78,251,91,252,95,172,7,222,234,244,68,108,147,71,114,116,76,30,83,103,232,209,208,250,86,149,247,221,125,26,177,41,86,213,18,255,185,146,85,185,47,189,129,237,27,82,69,29,51,130,215,1,150,81,126,85,130,187,83,95,215,133,158,94,5,154,94,97,194,168,189,84,68,225,198,241,205,68,83,161,29,190,109,6,16,252,240,232,25,134,37,186,104,5,22,142,252,29,142,150,93,83,62,195,233,83,31,241,114,225,62,245,29,67,199,247,250,75,16,185,187,186,238,189,199,74,3,150,48,220,247,254,181,60,186,151,99,199,100,149,82,246,234,188,194,251,86,115,41,199,8,175,20,93,219,191,211,6,226,160,143,113,232,124,208,199,110,254,201,85,124,237,213,228,97,195,48,119,27,170,201,45,128,32,165,146,25,142,42,200,211,195,131,112,208,81,151,183,150,200,123,124,144,176,28,80,189,33,11,175,223,27,218,185,67,101,45,131,218,150,143,8,85,255,158,222,200,154,213,162,57,221,21,199,10,197,142,35,159,63,119,96,198,102,184,79,17,118,243,18,159,106,182,94,56,22,80,158,36,215,96,211,52,197,188,157,84,57,3,145,129,227,176,233,160,53,186,124,96,233,233,75,215,196,150,91,168,199,109,152,218,29,13,234,252,102,135,142,98,2,69,233,175,223,34,109,221,45,133,54,180,214,99,107,61,25,220,56,6,60,215,114,92,13,213,48,204,130,41,109,174,212,153,167,167,30,217,124,141,22,7,110,68,19,236,232,91,102,216,32,94,169,75,235,172,59,175,226,231,78,51,160,70,184,198,191,81,153,24,152,211,33,156,150,146,130,139,163,67,190,30,170,93,30,13,84,98,81,202,222,219,100,232,203,120,112,107,240,136,202,145,160,210,63,96,27,33,51,237,18,234,158,175,22,187,243,144,29,121,73,118,223,173,253,81,238,161,235,241,210,195,110,226,50,113,27,72,183,30,231,218,224,248,213,73,15,57,188,247,208,69,91,129,70,55,255,186,136,158,106,245,59,209,157,111,217,119,98,205,101,162,10,15,211,221,240,222,251,221,29,59,206,172,110,183,187,185,251,15,151,106,138,120,25,18,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEntitySettingsNotFoundLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEntitySettingsNotFoundLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5e89ca0b-2d47-4dd4-9717-a49eb56c52a9"),
				Name = "EntitySettingsNotFound",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("8789f875-7dfa-4384-bf34-de1db29777b4"),
				ModifiedInSchemaUId = new Guid("8789f875-7dfa-4384-bf34-de1db29777b4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8789f875-7dfa-4384-bf34-de1db29777b4"));
		}

		#endregion

	}

	#endregion

}
