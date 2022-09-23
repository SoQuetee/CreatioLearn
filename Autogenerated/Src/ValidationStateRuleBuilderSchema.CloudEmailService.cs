namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationStateRuleBuilderSchema

	/// <exclude/>
	public class ValidationStateRuleBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationStateRuleBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationStateRuleBuilderSchema(ValidationStateRuleBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65");
			Name = "ValidationStateRuleBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,81,107,194,48,16,199,159,43,248,29,14,247,162,47,237,187,118,133,109,12,17,38,200,148,189,103,237,181,6,210,68,114,151,138,200,190,251,146,182,110,42,14,28,244,33,185,251,223,239,254,215,156,22,53,210,78,228,8,27,180,86,144,41,57,126,49,186,148,149,179,130,165,209,195,193,113,56,136,28,73,93,193,250,64,140,181,207,43,133,121,72,82,60,71,141,86,230,179,225,192,171,146,36,129,148,92,93,11,123,200,250,251,202,154,70,22,72,80,35,111,77,1,108,160,66,6,235,148,143,149,198,2,177,96,132,70,40,89,8,54,54,62,113,146,51,208,206,125,42,153,67,174,4,17,124,116,82,223,126,29,74,223,61,233,217,73,85,160,133,41,44,150,66,42,239,181,77,253,42,123,129,71,29,91,167,209,131,197,202,199,97,217,186,162,41,172,218,22,93,242,122,142,54,48,71,38,224,45,158,89,175,187,94,151,35,120,106,252,3,73,174,41,169,69,118,86,83,150,18,34,228,22,203,199,209,226,85,187,26,173,248,84,152,254,225,63,12,153,141,146,12,246,146,183,157,131,56,77,78,172,0,239,127,81,35,45,59,161,224,94,102,24,43,28,104,60,129,240,208,81,116,144,168,10,232,208,160,113,15,79,254,169,27,244,75,193,34,103,186,172,31,79,102,183,139,214,59,37,121,131,196,161,169,187,187,234,63,226,149,31,233,94,46,234,194,171,223,100,45,249,102,201,87,191,21,94,215,45,70,123,247,81,255,125,3,14,61,61,234,35,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65"));
		}

		#endregion

	}

	#endregion

}

