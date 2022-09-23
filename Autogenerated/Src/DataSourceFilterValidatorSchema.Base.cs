﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DataSourceFilterValidatorSchema

	/// <exclude/>
	public class DataSourceFilterValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DataSourceFilterValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DataSourceFilterValidatorSchema(DataSourceFilterValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c7ab432-5c65-4d1c-b86f-258287b05acf");
			Name = "DataSourceFilterValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,77,107,219,64,16,61,43,144,255,48,206,33,216,151,165,45,133,30,140,3,193,113,65,16,146,80,39,237,161,244,176,146,71,242,194,106,87,221,157,77,107,234,252,247,174,190,34,89,182,227,152,228,96,91,222,157,247,102,230,205,135,20,207,208,230,60,70,184,71,99,184,213,9,177,169,86,137,72,157,225,36,180,58,61,249,119,122,18,56,43,84,10,243,149,37,204,198,189,255,236,90,168,223,237,97,151,199,32,155,41,18,36,208,238,50,120,8,217,15,140,188,59,50,90,90,214,60,120,83,111,252,243,54,178,90,34,225,240,236,11,251,248,153,125,130,53,76,37,183,22,132,5,165,9,132,2,103,17,184,90,192,31,33,37,68,8,6,51,253,136,139,242,42,143,117,86,184,51,40,145,91,180,103,163,95,158,53,119,145,20,49,88,242,201,197,16,151,124,87,156,248,92,59,19,227,87,33,9,205,119,46,197,130,147,54,222,190,72,62,200,141,120,228,132,13,42,210,90,66,104,47,213,234,26,19,154,253,205,13,90,235,165,186,113,82,222,154,89,150,211,106,216,231,132,164,252,25,65,73,24,148,20,30,230,36,193,4,18,46,45,142,203,11,145,192,176,50,133,201,4,148,103,108,32,129,65,114,70,213,168,202,250,169,252,238,1,189,142,89,206,141,176,90,221,175,114,44,120,170,24,54,207,89,104,139,128,97,189,174,232,131,163,209,154,110,94,21,95,39,180,77,193,246,165,72,198,225,30,130,111,34,93,190,204,80,107,218,225,0,244,242,54,6,251,185,88,147,111,191,118,173,73,153,249,60,94,98,198,167,90,186,76,181,234,5,111,35,189,76,83,131,105,57,113,207,185,180,201,204,201,248,86,174,43,214,180,216,62,135,220,164,72,85,120,119,156,150,163,74,133,90,202,224,189,84,184,227,198,175,142,162,79,119,196,59,216,71,254,140,178,48,168,42,7,231,231,7,20,108,49,190,55,157,162,2,249,97,51,171,206,28,108,119,97,121,249,78,99,236,101,149,24,23,85,170,7,186,61,56,98,180,59,44,199,13,121,75,219,227,97,62,11,79,14,147,11,127,197,14,36,53,170,197,123,73,170,141,53,249,26,165,104,233,215,114,216,215,43,244,239,135,58,216,226,113,183,70,7,152,91,56,240,237,101,221,41,192,120,115,27,14,42,7,219,171,225,77,254,70,59,138,178,75,70,255,121,250,15,99,96,185,220,93,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c7ab432-5c65-4d1c-b86f-258287b05acf"));
		}

		#endregion

	}

	#endregion

}

