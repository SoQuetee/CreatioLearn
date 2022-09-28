﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsqDataProviderSchema

	/// <exclude/>
	public class EsqDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsqDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsqDataProviderSchema(EsqDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b749fe1-786e-461b-a25c-c9db1807ffe5");
			Name = "EsqDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("907f2de3-5104-49b3-a54a-bb8730240b72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,75,111,26,49,16,62,19,41,255,97,164,94,22,41,117,164,62,14,77,200,74,21,44,21,106,17,17,208,92,35,179,76,136,219,197,134,177,141,64,81,254,123,199,107,232,102,151,4,181,39,219,227,153,249,30,99,107,185,68,187,146,57,194,20,137,164,53,15,78,116,141,126,80,11,79,210,41,163,197,24,87,134,156,210,11,209,151,214,197,83,166,23,74,163,200,236,250,252,236,233,252,172,229,45,223,195,100,103,29,46,185,188,40,48,15,181,86,124,67,141,164,242,235,102,206,15,165,215,71,193,233,35,161,156,7,164,169,180,191,109,117,255,146,26,225,91,113,145,105,167,156,194,87,11,43,21,61,233,228,196,120,202,81,124,157,89,71,50,82,229,34,46,123,71,184,224,19,116,11,105,237,21,176,192,144,126,75,102,163,230,72,101,202,202,207,10,149,67,30,50,154,9,112,5,131,151,231,206,254,126,130,193,145,148,171,159,202,30,127,113,250,10,139,57,3,221,146,218,72,135,241,114,21,15,16,220,48,186,216,193,79,139,196,67,209,209,85,184,247,181,243,245,190,37,234,121,236,90,135,224,68,86,233,115,103,40,0,149,236,247,56,81,73,67,67,210,64,171,131,181,33,204,187,213,106,112,128,27,56,34,213,106,61,159,102,54,68,247,104,222,84,63,24,179,252,17,203,239,169,178,163,164,93,135,133,240,8,47,192,204,126,5,63,131,182,13,146,155,154,42,39,41,95,193,14,176,92,46,78,182,137,107,10,104,215,252,104,253,82,15,229,234,32,240,242,114,58,234,141,160,59,30,190,255,252,233,195,151,143,101,144,208,121,210,181,124,81,3,223,194,77,10,91,241,29,25,185,220,71,26,252,15,92,172,184,147,133,199,100,43,202,181,221,254,63,155,142,103,23,62,74,103,144,105,191,68,146,179,2,59,255,224,90,154,2,211,9,35,79,106,207,19,108,185,28,12,216,72,218,179,175,62,52,143,57,38,133,175,31,68,101,141,132,164,241,46,162,192,131,111,129,173,232,147,89,142,209,250,194,37,205,246,34,18,217,199,131,125,175,13,248,48,217,138,73,53,188,147,142,198,104,61,200,177,63,169,134,255,108,3,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b749fe1-786e-461b-a25c-c9db1807ffe5"));
		}

		#endregion

	}

	#endregion

}
