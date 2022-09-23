namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestRequestSchema

	/// <exclude/>
	public class LandingInfoRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestRequestSchema(LandingInfoRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8");
			Name = "LandingInfoRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,203,106,195,48,16,69,215,49,248,31,6,186,183,247,77,232,198,165,33,16,104,72,2,93,143,173,177,59,160,135,171,7,37,152,252,123,101,201,9,105,161,27,137,57,115,117,57,210,168,200,141,216,17,156,201,90,116,166,247,85,99,116,207,67,176,232,217,232,234,100,58,70,185,39,20,91,210,101,49,149,197,42,56,214,3,156,46,206,147,90,151,69,36,79,150,134,24,134,70,162,115,207,176,71,45,98,100,167,123,115,36,231,143,244,21,226,149,146,117,93,195,198,5,165,208,94,94,150,185,145,38,8,176,57,5,175,231,119,248,102,255,9,28,159,91,149,44,0,91,19,60,200,220,91,221,122,234,135,162,49,180,146,59,232,102,131,127,5,86,83,146,184,251,30,172,25,201,122,166,40,125,72,5,121,255,215,50,129,165,20,88,84,247,204,163,193,77,97,27,88,64,99,105,54,255,160,246,45,126,98,39,96,130,129,252,26,220,124,92,23,11,210,34,139,164,57,211,223,48,178,31,150,100,123,139,163,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8"));
		}

		#endregion

	}

	#endregion

}

