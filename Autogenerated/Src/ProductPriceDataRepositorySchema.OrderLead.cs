﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProductPriceDataRepositorySchema

	/// <exclude/>
	public class ProductPriceDataRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProductPriceDataRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProductPriceDataRepositorySchema(ProductPriceDataRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("600d1dd0-1fa6-47c0-8dba-8e1f2fd8dcc0");
			Name = "ProductPriceDataRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c797525-d05e-4bd8-84e9-5dcb79ad7c60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,77,143,219,56,12,61,187,64,255,3,145,94,28,32,112,238,157,76,128,233,76,59,72,177,139,6,219,180,123,88,244,160,218,204,68,88,91,202,74,242,204,100,23,249,239,165,37,203,150,63,50,73,187,167,68,20,31,73,145,143,164,5,43,80,239,89,138,176,65,165,152,150,91,147,220,74,177,229,15,165,98,134,75,241,250,213,127,175,95,69,165,230,226,1,62,31,180,193,226,170,119,38,253,60,199,180,82,214,201,61,10,84,60,29,232,220,49,195,90,97,232,171,40,164,24,191,81,120,74,158,220,189,163,43,186,124,163,240,129,252,194,109,206,180,126,11,107,37,179,50,53,107,138,0,43,143,127,224,94,106,110,164,58,88,237,249,124,14,11,93,22,5,83,135,101,125,182,72,216,74,5,26,235,87,128,197,255,198,181,129,173,146,5,172,153,50,244,42,189,227,251,196,91,153,7,102,246,229,247,156,167,144,90,75,47,133,16,85,169,108,98,254,192,49,207,92,208,134,28,99,102,99,140,246,254,8,10,89,38,69,126,128,47,26,21,21,69,212,225,117,143,87,93,208,29,183,82,10,109,113,95,242,108,54,8,104,217,145,84,175,212,46,151,209,27,20,153,139,173,62,251,228,82,97,141,34,132,84,85,184,246,181,78,163,159,80,43,88,9,110,56,203,249,191,168,129,129,192,39,224,132,103,130,56,38,183,96,118,72,16,68,72,21,110,175,39,167,211,53,153,47,93,74,147,198,211,188,239,106,177,103,138,21,32,136,196,215,147,178,147,150,201,114,67,158,42,25,164,141,48,89,204,45,194,26,168,203,118,58,130,184,151,247,174,131,41,216,106,70,61,165,235,158,154,45,79,52,72,57,233,85,153,57,95,173,120,106,45,28,95,46,209,239,104,118,210,145,137,63,50,131,158,74,246,0,159,45,179,225,30,77,63,14,119,19,87,127,109,0,75,216,251,171,85,166,103,208,185,176,80,18,251,151,43,52,165,18,246,29,181,157,110,46,166,86,43,138,170,1,81,22,34,158,172,215,147,25,76,172,243,201,52,185,209,177,255,127,74,177,246,216,40,55,231,113,192,134,61,55,202,245,255,113,197,219,82,41,20,233,161,209,14,5,125,200,198,198,130,42,69,97,124,36,254,244,194,11,93,14,195,119,122,137,7,125,160,225,18,119,58,192,107,175,91,165,21,101,83,125,148,92,216,39,249,199,181,247,159,124,132,214,215,74,191,255,167,100,121,47,33,94,247,207,29,42,236,5,67,14,98,23,125,178,174,90,3,13,77,186,56,100,193,180,193,223,136,172,83,133,83,216,134,40,53,146,233,154,32,158,202,81,20,210,179,207,121,184,165,201,103,176,47,142,87,174,61,89,70,61,173,236,207,8,19,7,198,156,70,100,83,65,93,231,128,180,167,140,139,252,43,203,75,116,20,111,72,51,115,144,150,20,231,112,33,125,102,141,191,154,37,39,193,25,166,188,96,249,50,224,83,13,182,209,95,130,115,164,9,81,174,104,231,2,30,242,241,248,115,99,230,242,37,64,129,248,129,10,79,220,236,252,32,113,147,6,114,59,13,185,0,169,170,186,230,252,111,172,78,237,37,141,111,255,121,113,233,38,8,217,59,89,174,91,83,100,88,241,135,157,113,206,58,219,96,196,136,167,113,101,194,254,119,223,9,79,60,221,193,19,18,219,104,221,118,30,51,182,94,30,37,207,130,108,252,226,168,125,100,202,75,123,179,155,42,125,122,174,119,61,4,102,221,86,26,183,152,188,127,198,180,52,232,58,45,118,60,130,235,165,239,164,32,150,75,136,214,76,139,171,16,254,107,76,173,77,240,45,196,131,141,154,108,212,129,76,88,112,59,131,102,32,75,51,28,10,123,133,143,92,150,186,190,168,100,83,202,53,212,147,174,114,16,230,142,6,93,134,207,159,182,241,8,46,9,34,156,66,183,170,1,174,213,241,53,29,251,44,248,171,9,252,27,37,230,196,28,172,103,95,157,12,55,79,233,7,48,215,216,216,30,230,231,38,203,194,188,188,108,220,91,63,70,110,86,71,199,206,119,200,104,207,83,246,125,166,235,254,173,218,197,119,200,255,251,8,244,62,170,65,65,5,221,251,117,115,249,72,240,60,244,205,12,60,163,145,203,183,252,220,32,80,168,203,220,150,186,197,186,231,101,85,249,7,88,183,140,116,79,23,159,185,209,139,185,191,12,38,196,119,41,115,112,228,29,84,163,106,2,56,71,230,54,192,222,62,252,169,30,9,172,156,90,5,181,172,187,29,142,63,0,105,235,132,212,67,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("600d1dd0-1fa6-47c0-8dba-8e1f2fd8dcc0"));
		}

		#endregion

	}

	#endregion

}
