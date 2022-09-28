﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLConstsSchema

	/// <exclude/>
	public class MLConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLConstsSchema(MLConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("786986e9-18ac-42e8-a1d8-4e690bf80ee5");
			Name = "MLConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,219,110,227,54,16,125,78,128,252,3,145,190,100,31,104,75,34,37,139,109,119,1,137,23,108,81,27,13,234,180,251,44,75,180,77,64,162,12,73,206,174,81,244,223,59,164,156,196,221,180,46,188,141,1,193,224,237,204,153,209,153,67,217,162,209,253,174,40,53,122,208,93,87,244,237,122,152,240,214,174,205,102,223,21,131,105,237,100,49,191,185,254,227,230,250,230,250,234,187,78,111,96,6,241,186,232,251,239,209,98,14,27,251,161,247,107,211,233,20,253,216,239,155,166,232,14,31,142,99,191,92,216,161,71,235,182,67,77,81,110,141,213,168,214,69,103,141,221,160,186,221,152,114,242,116,118,122,114,120,183,95,213,166,68,112,120,128,191,210,133,59,137,118,5,108,174,94,5,244,19,15,91,61,110,55,107,83,122,250,104,215,181,171,90,55,104,56,236,52,186,91,204,239,199,241,3,12,223,77,158,129,78,163,63,133,47,93,60,32,209,57,178,252,111,168,39,32,232,61,186,77,103,169,204,101,24,226,60,80,4,83,146,73,156,166,89,140,101,148,114,170,66,193,169,36,183,63,156,101,221,151,173,143,243,70,116,151,35,220,87,60,195,148,112,26,231,4,171,88,73,76,165,18,56,103,140,224,40,12,18,25,203,68,40,17,159,225,249,171,222,116,26,170,240,118,85,125,65,252,138,41,9,103,65,22,209,8,83,38,161,162,74,48,204,152,20,56,16,9,44,229,66,100,65,118,150,105,217,54,141,182,213,168,129,59,174,222,189,153,16,218,186,46,86,173,107,142,71,173,76,61,104,63,13,156,103,89,26,240,80,101,56,201,28,231,32,8,49,131,170,226,76,5,179,76,10,248,133,244,63,84,208,20,198,14,218,22,22,250,241,179,177,85,251,217,53,65,55,160,70,15,219,182,2,218,47,27,62,249,245,75,168,191,58,188,116,216,139,17,26,18,136,120,42,132,98,25,230,33,227,152,70,60,199,121,72,9,150,12,212,156,135,25,15,114,47,143,179,41,64,84,109,123,141,218,157,30,13,4,56,84,218,59,192,174,211,149,41,93,221,80,175,187,71,216,216,95,192,126,110,202,95,158,48,185,131,4,198,247,207,136,203,17,112,242,91,175,207,82,252,89,31,60,151,18,220,72,87,96,22,70,91,8,81,118,102,7,85,46,0,118,117,128,83,26,124,164,211,235,247,183,222,118,94,220,112,233,55,230,123,83,87,186,187,157,126,184,128,255,145,107,1,162,147,118,48,131,209,253,136,230,40,65,46,78,145,175,118,156,205,229,147,169,107,180,2,166,219,182,215,22,13,80,253,199,162,222,59,233,12,91,244,209,108,182,168,55,27,235,93,203,41,170,210,107,48,224,202,101,184,152,35,105,55,206,142,239,142,25,86,80,135,223,221,233,81,15,23,233,106,62,98,45,79,130,253,19,230,79,94,101,49,151,68,197,130,131,9,209,16,83,145,112,156,207,84,138,83,16,29,33,33,97,48,250,31,105,15,190,141,190,152,102,223,248,150,47,86,166,54,195,193,27,236,219,100,91,124,185,127,193,253,247,60,9,207,19,18,65,255,7,146,43,76,99,197,112,30,39,57,14,37,139,3,17,170,36,98,249,217,60,23,32,242,26,98,215,251,198,246,104,223,195,155,115,202,29,58,104,99,32,114,9,101,135,196,61,144,179,187,135,35,130,99,9,54,197,162,32,22,88,144,44,129,183,161,56,78,185,162,152,82,166,120,206,194,156,145,224,91,88,62,245,58,124,64,124,51,207,251,103,12,127,121,69,81,66,224,154,197,65,194,128,159,228,2,167,36,137,48,60,148,206,8,17,193,241,74,248,115,252,88,1,247,31,191,87,220,16,230,254,2,11,75,150,2,234,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("786986e9-18ac-42e8-a1d8-4e690bf80ee5"));
		}

		#endregion

	}

	#endregion

}
