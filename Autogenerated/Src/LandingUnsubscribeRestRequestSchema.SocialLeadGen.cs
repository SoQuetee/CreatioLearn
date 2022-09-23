namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingUnsubscribeRestRequestSchema

	/// <exclude/>
	public class LandingUnsubscribeRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingUnsubscribeRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingUnsubscribeRestRequestSchema(LandingUnsubscribeRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0d75d98-819a-c4f5-150a-b26f00c1ebdd");
			Name = "LandingUnsubscribeRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,107,195,48,12,133,207,13,228,63,8,118,79,238,107,217,37,99,101,80,88,105,59,118,182,99,37,19,36,118,42,217,140,18,246,223,231,56,105,233,118,217,69,70,207,79,143,239,89,213,163,12,170,70,56,33,179,18,215,248,162,114,182,161,54,176,242,228,108,113,116,53,169,110,135,202,108,209,230,217,152,103,171,32,100,91,56,94,196,99,191,206,179,168,60,48,182,209,12,85,167,68,30,97,167,172,137,150,119,43,65,75,205,164,241,128,226,15,120,14,241,73,7,101,89,194,70,66,223,43,190,60,45,123,213,185,96,128,103,23,60,159,222,224,139,252,39,144,109,28,247,9,6,148,118,193,67,55,199,23,215,156,242,46,104,8,186,163,26,234,9,228,63,142,213,152,88,110,244,123,118,3,178,39,140,21,246,41,103,254,255,11,155,132,37,27,200,20,55,207,61,200,149,100,27,200,64,197,56,21,248,64,253,18,187,188,26,24,161,69,191,6,153,198,247,66,129,214,204,32,105,159,213,223,98,212,126,0,99,122,5,196,177,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0d75d98-819a-c4f5-150a-b26f00c1ebdd"));
		}

		#endregion

	}

	#endregion

}

