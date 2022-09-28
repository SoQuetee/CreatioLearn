﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatLocksRepositorySchema

	/// <exclude/>
	public class ChatLocksRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatLocksRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatLocksRepositorySchema(ChatLocksRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f8d77e76-bfd4-4a03-b953-4d2d8d1beeb8");
			Name = "ChatLocksRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,75,111,19,49,16,62,7,137,255,48,44,28,82,9,109,238,180,73,21,21,132,42,90,81,74,57,33,84,57,187,179,137,193,107,47,182,183,37,138,242,223,241,51,221,221,110,30,60,14,189,68,177,61,243,205,55,51,159,199,203,73,137,170,34,25,194,13,74,73,148,40,116,122,38,120,65,231,181,36,154,10,158,126,44,57,205,22,132,115,100,233,37,42,69,230,148,207,159,63,91,61,127,54,168,149,249,11,159,151,74,99,121,220,89,27,20,198,48,179,16,42,125,143,28,37,205,30,108,154,193,36,154,125,115,242,82,226,220,88,195,25,35,74,189,129,179,5,209,23,34,251,161,174,177,18,138,106,33,151,206,108,52,26,193,137,170,203,146,200,229,36,172,157,11,20,66,66,73,56,153,35,24,194,90,65,142,21,242,28,185,134,159,53,205,126,0,51,112,32,42,244,153,41,160,28,50,146,45,48,141,176,163,6,110,85,207,24,205,32,115,208,189,100,6,43,71,232,129,184,193,212,132,107,67,254,74,210,59,162,209,159,87,126,1,153,61,7,165,165,173,64,68,60,179,4,62,224,242,74,98,65,127,193,24,18,91,240,219,120,124,155,28,239,132,248,84,99,141,59,48,220,185,3,113,76,77,57,60,217,30,230,178,206,76,94,150,188,203,60,112,247,85,232,201,127,248,69,161,52,142,220,55,25,234,214,242,8,172,64,6,131,142,209,184,99,230,146,91,239,38,119,37,109,203,52,197,109,117,237,196,232,44,61,143,57,234,99,80,230,231,128,128,151,168,23,34,223,22,45,20,255,61,234,110,11,135,225,40,220,150,243,252,117,52,86,86,134,242,60,143,85,145,168,107,201,225,85,178,234,151,193,122,181,193,88,223,174,162,247,58,105,178,239,231,211,210,195,223,18,234,17,213,33,140,246,214,243,156,107,148,156,48,127,220,189,200,110,227,70,154,62,131,22,32,102,154,216,251,105,232,248,123,219,188,172,143,111,171,223,169,136,36,37,112,51,211,198,201,134,111,50,57,207,65,20,30,42,78,178,147,145,179,221,226,42,184,38,153,238,186,250,221,221,174,150,234,52,51,227,70,162,241,78,204,165,194,4,104,225,83,184,39,10,72,56,180,249,232,5,53,185,202,101,10,73,65,152,242,150,46,150,179,100,18,73,190,116,174,152,183,194,210,80,72,184,19,52,55,53,91,58,9,25,199,253,29,127,13,162,214,48,19,130,65,147,107,20,66,244,15,205,55,23,182,79,232,77,248,168,36,167,132,129,73,160,51,24,210,105,85,153,17,226,70,174,3,248,26,193,191,193,120,12,188,102,44,6,31,252,129,39,216,210,250,152,131,102,34,173,147,53,160,41,107,68,239,152,185,146,7,187,134,138,123,101,121,141,12,137,194,167,46,199,182,46,2,233,216,189,195,167,193,191,138,96,79,27,211,107,44,197,29,14,35,254,209,241,190,242,191,227,63,237,72,130,210,125,127,160,45,254,61,161,58,100,99,159,119,123,250,36,91,242,200,53,228,144,76,46,67,50,102,216,161,207,111,71,47,67,5,130,207,33,215,252,227,236,187,169,127,44,217,222,214,182,31,142,237,189,189,35,50,98,170,135,79,60,131,115,248,221,53,179,237,130,42,125,34,28,195,9,156,158,2,199,251,214,222,48,68,123,28,41,157,230,249,48,38,117,144,220,90,83,227,49,224,94,241,189,69,47,47,194,216,198,29,10,41,202,157,26,132,41,83,2,10,86,171,133,49,127,42,2,221,230,234,223,127,53,177,61,176,214,185,207,57,223,36,108,92,162,77,75,156,173,70,134,74,93,184,7,203,138,74,57,85,253,135,193,243,207,234,28,54,137,30,29,172,152,135,71,173,7,245,197,159,189,94,253,99,207,191,61,241,3,108,183,60,59,31,88,126,183,189,185,254,13,131,125,180,140,209,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8d77e76-bfd4-4a03-b953-4d2d8d1beeb8"));
		}

		#endregion

	}

	#endregion

}
