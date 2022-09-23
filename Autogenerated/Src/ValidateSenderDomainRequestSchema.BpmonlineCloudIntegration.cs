namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateSenderDomainRequestSchema

	/// <exclude/>
	public class ValidateSenderDomainRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateSenderDomainRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateSenderDomainRequestSchema(ValidateSenderDomainRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f9ce81e-a5d7-4bb1-aa16-62e6c9485129");
			Name = "ValidateSenderDomainRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,61,111,194,48,16,134,103,144,250,31,78,176,180,75,178,151,182,11,32,212,129,10,145,170,11,98,48,201,37,181,148,216,233,221,25,137,162,254,247,58,14,160,128,80,37,58,37,247,245,250,185,215,54,170,66,174,85,138,240,142,68,138,109,46,209,216,154,92,23,142,148,104,107,162,241,52,153,219,12,75,190,235,239,239,250,61,199,218,20,144,236,88,176,26,93,196,209,210,25,209,21,70,9,146,86,165,254,14,10,190,203,247,13,9,11,31,192,184,84,204,143,240,225,203,153,18,76,208,100,72,19,91,41,109,150,248,229,144,37,180,199,113,12,79,236,170,74,209,238,229,16,135,81,200,45,1,181,157,32,22,182,7,33,224,160,4,89,144,138,142,18,113,71,99,53,81,162,252,114,66,42,149,181,79,212,110,83,234,20,210,160,251,39,81,111,31,168,78,91,44,200,214,72,162,209,175,178,8,42,109,253,18,59,36,102,40,12,158,154,155,175,124,34,160,215,46,65,103,232,221,202,53,82,116,26,237,226,182,188,115,172,54,72,247,111,254,158,224,25,6,97,244,53,27,60,52,252,199,5,102,78,103,48,109,43,176,135,2,101,212,28,54,130,159,91,168,206,12,228,27,152,184,227,24,159,147,177,144,127,30,171,53,116,93,229,255,51,154,230,72,155,135,255,154,236,214,123,120,139,123,199,145,38,190,6,218,220,235,169,225,26,229,208,175,209,62,129,16,183,217,243,164,207,253,2,47,158,90,233,85,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f9ce81e-a5d7-4bb1-aa16-62e6c9485129"));
		}

		#endregion

	}

	#endregion

}

