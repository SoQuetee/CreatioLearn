﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DataProviderExceptionSchema

	/// <exclude/>
	public class DataProviderExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DataProviderExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DataProviderExceptionSchema(DataProviderExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29d0b1e4-47c2-4642-a043-e4aab804fb5b");
			Name = "DataProviderException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,86,77,111,26,49,16,61,19,41,255,97,68,122,8,42,90,238,36,65,106,73,165,114,104,133,32,57,85,61,152,221,89,176,186,107,111,253,65,146,34,254,123,199,222,111,150,66,84,169,106,213,11,172,103,103,158,223,60,191,193,8,150,162,206,88,136,240,128,74,49,45,99,19,76,165,136,249,218,42,102,184,20,193,131,98,225,55,46,214,151,23,187,203,139,158,213,244,8,203,23,109,48,189,57,88,7,159,209,116,98,11,43,12,79,49,88,162,226,44,225,63,60,40,101,81,222,149,194,53,45,96,154,48,173,199,112,207,12,155,43,185,229,17,170,15,207,33,102,46,211,39,142,70,35,184,213,54,77,153,122,153,20,235,247,76,35,68,84,2,89,81,3,88,22,149,161,8,98,169,224,221,124,22,148,32,163,6,202,151,138,210,42,193,175,20,200,236,42,225,33,132,142,206,113,54,48,134,6,179,222,206,179,171,250,160,244,12,149,225,72,205,204,61,86,254,254,144,190,15,144,200,134,113,161,97,99,76,6,218,48,99,53,132,50,66,144,49,72,197,215,156,137,4,20,29,142,20,212,105,172,100,74,204,164,141,130,10,178,217,76,73,254,35,161,45,61,216,212,97,45,138,250,70,104,7,107,58,38,208,238,99,127,130,224,2,191,91,212,6,172,74,192,200,124,111,160,46,159,54,60,220,192,19,58,24,93,107,126,154,150,54,202,121,162,192,196,232,145,64,143,16,185,66,17,229,98,182,149,37,177,8,193,134,70,170,215,104,123,143,49,179,137,33,57,171,178,211,244,142,30,246,245,0,118,167,4,154,158,69,247,145,140,41,150,130,160,57,187,235,211,172,105,182,198,254,164,118,84,17,10,110,71,62,241,60,171,66,202,162,110,64,150,92,209,40,92,87,235,191,196,185,83,167,58,214,235,79,74,59,182,252,222,176,246,25,192,218,60,14,170,88,181,13,154,187,51,100,86,211,155,218,156,191,169,238,240,112,158,186,77,13,75,111,55,233,13,220,62,189,94,231,104,124,248,200,76,222,29,1,190,41,146,27,19,115,215,218,196,39,252,35,135,205,133,104,168,216,159,204,220,250,23,250,255,167,78,169,21,107,139,241,26,15,229,118,57,102,164,131,241,30,30,128,255,113,79,113,177,161,91,210,68,50,28,157,151,164,117,199,207,68,44,137,109,44,135,176,52,10,89,74,189,185,75,15,159,253,15,179,251,174,186,203,211,170,232,238,204,117,240,9,205,70,70,7,55,65,193,76,110,233,127,12,209,42,199,242,65,46,253,195,117,41,213,150,41,247,142,26,119,91,7,245,251,92,28,133,198,42,1,111,250,93,73,199,176,235,6,247,65,121,171,229,10,250,164,90,208,125,208,135,183,110,191,166,178,205,190,138,88,187,85,138,253,4,92,32,9,234,153,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29d0b1e4-47c2-4642-a043-e4aab804fb5b"));
		}

		#endregion

	}

	#endregion

}

