namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingStateValidationRuleSchema

	/// <exclude/>
	public class IMailingStateValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingStateValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingStateValidationRuleSchema(IMailingStateValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d21ccf92-5dc5-4e8f-9f1a-b4b1c7befaaa");
			Name = "IMailingStateValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,77,79,195,48,12,134,207,171,212,255,96,149,11,92,154,59,108,189,76,28,118,152,132,198,196,61,180,206,22,169,117,42,199,65,32,196,127,199,109,247,81,13,33,229,16,59,246,227,215,111,200,118,24,123,91,35,236,145,217,198,224,164,92,7,114,254,144,216,138,15,148,103,223,121,150,103,11,99,12,44,99,234,58,203,95,213,41,222,97,207,24,145,36,130,28,17,182,214,183,158,14,175,98,5,223,108,235,155,17,176,75,45,66,29,72,216,214,82,158,73,102,134,234,211,123,235,107,240,36,200,110,144,178,249,159,164,229,147,158,197,29,227,65,147,176,69,57,134,38,62,194,203,136,153,30,111,213,14,137,197,243,39,214,73,16,62,46,68,112,129,33,246,88,123,231,177,1,214,1,229,165,221,220,244,195,178,183,108,59,32,181,108,85,196,65,91,81,237,117,239,241,58,162,174,228,114,105,198,234,107,51,163,36,166,88,109,72,235,73,183,12,78,37,162,122,195,232,86,197,108,77,253,144,64,17,11,83,1,95,29,158,169,214,84,106,37,234,140,51,116,152,242,151,0,167,20,222,207,13,157,244,62,60,157,108,68,106,38,39,199,248,39,207,244,252,2,66,225,197,19,22,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d21ccf92-5dc5-4e8f-9f1a-b4b1c7befaaa"));
		}

		#endregion

	}

	#endregion

}

