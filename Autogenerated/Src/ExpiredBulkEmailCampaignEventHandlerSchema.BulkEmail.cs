namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExpiredBulkEmailCampaignEventHandlerSchema

	/// <exclude/>
	public class ExpiredBulkEmailCampaignEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExpiredBulkEmailCampaignEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExpiredBulkEmailCampaignEventHandlerSchema(ExpiredBulkEmailCampaignEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756");
			Name = "ExpiredBulkEmailCampaignEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,77,111,226,48,16,189,87,234,127,152,165,151,68,66,102,207,133,34,149,54,237,34,209,165,43,232,246,108,146,9,88,117,28,106,59,180,108,219,255,190,147,207,77,8,148,74,155,11,194,243,245,230,205,27,91,241,8,205,154,251,8,115,212,154,155,56,180,236,42,86,161,88,38,154,91,17,171,211,147,183,211,19,160,47,49,66,45,97,182,53,22,163,126,251,136,162,164,68,63,13,49,236,22,21,106,225,239,115,155,8,245,220,56,175,215,141,162,88,29,52,106,100,87,60,90,115,177,252,146,15,243,54,168,236,15,174,2,137,250,179,128,235,81,195,154,158,149,57,102,254,10,35,14,23,208,204,220,52,83,116,30,127,166,113,73,237,195,149,228,198,156,131,247,186,22,26,131,81,34,159,188,136,11,89,70,213,113,149,161,235,100,33,133,15,6,185,196,0,252,52,193,151,226,225,28,246,29,143,184,193,46,140,167,170,52,254,230,82,4,220,98,55,47,151,126,53,235,8,67,234,111,198,55,152,155,223,74,88,245,174,238,208,174,226,128,250,186,215,98,67,169,234,62,235,252,8,22,113,44,225,22,9,134,41,208,103,200,141,51,246,84,18,161,230,11,137,131,219,68,4,67,192,212,48,14,140,11,111,255,242,164,159,8,193,249,246,96,80,147,12,85,46,40,210,147,29,155,27,228,54,209,232,169,52,75,224,116,230,90,44,151,168,179,10,243,149,142,173,149,52,191,95,9,38,216,113,225,253,189,42,193,198,198,139,214,118,235,184,173,98,233,167,145,210,42,8,185,52,216,111,154,63,154,127,55,92,211,136,82,149,147,36,20,190,192,44,251,227,52,209,186,36,171,68,89,71,209,106,197,161,83,205,143,141,3,215,101,55,58,142,90,38,215,109,195,98,143,43,212,120,32,203,88,57,180,111,73,164,216,61,215,228,97,81,27,167,162,116,95,182,75,21,180,115,101,67,202,214,252,154,198,151,230,53,19,52,102,170,189,231,132,203,86,9,39,245,154,139,8,217,131,245,127,198,47,196,39,55,5,9,253,54,85,25,30,147,145,65,124,229,196,81,73,244,19,139,51,159,75,174,7,66,217,161,227,238,196,22,3,169,135,15,225,123,205,233,99,159,246,218,18,35,213,84,173,18,45,206,158,205,54,217,79,75,22,5,130,220,202,110,100,252,226,73,140,104,191,12,155,134,243,237,26,7,119,92,63,161,37,189,101,217,11,43,181,194,10,73,188,194,197,16,94,89,211,141,70,119,172,139,77,44,2,40,183,181,190,67,78,11,100,69,49,245,70,252,182,186,109,116,186,203,113,26,188,218,217,210,60,73,107,119,43,89,245,247,44,234,110,142,79,54,236,248,110,209,83,100,248,18,115,28,19,255,207,204,106,162,142,216,72,170,61,248,202,165,232,118,219,16,58,117,148,83,69,119,29,101,46,131,59,187,173,53,185,99,151,65,80,140,132,54,101,172,194,216,41,144,118,97,231,130,45,236,19,220,160,100,143,92,43,170,114,112,230,103,168,130,252,114,253,252,190,205,222,134,186,75,175,215,131,129,73,162,136,235,237,176,121,156,83,96,128,211,254,164,148,128,93,113,11,194,128,230,194,208,211,178,200,174,122,240,11,216,133,196,193,208,221,31,176,157,10,189,118,137,226,157,202,84,58,173,189,27,109,117,238,215,240,33,42,26,29,29,235,129,200,169,240,111,42,222,203,214,140,229,218,178,227,224,75,128,255,11,189,61,197,202,220,52,209,241,95,87,240,240,89,110,9,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExpiredEmailOnSavingCampaignLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExpiredEmailOnSavingCampaignLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c4cf7837-443a-45c8-e95c-827f665cb8d6"),
				Name = "ExpiredEmailOnSavingCampaign",
				CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb"),
				CreatedInSchemaUId = new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756"),
				ModifiedInSchemaUId = new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756"));
		}

		#endregion

	}

	#endregion

}

