namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderDomainResponseSchema

	/// <exclude/>
	public class ValidateSenderDomainResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderDomainResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderDomainResponseSchema(ValidateSenderDomainResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("871f1b8a-e82c-41c2-a927-53b14043304e");
			Name = "ValidateSenderDomainResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,146,65,107,194,64,16,133,207,10,254,135,193,94,218,75,188,87,235,69,139,8,181,72,82,122,41,61,172,201,196,46,36,187,97,102,35,88,233,127,239,236,38,138,164,210,66,15,165,167,176,111,94,102,190,183,179,70,149,200,149,74,17,158,144,72,177,205,93,52,179,38,215,219,154,148,211,214,68,179,251,100,101,51,44,120,208,63,12,250,189,154,181,217,66,178,103,135,165,56,139,2,83,111,227,104,129,6,73,167,227,174,39,174,141,211,37,70,137,84,85,161,223,67,87,113,137,239,138,112,43,7,152,21,138,249,22,158,165,156,41,135,9,154,12,105,110,75,165,77,44,116,210,29,131,127,52,26,193,132,235,178,84,180,159,182,231,24,43,66,70,227,24,168,245,130,205,193,189,33,48,210,78,75,178,220,146,212,28,105,220,121,174,44,52,230,32,203,143,153,215,80,164,34,58,142,24,157,205,168,234,77,161,83,72,61,226,15,132,189,67,160,60,197,90,147,173,144,156,70,201,182,14,109,154,122,55,70,16,22,40,9,2,145,124,61,125,131,25,157,126,56,135,234,189,204,149,83,43,44,55,72,215,143,178,66,184,131,33,159,65,45,77,110,121,120,243,234,189,109,130,7,205,110,146,116,60,83,232,42,12,7,216,162,27,123,144,49,124,180,137,196,212,132,10,231,70,237,136,157,101,118,251,254,143,5,126,165,250,195,165,181,36,44,65,132,184,129,184,116,219,23,71,197,232,106,146,208,142,106,4,125,188,31,159,166,29,10,154,97,231,223,231,247,211,55,214,22,176,228,240,146,127,185,106,209,62,1,147,170,249,53,55,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("871f1b8a-e82c-41c2-a927-53b14043304e"));
		}

		#endregion

	}

	#endregion

}

