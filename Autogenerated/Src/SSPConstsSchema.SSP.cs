namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SSPConstsSchema

	/// <exclude/>
	public class SSPConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SSPConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SSPConstsSchema(SSPConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee");
			Name = "SSPConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b1aa09-c30c-47e9-9379-18a9c48e3a0f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,79,111,194,32,24,135,207,54,233,119,32,158,182,3,254,105,105,171,49,59,208,150,46,158,52,211,125,0,214,98,71,210,66,3,84,227,204,190,251,208,186,57,119,216,14,46,121,57,0,63,30,158,188,208,106,46,74,176,218,107,195,234,153,235,184,142,160,53,211,13,205,25,88,51,165,168,150,27,51,72,164,216,240,178,85,212,112,41,92,231,224,58,189,166,125,169,120,14,180,177,107,57,200,43,170,53,88,173,150,54,169,141,182,251,135,35,171,215,27,14,193,19,43,185,54,221,89,192,106,202,43,96,239,106,42,106,24,224,5,19,134,111,56,83,131,99,250,26,170,24,45,164,168,246,224,177,229,197,21,134,28,41,235,51,100,94,128,7,32,216,238,20,187,235,227,32,77,9,74,66,24,165,254,20,162,200,27,65,140,237,116,66,72,20,251,33,193,89,140,251,247,179,47,185,154,139,2,52,86,127,39,85,113,147,95,46,183,76,237,151,103,212,111,142,8,37,9,158,196,8,6,211,212,131,136,16,31,198,36,64,48,69,81,70,178,48,241,35,47,190,56,206,197,150,155,91,219,119,129,252,139,88,167,134,11,219,189,238,85,164,2,27,59,164,42,169,224,111,157,173,45,243,202,64,35,149,161,213,95,130,87,172,76,170,197,55,210,66,44,79,12,251,77,79,177,103,193,205,15,243,48,155,226,44,28,121,208,199,158,53,15,130,4,198,163,32,132,94,146,141,145,135,198,217,20,249,159,230,239,174,99,235,3,206,69,156,97,250,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baddafff-9580-40c5-a726-cdd52e87d9ee"));
		}

		#endregion

	}

	#endregion

}

