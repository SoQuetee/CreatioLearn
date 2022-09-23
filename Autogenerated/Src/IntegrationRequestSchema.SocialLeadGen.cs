namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationRequestSchema

	/// <exclude/>
	public class IntegrationRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationRequestSchema(IntegrationRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0");
			Name = "IntegrationRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,77,107,195,48,12,61,47,144,255,32,216,61,185,183,99,151,20,202,96,176,210,245,15,120,137,146,25,28,43,147,228,141,81,246,223,231,196,109,112,199,78,150,158,158,223,135,55,35,202,100,90,132,19,50,27,161,94,171,134,124,111,135,192,70,45,249,234,149,90,107,220,51,154,110,143,190,44,206,101,81,22,119,247,140,67,60,66,227,140,200,6,158,188,226,144,248,71,252,8,40,186,176,234,186,134,7,9,227,104,248,251,241,178,55,142,66,7,156,88,176,59,189,192,151,213,119,176,190,39,30,23,5,160,62,174,171,96,117,21,170,51,165,41,188,57,219,66,59,219,255,227,14,27,184,137,125,140,216,129,233,211,118,200,113,158,200,11,70,149,212,101,45,19,25,19,178,90,140,141,14,139,65,186,255,173,177,0,123,84,1,98,144,249,205,226,130,179,162,213,250,45,15,125,77,157,229,205,231,157,81,3,103,24,80,183,179,234,22,126,46,241,208,119,41,225,178,39,244,22,140,216,47,114,222,225,54,201,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0"));
		}

		#endregion

	}

	#endregion

}

