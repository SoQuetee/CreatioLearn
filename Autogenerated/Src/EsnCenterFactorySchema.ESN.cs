namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnCenterFactorySchema

	/// <exclude/>
	public class EsnCenterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnCenterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnCenterFactorySchema(EsnCenterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1");
			Name = "EsnCenterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,81,79,219,48,16,199,159,139,196,119,176,202,75,34,161,244,157,66,165,45,43,83,165,129,38,24,79,104,15,110,114,13,214,194,185,58,219,176,10,241,221,119,142,219,164,78,91,86,242,20,255,125,247,187,243,249,159,160,124,6,179,148,5,136,95,64,36,141,94,216,44,215,184,80,149,35,105,149,198,108,122,127,123,122,242,118,122,50,112,70,97,37,114,77,48,142,86,217,181,44,172,38,5,134,117,222,57,35,168,56,81,136,188,150,198,92,136,169,193,28,208,2,133,184,85,19,52,26,141,196,165,194,39,32,101,75,93,136,209,132,197,199,111,176,144,174,182,95,21,150,76,79,236,106,9,122,145,204,250,132,52,253,205,209,75,55,175,85,33,10,95,101,167,136,184,16,59,105,156,227,207,209,54,120,3,246,73,151,220,225,207,134,212,244,181,191,177,77,173,14,41,114,2,105,161,93,39,15,6,136,7,135,80,248,169,9,23,45,83,209,20,30,188,72,234,237,124,161,202,61,51,65,92,9,132,87,158,39,26,75,206,183,187,217,73,134,113,198,240,188,15,31,183,236,90,253,129,59,88,106,163,154,25,92,133,43,88,31,63,251,14,246,210,159,224,71,20,53,73,246,119,180,133,5,131,55,96,140,172,56,77,150,124,248,3,224,40,232,147,220,178,97,253,151,28,194,142,99,223,67,225,248,22,87,83,172,20,194,33,116,28,117,4,185,214,21,239,91,248,187,185,52,63,210,78,11,55,221,60,172,78,81,206,107,40,57,50,230,250,242,51,115,205,30,114,4,235,160,100,216,218,137,51,43,160,181,62,76,207,59,166,247,217,108,15,47,119,68,156,234,183,179,89,217,75,184,229,175,252,227,20,31,209,229,188,143,55,239,4,220,32,238,78,174,237,116,146,28,244,45,244,173,198,214,141,29,186,125,176,193,71,156,200,89,140,233,75,159,7,5,35,245,80,65,60,26,22,91,39,176,98,237,56,84,231,40,63,161,118,145,6,211,189,135,31,211,25,96,25,126,92,188,10,218,182,196,202,63,163,179,254,253,204,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04389b5a-20dc-4773-ad27-ab521c1b58a1"));
		}

		#endregion

	}

	#endregion

}

