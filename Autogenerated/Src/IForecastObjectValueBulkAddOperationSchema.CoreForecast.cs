namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueBulkAddOperationSchema

	/// <exclude/>
	public class IForecastObjectValueBulkAddOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueBulkAddOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueBulkAddOperationSchema(IForecastObjectValueBulkAddOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("949d29b4-32dc-fbc9-0241-7774107a898a");
			Name = "IForecastObjectValueBulkAddOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,75,107,132,48,20,133,215,10,254,135,139,221,180,80,20,186,108,173,208,55,174,6,58,101,246,87,115,117,210,106,34,121,12,12,67,255,123,99,124,32,76,23,165,187,228,228,220,239,158,36,87,96,71,186,199,138,224,131,148,66,45,107,147,60,73,81,243,198,42,52,92,138,228,85,42,170,80,155,221,77,20,158,162,48,176,154,139,6,182,71,109,168,115,214,182,165,106,240,233,228,141,4,41,94,221,69,161,115,93,40,106,156,10,133,48,164,106,199,191,133,98,38,109,202,79,87,179,195,214,210,163,109,191,30,24,219,244,52,118,243,181,105,154,66,166,109,215,161,58,230,211,126,225,64,45,21,32,99,67,8,135,147,138,105,48,114,80,61,27,246,92,27,169,142,32,125,19,56,12,93,38,99,50,179,211,21,188,183,101,203,43,224,11,255,111,49,131,147,143,122,150,213,11,206,250,159,108,231,225,70,165,71,133,29,8,247,83,247,177,22,216,235,189,52,113,62,199,132,89,202,82,111,252,189,110,138,19,231,239,227,98,109,62,72,206,134,204,211,209,229,76,222,78,224,103,52,184,116,185,134,226,69,216,206,61,68,217,82,182,122,163,177,58,159,47,126,229,230,32,248,30,103,129,4,27,199,97,216,58,237,7,5,241,27,223,117,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("949d29b4-32dc-fbc9-0241-7774107a898a"));
		}

		#endregion

	}

	#endregion

}

