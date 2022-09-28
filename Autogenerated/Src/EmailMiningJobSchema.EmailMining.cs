﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMiningJobSchema

	/// <exclude/>
	public class EmailMiningJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMiningJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMiningJobSchema(EmailMiningJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5cc201b0-a7ef-4e37-aaca-fc8221b756a2");
			Name = "EmailMiningJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e20436f2-80ed-4182-a2cd-94f2d77ff547");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,26,219,114,219,182,242,89,157,233,63,32,106,103,14,53,71,165,147,151,243,96,91,154,241,45,41,211,56,241,177,157,230,161,211,233,192,36,36,161,229,69,1,64,59,74,234,127,63,187,184,17,164,72,89,153,105,230,188,216,36,176,216,93,236,125,151,42,105,193,228,154,166,140,220,50,33,168,172,22,42,62,171,202,5,95,214,130,42,94,149,241,69,65,121,126,201,75,94,46,191,255,238,203,247,223,141,106,9,143,228,102,35,21,43,142,58,239,112,54,207,89,138,7,101,252,138,149,76,240,116,11,230,156,42,186,181,248,134,151,31,155,197,101,94,221,209,252,240,240,172,42,10,224,225,77,181,92,194,114,179,255,150,61,40,32,129,220,190,150,85,217,108,132,183,192,163,253,59,130,13,173,183,47,63,8,117,126,58,184,117,81,42,174,56,147,131,0,47,105,170,42,49,0,113,201,164,164,120,215,134,127,128,250,65,176,37,176,67,206,114,42,229,33,9,84,242,186,186,211,16,7,7,7,228,88,214,69,65,197,102,110,223,175,217,90,48,201,74,37,201,26,20,81,101,60,165,57,81,84,254,69,22,149,32,12,177,144,66,163,137,29,138,131,0,199,186,190,203,121,74,82,36,218,161,73,14,73,2,255,46,62,177,180,134,203,0,240,23,205,70,195,41,104,71,81,32,125,72,174,4,191,167,138,153,253,46,159,122,1,76,224,134,41,133,146,40,193,30,201,3,87,43,203,24,89,139,42,5,153,248,27,112,181,33,188,196,221,90,49,25,123,156,33,227,163,181,33,73,82,228,130,72,37,16,19,240,123,165,145,52,228,228,91,36,55,35,227,224,118,6,6,158,199,71,95,203,178,145,104,90,213,165,50,18,166,233,202,95,64,212,229,215,112,171,57,186,162,233,95,103,136,238,9,150,1,140,46,217,13,255,204,118,50,125,206,22,180,206,21,185,167,121,205,72,181,248,103,24,230,112,24,48,123,134,145,13,96,240,197,243,221,172,228,212,41,210,168,82,51,80,178,79,138,252,9,246,197,180,101,161,37,241,5,156,102,64,76,176,197,108,156,148,105,37,4,68,152,150,159,94,124,74,217,26,31,198,7,115,82,165,105,13,32,217,222,204,247,227,188,229,5,187,89,241,133,186,180,252,205,200,127,118,94,41,48,9,188,74,199,126,89,73,239,114,86,128,55,126,149,21,232,83,129,170,251,12,161,11,131,54,48,128,47,201,128,1,190,128,64,128,87,60,73,85,77,243,125,156,98,248,220,14,98,38,150,177,27,86,102,76,116,16,62,125,236,180,202,54,183,155,53,107,113,115,81,66,66,89,177,204,153,249,15,128,219,68,156,118,248,121,201,89,158,117,99,143,163,6,129,73,65,92,19,140,102,85,153,111,72,2,233,133,252,145,195,159,25,129,199,75,90,2,121,1,233,75,97,222,97,34,106,49,62,105,113,238,145,188,161,159,55,199,201,201,122,125,131,252,213,57,19,31,4,133,160,53,7,204,176,213,89,37,51,68,50,42,217,195,240,193,40,154,144,217,220,196,124,147,51,54,200,83,63,236,100,242,132,68,116,64,22,53,162,65,185,232,208,190,195,152,147,18,146,24,205,193,149,37,161,4,249,228,58,160,167,58,110,168,21,11,157,178,157,27,208,7,117,206,24,50,116,147,86,218,135,224,174,88,91,140,30,255,63,60,233,149,53,21,180,208,225,124,54,46,228,242,108,69,203,146,229,214,28,198,243,91,32,144,154,53,82,88,27,57,62,208,135,118,220,43,185,236,98,34,91,184,237,221,71,127,164,109,192,217,54,232,81,32,164,33,85,95,137,10,108,2,107,144,1,7,232,225,169,67,250,232,9,240,206,171,97,127,201,148,125,26,65,208,142,186,183,121,54,35,101,157,231,238,178,163,145,96,170,22,101,47,105,125,71,135,104,139,124,156,200,235,186,68,9,55,200,182,101,215,115,204,154,75,155,196,46,54,30,247,16,247,37,83,171,106,48,216,220,87,60,195,168,114,33,68,37,34,159,168,32,193,217,39,175,124,8,64,177,134,122,89,137,130,42,136,58,30,248,97,197,4,3,11,23,213,67,73,178,90,135,201,176,124,195,148,25,143,167,1,210,208,78,28,43,186,50,221,52,21,58,129,104,242,190,180,9,138,101,62,129,71,239,37,19,16,47,74,11,86,183,94,29,191,152,57,129,159,183,117,1,178,14,178,7,198,168,95,177,192,136,218,231,166,187,75,154,169,81,70,183,144,48,23,209,196,168,206,58,231,116,35,77,230,217,147,172,193,187,119,226,155,146,23,150,38,180,41,12,139,0,75,88,179,37,111,20,21,10,119,128,186,3,136,111,171,140,110,226,147,44,67,230,162,159,186,140,90,124,70,252,24,185,11,138,56,249,125,243,58,235,8,57,14,129,131,132,228,44,248,116,131,188,70,227,19,139,198,102,165,209,61,133,34,78,126,4,124,24,30,67,36,255,173,153,216,68,109,178,222,123,146,101,9,157,201,57,151,107,168,202,180,20,177,220,129,116,193,140,23,24,228,128,56,6,27,199,160,169,177,129,37,213,69,9,206,248,43,151,28,74,16,123,164,1,6,137,24,152,104,140,217,220,49,217,217,74,228,207,170,200,119,0,156,65,146,85,44,123,87,14,236,99,129,129,186,24,79,226,119,2,74,141,211,205,57,147,105,52,12,12,209,60,216,188,174,30,180,65,2,251,198,158,155,173,151,60,87,76,72,60,255,134,149,75,181,50,11,29,49,78,137,185,222,148,152,109,232,220,32,43,112,232,75,177,126,137,95,105,246,197,148,60,159,244,98,142,240,221,220,209,172,126,128,94,226,10,211,10,67,144,168,23,233,197,71,48,49,32,140,47,99,107,227,206,24,116,170,151,166,113,199,253,247,73,54,249,6,164,77,45,6,14,161,106,233,88,8,215,32,220,106,57,161,127,220,232,210,14,170,148,127,144,15,43,215,119,194,49,228,237,192,50,211,235,183,223,66,18,191,153,156,111,234,86,156,110,28,58,85,28,38,217,239,96,96,249,144,142,220,43,80,130,146,148,175,161,99,70,232,219,106,74,246,131,60,75,247,133,60,77,83,119,119,155,241,240,202,16,83,186,105,161,19,64,123,83,201,57,215,123,16,9,142,95,213,60,155,146,55,92,42,253,56,159,99,90,209,2,185,169,239,164,224,119,40,190,157,25,197,219,78,39,61,233,12,39,93,144,74,46,202,186,96,2,123,29,67,200,199,208,36,195,104,101,160,227,27,134,199,35,166,145,97,253,108,158,92,224,50,97,64,135,184,32,100,74,125,8,144,68,230,248,4,163,167,197,212,145,134,45,55,98,23,79,88,145,129,227,251,64,156,100,227,45,16,90,35,4,238,196,39,18,98,118,6,73,251,61,212,178,13,108,252,82,84,133,107,51,26,51,178,7,144,132,71,154,0,39,226,117,197,49,148,109,164,199,101,65,129,20,4,193,134,173,119,15,0,173,41,39,82,91,171,227,6,110,164,64,126,1,11,31,176,198,232,189,15,208,140,108,172,15,60,34,144,254,36,20,37,40,61,53,90,183,89,104,151,173,184,32,109,198,96,209,249,169,155,40,145,204,15,151,250,146,163,172,33,93,157,54,75,16,89,92,46,179,168,18,20,224,53,116,103,80,11,102,205,227,204,234,58,54,216,153,89,142,26,106,13,162,209,195,138,67,82,139,154,211,49,254,11,72,141,70,120,11,125,101,125,227,4,107,146,0,28,28,33,176,55,115,229,142,254,143,90,152,26,153,238,133,40,208,145,199,3,177,204,173,67,29,137,46,152,34,107,81,160,151,105,200,241,52,32,234,177,60,134,5,242,99,24,51,2,52,125,113,65,87,187,67,44,236,12,26,45,254,186,98,181,17,162,35,35,167,135,6,77,115,198,50,96,167,172,166,143,120,22,208,136,181,3,64,255,248,11,219,68,1,165,70,185,61,168,172,65,55,244,156,249,142,66,204,152,77,90,2,238,193,100,207,61,18,150,75,182,155,98,128,250,183,0,237,239,65,131,210,119,82,179,209,85,109,159,182,48,107,94,51,89,231,74,66,158,110,136,69,250,154,174,155,5,35,52,61,173,1,157,19,97,142,184,178,125,79,213,250,230,1,212,209,138,20,166,55,36,127,255,237,16,187,37,175,15,99,128,225,173,49,220,108,117,125,61,237,178,166,214,5,236,96,215,221,215,7,42,32,116,218,0,220,237,245,9,151,164,172,20,142,69,245,196,156,88,161,145,135,170,252,151,34,119,140,224,168,221,123,226,54,187,11,40,177,113,190,26,129,201,105,63,190,162,92,244,136,235,222,237,225,120,180,71,118,77,208,73,155,168,227,15,197,128,221,178,16,244,237,254,50,179,142,196,160,6,42,179,68,177,226,116,3,101,98,20,98,117,55,9,164,183,37,182,81,10,110,196,203,186,211,82,7,30,217,78,210,13,155,90,2,71,1,248,160,165,53,60,57,137,207,156,145,184,164,104,114,151,89,196,156,31,16,245,142,110,183,227,38,106,78,124,82,189,173,144,5,239,205,58,143,241,98,157,51,103,11,198,241,111,90,107,78,4,88,251,3,0,126,135,2,90,247,76,40,40,66,132,25,84,189,187,251,19,107,136,173,43,76,172,223,140,180,242,172,116,227,36,179,82,116,81,37,164,23,255,108,114,65,103,46,218,51,45,221,117,218,15,99,91,195,89,123,194,241,113,85,73,101,247,163,22,150,73,96,207,123,79,69,158,26,53,94,215,165,212,211,59,63,209,0,62,247,28,211,181,11,131,241,28,235,76,156,38,187,74,33,156,207,233,195,198,45,165,25,230,233,174,207,142,14,253,24,196,22,146,4,10,143,227,116,254,211,139,227,131,116,142,31,33,22,208,27,64,213,225,194,128,153,231,103,64,193,161,12,102,128,247,92,96,235,161,191,46,192,245,180,85,239,55,85,25,40,130,65,97,67,195,154,190,106,93,207,75,60,172,235,110,109,133,172,95,143,154,153,83,82,46,42,63,114,50,212,84,229,78,31,146,47,207,31,161,32,108,35,155,52,113,213,34,77,228,219,10,170,254,181,218,4,245,81,227,210,134,182,121,156,89,211,223,26,108,55,224,243,8,221,45,24,89,159,136,101,141,223,78,162,174,198,167,93,57,78,246,138,41,62,201,4,140,185,146,208,94,201,33,218,55,181,25,21,117,27,159,238,12,172,141,123,48,247,186,236,218,138,255,97,50,241,154,179,58,115,131,192,5,252,147,43,134,249,33,77,81,99,11,8,215,126,176,98,139,184,182,50,195,202,96,216,65,91,227,70,90,2,1,251,9,66,250,143,118,223,204,105,195,195,107,223,129,140,231,248,33,186,121,239,27,198,235,10,199,233,117,119,19,74,146,64,211,230,83,212,148,84,58,126,207,3,42,225,248,83,109,127,34,124,110,4,173,196,38,28,133,63,235,27,84,30,223,85,85,62,223,158,146,62,241,201,111,170,135,108,65,19,210,239,196,78,85,16,174,50,46,77,172,130,90,15,170,20,253,123,11,40,86,12,74,251,49,88,123,185,235,33,158,98,193,247,9,97,145,227,114,191,143,119,189,129,233,145,164,84,97,17,244,196,135,92,194,62,181,107,51,51,63,103,159,226,118,42,26,245,232,96,191,239,185,29,126,122,41,251,185,61,172,57,122,56,132,119,103,193,219,40,184,151,87,53,70,93,247,243,129,125,167,226,67,63,75,104,230,133,218,132,2,188,96,101,61,218,143,126,28,7,95,160,191,12,161,133,150,3,231,0,58,198,127,102,162,138,145,1,242,192,161,248,198,180,118,135,159,52,157,107,103,177,47,103,219,157,138,230,104,75,242,243,144,175,160,162,254,113,252,214,125,214,215,116,144,70,93,98,117,251,165,185,213,191,183,188,233,209,253,200,99,220,237,75,71,254,243,231,123,165,103,62,246,21,201,128,249,245,127,120,48,150,124,178,94,99,252,198,95,38,197,183,84,44,153,130,235,191,18,85,189,182,190,181,226,210,251,193,46,238,38,45,171,223,81,17,153,213,246,226,227,255,0,235,23,160,218,119,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5cc201b0-a7ef-4e37-aaca-fc8221b756a2"));
		}

		#endregion

	}

	#endregion

}
