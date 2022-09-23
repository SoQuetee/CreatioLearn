﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OperatorSessionRepositorySchema

	/// <exclude/>
	public class OperatorSessionRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OperatorSessionRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OperatorSessionRepositorySchema(OperatorSessionRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("26246f71-a336-431c-a755-aa8f74c8da9c");
			Name = "OperatorSessionRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad806488-98f4-482b-bb58-5e43a394961e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,109,111,219,54,16,254,236,2,253,15,172,7,116,50,96,40,223,155,196,67,234,36,133,129,166,233,234,116,253,88,48,18,29,115,147,73,135,164,18,120,69,254,251,142,111,18,245,106,57,93,135,13,216,183,136,38,239,142,119,207,61,119,199,48,188,33,114,139,19,130,110,136,16,88,242,149,138,231,156,173,232,93,46,176,162,156,197,215,27,70,147,53,102,140,100,241,21,145,18,223,81,118,247,242,197,183,151,47,70,185,132,63,209,114,39,21,217,28,215,190,65,74,150,145,68,139,144,241,59,194,136,160,73,99,207,123,202,238,203,197,208,130,205,134,179,246,95,4,233,90,143,47,152,162,138,18,9,27,96,203,79,130,220,129,118,52,207,176,148,111,208,245,150,192,141,184,88,194,29,96,249,19,217,114,73,225,123,103,54,31,29,29,161,19,153,111,54,88,236,102,238,187,220,130,86,92,160,71,46,254,208,74,31,169,90,35,238,164,33,105,197,197,94,198,81,32,100,155,223,102,52,65,137,54,160,91,63,250,102,44,40,237,5,143,41,204,20,216,252,81,208,7,172,136,253,189,110,162,89,184,174,217,129,100,178,38,27,140,24,196,53,46,78,133,70,141,182,86,40,74,180,30,36,149,208,151,250,202,171,230,45,141,152,15,32,5,157,162,113,205,246,241,177,179,152,176,212,26,93,189,193,37,37,89,58,200,252,19,73,192,16,65,86,167,227,207,146,8,184,58,179,152,25,31,205,16,53,126,72,246,221,67,16,156,114,150,237,80,85,2,250,154,87,190,143,135,153,49,95,99,229,175,59,199,224,133,231,88,210,16,130,190,38,245,165,61,62,52,40,16,121,2,219,181,39,13,146,122,110,176,96,128,124,156,209,63,137,68,140,60,22,22,35,190,10,111,215,9,66,184,101,199,229,204,202,22,11,188,49,160,58,29,87,221,58,158,105,183,107,48,185,133,248,228,200,236,182,158,177,25,208,169,54,170,197,172,42,123,130,222,32,181,166,50,170,46,79,205,13,27,62,174,237,154,76,116,98,141,70,79,255,61,175,53,14,39,6,136,51,111,135,68,102,161,132,229,223,231,242,105,11,118,141,50,231,205,81,45,171,128,29,26,105,166,119,53,224,14,27,19,7,251,34,38,93,216,191,34,106,205,135,17,200,39,162,114,193,36,186,207,137,163,105,5,186,44,153,25,58,116,180,200,111,127,7,251,28,59,246,197,76,88,129,179,69,59,20,76,137,217,89,118,252,85,235,4,8,156,28,249,67,33,25,52,118,162,57,240,131,34,181,192,92,200,251,200,251,246,1,11,68,228,61,184,74,131,177,33,32,170,249,62,14,119,92,97,134,239,136,152,246,48,249,196,198,6,52,196,224,88,125,109,35,22,10,117,190,97,241,66,158,101,143,120,39,151,68,151,109,176,1,216,135,148,39,206,210,212,110,140,198,94,176,194,66,157,195,141,198,147,248,90,164,68,156,83,81,128,162,186,16,159,19,153,64,176,161,210,88,137,214,97,250,178,199,251,114,20,20,163,21,205,20,164,203,237,174,172,187,152,165,40,135,62,133,81,185,38,105,88,134,135,100,35,40,30,31,22,226,158,236,244,54,45,210,50,69,17,77,9,200,89,81,34,170,217,233,208,241,192,105,10,117,82,95,203,185,243,237,206,159,141,154,208,1,123,167,232,93,14,103,74,101,30,53,58,58,86,146,212,81,138,244,183,133,154,93,253,2,253,202,71,109,0,209,91,34,187,8,29,22,24,69,37,103,55,187,45,116,78,247,57,206,166,104,12,125,153,166,135,241,52,212,19,224,166,93,207,66,126,200,179,204,254,86,192,227,130,165,22,28,147,65,33,214,136,247,201,170,211,216,235,31,26,209,67,130,208,56,12,56,128,91,132,39,205,202,160,32,90,23,124,32,143,181,196,142,106,225,114,241,115,170,194,148,111,77,88,200,161,1,233,14,157,181,242,48,126,187,211,73,30,237,205,127,43,166,174,213,173,158,182,91,227,2,109,55,213,121,200,201,109,21,24,47,137,58,39,43,75,29,191,225,44,39,50,218,183,63,216,28,121,68,66,112,42,152,60,68,68,17,24,23,229,105,17,132,131,12,169,179,222,180,17,160,121,46,4,0,70,219,171,3,227,62,245,230,27,10,145,153,244,235,195,15,36,218,159,43,96,150,41,113,192,166,40,213,32,4,242,42,75,30,23,63,203,67,185,208,109,151,227,89,131,4,203,25,78,119,193,126,35,180,45,126,185,39,45,128,96,50,96,28,119,73,25,213,37,22,226,124,42,248,239,248,146,139,11,104,21,34,79,7,167,51,183,195,100,139,44,232,5,104,191,153,36,251,98,112,220,144,100,34,106,100,121,199,193,57,205,138,105,16,255,19,47,97,214,86,255,156,80,127,190,3,58,158,17,167,149,59,248,195,116,133,162,154,69,175,78,145,87,27,95,81,43,205,123,203,94,33,117,83,58,24,31,81,166,38,161,224,120,153,223,42,129,19,85,19,59,137,111,184,194,25,8,204,149,153,149,71,125,182,159,59,13,96,181,87,230,45,126,170,221,90,3,120,133,51,233,137,230,105,63,154,193,211,208,197,38,14,43,5,36,126,24,233,251,70,237,89,72,239,238,242,2,84,27,66,78,106,224,15,106,123,71,17,47,91,191,238,46,177,181,25,171,144,91,60,231,169,110,199,252,220,110,22,205,90,229,236,89,150,89,90,183,66,10,70,238,234,71,76,247,209,32,223,178,135,211,9,83,119,68,123,145,232,195,194,231,173,230,51,25,60,173,216,26,204,252,10,47,38,159,127,99,83,80,193,215,153,5,131,32,50,207,84,7,116,110,57,207,220,165,189,134,5,179,147,236,160,214,33,28,212,80,56,111,105,86,108,204,95,58,70,69,64,27,177,212,228,83,21,1,51,8,244,116,160,11,217,44,119,209,54,249,237,210,219,254,18,30,139,13,224,64,63,40,51,127,70,213,74,219,98,86,187,3,194,125,85,184,21,83,73,31,148,222,115,156,202,214,9,94,155,163,51,124,37,248,6,28,202,5,116,81,131,11,229,119,0,162,207,150,96,140,111,195,73,101,127,233,217,174,110,146,4,93,226,179,155,200,154,145,46,4,165,120,16,28,234,25,210,30,106,136,217,51,241,37,81,201,250,18,34,112,254,182,0,72,81,215,92,156,245,60,80,189,185,175,123,11,83,170,237,177,169,91,211,28,87,216,212,90,191,237,59,39,84,111,75,145,254,160,87,113,246,128,105,134,111,179,61,82,116,206,206,74,239,20,167,198,19,87,18,93,106,132,136,221,115,147,224,125,189,120,94,55,143,127,50,174,114,251,130,65,45,167,15,240,71,253,218,135,139,208,7,251,92,112,184,196,134,148,208,33,131,223,123,246,61,115,186,196,54,73,6,201,228,159,199,2,182,48,201,109,222,159,109,142,3,187,224,91,44,7,39,121,69,214,172,227,97,184,150,181,141,199,55,211,1,107,91,43,206,138,58,25,59,204,95,218,232,30,44,159,246,118,21,21,18,182,243,82,144,179,25,150,106,233,155,233,22,5,48,214,11,169,174,5,12,106,24,234,149,111,7,90,153,61,148,245,202,22,9,27,233,95,74,106,10,246,180,102,145,166,174,89,115,46,155,184,36,122,243,127,202,244,151,55,255,232,137,179,12,89,89,69,179,32,81,70,165,26,242,192,217,3,109,35,162,86,140,44,176,223,195,47,39,225,246,153,142,58,244,147,103,198,140,226,129,58,106,123,223,144,254,33,184,191,59,177,219,162,106,217,175,202,136,191,172,137,32,17,215,163,33,143,173,110,61,214,104,243,6,204,208,239,220,12,157,216,225,176,209,113,166,63,124,254,152,183,106,110,247,121,163,254,87,73,165,103,160,248,206,166,208,185,190,73,3,123,29,108,218,1,253,111,69,204,234,0,61,244,117,226,31,125,215,11,216,187,117,12,235,111,204,193,197,169,101,80,31,4,51,211,251,31,79,205,230,248,98,179,85,187,162,219,41,143,14,230,143,51,79,105,97,175,161,53,189,106,239,165,67,115,59,186,173,80,210,179,107,80,3,63,223,81,122,244,117,90,42,13,122,253,26,61,183,184,232,0,212,218,229,81,139,61,159,200,134,63,16,99,85,241,88,212,120,203,106,158,243,79,30,136,192,124,228,197,15,63,55,234,124,69,110,139,94,16,174,246,206,202,174,86,23,159,254,2,31,73,114,153,235,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26246f71-a336-431c-a755-aa8f74c8da9c"));
		}

		#endregion

	}

	#endregion

}

