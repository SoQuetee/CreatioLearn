namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingSubscribtionResponseSchema

	/// <exclude/>
	public class LandingSubscribtionResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingSubscribtionResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingSubscribtionResponseSchema(LandingSubscribtionResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da97b47f-924c-f15e-42df-bea8ad415e53");
			Name = "LandingSubscribtionResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,205,106,195,48,12,62,55,144,119,16,244,158,220,187,177,75,199,70,161,108,97,233,11,40,142,26,12,142,29,36,231,48,74,223,125,78,156,134,108,140,53,187,24,44,125,127,72,178,216,146,116,168,8,78,196,140,226,206,62,219,59,123,214,77,207,232,181,179,89,233,148,70,115,36,172,95,201,166,201,37,77,210,100,179,101,106,66,19,246,6,69,118,112,68,91,107,219,148,125,37,138,117,53,240,62,130,172,179,66,35,60,207,115,120,148,190,109,145,63,159,166,255,243,233,29,120,2,1,86,174,247,32,11,126,118,163,229,11,94,215,87,70,43,80,131,235,223,166,155,152,115,14,90,176,235,136,189,166,144,182,24,85,98,255,103,178,177,80,96,67,160,235,108,6,44,51,220,66,136,231,224,62,98,15,53,92,160,33,255,0,50,60,215,123,210,54,12,125,181,248,91,0,175,150,127,113,220,174,151,31,208,255,146,63,8,152,112,8,1,109,41,158,199,188,51,186,51,174,202,57,19,248,211,29,149,51,235,55,239,45,217,58,238,109,252,199,234,247,226,245,11,35,36,231,153,185,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da97b47f-924c-f15e-42df-bea8ad415e53"));
		}

		#endregion

	}

	#endregion

}

