namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAppEventListenerSchema

	/// <exclude/>
	public class CampaignAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAppEventListenerSchema(CampaignAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e");
			Name = "CampaignAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1f302b36-4763-41e5-806c-b1f1f1b6d901");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,81,107,219,48,16,126,78,161,255,225,112,95,82,24,214,123,154,26,182,52,133,140,142,141,185,208,103,69,62,219,98,150,100,36,185,212,43,251,239,59,203,78,230,100,205,12,101,108,125,147,238,78,223,125,247,233,147,52,87,232,106,46,16,238,209,90,238,76,238,227,149,209,185,44,26,203,189,52,250,252,236,249,252,108,214,56,169,139,131,18,139,241,138,171,154,203,66,95,77,21,196,27,237,209,230,212,197,77,215,166,158,91,159,210,138,87,39,139,111,185,240,198,202,151,225,30,112,75,85,74,153,142,24,229,47,44,22,52,8,172,42,238,220,2,118,141,222,215,245,250,17,181,191,147,206,163,70,27,106,25,99,176,116,141,82,220,182,201,176,255,138,181,69,71,149,14,20,250,210,100,14,188,1,169,165,151,188,146,223,17,72,190,111,188,192,120,119,158,141,0,234,102,91,73,1,162,235,125,178,53,44,96,243,59,157,217,115,160,180,231,255,169,111,190,128,47,1,179,79,30,19,14,129,15,82,19,201,129,150,163,60,34,8,139,249,117,20,52,232,213,107,35,150,128,244,168,92,188,7,98,199,72,203,154,91,174,64,147,75,174,35,97,232,26,159,124,148,108,180,243,92,147,103,76,62,6,223,141,176,26,234,88,18,47,89,0,8,120,131,20,143,70,102,240,185,211,32,220,244,252,232,20,12,93,46,161,243,221,108,54,102,28,119,131,45,55,59,25,215,79,40,154,206,163,119,166,40,208,190,131,19,137,100,30,53,14,45,53,208,40,186,112,116,121,53,133,253,209,108,111,36,61,12,47,202,49,242,65,248,53,184,247,82,97,74,135,179,166,26,227,30,132,95,131,123,107,121,161,72,197,180,213,162,180,70,147,47,71,240,47,101,147,121,143,250,227,15,70,10,215,180,214,25,160,170,125,11,37,215,25,241,251,95,126,33,34,83,110,97,236,198,128,54,190,236,190,132,220,88,160,213,254,37,64,139,62,158,30,57,69,231,72,244,224,206,55,48,248,152,206,63,28,255,109,220,250,47,50,127,117,244,11,212,89,255,171,134,125,31,61,12,82,236,39,18,51,30,69,28,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e"));
		}

		#endregion

	}

	#endregion

}

