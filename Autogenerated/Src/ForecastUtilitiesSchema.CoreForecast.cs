namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastUtilitiesSchema

	/// <exclude/>
	public class ForecastUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastUtilitiesSchema(ForecastUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91be19b7-738e-4443-9fd0-37cbba5954a8");
			Name = "ForecastUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,77,107,195,48,12,134,207,41,244,63,136,156,186,75,12,59,174,105,160,4,186,235,88,187,221,61,87,246,12,177,29,252,145,81,74,255,251,236,164,89,63,15,221,33,130,72,122,222,87,146,53,85,232,90,202,16,54,104,45,117,134,251,162,54,154,75,17,44,245,210,232,98,101,44,50,234,252,231,243,116,178,159,78,178,224,164,22,23,221,74,25,61,159,78,98,141,16,2,165,11,74,81,187,171,142,255,111,214,116,114,139,14,248,81,8,130,151,141,244,18,93,49,34,228,140,105,195,87,35,25,56,31,237,25,176,134,58,7,227,12,31,35,25,251,246,189,227,141,101,159,120,71,31,172,118,81,196,74,230,129,10,97,81,244,235,128,223,181,88,252,129,228,154,44,91,106,169,2,29,207,178,200,121,208,172,54,91,204,171,20,193,240,27,165,146,244,253,39,220,14,206,213,250,190,51,116,180,9,88,58,68,96,22,249,34,95,158,26,54,177,62,96,57,169,74,50,42,37,233,203,155,220,101,224,21,125,77,27,182,138,51,167,202,44,237,30,31,106,220,225,9,210,227,101,153,251,145,158,125,195,236,58,159,197,251,34,228,241,30,249,203,144,200,134,9,238,219,21,235,160,230,231,32,51,65,251,199,208,58,181,94,192,180,19,143,161,203,78,28,193,45,114,26,26,255,191,89,15,41,166,16,191,195,47,115,187,16,130,251,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91be19b7-738e-4443-9fd0-37cbba5954a8"));
		}

		#endregion

	}

	#endregion

}

