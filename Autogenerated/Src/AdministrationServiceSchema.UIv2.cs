﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdministrationServiceSchema

	/// <exclude/>
	public class AdministrationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdministrationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdministrationServiceSchema(AdministrationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("260546d8-c216-4a8a-9485-5c95fe4484cf");
			Name = "AdministrationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("69d1b189-4578-43dc-961e-a0b2ba1c7b4a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,26,93,115,219,54,242,89,157,233,127,64,149,23,106,70,165,175,47,125,72,44,117,28,127,164,234,52,177,107,59,245,131,199,147,161,72,88,194,149,34,89,0,180,173,235,228,191,223,46,62,72,2,4,101,221,53,238,196,47,34,118,23,187,139,197,126,1,112,145,108,168,168,146,148,146,107,202,121,34,202,123,25,31,151,197,61,91,213,60,145,172,44,190,253,230,175,111,191,25,213,130,21,43,114,181,21,146,110,222,120,99,160,207,115,154,34,177,136,223,209,130,114,150,246,104,78,18,153,244,128,87,52,173,57,147,219,0,130,63,176,148,190,47,51,154,239,68,198,55,116,185,155,224,8,20,123,80,43,105,233,186,75,221,108,134,48,156,14,193,227,147,183,131,168,211,66,50,201,168,24,36,56,75,82,89,114,77,65,72,152,230,156,175,174,36,175,83,89,135,149,128,85,239,80,29,177,63,75,89,197,71,75,33,121,162,119,6,8,129,244,21,167,43,24,145,227,60,17,226,53,57,202,54,172,96,72,132,52,198,110,138,240,214,12,192,23,20,139,59,132,29,137,234,3,149,32,184,2,250,37,203,97,235,46,233,159,53,227,116,67,11,41,162,238,0,173,79,102,228,153,41,72,21,27,64,54,65,33,85,189,204,89,74,170,132,75,150,228,36,69,69,135,244,28,253,133,186,194,111,179,174,11,94,86,148,163,253,95,227,183,4,183,164,153,38,169,56,250,1,37,139,174,113,223,39,69,178,162,156,124,42,251,64,52,237,232,224,224,128,28,138,122,179,73,248,118,110,1,239,168,20,97,62,172,16,50,41,82,26,55,115,15,186,147,43,171,82,120,118,8,134,209,55,26,173,168,36,179,121,80,77,242,211,79,36,10,34,102,164,160,143,33,166,209,71,65,57,236,108,161,163,118,50,81,75,29,137,29,66,102,228,33,201,107,229,140,163,207,198,230,180,200,180,217,119,236,129,218,77,119,3,92,225,228,83,237,140,181,159,134,237,254,202,251,235,2,134,44,174,221,201,147,233,13,91,27,235,175,17,167,176,246,158,106,218,210,30,108,70,48,212,48,76,232,19,68,111,205,57,248,53,164,32,33,0,123,59,118,37,141,239,72,34,60,233,198,248,159,155,45,48,58,244,5,181,59,160,169,159,217,7,152,43,212,54,150,220,223,9,109,148,96,84,69,19,173,192,231,61,72,61,51,186,10,27,62,129,117,244,54,252,217,165,188,167,114,93,102,42,166,149,15,185,14,5,106,97,2,132,168,52,102,95,100,209,187,154,101,68,232,225,37,77,75,158,45,50,171,145,161,23,150,24,3,165,206,115,109,217,43,138,181,140,172,58,204,12,104,166,247,5,99,74,67,252,48,210,248,17,214,195,122,83,68,227,134,193,184,65,157,241,114,3,136,173,192,169,6,223,98,111,214,148,211,104,140,19,226,133,56,253,179,78,242,72,51,139,47,18,14,149,90,66,236,250,139,154,160,75,105,133,222,88,63,246,84,143,79,159,160,210,74,122,73,147,12,56,68,11,172,198,122,64,178,230,115,130,193,111,156,175,107,155,150,2,170,187,212,250,252,142,174,120,168,13,57,119,86,106,252,211,252,154,64,106,216,253,111,155,221,113,217,225,124,64,188,116,64,2,176,161,236,160,32,21,154,150,20,96,222,217,152,27,171,142,231,94,122,121,21,31,30,40,66,53,239,246,28,50,156,10,133,110,125,28,221,66,229,93,20,15,229,31,52,210,139,0,235,141,47,206,175,174,199,83,242,145,179,107,186,169,114,116,88,128,66,181,134,136,130,129,117,130,41,121,91,102,219,43,185,205,17,15,140,222,3,2,82,111,3,141,111,120,82,85,52,155,42,195,98,205,164,66,158,149,124,147,72,103,130,6,197,191,136,178,152,146,75,104,238,32,13,208,221,116,170,240,218,80,103,133,36,190,118,145,9,25,238,69,146,27,0,208,22,217,142,238,180,88,177,130,198,199,107,154,254,113,156,20,198,255,26,171,69,99,0,234,210,226,102,22,235,63,236,158,68,223,97,12,199,215,124,11,190,47,104,100,101,79,73,89,75,162,226,187,66,68,214,137,4,55,125,127,255,131,147,90,251,81,239,100,12,143,89,171,135,158,8,1,249,1,146,196,57,191,89,51,176,11,182,204,81,195,235,25,209,15,9,87,73,207,8,107,107,170,106,195,116,67,184,197,224,58,92,124,236,145,205,35,163,75,159,3,196,117,5,141,83,71,15,39,234,126,232,70,219,223,119,89,136,121,6,185,128,94,128,206,143,96,164,175,192,101,247,207,10,248,227,196,51,233,125,224,223,148,56,36,118,180,111,250,192,45,250,0,95,207,164,143,222,188,202,154,116,238,169,225,47,38,200,73,111,183,152,251,180,154,11,9,45,149,244,216,118,71,164,9,227,167,148,86,232,51,83,71,17,155,84,15,15,172,232,78,254,48,113,230,123,139,77,33,214,68,83,75,104,215,238,85,231,7,61,31,157,93,111,62,120,130,137,196,211,77,165,207,140,163,145,228,91,27,121,150,79,220,147,236,102,169,105,163,130,173,85,36,77,100,186,38,81,111,213,132,62,53,129,29,210,135,62,197,102,208,141,118,19,125,189,9,95,54,26,225,92,11,237,1,251,143,78,160,31,11,38,23,197,101,153,211,175,53,42,27,125,5,30,211,61,165,119,197,151,117,177,195,229,28,186,89,122,120,176,156,79,9,228,229,196,48,68,103,121,132,22,72,212,105,10,10,221,215,249,148,0,237,125,146,11,69,76,190,39,165,132,198,234,145,9,26,246,216,101,89,230,100,200,158,209,203,215,58,40,184,156,138,58,71,179,6,78,107,113,163,90,223,112,145,155,241,13,155,249,140,252,235,203,122,27,54,126,107,150,103,141,120,113,84,100,104,17,113,92,214,133,28,107,95,218,215,241,200,126,78,103,252,243,11,149,3,55,179,247,83,31,217,3,247,106,224,36,234,246,156,29,54,196,73,171,30,65,135,245,190,5,6,190,225,120,137,59,191,104,138,69,88,239,144,78,93,237,159,41,35,78,41,36,189,130,1,65,21,150,26,48,144,111,9,98,184,123,28,26,150,125,182,13,211,142,22,193,72,62,97,42,56,193,124,230,108,2,205,226,242,223,16,177,115,242,140,7,71,77,53,106,13,108,35,95,179,184,189,35,43,94,214,149,208,141,163,199,44,114,38,190,105,218,62,138,215,129,219,171,116,77,55,201,111,53,133,114,165,111,101,78,125,184,87,165,226,46,129,73,4,83,50,238,102,0,155,63,122,34,98,56,37,163,11,169,129,57,63,46,196,81,254,152,108,133,61,203,18,204,165,67,243,207,88,14,39,77,17,31,101,89,212,199,30,115,10,89,65,211,220,48,185,110,142,166,34,210,64,117,219,199,25,132,229,245,182,162,177,58,199,234,96,30,141,111,205,217,87,167,175,215,102,244,122,145,221,197,183,221,197,1,4,145,72,116,23,47,176,215,212,198,159,12,46,250,5,149,238,42,134,88,117,250,5,149,122,183,194,177,79,25,227,234,172,206,122,75,219,219,114,237,28,140,162,71,245,53,6,31,243,39,248,23,14,173,155,53,245,3,125,107,56,10,218,114,129,228,202,84,227,12,60,66,210,108,33,233,70,180,102,238,211,233,91,27,149,236,27,197,99,5,8,213,160,151,46,63,95,107,155,227,228,203,96,50,115,82,105,243,51,152,251,188,204,59,148,111,163,14,108,234,18,185,195,110,89,152,236,168,91,61,113,255,76,137,218,171,54,133,248,236,178,184,25,79,67,171,10,214,145,38,227,7,18,253,142,66,97,146,107,98,137,251,23,135,129,140,17,188,74,108,238,16,187,151,135,71,194,29,91,26,117,226,116,168,92,136,165,187,232,238,140,67,31,198,52,151,149,157,146,227,93,85,134,51,163,165,26,197,139,162,127,129,185,71,214,132,46,56,129,70,57,209,231,181,177,131,252,212,69,66,26,208,239,96,45,255,19,198,77,9,93,20,85,45,39,83,171,204,232,255,209,228,132,226,75,20,190,85,245,244,104,81,47,174,69,219,0,184,42,24,248,139,203,191,166,201,166,39,28,129,127,79,242,143,61,158,103,117,161,107,87,110,206,178,207,113,239,221,126,255,204,160,214,240,116,205,210,36,215,240,115,117,150,23,164,52,191,186,72,14,210,69,218,123,205,177,223,180,82,90,117,12,43,44,71,216,143,24,180,10,28,23,235,4,147,161,211,18,112,137,248,96,212,19,173,140,172,18,13,76,213,87,9,122,53,166,133,43,50,166,26,6,33,241,89,180,88,181,144,153,93,86,124,101,112,142,198,13,161,121,225,243,231,199,191,210,123,121,250,84,113,125,131,104,108,211,105,28,91,156,159,37,134,56,14,62,92,32,103,188,182,117,91,101,112,129,179,50,207,160,35,204,246,217,110,45,213,203,176,113,215,162,231,205,54,27,203,180,93,82,14,103,111,179,196,95,225,243,208,235,138,16,173,122,157,176,166,205,53,44,166,255,232,228,173,62,232,151,156,100,203,230,115,70,122,109,188,128,147,252,201,219,22,20,77,28,7,51,236,186,79,50,92,255,204,252,66,226,61,227,180,98,13,71,203,114,244,8,158,68,73,164,249,196,72,110,133,182,52,35,117,131,206,176,233,226,193,199,29,196,207,117,193,121,99,231,52,22,98,89,3,212,151,94,230,199,185,1,83,212,215,229,17,164,151,173,177,241,103,247,225,167,255,214,163,40,58,4,187,255,81,1,136,255,11,191,174,140,248,193,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("260546d8-c216-4a8a-9485-5c95fe4484cf"));
		}

		#endregion

	}

	#endregion

}

