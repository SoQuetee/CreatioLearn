﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailConditionalTransitionElementHandlerSchema

	/// <exclude/>
	public class EmailConditionalTransitionElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailConditionalTransitionElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailConditionalTransitionElementHandlerSchema(EmailConditionalTransitionElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4544fb03-1158-4523-8bc1-19b739b2bfbf");
			Name = "EmailConditionalTransitionElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,221,79,228,54,16,127,222,147,238,127,176,168,212,38,210,42,84,234,219,113,32,29,220,114,32,193,113,5,218,123,168,250,96,146,217,93,139,124,108,109,7,216,34,254,247,142,191,18,39,113,200,246,84,93,95,22,98,207,120,190,126,51,99,15,41,105,1,98,67,83,32,183,192,57,21,213,82,38,39,85,185,100,171,154,83,201,170,242,237,155,231,183,111,102,181,96,229,138,220,108,133,132,226,160,247,141,244,121,14,169,34,22,201,39,40,129,179,116,64,243,145,74,58,88,188,96,229,95,237,162,175,64,81,84,101,120,135,67,242,65,74,206,238,106,9,98,148,228,132,22,27,202,86,227,103,56,130,100,241,0,165,60,163,101,150,3,31,165,254,120,140,91,184,249,3,135,21,154,73,78,114,42,196,59,178,40,40,203,209,91,25,83,198,211,252,150,211,82,232,255,23,57,20,237,185,154,119,127,127,159,188,23,117,81,80,190,61,178,223,250,28,34,43,178,214,132,36,181,90,17,80,90,9,130,162,104,158,19,80,114,72,218,10,34,178,145,68,192,136,66,226,101,203,47,210,53,50,37,78,236,190,39,119,83,223,229,44,37,2,104,14,25,73,181,6,187,26,66,222,17,231,56,223,111,199,84,192,156,156,95,149,110,243,164,218,108,81,212,179,54,188,245,26,2,68,82,84,245,29,249,162,149,48,219,125,199,232,133,207,136,75,109,81,205,57,10,10,24,108,125,198,147,230,12,223,74,103,102,170,100,18,129,128,193,168,118,141,209,34,14,201,222,174,198,239,29,88,115,160,204,140,69,93,243,46,65,174,171,76,25,199,217,3,149,96,118,55,230,131,220,128,202,17,242,9,228,226,137,9,137,234,156,109,55,192,115,86,222,11,179,247,107,13,124,27,157,47,202,186,0,78,239,114,120,255,169,102,217,17,89,59,186,243,76,204,213,145,179,217,144,168,132,199,227,58,191,215,182,32,93,76,158,53,229,3,229,4,80,30,147,67,121,104,59,114,89,197,162,223,4,112,116,66,105,18,57,54,114,84,106,215,69,25,237,157,103,123,253,165,51,42,214,131,69,79,135,225,222,166,64,215,166,247,225,173,107,216,96,188,232,37,21,247,205,246,41,175,10,239,204,198,128,134,224,235,26,56,248,218,205,146,243,50,50,167,38,95,40,199,8,75,224,34,242,93,24,59,230,43,30,212,119,228,136,190,131,99,66,133,245,221,129,102,28,115,115,114,179,129,148,45,183,159,171,139,42,189,63,99,136,255,40,54,44,28,100,205,203,209,0,105,162,151,46,140,84,180,201,41,43,179,147,188,42,33,59,107,13,59,222,170,136,68,154,192,179,119,110,88,36,229,43,144,158,5,1,36,13,29,125,89,101,144,123,8,20,109,169,119,8,51,242,80,50,194,41,68,151,156,50,46,228,21,255,8,75,90,231,50,122,34,135,71,228,41,57,207,200,225,161,175,103,156,40,245,15,26,212,166,93,251,70,78,119,64,9,202,56,211,90,29,106,237,108,108,127,252,17,215,61,47,168,237,129,107,186,209,233,41,130,154,255,219,184,88,212,127,247,208,40,55,174,39,28,184,115,120,254,211,200,116,243,189,35,170,183,215,137,91,83,64,6,28,118,253,255,139,242,119,11,238,156,220,85,85,78,150,168,68,131,44,23,112,182,36,81,112,195,89,57,1,208,142,250,99,154,207,130,144,51,206,124,193,230,44,96,55,161,186,90,77,72,12,195,219,202,10,196,103,216,23,131,194,69,244,237,238,31,107,192,162,170,121,10,190,144,49,4,248,233,233,193,238,194,112,217,174,124,129,119,4,115,114,228,165,94,39,184,175,39,158,105,141,46,223,166,114,193,50,125,40,183,209,90,177,172,253,100,59,34,63,91,29,150,120,25,166,233,154,68,157,210,130,36,172,12,56,160,65,95,160,106,104,245,195,153,244,237,40,156,247,210,194,40,61,27,58,57,249,144,101,209,64,35,31,88,129,186,96,121,67,117,193,135,195,228,117,210,128,82,147,13,246,196,87,38,215,237,61,32,114,46,36,86,29,119,193,190,49,247,251,211,188,122,116,156,161,184,219,189,91,60,80,117,195,211,156,174,162,238,17,62,69,171,77,236,21,82,194,118,120,31,56,0,217,203,164,17,175,110,72,59,115,118,244,246,130,162,49,25,199,33,175,63,84,152,94,215,112,231,188,217,201,240,206,13,184,235,107,97,161,183,99,8,14,154,218,218,63,199,234,230,195,60,4,75,20,23,188,246,15,206,115,128,237,164,153,247,242,193,44,27,176,56,225,90,250,32,91,80,116,212,30,144,220,232,28,189,134,165,10,205,37,229,247,160,52,210,180,46,28,73,119,217,246,193,190,117,232,225,219,202,184,254,213,50,212,13,172,167,137,31,225,219,74,85,187,40,86,131,7,73,89,41,34,117,1,113,247,244,22,85,182,50,181,137,173,117,194,106,217,171,159,35,53,63,92,49,66,38,185,26,51,27,187,52,224,78,208,20,83,188,7,213,194,213,148,169,150,53,218,137,194,240,25,182,162,29,106,207,24,128,116,195,217,161,21,250,253,105,140,220,111,89,190,127,71,123,219,176,157,154,186,235,191,184,144,121,144,127,126,185,49,222,64,232,124,11,200,173,30,3,1,167,21,95,96,38,26,9,190,41,170,131,92,211,114,133,200,246,1,16,123,150,191,242,238,158,156,2,116,222,252,1,103,56,125,199,222,156,139,39,72,107,137,78,160,25,240,136,235,63,29,19,76,11,84,209,24,9,162,171,43,26,212,230,128,4,213,54,15,227,223,105,94,219,72,153,215,183,205,24,243,226,122,157,220,204,13,44,67,183,84,189,202,215,121,170,59,118,239,69,48,194,141,239,237,163,238,236,161,229,237,188,65,166,248,135,3,138,151,184,251,134,104,157,235,119,171,233,113,209,212,44,236,4,53,147,32,72,90,109,182,106,38,214,214,30,241,19,201,168,164,132,98,25,54,217,201,164,26,39,122,20,35,227,177,63,174,184,66,198,47,241,159,222,176,76,55,212,43,61,189,107,250,167,228,91,7,133,209,86,235,46,255,41,149,170,107,45,158,82,216,152,81,221,83,211,159,236,8,174,0,33,232,10,76,14,92,164,127,223,232,101,237,234,104,56,158,155,147,61,163,78,115,228,158,171,192,238,26,115,81,173,86,24,181,5,231,21,199,108,45,168,140,172,140,57,138,159,247,111,76,139,82,50,185,109,11,185,92,243,234,113,248,160,232,5,205,172,246,22,123,195,224,145,60,154,158,253,114,216,112,16,106,162,153,179,213,90,62,130,250,53,113,197,96,15,143,37,160,109,8,14,119,17,173,192,213,128,216,204,117,71,117,234,143,102,191,240,10,9,36,131,30,30,45,48,244,67,6,147,236,153,96,59,60,32,66,253,188,12,41,116,250,79,208,248,25,63,78,138,118,16,47,185,39,9,253,76,14,16,239,16,78,92,251,7,83,110,195,66,13,25,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOnCopyExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOnCopyExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("76934acd-150c-4812-b1f2-a1d218422c09"),
				Name = "OnCopyException",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("4544fb03-1158-4523-8bc1-19b739b2bfbf"),
				ModifiedInSchemaUId = new Guid("4544fb03-1158-4523-8bc1-19b739b2bfbf")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4544fb03-1158-4523-8bc1-19b739b2bfbf"));
		}

		#endregion

	}

	#endregion

}

