﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthClientAppListenerSchema

	/// <exclude/>
	public class OAuthClientAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthClientAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthClientAppListenerSchema(OAuthClientAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3");
			Name = "OAuthClientAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,88,91,111,219,54,20,126,118,129,254,7,194,123,145,1,67,233,246,152,196,6,92,39,237,12,52,77,23,59,235,67,209,7,70,58,182,185,201,148,67,82,110,211,192,255,125,135,55,137,146,101,199,233,208,109,192,158,28,145,231,206,239,124,60,12,167,43,144,107,154,0,153,129,16,84,230,115,21,143,115,62,103,139,66,80,197,114,30,95,143,10,181,252,229,213,203,23,143,47,95,116,10,201,248,130,76,31,164,130,213,89,227,27,245,178,12,18,173,36,227,183,192,65,176,164,146,9,205,175,86,57,111,223,17,176,111,61,190,228,138,41,6,242,73,129,248,114,3,92,181,202,153,92,38,92,193,194,37,119,49,187,62,74,238,242,107,2,107,253,23,74,163,252,79,2,22,248,65,198,25,149,242,148,24,241,113,198,208,237,104,189,126,199,176,26,152,189,145,252,100,162,122,48,33,249,141,104,154,44,97,69,223,99,233,201,128,116,235,218,221,222,103,84,91,23,119,25,75,72,162,237,239,49,79,78,201,107,42,193,108,142,214,108,76,177,248,232,179,243,104,252,86,33,226,105,40,81,36,42,23,24,233,7,99,215,74,56,31,237,214,163,30,218,191,67,251,17,135,47,228,130,153,99,165,226,225,124,246,176,134,62,65,147,88,177,33,74,105,84,116,58,143,68,225,122,62,143,48,146,41,136,13,136,178,98,189,62,233,190,203,19,154,177,111,244,46,131,169,209,148,113,233,17,99,48,53,254,149,242,52,195,173,75,33,114,113,5,82,210,5,196,191,211,172,128,46,217,246,247,120,193,236,184,134,220,70,215,248,41,143,78,54,231,173,46,180,135,45,230,179,117,245,3,158,218,18,214,235,121,5,106,153,167,186,148,130,109,168,2,87,75,251,65,202,172,38,124,158,223,192,125,1,82,145,183,160,106,235,111,68,190,178,176,136,236,15,1,243,227,139,185,161,2,79,94,43,56,136,216,109,236,41,165,171,159,98,159,21,43,110,226,62,247,7,209,213,162,221,222,89,105,64,64,202,4,166,123,43,178,35,45,220,84,26,161,33,90,29,209,241,182,70,53,165,208,156,77,108,146,30,105,104,236,196,67,19,210,208,205,173,4,113,180,153,105,160,18,154,98,114,164,209,243,68,145,239,242,60,67,35,19,39,188,155,206,5,200,68,48,3,190,35,3,10,52,118,205,85,248,65,107,186,255,90,97,101,193,210,25,87,5,245,181,237,187,157,66,170,124,229,170,84,1,170,31,234,161,77,7,178,253,2,245,236,118,50,110,138,223,10,134,98,117,216,56,153,75,174,27,82,135,227,11,239,54,166,245,35,13,79,216,73,84,232,100,210,86,229,211,103,242,88,131,185,105,225,206,214,86,83,128,42,4,223,41,168,217,220,214,155,118,147,179,148,140,5,224,223,134,12,111,64,230,133,72,96,194,109,78,209,219,2,5,42,75,105,159,152,21,225,229,112,65,199,90,17,12,41,106,159,97,99,139,134,113,119,194,237,142,27,102,124,102,117,169,120,10,120,28,243,0,102,50,218,39,26,144,125,128,10,147,212,33,141,50,48,173,83,165,189,47,30,186,1,23,65,163,210,166,108,216,23,198,40,198,76,139,76,85,182,163,163,139,8,210,119,134,37,80,123,161,254,86,128,120,104,212,44,14,5,174,40,71,198,23,125,119,231,122,207,190,1,119,108,217,146,146,196,252,88,174,145,247,241,40,117,45,141,140,80,146,201,100,71,249,13,203,20,226,23,113,140,96,119,185,218,53,50,176,144,214,198,44,236,236,250,71,166,150,31,168,192,14,196,15,25,217,69,156,150,214,20,49,159,115,77,38,241,229,125,65,51,76,96,226,77,118,251,4,175,119,112,97,104,147,86,79,234,56,163,134,231,90,162,213,184,230,24,43,88,176,153,226,73,53,69,219,33,201,230,36,106,218,192,251,182,208,240,30,144,159,253,209,249,166,108,138,126,122,245,185,149,45,53,92,134,145,47,127,172,185,201,57,220,18,200,36,144,3,126,135,129,91,203,186,100,101,111,124,135,156,157,9,161,137,28,15,143,41,142,78,168,214,111,78,106,126,84,234,58,134,234,180,13,29,87,56,153,206,150,148,95,115,104,224,189,62,127,184,188,58,106,41,242,47,21,35,148,206,202,225,38,114,89,212,11,241,239,39,250,62,255,49,249,5,44,114,196,72,150,43,204,9,82,207,58,238,147,228,56,42,10,150,58,170,159,233,24,42,135,174,104,96,134,66,185,232,145,193,144,60,29,102,41,126,118,108,112,193,232,125,114,114,66,206,101,177,90,225,68,61,244,11,102,0,6,233,186,131,104,22,77,9,232,135,67,92,234,156,52,149,206,215,154,48,8,199,214,24,116,37,198,128,199,52,52,175,13,98,191,226,243,19,35,210,174,1,221,225,108,9,24,11,0,73,4,204,7,221,217,233,222,103,149,137,107,52,71,30,49,14,70,98,33,187,228,100,72,24,190,48,40,199,39,100,146,115,69,25,215,213,84,75,240,14,77,10,36,165,138,214,98,113,207,143,250,209,92,243,9,71,112,42,141,210,252,238,15,60,61,151,70,223,49,253,107,152,99,80,165,127,2,190,201,199,75,72,254,28,83,110,57,126,138,156,97,15,215,104,7,19,150,171,238,128,184,217,187,103,37,172,192,254,171,201,205,116,183,109,236,167,159,73,113,24,185,15,217,131,184,54,190,85,119,46,154,95,227,235,204,244,105,145,101,45,178,126,212,11,84,236,194,224,208,163,194,189,38,28,215,127,133,164,80,224,94,136,81,100,224,221,22,194,36,181,122,250,97,197,18,248,40,112,130,67,248,232,219,206,14,35,205,32,240,153,213,90,149,42,111,183,141,243,73,192,234,193,76,223,223,13,36,246,155,199,152,152,2,98,86,181,154,177,91,245,33,228,16,224,32,109,199,91,29,238,21,220,106,103,142,202,205,35,127,26,106,141,153,178,122,55,224,195,82,183,120,144,111,160,33,194,73,236,251,224,122,104,210,173,13,185,225,124,123,192,224,182,133,211,26,92,118,187,198,246,55,36,107,232,236,63,64,99,13,30,57,196,99,207,36,48,159,235,15,224,47,7,186,210,195,179,65,247,143,144,203,30,34,49,81,195,247,114,73,27,200,246,92,156,23,144,129,250,63,94,157,38,241,31,138,188,210,195,179,145,231,134,172,191,249,223,159,231,224,237,6,86,88,160,26,222,240,86,57,18,103,141,105,206,174,214,23,183,127,1,33,231,103,105,59,23,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateClientApplicationHandlingErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateConnectionErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateNoDefaultResourceMessageLocalizableString());
			LocalizableStrings.Add(CreateMoreThanOneDefaultResourceMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateClientApplicationHandlingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2cf8bb31-6290-cc97-742e-64fed171040b"),
				Name = "ClientApplicationHandlingErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateConnectionErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3fb4a54a-87f4-40b3-82c2-9d506b6413b6"),
				Name = "ConnectionErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoDefaultResourceMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("645c2e6f-5960-4a83-98b7-9400582df07a"),
				Name = "NoDefaultResourceMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMoreThanOneDefaultResourceMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c3610e85-9aca-45f0-b034-d6dfbee46312"),
				Name = "MoreThanOneDefaultResourceMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"));
		}

		#endregion

	}

	#endregion

}

