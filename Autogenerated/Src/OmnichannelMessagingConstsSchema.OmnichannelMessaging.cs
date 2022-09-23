﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelMessagingConstsSchema

	/// <exclude/>
	public class OmnichannelMessagingConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelMessagingConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelMessagingConstsSchema(OmnichannelMessagingConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e86ae68-80ed-4867-b9da-72eed6375810");
			Name = "OmnichannelMessagingConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,85,203,110,219,48,16,60,55,64,254,65,240,169,61,48,16,41,82,148,16,244,64,82,82,144,22,105,218,216,64,143,1,45,209,142,16,89,18,36,202,69,16,248,223,187,242,35,177,13,59,113,138,222,244,216,157,225,236,14,119,75,61,51,109,173,83,227,140,76,211,232,182,154,216,11,85,149,147,124,218,53,218,230,85,121,113,59,43,243,244,65,151,165,41,46,110,76,219,234,105,94,78,207,207,158,207,207,62,117,45,60,58,195,167,214,154,217,229,249,25,124,169,187,113,145,167,78,107,33,55,117,210,66,183,173,179,5,240,146,15,20,173,109,33,225,121,153,182,151,215,24,157,85,101,241,228,92,117,121,230,168,106,86,23,198,154,76,61,104,59,132,136,174,117,190,58,165,249,179,252,253,121,32,176,116,113,64,37,114,5,163,136,10,202,145,20,110,128,4,227,156,96,151,69,158,36,131,47,151,239,209,252,214,185,133,147,37,85,243,179,169,82,56,104,175,109,155,135,135,82,169,36,17,40,80,129,68,52,240,61,36,61,238,35,225,135,17,33,148,226,128,200,19,120,174,75,192,159,54,64,112,68,79,128,185,199,101,20,33,223,85,28,209,56,1,61,146,51,196,136,98,94,196,148,23,40,124,2,143,172,236,171,144,35,84,210,101,137,76,56,65,126,24,71,136,98,1,84,49,87,72,36,94,172,176,39,221,64,241,93,170,180,111,28,16,54,125,117,126,117,166,51,183,181,1,167,84,77,171,116,250,96,190,155,39,96,24,108,245,124,55,104,112,20,44,50,19,221,21,118,39,252,174,234,250,158,220,117,133,233,81,161,55,241,220,52,79,85,105,142,227,28,3,216,74,254,31,88,73,99,54,56,253,227,199,49,78,170,215,118,252,113,138,190,187,203,180,13,228,141,110,31,123,216,151,31,247,207,238,98,112,192,50,235,27,186,102,235,29,98,156,254,102,31,142,19,169,205,231,155,128,195,39,169,178,101,85,86,145,43,198,119,174,67,182,123,153,73,72,72,28,99,4,151,13,46,51,35,20,133,60,20,40,242,227,192,165,137,194,9,243,215,142,220,59,193,184,170,138,23,37,98,174,243,66,143,151,182,177,77,103,86,9,139,163,202,174,75,125,178,182,77,236,63,168,243,48,85,42,198,12,133,1,76,41,26,73,24,33,161,167,80,132,99,63,22,152,51,73,188,15,170,155,232,162,221,150,183,56,214,228,33,88,35,3,31,53,111,52,120,67,48,202,103,6,156,247,173,26,191,85,16,248,125,213,84,93,189,49,112,239,182,61,132,193,33,45,175,233,63,96,251,140,234,226,16,192,125,255,242,106,219,195,16,107,150,161,177,118,185,84,86,13,218,135,18,105,106,106,219,127,121,235,84,121,105,251,25,180,39,224,186,188,201,203,206,154,126,110,178,221,50,191,55,128,71,166,48,211,70,207,96,10,207,243,12,234,190,237,4,159,50,204,93,61,70,169,207,53,162,89,154,162,48,51,19,148,186,134,17,207,31,103,19,227,158,48,228,19,216,220,96,141,199,131,28,204,165,33,86,62,216,11,54,19,162,50,240,97,97,5,10,133,33,241,73,132,177,96,66,157,178,24,161,112,173,174,235,131,28,216,11,131,72,113,240,49,37,1,44,43,130,193,209,92,32,133,165,244,37,149,202,39,235,101,5,21,91,252,5,12,109,25,42,110,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e86ae68-80ed-4867-b9da-72eed6375810"));
		}

		#endregion

	}

	#endregion

}

