﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCGroupsAnalyzationRuleSchema

	/// <exclude/>
	public class DCGroupsAnalyzationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCGroupsAnalyzationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCGroupsAnalyzationRuleSchema(DCGroupsAnalyzationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49a65343-cc00-4d2e-8ce3-c820097262a4");
			Name = "DCGroupsAnalyzationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("69e28147-db31-49df-9976-b6fb9eb762c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,77,111,219,48,12,134,207,14,144,255,64,100,151,4,24,236,123,147,6,200,210,161,216,97,31,232,50,236,44,203,180,35,76,31,134,36,175,245,138,254,247,81,178,149,197,69,82,236,98,192,20,249,242,37,31,73,51,133,174,101,28,225,128,214,50,103,106,159,239,141,174,69,211,89,230,133,209,249,93,175,153,18,156,130,30,181,159,207,158,231,179,172,115,66,55,147,10,165,140,94,207,103,116,246,206,98,67,117,176,151,204,185,27,184,219,223,91,211,181,110,167,153,236,255,68,201,135,78,98,76,45,138,2,54,174,83,138,217,126,59,254,127,247,212,23,155,30,44,58,35,127,163,5,75,233,224,143,204,3,11,26,14,29,120,84,173,164,52,104,162,118,158,180,138,51,177,182,43,165,224,192,131,141,107,46,32,248,75,29,31,198,134,131,189,236,57,90,252,55,142,209,206,219,142,123,99,105,170,111,81,124,200,120,61,69,12,156,165,131,55,208,90,108,153,69,80,88,137,78,1,63,50,161,65,155,10,225,81,248,35,77,135,160,241,201,199,89,243,147,104,241,90,117,67,34,76,1,1,193,219,5,15,68,158,252,98,187,211,32,168,27,211,68,209,212,228,5,17,184,197,250,118,65,195,97,163,8,91,156,120,63,22,20,219,97,43,249,166,136,122,151,229,131,159,176,138,197,246,167,144,18,74,164,33,12,71,231,176,2,81,147,121,112,9,149,107,145,139,90,96,53,81,28,1,92,89,253,242,162,55,24,135,122,127,133,11,36,87,171,208,33,203,110,160,100,14,151,167,170,211,49,132,107,154,189,140,12,81,87,3,198,41,211,207,232,143,166,250,31,156,63,194,173,155,44,150,174,124,41,52,61,131,100,51,172,149,246,66,40,137,115,96,77,27,170,134,183,3,165,52,252,151,123,11,172,69,223,89,237,222,100,121,177,37,221,175,179,36,221,73,73,81,226,144,4,207,72,24,90,162,21,116,231,166,171,79,106,31,104,147,112,143,62,253,239,218,150,170,88,41,241,96,34,177,113,169,25,77,185,28,121,229,135,241,37,230,3,228,252,147,251,66,22,190,218,143,170,245,253,114,149,74,178,193,14,241,121,132,11,131,36,185,213,58,102,191,196,111,42,33,189,245,117,152,67,116,26,164,216,95,124,243,203,150,216,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49a65343-cc00-4d2e-8ce3-c820097262a4"));
		}

		#endregion

	}

	#endregion

}
