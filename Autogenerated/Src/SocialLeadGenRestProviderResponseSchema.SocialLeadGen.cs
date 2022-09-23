namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialLeadGenRestProviderResponseSchema

	/// <exclude/>
	public class SocialLeadGenRestProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialLeadGenRestProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialLeadGenRestProviderResponseSchema(SocialLeadGenRestProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb4700f9-fd00-5da9-06bb-a7b825d87bb3");
			Name = "SocialLeadGenRestProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,77,110,131,64,12,133,215,65,226,14,86,186,135,125,127,178,137,170,108,90,41,106,123,1,119,48,100,36,240,32,123,104,85,69,185,123,13,3,17,237,166,221,160,177,253,248,252,158,25,59,210,30,29,193,27,137,160,134,58,22,251,192,181,111,6,193,232,3,23,175,193,121,108,159,8,171,3,113,158,157,243,44,207,54,55,66,141,13,97,223,162,234,45,252,208,188,144,198,163,132,15,95,145,216,187,15,172,52,253,84,150,37,220,235,208,117,40,95,187,185,94,4,224,70,18,212,65,76,66,86,10,213,15,219,63,185,219,114,7,200,21,120,62,145,248,72,85,226,144,22,203,190,114,181,176,31,222,91,239,230,85,255,240,188,73,97,175,105,77,209,147,68,79,22,249,56,177,210,252,119,176,169,97,87,140,232,89,193,238,106,169,236,204,138,13,193,231,137,24,70,204,116,93,240,10,3,235,224,156,141,139,43,107,109,122,113,173,81,60,55,240,56,210,158,103,216,25,26,138,119,160,227,231,50,123,37,174,146,221,169,78,221,117,243,242,13,107,57,158,17,243,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb4700f9-fd00-5da9-06bb-a7b825d87bb3"));
		}

		#endregion

	}

	#endregion

}

