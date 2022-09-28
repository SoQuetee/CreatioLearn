﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RightsServiceSchema

	/// <exclude/>
	public class RightsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RightsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RightsServiceSchema(RightsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10bb4f79-5b92-47ce-b685-8e404e4984b9");
			Name = "RightsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,92,91,111,219,56,22,126,206,0,243,31,184,46,80,200,128,71,121,79,19,23,73,154,105,51,104,211,34,110,183,15,197,60,40,18,99,115,71,150,188,36,157,212,91,244,191,239,225,85,148,68,201,114,34,167,42,208,62,20,17,117,120,206,71,158,43,41,210,89,180,196,108,21,197,24,125,196,148,70,44,191,229,225,121,158,221,146,249,154,70,156,228,89,120,77,230,11,206,102,152,222,145,24,255,254,219,183,223,127,59,88,51,146,205,209,108,195,56,94,190,168,60,67,239,52,197,177,232,202,194,215,56,195,148,196,53,154,25,142,215,148,240,141,231,133,20,243,46,79,112,218,250,50,60,5,17,119,18,97,59,221,103,124,83,35,128,54,32,98,12,58,207,120,196,113,65,224,78,194,114,233,242,118,223,208,134,30,20,135,175,206,26,95,253,25,197,60,167,4,179,70,10,23,56,40,129,83,232,225,35,22,248,155,241,137,183,111,56,95,133,167,55,76,178,16,170,0,66,32,125,70,241,28,158,208,121,26,49,118,132,42,170,5,130,195,195,67,116,204,214,203,101,68,55,83,253,124,138,238,241,13,98,138,10,173,25,78,16,207,209,50,202,162,57,70,84,178,8,77,215,67,167,239,23,205,216,140,228,111,209,118,202,86,87,152,3,248,21,232,238,134,164,96,4,215,248,191,107,66,241,18,103,156,5,238,131,152,7,116,130,182,116,17,84,161,110,72,198,66,200,106,125,147,146,24,197,98,144,229,49,162,35,116,22,49,172,159,38,232,242,26,71,201,251,44,221,184,214,0,28,190,201,201,176,211,245,14,243,69,158,192,132,125,160,194,230,212,84,29,172,212,131,228,120,13,78,4,179,140,209,197,87,48,109,142,141,129,191,95,97,229,70,193,169,212,195,177,130,243,6,167,240,98,10,147,90,33,83,84,99,36,188,236,224,192,37,214,51,173,31,78,208,107,204,75,67,83,47,130,241,11,217,243,46,130,14,6,211,9,202,240,125,9,166,33,227,116,163,69,29,52,64,9,92,177,186,215,119,20,71,60,94,160,224,226,107,140,87,130,10,97,3,249,192,72,5,99,230,215,235,236,35,89,98,75,22,96,195,65,254,79,49,95,211,204,226,148,175,190,235,153,199,89,162,38,191,81,19,57,135,40,131,19,245,190,106,183,178,225,90,242,103,40,202,16,201,24,143,50,48,128,252,22,241,5,6,90,140,81,76,241,237,201,200,157,228,209,225,20,241,205,10,135,150,167,107,208,160,113,45,20,149,52,211,164,10,61,37,122,152,210,231,84,12,216,64,96,228,101,83,8,132,138,192,83,192,99,215,130,228,148,206,215,194,188,131,17,56,28,133,23,153,138,169,163,9,250,84,106,24,143,119,155,55,233,27,45,147,246,204,252,155,136,63,237,99,209,46,95,213,168,93,10,228,62,162,226,69,88,239,133,170,68,232,175,217,251,171,9,122,230,231,252,172,65,49,178,69,205,51,155,158,251,88,134,53,200,165,17,121,160,28,153,14,179,117,28,67,120,64,127,212,113,59,127,78,12,249,197,215,119,64,45,98,163,238,96,8,212,180,24,110,39,232,54,74,193,57,143,15,13,110,193,224,139,117,63,55,106,30,124,129,152,126,153,221,229,255,224,64,105,18,186,143,62,188,159,125,20,230,64,201,71,188,92,165,34,20,65,235,249,2,199,255,156,71,217,249,34,202,230,248,52,89,146,204,242,124,77,163,140,99,60,146,88,15,206,242,100,51,227,155,84,116,3,254,26,181,109,13,63,211,104,181,194,201,4,137,224,138,25,255,51,167,203,136,151,136,85,83,248,23,203,51,197,211,4,152,118,90,25,165,77,152,6,139,23,249,171,3,238,192,27,23,23,221,34,162,246,66,69,29,118,146,230,58,150,215,87,36,23,116,191,0,149,0,2,17,87,132,179,66,116,204,80,44,25,35,136,24,82,219,88,166,5,225,137,115,197,189,139,33,139,136,93,68,241,123,194,23,226,105,157,242,112,191,70,243,65,129,190,48,152,173,217,160,93,236,70,91,205,190,205,167,148,125,59,141,163,26,152,27,83,118,57,227,78,75,25,56,236,40,106,187,17,185,81,4,149,99,202,83,71,208,85,68,163,37,202,96,73,112,50,138,74,62,113,153,140,166,151,137,101,115,124,40,73,91,122,126,202,8,191,76,216,104,170,1,56,157,229,191,195,237,124,192,141,180,106,44,151,103,205,8,126,69,127,209,10,69,87,67,200,71,93,195,189,118,196,46,62,139,30,30,238,155,128,6,175,215,36,65,85,227,155,32,209,252,229,111,228,218,214,4,221,228,121,138,10,51,233,47,61,52,162,171,3,43,35,114,192,108,117,124,16,194,30,150,32,92,47,209,12,102,241,2,47,163,79,194,79,117,44,66,76,54,161,117,70,64,151,136,36,80,77,146,91,2,163,219,193,123,47,50,168,66,105,116,147,218,202,89,190,23,76,185,195,146,117,118,100,136,152,122,172,192,145,162,44,231,117,56,79,159,255,64,21,13,17,156,253,4,89,175,5,189,114,167,170,141,192,194,183,80,236,177,32,153,150,237,88,45,229,26,220,107,199,180,169,151,133,110,238,108,3,92,199,218,232,97,187,229,214,1,230,88,237,234,194,105,61,201,200,48,108,247,215,85,206,136,92,24,78,203,40,80,59,139,95,233,178,45,93,126,48,147,186,155,243,63,209,82,105,27,106,229,244,214,184,38,136,100,28,25,59,217,127,146,180,48,28,4,86,250,35,179,162,101,52,128,244,56,154,158,250,114,97,71,111,189,194,247,118,48,232,46,74,215,120,216,137,240,129,46,49,172,124,88,246,144,122,170,41,138,79,165,98,191,235,236,51,1,90,132,173,121,208,113,168,174,73,176,150,253,126,68,194,163,56,206,105,226,89,23,26,94,191,242,148,215,45,95,225,20,243,159,104,51,175,5,111,160,87,114,214,20,250,75,72,109,82,11,113,91,253,229,26,47,243,59,204,244,118,15,186,133,101,74,45,31,13,32,253,236,176,58,27,66,102,81,202,105,94,101,13,61,169,180,227,127,216,58,171,191,132,178,5,93,251,162,106,183,28,82,143,181,187,70,255,238,91,137,226,255,98,109,212,173,79,156,39,170,79,55,242,4,179,152,146,149,179,132,106,237,250,43,31,137,214,79,43,134,105,165,250,31,220,22,163,15,164,242,83,99,136,19,52,83,164,194,20,236,131,48,32,251,224,152,71,127,137,202,139,172,0,165,208,40,24,174,252,173,94,170,162,0,67,185,97,202,172,107,154,111,225,194,76,255,80,19,36,68,100,60,34,153,24,103,177,210,210,241,127,247,138,238,148,210,104,35,18,145,21,15,213,93,75,238,113,160,64,238,2,221,106,56,76,156,53,33,81,74,254,135,19,148,223,252,7,199,92,101,38,200,101,105,194,60,46,67,178,132,196,145,24,57,211,109,128,98,169,108,216,14,204,235,59,152,82,72,239,75,241,204,96,182,201,109,213,117,246,148,7,7,238,58,62,144,79,92,184,53,84,108,143,87,0,0,83,121,208,114,146,56,223,226,59,156,14,71,17,141,16,25,106,27,64,160,21,168,170,203,43,112,81,163,37,121,34,104,151,35,68,230,116,142,91,102,180,139,46,100,238,73,99,202,78,20,230,225,168,74,79,185,23,101,143,250,128,216,20,84,149,113,30,101,74,154,79,43,174,66,156,227,89,82,171,10,86,120,177,92,169,67,152,230,72,86,139,217,81,231,239,147,202,33,164,240,45,137,171,38,2,77,102,14,44,142,9,226,116,109,14,129,201,207,11,139,136,25,66,224,26,184,66,158,183,56,65,104,71,62,70,39,39,157,8,139,89,116,100,86,231,101,84,116,253,28,81,145,25,181,242,71,158,131,107,35,224,130,179,24,95,229,96,86,235,44,25,237,201,236,47,18,194,135,110,244,5,198,254,67,208,191,60,102,47,228,109,51,122,244,178,69,159,232,168,238,4,253,171,78,156,47,29,186,234,10,140,191,84,87,82,157,168,63,134,91,27,84,241,49,212,8,189,174,215,137,177,130,21,37,162,184,63,207,211,245,50,251,183,248,12,177,159,130,161,14,201,193,34,206,190,138,234,50,240,160,233,191,150,176,25,97,56,26,45,92,210,130,123,26,157,137,116,232,243,81,183,170,112,84,215,93,107,54,177,62,101,69,241,99,74,138,198,154,162,107,81,161,171,138,74,109,166,108,69,158,11,127,155,199,98,57,44,118,17,213,182,68,48,42,223,28,1,75,30,21,19,102,207,219,135,213,2,101,236,59,127,191,215,88,106,231,74,89,209,32,211,96,21,163,207,245,244,226,183,110,234,236,193,190,119,11,138,139,196,53,10,209,147,36,136,100,109,236,31,229,170,36,41,28,242,105,61,242,7,185,100,179,79,118,118,74,227,149,79,232,150,90,100,39,239,108,189,241,130,5,181,177,112,152,10,253,177,73,28,76,191,17,31,137,18,177,179,70,17,134,74,12,39,33,122,47,206,175,223,19,249,41,72,51,144,251,98,28,127,229,6,64,199,253,192,194,14,70,83,165,47,249,98,203,25,166,154,217,219,206,36,105,239,74,216,21,190,87,167,41,196,128,190,18,198,11,215,5,236,16,137,26,55,32,47,250,159,165,190,119,11,139,138,121,160,129,83,64,107,138,151,158,112,166,207,236,74,173,185,129,83,79,125,45,230,92,100,156,240,141,178,133,119,242,198,161,140,62,151,250,58,215,217,70,72,171,237,60,237,30,139,159,50,38,138,208,84,154,0,123,208,242,20,212,151,37,187,70,72,213,171,67,132,84,132,47,74,197,134,39,161,40,178,109,43,52,29,28,95,150,2,148,110,60,66,129,29,141,9,187,47,31,26,64,149,9,56,209,243,42,151,96,128,79,8,118,128,41,31,141,39,218,128,96,148,138,70,85,161,70,246,209,126,131,119,169,168,178,135,102,193,49,206,54,15,205,122,162,119,7,141,10,178,23,53,177,110,45,0,130,91,151,224,77,21,131,167,166,111,221,134,236,180,168,127,254,220,7,177,235,222,164,44,128,186,247,239,211,206,62,173,18,8,200,141,118,230,41,170,131,186,9,236,197,3,182,32,83,19,243,36,246,223,243,170,65,110,40,14,109,205,240,138,200,176,15,142,33,79,115,168,108,54,69,53,196,143,88,65,40,6,197,118,170,190,189,237,151,28,60,52,223,149,214,30,117,72,219,214,34,53,148,225,105,226,219,7,152,244,22,124,252,23,199,43,40,246,97,135,114,119,244,167,178,67,7,241,163,237,176,216,27,30,178,29,22,40,119,177,67,209,171,79,59,44,80,244,110,135,14,192,1,89,225,91,88,108,29,59,208,164,1,186,80,141,249,113,145,101,74,91,152,230,227,126,223,155,205,37,233,142,88,43,175,95,213,204,74,18,135,163,25,185,250,42,131,11,234,103,219,155,119,152,37,25,17,191,30,195,177,142,37,151,26,180,56,16,111,15,248,168,243,241,69,97,251,96,117,170,99,89,226,253,101,173,100,173,140,163,60,4,7,187,31,180,11,214,1,90,183,162,203,164,95,219,128,229,79,186,81,183,195,7,228,179,119,57,76,180,11,45,112,230,214,158,238,81,154,18,2,228,26,130,150,234,236,221,125,213,213,102,73,118,89,154,22,211,123,244,20,107,246,97,70,80,145,60,97,210,61,24,77,232,20,63,40,209,238,171,141,161,84,26,122,125,203,226,213,153,57,96,124,145,205,73,134,69,216,116,183,89,106,95,234,132,111,134,31,34,202,112,160,208,140,39,181,130,66,191,183,88,202,254,37,10,7,61,212,111,40,8,2,8,26,99,7,226,115,36,91,26,62,107,134,246,71,22,108,130,149,43,227,93,251,232,75,173,15,23,111,235,204,29,196,23,125,30,45,222,57,86,180,3,128,82,175,239,251,112,173,87,56,219,12,215,187,144,31,100,243,73,7,109,178,143,221,135,12,61,66,247,84,123,56,55,243,6,50,241,50,201,212,240,237,180,77,236,187,119,7,28,207,215,140,231,203,42,223,214,146,125,130,70,118,174,39,166,44,24,53,92,73,237,69,45,62,144,195,83,142,127,42,107,5,123,163,134,52,233,156,230,235,213,10,254,82,47,69,39,230,87,223,227,234,134,38,196,14,84,31,74,63,188,61,233,94,239,111,168,107,60,42,100,56,103,188,229,152,6,114,79,207,132,198,70,184,198,18,112,185,249,92,94,74,40,189,155,117,12,161,190,186,163,89,124,149,247,196,135,100,159,234,27,224,225,252,186,210,106,234,178,139,157,199,232,162,224,90,176,123,138,153,30,80,233,112,233,236,115,153,219,50,165,189,222,42,116,173,0,168,112,139,203,55,110,224,75,110,202,51,190,189,46,47,118,212,18,139,165,190,9,87,2,231,221,85,43,110,227,144,204,3,78,74,136,235,35,66,250,2,140,254,92,232,252,82,232,129,159,186,58,194,142,54,229,252,156,168,237,111,190,53,140,183,136,116,1,234,211,26,197,92,201,173,64,103,241,239,97,225,219,204,43,24,244,110,242,111,228,121,20,12,150,56,28,67,55,49,165,192,102,66,73,170,30,183,7,246,210,55,112,224,99,167,202,48,116,57,237,235,83,145,74,239,3,138,32,219,2,72,129,185,249,164,39,68,147,184,40,91,220,112,162,154,91,63,19,121,35,195,181,91,127,61,108,167,158,153,91,146,6,152,136,43,30,152,7,53,140,210,35,11,202,202,166,188,249,65,197,98,102,74,133,125,209,207,187,7,95,19,214,175,161,157,231,171,205,208,150,183,178,144,47,128,53,46,175,88,190,166,49,182,63,111,194,35,58,135,149,107,79,219,121,82,126,105,97,237,90,177,149,108,133,186,106,169,252,88,177,106,45,55,126,255,63,92,79,3,111,160,94,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10bb4f79-5b92-47ce-b685-8e404e4984b9"));
		}

		#endregion

	}

	#endregion

}
