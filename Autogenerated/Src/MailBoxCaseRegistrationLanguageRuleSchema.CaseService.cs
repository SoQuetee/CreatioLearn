﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailBoxCaseRegistrationLanguageRuleSchema

	/// <exclude/>
	public class MailBoxCaseRegistrationLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailBoxCaseRegistrationLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailBoxCaseRegistrationLanguageRuleSchema(MailBoxCaseRegistrationLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("deef2fcb-cb20-4c49-ac03-4ae5aaa4fc58");
			Name = "MailBoxCaseRegistrationLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ccdb6e24-6ee4-4f5a-ac6d-41fa38f56e68");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,91,111,34,55,20,126,102,165,253,15,46,251,50,72,104,232,115,2,84,73,54,68,84,161,155,134,108,251,176,202,131,153,57,128,171,25,155,216,30,186,104,149,255,222,227,177,231,226,97,24,168,212,190,49,231,126,253,124,32,156,166,160,118,52,2,242,2,82,82,37,214,58,188,19,124,205,54,153,164,154,9,254,241,195,143,143,31,122,153,98,124,67,150,7,165,33,189,110,124,163,124,146,64,100,132,85,248,0,28,36,139,142,100,30,25,127,171,136,117,95,105,42,120,59,71,194,41,122,120,207,53,211,12,212,73,129,25,141,180,144,86,2,101,62,73,216,96,124,228,46,161,74,93,145,5,101,201,173,248,126,71,21,60,35,67,105,155,235,35,229,155,140,110,224,57,75,32,87,27,141,70,100,172,178,52,165,242,48,117,223,79,82,236,89,12,138,36,78,154,172,133,36,17,154,34,178,102,139,164,232,99,37,190,135,133,153,81,205,206,46,91,37,44,34,145,137,230,146,96,200,21,185,69,182,31,95,207,52,166,202,12,171,175,41,215,152,221,147,100,123,170,109,6,189,157,253,32,145,225,19,52,110,138,101,124,45,163,45,164,244,55,236,63,153,144,190,161,244,175,79,42,220,96,123,247,76,31,124,165,130,218,161,248,68,37,112,93,8,226,164,100,41,47,212,125,94,56,143,59,236,60,67,196,118,12,197,125,19,72,134,156,220,161,122,39,118,135,19,234,142,117,214,132,107,209,76,200,57,143,176,249,92,215,59,229,23,101,97,251,126,66,246,188,147,162,201,126,164,11,80,10,137,5,179,187,88,95,21,184,40,218,141,29,243,59,140,45,129,199,32,239,205,56,223,196,177,196,56,26,145,89,75,203,3,143,150,160,53,170,168,240,88,167,107,182,18,70,85,171,233,58,167,111,23,185,247,9,77,219,145,119,223,110,254,113,45,119,32,13,38,152,5,16,26,1,9,226,98,5,220,39,249,204,114,152,194,45,28,91,231,67,23,196,20,163,48,206,172,255,5,221,145,124,185,122,27,208,121,224,239,221,206,243,229,147,153,129,28,227,62,223,110,43,209,68,144,156,112,39,1,171,160,8,203,87,22,177,87,172,81,8,176,46,18,214,147,254,5,128,208,31,77,195,210,252,168,105,127,188,163,146,166,196,96,251,164,159,41,144,24,31,183,8,221,159,98,243,165,105,128,35,132,227,81,46,157,43,59,92,186,32,128,224,171,103,150,248,94,6,121,241,174,86,104,32,104,112,92,97,155,229,158,16,14,127,119,244,39,24,92,210,135,5,232,173,136,79,65,224,94,176,152,224,56,89,175,42,200,31,17,7,105,191,103,32,15,4,212,219,144,204,239,121,150,130,164,171,4,198,197,116,68,86,165,136,30,17,31,104,180,37,129,27,97,203,198,126,54,5,155,121,126,179,252,87,204,23,125,133,101,48,129,165,15,66,51,250,121,166,38,213,50,223,34,3,235,238,219,43,121,128,18,55,75,104,83,193,67,134,9,154,151,200,102,134,28,33,227,121,92,4,147,179,119,30,232,206,99,140,4,141,61,53,168,65,139,21,27,22,91,147,224,216,6,26,65,227,225,125,186,211,135,50,119,9,58,147,156,240,44,73,106,41,229,22,94,228,161,150,130,117,116,100,118,72,68,166,201,158,74,66,61,193,65,233,193,149,95,22,37,192,100,124,81,188,71,244,203,97,7,174,204,127,208,36,43,155,26,180,60,10,46,201,94,217,215,218,251,240,239,140,159,120,117,124,7,216,201,50,118,133,246,45,53,252,85,48,30,244,175,251,195,138,59,244,99,25,132,216,49,236,80,13,97,131,65,248,34,110,240,8,58,4,133,19,215,128,202,69,189,13,205,238,52,70,45,31,150,182,201,56,51,100,173,75,229,214,251,136,215,64,145,176,46,176,160,28,177,70,14,27,199,138,203,205,108,15,42,223,196,41,227,207,108,179,205,203,183,166,137,114,219,83,91,243,124,169,209,61,22,251,199,233,123,228,221,25,182,33,52,214,196,173,43,150,195,141,170,31,247,176,173,30,215,157,59,231,147,90,39,201,168,78,131,38,128,156,74,224,213,57,116,109,109,186,108,107,241,74,136,132,180,110,98,30,53,109,44,162,171,76,99,23,91,218,94,138,184,207,9,57,223,230,112,198,120,60,119,239,225,237,193,100,20,28,31,157,46,71,63,132,218,94,90,201,208,190,175,173,173,106,181,208,57,73,174,160,13,141,25,232,104,59,147,34,253,124,27,84,133,26,180,149,217,106,84,127,146,204,86,185,163,9,84,208,2,4,255,219,42,89,84,184,244,152,29,116,111,210,201,115,117,216,125,127,22,139,102,112,125,205,18,13,82,157,202,105,150,179,171,202,153,0,156,182,211,12,31,197,134,69,52,249,130,183,159,253,219,53,33,77,210,18,43,28,233,240,139,244,53,49,47,99,207,13,139,117,245,39,211,219,39,115,13,129,17,9,10,255,41,110,19,83,130,155,21,13,239,223,50,154,12,59,207,226,97,1,191,69,71,67,196,48,61,22,171,191,48,15,60,101,6,131,255,52,148,246,3,250,210,32,140,227,89,45,16,23,148,15,39,30,250,213,26,210,182,92,23,223,104,231,206,228,227,127,218,249,180,178,53,195,11,118,141,187,87,252,199,6,117,233,49,124,140,211,253,169,121,95,8,88,40,169,28,120,119,113,110,135,241,45,72,166,99,17,145,81,253,90,22,123,144,18,21,203,39,179,24,250,243,143,101,251,21,208,126,220,117,94,100,149,254,47,225,35,240,141,222,146,41,249,185,188,147,204,174,185,90,213,112,104,226,35,81,13,128,220,253,80,158,185,14,104,83,187,242,230,206,61,178,86,250,202,227,113,146,173,239,154,121,118,142,223,181,46,204,120,173,46,62,47,151,170,208,100,82,176,123,93,174,219,159,212,147,72,86,188,169,181,164,124,175,63,181,222,189,213,218,28,105,148,246,222,221,15,183,44,5,193,59,205,42,211,29,123,101,169,62,241,253,31,121,132,96,82,215,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("deef2fcb-cb20-4c49-ac03-4ae5aaa4fc58"));
		}

		#endregion

	}

	#endregion

}
