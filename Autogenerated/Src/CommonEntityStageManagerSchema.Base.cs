﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CommonEntityStageManagerSchema

	/// <exclude/>
	public class CommonEntityStageManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CommonEntityStageManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CommonEntityStageManagerSchema(CommonEntityStageManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88b8732c-7386-4226-8e0d-422cd49bc74d");
			Name = "CommonEntityStageManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,219,78,219,64,16,125,6,137,127,24,168,132,28,9,57,82,31,9,80,137,187,165,130,80,3,188,84,125,216,216,19,216,214,222,141,246,146,42,130,252,123,199,187,107,98,59,54,55,169,15,32,237,120,230,204,153,153,51,19,193,10,212,51,150,34,220,162,82,76,203,169,137,79,164,152,242,7,171,152,225,82,108,109,62,109,109,110,88,205,197,3,140,23,218,96,49,106,189,201,63,207,49,45,157,117,124,129,2,21,79,87,62,39,82,97,124,206,82,35,21,71,189,178,215,211,41,236,179,199,103,194,112,227,3,201,229,139,194,7,74,3,39,57,211,122,159,176,139,66,10,231,178,24,27,246,128,87,76,208,127,229,124,135,195,33,28,104,91,20,76,45,142,194,219,7,64,90,21,56,201,17,208,133,131,46,227,161,240,0,113,21,63,108,1,28,104,68,150,107,9,169,194,233,225,78,163,83,113,23,17,23,245,228,191,36,226,146,107,234,195,34,101,185,243,218,11,132,220,227,148,25,182,7,73,189,166,196,127,249,129,51,169,121,25,248,212,149,176,130,229,21,236,114,185,3,195,146,241,207,83,156,50,155,155,99,46,50,234,109,100,22,51,148,211,40,89,39,122,255,117,48,248,69,17,51,59,201,121,10,105,217,223,222,246,194,62,172,27,15,122,200,172,215,72,105,54,94,47,179,15,235,168,44,170,148,227,74,8,164,57,163,108,169,46,210,195,141,99,239,166,95,85,210,87,67,116,167,81,81,180,240,194,5,219,120,58,142,196,242,2,77,141,85,171,144,163,32,157,22,249,42,246,115,21,6,204,181,128,128,234,172,65,69,99,52,166,220,24,189,110,27,56,239,125,152,48,141,81,171,180,30,214,189,137,59,241,193,77,97,233,91,253,5,69,230,231,17,222,97,56,87,104,30,101,86,206,69,241,57,51,24,6,227,31,48,145,50,135,75,166,87,29,160,59,98,11,17,5,240,141,57,83,21,215,244,17,11,6,135,208,28,90,181,112,238,107,152,107,124,78,90,79,72,20,76,164,120,188,184,166,243,22,245,182,46,110,216,28,76,25,48,24,185,8,133,198,42,209,160,240,45,246,28,181,75,19,224,223,2,110,23,232,82,192,246,33,8,155,231,163,90,31,171,206,204,37,207,128,144,86,129,183,242,196,42,69,76,206,68,230,160,35,95,122,32,183,182,99,32,243,236,229,81,239,39,237,181,105,72,50,201,224,208,247,167,71,169,116,209,205,247,118,84,228,243,198,52,216,242,58,250,186,238,89,110,105,221,235,169,227,36,27,208,159,239,103,95,130,187,89,70,85,71,29,212,246,64,224,95,56,229,110,218,148,231,128,118,157,186,75,57,38,191,73,2,71,161,176,141,39,248,204,12,246,128,46,7,194,210,97,44,7,163,143,41,90,26,98,128,89,53,185,240,4,57,167,223,47,158,133,33,146,91,138,90,223,40,156,115,105,181,99,164,63,50,187,176,246,109,23,106,203,218,120,203,93,143,187,19,86,153,26,200,77,16,63,34,62,133,104,187,115,39,171,44,97,43,188,187,111,221,133,165,74,195,245,32,53,65,175,54,70,47,50,124,108,94,61,77,81,175,200,111,197,166,75,132,65,38,43,205,93,219,98,130,106,240,186,232,142,109,254,39,8,175,77,230,221,170,251,188,232,186,52,247,134,134,18,97,80,21,152,113,162,252,95,117,84,106,160,30,90,93,42,216,221,109,237,182,166,107,244,162,139,55,238,85,151,4,7,117,21,149,105,27,99,76,244,216,166,101,229,83,235,114,183,62,18,50,60,63,195,246,186,249,133,82,125,35,58,218,247,238,173,88,246,92,134,96,107,30,11,178,253,3,209,52,229,8,84,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88b8732c-7386-4226-8e0d-422cd49bc74d"));
		}

		#endregion

	}

	#endregion

}

