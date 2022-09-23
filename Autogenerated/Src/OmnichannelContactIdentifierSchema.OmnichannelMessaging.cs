﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelContactIdentifierSchema

	/// <exclude/>
	public class OmnichannelContactIdentifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelContactIdentifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelContactIdentifierSchema(OmnichannelContactIdentifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74");
			Name = "OmnichannelContactIdentifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,90,91,111,220,184,21,126,158,5,246,63,48,218,98,171,193,78,229,182,143,182,199,129,175,193,180,177,227,198,73,243,80,20,129,44,113,198,68,116,153,136,146,147,105,214,255,189,231,240,34,145,20,37,141,55,219,135,46,144,245,72,34,15,15,207,229,59,23,178,136,115,202,183,113,66,201,59,90,85,49,47,215,117,116,94,22,107,182,105,170,184,102,101,17,189,201,11,150,60,196,69,65,179,232,154,114,30,111,88,177,249,241,135,111,63,254,48,107,56,252,36,155,172,188,143,179,195,195,243,50,207,97,252,235,114,131,35,142,218,239,6,129,118,190,247,235,109,85,62,178,148,86,60,186,40,243,152,21,209,101,81,179,154,81,62,49,122,85,212,180,90,195,30,140,129,119,59,94,211,220,125,134,173,101,25,77,112,95,28,183,153,52,85,69,139,122,116,216,43,90,208,138,37,189,49,175,89,241,185,123,105,74,15,197,224,255,82,209,161,247,209,197,217,224,167,190,24,156,1,119,181,164,12,223,127,170,232,6,216,38,231,89,204,249,161,41,47,216,110,29,39,245,42,133,13,179,53,163,149,24,127,112,112,64,142,121,147,231,113,181,59,81,207,98,46,169,31,226,154,48,61,154,147,68,206,39,247,59,2,38,195,105,177,161,85,247,189,138,52,177,3,131,218,182,185,207,88,66,18,65,112,156,151,25,26,84,199,62,72,190,142,139,26,182,112,43,104,8,102,53,61,248,84,139,63,21,10,67,17,227,103,187,142,222,121,156,60,208,191,211,29,89,146,160,191,46,12,61,151,47,78,139,180,155,20,72,17,206,126,162,69,42,249,80,207,138,41,176,184,45,173,80,19,192,85,197,30,227,154,42,182,228,3,169,104,156,150,69,182,211,156,125,44,232,23,181,228,13,248,25,50,115,99,189,121,93,38,113,198,254,19,223,103,244,78,76,209,44,116,182,121,193,132,29,130,64,143,37,213,5,121,213,176,244,132,124,76,70,55,115,100,50,182,7,185,113,209,16,161,157,217,134,214,82,79,240,223,196,250,176,217,169,17,47,95,146,247,28,116,85,194,39,193,85,116,186,221,130,126,5,238,8,13,170,165,102,224,132,245,63,227,172,161,199,211,59,57,9,199,12,98,126,164,104,178,53,9,39,183,176,36,69,147,101,115,162,247,60,91,21,224,137,168,50,234,91,36,108,169,63,201,191,21,173,155,170,216,75,85,114,202,211,128,65,73,224,164,31,202,234,19,173,174,128,84,9,219,94,129,65,174,89,70,47,226,58,214,104,8,118,177,237,191,85,51,142,188,180,21,149,85,14,11,188,46,99,24,222,210,48,222,61,203,55,202,26,20,74,83,57,196,133,24,241,2,21,143,144,162,53,223,14,52,225,3,120,85,148,28,67,113,30,103,173,117,30,25,66,244,174,123,204,41,37,73,69,215,203,96,5,145,42,56,56,33,44,223,102,52,7,101,8,187,35,76,32,79,66,7,89,146,226,83,24,132,68,200,199,172,220,28,217,252,154,159,241,95,203,161,182,37,109,26,48,21,29,33,20,63,150,56,246,58,46,64,234,21,218,60,198,82,48,43,15,132,25,168,53,159,247,13,104,72,77,2,87,171,6,173,193,129,86,175,180,58,115,231,36,38,128,102,173,116,72,185,134,8,65,77,121,142,50,9,114,22,81,160,147,234,54,174,226,156,20,128,130,203,160,177,212,25,156,172,134,87,177,53,15,116,163,227,3,65,234,100,64,95,50,100,140,49,23,58,198,101,115,163,189,223,25,180,116,134,73,29,140,56,31,204,64,1,238,239,201,161,195,135,189,130,233,174,146,114,223,143,157,141,205,143,246,176,144,107,90,63,148,233,80,132,123,44,89,74,166,64,80,9,108,58,64,32,215,211,128,174,81,117,175,88,17,221,209,250,77,245,150,230,229,35,21,17,99,52,26,44,166,160,185,21,217,108,102,138,1,249,34,224,159,183,15,101,93,174,210,208,80,159,206,147,240,247,66,39,2,73,23,242,181,116,30,227,138,108,229,116,144,4,18,140,46,243,109,45,49,90,68,39,131,208,203,72,173,32,22,36,47,156,184,212,209,241,88,71,116,23,63,202,103,147,162,69,112,97,49,168,208,132,208,140,83,130,140,188,144,187,136,86,252,6,86,125,83,9,62,135,217,123,95,101,243,61,89,67,17,26,51,87,233,217,14,102,15,242,9,223,188,172,138,255,43,64,85,11,154,166,110,25,239,5,205,104,77,207,33,250,1,76,43,219,8,133,62,19,141,11,154,121,52,79,57,220,117,36,101,107,87,85,153,135,129,34,18,232,183,31,30,104,69,195,96,149,6,115,16,217,229,231,38,206,192,8,179,38,47,162,91,4,42,160,87,133,221,98,122,218,229,87,154,52,176,212,124,144,117,64,69,8,177,210,56,235,157,134,177,98,93,58,252,47,72,91,103,41,180,17,25,59,252,213,59,19,21,197,174,155,33,41,130,146,28,31,147,227,238,192,89,242,88,133,37,197,45,104,78,131,244,217,14,117,209,202,65,83,107,229,33,101,45,73,121,17,105,230,240,129,62,44,5,38,61,184,163,28,44,12,45,237,57,87,122,117,203,213,66,203,2,70,22,96,131,171,245,101,242,80,62,151,152,65,166,125,183,39,141,21,127,213,80,94,163,32,12,42,198,219,33,58,224,198,225,58,6,167,84,3,32,57,136,46,232,125,179,185,42,171,60,174,123,10,32,95,98,142,65,19,13,253,144,180,31,151,223,254,252,180,32,142,88,150,223,254,242,180,8,200,47,82,101,65,247,121,249,237,175,79,166,212,253,226,27,148,134,99,198,10,14,95,161,72,90,47,14,53,72,202,169,248,202,5,78,3,144,103,42,217,83,238,174,160,73,139,0,246,70,66,216,11,249,19,1,198,231,192,57,58,113,175,204,114,204,48,194,104,44,186,32,209,91,202,203,166,74,40,150,212,176,159,133,18,200,104,110,179,32,65,111,5,30,129,52,123,5,224,47,36,136,132,25,0,52,188,43,21,47,243,5,145,171,88,2,232,239,220,39,80,29,136,46,191,50,94,3,49,13,104,83,0,96,3,6,6,160,86,37,109,32,212,182,17,170,185,11,82,54,80,254,151,101,70,24,191,161,52,125,87,74,215,118,236,110,222,11,97,184,194,146,164,116,29,55,153,4,219,57,249,249,231,206,102,236,173,202,152,222,11,114,67,220,218,211,194,81,162,186,62,27,229,31,232,67,138,76,205,216,98,239,229,69,187,23,220,197,184,44,52,247,195,216,221,119,45,95,88,107,71,141,89,193,160,6,135,204,193,80,233,138,59,172,183,84,132,109,113,51,111,161,252,179,202,222,204,0,241,143,134,86,46,192,251,34,8,184,75,47,84,104,49,193,236,211,52,103,197,91,182,121,168,57,44,34,0,79,138,67,74,5,214,134,156,128,97,126,47,22,84,145,117,197,79,179,47,241,142,223,81,108,220,89,42,196,25,167,105,42,7,26,225,218,255,85,238,217,252,122,197,178,26,219,140,48,42,196,103,169,104,249,246,3,171,31,218,160,206,67,249,242,188,204,161,34,97,188,44,222,237,182,52,18,25,128,6,146,61,195,145,90,30,133,173,52,223,181,36,97,115,200,6,122,189,50,38,253,197,31,93,13,34,157,253,25,196,122,11,168,12,38,100,53,205,231,100,9,21,50,246,59,97,61,220,78,106,4,179,99,153,159,27,97,209,132,53,244,249,161,32,57,101,109,29,91,125,150,49,169,18,25,168,162,101,123,136,49,238,180,128,49,228,165,231,203,21,171,120,29,206,71,247,212,230,28,115,114,104,99,215,94,46,232,192,146,81,220,120,145,9,217,208,81,239,164,109,171,42,212,26,2,237,62,87,2,169,236,217,209,187,106,167,219,103,225,224,218,17,36,216,133,194,3,21,123,183,248,230,166,201,239,33,246,168,8,53,3,188,51,94,99,69,80,214,102,81,48,159,132,235,219,110,122,104,174,160,145,121,0,105,229,30,187,78,156,23,22,53,102,126,7,114,154,236,249,228,96,37,31,106,214,251,154,101,162,65,31,117,148,184,34,229,184,228,194,162,38,237,240,77,117,161,246,56,156,250,223,54,252,161,213,29,196,26,172,95,219,188,169,45,102,157,50,70,101,74,227,157,221,127,233,233,255,54,125,238,127,88,113,143,179,227,21,129,8,80,210,140,91,33,96,237,53,32,6,180,97,191,40,108,189,13,176,96,57,140,77,213,41,62,122,125,1,161,171,247,219,20,126,139,116,254,186,76,233,64,113,137,168,220,136,145,42,148,202,105,61,123,25,44,171,64,236,110,49,209,171,50,49,8,206,231,178,117,109,87,167,6,188,185,69,170,232,17,154,5,42,129,58,66,114,39,205,66,178,237,47,88,247,104,43,89,205,225,174,99,250,200,170,26,184,32,102,47,165,83,56,62,14,103,181,74,189,8,30,123,37,149,29,154,141,14,223,19,58,101,194,110,32,39,54,53,231,221,26,248,56,6,149,202,42,141,30,158,216,109,7,118,2,68,189,117,151,26,32,112,68,29,49,225,106,10,12,221,20,214,87,108,186,76,0,135,230,52,209,166,82,29,73,163,137,227,233,111,34,248,201,174,230,217,238,90,31,16,134,78,2,96,116,109,116,191,70,81,49,122,65,72,28,224,83,181,139,210,240,183,84,156,211,118,216,63,86,20,142,42,179,187,238,152,110,210,232,140,244,74,216,236,210,181,90,59,171,119,58,123,189,50,167,87,213,191,42,91,220,33,224,119,241,33,89,163,182,63,138,206,185,168,229,89,106,151,239,80,191,111,33,221,104,42,250,177,169,50,187,130,23,61,181,214,92,236,215,88,130,140,180,222,236,198,224,16,187,55,165,197,45,89,151,77,145,6,86,73,99,214,4,122,176,122,218,167,3,53,210,123,210,235,216,253,173,46,176,73,58,123,116,164,172,156,89,247,103,193,40,240,111,104,55,104,16,136,33,128,27,41,36,247,140,176,91,64,190,70,214,222,224,53,89,58,255,46,25,223,111,77,248,122,155,189,46,239,165,17,21,52,176,211,31,23,103,140,206,46,136,220,239,37,192,79,232,53,101,15,107,228,215,95,45,123,126,29,15,14,133,50,193,218,133,77,27,251,54,4,251,57,62,106,80,29,56,253,44,15,230,141,118,29,157,163,128,238,88,193,58,74,232,247,189,209,98,244,188,23,230,25,194,164,78,212,2,82,31,248,203,210,197,208,44,92,58,240,49,210,78,240,181,40,177,201,225,116,40,201,23,40,155,137,16,30,54,236,226,34,37,176,5,108,219,25,45,75,123,165,190,191,212,213,238,123,154,43,144,47,214,201,3,9,47,191,38,116,43,220,171,109,142,205,188,103,4,238,250,110,133,227,182,224,158,211,204,145,217,153,247,8,86,114,193,137,229,199,216,220,69,17,174,179,120,67,88,23,205,85,223,163,37,102,158,177,42,126,240,112,53,41,115,116,119,109,146,123,29,160,138,212,86,50,35,150,115,248,249,158,142,99,23,226,245,73,159,147,65,187,162,215,102,21,254,33,0,27,37,27,28,72,114,24,73,234,82,8,0,162,78,11,39,228,91,59,253,41,176,114,4,175,188,129,173,238,174,211,35,139,9,131,231,161,11,79,35,82,214,98,88,67,157,162,233,245,37,45,13,130,159,104,199,48,200,31,31,232,143,163,122,113,42,88,144,229,84,194,98,183,214,37,30,13,228,151,254,96,232,105,59,136,33,221,157,171,94,110,214,97,167,36,63,112,130,129,185,142,154,75,182,109,91,237,144,200,73,206,201,133,147,244,96,218,115,39,122,247,118,198,35,231,122,242,69,3,147,197,52,3,85,253,39,158,253,140,19,195,209,139,193,194,116,168,118,212,138,120,30,130,76,52,212,187,106,97,20,116,149,186,17,118,1,107,139,63,214,42,65,155,22,87,123,183,201,228,186,151,45,59,60,171,123,80,222,246,69,39,30,215,191,251,41,230,224,126,48,110,200,189,200,141,16,86,72,67,196,123,138,159,192,24,193,72,236,243,171,196,190,9,54,221,43,154,134,137,148,241,109,22,239,200,35,198,201,22,52,68,28,99,165,23,50,14,122,247,146,76,16,105,217,8,252,192,48,1,34,22,59,14,142,180,55,40,157,131,184,11,57,71,70,122,127,199,226,255,32,109,183,213,24,93,81,8,241,234,176,64,88,16,184,230,197,89,104,83,85,223,101,166,99,218,98,215,57,214,99,148,144,140,164,8,146,63,5,21,221,229,141,49,179,145,109,178,206,114,152,14,231,50,76,160,105,238,107,36,108,79,235,24,187,103,229,222,194,51,39,219,119,109,69,248,151,220,235,144,223,1,157,176,23,6,190,181,215,69,42,217,162,214,151,43,49,73,111,156,171,85,78,73,44,181,58,80,45,240,222,77,172,161,62,229,239,125,135,212,192,99,222,43,227,145,67,128,31,227,32,131,171,214,91,130,39,42,137,60,6,198,173,2,118,71,242,212,74,127,50,174,169,246,34,164,84,65,235,157,40,73,12,139,243,206,146,76,244,131,208,41,240,79,33,55,170,72,153,235,223,74,86,132,120,114,189,16,227,244,129,211,12,31,240,52,253,18,168,132,159,4,63,154,125,136,115,114,245,240,147,140,104,184,199,84,164,202,233,124,132,97,94,27,230,206,17,160,109,94,3,31,83,237,170,178,162,110,233,79,168,250,185,205,104,189,140,231,10,165,215,127,175,50,136,100,157,233,61,203,97,191,211,249,196,210,122,55,210,239,246,114,183,223,89,98,194,202,71,58,109,242,173,253,242,233,191,86,200,1,141,102,50,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNewContactNameLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNewContactNameLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6ba8ceef-adcd-4763-8a4a-dd632777ed25"),
				Name = "NewContactNameLocalizableString",
				CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949"),
				CreatedInSchemaUId = new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74"),
				ModifiedInSchemaUId = new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74"));
		}

		#endregion

	}

	#endregion

}

