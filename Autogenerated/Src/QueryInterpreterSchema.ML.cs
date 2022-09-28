﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueryInterpreterSchema

	/// <exclude/>
	public class QueryInterpreterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueryInterpreterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueryInterpreterSchema(QueryInterpreterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("22e6d1a9-e819-444e-a117-b46bf8221e7a");
			Name = "QueryInterpreter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0c4dab6c-6e58-4a84-8a65-63630c246206");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,219,114,219,54,16,125,86,102,242,15,176,146,153,144,99,149,106,94,35,137,173,99,203,25,77,156,171,212,244,33,78,51,48,9,74,104,41,80,1,64,219,26,87,255,222,197,133,36,120,145,99,39,147,153,60,244,69,182,192,221,197,217,221,131,131,165,24,94,19,177,193,17,65,11,194,57,22,89,34,131,227,140,37,116,153,115,44,105,198,130,87,103,15,31,220,60,124,208,203,5,101,75,52,223,10,73,214,163,198,119,112,73,83,18,41,123,17,188,32,140,112,26,181,108,206,40,251,210,90,92,144,107,25,188,39,203,60,197,124,122,189,225,68,8,21,164,178,219,3,171,219,128,147,125,235,193,201,243,189,143,78,113,36,51,78,201,158,93,193,226,45,207,34,64,6,207,193,226,17,39,75,64,128,102,76,18,158,64,233,158,161,217,187,156,240,173,94,128,20,224,83,27,14,135,67,52,22,249,122,141,249,54,180,223,33,210,37,141,137,64,107,34,87,89,44,80,146,113,116,252,8,125,81,1,16,41,43,128,104,17,204,116,161,8,55,116,226,109,242,139,148,70,198,82,225,232,130,209,187,209,80,74,208,175,204,182,207,208,91,237,108,30,54,129,234,133,50,140,64,75,122,73,152,11,14,11,176,39,4,69,156,36,147,254,156,168,222,247,135,161,201,34,40,67,14,155,49,199,27,204,241,26,49,32,221,164,95,197,235,135,115,40,122,74,84,33,156,93,100,134,46,8,186,196,41,141,177,36,113,48,30,106,247,238,104,151,152,83,124,145,18,209,15,43,50,162,44,65,56,229,4,199,80,91,8,148,171,56,168,52,13,208,76,162,86,84,72,57,231,76,132,85,29,99,52,142,66,147,229,120,24,133,14,70,192,84,152,43,127,99,83,149,142,152,5,221,22,79,72,174,168,85,57,15,208,9,213,48,161,68,99,243,116,128,178,139,191,193,35,172,64,250,35,219,65,194,98,211,68,253,125,103,184,88,95,44,186,124,156,98,1,61,190,51,43,255,144,52,165,114,139,34,229,247,61,148,252,120,66,18,156,167,242,57,101,49,164,227,201,237,134,100,137,215,34,166,239,127,170,8,108,118,109,154,160,206,99,213,228,243,41,37,169,166,51,167,151,208,92,243,112,99,190,32,161,144,70,72,245,63,99,233,22,129,206,144,107,244,153,171,63,71,144,211,146,173,9,147,149,236,160,137,242,238,49,114,101,76,189,223,251,127,65,31,206,197,161,247,219,184,104,200,107,160,91,120,126,117,232,195,242,196,60,170,106,20,6,135,254,227,254,192,184,191,217,24,65,52,228,78,41,35,170,151,119,131,7,255,83,16,72,190,128,2,118,193,242,92,131,127,139,47,53,137,84,79,252,115,47,56,60,7,72,245,157,203,45,103,243,136,211,141,156,219,252,63,139,162,16,200,60,152,178,37,192,14,142,193,65,145,89,63,244,246,48,178,67,99,110,105,202,101,70,99,116,20,199,239,73,66,56,97,32,175,94,3,140,197,226,163,155,50,253,51,200,114,172,242,10,237,98,207,18,204,156,51,127,80,91,4,29,200,215,172,177,120,154,179,168,177,116,2,176,78,104,146,104,182,169,231,170,122,154,117,32,25,29,182,111,49,151,119,177,213,54,211,107,73,152,190,211,58,128,76,175,125,189,182,11,78,51,62,197,209,202,179,73,7,110,101,76,239,118,119,45,250,215,132,29,66,11,96,128,13,142,148,156,35,133,9,93,173,104,180,66,84,160,92,128,228,81,87,241,239,170,233,42,142,58,32,253,208,185,31,84,195,2,56,111,100,125,145,110,223,229,160,231,9,37,177,54,131,59,3,36,90,239,110,212,30,199,113,151,210,23,34,11,58,44,121,78,180,10,83,235,8,128,69,30,169,251,57,201,83,224,180,14,1,66,42,87,132,95,81,65,208,47,74,190,19,156,10,237,215,144,108,171,65,23,89,150,34,247,76,21,114,93,100,84,208,80,31,72,189,239,4,233,196,94,16,169,237,75,67,221,173,30,160,243,10,120,12,112,21,254,61,179,57,210,120,140,233,78,127,126,238,106,189,14,97,35,90,71,149,191,75,136,251,245,56,225,217,218,189,187,247,140,87,170,49,172,28,13,127,40,49,92,30,172,200,79,199,133,150,164,238,35,134,93,198,93,60,7,174,60,222,87,234,224,166,136,180,27,236,155,118,251,53,6,212,104,218,185,159,255,85,130,252,63,221,221,127,186,179,244,248,33,67,158,37,145,82,13,99,20,204,196,107,160,240,27,62,93,111,228,214,171,2,250,165,146,200,21,207,174,144,186,23,143,248,50,87,163,140,242,152,94,71,68,15,30,158,42,29,92,52,174,107,167,224,204,137,252,96,129,20,62,46,197,252,1,210,151,85,137,94,157,143,208,175,153,140,238,28,177,61,162,220,30,190,109,111,246,170,143,14,197,206,142,248,150,181,69,7,147,186,2,195,124,75,224,174,213,38,101,11,148,172,181,218,177,39,165,194,46,120,73,182,131,210,43,248,0,20,44,224,217,26,239,28,105,248,248,9,180,233,194,121,201,5,85,112,184,54,223,192,8,238,61,25,61,49,35,65,47,248,19,52,11,212,6,77,66,116,208,201,9,225,23,166,134,129,198,86,4,11,78,215,158,239,7,139,236,8,212,100,235,89,72,101,218,150,163,53,48,42,253,58,186,96,129,255,129,237,235,107,103,132,45,229,10,84,244,105,69,67,85,236,246,208,10,88,95,97,169,38,26,55,66,229,213,211,42,171,164,175,240,34,177,45,93,79,194,123,71,97,214,171,155,64,205,202,150,76,225,204,143,53,91,26,155,20,113,118,40,82,16,144,247,193,170,76,101,83,158,18,104,65,133,169,23,65,146,18,217,2,193,245,39,240,82,137,119,191,46,93,234,5,73,95,55,92,227,50,220,84,119,15,101,81,198,57,180,34,64,213,86,207,208,205,175,187,254,168,204,167,60,181,51,166,213,111,193,49,101,64,47,59,46,22,167,215,182,28,6,195,53,150,158,197,50,168,55,9,206,14,192,47,211,181,127,85,67,14,234,101,115,82,108,37,247,184,127,138,105,10,165,5,69,230,214,67,167,215,72,162,182,243,55,36,100,119,108,193,133,154,75,202,236,80,83,46,107,242,160,181,254,156,220,242,206,22,116,177,108,84,49,243,64,135,8,230,102,42,168,234,208,81,134,118,147,211,44,194,169,35,17,251,59,188,167,56,223,88,27,91,3,139,209,125,243,4,160,38,161,23,60,203,55,226,99,223,125,216,255,100,52,104,212,233,238,190,231,54,130,56,151,117,61,132,185,168,212,45,93,46,185,135,83,175,55,143,164,215,222,176,204,235,190,7,242,167,236,146,123,232,108,167,110,189,38,84,107,6,166,134,181,11,216,14,18,0,39,79,165,121,224,20,215,44,183,244,206,56,133,45,97,198,66,122,229,253,126,207,50,239,83,189,89,81,198,206,159,131,148,8,174,136,133,175,95,115,50,169,164,14,170,15,239,248,112,45,23,245,253,78,197,171,191,226,187,146,183,43,47,251,162,88,141,155,254,22,57,111,165,99,38,61,144,65,21,65,231,0,131,165,26,49,221,148,26,124,122,186,251,33,57,14,208,190,153,205,190,1,56,148,233,254,89,160,235,215,65,88,251,15,168,234,209,14,238,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22e6d1a9-e819-444e-a117-b46bf8221e7a"));
		}

		#endregion

	}

	#endregion

}
