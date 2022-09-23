namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiFormFieldsResponseSchema

	/// <exclude/>
	public class AccountApiFormFieldsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiFormFieldsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiFormFieldsResponseSchema(AccountApiFormFieldsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2106199-c783-417b-8ee7-13bea17b63c5");
			Name = "AccountApiFormFieldsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,193,110,219,48,12,61,167,64,255,65,104,47,219,37,185,183,133,129,192,67,183,14,221,230,174,185,13,59,168,18,147,16,176,37,79,146,219,5,65,255,125,178,172,56,177,195,100,70,17,160,151,0,33,31,31,31,159,41,50,197,11,176,37,23,192,102,96,12,183,122,238,198,169,86,115,92,84,134,59,212,106,252,168,5,242,252,30,184,252,12,234,252,108,125,126,54,170,44,170,5,251,14,47,78,171,80,241,213,106,117,221,38,30,87,214,65,225,105,242,28,68,205,97,199,190,20,12,10,143,241,168,75,3,11,31,101,105,206,173,189,98,83,33,116,165,220,180,196,91,109,138,91,132,92,218,159,94,148,175,131,128,159,76,38,236,198,86,69,193,205,42,137,255,63,205,126,48,183,228,142,73,176,194,224,147,1,54,205,238,152,137,117,108,110,116,193,120,195,204,44,152,103,20,48,222,112,77,118,200,202,234,41,71,193,68,173,229,168,20,118,197,58,86,248,184,203,140,126,70,9,102,43,119,180,14,146,251,51,126,65,41,65,5,194,38,223,105,219,201,142,54,20,45,135,239,82,130,113,8,158,40,11,117,17,240,171,246,61,102,87,31,46,234,111,121,241,241,119,72,69,126,235,76,248,84,62,195,214,108,1,238,218,155,225,127,94,105,6,174,236,11,24,154,99,26,114,36,203,37,40,217,104,109,2,49,222,15,247,60,73,107,199,148,35,252,104,51,111,247,2,101,111,10,244,123,112,39,135,152,32,154,238,51,248,235,104,39,210,45,224,148,118,84,214,233,162,38,125,168,252,106,181,176,174,51,4,232,132,38,197,1,135,249,244,39,42,56,108,212,195,14,226,228,78,125,171,114,135,101,14,233,82,251,183,253,95,207,14,193,223,243,185,189,155,131,153,1,9,115,84,32,143,248,70,129,222,238,86,217,178,133,59,71,143,155,117,65,167,152,248,144,190,158,188,229,246,4,219,168,45,74,187,71,235,110,118,46,116,178,123,174,45,37,145,190,39,20,109,188,36,201,230,164,12,162,219,59,1,36,243,30,42,33,142,199,240,126,244,243,57,220,153,198,39,71,31,227,16,53,229,222,82,82,26,246,87,55,33,214,153,236,215,219,163,38,218,13,190,254,3,185,61,31,246,54,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2106199-c783-417b-8ee7-13bea17b63c5"));
		}

		#endregion

	}

	#endregion

}

