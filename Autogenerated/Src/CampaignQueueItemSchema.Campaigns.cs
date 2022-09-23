﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignQueueItemSchema

	/// <exclude/>
	public class CampaignQueueItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignQueueItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignQueueItemSchema(CampaignQueueItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f1f50858-7bf6-4534-b6c1-bd9ea3b452f0");
			Name = "CampaignQueueItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,79,27,49,16,62,131,196,127,24,133,30,18,41,218,168,226,80,137,71,164,22,80,21,169,64,10,225,84,245,96,214,147,196,106,214,222,218,94,82,154,242,223,59,246,62,178,97,217,176,40,32,181,18,167,100,237,121,124,51,243,121,198,150,44,66,19,179,16,97,132,90,51,163,198,54,56,86,114,44,38,137,102,86,40,185,179,189,216,217,222,74,140,144,19,184,186,51,22,163,131,157,109,90,217,213,56,161,109,56,158,49,99,246,225,152,69,49,19,19,249,53,193,4,7,36,229,133,122,189,30,28,154,36,138,152,190,235,103,223,159,152,65,56,25,93,192,88,105,8,51,53,248,233,244,130,92,165,87,210,137,147,155,153,8,33,116,126,30,115,179,181,240,174,150,128,148,52,86,39,161,85,154,112,13,189,118,42,241,16,141,95,24,72,97,5,155,137,223,104,128,73,16,164,204,36,165,67,141,73,22,17,66,141,227,163,86,197,111,171,215,135,185,176,83,144,56,47,11,14,184,219,201,141,51,201,87,172,104,100,22,249,133,116,50,177,86,49,106,123,23,20,208,202,81,231,97,87,28,183,59,224,10,178,181,53,224,112,4,159,19,193,131,115,156,187,223,118,231,192,111,20,94,104,255,132,254,141,68,132,193,181,13,207,213,220,11,220,191,74,54,106,194,240,43,49,211,44,2,73,84,59,106,133,74,90,22,90,202,83,255,90,10,42,59,8,142,210,138,177,64,237,220,100,251,193,97,207,107,213,24,201,0,56,223,245,150,114,110,17,105,227,21,123,223,46,110,140,154,161,197,118,235,67,240,126,47,216,131,63,112,134,118,170,56,8,3,28,99,141,161,75,97,0,215,196,213,148,121,94,155,84,180,241,196,53,104,243,10,10,52,65,171,243,125,109,209,92,125,160,8,189,11,233,247,74,20,79,215,53,87,167,253,194,84,182,181,98,201,237,175,44,188,241,162,25,47,42,246,68,157,141,186,160,221,193,38,242,40,205,255,125,194,101,139,130,119,60,61,246,193,78,133,105,151,116,214,240,83,240,55,202,188,46,101,170,64,139,225,209,31,77,17,56,125,248,249,98,233,24,119,97,62,69,153,153,129,57,51,46,221,196,20,164,242,74,171,168,178,152,77,216,255,135,149,221,162,73,65,17,122,51,166,118,29,167,51,182,150,155,94,97,166,204,221,93,148,60,189,57,172,94,35,134,69,84,77,46,17,220,85,184,200,50,8,194,177,126,174,251,32,73,109,1,19,180,7,46,143,7,176,238,52,173,37,248,211,158,150,179,99,35,135,51,33,127,16,167,220,210,83,23,23,239,246,139,151,63,245,226,47,234,27,76,56,197,136,53,128,144,58,191,242,226,215,27,39,60,239,3,116,12,172,8,69,204,100,163,236,103,106,195,165,214,139,33,241,29,169,57,132,236,134,208,212,247,6,157,102,45,166,226,104,47,207,103,83,72,103,236,151,136,146,8,232,116,10,229,207,93,6,70,227,12,111,253,136,105,11,9,145,144,137,69,211,89,143,131,48,195,233,175,88,164,111,157,97,106,242,17,36,117,93,34,109,151,77,90,196,37,218,68,75,3,244,52,161,90,142,125,139,112,109,86,42,75,200,25,241,147,251,228,165,61,159,198,68,214,246,241,1,58,55,46,152,133,48,209,154,248,0,145,138,176,150,131,149,25,82,49,214,175,102,211,3,171,201,101,101,64,233,52,170,254,97,47,255,87,74,238,141,82,51,24,152,203,212,150,165,123,102,219,229,251,33,136,14,28,245,151,60,8,62,114,126,150,250,107,87,37,251,143,220,92,55,78,121,133,0,207,202,239,115,83,80,31,238,67,28,245,225,110,78,199,43,171,233,69,239,218,137,121,242,157,75,143,245,38,9,72,77,194,45,155,249,123,198,35,217,80,183,168,53,245,49,106,90,94,116,164,82,157,226,77,155,234,192,187,42,14,154,149,251,176,24,240,251,110,62,203,232,179,152,106,110,181,212,224,220,214,74,191,187,111,213,141,252,108,109,53,161,247,127,1,140,110,51,231,22,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f1f50858-7bf6-4534-b6c1-bd9ea3b452f0"));
		}

		#endregion

	}

	#endregion

}

