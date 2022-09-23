﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignTransitionProcessElementSchema

	/// <exclude/>
	public class CampaignTransitionProcessElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignTransitionProcessElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignTransitionProcessElementSchema(CampaignTransitionProcessElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("895b9ca3-4911-4c86-a68d-8acbe9d91a96");
			Name = "CampaignTransitionProcessElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3114fdd2-1796-4282-98ef-60854140c213");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,81,111,219,54,16,126,118,129,254,135,155,246,48,9,8,228,247,58,9,144,186,89,103,96,237,186,56,65,159,105,234,100,19,149,40,149,164,226,122,65,255,251,142,164,40,75,142,108,55,197,246,98,88,20,239,187,187,143,119,223,81,146,149,168,107,198,17,238,81,41,166,171,220,164,243,74,230,98,221,40,102,68,37,95,191,122,122,253,106,210,104,33,215,176,220,105,131,229,172,123,238,155,40,76,231,172,172,153,88,203,163,27,222,189,165,87,244,242,87,133,107,130,134,121,193,180,126,3,193,238,94,49,169,133,117,250,73,85,28,181,190,45,176,68,105,156,205,116,58,133,75,221,148,37,83,187,235,246,249,45,211,8,248,13,121,99,216,170,64,48,29,0,212,30,1,208,67,164,1,97,218,131,168,155,85,33,56,112,27,197,217,32,224,141,115,23,182,253,94,84,219,46,188,201,147,11,177,203,139,44,107,84,70,32,37,71,255,13,114,131,153,223,114,152,134,91,216,251,132,166,206,152,65,248,218,160,218,165,157,65,63,234,73,29,16,225,111,187,171,103,237,159,159,96,141,102,6,218,254,124,111,3,67,153,249,216,78,4,234,216,56,17,229,131,20,20,22,136,140,114,22,185,64,5,85,14,102,131,160,171,70,81,1,245,168,30,139,218,147,253,190,17,25,44,157,193,130,106,105,145,141,133,251,50,247,134,41,66,120,129,251,123,103,240,66,247,212,20,153,63,34,179,97,6,4,61,113,58,41,13,91,193,55,254,188,128,239,247,84,192,234,186,216,65,94,41,88,26,172,231,85,89,23,104,15,173,246,156,31,61,93,31,232,192,102,239,251,200,242,11,142,252,3,154,77,149,253,96,97,222,80,14,84,28,7,25,12,210,52,63,89,187,143,66,153,134,21,240,88,209,137,88,63,187,241,220,226,4,172,0,77,38,122,43,12,49,29,143,111,11,187,38,220,106,194,248,158,244,129,250,55,172,254,37,139,221,27,111,50,57,232,160,244,70,102,113,52,192,136,146,116,161,111,191,82,192,241,188,42,154,82,166,159,152,34,233,52,168,98,163,26,76,146,89,139,181,82,200,190,204,126,40,150,133,228,255,125,52,57,43,244,79,132,115,35,59,255,125,147,12,115,214,20,230,127,38,234,187,253,61,213,124,119,104,26,37,53,172,108,6,190,215,108,99,93,106,68,224,10,243,171,104,137,180,44,57,246,116,57,154,94,143,23,161,91,169,109,88,32,41,180,171,200,11,216,29,230,15,139,44,186,62,174,115,173,143,223,244,161,228,93,78,29,220,56,186,215,167,151,160,31,40,218,51,116,229,233,184,246,122,79,125,177,241,204,20,213,154,164,131,240,206,18,67,152,1,100,188,45,31,124,47,191,71,211,7,176,19,208,191,137,157,146,246,137,187,240,226,218,207,54,52,229,35,83,160,80,83,33,193,21,72,220,182,232,49,245,128,162,18,148,228,154,74,234,162,155,193,84,50,70,112,81,51,105,238,237,96,79,124,201,164,75,52,113,20,54,121,253,142,200,234,89,157,245,67,24,216,218,82,253,80,101,150,119,106,185,49,219,119,20,215,189,40,49,125,48,252,99,181,125,110,222,19,144,49,123,217,20,197,5,68,1,38,58,1,48,102,222,118,111,107,243,121,131,10,173,21,51,141,94,156,236,173,192,10,209,169,13,241,166,211,17,50,187,191,134,46,103,1,53,120,155,248,110,62,160,55,188,156,28,119,221,47,130,36,1,166,219,227,245,189,45,114,136,127,89,210,61,138,78,120,145,165,14,67,199,173,174,184,42,74,146,78,188,125,145,184,64,142,213,2,145,219,161,157,34,164,219,20,20,199,137,76,240,240,153,122,230,15,65,52,197,182,28,239,170,237,159,21,255,98,23,226,176,221,183,71,91,182,179,115,2,53,39,49,179,151,1,175,77,238,134,64,83,210,48,17,68,203,183,166,21,173,253,192,60,50,35,7,45,222,235,100,207,42,53,175,199,47,171,71,114,88,239,233,209,144,171,170,116,90,194,27,165,236,157,149,174,235,181,27,210,180,38,241,155,129,74,226,217,214,119,19,217,39,228,4,166,155,192,135,23,205,171,19,242,208,191,226,93,12,110,92,45,191,39,71,254,121,190,3,185,188,209,134,146,222,211,219,35,236,166,201,4,114,159,132,165,77,72,130,103,133,248,135,157,96,127,207,7,241,171,20,233,116,123,205,166,92,29,160,228,7,180,12,168,26,20,207,1,97,103,179,186,117,159,50,168,187,243,203,137,212,48,6,92,118,154,30,92,112,172,13,229,84,13,245,135,16,235,135,30,181,147,195,34,10,58,20,216,110,236,37,54,236,129,13,123,68,91,54,43,12,223,81,152,29,159,66,31,155,114,229,199,152,110,184,221,156,147,6,238,246,150,131,26,61,90,125,29,219,212,132,176,36,125,42,176,165,35,246,193,14,50,72,224,234,122,184,146,134,221,201,108,244,2,236,121,31,46,210,218,191,43,74,207,78,0,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("895b9ca3-4911-4c86-a68d-8acbe9d91a96"));
		}

		#endregion

	}

	#endregion

}

