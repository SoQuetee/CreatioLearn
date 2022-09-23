namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsValidationRuleSchema

	/// <exclude/>
	public class ActiveContactsValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsValidationRuleSchema(ActiveContactsValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df11bcd7-a33a-4244-bbc8-b2cfc61e31b4");
			Name = "ActiveContactsValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,107,219,64,16,61,203,224,255,176,168,23,7,138,116,119,35,67,107,84,26,176,193,196,73,47,161,135,237,106,36,47,145,118,197,236,202,77,27,252,223,59,251,161,90,181,27,232,69,31,179,239,189,121,243,70,82,188,3,211,115,1,236,1,16,185,209,181,205,214,90,213,178,25,144,91,169,213,124,246,58,159,205,103,73,158,231,236,214,12,93,199,241,231,42,190,223,67,143,96,64,89,195,236,1,24,23,86,30,129,9,173,44,61,178,35,111,101,229,53,24,14,45,100,163,72,62,81,233,135,239,173,20,76,180,220,24,246,209,243,215,129,110,190,254,161,223,19,155,45,217,221,150,203,86,170,102,111,185,133,191,79,73,41,184,76,222,33,52,174,227,22,236,65,87,102,201,118,190,67,56,188,156,193,21,146,242,5,196,96,97,106,183,214,120,57,204,56,193,245,8,161,210,115,228,29,83,148,102,145,26,103,48,93,61,80,36,254,209,235,157,229,179,219,220,163,207,100,4,59,160,50,171,59,69,120,69,187,208,53,249,4,234,142,80,23,233,100,86,218,149,86,6,210,124,197,240,28,254,52,105,48,67,107,13,245,24,69,93,151,24,243,181,208,88,130,197,52,220,96,251,134,189,58,110,18,79,220,94,224,197,250,68,220,189,8,168,44,214,63,120,236,155,43,244,182,38,70,99,161,240,172,11,218,23,104,123,192,108,180,182,3,236,164,49,68,42,43,105,63,13,237,115,217,145,165,69,52,146,61,26,64,162,42,16,78,248,38,24,145,53,91,92,118,35,171,21,176,162,120,251,67,11,176,18,81,227,56,253,56,254,163,165,155,149,96,178,141,110,2,228,179,198,142,219,69,250,180,46,247,14,229,96,59,212,71,89,145,251,248,89,237,65,85,91,48,134,55,240,109,201,54,82,128,75,93,28,64,60,179,154,56,80,101,105,180,156,132,141,49,5,63,254,181,169,104,39,217,15,66,144,32,229,95,243,214,192,251,88,222,136,95,123,139,126,79,110,200,171,168,179,232,34,192,79,161,229,201,95,255,171,239,185,173,197,33,168,4,145,83,252,241,104,208,240,239,249,119,95,165,203,111,4,220,246,253,96,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df11bcd7-a33a-4244-bbc8-b2cfc61e31b4"));
		}

		#endregion

	}

	#endregion

}

