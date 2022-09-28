﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SynchronizationErrorHelperSchema

	/// <exclude/>
	public class SynchronizationErrorHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SynchronizationErrorHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SynchronizationErrorHelperSchema(SynchronizationErrorHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd2838b1-4a6c-439b-aee9-57d6006ebc8a");
			Name = "SynchronizationErrorHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,27,219,114,211,72,246,217,83,53,255,208,120,170,40,185,198,171,204,190,146,216,83,137,73,38,102,73,96,49,89,30,166,168,41,89,110,59,154,213,197,168,165,16,195,228,223,247,156,190,72,221,173,150,172,144,0,187,85,251,2,88,58,125,116,110,125,238,164,65,66,217,54,8,41,121,75,243,60,96,217,186,240,103,89,186,142,54,101,30,20,81,150,254,248,195,231,31,127,24,148,44,74,55,100,177,99,5,77,14,173,223,0,31,199,52,68,96,230,255,70,83,154,71,97,3,230,101,148,126,168,31,206,211,130,110,4,254,227,109,228,227,207,124,13,68,176,26,228,146,126,44,0,33,210,243,130,101,105,235,11,11,179,206,69,146,232,231,236,55,22,90,253,117,78,219,158,251,207,79,90,95,157,166,69,84,68,58,15,22,192,89,16,22,89,222,2,113,17,68,177,243,57,101,44,216,192,179,14,134,222,209,165,127,94,20,91,255,120,201,138,60,16,170,0,64,0,253,41,167,27,248,69,102,113,192,216,51,208,70,26,94,231,89,26,125,226,194,63,205,243,44,63,167,241,150,230,28,250,247,231,116,29,148,113,113,18,165,43,248,132,87,236,182,52,91,123,243,246,99,163,209,123,56,183,45,151,113,20,146,16,63,210,241,13,242,140,116,160,2,60,159,57,21,21,209,103,17,141,87,64,245,235,60,186,9,10,42,94,30,28,28,144,35,86,38,73,144,239,166,245,3,74,73,152,211,245,100,200,213,176,91,132,215,52,9,46,130,52,216,208,124,120,48,37,81,202,138,32,13,169,95,29,57,208,145,108,197,39,136,227,52,249,131,233,63,15,59,200,176,152,35,20,185,35,215,65,186,138,1,79,24,0,30,146,194,141,219,67,68,78,131,85,150,198,59,2,218,68,77,255,193,241,156,11,52,108,134,104,46,1,11,153,144,161,245,69,5,51,148,84,254,68,211,149,16,166,41,89,184,226,128,187,68,123,68,249,114,245,117,240,165,129,251,100,65,11,6,36,174,105,78,65,158,164,200,116,233,91,38,127,197,104,14,135,83,225,30,122,232,129,63,217,6,121,144,112,65,77,134,165,137,97,250,69,223,58,58,224,40,133,144,133,173,182,219,161,103,34,34,38,5,35,130,254,112,48,176,128,38,22,216,33,7,50,45,167,1,228,59,172,141,31,188,235,214,222,235,60,3,58,209,215,224,221,200,10,192,70,87,253,110,199,189,21,178,85,248,137,197,177,245,243,51,217,208,226,144,48,252,99,15,249,23,180,184,206,86,61,105,255,13,173,77,99,96,126,193,54,51,184,81,41,141,117,234,201,26,46,154,48,28,0,147,182,195,118,236,120,149,68,233,85,26,21,243,21,128,247,53,58,235,160,110,116,11,237,149,65,64,153,70,31,74,74,162,21,5,165,174,35,154,27,86,199,63,145,211,162,204,83,54,221,207,14,156,85,192,166,18,110,162,188,40,131,152,104,231,80,68,34,74,80,249,196,251,173,140,86,196,100,66,217,173,64,75,234,227,210,238,32,8,203,79,159,129,243,159,67,204,62,217,93,205,87,158,133,69,55,79,167,190,222,8,178,137,33,178,52,228,247,75,82,105,234,45,138,33,248,3,103,203,93,67,127,220,237,205,178,21,158,240,63,245,212,93,125,104,218,65,131,47,209,146,48,139,203,36,37,55,65,92,210,94,26,235,226,166,85,109,226,162,163,166,236,227,39,59,164,68,104,172,34,189,86,151,238,33,64,163,230,89,249,120,98,69,40,72,194,10,165,205,147,29,70,10,175,73,181,208,164,196,223,192,12,56,221,31,243,103,16,156,10,42,142,89,158,82,162,140,214,196,179,15,251,103,180,8,175,207,242,44,121,126,226,105,108,142,201,58,136,25,29,41,118,149,121,218,231,5,230,59,221,130,211,50,142,247,90,163,160,150,145,63,33,215,35,137,228,237,99,84,92,203,208,28,165,235,172,175,83,72,32,67,91,102,183,134,89,93,136,103,40,93,8,139,5,4,107,214,26,120,12,131,194,228,83,134,247,189,119,93,102,1,160,85,93,36,158,84,157,36,75,73,16,13,233,87,221,146,64,149,18,4,237,98,198,205,253,95,104,237,222,240,180,134,26,142,72,192,8,63,124,88,225,81,7,13,36,144,140,161,140,52,68,226,192,139,87,203,63,129,238,74,202,19,146,210,143,68,62,245,164,109,200,151,191,43,193,193,135,223,215,184,231,43,255,109,182,224,220,122,154,49,105,204,248,231,1,227,223,172,12,166,221,128,219,47,155,142,80,96,19,31,115,154,46,121,50,225,182,86,125,113,32,245,129,177,252,45,189,45,28,119,5,37,253,22,114,231,149,38,165,35,113,108,234,241,24,108,93,67,77,50,250,219,247,50,101,192,207,72,192,187,230,77,224,101,208,89,150,39,65,129,255,148,2,228,79,23,80,140,5,113,244,137,122,18,255,104,76,4,36,218,42,248,124,140,86,180,159,91,135,202,229,134,90,142,221,138,133,85,236,99,36,142,88,241,93,110,214,125,232,219,27,101,79,211,50,161,121,176,140,233,17,94,136,41,143,181,130,178,87,31,161,210,101,45,183,80,106,6,124,99,1,229,216,85,17,197,188,52,68,187,64,253,178,147,221,41,158,96,150,7,29,243,59,243,18,72,83,214,162,140,78,187,194,237,134,181,128,132,139,230,28,243,241,10,82,47,198,134,35,97,46,35,176,4,172,209,189,127,223,108,201,100,74,224,47,255,31,116,183,95,239,136,146,73,103,153,102,40,188,80,148,54,144,246,163,101,178,111,165,227,166,114,110,50,240,80,72,31,191,121,151,26,113,45,74,145,247,54,209,61,132,225,81,21,124,237,122,36,172,63,103,151,224,2,94,129,108,183,16,246,236,112,165,71,39,200,67,41,20,104,68,230,96,229,146,133,121,180,164,57,248,208,40,109,154,143,250,100,133,81,79,236,66,249,247,196,145,226,233,152,117,247,85,157,177,189,86,8,182,24,165,202,91,75,106,7,55,65,78,88,148,108,99,122,97,248,237,133,254,76,57,227,129,1,233,159,100,171,29,58,111,61,68,91,32,60,114,72,146,224,135,19,230,28,170,93,72,90,132,241,58,106,90,174,162,161,60,170,112,189,206,152,146,136,103,160,27,105,202,232,147,167,154,37,58,86,17,89,24,150,57,102,164,244,54,164,91,94,167,245,77,61,213,1,222,109,193,196,203,48,247,83,245,154,231,157,188,87,194,155,1,13,87,230,196,169,98,66,43,70,101,171,125,60,163,184,32,70,34,158,173,157,57,187,236,40,32,40,21,183,10,155,66,123,61,103,157,240,234,88,60,121,5,155,130,26,19,251,149,210,167,145,8,215,173,70,165,50,102,69,122,213,1,81,54,171,187,112,129,99,90,213,28,231,53,10,133,77,88,153,255,238,26,222,123,215,232,42,175,187,125,238,169,193,202,112,132,174,34,43,12,111,33,47,224,224,233,83,7,227,254,41,56,216,119,144,145,122,247,252,208,152,136,64,63,203,18,208,119,132,209,126,158,194,117,142,130,180,152,149,49,40,135,206,55,41,120,163,89,128,9,182,145,238,235,253,36,96,222,150,135,20,194,89,148,179,226,85,46,123,130,189,164,33,149,118,198,17,246,22,70,93,147,65,184,4,131,220,39,10,235,43,35,59,87,172,56,179,124,96,47,182,31,139,111,35,94,56,234,23,157,152,222,85,181,12,23,60,225,212,27,141,76,132,79,238,191,138,107,74,216,150,134,24,14,225,5,247,170,20,15,146,64,36,5,189,187,32,205,116,98,186,112,225,235,227,113,90,154,229,254,94,79,212,146,36,124,153,51,170,145,73,92,178,144,149,206,167,201,177,179,14,167,250,143,62,213,183,139,7,243,70,42,197,78,12,228,61,170,109,105,77,42,63,212,235,108,87,62,56,118,240,168,138,112,242,107,69,198,179,126,229,181,50,75,219,28,205,160,186,148,14,135,132,80,114,245,142,165,90,109,58,93,40,115,174,241,220,183,209,246,253,237,79,139,93,238,128,229,48,181,127,150,52,7,233,177,15,50,45,107,188,243,76,227,27,147,102,228,150,134,2,72,124,62,58,192,222,158,28,31,180,12,22,234,3,96,33,194,223,53,227,143,19,200,242,131,78,24,44,37,65,24,101,90,180,0,84,109,137,150,247,16,82,22,69,182,69,70,65,27,230,69,114,39,8,136,0,83,17,11,164,243,70,169,227,143,221,241,236,93,48,137,163,141,246,115,71,47,245,158,87,226,145,59,153,162,226,169,200,126,28,207,185,167,111,249,53,220,166,198,193,189,29,226,187,60,194,118,163,219,31,114,183,5,86,5,255,128,250,130,109,51,62,100,173,234,81,168,168,49,116,247,117,61,15,41,188,191,142,51,220,83,200,232,14,253,180,142,7,251,15,85,149,143,56,229,170,115,90,186,3,92,29,149,59,177,218,2,99,210,232,149,142,201,50,203,98,91,125,232,108,32,241,195,140,81,196,73,97,216,202,118,192,190,120,151,233,77,180,185,46,152,130,58,52,96,22,29,157,215,177,209,173,125,50,225,100,249,60,115,36,102,39,87,24,225,168,27,117,237,94,193,3,143,201,47,123,192,23,78,94,49,79,112,190,176,177,5,55,85,119,0,179,141,6,182,160,40,153,217,87,233,186,62,87,219,21,111,215,227,61,8,5,11,104,128,57,178,212,184,84,65,1,129,108,91,60,168,3,245,61,46,130,100,108,56,189,132,128,174,184,108,206,159,90,76,90,136,72,87,114,195,172,163,180,80,120,31,195,86,45,131,82,152,91,13,161,111,29,3,153,104,126,3,172,99,10,165,133,46,87,13,131,112,253,171,22,132,70,39,115,161,125,228,222,161,145,111,45,225,77,188,215,88,150,135,64,140,141,252,171,88,47,194,181,149,173,64,73,151,123,178,119,191,90,66,160,183,103,120,130,211,137,68,214,119,82,39,132,171,7,64,69,105,235,112,78,28,113,21,196,188,73,238,13,5,227,138,190,59,66,1,141,133,164,118,114,61,27,118,232,128,154,145,21,84,16,66,60,232,46,124,191,126,193,219,52,64,41,2,195,8,45,75,239,213,223,150,137,238,107,193,103,123,161,42,162,25,209,63,174,244,134,61,94,254,33,90,136,116,24,43,137,231,17,183,4,144,133,236,98,140,73,198,71,117,213,200,97,48,248,76,250,150,144,228,110,172,29,154,97,255,52,229,147,14,30,223,76,227,243,181,215,216,32,150,157,232,193,221,97,69,45,90,240,170,20,93,26,94,110,136,213,185,29,218,220,209,124,158,4,92,38,47,178,229,66,1,78,85,20,170,142,250,111,104,146,221,80,9,216,24,180,212,2,217,239,181,164,240,73,28,133,52,5,75,198,237,27,45,177,251,206,35,16,73,221,203,72,36,202,45,195,143,214,76,36,197,214,40,119,42,187,84,187,89,67,117,251,107,173,36,194,41,73,93,56,85,131,163,43,220,0,189,48,64,43,229,32,150,216,4,225,211,95,29,152,23,106,183,216,231,223,80,11,157,219,139,89,8,125,188,50,234,160,74,61,28,83,107,67,237,251,87,149,246,173,200,57,170,192,150,141,90,191,125,245,236,191,98,65,206,136,137,111,228,178,5,120,140,199,227,204,138,162,98,33,15,222,21,157,123,121,68,11,134,253,118,244,180,181,197,227,124,83,38,224,116,72,160,254,33,220,160,3,196,179,69,58,182,209,27,37,100,227,18,180,115,48,245,212,215,31,54,120,85,69,105,198,103,136,223,204,253,8,61,85,99,87,119,174,239,246,62,238,49,109,239,186,64,186,184,182,202,250,65,241,189,179,83,222,29,232,177,55,113,43,7,112,211,227,148,180,77,230,170,137,226,170,20,209,219,100,162,251,43,17,31,226,92,4,183,90,223,108,42,38,59,164,126,4,49,169,129,74,41,204,17,44,92,54,218,149,91,84,236,16,157,105,89,46,59,40,180,107,229,214,185,159,90,158,145,24,85,82,233,141,26,155,64,45,243,65,27,129,177,48,214,201,173,131,77,215,92,210,254,224,216,197,239,255,170,9,187,38,214,181,174,249,140,250,75,70,212,53,138,214,161,244,119,49,113,210,101,227,237,179,105,145,160,182,24,96,255,75,224,6,113,61,253,235,47,130,255,159,3,231,161,244,182,80,9,179,218,68,211,51,50,213,254,236,154,109,53,135,90,218,130,139,194,96,141,74,155,139,45,238,209,177,61,224,239,115,131,218,198,181,246,162,29,246,49,18,75,90,250,1,103,5,10,135,166,174,25,131,92,140,12,133,40,181,254,219,23,238,71,14,236,141,221,62,196,201,242,216,192,171,239,238,52,136,171,246,29,201,211,167,14,218,197,246,162,127,250,1,140,159,233,107,141,117,205,110,104,82,109,253,160,100,101,251,236,178,76,150,50,11,111,223,48,179,133,90,247,30,6,70,111,99,15,26,201,126,221,193,208,248,111,84,175,114,175,67,123,82,53,38,116,153,61,113,221,31,16,150,105,56,83,242,183,191,227,83,147,233,35,19,170,150,153,163,201,86,117,215,126,254,217,64,82,45,112,186,228,204,107,89,179,123,172,145,238,38,209,107,113,8,38,233,211,137,69,187,164,2,16,60,217,107,134,232,176,166,205,57,154,190,225,170,104,134,220,88,145,60,104,244,34,92,78,84,239,63,52,133,161,247,243,251,174,232,234,218,214,207,119,111,100,136,249,33,250,181,33,86,198,85,58,86,51,105,215,205,230,246,159,162,218,26,33,84,102,96,76,13,152,209,28,223,219,202,154,197,52,200,219,166,68,184,146,142,11,186,247,216,59,123,88,82,224,138,161,72,97,122,181,189,103,12,213,27,78,223,50,52,137,198,21,129,26,12,24,64,34,81,47,125,253,122,189,238,110,175,205,91,248,76,255,191,119,49,189,205,112,180,17,78,239,37,197,222,255,153,230,255,235,139,237,82,234,216,216,16,55,64,219,89,180,168,126,240,222,226,183,76,155,84,131,221,49,161,255,162,4,197,181,188,102,15,195,173,254,153,120,106,62,132,103,255,1,205,252,23,225,109,62,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd2838b1-4a6c-439b-aee9-57d6006ebc8a"));
		}

		#endregion

	}

	#endregion

}
