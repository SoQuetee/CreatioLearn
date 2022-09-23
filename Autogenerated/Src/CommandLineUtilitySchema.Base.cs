﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CommandLineUtilitySchema

	/// <exclude/>
	public class CommandLineUtilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CommandLineUtilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CommandLineUtilitySchema(CommandLineUtilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("044ffa1d-45fd-4ef3-8658-4d94c51803c9");
			Name = "CommandLineUtility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aefc4b1e-afcc-4b90-8ad4-857733948a5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,107,111,219,70,242,179,2,228,63,48,42,80,208,56,133,184,4,9,210,216,113,10,91,126,156,175,118,236,70,73,239,67,16,20,12,181,182,217,82,164,74,46,147,168,134,255,123,247,197,229,236,139,92,74,78,131,43,242,33,173,180,59,239,157,153,157,217,93,185,174,210,252,42,152,173,42,140,22,59,247,239,213,224,107,52,45,178,12,37,56,45,242,170,99,42,58,70,57,42,211,164,11,228,252,195,111,228,227,89,49,71,153,14,118,16,227,88,31,59,57,215,71,78,211,252,15,125,236,13,250,140,109,99,209,107,116,85,103,113,121,248,121,89,162,170,178,137,255,26,93,10,217,228,204,27,84,150,113,85,92,98,34,248,98,209,49,17,253,183,114,204,150,200,49,28,29,236,187,102,14,115,156,226,20,85,174,249,139,178,72,136,18,61,211,228,75,126,153,94,213,101,236,212,137,0,207,48,20,81,152,226,56,43,62,196,89,250,167,134,57,83,40,6,187,10,45,149,215,253,123,121,188,64,213,50,78,144,11,234,254,189,155,251,247,70,203,250,67,150,38,65,133,201,88,18,36,89,92,85,1,181,105,156,207,201,250,162,183,56,205,82,188,34,128,20,120,244,93,137,174,40,107,66,136,96,228,184,218,14,46,24,1,58,73,255,169,228,74,20,207,139,60,91,5,199,117,58,15,102,68,132,159,208,138,224,226,56,193,39,115,162,64,142,62,177,185,112,252,248,241,244,233,211,39,255,158,62,60,120,190,255,232,225,147,231,135,71,15,127,56,220,127,246,240,217,227,39,143,158,239,63,251,225,240,233,179,233,120,107,167,225,243,29,202,231,92,22,57,34,68,35,214,95,162,146,46,31,145,173,76,63,198,24,81,115,16,209,248,151,70,182,183,21,42,137,40,57,119,57,253,235,77,112,133,240,78,80,209,255,220,90,241,79,211,10,191,16,150,122,217,154,172,194,1,179,212,104,68,8,52,31,71,37,194,117,153,7,167,69,60,23,144,85,200,149,25,141,110,217,255,58,152,92,196,101,188,144,156,224,55,127,118,12,203,143,231,65,202,76,16,151,171,23,116,105,38,108,129,94,6,191,226,213,18,17,114,89,189,200,219,52,178,227,79,224,141,13,159,162,115,169,129,252,233,101,16,218,217,5,187,196,103,234,44,219,146,170,186,224,152,107,217,37,145,86,24,125,140,203,0,224,31,206,126,22,136,44,3,172,102,201,53,90,196,63,215,168,92,133,170,127,68,16,224,44,206,227,43,84,78,130,49,9,95,146,79,235,12,241,233,177,100,164,50,33,25,34,93,16,161,24,101,62,26,157,84,123,217,167,120,85,205,16,85,129,136,129,203,26,57,208,247,230,226,75,56,166,70,229,159,223,158,204,157,252,0,2,17,17,202,222,133,117,148,102,24,149,21,197,14,5,132,14,50,37,17,142,17,7,252,95,138,175,153,155,33,138,21,242,65,226,126,203,184,76,73,118,166,146,18,45,95,21,248,21,89,64,98,44,77,116,193,225,111,20,134,136,114,248,71,29,155,178,112,63,137,14,23,75,188,250,186,114,89,86,107,136,112,211,152,160,17,95,210,156,119,198,119,96,54,27,81,137,78,139,36,206,232,87,178,205,64,159,98,16,78,255,96,179,39,100,191,122,69,212,33,92,116,68,58,53,118,133,26,211,74,9,88,141,250,49,194,58,144,22,132,82,174,75,178,133,18,134,33,229,129,24,78,144,230,93,220,218,244,225,200,31,239,56,25,42,4,72,91,191,196,89,141,94,240,28,98,13,164,247,68,141,126,76,71,204,222,194,212,220,164,240,142,172,203,33,57,120,247,150,120,134,240,117,49,135,251,161,216,172,187,118,52,117,175,18,6,163,22,78,248,224,198,201,82,16,111,12,208,146,29,152,30,1,34,200,115,39,54,194,96,158,250,108,55,196,148,84,198,22,136,245,98,170,177,164,18,81,58,85,24,75,10,2,136,36,184,2,102,12,1,138,222,241,3,40,190,70,85,157,97,86,85,240,165,85,92,162,217,55,237,225,230,16,74,134,26,133,78,231,94,1,2,162,2,8,39,44,211,129,94,225,146,24,251,165,186,184,144,4,93,82,79,18,112,245,71,134,121,88,186,167,6,18,182,9,219,140,194,234,90,82,107,136,175,66,106,160,67,51,35,132,1,162,137,4,176,5,194,187,201,3,134,4,59,34,248,253,138,70,75,37,248,229,34,154,115,248,66,113,45,120,68,125,241,221,192,249,196,57,135,116,196,59,128,60,139,211,156,41,215,203,189,133,236,231,223,194,206,106,214,146,27,149,153,29,143,124,76,89,117,155,249,201,164,195,55,59,245,146,14,14,67,245,16,116,163,52,201,61,104,104,174,4,88,95,60,97,46,65,120,217,179,166,18,128,95,57,117,158,248,33,11,105,127,221,56,255,54,132,238,36,15,115,82,74,62,166,164,22,77,216,120,42,39,195,76,87,79,18,26,160,96,75,204,80,177,210,98,99,160,112,174,208,50,105,155,193,101,201,202,148,233,9,59,171,73,208,254,138,208,11,117,249,156,244,133,57,148,49,150,206,92,8,23,83,43,138,200,250,34,225,119,18,56,232,164,112,144,86,203,44,22,132,126,140,56,40,63,15,8,126,12,198,227,96,219,3,79,23,32,86,83,155,231,122,105,9,81,119,41,141,232,0,199,210,9,91,147,180,141,199,48,127,211,217,56,189,142,11,70,153,169,78,193,134,121,19,58,105,103,91,15,112,204,31,216,0,118,218,83,31,167,82,15,118,97,219,43,139,45,97,136,141,2,194,197,83,54,102,186,242,242,59,244,165,145,105,132,22,206,25,2,35,139,105,12,52,15,191,239,198,129,28,111,91,15,194,178,15,165,71,201,182,62,51,98,103,181,105,94,253,132,86,102,226,32,204,173,88,239,116,200,247,68,194,118,245,132,32,246,29,84,22,214,112,251,116,87,215,83,176,191,201,189,78,155,236,170,192,225,110,4,246,166,6,224,76,217,99,192,142,99,0,8,38,202,94,98,0,233,81,166,39,186,183,22,194,179,190,148,220,207,201,158,151,249,104,15,166,61,33,139,225,6,119,207,146,66,141,180,234,0,110,125,94,31,117,32,216,35,177,23,193,12,202,139,46,29,156,49,169,169,206,93,159,70,1,211,186,141,168,142,86,206,238,248,29,253,156,113,138,205,207,152,233,37,221,203,128,164,51,245,212,57,69,85,160,116,119,89,91,152,118,81,10,65,117,91,73,138,119,118,34,222,236,40,144,244,192,134,144,73,214,4,10,7,111,188,19,18,85,15,187,225,121,124,100,59,179,3,201,209,69,102,26,151,115,99,107,116,242,228,246,240,134,215,246,118,170,228,101,145,205,81,73,111,102,167,236,159,135,166,71,18,69,244,177,64,45,74,178,40,155,163,102,237,138,196,88,87,29,46,132,44,39,193,105,113,149,146,142,237,124,137,248,45,226,140,108,228,9,142,206,75,33,191,201,136,165,116,69,110,126,32,46,239,2,56,130,97,230,205,9,154,75,97,91,11,120,130,111,50,3,203,130,204,246,81,33,228,221,64,138,46,48,208,218,64,157,190,210,255,45,24,27,177,104,109,216,134,74,249,62,164,6,180,68,146,210,169,193,197,240,235,30,109,81,194,229,210,214,193,139,156,43,142,44,17,226,87,91,187,162,170,161,203,45,28,113,219,138,168,244,109,82,181,250,156,150,178,170,1,31,136,122,237,251,239,3,99,194,86,216,10,97,154,83,96,89,26,141,19,230,234,146,211,109,203,208,176,50,224,105,155,27,196,246,170,192,69,123,85,225,4,171,80,92,38,215,54,233,180,21,35,252,199,175,138,156,40,162,243,254,79,92,241,100,166,222,129,2,82,15,232,142,166,150,166,178,38,109,201,101,141,80,114,114,34,130,200,184,4,111,247,230,12,236,196,214,59,146,143,69,58,15,120,186,81,42,84,209,39,137,26,146,223,209,5,128,115,27,177,141,16,96,135,134,21,1,209,90,191,225,39,25,42,111,46,23,231,100,91,188,34,204,67,8,20,44,147,45,253,238,63,92,38,145,82,223,202,2,151,250,3,153,236,168,74,119,91,201,155,2,102,194,175,221,249,183,244,50,84,69,214,46,229,153,242,240,232,201,161,76,171,141,77,17,85,19,69,133,246,206,76,200,21,157,204,157,71,67,196,7,206,75,18,190,82,225,80,174,146,211,53,136,134,10,17,123,180,112,1,205,198,138,84,139,38,251,61,49,232,193,93,247,137,181,219,91,154,222,66,251,177,188,193,132,19,35,76,76,206,98,127,229,16,142,75,88,147,84,52,67,248,0,93,130,132,217,190,63,177,67,3,80,41,53,187,241,150,190,52,0,31,244,110,132,2,88,77,176,198,96,161,28,9,209,131,145,209,254,140,39,192,3,180,84,232,163,56,51,246,124,127,197,40,233,143,166,186,44,16,127,68,210,194,109,110,115,165,50,22,165,102,112,108,148,201,164,153,131,93,163,227,95,243,0,147,230,11,237,4,83,75,78,108,243,83,9,107,9,73,100,18,41,29,236,202,20,177,55,140,52,105,69,88,205,75,226,50,194,52,118,30,225,197,207,206,115,238,104,149,217,205,241,69,155,4,5,179,130,236,229,170,79,41,166,117,102,147,54,165,91,39,113,133,130,166,150,216,110,83,174,214,253,17,126,119,248,38,138,80,107,75,8,88,132,115,54,131,95,69,89,72,244,53,109,86,36,216,0,24,147,131,122,149,117,201,251,191,13,226,15,131,36,179,145,79,139,11,118,26,40,40,107,62,136,24,142,134,70,8,56,224,25,14,143,68,149,36,217,185,235,28,7,47,130,71,96,99,31,141,62,16,181,127,111,241,110,229,167,214,201,121,65,105,28,76,79,140,218,196,134,198,110,101,38,218,117,128,168,210,163,55,197,140,133,75,184,165,136,30,106,129,26,29,33,18,60,71,101,177,56,216,15,91,6,91,138,34,48,225,233,248,202,169,47,75,238,54,141,81,70,66,209,70,177,127,23,117,128,43,187,137,167,1,123,233,12,183,104,47,73,191,141,206,74,9,238,116,119,178,12,242,131,226,153,60,77,178,222,7,38,201,187,117,82,91,223,249,205,49,135,58,102,143,21,255,49,206,40,58,236,47,231,142,223,114,230,183,156,185,137,155,206,209,101,92,103,120,219,54,169,156,181,168,213,184,87,151,34,123,232,141,154,148,166,57,251,59,123,20,200,119,195,38,67,235,55,199,22,14,178,211,80,89,126,245,70,195,154,201,26,71,49,218,56,235,93,182,249,11,16,189,154,148,110,201,117,1,239,39,152,35,235,151,153,146,10,91,69,62,198,89,237,175,46,98,124,237,33,19,187,107,217,178,68,182,148,105,189,20,173,99,169,143,65,38,22,229,122,57,194,31,57,120,40,166,136,35,30,104,12,76,247,32,218,52,228,142,36,115,27,104,41,94,67,237,78,240,38,240,58,233,189,135,202,144,197,240,148,104,147,197,233,21,215,119,227,208,233,104,219,198,122,203,217,91,93,67,31,123,160,223,4,120,198,250,90,167,56,253,169,91,72,101,80,31,148,135,248,245,71,131,42,49,6,11,200,182,0,253,252,136,221,13,255,43,16,151,192,99,85,110,149,179,183,208,30,25,11,82,142,6,37,46,5,179,171,32,250,7,167,28,183,245,134,102,30,111,107,254,31,230,8,239,106,178,97,164,22,147,240,55,81,236,187,241,139,168,142,95,47,243,187,190,107,148,252,254,154,96,85,24,149,104,46,110,165,43,173,122,10,106,181,152,18,110,164,1,237,106,96,224,140,152,101,188,74,214,109,182,87,61,238,55,228,109,125,70,159,17,40,180,148,55,4,28,26,94,192,183,152,17,89,106,97,87,200,160,185,51,148,207,19,0,6,91,63,229,18,184,13,66,203,21,169,44,214,165,24,19,7,77,219,5,45,47,60,223,189,15,18,250,190,127,175,44,227,149,168,78,229,204,205,248,151,79,130,217,30,35,200,127,64,160,255,48,69,31,21,3,183,138,117,249,219,12,198,139,101,87,250,74,95,50,86,140,26,47,151,107,253,214,65,210,110,180,109,8,69,135,159,151,105,137,142,203,162,94,26,80,218,141,142,226,175,150,223,253,16,63,210,111,147,239,208,115,69,232,233,28,252,66,112,74,255,212,192,118,115,53,44,30,190,113,125,148,191,66,64,199,111,248,180,253,55,254,34,130,25,128,32,192,218,65,226,230,98,153,232,79,249,249,167,170,249,116,11,193,69,55,201,22,122,24,10,187,151,238,68,225,114,107,54,16,227,61,166,129,118,213,86,156,91,72,7,240,49,211,72,92,13,174,103,41,6,222,62,186,29,106,172,246,61,238,90,152,253,214,214,36,133,239,119,135,113,84,31,246,174,197,211,120,87,177,166,4,230,11,224,187,32,36,30,196,222,9,169,131,65,180,154,19,29,237,205,240,48,73,108,207,136,55,162,176,182,121,187,158,27,223,5,165,53,140,171,188,74,238,67,52,18,148,28,211,106,37,61,131,88,16,125,147,126,123,60,103,205,107,224,244,238,198,148,135,253,237,153,178,78,112,81,186,243,26,124,33,217,152,0,86,42,240,151,122,205,51,190,173,65,102,241,72,174,77,212,40,47,10,61,23,242,67,81,100,65,251,22,206,19,11,234,19,40,250,174,225,6,214,213,164,163,183,127,1,104,252,70,69,161,74,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("044ffa1d-45fd-4ef3-8658-4d94c51803c9"));
		}

		#endregion

	}

	#endregion

}

