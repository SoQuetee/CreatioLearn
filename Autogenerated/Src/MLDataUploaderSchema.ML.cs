﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLDataUploaderSchema

	/// <exclude/>
	public class MLDataUploaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLDataUploaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLDataUploaderSchema(MLDataUploaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bbd5bc2a-31b9-4357-9afa-3ec7a140e7fe");
			Name = "MLDataUploader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,77,111,26,49,16,61,111,164,254,135,17,189,128,138,150,158,147,192,33,164,169,34,65,20,149,244,84,85,145,217,157,5,171,187,54,181,189,164,52,202,127,175,191,150,253,192,32,42,245,208,19,216,158,121,51,126,243,102,188,140,20,40,55,36,65,120,66,33,136,228,153,138,167,156,101,116,85,10,162,40,103,241,124,246,238,226,245,221,69,84,74,202,86,176,216,73,133,197,213,126,221,244,18,24,223,222,28,61,186,35,137,226,130,162,12,89,204,103,241,61,83,40,50,157,137,49,208,38,239,5,174,116,124,216,239,95,194,253,124,118,75,20,249,186,201,57,73,81,88,179,209,104,4,215,178,44,10,34,118,19,191,118,6,18,82,109,12,138,67,65,146,53,101,8,57,18,193,76,96,137,98,75,19,140,43,255,81,3,96,83,46,115,154,0,173,194,30,70,141,94,109,228,125,134,115,84,107,158,202,75,120,180,174,238,176,155,87,43,49,181,198,179,146,59,204,206,237,108,136,32,5,48,93,187,113,79,98,142,137,234,77,174,37,34,36,2,179,113,239,160,40,241,194,25,141,38,240,179,68,177,27,234,12,136,2,129,170,20,172,145,78,198,5,40,65,168,201,163,17,223,134,171,163,123,183,201,67,89,44,81,0,207,160,116,220,164,26,49,225,34,149,241,245,168,50,50,94,154,75,127,245,190,75,4,92,210,131,43,79,36,178,212,113,105,215,111,174,254,237,205,138,236,105,78,164,166,250,76,37,60,10,190,165,41,74,32,176,36,82,243,99,188,237,53,105,177,201,177,64,166,172,202,165,185,133,161,161,193,98,167,238,134,188,189,40,130,202,113,9,32,146,92,242,64,37,218,77,21,119,225,97,100,48,190,221,98,70,202,92,221,80,150,234,34,244,213,110,131,60,235,119,140,7,131,239,181,82,221,157,218,6,16,104,150,174,108,239,40,230,86,181,130,110,137,66,119,184,113,11,93,72,146,114,150,239,42,152,153,131,125,46,242,122,117,117,204,97,225,20,172,201,255,181,51,46,205,117,216,233,115,73,83,120,150,40,165,206,236,62,61,138,60,231,41,230,159,182,186,108,242,129,43,154,81,155,211,225,102,88,88,181,136,116,197,149,40,205,64,58,167,109,239,25,85,148,228,244,183,21,18,195,23,45,4,169,8,211,195,225,80,54,135,170,177,5,58,183,157,219,108,245,38,79,26,253,216,136,128,141,177,137,15,26,180,61,30,60,167,14,170,234,110,240,251,160,187,131,57,206,78,227,248,235,88,16,247,255,180,125,160,40,189,137,45,31,160,221,5,198,3,113,189,166,219,36,246,187,154,106,147,52,116,242,217,223,116,216,17,173,3,25,26,248,40,58,34,162,64,186,3,120,181,46,29,1,195,24,2,138,142,106,241,106,131,182,144,163,86,215,232,227,188,110,159,40,164,94,19,34,168,233,200,207,198,163,194,174,159,34,193,149,158,176,152,158,249,26,37,235,146,253,176,143,192,185,66,53,182,78,14,213,75,182,196,253,67,208,174,105,149,11,108,169,80,37,201,97,203,117,189,92,248,169,9,108,216,233,235,142,52,194,52,104,71,168,143,157,139,181,54,102,195,198,200,24,252,29,61,255,251,75,13,255,246,169,174,54,78,60,217,53,70,211,169,254,26,10,191,224,190,80,91,34,246,136,95,28,224,148,151,218,105,12,31,157,206,13,130,224,47,213,110,171,37,226,89,85,85,135,58,4,95,94,146,101,86,56,30,114,0,227,137,15,24,117,213,99,101,227,66,69,193,76,62,140,187,112,222,58,212,129,177,253,179,179,147,98,161,63,17,112,186,38,108,133,105,255,185,49,101,158,12,253,11,183,182,70,177,201,68,239,50,153,233,186,234,194,248,153,19,76,200,39,251,230,127,29,233,123,138,78,168,57,244,121,164,247,254,0,176,6,216,87,202,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bbd5bc2a-31b9-4357-9afa-3ec7a140e7fe"));
		}

		#endregion

	}

	#endregion

}

