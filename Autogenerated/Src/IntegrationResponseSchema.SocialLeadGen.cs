namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationResponseSchema

	/// <exclude/>
	public class IntegrationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationResponseSchema(IntegrationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34726720-1e07-4f00-be95-bf2446ea34bc");
			Name = "IntegrationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,145,65,79,195,48,12,133,207,155,212,255,96,141,11,92,218,251,6,92,58,105,66,26,48,109,187,33,14,89,235,150,72,77,50,57,46,104,76,252,119,220,180,29,25,167,198,47,207,207,254,82,171,12,250,163,42,16,246,72,164,188,171,56,205,157,173,116,221,146,98,237,108,186,115,133,86,205,26,85,185,66,155,76,207,201,116,210,122,109,107,216,157,60,163,73,183,173,101,109,48,221,33,137,79,127,135,174,69,50,21,223,13,97,45,5,228,141,242,126,14,79,150,177,238,83,215,218,243,86,6,59,235,49,88,179,44,131,123,223,26,163,232,244,56,212,121,227,218,18,104,176,193,114,255,10,95,154,63,64,219,202,145,9,57,224,42,41,47,177,233,152,148,69,81,111,75,197,74,152,152,84,193,239,34,28,219,67,163,11,40,186,173,226,165,198,133,96,14,87,208,162,243,134,220,167,46,145,254,150,158,156,195,226,23,72,113,28,145,88,163,144,110,194,132,254,254,63,89,16,86,200,30,28,129,239,190,17,0,52,242,48,233,165,45,198,232,57,158,209,28,144,110,95,228,183,193,3,204,162,214,238,118,118,215,241,141,128,17,90,124,238,140,112,134,26,121,209,205,95,192,207,0,130,182,236,89,66,221,171,215,162,104,191,15,4,120,22,49,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34726720-1e07-4f00-be95-bf2446ea34bc"));
		}

		#endregion

	}

	#endregion

}

