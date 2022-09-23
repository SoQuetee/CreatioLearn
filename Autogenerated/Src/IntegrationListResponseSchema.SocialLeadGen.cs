namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationListResponseSchema

	/// <exclude/>
	public class IntegrationListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationListResponseSchema(IntegrationListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56543138-4c89-c211-d5b8-8f2545d3e89d");
			Name = "IntegrationListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5eec482-a90e-42cc-86d3-ef2673139bae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,205,106,195,48,16,132,207,49,248,29,22,122,183,239,113,200,197,133,80,8,52,52,121,1,85,94,187,2,89,50,187,114,66,48,125,247,174,101,39,117,250,115,18,59,59,154,253,198,169,22,185,83,26,225,132,68,138,125,29,178,210,187,218,52,61,169,96,188,203,142,94,27,101,247,168,170,29,186,52,25,210,100,213,179,113,13,28,175,28,176,21,183,181,168,71,43,103,226,64,50,186,72,19,113,61,17,54,162,66,105,21,243,26,94,92,192,102,202,220,27,14,111,114,86,190,96,180,230,121,14,27,238,219,86,209,117,59,207,165,245,125,5,52,219,224,249,244,10,23,19,62,192,184,218,83,27,115,192,215,50,222,99,193,74,110,118,139,203,23,121,93,255,110,141,6,61,146,252,7,2,107,120,168,42,122,56,144,63,155,10,233,27,118,53,68,224,123,57,113,116,72,193,160,52,60,196,43,211,254,103,163,40,236,48,48,120,2,30,223,191,192,127,147,223,208,71,210,205,130,124,187,172,193,48,64,131,161,24,131,11,248,156,9,209,85,19,100,156,39,245,81,20,237,11,99,131,146,58,0,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56543138-4c89-c211-d5b8-8f2545d3e89d"));
		}

		#endregion

	}

	#endregion

}

