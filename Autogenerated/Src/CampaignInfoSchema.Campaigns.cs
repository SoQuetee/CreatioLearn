namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignInfoSchema

	/// <exclude/>
	public class CampaignInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignInfoSchema(CampaignInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42");
			Name = "CampaignInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,205,74,3,49,16,199,207,45,244,29,6,122,239,222,91,241,82,84,122,43,212,62,192,52,153,205,14,238,38,49,147,32,165,248,238,102,179,253,82,68,172,66,8,204,215,127,126,204,140,197,142,196,163,34,120,166,16,80,92,29,103,75,103,107,54,41,96,100,103,39,227,195,100,60,74,194,214,192,102,47,145,186,69,182,243,155,6,50,57,14,203,22,69,230,176,196,206,35,27,187,178,181,155,140,115,188,170,42,184,147,212,117,24,246,247,71,187,228,66,108,48,66,32,31,72,200,70,129,150,77,19,223,168,255,65,29,101,64,34,70,2,206,106,208,57,77,237,236,36,89,93,105,250,180,107,89,129,42,178,159,9,70,135,66,113,198,92,7,231,41,68,166,204,186,46,101,67,252,43,102,113,108,45,191,166,220,93,103,62,174,153,2,184,250,130,214,59,227,126,118,174,190,38,58,33,61,37,214,23,34,13,7,48,20,23,32,253,247,254,231,206,253,80,146,220,208,121,83,10,110,232,255,216,162,25,22,196,86,179,202,59,144,75,123,31,156,201,75,147,97,57,63,99,236,156,107,97,101,215,167,146,127,13,32,54,4,30,3,43,246,104,99,62,24,251,66,250,184,7,16,213,80,135,191,24,202,67,201,223,148,244,237,247,51,153,146,213,195,193,20,123,240,94,59,243,229,103,231,7,103,151,225,59,54,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42"));
		}

		#endregion

	}

	#endregion

}

