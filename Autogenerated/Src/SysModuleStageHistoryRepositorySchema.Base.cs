﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleStageHistoryRepositorySchema

	/// <exclude/>
	public class SysModuleStageHistoryRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleStageHistoryRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleStageHistoryRepositorySchema(SysModuleStageHistoryRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("606c473b-83a8-403c-b3e8-30b26e3b8597");
			Name = "SysModuleStageHistoryRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,90,91,111,219,54,20,126,118,129,254,7,214,29,48,25,48,228,247,198,118,145,186,113,231,173,41,138,37,217,75,16,12,138,68,37,194,100,201,35,41,119,110,145,255,190,195,155,174,36,45,59,233,205,79,150,68,30,126,231,240,156,143,31,41,101,193,26,211,77,16,98,116,137,9,9,104,30,51,127,145,103,113,114,87,144,128,37,121,246,252,217,151,231,207,6,5,77,178,59,116,177,163,12,175,79,90,215,208,62,77,113,200,27,83,222,55,44,8,193,25,115,54,123,135,51,76,146,176,106,179,200,215,235,60,171,174,235,104,8,182,221,247,207,50,150,176,4,83,107,131,101,16,178,156,200,22,208,230,37,193,119,0,0,173,50,134,73,12,110,191,66,43,128,119,158,71,69,138,47,88,112,135,127,75,40,116,216,253,137,55,57,77,248,63,209,111,50,153,160,41,45,214,235,128,236,230,234,250,35,201,183,73,132,41,90,99,118,159,71,20,197,57,65,20,51,198,97,4,89,132,8,102,48,242,150,95,82,110,26,221,75,219,186,17,245,181,229,73,205,244,166,184,77,147,16,37,26,97,15,128,3,62,69,165,111,231,18,206,43,244,81,88,18,248,59,14,136,27,203,36,3,216,18,155,194,228,151,141,39,237,214,211,77,64,130,53,202,32,99,102,67,204,3,191,187,8,239,241,58,184,90,69,195,185,152,9,112,77,220,65,16,23,184,142,19,76,252,233,68,244,171,204,64,88,10,146,209,249,148,98,140,66,130,227,217,176,238,216,133,4,50,156,204,167,19,221,148,247,53,180,17,14,120,239,138,36,66,45,60,163,19,135,219,239,48,59,210,107,233,221,7,248,223,118,152,63,255,170,174,2,104,143,66,62,241,100,42,81,56,221,188,8,182,248,72,63,19,168,215,97,31,212,149,191,219,28,102,129,15,233,153,208,115,131,251,231,36,72,211,38,94,106,1,188,58,203,138,53,38,193,109,138,167,134,225,230,220,220,105,154,122,122,200,151,56,139,100,117,192,213,131,100,130,250,45,19,51,32,27,53,44,2,136,255,87,100,5,196,114,4,125,98,146,175,81,200,199,122,12,77,40,176,146,33,236,145,79,168,28,10,236,1,159,6,105,242,25,71,150,216,223,230,121,138,86,84,24,94,85,173,209,23,116,135,217,9,122,224,109,246,49,206,6,135,64,14,161,57,0,128,161,242,251,9,184,168,200,146,127,11,252,45,41,201,112,255,112,150,58,141,34,75,124,32,63,14,138,143,234,55,156,95,194,4,91,86,162,167,10,137,164,1,204,234,109,47,115,145,44,70,98,80,0,250,113,3,103,17,218,42,12,91,0,142,196,127,8,179,236,97,146,69,26,80,88,133,141,101,121,186,217,64,245,10,129,165,43,84,23,121,146,221,131,52,98,81,30,162,9,135,116,253,22,199,65,145,178,55,144,88,60,145,216,110,131,243,216,115,148,251,104,140,248,226,128,102,104,88,27,103,56,186,169,104,35,228,216,250,65,219,199,131,77,241,1,250,15,50,44,99,92,126,144,100,27,48,201,148,131,141,188,64,33,127,142,212,66,38,44,252,129,119,28,169,105,114,76,236,61,168,143,6,100,187,193,132,11,64,62,92,206,64,94,226,200,73,64,188,4,10,138,9,7,146,73,53,106,201,162,141,182,135,174,160,253,162,108,222,190,172,120,175,141,213,138,116,159,46,59,128,146,5,82,57,167,86,98,230,109,6,0,82,253,27,108,3,82,45,54,51,62,90,61,248,75,40,47,89,175,34,199,225,39,235,163,234,242,98,134,178,34,77,229,83,193,247,6,231,155,19,37,210,130,20,92,139,59,167,167,194,13,21,143,50,252,9,188,231,249,4,235,91,30,35,6,209,168,215,115,159,244,133,10,151,217,222,151,45,139,198,244,74,210,108,103,76,157,45,85,244,123,129,241,90,185,211,28,107,164,38,168,121,215,95,220,227,240,159,83,114,7,188,148,177,15,16,120,143,3,5,10,104,245,86,211,213,26,98,214,26,228,68,205,151,154,31,75,186,86,123,8,83,17,175,222,38,194,22,196,112,202,215,181,49,178,81,165,225,62,245,180,159,189,243,16,189,126,45,158,6,49,78,119,206,92,45,215,179,191,130,180,192,212,95,230,228,12,158,123,91,126,137,102,243,170,4,224,218,239,132,234,170,27,170,193,131,50,221,170,130,102,28,143,136,140,203,25,5,83,13,233,14,12,47,146,94,163,170,24,61,60,197,92,90,177,122,253,236,141,154,145,246,219,133,114,173,151,134,155,19,100,33,152,126,91,222,246,106,90,150,235,99,165,91,175,28,174,82,190,149,158,151,100,7,77,69,146,122,45,203,99,148,23,12,113,187,4,83,88,247,155,233,39,239,213,39,210,233,230,177,114,76,121,167,183,141,86,10,210,237,21,72,142,90,46,90,179,158,5,43,90,95,235,113,206,154,161,184,1,51,234,145,137,219,28,89,3,29,133,229,222,129,234,173,251,142,154,247,22,119,40,118,178,83,177,184,123,164,180,92,101,231,120,221,221,166,62,169,172,148,35,244,85,148,13,68,135,201,73,139,192,115,202,187,198,9,130,115,163,80,73,60,232,195,192,137,247,193,231,221,180,58,194,236,69,101,115,164,103,91,250,167,244,160,230,87,42,196,33,154,137,60,224,92,125,212,24,229,73,70,7,178,82,125,13,12,134,109,185,130,241,221,180,177,91,110,252,16,234,24,212,129,61,142,117,34,177,121,241,237,68,110,163,162,190,171,194,109,32,249,9,229,237,183,214,11,141,252,146,235,192,126,49,96,26,252,231,19,7,73,140,188,23,246,10,211,102,7,14,50,155,33,168,47,92,219,120,10,163,166,152,66,70,176,0,202,10,196,128,103,81,23,163,114,68,203,164,92,109,34,96,112,91,247,177,142,199,24,25,250,91,37,141,10,198,3,194,41,197,123,0,156,70,209,222,209,71,181,104,52,207,94,159,74,234,168,228,50,97,108,234,152,62,42,166,167,136,105,189,126,59,72,172,84,125,71,61,5,74,213,195,170,78,218,175,219,58,188,223,247,204,203,104,253,162,124,163,35,142,194,76,77,126,182,195,176,214,190,216,46,249,208,223,212,250,204,117,42,124,41,22,255,106,221,180,143,176,215,39,23,58,199,163,206,193,154,195,19,152,87,215,83,216,199,123,238,222,124,135,97,125,238,105,142,149,36,235,176,228,119,37,80,73,131,3,126,179,81,230,46,76,122,68,201,195,154,37,220,147,89,54,167,82,111,185,93,22,135,52,7,10,175,62,2,242,241,250,171,98,131,239,42,190,42,24,63,144,242,234,167,187,52,79,54,105,66,40,146,110,22,186,234,83,236,2,180,131,114,145,172,62,52,129,160,150,127,103,104,137,89,120,111,54,85,54,211,59,246,56,39,24,44,35,143,111,244,165,40,19,239,37,203,134,35,195,105,58,140,193,179,201,164,9,155,193,211,181,163,23,247,101,146,166,252,104,68,226,87,34,80,55,146,59,88,139,78,115,169,0,29,213,78,84,250,5,162,118,210,209,8,35,119,177,109,178,229,223,120,223,50,167,79,127,74,3,254,251,60,136,90,199,37,213,83,227,193,165,35,41,246,144,101,195,179,146,58,160,18,168,116,239,250,6,22,50,238,230,162,241,84,212,137,215,174,224,113,107,13,28,161,7,233,133,216,113,38,245,253,209,89,198,69,87,212,57,104,246,1,239,138,46,113,0,110,235,70,222,80,41,190,26,252,223,115,8,11,16,87,118,167,183,93,195,154,182,54,13,85,102,169,10,169,208,92,242,155,168,29,31,117,234,136,226,220,211,231,60,227,118,152,234,233,118,164,233,250,155,73,139,253,39,63,244,125,228,33,159,67,97,212,223,10,91,95,21,244,220,144,217,190,161,121,228,246,171,190,129,208,159,70,116,18,177,222,232,60,200,0,4,145,249,35,82,84,173,146,111,118,188,132,189,126,37,94,227,207,153,26,214,95,0,183,50,172,200,206,200,140,178,135,47,136,138,19,227,219,55,229,70,72,126,54,209,34,79,19,113,42,27,34,158,113,0,187,45,117,223,49,141,125,72,182,207,68,30,246,173,90,55,219,220,201,102,59,119,48,124,93,210,73,198,253,46,136,187,248,191,16,111,228,10,42,84,208,138,225,245,135,156,45,243,34,139,206,244,179,225,124,21,195,250,155,253,202,80,12,144,74,240,183,59,37,121,160,107,247,195,185,201,28,244,77,105,127,95,212,204,159,189,213,35,166,221,237,149,204,34,141,193,23,149,194,53,147,62,152,56,121,154,121,160,173,25,224,228,92,26,148,239,206,75,94,102,247,36,255,164,214,26,254,5,172,111,140,180,247,203,240,162,250,206,16,80,125,169,144,63,12,77,108,108,152,238,22,143,118,63,94,129,59,255,3,191,73,185,188,15,44,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("606c473b-83a8-403c-b3e8-30b26e3b8597"));
		}

		#endregion

	}

	#endregion

}
