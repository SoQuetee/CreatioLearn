namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SplitTestStatusValidationRuleSchema

	/// <exclude/>
	public class SplitTestStatusValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SplitTestStatusValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SplitTestStatusValidationRuleSchema(SplitTestStatusValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("219a848e-eacd-4e66-a390-448dd194d011");
			Name = "SplitTestStatusValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,193,110,155,64,16,61,19,41,255,48,162,7,219,82,5,61,59,198,135,36,110,132,212,40,85,236,244,190,129,1,175,10,11,218,157,109,226,90,254,247,14,187,96,104,221,67,36,4,236,236,155,247,230,237,204,42,81,163,105,69,134,176,67,173,133,105,10,138,238,26,85,200,210,106,65,178,81,215,87,199,235,171,192,26,169,74,216,30,12,97,125,115,94,79,83,52,70,27,69,146,36,26,6,48,36,142,99,88,25,91,215,66,31,214,253,250,25,91,141,6,21,25,160,61,194,182,173,36,237,208,16,24,18,100,13,252,18,149,204,157,44,104,91,97,52,208,196,19,158,214,190,86,50,131,172,18,198,140,12,91,71,240,227,156,255,204,233,176,132,244,81,200,138,75,237,182,241,239,93,166,58,186,66,131,79,26,203,78,242,17,105,223,228,102,9,223,157,132,223,252,215,70,23,8,54,239,152,89,194,105,189,69,163,47,253,12,38,46,93,248,72,43,180,168,65,113,15,146,176,75,193,112,189,227,115,113,191,142,113,20,136,86,177,67,143,201,26,201,106,101,214,169,98,188,226,14,54,5,87,138,8,153,198,34,9,39,110,185,195,141,50,24,198,107,208,99,7,166,135,141,198,86,100,88,99,32,237,84,250,147,190,36,26,66,56,159,30,175,47,123,1,221,188,4,65,191,195,179,68,248,78,144,245,223,196,163,162,62,126,227,176,110,112,14,240,106,171,159,155,154,243,24,213,227,163,219,33,230,49,30,47,11,152,159,193,209,3,210,238,208,98,126,215,84,182,86,92,154,197,213,131,149,249,122,30,110,177,172,59,175,126,58,210,60,92,64,146,192,88,154,97,207,61,198,67,94,218,206,169,42,211,124,240,49,24,121,33,254,116,211,29,125,107,202,40,85,69,243,181,209,181,160,185,71,5,225,185,82,120,147,180,135,52,95,194,241,203,9,50,161,102,4,37,186,153,208,132,121,4,189,226,48,36,210,192,108,208,157,69,225,231,158,240,67,6,157,165,133,63,21,158,138,221,211,253,19,136,60,159,246,182,202,126,179,146,102,114,143,242,29,6,133,111,255,235,108,111,58,216,218,44,67,190,96,9,20,162,50,232,163,39,47,116,114,239,15,241,140,52,164,173,103,241,36,167,254,234,161,202,253,237,115,107,142,242,243,7,184,165,208,109,148,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("219a848e-eacd-4e66-a390-448dd194d011"));
		}

		#endregion

	}

	#endregion

}

