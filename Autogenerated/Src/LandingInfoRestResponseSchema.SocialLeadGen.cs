namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestResponseSchema

	/// <exclude/>
	public class LandingInfoRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestResponseSchema(LandingInfoRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2");
			Name = "LandingInfoRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,209,106,131,48,20,134,175,43,248,14,7,122,95,239,219,177,27,199,74,161,108,178,246,5,162,57,186,128,38,114,78,178,81,100,239,190,36,182,93,59,54,106,47,20,114,242,241,251,253,28,181,232,144,123,81,33,236,145,72,176,169,237,34,55,186,86,141,35,97,149,209,139,157,169,148,104,183,40,228,26,117,154,12,105,50,115,172,116,3,187,3,91,236,86,105,226,39,115,194,198,195,144,183,130,121,9,91,161,165,71,54,186,54,111,200,214,63,189,209,140,17,205,178,12,30,216,117,157,160,195,227,241,156,183,198,73,160,35,6,79,251,87,248,84,246,29,148,15,160,46,122,128,40,141,179,208,142,201,192,174,228,138,84,25,21,79,169,217,69,108,239,202,86,85,80,5,161,255,124,96,9,87,237,194,93,65,230,67,73,164,31,231,217,16,189,207,29,61,209,35,89,133,190,104,17,191,50,222,255,46,22,7,207,222,31,148,92,156,129,75,199,147,36,91,10,157,2,187,145,48,64,131,118,5,28,94,95,183,162,181,223,223,228,240,23,15,79,142,47,68,131,83,205,3,123,135,121,140,158,108,30,232,187,204,143,219,190,41,191,118,74,158,127,141,63,237,231,168,229,184,245,120,30,167,215,67,63,251,6,237,11,212,98,68,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2"));
		}

		#endregion

	}

	#endregion

}

