﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EstimateLinksGeneratorSchema

	/// <exclude/>
	public class EstimateLinksGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EstimateLinksGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EstimateLinksGeneratorSchema(EstimateLinksGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea5c3369-0f0c-4f8b-b917-e7304c394e34");
			Name = "EstimateLinksGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,26,219,82,219,72,246,153,169,154,127,232,241,214,78,201,5,200,144,205,238,3,198,166,128,144,196,181,100,194,98,178,121,152,76,165,26,169,177,59,209,197,233,110,155,120,41,254,125,207,233,139,212,146,101,203,144,217,125,1,212,58,247,251,105,145,209,148,201,25,141,24,185,97,66,80,153,223,169,240,60,207,238,248,100,46,168,226,121,246,243,79,15,63,255,180,51,151,60,155,144,241,82,42,150,246,107,207,0,159,36,44,66,96,25,190,97,25,19,60,90,129,185,228,217,183,149,195,27,246,93,149,135,190,0,105,154,103,205,111,4,91,119,30,94,100,138,43,206,100,19,192,71,118,187,129,44,190,125,171,212,44,60,189,149,74,80,163,75,93,220,49,83,10,158,36,25,16,205,174,98,166,16,96,28,0,32,2,234,95,4,155,192,11,114,158,80,41,143,200,133,84,60,165,138,129,33,190,74,109,37,170,114,161,33,123,189,30,57,150,243,52,165,98,57,180,207,99,160,42,239,140,36,36,97,11,150,16,64,159,48,146,32,62,153,56,2,161,195,239,121,4,102,243,219,132,71,36,66,206,107,24,147,35,50,122,71,35,145,203,81,182,200,191,210,219,132,1,34,186,186,42,56,89,39,249,149,200,103,76,160,185,181,14,59,51,193,23,0,180,145,105,137,67,30,12,86,193,236,53,103,73,12,102,186,210,162,219,151,86,15,193,104,156,103,201,146,188,158,103,209,241,88,9,48,242,217,156,39,49,19,67,114,241,93,49,145,209,228,253,140,101,55,116,210,111,68,148,26,167,128,29,101,240,59,101,49,7,9,1,231,12,68,200,158,131,120,158,228,146,109,133,168,33,215,138,167,245,50,24,123,132,103,202,254,112,39,53,141,79,103,160,106,172,69,105,211,251,89,132,49,204,54,144,219,40,141,167,167,113,47,188,51,30,174,249,27,146,7,164,152,71,16,21,24,99,21,183,215,243,193,156,140,50,72,110,154,240,255,176,45,194,235,158,171,41,200,253,109,206,5,139,201,130,38,115,140,83,71,187,183,66,252,120,70,5,77,73,6,213,112,208,225,142,36,251,128,233,63,158,209,172,51,28,73,114,199,168,154,11,70,86,222,18,150,97,2,197,199,61,77,102,59,178,218,206,31,68,178,158,180,131,104,36,111,125,211,102,137,224,54,207,161,116,172,106,180,71,154,222,56,150,93,162,75,193,206,14,191,35,65,3,118,241,126,167,150,127,80,28,131,46,25,12,73,198,238,171,241,21,116,67,19,43,175,115,1,18,7,157,99,137,166,147,106,153,176,193,167,206,148,241,201,84,29,145,135,131,199,217,247,254,167,206,176,179,71,70,81,158,141,193,225,221,126,141,89,83,2,3,103,19,215,225,69,58,83,203,22,20,29,168,45,40,46,152,1,172,3,49,3,210,14,59,14,166,49,9,81,121,172,207,123,100,70,227,88,167,216,44,215,25,23,243,197,24,21,221,206,52,111,5,187,51,127,238,145,10,189,110,51,123,79,208,54,227,131,217,123,116,216,113,132,30,9,75,192,14,127,130,51,21,134,40,196,148,128,183,224,206,131,79,29,18,177,36,177,130,195,9,56,214,158,225,188,225,157,161,167,207,225,248,170,166,99,139,179,129,165,40,253,209,226,102,208,186,9,186,234,97,173,194,214,46,150,16,152,91,251,215,146,220,41,189,160,98,240,66,237,216,26,243,21,95,56,239,215,200,147,147,19,23,177,37,172,126,227,16,138,148,89,67,187,115,76,201,20,194,203,55,62,234,243,231,69,150,247,8,98,87,15,180,210,46,244,214,22,152,149,34,180,227,117,38,148,68,79,66,175,168,162,53,47,164,60,101,55,203,217,150,89,118,170,20,141,166,12,200,78,156,245,154,9,175,73,150,255,137,80,158,48,14,177,85,44,253,235,177,161,227,22,167,245,54,92,233,194,52,83,56,120,153,249,13,223,86,198,57,132,192,169,129,92,231,247,151,44,155,168,233,37,79,185,2,141,15,15,250,205,144,46,6,1,230,229,58,24,155,236,0,242,247,53,16,94,73,88,199,204,14,89,101,185,212,121,92,13,240,162,193,64,195,135,194,1,13,230,16,27,140,171,168,246,25,19,97,61,131,34,33,53,125,136,106,18,131,51,246,57,44,5,251,64,246,171,174,120,210,155,216,247,245,196,190,95,21,0,24,181,178,241,114,25,121,221,243,88,77,93,79,36,213,22,73,22,216,225,35,154,236,195,80,52,1,197,82,30,199,9,235,147,187,36,167,0,149,176,59,213,223,192,13,39,134,146,19,208,236,141,153,88,240,136,189,203,99,150,244,206,169,100,215,20,247,153,119,52,131,240,75,89,166,44,64,40,23,81,15,222,49,132,233,129,90,189,135,23,143,27,56,221,228,95,89,230,179,211,129,250,116,150,99,22,193,140,84,48,254,253,4,127,141,226,1,72,112,242,71,139,12,69,94,105,23,242,116,66,164,136,192,41,232,200,35,144,164,127,11,180,254,241,114,79,59,137,104,187,15,128,162,181,185,254,147,38,10,189,248,55,4,232,109,242,227,74,97,169,241,52,97,97,121,28,150,60,14,11,30,47,74,30,173,233,107,135,232,234,12,189,113,58,12,108,97,125,220,6,118,132,123,49,48,82,176,171,159,70,17,147,18,150,199,233,234,153,43,214,159,27,222,129,254,13,167,253,45,10,148,55,210,123,37,202,183,124,163,124,77,66,244,91,177,154,206,140,82,19,166,252,129,184,89,199,1,201,230,137,215,180,214,88,194,227,18,54,112,172,118,71,193,96,45,200,214,235,99,224,30,125,213,90,119,163,207,172,5,162,255,36,114,205,0,255,214,43,23,180,60,19,20,109,44,113,176,193,222,216,186,206,140,228,107,179,42,185,137,65,247,95,121,201,165,210,179,3,212,208,11,179,45,193,44,228,96,203,132,68,88,200,73,44,28,150,21,68,217,69,154,67,33,133,92,178,152,221,138,1,112,77,58,33,159,249,214,140,137,9,132,21,34,100,123,217,113,84,120,10,71,176,222,7,201,4,68,72,102,46,226,194,55,76,21,236,44,84,208,89,79,168,179,89,231,39,26,176,221,2,79,38,56,252,1,105,182,180,206,182,100,173,173,182,43,89,94,77,94,185,214,192,3,20,12,187,135,147,172,0,172,220,81,216,18,93,213,162,254,248,64,160,76,245,137,196,31,45,101,245,29,83,211,60,94,91,83,109,31,171,132,11,86,31,202,225,32,176,111,237,22,100,30,188,9,21,103,55,59,250,218,151,110,144,197,54,216,41,78,139,157,166,90,55,23,84,16,121,139,135,43,163,242,225,193,139,151,118,232,149,183,110,171,216,84,126,194,198,21,206,238,111,87,235,86,116,187,57,61,133,1,106,239,47,0,110,2,94,93,2,158,65,188,182,138,5,93,107,3,219,27,192,20,55,185,49,84,208,93,215,83,205,80,223,228,254,92,65,248,176,120,67,136,94,107,62,146,208,217,12,130,80,231,2,153,139,100,77,168,234,19,35,154,28,226,229,149,221,87,143,123,238,208,68,154,229,75,22,92,168,57,77,202,152,83,167,37,31,192,15,252,192,152,229,66,209,100,12,131,55,82,30,212,46,230,49,173,181,233,130,106,102,236,145,206,149,143,88,196,160,185,246,177,230,196,198,110,143,71,242,55,136,200,247,66,191,14,42,76,187,69,127,247,122,183,63,221,84,59,188,107,214,186,226,232,93,43,98,129,91,220,172,3,125,228,95,76,50,216,9,226,132,124,100,183,31,20,79,244,103,13,164,113,6,37,169,102,31,15,61,188,102,223,32,112,148,219,253,143,182,55,208,70,211,60,154,240,113,2,87,12,226,71,92,99,248,0,79,73,4,139,114,17,19,30,147,59,145,167,4,86,177,57,78,247,36,191,253,2,34,108,10,37,255,6,213,161,117,134,167,53,2,254,213,104,37,2,175,29,227,214,0,124,51,7,233,64,88,131,49,138,3,67,186,144,213,143,67,163,78,33,196,160,84,136,74,242,79,182,212,70,190,162,92,20,151,239,72,125,120,82,73,220,42,145,240,45,149,26,141,156,212,223,232,99,243,19,82,22,41,121,247,149,219,87,250,182,86,228,242,220,102,162,190,52,39,119,48,179,166,250,59,209,83,157,36,75,47,201,45,220,36,231,137,90,83,43,76,243,91,45,20,230,251,149,9,232,154,179,164,239,45,38,191,217,126,162,191,16,46,199,208,229,83,250,175,57,19,203,90,34,132,62,128,89,66,5,38,135,183,218,95,226,102,239,46,177,86,232,157,231,201,60,205,76,213,183,127,15,144,127,120,26,199,230,57,128,90,4,47,29,5,15,50,124,143,119,167,175,184,176,253,124,64,170,7,225,43,38,35,112,51,104,111,155,160,177,132,71,226,55,240,0,224,249,68,241,168,2,174,219,212,40,174,32,212,36,212,253,44,28,197,157,238,42,58,46,204,21,220,231,206,116,166,70,157,192,72,96,254,58,106,150,2,27,106,147,28,174,163,254,63,101,121,103,121,86,228,65,200,215,60,129,38,45,17,35,192,231,115,1,98,48,115,250,145,171,233,21,70,61,67,144,192,28,158,231,41,100,2,151,121,134,244,194,139,111,16,217,16,104,35,121,10,174,94,48,40,195,176,215,179,110,37,204,202,207,236,68,214,3,82,90,39,66,86,212,129,107,33,238,117,187,95,86,201,132,167,217,50,112,67,138,27,48,86,62,145,232,82,201,113,204,247,235,101,153,123,253,34,245,162,124,174,235,99,3,167,115,124,85,66,138,252,30,149,8,12,198,110,253,186,113,159,28,118,73,175,118,90,193,198,243,41,242,50,20,122,154,162,7,1,41,202,51,200,167,2,226,175,43,16,186,6,181,76,158,6,106,171,249,173,246,53,165,24,220,112,66,70,81,190,3,175,131,146,191,92,74,29,102,166,156,124,24,161,125,219,203,147,63,89,156,45,49,44,131,206,216,82,130,56,5,50,134,3,22,242,0,217,112,205,21,126,29,27,155,255,250,171,21,230,216,216,5,94,237,238,238,149,246,218,223,47,70,158,103,232,222,244,241,198,205,63,133,72,95,140,72,95,140,72,214,145,187,36,40,125,54,36,7,208,23,15,161,141,29,116,27,36,254,130,18,235,179,221,221,242,2,70,27,181,30,120,141,193,248,187,198,253,163,239,33,234,26,218,4,140,6,199,164,181,181,65,235,123,12,176,195,160,86,136,139,79,42,182,98,193,252,124,157,231,202,76,174,13,115,110,13,60,241,239,103,183,217,95,205,245,104,89,228,58,93,48,89,253,238,245,200,187,247,109,96,88,126,17,181,223,35,74,41,246,60,5,192,216,113,237,43,132,174,40,207,190,113,41,124,166,109,111,91,212,214,214,215,195,85,176,210,216,10,209,204,71,38,75,20,70,236,114,132,242,24,151,156,141,135,170,118,232,132,33,12,37,82,245,160,126,51,123,41,221,3,89,240,177,135,55,217,15,135,143,56,60,215,115,120,207,41,83,10,227,236,29,185,141,90,135,67,227,170,109,54,85,39,84,221,226,245,132,44,8,150,16,246,26,177,254,233,170,212,117,157,141,161,254,49,154,154,217,170,218,242,27,172,234,214,22,223,154,245,139,1,253,95,83,25,126,179,128,117,245,76,95,182,219,165,85,131,192,234,66,227,211,36,57,91,42,38,139,74,233,68,245,110,16,182,139,8,195,125,24,172,78,9,63,234,7,179,224,215,215,250,231,184,164,118,209,251,163,165,85,223,15,184,133,237,185,173,202,93,50,84,175,24,44,161,246,107,6,120,54,167,213,67,56,251,47,143,87,163,183,104,40,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea5c3369-0f0c-4f8b-b917-e7304c394e34"));
		}

		#endregion

	}

	#endregion

}
