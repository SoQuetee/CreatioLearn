﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationInfoServiceSchema

	/// <exclude/>
	public class NotificationInfoServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationInfoServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationInfoServiceSchema(NotificationInfoServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a6f8b77-e1cf-41ad-8745-4b6205a383e6");
			Name = "NotificationInfoService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,86,75,111,227,54,16,62,123,129,253,15,172,246,34,3,6,221,246,82,32,126,0,94,111,54,117,129,196,105,188,197,30,140,30,104,105,228,176,149,72,149,164,210,85,183,249,239,29,62,100,203,182,236,100,143,189,72,226,112,102,248,205,204,55,67,9,86,128,46,89,2,228,19,40,197,180,204,12,157,75,145,241,109,165,152,225,82,188,125,243,245,237,155,94,165,185,216,146,85,173,13,20,163,163,53,234,231,57,36,86,89,211,27,16,160,120,114,162,243,80,9,195,11,160,43,220,101,57,255,199,249,62,209,194,221,39,158,192,173,76,33,191,184,73,103,120,222,211,203,78,232,103,216,156,40,160,12,149,180,70,227,149,97,6,246,10,237,28,168,179,114,250,145,37,70,42,14,186,75,195,122,159,203,162,112,200,112,255,157,130,45,158,68,230,57,211,250,138,220,73,195,51,158,56,232,11,145,201,128,214,169,14,135,67,50,214,85,81,48,85,79,195,218,153,17,153,17,243,8,36,101,134,17,237,45,72,38,21,17,45,111,132,163,59,85,184,111,218,120,27,182,220,173,195,89,88,95,163,48,132,223,173,108,166,203,59,48,8,184,68,195,13,207,185,169,31,224,175,138,43,40,64,24,29,183,23,54,165,100,66,94,48,177,90,52,8,210,190,61,164,172,54,57,79,72,226,66,57,147,0,114,69,222,51,13,97,53,32,139,7,96,233,82,228,117,187,82,232,203,178,241,82,78,231,18,153,6,74,7,71,15,200,110,228,165,207,239,121,32,103,172,16,212,65,51,156,56,237,121,60,59,64,247,74,150,160,12,82,227,138,220,187,195,252,193,189,245,7,44,221,45,20,27,80,241,29,246,28,166,49,234,2,16,185,132,237,144,46,62,112,215,88,88,193,177,54,10,153,54,192,50,155,105,39,120,242,149,108,193,140,144,32,248,120,14,7,191,3,145,122,112,118,25,164,109,97,59,159,183,96,30,101,122,132,253,152,149,78,224,20,244,227,69,2,158,50,208,75,74,166,88,65,4,102,97,18,109,149,172,74,155,144,104,122,99,63,157,120,60,116,42,123,11,5,166,82,66,79,199,195,230,203,110,173,151,152,235,144,129,61,163,123,107,236,192,133,120,146,127,66,236,227,177,185,190,95,174,62,69,3,242,94,166,245,202,212,185,205,63,170,221,34,183,216,22,118,82,250,89,177,178,132,116,224,82,103,57,12,218,124,116,49,29,24,120,17,253,69,75,49,32,13,27,46,235,249,186,174,151,27,45,115,48,16,71,191,33,189,126,162,63,252,72,191,39,255,134,196,19,174,73,10,165,2,204,39,164,148,88,149,27,219,105,161,190,92,224,252,98,105,224,72,160,200,37,130,54,101,58,238,185,216,115,137,236,178,143,168,69,149,231,125,226,233,220,69,59,185,249,3,135,252,148,184,210,128,195,227,141,70,206,228,137,41,162,221,124,69,212,10,65,9,127,37,160,210,161,128,206,202,178,181,90,117,216,236,61,170,38,16,60,10,254,190,24,107,220,247,102,60,35,241,119,30,52,93,232,59,4,184,84,215,69,105,234,120,23,109,191,137,179,119,24,12,158,112,62,240,198,127,203,134,206,210,52,142,76,93,2,82,43,218,212,142,193,209,37,189,251,70,134,6,123,56,222,224,217,61,141,170,27,112,199,85,195,59,20,47,87,162,252,107,226,167,159,191,139,106,138,84,75,0,201,50,238,182,154,198,222,103,207,162,144,89,220,173,213,167,51,173,113,72,229,245,175,21,222,210,25,135,212,2,28,4,219,80,2,76,76,101,15,157,169,109,101,39,126,28,85,7,229,195,216,186,152,208,127,209,205,62,99,232,98,191,232,55,25,245,145,219,127,137,248,32,103,24,70,242,72,226,235,47,9,148,142,115,240,101,87,225,134,65,120,227,155,107,165,164,114,252,71,133,157,3,247,246,115,101,199,183,81,107,88,254,15,199,76,24,13,175,185,225,90,243,37,110,146,214,209,121,175,112,213,212,196,90,39,149,82,88,82,155,48,204,215,233,12,152,251,125,43,165,65,105,145,122,243,69,199,81,129,228,36,11,239,67,238,251,66,83,75,254,11,198,211,248,245,244,61,34,110,255,28,178,159,153,72,115,236,197,199,240,254,6,92,193,244,2,170,16,44,194,9,95,13,142,214,136,56,251,127,144,52,119,198,132,132,174,11,24,45,156,174,98,198,135,37,27,28,84,220,13,54,7,146,206,240,150,24,29,181,86,231,207,200,100,135,225,155,91,117,191,59,193,253,182,249,153,54,237,245,142,255,106,66,243,182,69,207,255,1,30,235,239,231,236,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a6f8b77-e1cf-41ad-8745-4b6205a383e6"));
		}

		#endregion

	}

	#endregion

}
