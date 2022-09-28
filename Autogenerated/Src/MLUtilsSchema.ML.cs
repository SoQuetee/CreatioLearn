﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLUtilsSchema

	/// <exclude/>
	public class MLUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLUtilsSchema(MLUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0af1c93-3847-4041-a07a-a99e24cacdf4");
			Name = "MLUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,85,219,110,219,48,12,125,78,129,254,3,225,61,204,30,58,167,207,109,18,160,75,47,8,150,108,5,146,174,47,3,6,197,97,28,33,178,100,232,146,206,40,250,239,163,172,220,28,100,107,129,1,219,67,28,155,164,200,35,242,232,72,178,2,77,201,50,132,9,106,205,140,154,219,180,175,228,156,231,78,51,203,149,76,71,195,211,147,231,211,147,150,51,92,230,144,11,53,101,226,226,162,175,138,130,156,67,149,231,100,190,220,250,247,179,248,136,227,30,141,191,179,167,215,159,200,69,206,119,26,115,42,15,125,193,140,185,128,209,240,193,114,97,106,87,187,221,134,142,113,69,193,116,213,91,127,123,47,183,28,13,204,149,134,130,101,11,46,17,4,50,45,169,72,186,89,213,222,91,86,186,169,224,25,24,75,251,204,32,243,117,118,101,90,207,117,169,45,140,91,142,98,70,56,238,53,95,49,139,193,89,134,143,77,10,141,108,166,164,168,96,64,109,129,31,130,30,93,160,215,17,147,44,71,157,222,161,245,253,66,29,71,163,97,148,92,174,43,160,156,133,34,205,138,35,180,11,85,151,172,113,6,231,225,214,107,67,127,129,217,210,128,93,32,92,221,15,96,137,85,186,141,109,31,6,119,74,166,89,1,146,230,222,141,156,65,77,211,150,152,249,81,71,189,9,165,240,54,200,182,198,180,211,174,87,236,18,104,180,78,75,211,235,100,61,171,29,118,218,89,15,248,28,88,201,125,105,224,6,12,218,51,80,132,71,63,113,131,240,17,40,116,206,132,169,99,41,225,38,67,221,195,198,20,166,74,137,176,159,171,146,127,198,42,126,104,32,132,38,224,4,60,49,91,173,21,211,190,60,197,83,195,169,203,212,5,191,246,32,248,178,142,37,164,113,136,77,7,230,139,19,226,171,190,41,74,91,197,201,38,91,203,79,46,125,36,230,196,209,119,59,70,189,226,217,182,179,126,123,232,227,211,0,19,222,247,133,114,179,117,148,9,149,223,131,169,140,197,194,55,194,18,253,12,172,152,112,24,173,33,180,194,254,161,110,73,48,189,212,207,181,221,119,181,54,191,188,62,116,223,120,89,65,33,160,212,106,42,168,166,173,74,132,5,243,83,8,200,157,22,255,133,15,4,107,3,225,0,206,95,147,99,96,214,13,127,208,98,140,246,109,44,25,163,32,3,225,168,255,186,16,7,67,34,241,9,194,235,33,99,194,180,72,151,156,180,113,244,33,218,24,110,181,42,252,25,190,15,45,159,80,199,183,190,71,218,24,198,183,78,102,233,16,137,65,59,160,81,146,16,229,238,72,37,44,73,64,95,9,87,72,175,181,198,198,231,201,134,157,210,82,175,169,28,225,11,64,211,155,159,152,57,139,227,140,9,166,59,20,208,139,247,168,188,14,238,194,121,147,190,215,56,117,121,28,77,60,26,96,244,147,138,196,173,65,18,3,79,220,46,60,71,97,31,228,17,66,134,34,61,56,127,149,149,116,248,254,189,16,93,173,149,199,111,135,206,162,87,253,153,191,89,152,156,209,89,98,116,49,208,199,211,130,219,112,211,153,63,146,204,88,237,195,119,42,242,102,5,90,214,242,19,135,4,73,125,153,53,111,210,113,69,180,13,130,224,239,130,111,94,19,14,40,119,6,209,17,61,137,246,6,190,12,194,165,236,113,237,10,32,124,208,68,243,34,62,54,77,114,238,207,241,224,254,9,214,166,145,108,191,0,88,87,20,47,40,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0af1c93-3847-4041-a07a-a99e24cacdf4"));
		}

		#endregion

	}

	#endregion

}
