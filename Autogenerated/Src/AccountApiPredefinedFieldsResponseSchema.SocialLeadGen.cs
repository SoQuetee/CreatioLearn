namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountApiPredefinedFieldsResponseSchema

	/// <exclude/>
	public class AccountApiPredefinedFieldsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountApiPredefinedFieldsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountApiPredefinedFieldsResponseSchema(AccountApiPredefinedFieldsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1521232e-cc77-4fda-b150-54054f3f6789");
			Name = "AccountApiPredefinedFieldsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,79,194,64,16,133,207,37,225,63,76,240,162,151,246,14,132,132,96,52,26,162,40,220,140,135,101,59,173,155,180,187,205,204,22,67,8,255,221,109,187,5,91,49,122,105,210,55,243,222,124,51,171,69,142,92,8,137,176,65,34,193,38,177,225,194,232,68,165,37,9,171,140,14,215,70,42,145,45,81,196,247,168,135,131,195,112,16,148,172,116,10,79,248,105,141,174,29,143,108,244,228,84,88,239,217,98,238,98,178,12,101,149,193,161,179,34,41,233,122,92,215,21,97,234,84,88,100,130,121,12,115,41,77,169,237,188,80,43,194,24,19,165,49,190,83,152,197,252,234,208,156,27,107,87,20,69,48,229,50,207,5,237,103,254,255,118,243,12,246,67,88,136,145,37,169,45,33,204,87,15,64,222,7,9,153,28,68,147,15,140,180,83,18,195,54,43,250,22,86,148,219,76,73,144,21,209,63,128,96,12,157,179,56,221,174,200,236,84,140,116,134,14,14,53,120,127,223,115,232,75,233,124,174,210,180,117,24,46,53,5,109,224,41,209,205,44,144,172,194,42,182,182,251,134,183,234,69,124,117,127,61,42,186,123,140,110,222,235,46,63,145,45,85,207,214,91,22,14,144,162,157,184,179,185,207,177,29,140,58,110,102,55,130,215,251,242,95,124,191,226,181,203,178,71,244,132,75,197,118,250,243,36,179,11,103,226,75,220,61,190,70,237,138,199,47,143,75,58,123,10,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1521232e-cc77-4fda-b150-54054f3f6789"));
		}

		#endregion

	}

	#endregion

}

