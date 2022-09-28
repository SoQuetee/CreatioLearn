﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicatorSchema

	/// <exclude/>
	public class DeduplicatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicatorSchema(DeduplicatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b101bb1-30c4-4d3d-b6ef-6f6e0f4efe33");
			Name = "Deduplicator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d3b16cd4-e124-46c1-8f09-d3b70a775b3e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,75,111,219,70,16,62,43,64,254,195,66,189,80,128,64,223,35,75,65,108,217,169,210,56,49,106,167,61,24,70,176,22,87,209,54,228,82,225,46,237,168,129,255,123,103,223,124,44,45,170,118,210,22,232,37,33,151,179,243,248,102,190,217,33,101,134,51,194,55,120,73,208,37,41,10,204,243,149,136,143,115,182,162,159,202,2,11,154,179,248,36,195,52,61,163,140,178,79,207,159,125,123,254,108,80,114,184,68,23,91,46,72,54,105,220,195,222,52,37,75,185,145,199,175,9,35,5,93,182,100,230,88,224,214,226,91,202,190,248,69,239,204,9,3,21,235,140,48,17,47,152,32,197,10,124,229,33,193,227,60,203,114,22,126,82,144,174,245,120,126,212,249,232,20,47,69,94,80,101,14,100,126,42,200,39,136,11,57,55,94,160,197,156,36,229,38,165,75,12,130,74,232,224,224,0,29,242,50,203,112,177,157,153,251,243,34,191,165,9,225,168,20,52,165,98,139,50,34,214,121,194,209,42,47,80,226,52,72,221,249,10,101,148,145,4,37,128,81,108,245,29,84,20,110,202,27,144,70,212,58,209,244,97,240,77,249,225,188,61,211,182,94,160,115,181,81,63,108,122,169,22,206,112,241,153,27,243,0,55,21,16,249,24,137,53,22,8,23,4,225,180,32,56,217,162,77,65,56,60,6,15,208,50,103,2,48,26,35,204,145,245,129,240,216,89,56,104,154,56,220,224,2,103,136,65,209,77,135,0,9,88,89,81,146,28,107,61,67,39,55,167,170,132,96,235,24,221,173,9,88,255,76,182,136,90,239,140,93,36,200,87,161,93,133,135,9,194,44,65,183,56,45,137,148,244,218,173,120,197,47,229,70,216,43,27,249,112,118,86,67,34,174,238,186,205,193,156,199,157,152,0,100,97,71,222,247,195,215,37,77,198,72,254,59,67,173,104,1,219,75,240,255,196,232,119,134,70,19,147,64,194,18,157,67,117,127,175,107,176,190,104,147,124,156,98,14,41,238,85,141,115,178,194,101,10,249,203,54,41,145,188,114,149,119,200,9,65,203,130,172,166,195,30,205,32,174,21,222,240,96,22,44,215,43,99,238,136,178,4,54,69,98,187,33,249,42,170,237,29,141,174,125,97,47,101,40,181,72,80,139,103,205,26,63,165,36,85,37,94,208,91,200,134,126,184,209,55,72,86,109,206,210,45,250,192,73,1,209,48,221,158,208,199,178,118,31,70,221,35,12,13,77,20,165,108,8,125,184,180,96,144,75,156,210,63,33,177,24,49,114,7,116,225,2,51,224,235,254,64,55,112,214,16,245,101,89,61,202,225,76,162,32,25,97,22,106,101,109,82,80,181,23,53,80,171,171,27,33,121,32,12,6,13,44,209,20,181,192,29,152,10,238,139,215,226,169,1,179,166,238,168,88,163,101,201,69,158,245,209,187,56,95,231,140,188,43,179,27,25,80,6,96,17,91,236,79,13,127,107,243,38,96,122,166,252,65,76,173,130,38,189,252,184,52,142,81,40,74,20,48,191,87,194,7,31,149,6,167,111,26,210,88,45,141,46,242,193,1,186,33,133,108,142,29,28,15,186,95,183,62,217,41,127,94,115,86,199,249,137,8,115,53,40,136,40,11,214,208,138,94,190,68,81,43,76,89,191,1,11,81,3,181,209,72,195,116,95,129,192,122,248,51,230,235,11,34,14,245,225,161,45,92,66,239,228,147,110,169,115,39,180,195,123,45,227,93,215,247,83,244,54,199,137,87,18,133,252,235,74,145,31,51,66,249,169,251,217,52,99,124,188,197,5,226,68,78,143,224,74,116,161,174,70,18,74,125,217,66,79,7,54,144,35,103,153,177,104,40,7,192,146,153,73,74,170,94,36,67,35,20,159,22,121,166,36,228,250,205,182,38,58,28,193,100,9,147,234,155,156,54,181,184,253,239,155,79,164,238,120,193,79,190,148,56,109,110,26,163,97,197,244,239,114,126,145,34,9,169,108,209,78,199,231,146,180,4,70,185,104,168,16,25,90,204,245,64,26,205,143,78,190,146,101,41,79,193,228,198,93,78,155,135,23,76,201,188,44,200,252,200,47,65,246,108,238,141,174,133,28,79,126,133,211,16,106,180,208,255,77,13,224,177,86,77,244,211,200,155,242,74,108,5,201,132,212,210,25,105,93,48,237,139,87,105,170,227,250,77,78,97,220,60,15,39,198,196,169,139,43,72,1,53,100,201,90,169,237,231,81,189,152,204,112,183,72,248,88,43,204,75,129,90,51,152,221,3,103,56,96,49,155,233,78,180,223,150,92,64,38,185,5,68,43,0,4,189,3,241,101,238,181,68,224,252,84,142,125,99,164,175,170,192,25,157,142,97,90,245,19,41,123,60,143,140,15,195,214,35,221,207,218,235,23,4,23,203,117,215,211,62,196,84,38,195,220,115,4,114,110,1,95,91,4,226,145,199,238,223,75,162,187,53,77,9,178,148,145,146,21,19,131,129,172,60,95,3,160,217,115,171,66,44,207,43,135,200,196,106,184,201,243,20,94,127,244,144,48,173,28,9,177,146,134,161,42,218,161,243,1,174,14,6,116,133,34,163,189,226,182,33,195,149,243,252,58,126,149,36,29,134,108,185,54,138,198,219,184,71,36,229,164,162,93,179,99,79,237,1,189,230,226,126,87,227,105,181,2,163,84,53,163,5,91,229,141,22,68,161,247,24,25,196,151,107,146,97,119,187,146,111,38,22,169,78,189,20,116,66,178,232,46,214,107,121,24,117,55,98,107,226,210,156,126,20,223,3,68,215,110,87,41,170,227,106,80,178,155,139,244,191,78,66,186,147,125,53,218,185,116,167,36,81,82,157,187,109,129,106,136,61,177,160,4,174,104,114,13,251,188,146,73,103,197,218,211,88,110,155,4,74,88,157,157,31,54,9,92,207,237,71,10,251,165,33,90,156,192,219,3,41,240,77,106,130,241,31,111,172,140,133,67,171,64,165,254,15,202,75,47,168,242,210,151,205,242,130,225,231,132,1,175,221,183,141,173,107,228,192,152,104,56,247,95,187,46,4,22,37,135,113,169,53,12,41,13,206,113,45,7,153,165,92,240,5,211,90,129,41,23,10,74,200,93,239,178,108,199,105,139,84,197,98,139,39,26,133,48,109,195,118,74,89,50,247,223,128,106,83,74,255,207,64,218,249,218,183,32,81,185,177,169,120,11,209,55,211,85,183,105,222,60,188,160,137,99,80,245,188,182,69,67,57,211,159,213,218,79,168,26,112,170,206,196,117,139,53,220,219,74,116,247,106,6,236,78,162,95,200,54,176,41,118,199,154,77,142,60,116,186,61,148,35,181,108,136,21,14,27,114,116,192,84,121,169,105,183,228,142,65,113,210,83,90,31,85,90,186,107,78,53,105,170,15,209,1,152,244,16,109,48,8,204,193,149,201,23,201,9,214,140,180,234,218,204,170,122,239,42,135,86,180,92,163,40,144,251,64,234,229,151,221,110,184,29,200,166,77,54,220,86,199,88,51,148,171,135,178,124,109,186,92,56,203,144,221,198,180,209,192,28,125,102,249,29,51,218,206,237,80,110,6,146,150,43,214,152,178,86,123,225,143,207,176,88,174,95,177,96,73,170,84,140,3,166,170,231,70,71,185,169,97,37,20,152,239,254,182,191,215,7,159,96,160,239,101,98,91,180,55,19,210,195,225,118,237,247,147,97,87,228,79,27,101,251,20,123,136,168,251,53,97,240,162,32,156,147,31,212,127,157,185,94,173,215,72,215,154,110,117,45,208,110,157,129,118,167,53,143,250,246,88,35,254,64,119,109,184,2,204,123,151,139,102,107,125,210,166,214,61,17,227,10,176,110,234,174,54,60,251,242,35,63,182,24,199,221,56,230,250,93,13,240,26,222,174,199,53,130,246,133,190,119,123,107,1,236,200,103,134,67,197,63,151,53,31,98,31,218,186,109,211,154,219,134,158,1,118,186,194,241,196,180,123,246,163,164,83,244,55,216,248,38,191,249,65,68,148,150,122,113,16,4,107,252,179,247,1,238,73,157,109,218,193,106,95,202,129,232,3,116,171,88,254,71,169,246,135,134,110,39,203,192,223,75,42,82,210,166,153,195,212,65,234,232,85,9,242,17,212,170,1,25,164,149,202,138,10,165,15,155,148,244,212,121,216,205,34,89,2,158,64,82,116,63,242,200,253,125,126,224,248,255,71,250,239,240,35,189,249,25,236,187,254,86,95,249,233,162,251,165,236,161,215,196,144,169,234,95,2,52,149,87,39,142,142,201,103,95,149,166,119,182,59,247,190,138,164,150,174,241,16,52,192,101,212,142,99,212,122,36,109,87,154,101,165,102,131,109,178,235,43,135,223,183,251,103,172,208,31,87,192,218,95,64,157,183,108,29,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b101bb1-30c4-4d3d-b6ef-6f6e0f4efe33"));
		}

		#endregion

	}

	#endregion

}
