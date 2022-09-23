namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TenantServiceDataProviderSchema

	/// <exclude/>
	public class TenantServiceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TenantServiceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TenantServiceDataProviderSchema(TenantServiceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("187f0e27-7e57-4243-a537-36ca44a321f2");
			Name = "TenantServiceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,193,110,219,48,12,61,187,64,255,129,200,46,49,80,216,247,165,9,48,180,195,208,75,87,32,233,174,131,106,211,129,48,91,50,40,42,64,16,244,223,71,75,118,26,187,115,118,177,45,250,241,241,61,146,50,170,65,215,170,2,97,135,68,202,217,138,179,7,107,42,189,247,164,88,91,147,237,72,21,127,180,217,223,222,156,110,111,18,239,228,115,132,37,92,157,227,221,41,102,195,58,28,198,92,2,20,232,23,194,189,28,224,161,86,206,125,133,129,255,81,177,122,33,123,208,37,82,192,229,121,14,247,206,55,141,162,227,166,63,247,0,208,166,178,212,4,82,168,200,54,192,104,148,97,112,72,7,93,96,54,164,231,23,249,173,127,171,117,1,69,87,86,28,116,248,109,132,95,150,134,57,69,201,41,168,58,203,151,63,45,18,107,20,15,47,164,15,138,49,2,166,186,67,96,123,116,140,141,232,99,22,102,7,70,250,14,226,1,222,148,195,137,122,240,84,103,103,166,75,11,73,27,11,129,99,138,115,232,242,190,149,37,161,115,219,158,251,185,163,94,111,96,49,248,136,168,87,170,23,171,222,2,154,50,186,184,102,201,50,22,140,101,132,76,10,255,230,129,115,53,107,121,247,201,20,28,84,237,113,214,90,95,112,108,78,74,64,183,120,73,178,71,238,191,18,93,193,50,162,178,39,247,236,235,250,39,125,111,90,62,46,63,116,165,233,0,78,62,130,253,86,198,165,204,100,38,67,207,178,31,200,191,58,113,203,87,209,43,255,141,72,145,150,220,205,183,56,205,118,118,27,52,44,211,85,95,137,144,61,153,105,119,146,228,29,176,150,49,159,254,7,11,175,240,124,191,62,41,81,40,254,125,193,150,186,89,133,205,190,178,125,23,112,176,21,168,120,9,102,6,17,34,173,34,213,132,45,93,47,252,168,37,139,205,147,144,41,35,35,21,170,113,187,178,251,60,36,198,129,198,251,54,123,211,38,173,134,113,153,84,46,98,119,55,150,211,240,9,254,221,155,24,29,7,37,246,23,109,246,183,107,225,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("187f0e27-7e57-4243-a537-36ca44a321f2"));
		}

		#endregion

	}

	#endregion

}

