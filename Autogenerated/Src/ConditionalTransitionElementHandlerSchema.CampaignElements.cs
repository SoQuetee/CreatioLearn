﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConditionalTransitionElementHandlerSchema

	/// <exclude/>
	public class ConditionalTransitionElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConditionalTransitionElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConditionalTransitionElementHandlerSchema(ConditionalTransitionElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2af9086c-4bf0-45a0-926a-77e05a3df84d");
			Name = "ConditionalTransitionElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,89,109,111,219,182,22,254,156,1,251,15,156,7,108,10,96,168,235,62,13,235,146,33,113,236,214,88,154,14,181,115,239,135,98,184,96,36,218,33,42,81,46,73,37,241,186,252,247,123,248,38,145,50,229,151,54,183,5,46,80,32,53,121,222,121,206,195,163,67,134,75,34,86,56,35,104,78,56,199,162,90,200,116,84,177,5,93,214,28,75,90,177,111,191,249,248,237,55,71,181,160,108,137,102,107,33,73,249,162,243,27,232,139,130,100,138,88,164,47,9,35,156,102,27,52,23,88,226,141,197,75,202,62,108,44,206,201,131,108,23,125,171,202,178,98,241,29,78,250,214,211,51,41,57,189,169,37,17,189,36,35,92,174,48,93,246,202,110,8,210,241,29,97,242,21,102,121,65,120,47,245,197,57,108,193,230,247,156,44,33,38,104,84,96,33,126,69,16,213,156,170,32,225,98,206,49,19,250,255,227,130,148,173,72,205,246,236,217,51,244,155,168,203,18,243,245,169,253,173,69,32,89,161,91,77,136,50,107,16,34,202,32,129,64,11,46,10,148,181,42,144,108,116,32,98,148,0,217,162,229,20,217,45,41,113,234,20,62,243,52,174,234,155,130,102,72,16,92,144,28,101,90,247,30,214,35,240,209,74,247,227,116,142,5,25,162,233,27,230,54,207,201,2,194,52,195,119,225,242,168,90,173,65,249,71,29,132,54,120,144,84,18,131,241,191,162,63,181,89,102,187,27,36,189,112,5,185,172,125,172,57,7,253,145,16,216,248,241,180,145,225,251,237,28,207,148,78,36,32,111,212,225,246,120,171,149,157,160,65,223,254,224,133,117,132,176,220,248,18,58,246,154,200,219,42,87,110,113,122,135,37,49,187,43,243,3,77,199,172,46,9,199,55,5,249,237,101,77,243,83,244,146,200,241,3,21,18,108,154,84,69,78,248,52,23,201,38,217,194,237,29,35,85,183,71,71,119,152,35,98,25,167,80,95,2,140,102,228,30,93,194,146,225,73,142,95,104,74,186,64,73,195,142,78,128,172,134,156,250,231,159,86,102,58,21,227,114,37,215,201,177,147,126,196,137,172,57,11,53,24,113,143,129,122,218,236,206,136,2,11,107,133,249,145,92,11,194,225,164,153,65,145,99,35,90,225,74,93,178,100,48,205,7,110,105,194,171,50,25,0,169,196,153,52,113,104,246,254,125,75,56,233,110,14,145,199,126,148,78,89,98,164,166,127,98,14,39,40,9,23,173,211,224,22,22,214,38,227,68,204,244,116,182,34,25,93,172,175,170,203,42,123,255,138,66,114,186,16,70,201,199,15,36,3,252,121,75,48,104,73,184,254,131,78,78,195,152,165,103,121,110,247,0,67,165,49,242,95,184,168,237,193,154,40,28,91,61,189,81,127,12,211,232,174,162,57,154,50,136,174,12,194,18,102,206,188,94,217,252,25,162,155,181,36,239,254,58,61,69,57,0,246,188,50,188,67,164,54,27,236,152,230,238,248,85,33,227,236,22,37,234,152,21,7,162,44,224,108,242,36,98,68,162,8,135,190,84,47,113,246,116,36,137,216,142,140,220,30,147,149,165,230,192,109,5,155,58,79,39,21,47,177,76,6,31,127,122,252,207,199,231,143,3,223,176,161,22,153,170,48,63,183,70,170,228,53,246,244,36,239,148,201,170,47,83,103,68,234,243,28,162,110,50,38,158,162,128,90,25,27,163,111,93,9,233,71,112,48,146,228,231,235,184,154,208,230,116,100,16,83,173,166,214,100,136,88,32,240,117,149,211,5,125,74,137,38,40,243,245,138,196,37,190,198,252,61,81,233,173,239,0,145,182,244,23,107,134,75,154,117,5,2,43,168,220,79,152,187,117,38,180,80,24,16,156,83,87,238,140,96,158,221,170,14,102,235,137,253,220,112,217,138,183,168,16,75,229,11,128,6,73,182,212,100,15,154,171,180,51,188,61,105,247,191,6,200,189,61,188,94,65,96,182,121,184,5,117,12,239,30,32,19,18,234,232,152,165,78,116,192,201,104,72,32,38,84,222,26,8,87,204,111,171,123,135,233,201,113,67,243,228,249,223,17,249,134,197,4,66,190,145,57,45,73,122,45,179,171,234,190,195,123,104,78,110,63,125,117,177,127,168,113,177,113,246,17,60,234,30,126,63,94,159,101,18,100,210,191,187,89,224,206,75,53,28,174,14,103,186,29,117,93,71,167,189,232,54,20,109,99,39,84,190,59,94,20,10,75,39,69,117,111,155,50,17,148,192,131,186,126,31,82,187,167,16,37,125,133,197,164,192,203,142,61,62,69,219,232,185,64,252,240,3,122,64,52,232,141,103,228,67,77,88,70,60,213,45,49,232,197,187,168,143,83,131,72,211,28,125,119,162,239,176,84,183,92,135,74,81,254,104,65,135,50,78,45,223,8,90,229,37,201,91,32,212,141,154,137,220,30,114,204,145,109,34,26,205,195,35,139,30,101,168,173,137,200,54,161,14,11,64,100,180,83,14,244,110,23,100,174,117,16,20,240,64,214,103,100,37,19,79,151,21,227,96,201,227,140,122,181,153,130,158,58,3,18,148,137,196,243,55,22,124,5,83,17,232,244,216,134,104,204,50,128,22,104,106,174,231,147,95,84,59,121,14,68,173,100,244,251,239,104,208,54,147,173,253,77,8,15,177,223,48,125,69,251,163,55,77,112,63,216,227,142,245,193,97,155,219,1,144,49,147,84,174,93,226,197,32,238,45,41,171,59,114,205,106,65,242,131,81,206,150,38,124,97,117,244,78,25,196,30,234,234,19,168,3,208,219,3,78,55,107,0,107,212,158,180,31,130,134,117,39,182,62,49,184,238,137,174,222,173,216,230,216,97,64,219,139,6,77,219,51,175,76,207,213,19,139,254,3,248,154,145,241,168,15,139,7,92,1,87,149,116,31,250,79,16,223,182,111,208,8,218,73,176,216,244,193,5,60,61,99,254,176,33,218,53,111,48,109,105,75,46,168,238,206,48,95,119,62,25,189,59,163,237,172,62,103,188,210,167,233,11,13,91,158,98,214,226,150,188,86,243,235,142,97,14,155,194,108,27,194,184,112,186,81,140,141,239,145,158,25,192,191,19,180,115,20,243,194,178,152,115,85,195,82,27,164,62,230,48,144,202,67,195,234,4,109,142,131,84,218,180,114,157,198,199,3,103,64,218,39,51,14,8,71,39,27,150,111,142,72,166,42,20,186,9,189,34,247,234,111,210,223,243,244,93,236,78,82,196,151,190,161,208,158,23,178,11,129,211,208,123,75,27,239,207,88,126,78,89,247,154,246,107,124,59,162,157,250,109,145,139,213,22,136,8,251,168,237,61,109,47,48,145,160,147,21,97,123,235,65,213,162,3,167,193,71,179,55,8,135,79,103,223,40,239,98,234,104,74,255,32,107,17,239,234,26,60,138,229,126,71,204,187,86,91,35,193,165,188,206,76,99,184,26,254,235,100,139,37,234,102,13,68,132,2,175,47,106,147,176,243,97,163,232,113,33,200,142,111,216,81,1,202,237,144,232,115,115,197,15,252,164,226,99,56,159,68,122,240,35,125,103,114,178,192,117,33,19,21,164,198,237,29,78,244,247,169,163,162,98,196,185,225,119,166,157,177,5,36,23,168,128,35,168,57,25,51,229,104,14,80,110,139,240,172,206,169,242,115,90,174,42,46,7,221,123,201,191,137,62,233,211,254,19,195,251,255,253,225,255,121,31,224,157,105,137,154,118,217,44,232,160,147,137,143,206,70,217,14,15,172,148,109,248,25,151,222,175,190,170,229,78,11,190,139,152,224,215,97,175,200,160,0,118,191,188,237,122,80,108,6,88,194,179,244,71,97,134,144,55,250,25,19,9,124,167,158,9,35,239,170,145,7,198,119,111,184,2,180,231,199,127,233,10,53,207,141,186,64,223,120,207,162,73,11,24,107,87,45,79,86,171,65,221,217,194,59,234,157,212,89,178,109,159,185,182,130,33,2,82,221,55,166,201,215,111,174,15,141,82,251,150,90,18,33,240,210,206,104,46,179,191,103,122,217,116,71,219,222,89,161,123,244,227,211,168,104,186,48,231,245,101,181,92,66,227,53,230,188,226,246,65,199,234,28,130,57,187,218,137,35,121,203,171,251,205,11,33,154,27,166,38,4,202,224,186,81,143,206,94,78,254,104,18,4,236,71,5,101,239,5,162,82,189,221,251,201,190,53,61,126,142,165,135,186,214,98,137,17,34,251,151,58,12,101,205,151,62,134,78,61,155,213,112,17,214,254,11,122,207,103,7,209,34,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOnCopyExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOnCopyExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8bf5e243-9892-4fc1-9e2b-141cb6d52222"),
				Name = "OnCopyException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("2af9086c-4bf0-45a0-926a-77e05a3df84d"),
				ModifiedInSchemaUId = new Guid("2af9086c-4bf0-45a0-926a-77e05a3df84d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2af9086c-4bf0-45a0-926a-77e05a3df84d"));
		}

		#endregion

	}

	#endregion

}
