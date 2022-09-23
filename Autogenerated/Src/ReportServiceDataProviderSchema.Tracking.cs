namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportServiceDataProviderSchema

	/// <exclude/>
	public class ReportServiceDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportServiceDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportServiceDataProviderSchema(ReportServiceDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4bdab04d-2ff8-4619-bc00-3e7bdcd86548");
			Name = "ReportServiceDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,77,111,219,48,12,61,171,64,255,3,145,93,108,96,176,239,75,19,96,232,134,161,151,174,104,210,93,7,213,166,3,97,182,100,80,82,128,32,232,127,31,45,217,137,237,205,185,196,33,245,72,190,199,15,45,27,180,173,44,16,246,72,36,173,169,92,246,104,116,165,14,158,164,83,70,103,123,146,197,31,165,15,247,119,231,251,59,225,45,255,133,221,201,58,108,214,23,123,28,75,120,245,119,86,204,6,155,96,76,115,51,144,161,159,8,15,108,192,99,45,173,253,2,67,189,111,210,201,23,50,71,85,34,5,92,158,231,240,96,125,211,72,58,109,123,187,7,128,210,149,161,38,36,133,138,76,3,132,173,33,7,22,233,168,10,204,134,240,124,20,223,250,247,90,21,80,116,101,225,53,224,119,17,62,46,13,75,140,196,57,176,186,208,231,151,22,201,41,100,13,47,164,142,210,97,4,204,121,7,71,236,32,243,115,142,51,91,208,60,7,96,13,240,46,45,206,216,131,167,58,187,100,26,75,16,109,44,4,214,81,215,239,168,226,107,89,18,90,187,235,115,63,119,169,55,91,88,13,58,34,234,141,234,213,186,151,128,186,140,42,110,73,50,14,11,135,101,132,204,10,255,166,33,231,122,81,242,235,63,162,224,40,107,143,139,210,250,130,83,113,92,162,123,237,118,81,136,3,186,240,141,150,80,21,36,17,156,61,217,103,95,215,63,233,123,211,186,83,114,165,151,166,17,218,71,136,235,75,191,161,113,65,51,158,207,208,191,236,7,186,95,29,209,228,141,185,243,187,102,90,220,158,207,203,237,78,179,189,217,5,34,73,186,238,43,17,58,79,122,222,41,33,62,226,7,107,139,83,106,183,3,194,239,199,237,249,49,87,110,135,47,156,161,110,130,97,223,111,236,228,8,14,166,2,25,79,99,97,60,193,211,74,146,77,216,221,205,202,79,154,179,218,62,113,50,169,121,208,156,106,218,184,236,33,15,129,113,204,241,10,23,239,111,214,116,152,150,73,249,60,187,139,73,230,238,51,252,191,55,209,59,117,178,239,47,31,70,189,149,7,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4bdab04d-2ff8-4619-bc00-3e7bdcd86548"));
		}

		#endregion

	}

	#endregion

}

