﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WordReportingDesignServiceSchema

	/// <exclude/>
	public class WordReportingDesignServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WordReportingDesignServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WordReportingDesignServiceSchema(WordReportingDesignServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("778cb9df-4e29-46a4-8914-8863c3d25dbc");
			Name = "WordReportingDesignService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ce5f9868-588b-431e-9bee-93d7e8c140a5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,25,219,114,219,54,246,89,157,233,63,96,149,78,75,109,101,58,77,51,219,221,184,142,87,241,37,85,39,138,179,146,210,60,120,61,25,136,132,100,78,72,130,5,64,217,90,215,255,222,131,27,9,80,212,101,155,206,38,179,47,137,8,156,251,253,192,57,206,8,47,112,68,208,148,48,134,57,157,139,240,148,230,243,100,81,50,44,18,154,135,99,82,80,38,146,124,17,190,163,44,14,39,132,45,147,136,240,47,191,184,255,242,139,78,201,225,2,77,86,92,144,236,168,241,29,14,47,215,142,94,37,249,175,107,135,175,137,88,59,155,144,168,100,137,88,181,92,40,254,35,26,147,116,235,101,56,136,68,178,84,58,108,135,123,71,102,107,0,83,114,39,64,243,69,153,98,118,126,87,48,194,57,208,225,53,220,38,107,93,36,41,121,91,164,20,199,187,97,27,150,133,127,62,16,182,47,154,81,161,29,156,109,60,15,47,112,36,40,75,200,6,93,0,194,53,14,112,22,12,48,218,128,193,110,128,144,101,174,125,127,18,162,144,56,96,62,116,220,128,149,119,225,96,198,21,65,105,205,208,129,6,18,143,146,57,122,125,62,157,76,7,175,207,6,227,179,39,239,31,163,195,67,52,189,60,187,68,167,227,209,193,211,191,61,253,199,15,181,24,147,221,244,37,77,146,114,82,33,141,36,146,241,176,246,250,35,146,199,201,220,161,234,153,218,99,161,108,227,93,3,62,96,62,98,100,33,97,79,83,204,249,51,36,93,89,57,246,140,240,100,145,27,131,42,232,43,243,97,13,123,45,207,6,188,128,28,0,91,22,64,119,150,164,16,247,99,242,107,153,48,146,145,92,240,192,253,144,110,1,185,118,160,72,168,208,28,196,61,201,164,40,103,105,18,161,72,74,185,69,72,244,12,189,192,156,84,34,119,238,149,216,181,150,96,87,129,129,195,51,244,134,201,244,210,106,117,10,253,129,34,121,143,192,7,210,156,146,205,40,201,200,116,85,72,153,187,184,40,64,6,101,187,195,101,30,135,180,32,249,93,150,206,41,203,176,224,7,116,62,7,158,49,141,74,169,67,120,11,216,5,163,145,204,189,124,145,165,161,189,233,30,25,153,192,121,90,44,95,198,139,132,164,241,38,1,235,4,37,12,189,159,59,95,71,62,224,176,54,146,182,144,206,79,244,158,169,179,42,91,93,28,8,170,49,148,83,176,1,121,163,37,167,128,112,219,114,186,67,5,101,102,86,202,84,149,138,40,223,25,86,218,143,155,61,24,244,208,61,122,216,23,248,45,39,12,152,229,68,165,12,42,189,207,62,26,214,230,26,230,115,138,230,222,103,79,242,232,60,67,51,136,152,192,71,117,132,216,164,35,216,162,32,32,18,217,228,170,77,30,24,59,14,64,199,207,149,16,158,87,208,201,9,10,252,147,99,157,159,186,250,173,194,151,68,252,184,129,252,243,160,215,219,199,173,173,135,86,154,54,151,107,169,90,111,90,164,107,35,223,34,154,23,206,222,135,21,197,13,113,45,130,119,114,172,160,58,107,252,93,90,207,131,156,220,186,49,57,96,11,149,137,65,215,247,122,183,143,252,128,234,85,2,111,138,130,17,17,55,116,99,182,54,227,15,36,243,79,130,137,96,4,103,42,48,85,43,201,5,132,158,210,137,17,81,178,124,221,178,62,129,45,186,57,52,65,49,151,67,191,173,91,105,67,110,164,198,160,26,19,46,41,77,39,110,231,11,79,75,198,100,189,27,107,0,69,220,180,173,253,232,73,144,145,166,105,104,188,99,80,106,9,11,70,219,57,105,86,166,3,110,227,197,225,11,47,200,154,123,213,204,162,198,71,160,201,105,201,34,50,209,160,202,239,157,206,131,239,78,211,23,128,192,18,50,255,197,74,16,62,165,163,89,16,147,40,201,112,138,102,242,196,250,111,137,25,202,102,144,27,129,58,70,135,232,187,199,79,158,246,204,255,71,174,143,179,89,56,165,19,69,60,104,101,44,123,154,77,39,25,68,246,119,48,163,52,69,9,159,148,145,76,177,62,74,114,113,130,160,231,83,208,50,38,125,43,49,12,201,28,180,146,77,172,235,202,199,44,205,99,229,5,143,141,134,234,24,210,0,81,177,81,23,15,90,3,8,163,224,47,213,13,250,250,235,154,123,248,19,230,191,224,180,36,150,99,199,178,11,207,37,140,202,8,205,184,254,54,144,157,81,37,177,145,189,111,46,206,45,121,184,170,89,213,230,211,96,70,186,7,215,202,150,123,155,129,151,52,137,209,164,54,172,12,187,137,192,162,228,65,253,83,113,229,213,79,165,214,174,169,239,135,39,223,235,204,114,71,203,168,26,49,91,194,251,200,205,31,40,163,151,144,9,106,230,88,199,110,185,245,168,84,169,33,189,84,161,129,201,203,52,117,156,34,173,83,217,107,111,133,26,241,99,200,135,99,215,202,181,199,29,11,66,70,64,152,246,106,67,122,26,95,150,98,65,193,147,78,3,177,138,83,115,53,94,231,122,217,184,210,220,155,8,190,20,13,1,172,177,26,145,97,115,27,178,110,132,239,100,241,157,36,255,33,23,140,102,48,137,67,196,200,153,132,7,214,154,160,24,90,202,152,151,179,183,63,141,135,14,188,44,228,42,53,26,3,76,31,117,37,135,97,38,187,186,195,14,42,215,227,158,87,50,236,141,169,69,132,133,163,217,148,170,146,20,40,1,90,235,136,42,23,67,254,10,115,113,122,83,230,31,2,83,31,100,133,26,227,124,65,252,226,176,32,119,38,65,199,242,119,240,207,238,191,227,111,15,130,147,31,75,221,89,99,197,239,249,213,193,245,9,92,244,14,225,70,80,129,83,125,44,143,190,234,26,177,37,65,15,75,14,13,90,118,72,222,97,46,190,127,18,40,134,225,8,139,232,38,168,37,10,95,50,90,22,252,170,235,161,119,175,195,95,106,53,21,249,154,245,127,79,187,198,109,16,62,60,148,161,255,76,217,123,80,36,136,67,156,52,20,185,77,96,4,40,33,60,115,162,12,105,240,96,91,147,19,26,42,210,114,145,228,26,49,162,144,156,145,104,16,80,254,114,157,219,48,212,177,171,218,111,191,53,174,191,69,223,249,32,174,227,119,143,45,206,108,126,229,21,19,187,222,117,174,32,21,135,249,146,126,32,129,70,147,109,228,205,229,100,10,81,105,90,241,133,90,129,116,69,50,149,91,31,133,63,115,25,213,54,1,119,192,41,27,188,160,241,106,34,86,41,241,192,170,211,80,15,7,177,29,2,174,91,23,133,17,78,114,217,79,206,4,189,186,150,185,187,126,117,74,211,84,103,93,208,24,185,220,1,61,84,221,86,126,115,23,1,226,106,0,155,245,202,111,215,255,71,6,180,149,10,12,232,155,175,42,121,47,75,104,153,122,73,25,198,123,89,176,66,173,176,246,52,30,80,8,222,178,100,74,178,34,149,101,12,204,119,70,111,115,153,5,154,178,189,57,188,183,164,31,186,158,98,102,204,110,199,178,85,176,169,140,46,130,242,76,233,170,43,161,252,217,80,160,35,216,202,118,83,119,160,175,198,175,8,23,122,169,60,246,45,99,197,169,4,169,185,25,202,29,75,65,79,238,103,9,132,1,79,204,227,206,87,93,44,4,142,110,228,144,123,164,56,230,56,35,127,61,126,59,189,56,248,251,55,223,220,131,201,194,115,14,204,201,25,22,216,12,72,86,150,7,249,30,113,215,53,108,218,214,181,112,192,229,90,41,43,159,215,137,97,162,118,198,150,65,100,160,193,73,67,245,184,34,119,248,190,247,120,98,103,55,41,226,73,248,138,228,11,113,35,119,185,199,253,22,197,172,230,38,148,36,142,25,78,192,142,80,190,81,48,20,36,123,77,33,103,202,60,62,191,139,136,49,174,241,128,184,97,244,86,185,10,148,186,192,101,42,42,152,198,44,23,90,34,189,6,131,143,34,170,83,28,72,15,210,148,222,146,138,248,199,213,137,70,248,235,5,208,15,227,238,190,101,194,203,12,111,230,111,35,187,101,69,117,103,218,27,239,233,116,103,128,104,163,52,18,15,16,29,50,118,207,11,255,85,18,182,210,225,123,213,181,176,221,107,77,194,41,67,91,50,116,251,67,16,32,174,111,230,174,190,154,136,29,5,179,122,48,211,152,219,6,195,230,248,99,111,140,176,53,83,61,44,6,141,39,170,106,13,35,226,180,132,61,54,131,46,84,102,57,151,124,52,6,16,154,99,152,158,77,146,141,60,225,28,81,221,173,205,41,88,238,67,73,168,127,200,163,192,151,214,38,165,92,36,220,249,209,135,10,95,84,147,85,37,120,199,132,143,168,163,215,171,129,48,108,37,49,156,87,225,214,32,169,230,225,170,28,118,60,220,9,94,214,120,150,65,223,68,67,133,178,207,90,23,158,130,144,162,74,86,179,56,86,5,193,62,37,84,73,143,200,157,235,154,221,244,97,10,37,44,199,169,124,184,36,76,45,177,141,66,231,174,245,218,161,122,79,90,175,89,50,163,10,129,103,41,105,22,174,214,202,248,73,101,109,173,175,78,140,74,41,9,204,178,127,92,90,221,78,170,63,22,252,33,65,125,26,253,245,23,158,70,80,58,10,244,54,54,143,79,103,247,109,45,168,141,148,96,37,80,82,175,2,159,213,56,139,246,28,101,55,55,180,83,90,172,26,237,76,53,12,253,216,55,54,77,162,175,122,6,172,250,28,220,171,20,30,55,70,65,167,96,122,21,72,210,175,199,200,6,209,54,122,155,253,217,116,194,190,243,206,231,145,210,246,15,222,159,90,62,8,159,89,18,199,36,223,61,211,253,111,5,219,76,232,35,39,195,207,107,131,244,178,111,76,50,186,36,109,249,215,92,181,54,229,151,166,208,216,143,134,107,209,183,61,67,254,156,8,255,88,186,127,82,81,110,188,232,232,83,255,16,206,126,7,125,239,166,206,24,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("778cb9df-4e29-46a4-8914-8863c3d25dbc"));
		}

		#endregion

	}

	#endregion

}
