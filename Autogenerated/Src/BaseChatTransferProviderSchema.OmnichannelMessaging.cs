﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseChatTransferProviderSchema

	/// <exclude/>
	public class BaseChatTransferProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseChatTransferProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseChatTransferProviderSchema(BaseChatTransferProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8dae1b07-57f7-43d8-bb4a-45b32e70e944");
			Name = "BaseChatTransferProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,91,111,219,54,20,126,118,129,254,7,66,123,136,12,184,114,251,52,44,137,83,172,73,214,26,168,155,172,113,48,96,47,1,35,29,59,4,36,82,35,41,167,94,145,255,190,195,155,44,209,86,210,2,11,28,71,60,55,125,231,198,115,194,105,5,170,166,57,144,37,72,73,149,88,233,236,92,240,21,91,55,146,106,38,248,235,87,223,95,191,26,53,138,241,53,185,170,56,203,31,40,231,80,46,64,41,186,70,226,73,203,189,217,42,13,213,238,60,96,48,235,88,201,14,152,233,170,73,216,209,157,40,44,183,53,144,89,23,202,181,20,27,86,128,84,217,133,168,40,227,217,37,215,76,51,80,89,71,101,103,103,93,138,123,90,30,31,159,139,170,66,52,159,197,250,185,247,103,23,31,144,133,204,95,36,172,17,61,57,47,169,82,199,228,3,85,112,254,64,245,82,82,174,86,32,3,8,43,59,157,78,201,169,106,170,138,202,237,153,63,127,133,90,130,2,174,21,201,237,155,201,170,225,185,9,8,45,153,222,18,177,34,218,219,146,6,6,58,167,179,96,107,218,49,86,55,247,37,203,9,189,87,40,159,107,146,27,64,207,224,25,125,183,152,90,7,254,96,80,22,232,1,74,104,200,53,20,142,93,135,35,145,64,11,193,203,45,185,85,32,49,117,28,44,204,232,120,50,160,212,102,212,7,63,228,109,72,254,99,195,10,98,144,207,139,19,15,20,120,225,176,246,129,35,224,26,164,73,172,1,207,54,84,67,128,110,15,100,142,185,36,119,165,88,71,239,178,116,243,59,59,179,108,242,254,61,73,237,195,204,144,23,148,35,62,153,125,4,109,138,1,100,154,116,170,171,27,212,100,60,62,233,191,210,112,49,179,66,49,45,228,150,220,229,189,115,132,35,18,142,142,6,92,95,221,225,140,104,51,194,225,49,210,77,251,169,57,136,242,207,6,26,184,96,88,52,236,190,65,37,247,178,152,122,0,241,158,226,65,98,64,191,199,104,125,216,87,105,61,137,89,63,226,207,21,214,2,69,217,47,66,179,21,3,244,135,251,167,3,62,236,9,183,15,6,119,80,116,88,219,211,14,95,172,254,18,62,95,242,190,176,200,93,229,30,34,96,145,84,248,107,16,121,5,7,40,28,28,158,190,214,75,72,162,66,14,183,2,185,19,135,25,17,196,33,245,33,186,193,62,96,217,249,50,196,116,190,13,152,253,225,242,142,59,49,34,14,21,119,212,147,49,173,87,218,135,186,115,79,161,95,216,47,247,233,208,141,135,162,90,54,57,170,154,43,207,222,251,78,32,30,48,150,48,231,56,245,112,152,252,11,202,2,96,92,105,202,113,178,227,104,57,85,0,36,151,176,154,37,67,147,34,153,182,150,122,243,198,81,106,42,105,69,56,110,11,179,164,233,121,145,156,25,175,112,168,5,66,118,58,181,210,135,149,43,87,191,201,89,152,15,184,51,212,165,73,163,22,228,30,136,29,111,234,1,138,158,25,63,244,134,176,71,129,37,125,132,147,253,161,228,81,140,137,89,110,70,163,72,125,22,25,176,133,51,10,186,179,160,237,200,110,118,33,213,76,178,236,154,74,5,169,23,205,28,111,108,5,159,158,207,245,2,244,131,40,134,70,91,41,112,37,192,1,117,222,72,137,59,196,146,85,144,6,240,18,116,35,57,73,141,204,56,189,64,113,195,206,110,117,254,69,60,146,55,182,22,2,53,125,247,219,175,111,39,228,157,253,188,109,63,227,113,182,20,154,150,11,86,98,240,1,115,89,168,159,4,61,176,76,152,8,132,192,25,252,120,116,123,162,39,166,47,165,198,123,23,58,42,168,5,246,104,9,223,244,46,37,97,229,155,120,166,91,22,35,166,161,6,1,140,73,127,155,236,94,60,102,37,48,18,115,110,10,196,60,253,45,56,164,193,156,33,96,139,85,181,137,222,141,54,107,91,154,108,241,231,232,205,209,98,129,95,69,177,252,244,233,232,248,168,170,240,75,169,100,236,223,250,123,131,97,235,14,24,211,232,184,203,237,188,26,217,138,234,151,101,230,147,111,168,217,188,112,130,79,222,228,5,147,109,241,254,204,110,220,234,101,87,141,198,197,20,125,176,6,159,186,233,143,103,86,39,91,24,161,126,62,149,141,67,8,185,201,78,112,106,67,37,81,93,217,222,68,235,216,244,49,216,235,55,99,204,187,219,54,157,123,216,197,63,132,184,255,223,66,231,148,57,184,157,252,219,20,154,254,141,218,203,139,124,133,156,213,12,169,59,59,89,75,243,50,55,216,31,118,138,5,1,71,232,99,249,31,83,180,139,130,177,96,3,209,185,114,28,45,64,19,141,204,161,11,205,18,58,73,14,45,214,203,205,225,244,111,4,46,235,55,174,141,175,37,108,24,60,166,118,129,207,109,26,38,164,159,253,144,121,147,229,219,186,192,59,40,186,168,39,196,174,218,198,92,50,118,120,49,116,58,77,58,47,72,38,56,7,203,166,226,230,110,197,17,162,241,186,15,246,131,206,95,15,32,33,77,230,69,50,206,230,234,242,159,134,150,233,158,146,195,216,234,92,126,131,188,65,68,207,221,206,142,218,39,34,237,63,84,25,116,53,53,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dae1b07-57f7-43d8-bb4a-45b32e70e944"));
		}

		#endregion

	}

	#endregion

}
