﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationsJobSchema

	/// <exclude/>
	public class NotificationsJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationsJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationsJobSchema(NotificationsJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c6e0d65-7ec4-45eb-b1be-36536febb84e");
			Name = "NotificationsJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,201,110,219,48,16,61,59,64,254,97,224,30,34,3,134,140,246,208,2,241,18,184,142,93,184,104,227,52,75,47,65,16,80,210,200,97,64,147,6,73,57,53,210,254,123,71,164,156,208,138,157,246,34,113,121,179,188,55,51,148,108,129,102,201,82,132,43,212,154,25,149,219,120,164,100,206,231,133,102,150,43,121,120,240,116,120,208,40,12,151,115,184,92,27,139,139,110,109,79,120,33,48,45,193,38,254,130,18,53,79,95,48,161,91,141,251,206,227,9,75,173,210,28,205,94,196,101,122,143,89,33,80,239,71,88,31,129,238,223,105,156,83,62,48,18,204,152,99,56,83,150,231,60,117,132,204,87,149,56,76,167,211,129,158,41,22,11,166,215,131,106,239,240,160,114,144,161,5,60,168,36,222,88,116,2,147,155,89,98,148,64,139,81,243,83,252,254,99,252,1,126,87,46,30,185,16,144,32,104,92,168,21,102,192,114,139,26,50,44,193,144,35,179,133,70,56,218,202,107,38,103,18,157,53,101,120,20,55,91,183,20,97,89,36,130,167,144,58,167,117,26,112,12,83,250,141,127,97,90,16,119,130,63,57,102,47,244,9,103,153,180,36,193,185,230,43,102,209,223,47,253,6,210,242,30,140,213,165,154,147,241,240,234,250,98,124,55,154,157,142,161,15,205,253,201,53,187,141,70,21,8,101,230,99,149,251,48,244,132,163,200,246,197,253,172,72,53,38,79,224,142,155,137,23,99,44,89,34,48,235,134,48,141,44,83,82,172,97,58,98,84,125,87,95,184,51,47,101,174,197,175,17,215,69,217,83,101,14,78,196,42,5,47,104,93,202,168,5,101,159,55,26,222,61,241,119,209,98,23,248,198,125,191,225,10,69,60,92,46,69,101,119,219,245,22,117,14,100,236,189,208,52,216,159,76,20,216,219,16,30,68,161,202,109,144,133,16,45,231,230,207,219,132,190,163,189,87,123,245,76,200,253,9,76,107,121,68,215,6,53,41,33,253,112,66,177,181,221,16,230,57,68,59,40,244,125,110,21,104,39,201,109,127,37,217,87,25,132,108,61,207,141,194,55,225,213,109,41,217,206,86,40,117,161,175,70,186,144,123,48,255,45,93,208,6,245,225,119,7,126,144,240,121,222,95,15,188,63,89,50,205,22,32,233,233,236,55,183,69,104,14,74,205,203,185,218,168,210,235,56,244,110,99,183,166,23,65,155,230,224,252,121,13,185,210,192,221,228,166,148,140,155,253,45,63,85,15,175,20,207,54,57,191,93,235,54,76,79,185,91,17,143,158,159,247,54,168,228,129,174,7,240,146,69,216,19,175,106,89,111,31,106,17,26,49,124,110,145,112,164,166,50,87,23,5,97,53,104,255,235,251,135,209,191,243,235,120,162,116,138,212,49,189,221,86,131,200,251,108,216,245,18,85,30,237,70,181,226,161,49,184,72,196,250,71,193,4,1,48,59,35,38,237,202,86,226,99,248,16,12,245,188,88,160,180,81,189,102,237,250,100,252,211,65,80,183,118,40,223,166,197,61,231,152,178,140,90,65,27,239,104,212,234,44,60,162,147,191,127,109,49,111,150,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c6e0d65-7ec4-45eb-b1be-36536febb84e"));
		}

		#endregion

	}

	#endregion

}
