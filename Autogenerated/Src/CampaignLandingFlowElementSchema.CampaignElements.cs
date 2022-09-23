﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignLandingFlowElementSchema

	/// <exclude/>
	public class CampaignLandingFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignLandingFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignLandingFlowElementSchema(CampaignLandingFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b28fe371-60dc-4a3a-8c22-fb58a012ed20");
			Name = "CampaignLandingFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,79,27,49,16,61,7,137,255,48,10,151,141,84,109,238,64,130,66,26,104,164,82,81,65,213,99,229,172,103,19,75,94,123,241,71,32,69,252,247,142,189,31,236,134,144,83,47,43,237,120,222,155,55,243,198,86,172,64,91,178,12,225,17,141,97,86,231,46,157,107,149,139,181,55,204,9,173,78,79,94,79,79,6,222,10,181,134,135,157,117,88,92,180,255,93,136,193,116,206,138,146,137,181,250,52,225,235,53,29,209,225,153,193,53,81,195,92,50,107,207,161,193,125,103,138,19,234,70,234,231,133,196,2,149,139,217,227,241,24,46,173,47,10,102,118,211,250,127,241,130,153,119,108,37,17,100,133,130,146,173,17,176,194,129,219,48,7,185,144,14,141,5,230,185,64,69,45,114,143,224,116,139,160,68,225,4,218,180,41,50,238,84,41,253,74,138,12,178,32,241,136,66,120,151,223,211,61,120,141,218,219,86,239,141,46,209,132,106,231,112,31,169,171,243,253,230,98,224,113,131,224,149,120,34,185,130,7,149,185,64,3,58,7,6,153,55,38,148,125,198,21,228,218,20,105,75,210,21,223,168,191,245,130,67,45,122,201,225,21,214,232,46,192,134,207,219,145,250,36,118,75,133,45,144,2,179,131,66,115,148,161,26,141,21,193,150,152,5,65,188,153,227,103,18,140,216,50,135,77,121,90,42,199,50,247,51,48,214,252,6,254,60,117,127,47,58,202,143,161,250,127,97,61,7,3,106,12,38,211,61,66,184,186,130,100,47,52,1,133,207,199,232,147,95,22,13,29,40,204,194,254,143,70,81,214,192,30,44,48,129,45,147,30,99,74,61,209,51,84,188,50,189,191,1,119,232,54,154,7,251,141,118,196,141,220,30,177,32,42,19,202,146,225,214,233,2,164,94,211,84,130,7,151,22,17,50,131,249,100,56,11,139,157,97,148,63,28,79,65,40,218,103,38,197,223,120,115,63,241,37,70,12,58,111,148,157,46,27,4,217,217,33,110,25,233,182,120,139,192,72,71,189,229,237,109,74,47,199,13,75,101,119,221,21,232,45,221,122,154,78,229,19,220,162,155,213,144,24,72,70,181,101,91,102,104,21,37,129,238,226,130,77,250,198,166,4,124,120,63,78,218,53,174,13,9,240,172,242,175,74,35,130,14,93,58,239,158,125,128,44,249,92,75,95,40,2,245,72,210,42,108,211,27,161,248,245,110,38,5,179,201,1,218,6,255,131,222,207,90,144,200,33,233,115,125,99,150,210,185,136,123,84,119,61,232,167,204,20,79,246,36,141,210,165,93,60,121,38,147,230,101,185,103,244,114,100,162,100,202,61,134,55,239,11,12,91,25,195,186,250,27,189,125,228,212,193,34,191,55,104,240,63,149,105,7,89,190,103,219,214,128,21,179,152,126,116,188,194,126,68,196,246,71,233,226,69,88,103,251,195,171,49,213,138,29,40,118,228,202,85,209,126,144,98,255,0,45,214,73,32,235,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b28fe371-60dc-4a3a-8c22-fb58a012ed20"));
		}

		#endregion

	}

	#endregion

}

