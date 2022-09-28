﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculatorActionsSchema

	/// <exclude/>
	public class TermCalculatorActionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculatorActionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculatorActionsSchema(TermCalculatorActionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0026dc01-7a4e-45d4-b5e7-e879067fbf5e");
			Name = "TermCalculatorActions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,235,79,220,56,16,255,188,149,250,63,184,156,84,101,213,37,130,175,60,69,121,84,171,3,202,21,238,144,238,203,201,108,188,144,107,30,91,59,1,86,21,255,251,141,95,241,35,14,187,75,225,246,218,158,84,209,141,51,47,143,127,51,158,177,83,179,180,184,70,231,83,86,145,124,243,245,171,218,122,140,247,203,44,35,163,42,45,11,22,127,32,5,161,233,200,39,57,78,139,47,205,216,5,161,20,179,114,92,1,103,158,151,69,240,5,37,29,195,241,97,81,165,85,74,24,188,127,253,170,192,57,97,19,60,34,14,85,49,78,175,107,138,185,73,175,95,125,229,116,189,95,40,185,134,71,180,159,97,198,54,56,117,190,143,179,81,157,225,170,164,123,210,122,65,56,169,175,178,116,132,70,156,174,139,172,7,50,123,70,36,140,85,180,30,1,5,72,62,19,252,66,148,150,21,148,18,253,206,8,5,214,66,186,14,213,206,227,0,125,168,211,4,141,112,70,138,4,211,97,210,71,66,103,207,227,218,246,248,54,37,81,149,102,12,222,21,228,14,237,43,17,98,204,83,218,151,228,251,141,22,224,49,42,253,151,108,255,6,167,92,165,16,5,75,93,249,239,34,203,94,193,253,32,253,240,11,12,74,103,169,103,229,185,51,90,78,8,229,139,185,193,127,87,96,21,73,148,235,244,35,242,102,236,61,126,69,194,202,107,82,109,202,95,76,255,122,240,5,57,158,144,147,88,132,93,44,136,229,170,5,88,135,135,69,157,19,138,175,50,178,197,197,236,160,150,87,103,74,235,242,225,9,169,110,202,68,56,48,189,197,21,209,186,197,3,250,149,76,255,192,89,77,206,112,74,183,14,96,228,34,205,201,0,29,224,233,176,208,54,236,32,88,202,83,130,41,97,213,105,89,93,18,242,25,198,129,36,210,12,136,235,2,140,139,136,106,164,8,51,175,202,50,67,121,121,75,142,74,122,139,41,71,16,196,2,209,112,117,20,161,4,79,67,240,225,170,124,135,12,130,58,21,96,211,49,138,222,128,48,46,228,98,58,33,9,164,160,58,47,196,76,183,184,69,59,209,10,8,229,175,254,26,50,53,161,149,190,54,170,71,73,85,211,66,132,199,92,14,138,130,243,231,211,81,6,61,136,191,33,42,152,111,104,56,230,63,226,189,132,187,153,69,182,255,118,209,58,218,64,171,235,74,178,50,181,107,133,194,134,89,242,156,56,212,168,224,84,231,19,44,196,30,99,86,93,150,244,51,100,90,62,60,44,42,2,140,217,97,145,68,2,241,48,73,64,86,142,233,212,114,178,246,36,104,64,132,125,81,169,70,100,230,233,249,232,134,228,248,183,154,208,169,151,110,98,155,224,4,23,248,154,208,1,90,9,104,95,81,179,111,73,148,54,160,170,84,63,182,185,122,238,71,249,28,173,92,148,154,87,211,196,231,117,206,205,231,104,0,250,189,235,107,112,154,112,24,31,137,79,240,189,164,231,130,62,149,119,251,101,93,84,64,183,110,70,143,210,12,204,98,92,77,196,159,247,41,1,47,202,209,203,180,186,57,195,20,182,33,78,18,201,65,216,215,38,152,166,76,169,56,252,82,227,12,38,234,128,106,101,32,227,188,23,118,176,227,0,68,228,127,114,182,176,104,106,74,242,109,32,169,219,208,81,188,111,96,141,234,44,3,124,201,129,96,236,104,8,237,68,141,247,78,97,106,253,152,15,126,28,195,4,0,155,26,61,241,159,132,150,26,94,189,158,13,176,6,253,46,192,128,191,121,19,181,82,131,6,149,178,155,199,183,136,18,254,7,189,155,129,85,78,29,112,99,8,253,141,9,159,8,15,20,99,27,155,145,240,80,10,200,0,69,76,96,196,164,56,197,51,166,101,126,32,50,220,236,136,95,53,98,54,93,41,85,57,183,140,245,102,169,143,129,116,203,75,234,92,67,71,182,101,129,116,171,172,31,72,3,96,197,75,46,52,210,25,23,102,126,215,164,29,166,131,132,235,136,197,67,4,153,31,116,46,154,145,165,244,187,155,52,3,68,180,20,0,102,215,154,164,173,29,163,12,245,220,192,41,204,2,180,104,124,209,154,229,89,157,212,123,57,15,41,8,27,152,228,169,64,133,214,112,2,197,151,146,207,135,27,80,217,33,38,88,166,154,227,28,48,159,17,155,9,109,111,107,177,238,230,35,25,231,139,67,69,187,104,40,194,66,41,129,103,208,63,148,137,137,196,137,120,110,10,0,133,6,119,20,230,36,54,200,251,144,85,231,21,166,85,228,139,121,167,178,111,207,123,99,101,186,85,46,244,140,146,219,180,172,89,199,116,61,177,134,219,174,84,134,76,178,41,25,154,223,103,110,144,142,90,179,107,185,199,99,117,171,16,177,104,46,197,60,213,184,169,36,219,45,140,40,243,186,230,241,104,214,124,249,74,240,219,11,193,49,206,24,113,3,237,165,43,27,175,108,25,38,246,139,37,149,33,161,168,237,63,159,254,15,130,158,126,164,218,16,168,213,6,122,29,2,155,157,137,165,103,52,226,152,48,102,44,56,130,124,190,152,13,186,168,146,117,152,92,118,115,0,226,151,98,241,94,49,141,220,204,39,227,201,46,144,30,205,91,115,197,214,124,93,222,24,32,149,200,29,96,145,118,34,184,151,200,248,213,18,99,161,221,43,100,18,147,190,26,58,48,116,115,25,225,37,214,249,25,81,244,159,11,37,9,228,70,127,16,189,86,67,97,16,139,42,203,123,204,116,24,179,144,109,109,111,142,4,137,120,63,193,206,66,121,99,177,83,224,174,251,213,79,211,25,88,212,176,147,187,6,88,165,208,227,45,142,66,133,191,103,119,7,234,140,90,96,249,161,58,144,59,217,243,71,236,50,98,214,116,242,203,142,88,89,100,180,234,67,232,78,156,86,184,1,253,243,239,83,124,167,212,5,107,71,116,91,97,178,180,24,159,17,32,225,40,95,125,98,152,227,251,57,195,156,3,105,254,32,63,74,41,171,244,192,176,152,121,12,250,125,7,246,207,189,21,127,199,129,178,252,221,144,31,2,252,31,39,63,193,246,247,125,69,201,147,130,228,25,247,18,251,110,69,161,85,15,205,58,94,182,94,179,73,89,48,226,199,78,35,251,206,21,44,142,139,93,22,180,26,84,178,233,201,49,158,85,114,184,213,238,96,71,160,181,108,116,250,99,223,192,157,150,170,221,22,205,106,139,166,227,174,161,203,219,158,221,222,193,124,203,203,252,12,215,245,175,56,229,74,217,169,184,31,186,21,105,192,156,12,113,224,218,146,96,78,109,9,214,57,62,201,39,214,9,158,205,233,28,87,55,20,70,216,166,57,240,54,111,45,113,234,189,99,40,191,116,117,171,168,238,59,1,201,190,216,153,183,246,158,53,229,248,35,77,8,125,63,117,14,158,189,35,113,55,5,155,3,122,113,4,45,74,173,48,165,62,236,23,116,124,167,137,154,14,118,201,245,74,103,138,182,94,184,89,246,229,211,184,185,203,136,207,9,207,190,122,73,134,73,63,62,128,229,72,11,24,235,59,47,163,242,234,111,120,232,39,124,201,246,40,197,60,7,43,83,5,116,2,46,218,241,83,191,233,119,230,57,12,115,212,7,196,75,91,26,248,204,74,85,237,220,208,27,151,224,208,209,77,224,114,17,165,226,70,145,53,129,218,61,71,32,187,112,167,233,109,23,151,55,132,146,168,226,211,168,98,71,19,255,130,70,128,86,120,94,53,108,222,37,81,99,99,64,57,191,97,212,63,90,118,52,166,139,84,36,160,192,248,225,119,115,45,213,71,111,223,54,18,98,14,92,171,91,221,114,2,217,218,195,26,169,61,135,53,156,179,212,174,218,54,65,94,136,57,6,92,148,150,122,59,89,62,174,252,162,12,37,67,71,113,247,28,131,202,45,45,109,20,121,35,34,52,195,83,88,237,242,109,223,179,241,33,212,205,90,217,122,23,173,182,119,58,111,228,177,226,219,220,6,61,249,210,90,221,155,168,107,202,45,235,154,85,153,219,190,27,15,75,63,193,213,77,188,119,197,140,52,183,254,226,217,218,229,252,198,139,159,129,248,140,161,111,106,242,177,110,216,135,69,211,48,4,154,248,71,142,182,185,148,12,183,132,180,27,156,89,50,8,99,141,230,142,43,124,180,181,237,89,108,248,115,200,12,90,105,23,251,206,182,107,170,215,193,44,242,13,130,89,127,200,89,107,128,202,53,128,225,122,223,147,56,255,247,8,137,125,185,62,163,4,249,113,62,75,48,30,23,22,90,125,136,85,198,181,95,255,0,31,36,216,40,201,241,189,243,57,130,105,168,186,63,71,224,44,179,62,71,144,98,131,252,56,203,75,86,157,104,41,93,199,4,82,77,235,36,69,159,20,216,231,0,22,41,8,116,163,121,23,117,127,203,20,217,166,244,55,30,33,148,26,188,175,43,140,214,197,26,156,247,211,224,46,160,119,109,175,211,153,46,220,228,168,61,123,58,119,111,227,245,53,26,243,126,28,44,220,201,4,178,155,214,225,247,254,255,110,230,49,238,239,138,174,55,79,9,175,102,67,104,87,43,188,229,105,26,92,95,255,0,173,201,127,46,192,190,161,242,176,63,21,81,99,246,208,195,63,206,9,126,29,23,48,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0026dc01-7a4e-45d4-b5e7-e879067fbf5e"));
		}

		#endregion

	}

	#endregion

}
