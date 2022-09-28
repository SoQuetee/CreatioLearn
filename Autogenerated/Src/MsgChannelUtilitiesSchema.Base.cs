﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MsgChannelUtilitiesSchema

	/// <exclude/>
	public class MsgChannelUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MsgChannelUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MsgChannelUtilitiesSchema(MsgChannelUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75f1e6e1-f848-4035-bda7-522abc9b3a5e");
			Name = "MsgChannelUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,223,111,211,48,16,126,238,164,253,15,71,64,34,149,166,136,61,32,164,85,19,98,133,65,36,54,38,202,196,3,66,200,77,174,153,53,199,174,108,103,163,42,253,223,57,199,78,154,116,165,43,18,226,37,137,237,251,241,221,119,231,47,146,149,104,230,44,67,248,130,90,51,163,102,54,25,43,57,227,69,165,153,229,74,30,30,44,15,15,14,15,6,149,225,178,128,201,194,88,44,71,237,122,172,52,174,87,23,104,12,43,232,139,66,148,165,146,235,147,66,168,41,19,39,39,126,63,249,168,10,103,54,170,35,63,213,88,80,34,24,11,102,204,9,92,152,98,124,195,164,68,113,109,185,224,150,163,169,205,230,213,84,240,12,140,37,88,25,100,206,120,187,237,192,3,94,199,85,146,156,164,165,216,87,117,12,127,28,226,101,238,148,162,106,7,243,74,171,140,106,120,39,9,29,78,80,230,168,47,137,32,56,133,168,119,20,121,228,131,111,159,166,70,9,180,24,71,175,146,227,151,201,49,252,106,211,1,55,32,21,189,36,84,6,129,201,28,238,185,16,48,69,208,88,170,59,204,235,163,121,166,74,151,90,163,64,102,208,68,195,239,123,161,59,99,217,237,7,110,172,210,139,9,81,178,11,237,166,105,131,254,41,185,120,142,250,132,157,115,20,185,99,75,243,59,50,15,116,249,69,195,191,70,150,43,41,22,144,82,47,225,135,160,199,41,208,231,5,147,172,64,157,188,71,235,154,140,58,142,190,226,116,162,178,91,180,209,240,145,196,23,104,111,212,99,153,167,74,9,24,223,96,118,59,102,242,74,25,235,167,14,227,192,18,145,93,211,112,212,208,102,90,102,134,176,116,1,7,124,6,241,147,245,236,52,152,83,243,185,146,146,92,26,187,129,171,43,249,202,180,60,87,186,100,54,142,40,229,115,11,115,202,10,165,79,11,86,193,242,197,10,102,90,149,176,60,94,193,253,13,23,8,15,162,55,227,160,125,138,232,200,103,24,52,112,225,245,107,136,222,8,17,29,117,1,143,188,149,70,91,105,9,51,38,12,250,173,85,253,12,251,86,87,126,123,181,149,177,148,192,192,152,58,102,113,131,43,159,169,101,170,52,109,233,181,143,225,229,92,52,62,212,95,137,247,48,233,238,197,45,83,105,78,231,239,43,158,39,151,120,239,222,241,48,84,120,166,242,5,157,81,108,15,220,227,239,133,78,62,208,52,81,3,252,12,147,177,199,53,234,214,216,115,216,81,236,157,226,57,116,198,34,149,22,181,100,34,78,215,45,129,204,191,55,70,100,111,30,54,184,12,206,206,203,67,174,199,230,45,78,171,34,126,22,53,57,151,33,105,226,26,187,242,51,52,83,26,150,222,127,229,252,79,96,73,207,85,20,226,52,30,189,41,239,98,25,254,5,17,95,20,77,87,203,198,127,40,220,229,118,183,131,145,232,61,82,232,150,187,88,139,104,134,117,237,53,244,29,149,63,174,39,15,117,255,15,44,197,215,116,31,73,194,37,102,238,239,87,171,201,122,185,69,83,214,220,5,154,241,167,237,233,204,54,169,234,71,77,198,149,214,40,173,75,157,132,152,107,9,104,175,152,191,8,221,235,255,80,100,178,254,242,244,161,14,181,204,142,218,54,55,19,90,163,10,223,167,27,161,146,115,46,243,148,254,253,103,139,235,52,223,85,64,154,135,166,186,234,187,33,159,144,128,84,66,180,245,108,187,164,29,251,163,30,201,93,118,3,5,128,164,134,61,165,78,229,76,133,201,78,90,197,14,217,157,246,206,84,69,127,97,55,139,46,79,79,182,123,122,188,119,107,58,205,88,237,51,93,97,144,255,201,12,57,46,247,29,148,63,203,192,46,138,183,220,174,176,215,221,162,157,223,156,175,242,209,69,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75f1e6e1-f848-4035-bda7-522abc9b3a5e"));
		}

		#endregion

	}

	#endregion

}
