namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenResponseSchema

	/// <exclude/>
	public class SessionTokenResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenResponseSchema(SessionTokenResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f87b198-4253-acd7-9bd9-07d8390cb4bc");
			Name = "SessionTokenResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,143,77,106,195,48,16,133,215,49,248,14,3,217,219,251,182,20,74,22,221,100,17,226,228,0,19,121,236,138,218,35,51,35,37,148,208,187,87,145,227,224,134,182,116,35,52,111,126,222,247,24,123,210,1,13,193,142,68,80,93,227,139,149,227,198,182,65,208,91,199,69,229,140,197,110,77,88,191,18,231,217,57,207,242,108,177,20,106,99,19,86,29,170,62,64,69,170,177,220,185,119,226,109,188,231,88,41,205,149,101,9,79,26,250,30,229,227,249,90,79,3,112,178,254,13,44,55,78,250,100,5,120,112,193,3,26,227,2,123,80,146,163,141,96,200,117,252,39,131,98,58,89,206,110,14,225,208,89,3,230,130,242,11,201,98,164,190,97,111,196,13,36,222,82,100,223,164,245,177,127,143,155,132,151,59,158,253,118,93,220,134,231,32,19,137,122,177,220,78,123,213,184,182,151,14,206,208,146,127,140,135,226,243,249,135,227,53,4,248,75,138,127,121,205,99,255,100,179,36,174,199,236,169,30,213,239,98,212,190,0,69,50,64,255,13,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f87b198-4253-acd7-9bd9-07d8390cb4bc"));
		}

		#endregion

	}

	#endregion

}

