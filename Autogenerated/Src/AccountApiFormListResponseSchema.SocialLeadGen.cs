namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiFormListResponseSchema

	/// <exclude/>
	public class AccountApiFormListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiFormListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiFormListResponseSchema(AccountApiFormListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c594cadb-29f2-49ba-adfb-e460ee13e9d5");
			Name = "AccountApiFormListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,65,79,194,64,16,133,207,144,240,31,38,112,209,75,123,7,66,66,48,26,12,81,34,220,140,135,101,119,90,55,182,187,205,236,22,67,136,255,221,233,182,168,20,68,47,77,246,205,188,111,223,206,212,136,28,93,33,36,194,26,137,132,179,137,143,102,214,36,58,45,73,120,109,77,180,178,82,139,108,129,66,221,161,233,117,247,189,110,167,116,218,164,240,128,239,222,154,224,184,119,214,140,190,10,171,157,243,152,51,38,203,80,86,12,23,177,21,73,75,238,225,174,1,97,202,42,204,50,225,220,16,166,82,218,210,248,105,161,111,45,229,11,237,252,19,71,98,23,134,238,56,142,97,236,202,60,23,180,155,52,231,155,245,35,248,87,225,65,161,147,164,55,132,48,93,206,129,26,31,36,100,115,16,53,23,28,210,86,75,140,14,172,248,7,172,40,55,153,150,32,171,36,23,130,192,16,142,198,192,186,95,146,221,106,133,244,29,182,179,15,129,219,239,171,96,117,225,232,182,90,238,28,76,95,46,230,22,72,94,35,91,151,193,208,52,60,87,83,110,170,187,171,190,86,253,235,151,80,104,176,153,229,217,207,21,236,33,69,63,226,103,243,231,227,188,215,240,214,91,110,231,41,44,149,43,255,33,100,218,188,161,154,155,25,161,240,168,214,250,55,224,226,180,241,148,127,233,134,149,23,190,116,151,225,117,207,217,220,3,52,170,158,108,45,52,122,91,254,107,250,173,112,9,47,239,144,169,137,84,253,47,227,106,169,147,176,218,179,105,90,183,214,234,177,200,218,39,160,121,31,77,148,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c594cadb-29f2-49ba-adfb-e460ee13e9d5"));
		}

		#endregion

	}

	#endregion

}

