namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastExportToExcelServiceSchema

	/// <exclude/>
	public class IForecastExportToExcelServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastExportToExcelServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastExportToExcelServiceSchema(IForecastExportToExcelServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c9ba928-203d-4631-aa4f-bccc69f69d0a");
			Name = "IForecastExportToExcelService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,77,107,195,48,12,61,175,208,255,32,114,218,96,36,176,235,210,92,70,59,202,14,131,110,244,238,56,74,235,205,177,139,236,180,11,163,255,125,178,147,150,126,237,22,189,188,247,244,36,217,136,6,221,70,72,132,79,36,18,206,214,62,125,177,166,86,171,150,132,87,214,164,51,75,40,133,243,203,167,241,232,119,60,186,107,157,50,43,248,232,156,199,134,169,90,163,12,60,151,190,162,65,82,242,249,200,249,207,113,250,179,177,228,63,237,244,71,162,102,58,11,178,44,131,220,181,77,35,168,43,134,122,110,60,82,29,162,213,150,0,163,40,216,214,67,32,88,43,231,45,117,80,145,210,186,178,59,3,149,240,2,188,101,50,59,167,7,223,236,196,120,211,150,90,73,80,71,239,249,97,190,179,84,31,72,91,37,145,5,191,49,223,85,192,8,188,16,10,143,14,132,169,96,71,42,124,198,206,224,60,255,105,66,18,109,165,8,181,37,177,194,72,36,244,45,153,97,30,248,198,46,61,250,103,151,13,242,141,32,246,49,124,164,73,82,43,205,161,251,85,38,197,44,86,253,196,242,108,189,121,22,85,183,77,108,249,197,247,90,10,221,226,2,165,165,202,37,197,123,196,96,27,64,142,23,209,71,216,173,149,92,195,142,87,11,37,14,113,177,186,118,239,231,113,69,238,16,65,18,214,147,228,108,149,11,126,95,252,60,48,201,138,30,231,22,61,194,94,7,113,112,187,169,130,87,60,191,204,27,118,247,179,147,77,192,233,90,30,97,62,53,109,131,36,74,141,249,251,229,172,5,92,143,255,16,222,235,126,60,218,195,31,236,253,180,58,11,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c9ba928-203d-4631-aa4f-bccc69f69d0a"));
		}

		#endregion

	}

	#endregion

}

