namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoResponseSchema

	/// <exclude/>
	public class AccountInfoResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoResponseSchema(AccountInfoResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("126bd8c9-55dd-b001-f748-1309e196c95f");
			Name = "AccountInfoResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,221,106,131,48,20,190,174,224,59,28,232,189,222,175,99,48,220,40,133,194,74,127,30,32,141,71,27,208,68,206,73,182,21,217,187,47,70,43,110,20,233,77,224,124,249,254,14,137,22,53,114,35,36,194,17,137,4,155,194,38,153,209,133,42,29,9,171,140,78,14,70,42,81,109,81,228,107,212,113,212,198,209,194,177,210,37,28,174,108,177,94,197,145,71,150,132,165,39,67,86,9,230,39,120,149,210,56,109,55,186,48,123,111,111,52,99,160,165,105,10,207,236,234,90,208,245,101,152,223,142,31,64,3,9,190,148,189,128,242,50,170,67,58,136,179,113,22,68,239,151,220,44,210,137,71,227,206,149,146,32,187,228,251,193,139,54,132,143,37,119,100,26,36,171,208,55,221,5,117,127,255,191,93,0,54,124,75,7,252,86,108,57,25,169,211,22,183,26,103,99,42,175,25,122,188,7,5,180,80,162,93,1,119,199,207,76,214,160,2,149,207,135,172,157,202,199,85,243,135,237,39,171,8,105,213,39,62,184,74,71,125,56,36,35,236,94,14,78,251,237,188,61,91,234,126,209,192,63,81,117,47,98,137,58,239,95,45,204,61,250,23,244,216,47,198,184,95,237,197,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("126bd8c9-55dd-b001-f748-1309e196c95f"));
		}

		#endregion

	}

	#endregion

}

