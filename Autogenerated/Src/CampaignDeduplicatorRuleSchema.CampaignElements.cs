namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignDeduplicatorRuleSchema

	/// <exclude/>
	public class CampaignDeduplicatorRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignDeduplicatorRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignDeduplicatorRuleSchema(CampaignDeduplicatorRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("078983fb-8c59-4207-a217-01b1057fd97c");
			Name = "CampaignDeduplicatorRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,106,195,48,16,60,39,144,127,24,200,221,190,55,165,23,183,148,94,74,104,154,15,80,172,181,45,176,36,87,187,58,24,211,127,175,172,60,72,75,9,185,136,213,236,106,102,118,87,78,89,226,65,213,132,79,10,65,177,111,164,168,188,107,76,27,131,18,227,221,106,57,173,150,139,200,198,181,216,141,44,100,55,171,101,66,214,129,218,148,70,213,43,230,7,84,202,14,202,180,238,153,116,28,122,83,43,241,225,35,246,148,107,203,178,196,35,71,107,85,24,159,78,247,57,9,173,68,193,122,77,61,164,83,2,195,136,76,26,135,17,245,137,16,250,138,17,212,147,37,39,92,156,89,203,43,218,33,30,82,29,234,217,209,13,67,139,41,155,186,116,176,13,126,160,32,134,82,27,219,76,113,204,255,117,157,129,189,51,95,145,96,116,114,97,26,67,1,190,193,28,203,8,174,59,178,170,184,188,189,246,118,54,247,26,141,198,75,174,223,229,242,253,155,198,132,150,100,3,158,143,239,27,226,91,37,29,196,163,246,125,180,110,142,26,227,52,206,13,18,167,193,221,150,103,9,243,34,171,76,144,233,238,213,126,79,31,5,77,90,129,116,132,144,6,121,151,80,126,245,143,196,154,156,62,142,63,223,143,232,111,48,97,63,171,37,218,42,157,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("078983fb-8c59-4207-a217-01b1057fd97c"));
		}

		#endregion

	}

	#endregion

}

