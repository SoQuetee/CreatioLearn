﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignSplitGatewayFlowElementSchema

	/// <exclude/>
	public class CampaignSplitGatewayFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignSplitGatewayFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignSplitGatewayFlowElementSchema(CampaignSplitGatewayFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ddec6b2-da37-4115-63da-d425f6b8a3e2");
			Name = "CampaignSplitGatewayFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,75,115,219,54,16,62,43,51,249,15,59,202,161,100,155,129,146,107,109,107,38,146,101,143,38,47,55,82,123,233,244,0,145,43,9,19,18,96,1,80,182,226,241,127,239,2,32,41,80,82,236,94,164,225,98,247,219,247,7,72,94,162,169,120,134,176,68,173,185,81,107,203,166,74,174,197,166,214,220,10,37,95,191,122,124,253,106,80,27,33,55,176,216,27,139,229,197,209,55,233,23,5,102,78,217,176,91,148,168,69,118,162,115,205,45,63,17,126,18,242,223,19,225,114,171,145,231,36,56,156,196,161,149,165,146,231,79,162,160,217,148,151,21,23,27,185,64,189,19,25,158,55,208,200,174,39,63,61,186,211,42,67,99,232,156,52,222,104,220,16,46,76,11,110,204,239,208,193,87,133,176,183,220,226,61,223,223,20,234,126,86,96,137,210,122,147,209,104,4,151,166,46,75,174,247,227,230,123,246,128,89,109,249,170,64,168,184,182,160,214,96,28,4,108,2,6,96,0,96,173,253,40,2,168,234,85,33,50,200,92,8,47,69,0,135,24,123,113,13,30,125,108,93,62,148,100,133,218,10,164,164,238,60,126,56,63,14,222,11,238,184,208,198,197,156,53,208,96,53,151,70,184,138,183,145,195,60,7,46,115,16,246,23,3,248,80,209,92,96,14,228,35,163,67,190,65,103,206,235,92,160,164,145,179,42,32,172,81,179,206,107,156,114,155,243,181,240,227,69,210,203,219,90,228,111,65,72,59,38,169,177,90,172,106,239,255,17,54,104,47,192,184,159,167,103,146,184,41,248,198,57,22,50,23,25,213,13,236,150,91,200,99,40,97,32,171,141,85,165,248,65,177,175,149,134,53,213,208,60,31,226,74,169,2,254,52,56,245,150,47,133,246,6,101,30,90,208,239,199,103,180,91,149,187,102,104,177,163,232,194,105,21,62,96,167,68,14,115,105,168,99,119,52,62,34,19,21,151,214,220,40,189,236,26,145,184,2,69,141,153,83,181,230,51,89,151,168,221,220,249,250,141,253,244,181,230,41,184,13,31,12,118,92,67,182,173,229,119,51,85,53,117,242,10,18,42,115,250,153,219,45,155,162,40,104,71,146,28,51,81,242,130,125,149,8,191,66,18,195,48,111,149,164,48,130,5,95,227,31,53,234,253,132,219,108,187,160,50,166,41,252,6,239,47,142,252,144,139,30,130,31,230,175,210,229,102,146,40,148,52,24,82,39,144,103,91,72,58,4,234,98,3,213,38,225,209,133,47,17,161,75,188,111,234,149,80,107,52,113,132,12,68,149,178,185,180,42,25,78,203,170,217,161,184,99,195,198,97,223,99,20,106,231,183,115,59,8,62,217,95,188,168,209,36,105,35,29,176,5,90,114,211,44,76,212,181,121,62,124,11,196,156,117,41,25,137,137,134,45,234,184,160,233,17,198,50,106,233,57,211,184,229,105,155,192,83,248,19,107,215,75,31,96,176,11,97,178,185,249,162,236,172,172,236,62,73,79,82,9,100,133,201,17,86,224,103,182,40,16,171,228,253,187,230,212,31,62,157,25,215,5,223,97,60,172,183,90,213,149,73,78,54,218,253,254,253,207,24,54,254,188,13,166,215,0,127,228,74,223,215,241,45,143,179,167,198,123,13,246,17,247,23,7,149,120,212,58,21,95,136,70,233,165,205,234,47,85,111,133,78,139,240,63,54,92,89,207,142,207,144,85,211,2,199,71,90,59,118,117,68,20,95,18,103,248,200,75,42,55,22,32,105,52,174,134,153,146,22,31,236,112,188,220,34,81,178,67,116,129,52,98,118,57,242,202,7,91,141,182,214,210,140,191,212,229,10,181,35,236,42,92,133,142,200,227,117,189,28,181,170,161,235,77,62,160,118,116,147,138,28,29,75,123,46,104,39,169,185,82,195,39,209,201,52,132,208,134,18,19,145,70,83,23,110,133,223,133,210,186,9,142,87,148,53,28,69,10,221,28,132,104,26,211,168,35,205,253,238,103,40,95,5,239,68,234,87,208,231,4,54,147,166,214,120,61,57,136,18,207,98,31,233,174,160,183,74,41,40,185,195,154,28,144,216,194,82,89,252,160,240,96,54,55,170,240,15,145,79,184,195,130,125,163,133,113,47,23,97,29,66,51,109,86,239,187,141,115,145,181,183,162,119,73,193,221,162,253,16,139,186,61,60,55,204,164,76,195,110,38,251,160,218,195,74,217,82,125,160,167,205,17,66,88,162,99,10,238,106,140,147,125,183,170,135,178,119,8,63,89,235,102,51,91,173,174,139,43,110,144,197,163,208,182,188,213,140,170,25,42,21,151,51,194,59,233,240,224,137,158,35,214,81,196,236,33,195,202,7,217,213,53,66,253,70,143,212,21,207,190,159,197,181,91,173,238,123,52,247,204,42,7,105,95,72,178,255,0,68,83,125,221,74,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ddec6b2-da37-4115-63da-d425f6b8a3e2"));
		}

		#endregion

	}

	#endregion

}

