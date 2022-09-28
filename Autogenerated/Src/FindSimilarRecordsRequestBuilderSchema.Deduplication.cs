﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FindSimilarRecordsRequestBuilderSchema

	/// <exclude/>
	public class FindSimilarRecordsRequestBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FindSimilarRecordsRequestBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FindSimilarRecordsRequestBuilderSchema(FindSimilarRecordsRequestBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bffe86b7-a6ca-4b6e-b415-04e84ac0b4dc");
			Name = "FindSimilarRecordsRequestBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,91,111,219,54,20,126,86,129,254,7,194,221,131,12,24,10,54,12,24,80,231,130,92,154,204,104,179,101,113,178,151,160,40,24,233,40,38,32,75,14,73,117,19,60,255,247,29,94,36,81,18,29,59,65,95,154,146,58,215,239,124,231,144,116,78,151,32,86,52,6,114,7,156,83,81,164,50,58,47,242,148,61,149,156,74,86,228,209,5,36,229,42,99,177,94,189,127,183,126,255,46,40,5,203,159,200,188,18,18,150,211,222,26,181,179,12,98,37,44,162,43,200,129,179,120,32,243,133,229,207,237,166,235,153,195,182,253,232,83,46,153,100,32,182,10,92,210,88,22,220,72,160,204,7,14,79,24,5,57,207,168,16,31,201,37,203,147,57,91,178,140,242,91,136,11,158,136,91,120,46,65,200,179,146,101,9,112,173,115,112,112,64,14,69,185,92,82,94,29,219,245,5,164,180,204,36,97,203,85,6,75,200,165,70,130,20,41,145,11,64,105,0,18,115,72,143,70,179,93,46,70,7,199,132,229,18,120,138,128,71,181,187,131,158,63,101,145,102,162,120,133,85,212,124,176,97,158,161,52,98,19,202,106,5,69,26,238,212,30,143,191,162,246,170,124,196,18,147,88,65,181,19,41,242,145,236,52,139,54,215,26,209,166,12,151,12,178,4,235,112,195,217,119,42,193,124,92,153,5,225,64,147,34,207,42,114,47,128,35,255,114,195,32,242,173,236,172,167,94,157,217,133,37,40,136,219,50,131,107,154,211,39,140,242,91,226,219,158,218,168,32,79,76,96,221,40,209,151,144,188,84,68,82,177,106,88,108,168,6,162,93,137,135,74,54,232,165,209,205,98,162,69,182,68,237,13,122,76,214,90,167,7,7,57,34,30,124,2,127,226,40,188,13,144,32,216,188,140,202,53,200,69,177,181,120,179,79,121,185,4,78,31,51,56,188,42,89,114,76,174,64,226,24,40,151,249,253,44,17,225,23,38,228,97,55,219,75,150,97,27,28,247,34,50,187,162,206,54,197,166,166,241,130,132,223,41,39,28,191,99,243,188,172,17,176,148,132,42,132,232,142,87,55,148,11,8,149,94,52,47,74,30,67,19,210,132,20,165,36,74,142,136,238,151,113,99,41,168,20,95,145,100,178,228,121,95,204,224,172,80,171,255,221,116,33,209,179,170,82,56,24,215,102,173,67,35,12,253,35,199,212,0,19,241,2,150,244,15,156,193,19,15,138,113,3,97,29,149,2,2,180,169,185,214,196,154,246,40,97,166,164,253,108,43,140,99,88,206,144,214,52,143,225,172,82,222,194,214,241,120,218,90,22,207,104,48,135,127,136,107,228,175,18,120,21,238,225,102,226,164,211,192,136,141,112,154,44,89,126,203,158,22,82,160,249,20,71,27,24,220,166,195,42,219,148,21,74,185,39,255,0,67,140,78,147,196,20,34,116,161,136,204,158,136,84,131,158,85,168,21,54,198,198,145,147,233,166,201,87,232,195,232,190,223,82,253,84,79,87,171,118,117,18,205,125,90,39,39,222,81,21,88,250,168,176,177,8,150,5,62,191,19,164,197,120,234,97,210,11,205,131,22,125,31,68,232,97,87,189,165,217,56,31,212,73,195,97,166,90,125,204,42,131,170,96,254,105,18,13,156,163,219,158,241,14,33,90,154,113,16,234,56,53,76,251,157,138,197,28,182,100,24,142,61,20,169,7,129,47,220,134,39,181,224,89,145,84,232,73,15,129,91,187,182,205,219,49,154,106,135,202,108,173,21,245,71,75,96,226,86,244,11,141,248,120,56,6,234,130,91,217,187,66,149,47,244,22,214,86,164,25,149,23,84,210,207,80,133,62,36,116,84,230,191,110,197,140,151,27,188,38,176,127,109,150,70,40,106,139,208,199,125,94,14,132,141,127,37,172,120,236,124,184,195,59,68,135,199,63,141,214,174,207,205,135,181,99,116,51,218,131,191,109,174,154,191,246,236,188,46,18,200,66,59,52,133,51,49,205,81,25,188,245,4,81,105,39,125,223,76,55,28,94,184,44,5,219,141,67,83,147,9,241,198,219,99,99,143,55,175,61,151,82,91,168,55,156,76,237,160,196,12,92,180,162,173,163,176,111,108,58,48,101,233,135,22,7,140,236,178,221,209,249,155,102,37,244,99,104,213,153,88,101,180,210,66,118,22,55,54,20,30,219,11,163,94,32,146,178,92,40,239,157,240,28,20,186,197,61,175,241,216,110,245,161,99,233,107,29,74,208,179,17,233,128,117,155,59,89,54,145,111,8,224,1,214,141,162,53,92,83,202,195,159,86,37,104,187,83,29,136,253,142,157,52,114,78,99,54,114,237,94,43,167,250,180,149,80,171,246,91,93,35,21,150,110,35,195,241,99,178,118,178,219,212,226,155,33,42,195,234,180,208,88,44,39,14,2,45,80,91,135,227,11,166,117,52,194,59,55,119,223,77,157,203,186,126,71,177,124,129,175,79,153,20,241,190,79,169,72,255,181,123,225,80,250,146,23,203,57,62,13,160,150,25,155,199,151,251,56,112,198,148,145,33,175,53,138,133,220,237,216,153,112,166,238,194,180,174,255,70,176,135,197,33,3,247,82,234,95,40,218,243,166,51,115,88,34,220,209,162,223,5,54,238,129,138,61,7,142,6,215,231,253,3,194,73,250,246,28,38,131,208,59,183,151,246,196,50,33,118,206,176,206,225,69,134,25,118,46,63,126,186,216,57,209,27,18,111,168,159,61,6,188,205,79,70,179,100,68,54,86,178,206,198,77,206,189,163,119,110,53,110,83,254,144,62,235,223,132,95,209,119,15,127,62,138,34,3,9,225,232,183,232,231,95,162,95,201,127,118,32,16,38,72,2,43,14,10,219,36,82,63,44,236,254,213,226,13,253,175,127,62,121,69,255,239,241,203,192,15,30,17,182,120,157,40,246,81,127,97,248,154,221,238,230,230,127,172,126,98,254,75,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bffe86b7-a6ca-4b6e-b415-04e84ac0b4dc"));
		}

		#endregion

	}

	#endregion

}
