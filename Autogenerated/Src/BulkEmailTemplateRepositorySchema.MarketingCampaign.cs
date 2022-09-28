﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailTemplateRepositorySchema

	/// <exclude/>
	public class BulkEmailTemplateRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailTemplateRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailTemplateRepositorySchema(BulkEmailTemplateRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("881e0902-637e-4875-a1ed-c77ee0acb019");
			Name = "BulkEmailTemplateRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("633119c1-eb92-42a3-a09d-15ece666869f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,90,221,115,219,54,18,127,102,103,242,63,96,116,47,210,140,135,190,231,218,146,199,182,156,84,153,38,206,89,238,245,161,147,185,161,41,200,226,133,34,21,0,116,162,203,248,127,191,197,39,241,69,138,114,218,203,245,161,173,193,197,238,98,247,183,139,221,133,170,108,139,233,46,203,49,186,199,132,100,180,94,179,244,186,174,214,197,99,67,50,86,212,213,171,159,190,189,250,41,105,104,81,61,162,229,158,50,188,61,243,254,6,250,178,196,57,39,166,233,27,92,97,82,228,1,205,60,99,89,176,248,107,81,125,110,23,109,5,182,219,186,138,127,177,84,75,231,251,42,219,22,57,44,50,92,177,99,233,211,119,245,10,151,52,190,141,224,174,245,116,126,213,249,233,166,98,5,43,176,197,243,61,254,194,192,46,156,226,45,5,21,212,145,225,251,223,8,126,4,165,208,117,153,81,250,51,186,106,202,79,55,219,172,40,239,241,118,87,102,12,223,225,93,77,11,86,147,189,32,223,53,15,101,145,163,156,83,247,19,39,223,196,6,35,224,117,129,203,21,72,248,64,138,39,32,149,31,119,242,15,52,191,14,89,156,183,139,194,68,51,244,47,22,16,157,41,33,184,90,73,57,174,80,176,49,101,164,201,129,148,139,22,202,75,138,211,211,83,116,78,155,237,54,35,251,153,94,88,84,96,183,172,44,254,131,41,170,240,23,84,192,238,172,2,84,214,107,196,54,88,30,59,53,219,79,253,253,231,187,140,100,91,4,238,197,211,81,67,49,1,249,149,196,228,104,246,27,252,141,114,179,96,152,167,231,167,98,155,224,162,236,219,99,217,241,111,14,95,228,138,153,32,30,39,73,226,17,77,61,50,142,140,228,185,223,118,31,72,189,195,132,227,200,115,90,212,116,157,167,139,91,75,59,222,211,211,251,243,27,122,196,236,12,29,163,168,229,98,101,203,167,130,176,38,43,7,98,44,70,165,108,10,186,160,169,208,62,73,34,80,68,23,23,104,28,91,159,202,45,9,71,212,32,37,60,23,79,38,67,220,245,14,179,77,29,4,88,212,87,119,152,53,164,162,72,235,138,182,92,44,122,216,35,204,49,135,138,21,228,165,98,93,96,50,20,235,15,26,175,139,213,104,118,227,51,177,1,46,182,18,169,192,12,108,0,30,202,164,124,32,211,235,241,212,32,140,131,222,96,54,207,157,165,241,155,166,88,33,75,5,29,4,79,25,65,196,152,249,118,39,238,6,136,5,233,136,214,1,119,56,91,169,175,190,47,78,36,33,215,82,1,68,178,78,90,55,154,189,192,217,118,175,94,79,111,190,230,101,179,194,138,205,47,108,91,170,212,47,56,61,11,231,38,242,232,81,124,164,156,215,21,104,153,215,100,181,88,141,173,147,158,132,231,115,192,210,235,126,162,172,79,112,94,236,10,208,7,226,183,129,127,83,204,239,209,161,174,87,92,22,43,58,210,254,164,224,124,138,50,184,147,246,125,190,151,90,156,83,12,137,149,224,245,116,180,20,130,71,167,51,36,255,175,3,17,242,35,7,130,73,147,119,250,8,74,131,107,126,16,73,39,208,241,199,71,212,234,105,195,67,158,85,97,66,109,240,162,79,250,155,151,23,205,182,26,143,12,30,0,234,222,183,215,77,149,167,66,244,120,196,191,78,210,75,58,30,25,221,196,23,179,231,53,169,183,227,81,231,9,12,221,239,27,76,176,39,54,93,84,99,41,51,253,192,173,139,25,38,116,108,157,80,111,126,67,234,102,119,181,247,182,35,240,144,60,171,196,158,114,248,114,7,58,172,247,239,235,95,235,252,211,47,69,197,232,120,226,128,147,182,123,158,221,251,251,169,134,8,156,195,103,134,173,19,73,188,3,120,185,118,125,65,186,18,59,117,100,138,63,58,188,32,172,198,129,87,175,199,29,146,38,174,229,250,137,211,43,75,35,176,43,189,249,12,119,69,96,92,59,230,84,58,78,164,210,16,221,56,111,64,223,73,167,93,22,21,28,133,117,217,225,4,57,26,201,36,183,81,71,113,19,153,200,66,25,253,4,134,82,4,233,93,187,122,230,147,2,16,154,135,165,6,248,53,193,50,171,200,79,10,235,126,46,209,204,212,25,185,63,164,250,190,63,0,130,172,30,234,137,37,102,199,248,225,4,245,219,127,56,87,11,246,147,147,136,93,142,96,181,132,123,23,19,241,37,166,224,38,66,118,52,247,247,64,116,152,185,160,58,134,119,243,240,111,126,214,62,198,138,228,8,174,31,8,150,187,251,248,26,34,94,28,65,37,14,189,72,122,179,221,177,189,145,212,27,62,10,188,113,232,134,129,4,41,203,193,112,24,61,110,72,12,205,249,202,18,6,76,112,98,127,41,181,112,105,231,168,118,143,254,186,0,33,228,109,93,88,108,245,149,175,105,146,244,54,20,154,182,116,173,172,196,100,172,144,153,165,164,94,179,181,116,178,163,69,162,203,140,193,217,80,241,187,172,86,161,206,194,13,61,140,108,111,5,215,146,186,117,66,215,13,174,112,118,6,126,107,240,137,0,139,42,113,77,233,155,139,214,124,104,177,163,183,201,134,94,151,186,62,179,239,170,119,101,148,240,234,70,187,4,130,72,6,221,88,125,115,181,208,48,47,214,72,17,128,189,223,55,101,121,75,68,168,141,61,114,77,175,237,91,1,169,52,248,179,9,23,189,133,15,11,32,80,222,222,138,244,192,29,71,177,207,207,113,150,189,241,143,145,209,252,30,127,101,163,143,23,233,63,179,178,193,231,82,203,89,111,204,187,213,157,157,121,236,240,167,117,67,114,124,101,39,1,177,206,50,242,104,49,112,171,141,227,107,62,70,30,181,51,70,39,104,164,67,196,175,255,56,157,46,223,128,44,66,160,242,34,255,170,82,110,31,137,201,158,189,124,204,157,112,152,74,24,195,171,64,219,208,31,201,122,149,146,188,93,9,146,86,72,111,27,103,194,51,215,33,115,37,221,249,32,244,91,84,3,83,35,107,133,219,5,46,223,62,129,242,131,17,105,83,195,55,59,169,198,79,235,202,178,60,28,61,171,43,203,197,67,76,150,204,155,30,33,79,135,221,42,203,175,161,170,29,225,162,20,223,152,191,110,93,100,120,141,69,92,166,101,28,213,143,120,54,110,125,220,237,220,32,88,181,115,7,183,35,140,52,248,80,75,114,120,62,114,104,10,168,111,143,118,130,65,249,0,144,226,182,188,16,11,226,38,249,31,77,72,108,93,116,99,237,220,30,114,214,165,122,93,72,158,16,240,108,158,27,215,246,247,95,152,126,86,233,80,140,142,247,203,124,3,135,251,71,131,131,113,99,106,19,188,203,170,236,17,147,19,233,197,190,94,86,250,12,196,0,58,230,5,101,69,37,18,48,247,103,208,182,72,220,192,87,78,126,185,90,5,141,119,202,97,214,114,124,93,148,188,253,229,164,99,254,183,172,22,229,234,239,5,219,88,29,178,92,188,174,183,96,237,2,110,168,251,253,14,26,56,142,86,125,134,88,185,101,74,34,0,122,164,15,148,87,10,88,91,111,109,31,34,212,33,192,29,210,108,237,23,255,194,241,64,29,229,150,170,187,138,162,233,12,241,55,14,198,245,87,246,145,55,43,119,242,108,236,24,50,149,237,66,122,95,95,114,220,140,135,204,135,114,92,60,97,0,90,89,134,128,55,87,252,95,140,124,161,45,151,74,236,162,137,198,113,223,206,120,237,97,157,140,4,19,5,253,49,32,103,160,211,216,124,209,222,113,102,106,45,177,225,66,119,224,224,148,169,40,165,130,242,74,15,27,91,181,254,254,209,174,183,20,157,172,9,53,183,35,220,37,198,74,84,188,79,84,205,246,1,138,93,97,52,21,130,20,173,107,8,240,44,223,180,101,170,178,232,75,38,124,129,87,172,196,212,237,203,121,33,0,12,18,208,23,136,72,165,39,237,82,84,235,23,117,117,203,75,160,93,116,125,179,195,195,192,254,49,32,177,40,77,123,56,116,192,104,177,108,51,130,24,165,90,231,86,179,173,152,242,122,202,38,159,234,198,98,32,246,32,251,98,176,200,20,5,25,152,54,4,207,175,218,165,177,93,211,251,234,233,14,251,78,182,16,68,246,67,83,51,200,78,60,77,69,30,149,84,60,197,132,217,197,173,24,84,226,228,146,99,91,196,249,130,17,168,58,112,242,60,137,4,130,167,207,65,252,47,51,158,171,56,252,53,38,245,244,225,37,9,234,30,248,88,125,98,95,166,138,196,136,174,185,4,27,95,157,200,59,159,152,15,242,3,116,79,7,23,55,16,45,152,100,15,37,62,15,39,133,51,228,74,214,64,248,51,176,212,110,76,151,80,152,179,123,146,85,52,83,84,202,131,204,188,142,37,73,255,252,55,76,162,73,2,17,47,2,94,232,169,204,4,33,209,113,38,248,199,29,165,58,118,210,35,83,205,251,89,253,215,58,5,127,208,47,162,199,120,70,121,198,64,145,111,225,166,59,184,127,31,178,252,83,108,91,194,54,164,254,162,121,180,80,238,131,43,4,200,15,65,171,78,165,209,164,122,8,100,160,244,144,57,254,119,214,145,232,208,56,185,45,250,128,219,229,106,91,84,119,197,227,134,241,151,183,117,86,82,108,149,153,143,21,96,11,74,77,184,241,246,34,21,209,160,222,220,66,35,117,184,216,148,237,150,85,234,201,190,189,107,163,105,235,219,29,102,10,213,181,199,234,243,157,146,82,119,236,157,178,236,166,222,223,201,203,190,254,141,114,102,16,121,54,56,166,2,23,110,247,157,45,235,236,5,20,28,250,241,251,229,133,57,106,251,10,175,254,238,104,1,186,149,9,84,254,238,74,221,103,163,75,244,175,252,130,229,113,16,121,219,81,57,70,1,5,4,127,141,150,242,122,72,230,224,77,22,243,234,206,109,135,235,135,120,120,8,116,184,88,32,58,172,139,143,73,135,147,245,22,213,201,73,212,3,109,224,69,52,225,43,3,21,105,33,30,211,99,177,234,100,227,180,73,26,239,146,135,76,226,135,171,110,147,198,87,120,157,53,37,51,215,151,152,52,27,200,254,208,172,46,24,218,208,227,189,141,84,247,71,100,243,182,178,136,103,111,229,190,238,212,45,125,51,56,21,235,38,46,146,146,221,17,118,247,86,53,231,255,161,105,89,230,24,153,76,221,36,229,121,33,150,29,173,38,52,64,67,144,136,90,73,23,127,66,74,138,190,96,12,21,225,58,72,205,48,162,25,107,176,210,189,185,203,201,61,199,177,244,179,144,133,210,103,247,135,104,188,216,191,174,119,251,222,159,72,28,253,164,161,250,85,26,111,91,35,47,39,17,9,33,243,22,127,133,168,185,85,38,144,5,120,252,209,68,254,36,160,123,14,173,6,200,252,109,121,100,137,242,135,208,214,219,136,243,6,226,190,117,244,188,105,232,99,202,23,126,53,176,17,122,199,95,155,189,137,177,92,245,22,189,159,201,134,215,186,160,242,111,10,57,77,131,219,151,138,1,199,252,254,150,143,60,204,77,1,29,25,115,83,125,108,68,19,220,30,206,111,112,35,5,198,207,65,168,191,10,126,141,219,245,155,201,238,187,174,230,25,204,107,93,248,69,222,245,3,79,169,36,127,146,183,235,2,245,139,78,106,253,172,243,56,145,7,127,155,104,77,194,81,91,9,68,228,254,31,186,253,176,187,255,74,207,202,116,38,174,237,126,219,170,103,104,43,103,190,200,173,74,94,223,51,74,76,160,76,252,47,6,146,180,184,186,194,134,137,85,23,228,119,138,52,69,248,32,161,237,77,250,50,232,194,218,127,1,205,3,223,8,85,49,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("881e0902-637e-4875-a1ed-c77ee0acb019"));
		}

		#endregion

	}

	#endregion

}
