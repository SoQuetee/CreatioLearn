﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateUserTaskMessageProviderSchema

	/// <exclude/>
	public class EmailTemplateUserTaskMessageProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskMessageProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateUserTaskMessageProviderSchema(EmailTemplateUserTaskMessageProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc");
			Name = "EmailTemplateUserTaskMessageProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,89,89,111,220,54,16,126,222,2,253,15,204,38,8,36,212,144,219,62,250,74,29,123,19,44,106,55,169,237,182,47,69,11,90,226,174,217,234,50,73,185,222,38,249,239,29,94,226,33,173,178,13,130,62,244,33,129,69,206,12,103,190,57,56,195,173,113,69,120,139,115,130,110,8,99,152,55,43,145,157,53,140,100,111,89,147,19,206,225,163,94,209,117,199,176,160,77,253,229,23,239,190,252,98,214,113,90,175,209,245,134,11,82,29,70,223,64,95,150,36,151,196,60,123,77,106,194,104,62,160,185,160,245,253,96,241,134,60,138,236,138,172,187,18,179,197,99,203,224,112,41,196,209,249,10,86,85,83,143,239,120,218,126,148,192,26,121,78,56,93,131,170,227,12,0,198,162,22,84,80,178,69,25,32,120,133,115,209,48,77,1,52,109,119,91,210,28,229,37,230,28,45,42,76,203,27,82,181,37,22,228,39,78,216,13,230,127,94,194,177,120,77,64,129,7,90,16,134,14,208,75,204,137,209,71,113,68,20,32,245,157,146,61,123,202,200,26,148,71,96,10,23,184,22,252,0,189,101,244,1,132,235,253,253,253,125,116,196,187,170,194,108,115,98,23,148,72,36,140,22,136,72,131,54,136,231,119,164,194,168,134,32,200,122,214,125,159,183,213,146,81,46,15,67,92,48,105,252,239,196,55,233,90,9,249,1,100,160,99,52,15,172,157,31,78,168,116,131,215,104,213,48,180,38,66,72,169,36,84,177,3,164,144,0,168,80,137,235,117,7,80,32,42,8,56,174,97,159,174,171,133,255,194,136,92,26,137,82,151,88,121,75,59,105,4,56,65,128,239,63,25,201,92,243,135,24,26,161,246,224,167,164,46,180,207,71,2,128,117,50,242,100,12,168,152,211,20,38,254,118,137,188,100,148,72,161,47,255,72,165,184,217,1,186,133,232,76,250,69,36,203,192,236,195,180,122,112,66,75,152,76,155,72,57,3,196,165,116,130,52,21,130,81,231,207,70,227,225,190,15,183,226,126,217,149,130,246,129,97,184,208,74,179,109,243,128,70,101,236,220,145,53,201,161,204,156,65,128,162,227,147,88,55,244,226,5,74,226,181,99,84,147,191,198,164,37,18,89,88,170,117,109,76,83,101,218,140,143,139,62,70,15,184,236,200,225,14,40,95,18,113,215,20,113,13,176,24,171,194,181,209,209,245,99,71,64,244,107,34,2,143,27,53,23,252,62,121,221,209,162,207,191,101,97,188,60,123,192,12,85,184,6,156,25,40,22,218,145,249,7,92,106,162,195,158,139,240,123,131,200,64,143,196,72,220,139,43,134,1,6,88,179,211,162,128,219,164,171,234,100,254,178,41,54,91,182,174,187,219,63,64,25,187,43,207,5,235,193,233,244,21,45,133,210,89,114,156,49,2,226,245,210,47,84,220,189,197,12,178,13,62,120,162,23,225,82,105,129,137,55,245,205,166,133,146,127,223,225,18,180,91,22,243,61,31,20,167,131,102,227,82,151,36,56,209,208,208,21,210,201,101,147,42,187,6,31,106,107,225,4,116,124,140,18,90,139,52,88,205,78,59,209,88,228,213,49,192,125,90,84,180,190,162,235,59,193,193,154,21,46,185,14,13,25,27,240,63,35,162,99,181,180,210,15,24,27,2,23,148,139,35,115,177,104,7,244,166,159,200,104,24,223,226,137,239,126,136,53,242,104,92,121,37,255,78,190,155,255,118,69,114,218,82,136,157,95,139,175,158,249,240,195,213,221,66,105,34,134,97,74,129,196,176,121,151,159,38,89,148,164,146,25,109,75,142,94,5,137,33,162,160,127,64,159,4,81,160,228,57,147,32,85,240,178,94,53,32,37,18,139,57,90,190,221,70,238,188,57,33,17,76,237,202,178,119,156,113,137,69,194,247,214,56,18,174,109,66,109,47,30,20,221,122,100,246,170,97,57,145,254,243,92,118,104,226,161,199,223,201,202,126,185,35,140,36,45,148,27,171,34,248,49,91,242,75,44,242,187,164,205,228,229,147,162,231,207,245,110,2,43,231,88,224,159,101,29,82,129,185,228,23,77,243,103,215,2,9,106,161,81,91,129,184,58,55,183,63,122,162,1,232,249,103,3,146,76,223,110,199,35,119,94,138,222,191,71,79,182,29,152,166,217,77,35,131,72,217,231,71,124,0,111,20,246,183,77,83,202,98,117,78,86,24,238,138,51,248,215,49,98,203,76,98,238,95,238,233,224,135,187,137,108,233,129,169,20,113,161,225,88,178,211,122,163,96,158,178,40,138,19,184,197,131,24,145,74,148,81,139,162,85,137,27,151,196,179,224,112,192,43,245,119,154,233,35,161,10,201,72,75,98,187,100,245,239,109,83,58,167,134,65,71,78,47,103,89,72,227,252,79,112,190,228,206,22,85,43,54,105,120,76,196,230,153,240,114,211,87,144,254,92,159,124,111,0,65,106,101,159,67,52,208,58,23,46,226,21,140,189,217,208,148,119,178,24,72,205,190,25,139,14,117,213,125,28,129,100,220,243,46,173,172,35,27,117,7,201,108,149,45,207,70,49,143,21,171,72,188,147,19,216,161,110,226,52,16,54,101,196,36,160,138,40,64,117,25,199,208,16,103,99,85,4,171,221,206,188,51,185,239,177,20,238,68,198,197,27,102,146,46,233,57,149,239,189,175,48,98,198,140,27,106,57,26,253,58,141,237,96,0,109,124,156,203,93,208,175,156,178,117,167,238,21,125,53,121,29,180,221,73,230,33,7,220,254,81,235,166,93,117,38,103,59,211,175,101,55,108,3,218,37,145,26,123,168,233,196,14,112,239,233,168,30,215,212,171,49,195,138,16,221,58,210,94,87,15,118,177,213,81,131,157,49,138,250,228,217,240,88,83,226,3,8,192,254,163,129,169,39,201,220,132,2,136,31,106,150,142,116,49,241,105,83,129,111,100,247,167,22,65,211,82,132,187,87,93,105,59,146,243,225,78,220,159,7,249,56,34,201,207,1,56,119,36,152,103,179,97,35,238,41,29,95,72,81,243,13,105,106,58,243,107,0,161,159,112,212,71,148,158,254,150,84,43,241,165,140,163,148,202,225,37,230,179,73,27,55,187,187,15,32,141,0,244,72,97,157,101,62,81,243,64,24,131,89,19,217,116,149,221,252,158,29,129,77,255,158,246,147,137,177,187,247,165,129,206,60,89,232,144,119,73,17,205,35,32,100,201,95,65,171,15,216,46,106,124,91,146,34,25,31,235,213,4,105,65,249,249,219,185,187,148,251,147,64,88,64,213,59,43,172,235,129,120,3,186,253,188,114,213,49,73,77,162,207,118,126,147,176,9,130,8,180,252,126,150,91,31,45,212,132,53,49,211,77,106,106,51,188,55,216,19,43,145,212,200,187,214,52,78,146,236,26,28,88,18,87,239,211,184,137,177,2,141,147,225,8,237,117,157,43,174,97,185,133,136,24,221,148,46,54,234,61,137,170,221,174,222,7,154,75,156,179,134,195,160,70,37,25,46,93,15,231,185,125,22,98,165,121,22,143,128,100,65,10,247,152,145,93,120,151,154,137,74,121,176,236,240,204,80,170,110,236,35,153,209,80,0,29,185,157,145,12,62,51,99,244,132,8,141,199,73,56,255,206,134,160,238,34,34,154,147,195,152,18,119,172,249,75,213,198,211,182,45,105,174,158,71,23,143,57,105,149,223,159,205,47,154,28,151,244,111,9,169,123,162,171,27,129,86,208,105,21,234,29,15,26,129,134,21,232,221,100,200,125,152,7,49,98,106,64,63,142,245,22,217,144,54,43,254,92,199,227,88,90,242,31,32,46,222,48,21,54,73,36,11,74,221,32,10,15,226,3,195,238,235,86,151,39,195,239,215,192,209,167,168,43,197,198,93,147,133,160,214,129,67,86,20,58,197,21,107,170,173,47,155,91,222,169,212,138,86,134,159,92,253,123,169,71,251,150,57,172,195,15,148,137,14,151,253,245,57,90,163,62,105,234,255,159,142,239,238,86,255,111,7,120,165,172,39,196,204,214,48,36,123,243,188,26,113,228,222,215,187,169,13,41,74,112,126,135,62,58,211,32,234,155,16,148,219,232,205,192,18,245,111,7,142,111,251,227,129,125,31,232,41,183,63,37,160,173,68,147,143,9,182,158,127,166,161,236,163,99,153,69,56,232,99,35,39,76,21,16,80,129,163,74,54,26,238,167,142,232,151,154,169,74,161,244,85,191,60,28,207,93,239,54,63,177,233,109,11,179,171,31,80,33,20,211,184,12,77,46,37,152,206,235,95,242,123,51,197,137,252,93,69,174,34,209,200,223,121,16,174,221,143,56,3,33,182,106,93,78,67,177,173,188,185,22,123,188,105,27,116,216,118,52,86,214,246,253,232,248,147,144,105,150,191,167,242,222,25,121,223,151,113,116,214,211,120,175,50,123,91,127,45,251,124,207,196,78,185,204,31,26,118,120,58,86,175,100,149,15,151,105,155,236,144,247,100,151,14,235,156,114,249,215,40,236,102,206,57,107,24,32,13,90,205,195,209,106,244,108,200,252,137,151,59,7,160,86,241,197,196,84,229,187,123,11,74,70,202,129,191,239,156,25,72,176,177,18,61,88,12,230,28,19,73,182,135,145,205,91,50,18,76,94,155,211,207,60,1,56,134,46,147,2,38,70,49,181,10,255,253,3,220,228,187,110,204,31,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDefaultEmailSubjectLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDefaultEmailSubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b78329ef-0d4b-4d4f-8ce4-0a08ce3b73df"),
				Name = "DefaultEmailSubject",
				CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6"),
				CreatedInSchemaUId = new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc"),
				ModifiedInSchemaUId = new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5fa2bb49-a5ab-417b-bd90-631fe2e088fc"));
		}

		#endregion

	}

	#endregion

}

