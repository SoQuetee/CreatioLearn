﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAudienceQueueManagerSchema

	/// <exclude/>
	public class BaseAudienceQueueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAudienceQueueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAudienceQueueManagerSchema(BaseAudienceQueueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c4116d3-fa0e-44ac-8a08-8230e66b90b7");
			Name = "BaseAudienceQueueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("097cd95f-c972-4e9b-ab53-9b1cae85bae7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,75,111,219,56,16,62,183,64,255,3,161,189,72,104,32,167,135,189,52,182,139,60,187,193,182,105,26,187,219,195,98,15,180,52,78,136,72,162,74,82,73,141,160,255,189,195,151,37,202,86,236,0,123,40,26,75,51,223,188,62,206,12,85,209,18,100,77,51,32,115,16,130,74,190,84,233,41,175,150,236,182,17,84,49,94,189,121,253,244,230,245,171,70,178,234,150,204,86,82,65,121,212,251,141,242,69,1,153,22,150,233,71,168,64,176,108,67,230,19,171,126,180,15,187,182,202,146,87,219,223,8,24,122,158,158,157,224,43,124,249,135,128,91,180,75,78,11,42,229,123,114,66,37,28,55,57,131,42,131,175,13,52,240,153,86,244,22,132,145,29,141,70,100,44,155,178,164,98,53,117,191,49,84,69,89,37,73,9,234,142,231,146,40,78,30,185,184,39,143,76,221,145,31,26,34,117,162,95,106,192,140,128,180,175,198,18,128,100,2,150,147,72,27,181,198,64,74,180,22,141,166,94,103,60,234,216,171,155,69,193,50,66,23,82,9,154,41,146,105,159,7,93,30,207,167,196,6,52,167,242,190,255,230,241,14,4,150,204,73,116,173,163,161,39,19,110,155,27,172,139,18,77,166,184,192,20,93,27,47,172,68,63,35,62,37,94,156,44,241,95,47,210,109,190,186,136,55,67,182,79,106,42,104,73,42,100,218,36,106,36,8,180,80,89,190,68,211,241,200,188,53,194,46,65,67,86,226,111,129,46,9,161,18,204,197,2,53,227,254,227,167,95,46,29,80,229,54,35,97,122,174,5,199,202,42,6,58,57,130,43,212,131,252,153,252,32,147,239,33,39,2,50,46,114,228,141,201,58,201,120,209,148,149,9,114,32,21,181,199,110,25,128,255,105,110,223,24,168,83,131,112,133,0,228,137,220,130,58,34,59,28,255,108,41,171,189,102,15,200,76,251,182,182,63,8,171,20,249,8,234,92,42,86,226,239,124,206,74,136,245,195,154,75,230,50,163,229,95,61,80,65,100,179,152,129,62,195,100,66,42,120,36,246,71,47,225,137,17,127,149,206,121,29,175,65,220,51,235,124,28,5,230,162,36,61,150,27,207,156,198,133,224,101,140,14,206,178,59,40,169,14,59,94,210,66,66,226,5,190,136,28,196,201,234,12,100,22,71,24,34,23,76,173,162,222,219,99,253,242,84,128,134,255,82,69,9,161,210,57,127,212,6,183,119,100,46,138,139,166,202,210,75,121,213,20,133,253,123,214,148,113,132,57,138,14,72,63,154,3,98,149,210,107,77,99,80,72,211,195,36,9,130,92,39,215,166,67,227,36,214,59,235,89,58,171,33,99,203,213,21,255,196,179,251,191,176,70,50,118,2,2,84,35,42,23,65,122,254,19,178,70,193,44,163,5,21,99,148,155,58,185,95,97,233,207,152,137,10,137,55,254,216,176,252,64,115,97,170,201,160,59,137,188,172,144,229,183,2,121,27,7,20,120,105,150,250,172,221,65,133,225,178,99,179,193,170,239,153,17,237,42,250,222,20,222,213,173,193,198,33,156,75,220,13,80,36,77,44,200,100,234,2,55,112,44,71,40,129,147,75,89,215,255,161,69,3,6,108,186,25,228,81,171,7,138,110,83,52,246,251,209,59,53,235,121,122,156,231,177,118,21,17,220,155,95,97,193,173,92,183,182,123,52,129,221,173,235,198,160,203,110,75,191,172,176,198,10,27,184,30,118,98,69,112,86,215,133,38,17,14,66,168,204,0,244,61,110,223,22,207,164,29,149,186,42,197,87,141,26,77,47,10,122,171,33,89,149,179,76,195,243,86,132,40,186,40,0,219,185,182,209,157,7,6,217,102,68,78,135,125,70,29,47,20,246,89,254,128,75,3,203,129,88,5,125,2,236,95,110,84,26,223,230,46,224,120,193,121,65,54,125,239,158,17,102,113,38,102,208,164,207,195,109,65,10,74,108,177,220,169,152,129,234,80,230,134,63,202,83,222,84,10,251,141,166,184,209,110,251,203,128,32,118,43,108,79,151,149,2,61,145,215,45,40,132,54,108,220,129,234,100,222,5,104,93,46,110,229,214,5,43,10,73,30,244,17,144,102,111,176,124,170,189,1,183,55,57,78,181,131,179,94,143,223,189,249,101,203,255,12,35,182,145,119,131,88,93,72,39,20,77,17,72,81,220,59,8,95,118,79,201,92,67,123,143,91,240,0,116,11,239,30,56,246,22,44,64,152,106,25,35,166,231,164,13,230,0,87,57,7,239,249,102,40,54,160,235,149,188,74,219,26,59,233,158,56,177,118,50,73,43,215,202,104,10,159,172,76,19,222,70,170,36,53,29,13,145,124,18,55,133,246,130,116,203,128,71,139,135,225,200,136,252,121,120,152,144,183,228,221,78,198,109,233,102,118,110,5,60,192,77,138,100,141,16,128,224,110,103,195,189,91,181,252,115,155,12,102,171,221,247,247,161,161,5,187,204,163,233,183,138,161,38,206,17,180,193,150,12,132,102,143,199,47,244,186,40,156,233,189,218,91,47,136,193,246,230,54,54,76,248,39,12,200,111,204,174,25,93,187,176,220,36,215,211,140,120,143,7,54,63,219,48,118,141,255,93,243,127,253,94,3,125,199,126,207,31,13,133,245,34,165,97,98,39,102,12,97,221,175,154,114,1,34,20,73,14,214,66,186,171,117,53,140,160,181,112,254,179,214,91,140,86,232,174,128,107,113,179,34,158,49,97,221,199,221,43,195,25,138,251,118,98,247,48,107,123,255,125,244,187,190,114,117,55,81,92,17,207,127,52,180,136,55,54,192,51,88,82,156,223,190,20,78,35,121,118,59,125,97,246,205,94,250,153,254,108,227,120,110,231,156,233,157,51,136,99,163,122,195,209,172,105,179,225,255,203,246,215,189,15,244,250,72,226,49,10,206,170,30,43,238,12,255,207,167,117,215,241,188,126,137,75,67,7,246,129,9,133,25,246,87,51,125,106,61,238,5,23,182,34,195,39,85,155,221,122,184,177,163,238,213,3,214,160,65,109,6,97,119,94,55,118,175,164,187,62,53,184,254,175,149,114,138,219,116,167,109,98,214,50,125,184,241,122,172,83,28,118,240,151,23,253,50,168,182,186,131,157,21,159,55,117,97,214,0,240,67,202,250,24,111,12,12,66,171,156,160,140,217,12,22,64,192,230,45,79,60,230,150,0,122,20,177,31,62,60,63,130,107,186,185,208,152,155,66,231,58,191,31,99,84,120,221,179,60,217,184,3,118,150,7,31,217,100,152,158,61,18,177,101,39,33,147,9,57,244,246,61,189,122,62,164,254,131,219,223,176,106,177,92,111,251,64,98,92,58,123,26,255,122,169,255,188,216,123,18,31,30,160,37,119,115,90,187,15,221,117,195,198,16,126,253,88,127,180,56,10,82,212,218,58,55,55,186,190,203,102,109,145,230,35,64,120,116,250,130,24,147,212,223,13,184,58,47,107,181,138,157,195,31,58,41,122,171,215,234,208,209,183,155,78,56,197,247,173,98,79,233,185,115,104,159,134,15,241,217,111,102,123,240,62,233,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c4116d3-fa0e-44ac-8a08-8230e66b90b7"));
		}

		#endregion

	}

	#endregion

}

