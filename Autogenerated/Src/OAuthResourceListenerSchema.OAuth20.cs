namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthResourceListenerSchema

	/// <exclude/>
	public class OAuthResourceListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthResourceListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthResourceListenerSchema(OAuthResourceListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2");
			Name = "OAuthResourceListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,86,75,143,218,72,16,62,19,41,255,161,229,189,24,9,153,85,142,51,128,68,24,146,32,101,118,162,64,118,15,81,14,61,118,1,157,181,187,173,238,54,25,118,196,127,223,234,151,177,29,216,25,20,69,138,180,39,232,118,61,191,250,170,186,56,45,64,149,52,5,178,2,41,169,18,107,157,204,4,95,179,77,37,169,102,130,39,119,211,74,111,95,253,254,242,197,227,203,23,189,74,49,190,33,203,189,210,80,92,119,206,168,151,231,144,26,37,149,188,5,14,146,165,71,153,166,249,162,16,252,244,23,9,201,156,107,166,25,168,39,5,146,249,14,184,62,41,103,99,94,112,13,27,159,196,205,234,238,89,114,243,135,20,74,243,15,165,81,254,55,9,27,60,144,89,78,149,186,34,86,252,35,40,81,201,20,222,51,76,26,147,180,130,159,109,80,123,27,81,248,16,47,211,45,20,244,15,68,152,140,73,212,82,142,250,95,80,171,172,238,115,150,146,212,88,63,109,156,92,145,215,84,129,253,54,45,217,140,34,194,232,177,247,104,189,30,227,67,200,181,172,82,45,36,134,249,193,154,117,18,222,197,73,227,113,31,205,223,163,249,152,195,55,114,195,108,233,168,220,143,86,251,18,6,4,45,34,90,19,148,50,149,239,245,30,137,198,123,177,142,49,144,37,200,29,200,26,173,254,128,68,239,69,74,115,246,15,189,207,97,105,53,85,18,28,126,196,40,209,165,185,156,75,41,228,45,40,69,55,144,252,73,243,10,34,114,24,156,177,143,105,113,67,168,157,129,246,9,95,65,86,240,147,46,140,135,3,102,114,240,192,1,207,28,118,109,32,111,65,111,69,102,48,148,108,71,53,120,16,221,129,96,96,33,165,5,95,11,242,22,116,227,234,141,20,133,163,65,236,126,8,216,159,128,223,142,74,34,189,172,39,133,19,192,102,209,6,242,12,27,168,42,184,13,121,20,208,143,140,104,212,191,254,206,196,13,83,101,78,247,23,88,106,104,52,13,210,99,10,104,200,80,161,155,167,139,191,231,93,53,115,112,149,235,181,99,57,17,161,151,251,32,69,9,210,52,175,247,212,32,157,11,179,166,93,112,138,180,136,76,74,17,150,125,90,150,72,102,219,169,211,52,197,10,251,194,98,105,237,207,193,37,37,65,87,146,55,243,178,247,207,47,189,208,200,36,200,66,241,253,145,8,164,164,100,25,144,157,96,25,89,109,165,248,86,179,50,118,97,19,176,228,83,155,62,25,79,136,54,34,54,207,86,255,29,149,106,233,235,231,198,214,104,237,225,112,72,70,170,42,10,68,111,18,46,222,81,158,229,8,175,227,3,89,210,29,6,14,102,44,37,181,206,176,171,52,42,169,164,5,225,88,168,113,164,48,6,144,209,196,206,50,226,78,201,104,104,69,78,107,64,52,89,109,1,99,1,32,169,132,245,56,90,93,157,157,217,54,174,233,26,167,129,117,48,149,27,172,226,112,66,24,78,48,202,145,130,169,224,154,50,110,192,212,91,8,14,109,10,36,163,154,182,98,241,227,173,93,153,59,190,224,202,208,140,111,98,113,255,21,139,231,211,24,16,231,254,53,172,49,168,218,63,129,208,162,179,45,164,127,207,40,191,165,28,135,199,18,155,200,213,214,106,251,150,49,3,51,105,186,8,182,161,209,83,30,254,49,241,163,160,239,132,156,64,183,189,218,13,120,118,168,248,105,226,108,204,31,32,173,52,248,55,33,142,45,223,22,153,147,49,211,147,165,240,151,164,37,182,91,50,205,178,96,46,110,248,194,65,234,167,198,39,117,156,181,130,215,153,28,46,226,153,101,255,175,70,180,78,165,127,128,105,54,24,8,157,235,221,187,197,231,14,65,182,67,9,145,197,41,96,102,69,221,226,209,100,86,73,105,44,86,8,50,102,169,148,81,103,202,88,160,102,170,184,157,4,30,176,35,56,205,9,181,131,173,129,97,237,243,191,8,239,240,255,121,108,247,246,59,84,191,128,32,55,144,131,254,63,82,100,193,119,184,170,100,53,71,26,204,168,49,161,220,61,16,245,203,105,248,193,133,38,168,84,48,141,44,185,148,15,193,244,133,140,120,114,116,53,23,144,37,110,155,200,155,227,242,209,30,35,245,246,231,229,156,1,255,76,22,110,61,243,91,192,119,235,92,220,241,49,232,172,207,97,131,53,75,65,184,11,41,55,215,191,176,230,28,31,226,179,229,136,125,72,45,102,159,65,247,83,137,181,255,169,253,86,123,248,229,31,23,27,41,252,200,251,210,89,122,220,109,251,242,240,47,11,105,31,119,167,14,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateConnectionErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceRegisteringErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceModifyingErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceDeletingErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateConnectionErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e03aaebb-193b-8726-710a-929627d6b105"),
				Name = "ConnectionErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceRegisteringErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("21597b70-844d-8f8f-62df-ff422643519c"),
				Name = "ResourceRegisteringErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceModifyingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("592cb685-553c-4598-8deb-f17e38c2101e"),
				Name = "ResourceModifyingErrorMessage",
				CreatedInPackageId = new Guid("1cbe3766-af85-4075-b77c-3de2d413d0be"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceDeletingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("12e7cc28-c036-6369-e37b-184500b360e6"),
				Name = "ResourceDeletingErrorMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"));
		}

		#endregion

	}

	#endregion

}

