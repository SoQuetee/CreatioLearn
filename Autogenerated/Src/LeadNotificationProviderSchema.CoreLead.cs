﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadNotificationProviderSchema

	/// <exclude/>
	public class LeadNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadNotificationProviderSchema(LeadNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("331bec2a-e8d3-4fd0-a099-f1ff7e7a7355");
			Name = "LeadNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d421cd45-8045-4291-a77e-0a493fa9465d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,221,111,219,54,16,127,86,129,254,15,156,10,20,50,22,200,235,107,156,26,112,155,52,240,150,52,65,236,108,15,109,81,48,210,57,225,38,75,30,73,101,240,138,254,239,59,126,201,164,44,201,30,48,236,37,49,201,251,221,247,29,143,42,233,26,196,134,102,64,150,192,57,21,213,74,166,239,171,114,197,30,107,78,37,171,202,151,47,190,189,124,17,213,130,149,143,1,9,135,244,252,221,164,57,90,108,133,132,53,238,23,5,100,10,39,210,75,40,129,179,108,210,3,111,99,113,141,59,175,56,60,34,154,188,47,168,16,167,228,10,104,254,177,146,108,197,50,173,205,45,175,158,89,14,92,211,142,199,99,114,38,234,245,154,242,237,212,174,21,128,148,30,130,108,44,36,117,136,177,7,217,212,15,5,203,72,166,164,245,10,35,167,228,29,21,208,117,116,66,230,221,234,69,202,107,141,53,31,24,20,57,154,115,203,217,51,149,160,181,143,54,102,65,50,116,150,36,66,114,229,139,203,187,155,251,219,175,31,103,215,23,228,45,137,125,222,241,164,23,228,200,149,1,177,241,99,244,10,202,220,72,183,107,231,88,5,228,117,38,43,174,20,210,246,91,125,140,47,250,188,144,220,11,224,136,46,77,124,73,29,44,71,138,67,116,74,30,208,81,73,235,136,104,95,124,63,78,202,57,211,32,140,207,153,177,238,132,84,15,191,35,167,41,217,80,142,217,42,129,139,64,154,183,29,72,234,243,0,138,218,0,151,12,90,246,183,211,73,111,92,242,170,222,144,18,5,164,13,141,159,64,206,30,23,62,77,174,181,136,30,65,218,95,17,7,89,243,210,11,174,142,165,82,180,209,182,83,122,147,129,71,43,240,17,9,123,229,119,75,238,243,211,53,200,167,202,100,109,37,49,0,144,187,188,181,75,82,61,99,69,163,126,228,185,98,57,153,229,57,150,127,189,46,69,178,0,213,5,136,208,255,108,84,34,179,50,10,165,134,50,137,239,96,205,202,28,53,143,79,72,60,207,227,81,58,19,137,254,49,68,104,22,75,182,6,11,240,55,134,128,152,149,146,102,178,17,212,28,122,7,67,248,115,16,25,103,27,93,143,134,67,176,211,130,234,122,244,237,82,27,29,34,28,157,10,158,165,92,50,89,236,219,130,157,114,145,61,193,154,182,168,47,74,201,228,214,28,153,237,22,208,47,53,177,0,41,209,30,161,152,32,199,249,154,62,194,206,245,110,53,241,139,182,39,228,63,87,172,92,210,135,2,142,9,249,21,172,228,77,141,117,170,80,218,150,89,142,174,189,47,153,68,217,55,67,161,154,139,139,63,107,90,180,64,33,145,149,50,199,182,99,37,104,183,118,112,94,212,186,161,132,156,253,88,245,42,108,157,223,197,115,43,252,32,236,105,189,11,219,125,191,132,238,40,89,226,232,95,10,29,10,185,143,186,63,54,216,186,190,81,182,102,216,29,111,213,143,211,144,206,18,76,188,124,72,103,101,222,178,196,87,118,185,221,128,31,80,107,144,73,229,244,214,117,251,196,175,93,33,69,218,230,209,156,207,243,209,33,3,131,91,124,94,174,42,114,9,242,14,178,138,231,237,147,196,232,213,113,79,153,255,83,146,55,71,70,231,95,105,81,131,187,156,162,203,26,125,201,76,149,77,154,157,116,201,183,104,26,94,103,221,232,79,77,97,126,193,11,177,150,142,131,117,172,109,240,37,252,69,246,244,117,130,35,221,83,112,78,232,147,96,122,206,151,19,67,253,174,202,183,3,196,126,223,115,16,171,34,162,172,118,118,223,164,155,62,80,26,42,123,123,205,180,45,242,203,40,192,238,90,219,128,74,123,93,208,233,117,13,66,56,205,14,42,224,11,247,219,205,49,88,159,222,231,163,199,2,171,189,254,109,46,97,63,41,15,223,194,135,70,149,217,102,3,58,223,245,180,64,170,21,14,137,250,58,38,171,138,147,140,3,85,45,192,243,158,34,145,79,88,221,90,251,158,241,66,239,232,17,75,179,125,27,91,166,241,116,134,42,0,40,198,171,183,241,21,19,242,108,57,69,44,192,52,30,79,157,236,244,108,172,193,254,168,18,182,21,108,77,110,108,208,76,92,21,89,6,46,123,29,63,236,46,102,62,152,236,111,123,183,65,199,169,63,35,116,28,219,91,225,61,181,119,121,63,73,15,255,96,18,240,67,219,25,173,59,93,177,66,7,128,235,70,131,255,68,93,200,99,227,208,157,131,173,176,244,119,169,216,121,216,132,63,136,147,150,101,90,138,8,249,45,36,199,134,61,69,106,119,220,21,87,55,12,187,22,122,167,13,235,26,237,143,107,153,150,159,60,208,191,130,150,52,241,145,44,31,128,169,66,13,168,121,147,40,3,40,47,155,66,244,195,112,223,108,165,89,136,21,46,193,14,51,216,105,253,76,57,249,3,148,76,52,243,71,18,127,141,241,239,206,134,29,209,166,218,224,227,196,180,177,91,245,251,156,74,186,127,61,104,55,135,151,128,178,105,191,151,55,218,246,183,106,51,86,121,221,78,43,130,207,67,70,11,246,55,220,90,141,180,102,233,194,109,39,225,173,102,156,147,126,168,248,154,202,36,254,28,127,251,233,251,231,248,148,124,123,243,29,103,7,52,253,164,197,241,248,234,243,83,91,207,38,177,106,138,160,13,73,199,211,129,82,236,46,15,195,3,219,31,195,145,132,150,25,28,168,20,59,69,97,165,104,231,225,155,212,236,52,81,177,4,16,156,170,24,214,69,97,156,196,86,196,123,2,147,31,204,25,121,253,218,123,47,167,186,51,162,78,191,192,54,137,69,120,75,141,134,104,243,26,48,75,176,99,54,105,162,231,151,144,5,234,147,168,237,209,142,203,167,182,20,155,172,145,226,166,75,43,87,159,49,16,232,54,2,176,19,235,80,251,246,99,14,91,87,221,119,124,136,24,122,97,14,18,28,241,178,60,242,105,185,247,52,233,193,249,175,17,133,243,214,131,184,163,158,162,195,50,155,187,206,17,159,227,5,204,74,149,126,110,231,3,175,214,62,184,57,248,95,94,115,255,229,115,46,74,127,123,2,14,97,68,17,112,133,195,225,13,239,121,99,168,36,77,151,21,42,136,21,43,104,161,80,201,104,212,176,212,47,153,185,184,51,170,245,62,85,86,180,16,208,66,181,141,159,15,114,8,171,9,171,145,10,155,255,222,7,29,215,48,195,106,57,186,25,250,159,77,135,166,16,215,208,252,151,70,119,159,155,95,148,245,26,184,250,66,112,182,247,196,154,170,182,23,188,82,155,174,231,190,151,181,206,21,74,36,163,190,177,217,238,249,91,184,243,15,81,103,118,241,226,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("331bec2a-e8d3-4fd0-a099-f1ff7e7a7355"));
		}

		#endregion

	}

	#endregion

}
