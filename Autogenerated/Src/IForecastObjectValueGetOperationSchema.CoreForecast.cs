namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueGetOperationSchema

	/// <exclude/>
	public class IForecastObjectValueGetOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueGetOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueGetOperationSchema(IForecastObjectValueGetOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8085a14a-5f12-d391-672c-77b5acc1b8d6");
			Name = "IForecastObjectValueGetOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,65,107,195,48,12,133,207,41,228,63,136,238,178,193,72,96,199,45,205,101,44,165,48,40,172,163,119,39,149,51,143,196,14,178,61,40,101,255,125,178,211,148,64,7,61,57,122,121,122,254,108,75,139,30,237,32,26,132,79,36,18,214,72,151,189,26,45,85,235,73,56,101,116,86,25,194,70,88,183,127,74,23,167,116,145,120,171,116,11,187,163,117,216,179,181,235,176,9,62,155,173,81,35,169,230,37,93,176,235,142,176,101,21,54,218,33,73,206,127,134,205,148,180,173,191,185,103,47,58,143,107,116,219,1,199,157,98,95,158,231,80,88,223,247,130,142,229,185,190,100,128,52,4,45,58,23,8,228,57,13,76,140,131,159,144,7,172,25,58,216,108,138,202,103,89,131,175,59,213,128,186,196,221,38,74,78,145,234,10,43,10,108,189,77,113,141,49,42,131,32,209,131,230,235,95,45,237,23,162,91,150,187,176,20,121,252,243,191,81,170,142,217,199,247,89,150,85,172,160,137,229,85,31,161,243,164,109,249,174,152,14,181,239,249,80,117,135,96,228,132,87,228,147,39,52,109,222,46,158,98,118,31,31,209,91,134,195,142,159,246,62,114,66,132,126,132,106,134,4,115,190,7,30,132,228,119,28,6,212,135,113,30,66,201,218,31,52,81,98,22,118,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8085a14a-5f12-d391-672c-77b5acc1b8d6"));
		}

		#endregion

	}

	#endregion

}

