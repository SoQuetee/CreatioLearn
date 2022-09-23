namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileConstsSchema

	/// <exclude/>
	public class FileConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileConstsSchema(FileConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1");
			Name = "FileConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,79,79,194,64,16,197,207,144,240,29,38,112,209,195,74,255,81,90,137,7,41,148,152,120,32,17,245,188,237,78,113,99,217,54,221,69,211,16,191,187,187,173,162,24,140,33,158,54,59,243,222,155,95,50,35,232,6,101,73,83,132,21,86,21,149,69,166,46,30,49,185,46,203,94,119,215,235,118,182,146,139,53,220,213,82,225,102,210,235,234,202,160,194,53,47,4,68,57,149,242,18,98,158,99,84,8,169,100,211,45,183,73,206,83,144,138,42,253,164,70,115,32,233,236,26,217,62,37,230,152,51,29,179,108,124,109,111,56,52,14,80,117,137,64,26,183,4,42,24,228,92,60,75,48,138,195,41,21,82,86,136,188,134,197,150,179,70,191,210,214,251,27,6,87,32,240,181,41,159,245,71,78,56,141,156,56,32,214,124,110,145,89,108,219,36,28,219,83,98,89,246,204,183,230,161,27,68,126,255,124,242,137,112,171,135,253,130,240,23,129,177,30,37,112,79,34,152,11,197,85,253,15,142,175,128,163,52,94,152,164,78,166,105,16,45,194,178,150,38,49,52,204,183,80,211,164,223,105,140,189,164,107,132,23,172,164,222,156,132,34,3,245,132,144,153,93,157,204,102,228,15,31,73,139,138,179,165,142,254,73,136,129,151,38,158,75,137,231,185,54,241,252,208,37,9,99,148,80,219,115,236,32,113,211,81,56,222,19,14,80,176,246,166,154,255,91,123,171,7,69,93,123,7,133,162,212,214,239,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1"));
		}

		#endregion

	}

	#endregion

}

