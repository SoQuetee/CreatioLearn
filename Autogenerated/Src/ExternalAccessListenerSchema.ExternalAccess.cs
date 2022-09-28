﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExternalAccessListenerSchema

	/// <exclude/>
	public class ExternalAccessListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExternalAccessListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExternalAccessListenerSchema(ExternalAccessListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572");
			Name = "ExternalAccessListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,221,111,227,184,17,127,206,1,247,63,112,213,5,78,6,92,5,247,154,175,69,226,120,247,124,77,54,65,156,244,30,22,139,66,145,104,155,141,44,122,41,41,137,27,228,127,239,12,135,148,68,125,216,206,93,123,219,135,190,36,22,53,156,239,249,113,134,118,26,46,121,182,10,35,206,110,185,82,97,38,103,121,48,146,233,76,204,11,21,230,66,166,193,248,57,231,42,13,147,211,40,226,89,118,29,70,15,225,156,255,248,195,203,143,63,236,21,153,72,231,108,186,206,114,190,60,108,60,3,151,36,225,17,178,200,130,79,60,229,74,68,45,154,11,145,126,107,45,222,20,105,46,150,60,152,194,150,48,17,255,210,106,180,168,166,60,42,148,200,215,213,139,121,34,239,195,228,224,96,36,151,75,208,251,66,206,231,176,92,189,175,27,136,20,221,111,20,239,91,15,206,207,122,95,141,65,229,92,240,108,43,65,48,126,228,105,222,79,247,49,140,114,169,122,56,93,66,0,66,52,170,101,1,238,165,176,177,99,253,224,6,17,8,129,244,47,138,207,225,129,141,146,48,203,14,152,27,216,11,1,110,133,40,105,202,253,253,125,118,148,21,203,101,168,214,39,230,217,18,176,153,84,236,39,119,243,79,140,163,125,107,198,181,117,129,101,177,223,224,113,148,113,30,38,153,100,145,226,179,99,111,179,143,130,179,48,227,122,109,173,23,172,2,30,219,71,126,95,58,94,249,211,104,193,151,225,103,72,106,240,131,231,42,233,13,190,194,182,85,113,159,136,136,69,232,131,30,23,176,3,214,35,26,246,191,104,7,85,190,132,244,206,67,208,246,128,93,43,241,24,230,156,222,175,232,129,69,248,158,101,185,194,40,77,98,114,211,105,28,43,144,55,229,121,14,203,153,85,215,190,134,196,127,228,234,78,37,222,97,47,171,81,34,128,120,18,111,230,97,169,182,50,130,106,82,60,223,133,25,81,122,135,198,13,60,141,201,19,174,91,62,10,158,196,125,62,1,135,229,16,2,197,195,88,166,201,154,77,160,84,217,63,18,137,185,11,31,47,195,20,16,70,1,104,228,88,195,16,213,86,32,183,72,191,228,249,66,110,19,255,40,69,204,70,11,30,61,16,162,92,173,56,21,203,13,71,215,68,57,143,47,101,204,125,121,255,79,128,49,150,129,44,174,6,12,113,111,111,239,49,84,54,229,143,153,79,153,50,32,146,195,146,160,200,192,105,50,77,9,5,129,144,118,4,119,206,58,209,139,25,243,93,250,96,146,53,20,203,42,205,172,30,123,249,66,201,39,150,242,39,214,107,197,248,57,226,43,92,242,7,36,235,21,255,190,246,59,229,179,204,197,108,77,225,62,189,151,69,94,113,112,85,111,88,56,100,37,33,11,117,164,62,41,40,141,114,209,42,141,182,190,187,204,230,163,69,8,91,19,27,239,73,6,200,159,66,254,149,198,65,162,21,42,173,41,173,221,26,209,54,240,103,7,15,93,141,17,224,168,72,227,9,248,227,108,125,55,137,155,158,29,21,74,129,109,104,76,48,137,7,85,4,74,214,199,44,45,146,100,139,34,153,88,174,18,78,160,140,245,162,163,224,172,153,237,103,50,198,60,233,242,201,7,80,25,128,165,114,220,135,15,157,116,67,226,52,137,129,207,167,66,196,193,103,254,132,255,253,1,41,69,186,57,26,5,191,64,129,129,133,40,253,118,189,226,182,170,53,99,112,115,163,168,54,112,152,234,196,70,11,129,133,156,249,221,176,105,252,104,124,24,92,203,44,55,124,124,135,43,209,53,242,239,92,232,208,192,89,113,68,192,52,52,0,117,66,53,122,154,198,23,50,140,111,248,183,66,40,30,67,178,91,176,218,146,147,228,55,226,245,229,43,148,49,237,170,23,242,99,152,20,60,3,243,236,203,224,86,86,250,248,196,33,2,44,96,199,39,12,255,15,221,165,234,240,13,106,122,33,126,253,29,57,251,205,42,209,44,152,231,81,232,140,219,208,139,71,214,100,190,92,33,234,18,35,80,140,52,12,126,91,112,197,253,7,190,214,124,81,180,253,28,208,223,73,246,25,210,246,74,253,182,16,57,159,98,91,231,15,72,202,30,4,17,219,177,238,221,127,227,235,1,24,141,58,248,181,114,112,212,64,230,50,31,227,18,48,181,169,173,129,80,41,169,110,129,56,193,72,82,29,92,200,72,247,110,247,9,159,106,163,154,53,8,248,36,11,21,193,91,169,32,41,134,205,211,186,60,237,141,179,247,188,22,75,104,20,234,10,218,164,213,38,121,104,143,145,108,44,170,116,173,74,150,28,30,124,148,106,25,230,190,99,136,77,192,224,87,41,82,223,3,5,135,110,92,6,150,111,133,193,32,90,196,176,183,2,204,186,188,58,252,26,72,49,145,237,170,136,9,42,98,154,110,37,159,215,12,242,169,177,228,111,168,26,101,43,165,35,225,51,125,158,155,46,228,84,205,77,204,116,47,163,10,108,64,97,177,88,2,68,250,94,86,54,35,195,22,207,47,27,26,154,175,131,234,32,140,76,27,178,69,148,37,235,146,212,213,239,180,69,80,115,178,147,24,211,199,244,138,106,119,68,117,113,121,35,54,199,212,84,83,247,190,198,210,63,106,198,239,196,111,186,125,88,119,204,176,105,130,145,102,242,164,33,176,43,97,124,60,15,160,199,28,178,123,41,19,118,10,169,241,200,7,12,97,19,33,114,146,206,228,182,243,91,115,128,246,48,7,59,38,177,155,50,136,30,216,236,16,142,12,244,97,71,144,226,114,177,120,243,81,201,165,239,1,32,158,198,75,145,222,165,34,247,236,43,24,13,51,223,211,129,246,72,205,242,21,65,156,55,178,58,64,29,79,178,241,183,34,76,124,216,85,44,211,224,58,84,16,12,128,10,191,84,20,216,160,230,158,173,72,82,22,38,87,152,17,1,7,33,128,9,191,225,145,84,177,175,244,137,134,224,231,219,163,93,31,113,16,49,226,175,209,227,8,217,157,104,21,7,195,77,116,232,105,160,115,140,24,12,25,244,76,12,189,6,129,46,146,220,141,36,173,117,5,176,234,72,245,17,45,213,78,225,194,197,50,232,34,179,97,175,90,45,34,96,239,142,217,230,54,200,66,122,131,234,252,204,142,218,227,20,102,79,152,44,81,195,81,152,26,247,150,29,39,68,45,76,207,193,245,115,141,128,173,142,189,132,62,221,255,53,53,237,66,231,63,239,32,161,2,9,181,70,227,154,18,253,135,73,173,241,182,238,217,10,250,175,187,142,45,122,70,165,151,205,81,92,47,252,18,166,113,2,45,139,25,65,166,225,35,143,105,246,14,202,61,251,205,77,71,43,172,28,221,195,29,123,52,171,120,39,122,188,53,195,77,112,180,175,73,186,119,112,239,228,118,193,245,8,111,199,247,131,222,1,158,78,133,25,196,65,11,0,56,203,112,108,103,194,244,231,4,50,2,187,125,150,47,184,21,168,77,96,112,130,134,142,46,102,102,151,128,158,74,196,166,80,174,82,104,246,185,66,120,118,103,52,24,67,180,248,51,62,3,165,74,249,172,76,181,123,24,238,131,250,118,187,143,215,16,254,63,58,221,189,225,156,198,163,100,75,195,219,132,1,76,194,178,193,125,177,131,66,239,201,108,234,160,235,68,117,94,181,79,64,202,228,154,147,148,169,61,51,90,24,15,192,212,141,137,87,195,201,86,249,104,15,63,175,4,33,199,57,245,141,102,59,246,57,48,174,196,117,156,69,138,91,177,228,128,181,231,5,199,39,207,137,85,124,53,27,59,236,206,67,140,157,43,34,208,127,192,35,240,50,243,127,30,224,199,91,17,61,100,254,95,127,30,180,2,75,71,203,102,181,204,49,97,224,26,79,11,98,227,111,66,230,99,247,72,110,70,211,17,111,248,57,135,66,215,6,20,83,74,160,61,148,182,116,33,70,58,179,57,113,48,79,165,101,68,163,71,230,58,249,217,250,58,204,23,165,117,94,63,95,26,88,41,107,222,200,220,197,106,98,97,37,25,14,232,173,11,41,31,138,213,185,200,160,53,167,153,37,243,49,237,219,202,96,9,184,134,14,187,244,179,89,108,110,193,244,6,206,109,77,56,81,167,29,117,217,126,155,97,35,127,220,130,232,102,226,40,233,20,21,64,106,186,57,241,12,122,96,231,129,154,220,232,45,94,139,73,117,148,190,167,48,194,49,113,191,62,96,47,86,199,215,161,161,132,53,250,240,106,46,2,90,227,71,187,229,237,24,72,90,83,135,227,229,230,241,14,179,170,201,169,141,247,70,14,105,174,214,229,221,151,43,60,208,187,104,193,175,35,211,208,245,198,176,7,47,202,74,50,125,2,228,87,149,76,181,220,176,169,179,135,87,150,129,174,225,247,222,180,64,185,51,80,115,109,54,196,198,22,112,184,97,76,110,47,107,251,149,61,137,124,209,246,191,237,24,88,20,230,209,130,249,87,167,69,190,152,0,199,121,249,141,140,113,76,112,186,18,116,55,91,249,138,63,151,29,213,119,235,166,136,212,104,182,83,55,213,19,118,254,252,59,124,97,173,121,172,247,100,117,191,124,223,59,11,71,189,157,156,243,150,59,139,223,51,162,239,236,253,86,167,187,33,219,248,179,249,186,138,191,81,200,46,204,223,123,119,41,156,237,28,175,183,41,148,44,46,42,32,223,90,121,222,142,58,149,227,74,39,225,187,198,45,49,222,191,141,176,187,77,56,158,32,185,42,120,29,41,116,176,1,42,198,111,215,23,208,161,75,131,18,43,246,54,92,217,55,219,133,206,155,249,214,80,99,222,215,179,123,231,249,102,199,145,69,159,8,255,107,51,75,99,104,248,3,67,139,86,134,151,201,66,226,183,127,73,227,157,152,177,92,167,2,88,153,101,184,93,100,200,33,196,124,167,111,124,185,137,141,137,103,205,135,165,204,77,179,19,249,255,141,131,211,14,223,150,153,175,201,14,235,131,150,145,213,152,178,222,144,44,120,169,144,255,63,93,190,99,186,216,8,252,57,9,83,74,235,78,153,198,253,9,173,54,22,27,191,117,216,4,103,189,191,120,168,144,94,227,98,202,158,22,34,225,4,217,61,62,109,165,229,151,242,87,44,208,2,180,126,127,176,73,45,118,192,106,42,118,254,238,128,110,182,187,46,140,68,186,0,185,121,44,163,253,122,88,55,162,186,9,218,235,31,100,99,122,253,165,57,30,192,12,140,170,95,62,255,23,132,212,191,120,22,206,215,169,77,241,195,214,251,151,254,196,234,115,182,146,185,238,60,54,217,96,105,54,155,225,252,196,9,39,9,80,111,38,135,12,26,64,30,46,193,66,108,1,32,205,52,148,192,127,115,75,110,108,34,90,251,106,147,37,93,37,2,107,255,6,90,255,10,170,253,37,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmptySettingsMessageLocalizableString());
			LocalizableStrings.Add(CreateAccessServerErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateConnectivityErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateUserInactiveErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmptySettingsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b5e8b8a9-4df3-43b5-8815-10027c29ed4d"),
				Name = "EmptySettingsMessage",
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8"),
				CreatedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572"),
				ModifiedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAccessServerErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b11e7c82-dec9-419c-91da-8f4e52414613"),
				Name = "AccessServerErrorMessage",
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8"),
				CreatedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572"),
				ModifiedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateConnectivityErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d3417878-4a5f-40ab-a5be-f8ccbd353cfa"),
				Name = "ConnectivityErrorMessage",
				CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8"),
				CreatedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572"),
				ModifiedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUserInactiveErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("566eced3-2ed3-2e4d-a05b-7f9f94dc0a97"),
				Name = "UserInactiveErrorMessage",
				CreatedInPackageId = new Guid("651868d2-0b85-4a6b-bc3a-32549eab2f65"),
				CreatedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572"),
				ModifiedInSchemaUId = new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9058b68-1667-44ce-a5ca-8ff753a9c572"));
		}

		#endregion

	}

	#endregion

}
