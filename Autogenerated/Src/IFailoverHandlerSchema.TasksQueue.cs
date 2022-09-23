namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFailoverHandlerSchema

	/// <exclude/>
	public class IFailoverHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFailoverHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFailoverHandlerSchema(IFailoverHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99cf0342-6c2a-4b19-8aa0-db2b06c2b200");
			Name = "IFailoverHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0feb11c-442a-4bb5-a527-aa32bcda81de");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,81,205,110,131,48,12,62,23,137,119,176,186,203,118,129,123,219,245,82,109,90,39,77,234,161,123,128,0,6,82,65,140,156,4,109,170,246,238,51,129,162,178,29,114,240,103,127,63,118,140,106,209,118,42,71,56,35,179,178,84,186,228,64,166,212,149,103,229,52,153,56,186,198,209,202,91,109,170,197,8,227,54,142,164,243,192,88,201,24,28,141,67,46,69,104,3,199,87,165,27,234,145,223,148,41,26,228,48,151,166,41,236,172,111,91,197,223,251,169,62,49,245,186,64,11,45,186,154,10,11,142,160,37,163,29,49,8,21,234,192,135,82,228,108,114,211,72,239,68,58,159,53,58,7,125,243,254,103,13,146,230,157,178,151,47,204,189,168,10,229,26,210,204,177,63,70,231,13,156,130,212,216,252,155,53,0,7,70,229,36,235,133,178,251,156,115,184,145,213,41,86,45,24,185,234,243,218,91,100,185,165,193,124,56,228,122,127,174,17,6,12,242,25,76,118,105,96,204,46,139,245,86,61,233,98,50,150,45,30,63,23,130,176,212,127,218,78,155,161,41,198,229,66,253,35,111,248,166,5,42,224,47,176,48,181,17,249,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99cf0342-6c2a-4b19-8aa0-db2b06c2b200"));
		}

		#endregion

	}

	#endregion

}

