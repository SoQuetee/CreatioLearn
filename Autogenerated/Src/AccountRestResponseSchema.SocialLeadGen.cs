namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountRestResponseSchema

	/// <exclude/>
	public class AccountRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountRestResponseSchema(AccountRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c549c9b6-fa79-24e6-145a-6a71c2ee8ca3");
			Name = "AccountRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,106,195,48,16,60,199,144,127,88,200,221,190,39,165,16,92,8,129,64,66,30,31,32,91,107,87,32,75,102,37,165,4,211,127,175,36,219,105,82,130,233,65,18,59,26,205,204,46,82,172,65,211,178,18,225,140,68,204,232,202,166,185,86,149,168,29,49,43,180,74,79,186,20,76,238,144,241,13,170,121,210,205,147,153,51,66,213,112,186,25,139,205,106,158,120,100,65,88,123,50,228,146,25,179,132,117,89,106,167,236,17,77,88,173,86,6,35,45,203,50,120,51,174,105,24,221,222,135,58,151,218,113,160,129,6,31,231,61,124,9,251,9,66,85,154,154,152,1,88,161,157,5,214,171,166,163,80,246,160,212,186,66,138,18,202,224,255,202,30,150,240,212,72,184,59,144,190,10,142,244,27,113,214,197,152,247,118,60,163,69,178,2,125,79,135,232,208,223,255,237,35,2,131,43,8,158,222,57,143,17,199,140,27,39,248,72,222,114,232,160,70,187,2,19,182,239,9,249,173,25,7,224,79,43,174,56,237,82,104,45,253,155,117,164,254,219,36,39,12,19,135,203,113,55,45,111,44,133,63,48,240,47,36,95,89,44,80,241,126,146,177,238,209,103,208,99,63,9,248,138,11,131,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c549c9b6-fa79-24e6-145a-6a71c2ee8ca3"));
		}

		#endregion

	}

	#endregion

}

