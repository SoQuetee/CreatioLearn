﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FillEmailTemplateUserTaskPartialSchema

	/// <exclude/>
	public class FillEmailTemplateUserTaskPartialSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FillEmailTemplateUserTaskPartialSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FillEmailTemplateUserTaskPartialSchema(FillEmailTemplateUserTaskPartialSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("81b744f2-f0fd-4d07-8a15-859a0b11dbfe");
			Name = "FillEmailTemplateUserTaskPartial";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,91,115,219,182,18,126,118,103,250,31,80,122,166,166,199,12,229,116,250,208,145,108,229,36,182,155,227,57,113,235,90,78,242,224,250,1,38,33,9,39,188,200,0,168,88,113,253,223,187,139,11,9,82,148,226,156,51,245,131,41,130,139,221,111,175,216,69,65,115,38,23,52,97,228,154,9,65,101,57,85,241,73,41,88,124,41,202,132,73,9,47,197,148,207,42,65,21,47,139,239,191,123,252,254,187,157,74,242,98,70,38,43,169,88,62,234,188,3,125,150,177,4,137,101,252,150,21,76,240,100,141,230,154,61,168,248,138,205,170,140,138,179,135,133,0,57,72,223,208,249,88,242,188,44,250,191,8,182,105,61,62,43,20,87,156,109,96,217,168,215,247,253,35,187,219,34,22,191,254,91,169,69,252,250,78,42,65,141,166,64,8,164,187,130,205,224,141,156,100,84,202,33,249,149,103,217,89,78,121,118,205,242,69,70,21,123,47,153,184,166,242,147,38,30,12,6,228,72,86,121,78,197,106,108,223,47,169,80,156,102,36,65,6,164,156,110,102,17,17,53,167,138,112,88,101,57,43,20,169,224,3,81,240,133,136,10,116,207,25,185,99,115,186,228,101,37,98,39,109,224,137,91,84,119,25,79,200,162,37,113,11,226,157,71,141,186,214,241,130,169,121,153,130,150,96,72,5,254,102,169,249,190,112,175,164,92,130,205,120,10,64,202,50,35,231,133,98,162,160,217,217,3,75,42,197,66,107,127,243,10,22,134,48,83,16,21,36,49,207,125,130,129,182,179,179,164,130,228,180,160,51,208,238,152,32,28,32,44,76,124,25,39,175,38,201,156,229,244,194,16,141,234,93,78,133,179,201,31,176,179,96,159,137,79,254,71,197,196,42,180,156,35,18,180,180,14,246,13,27,143,69,12,162,95,167,57,47,174,248,108,174,36,112,156,210,76,178,117,186,215,105,10,25,80,229,69,24,76,170,187,255,2,210,62,110,30,213,155,50,93,245,145,128,47,192,98,18,73,67,253,177,245,245,68,48,248,101,104,62,114,53,135,200,129,68,198,13,161,89,132,0,6,223,114,89,22,215,171,5,228,195,125,69,51,208,243,60,13,162,218,52,231,233,254,126,99,176,123,52,201,21,147,85,166,64,61,95,216,91,166,140,237,154,220,14,219,174,176,108,248,148,132,30,27,200,34,136,69,50,38,135,206,157,59,214,38,32,192,163,187,57,188,69,25,8,212,154,229,3,205,42,118,4,249,5,145,49,94,179,228,14,218,236,27,89,248,102,126,34,12,124,231,32,9,166,42,81,16,37,42,235,206,39,253,223,236,36,82,135,203,111,96,92,16,104,214,226,179,124,161,86,141,225,228,74,154,160,122,86,132,130,99,139,244,188,144,138,22,9,123,179,122,127,158,134,80,21,125,66,112,75,99,206,134,249,15,16,197,85,150,213,166,108,35,115,100,49,46,124,131,154,38,193,120,241,172,52,105,68,122,113,35,157,238,150,12,253,208,232,135,196,225,218,62,43,113,107,86,57,26,47,87,32,122,45,131,83,174,13,12,197,204,186,56,178,206,25,67,5,65,98,20,38,173,70,155,137,67,79,143,156,38,162,148,239,184,196,232,68,39,93,224,66,104,99,175,6,238,136,16,215,21,45,102,44,108,104,49,200,92,74,77,225,148,161,201,156,132,200,187,193,116,137,117,150,23,158,180,218,161,232,238,31,60,244,120,244,42,48,130,252,15,91,133,109,14,251,245,166,157,134,61,134,129,137,1,68,100,28,104,44,247,102,117,73,213,188,203,195,38,147,150,107,57,116,99,172,78,3,38,239,79,234,221,218,215,93,231,116,152,123,113,8,127,190,86,88,208,218,196,81,155,125,13,204,68,168,125,52,225,202,116,128,122,32,234,250,212,169,74,17,9,75,227,188,43,150,148,34,173,19,171,169,66,88,51,224,184,249,248,187,118,160,100,50,108,28,19,17,75,23,89,145,145,31,91,150,149,45,69,219,249,32,209,54,38,90,43,9,167,54,20,92,195,0,88,6,187,103,118,105,55,104,234,129,139,9,120,74,101,104,195,246,214,38,54,222,47,82,88,221,76,25,33,108,39,100,162,29,29,186,240,125,90,3,118,201,147,30,108,176,250,92,120,53,131,231,32,172,137,123,64,194,183,14,206,110,113,123,178,205,10,43,82,211,175,108,106,94,116,23,100,59,23,211,17,213,109,139,141,124,148,110,154,148,178,56,165,138,134,14,188,149,185,118,38,60,181,216,45,185,80,112,244,18,12,4,119,26,121,213,197,157,50,208,166,37,204,111,122,4,251,98,171,151,191,51,236,22,151,11,170,224,145,235,255,80,85,160,167,102,15,177,94,132,16,52,92,35,242,175,224,207,155,221,48,62,120,181,191,251,231,109,208,88,31,100,232,108,212,219,227,183,162,172,22,242,230,229,109,172,143,206,62,251,194,134,45,42,122,6,235,196,148,21,104,9,42,145,129,106,86,245,253,78,95,222,26,55,98,56,25,39,76,97,127,136,195,132,210,192,214,146,60,152,112,232,84,69,230,206,6,43,38,227,197,39,12,213,35,74,230,130,77,143,247,2,114,160,101,31,144,224,164,146,170,204,39,76,44,57,116,161,49,125,72,95,153,78,254,216,197,223,143,60,61,198,13,174,114,196,215,101,173,205,129,49,95,240,35,162,44,102,199,143,135,79,123,227,199,151,79,71,3,58,38,36,104,161,16,174,161,234,239,29,88,247,176,221,120,8,127,189,179,64,75,0,32,57,53,170,188,99,75,86,219,100,77,142,127,172,98,41,122,22,225,101,201,11,232,194,226,223,69,202,196,41,23,6,11,64,110,47,196,167,76,38,144,122,160,175,25,140,236,41,53,103,201,167,164,110,33,97,219,186,176,103,183,154,173,227,245,228,18,131,191,195,223,11,115,237,130,131,218,7,191,150,2,92,28,98,128,68,176,23,133,122,61,99,163,102,227,242,200,158,72,134,120,115,151,105,44,217,159,58,8,226,127,200,30,93,236,214,18,168,169,184,56,139,218,225,41,62,169,132,192,97,176,123,140,155,140,131,201,245,189,226,153,158,139,81,141,55,20,186,175,197,2,64,232,100,131,12,234,99,6,115,58,244,217,82,245,246,206,255,116,42,183,90,241,148,47,39,106,149,97,251,17,124,230,169,154,15,201,207,135,139,135,17,153,51,108,31,221,219,20,240,191,144,252,11,27,146,159,126,193,5,212,230,5,205,248,172,24,18,8,75,24,142,70,36,168,147,24,202,189,2,11,100,142,34,231,105,154,49,96,147,149,84,13,51,54,85,35,114,71,147,79,51,40,143,69,58,132,92,31,181,51,28,139,75,141,75,203,74,177,102,104,173,135,164,40,11,96,6,81,89,138,33,249,60,7,245,70,100,147,200,6,148,214,97,74,115,158,173,134,228,3,19,41,100,120,68,94,11,24,213,163,107,58,47,115,218,1,81,23,59,149,18,109,155,227,189,159,15,247,172,101,204,111,137,24,143,247,114,42,102,188,120,161,202,197,144,160,121,246,198,88,230,122,170,164,133,50,176,85,242,162,76,89,54,56,129,152,185,210,85,207,20,29,188,123,176,4,177,92,38,131,43,60,206,129,102,224,215,78,228,63,192,34,233,48,60,254,244,164,197,90,17,71,224,217,250,211,75,172,165,135,80,75,97,209,66,131,178,106,127,168,116,28,52,197,243,107,181,85,222,255,83,213,84,222,111,29,93,240,251,255,91,54,215,217,192,19,14,244,160,175,0,202,46,82,172,135,184,253,25,245,180,174,18,200,104,129,80,209,162,93,134,189,117,15,104,199,181,122,163,134,139,14,247,77,92,90,165,214,233,228,213,90,159,15,148,160,211,38,235,219,229,219,149,131,200,136,115,251,182,87,123,173,95,212,98,28,53,25,220,87,184,33,165,232,93,134,183,88,232,172,227,61,200,164,132,101,217,130,166,232,168,250,29,239,80,245,251,203,189,241,145,18,58,96,29,20,29,185,98,12,255,144,147,141,224,175,157,2,157,113,162,213,63,186,85,55,199,18,36,142,108,152,187,57,227,27,230,228,206,249,2,61,57,213,185,4,54,255,173,196,166,247,93,9,229,138,127,65,248,198,77,166,71,124,214,164,235,192,54,23,23,70,74,226,207,147,235,25,236,200,150,40,168,159,66,65,187,228,6,213,22,55,79,181,155,54,160,91,55,91,54,88,63,88,1,198,108,221,8,77,214,199,82,60,117,45,177,189,115,49,27,204,161,106,110,60,188,109,49,26,80,51,211,55,113,6,34,148,234,83,125,211,216,76,218,78,209,48,196,47,215,28,182,122,0,189,12,9,234,91,144,238,113,236,49,241,117,123,245,170,113,105,79,166,185,80,68,110,137,158,36,154,187,5,195,173,222,61,242,39,242,29,140,58,125,85,168,111,243,23,25,77,32,163,111,118,49,244,59,97,0,41,176,123,27,68,198,153,125,89,134,60,182,164,197,178,228,41,89,31,22,109,136,228,118,80,244,35,198,25,182,25,245,237,175,26,169,219,229,99,178,211,60,62,182,209,245,131,212,247,220,125,3,112,11,102,103,124,116,168,220,190,208,81,253,245,151,129,209,253,176,101,190,53,171,237,69,88,251,27,140,198,92,81,227,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81b744f2-f0fd-4d07-8a15-859a0b11dbfe"));
		}

		#endregion

	}

	#endregion

}

