namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketingAppEventListenerSchema

	/// <exclude/>
	public class MarketingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketingAppEventListenerSchema(MarketingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab8c1b0d-1351-4fe6-8ded-74eb63abcdfb");
			Name = "MarketingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,193,106,194,64,16,61,43,248,15,131,189,88,40,201,93,99,160,134,22,132,74,139,10,158,215,56,137,139,102,55,221,153,72,173,244,223,59,217,68,81,105,143,251,230,205,155,55,111,214,168,2,169,84,41,194,18,157,83,100,51,14,18,107,50,157,87,78,177,182,166,215,61,245,186,157,138,180,201,111,40,14,131,87,149,178,117,26,105,244,7,99,133,107,97,21,133,53,82,149,250,131,195,92,228,32,217,43,162,33,204,148,219,33,75,203,115,89,190,28,208,240,155,38,70,131,206,147,195,48,132,136,170,162,80,238,24,183,239,57,150,14,73,152,4,5,242,214,110,8,216,130,54,154,181,218,235,111,4,217,98,167,114,12,206,253,225,149,64,89,173,247,58,133,180,30,254,255,108,24,194,61,52,81,132,210,127,242,182,46,75,204,26,3,67,248,240,186,77,241,222,180,7,38,218,136,209,214,26,73,29,17,82,135,217,184,239,131,104,34,60,246,195,24,52,99,65,193,69,40,188,87,138,74,229,84,1,70,14,54,238,167,214,48,126,113,63,158,26,98,101,228,124,54,187,22,63,175,145,180,188,48,14,162,208,11,120,189,54,14,123,144,115,233,13,194,193,234,13,188,27,233,90,176,114,60,184,107,135,118,220,35,212,127,161,211,89,75,40,193,21,253,92,30,249,234,245,98,65,189,127,52,173,117,4,160,165,93,28,77,58,199,207,10,137,159,224,12,175,52,111,19,49,180,187,37,196,131,70,241,167,13,31,205,166,201,223,191,27,244,22,20,236,23,152,237,247,127,209,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab8c1b0d-1351-4fe6-8ded-74eb63abcdfb"));
		}

		#endregion

	}

	#endregion

}

