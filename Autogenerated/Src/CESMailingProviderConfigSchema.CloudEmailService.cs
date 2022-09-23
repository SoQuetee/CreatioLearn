namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigSchema

	/// <exclude/>
	public class CESMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigSchema(CESMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4");
			Name = "CESMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,77,107,194,64,16,61,71,240,63,12,241,210,94,18,74,15,130,90,65,108,11,30,74,133,8,61,20,15,235,102,146,46,236,71,152,221,8,34,253,239,93,55,81,172,52,245,208,222,102,222,188,153,121,111,103,53,83,104,43,198,17,86,72,196,172,41,92,50,55,186,16,101,77,204,9,163,251,189,125,191,23,213,86,232,18,178,157,117,168,198,167,188,163,37,153,63,101,158,228,105,3,194,210,3,192,37,179,118,4,30,127,97,66,250,214,37,153,173,200,145,154,190,192,77,211,20,38,182,86,138,209,110,218,230,45,205,2,15,60,48,5,184,15,4,213,12,129,170,157,146,28,219,211,179,254,170,222,72,193,155,213,157,155,97,4,139,14,73,209,62,200,58,121,240,245,10,201,9,244,70,150,97,118,83,191,212,29,128,133,182,142,105,255,170,173,226,137,69,4,78,88,60,196,199,125,43,84,149,100,14,159,25,119,134,118,113,58,77,78,227,206,125,28,141,116,244,193,101,126,56,87,20,149,232,198,33,176,109,240,249,55,181,179,58,23,232,41,143,204,177,204,212,196,175,235,126,127,221,88,35,209,225,77,252,38,164,132,13,2,161,50,91,204,129,21,14,9,134,201,221,48,185,143,111,215,63,184,236,220,7,221,149,61,252,175,117,255,105,102,149,184,126,152,134,7,25,210,86,112,60,132,191,223,96,128,58,111,62,85,200,27,244,59,232,177,47,110,138,251,51,154,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4"));
		}

		#endregion

	}

	#endregion

}

