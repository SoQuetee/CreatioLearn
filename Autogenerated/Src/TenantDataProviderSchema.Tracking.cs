﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TenantDataProviderSchema

	/// <exclude/>
	public class TenantDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TenantDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TenantDataProviderSchema(TenantDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9cf1bddb-587e-4ccd-8e7a-cb0987fe1fda");
			Name = "TenantDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,81,111,26,49,12,126,166,82,255,131,69,31,10,154,196,189,23,138,52,209,173,226,97,18,162,244,121,10,119,6,162,114,201,205,201,177,49,212,255,62,39,57,104,56,142,238,158,184,56,246,103,251,243,135,163,68,142,166,16,41,194,2,137,132,209,43,59,152,104,181,146,235,146,132,149,90,13,22,36,210,55,169,214,183,55,135,219,155,78,105,248,19,94,246,198,98,62,60,157,227,88,66,182,243,205,29,225,154,227,97,178,21,198,60,176,139,18,202,78,213,74,207,57,161,86,6,189,87,146,36,48,50,101,158,11,218,143,171,243,19,154,84,46,209,0,85,158,176,34,157,179,27,34,164,132,171,199,110,0,123,18,86,204,72,239,100,134,52,120,70,251,145,162,215,239,38,227,193,17,62,137,240,139,114,185,149,41,164,174,168,134,154,224,1,98,212,143,82,59,7,95,238,169,43,246,40,144,172,68,110,109,230,49,195,125,189,31,111,0,46,206,128,38,48,238,151,129,149,149,118,207,39,218,73,102,62,221,74,182,176,125,112,66,136,75,62,214,108,44,57,174,167,85,248,196,71,77,51,56,192,26,237,208,97,15,225,189,117,21,182,26,235,169,10,235,201,248,111,21,207,165,204,28,113,87,115,223,161,202,2,73,254,28,172,53,99,163,54,98,226,175,106,163,114,0,201,67,163,220,43,52,168,163,42,191,234,166,237,236,227,156,112,44,228,37,96,156,215,83,23,192,119,137,219,204,13,159,228,78,216,32,230,78,17,14,44,92,145,105,181,221,31,103,246,179,16,118,51,227,175,10,26,30,161,155,136,66,38,33,97,82,240,85,119,216,2,195,105,245,10,134,99,228,136,81,163,251,131,111,22,179,165,50,181,154,218,232,54,114,7,189,2,17,168,187,162,15,111,41,4,137,28,20,47,149,199,110,201,179,96,4,133,169,155,82,119,60,101,48,161,184,112,134,122,61,187,27,140,18,31,24,235,236,114,62,189,243,32,56,199,239,187,216,78,231,1,150,194,96,175,118,199,58,109,86,231,137,153,31,104,55,58,107,67,138,27,163,105,144,219,53,74,8,109,73,202,140,231,103,203,204,110,240,20,60,74,142,62,81,255,77,107,200,231,14,196,244,184,39,223,241,78,16,56,249,188,210,150,21,17,46,221,247,151,11,209,13,189,127,72,5,47,204,195,66,191,161,146,127,49,227,197,48,199,95,37,26,59,106,74,59,238,85,9,250,30,226,179,29,243,237,15,166,165,245,171,219,227,129,213,112,95,87,233,253,229,242,249,141,75,248,58,155,182,225,49,150,209,197,147,16,239,114,247,4,52,82,219,176,246,107,175,71,196,109,217,204,107,244,71,108,197,235,101,206,113,175,172,49,218,98,115,190,255,3,128,4,60,1,176,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9cf1bddb-587e-4ccd-8e7a-cb0987fe1fda"));
		}

		#endregion

	}

	#endregion

}
