﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailRecipientMacroRepositorySchema

	/// <exclude/>
	public class BulkEmailRecipientMacroRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailRecipientMacroRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailRecipientMacroRepositorySchema(BulkEmailRecipientMacroRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f21e75ff-18af-4453-8d4a-578418fcde6a");
			Name = "BulkEmailRecipientMacroRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,91,111,219,54,20,126,86,129,254,7,194,123,145,1,67,202,176,183,197,22,208,56,89,225,109,105,189,56,233,107,65,75,199,49,87,137,212,120,113,226,22,249,239,59,36,37,155,178,236,56,125,178,121,57,231,251,206,119,46,20,167,21,168,154,230,64,238,65,74,170,196,74,39,83,193,87,236,209,72,170,153,224,239,223,253,120,255,46,50,138,241,71,178,216,42,13,213,229,193,26,239,151,37,228,246,178,74,62,2,7,201,242,222,157,191,25,255,111,191,57,21,85,37,120,184,150,208,93,37,215,87,251,141,79,240,164,209,185,229,246,167,114,118,120,244,139,132,71,132,36,211,146,42,245,59,185,50,229,183,155,138,178,242,14,114,86,51,224,250,150,230,82,220,65,45,20,211,66,110,157,81,154,166,100,172,76,85,81,185,205,154,245,92,138,13,43,64,145,10,244,90,20,138,104,65,36,208,130,80,94,16,69,55,64,10,170,41,89,9,121,10,132,224,31,166,183,73,11,144,6,8,181,89,150,44,39,185,101,249,22,146,209,15,71,116,31,30,6,174,41,215,24,226,92,178,13,213,224,207,107,191,32,185,61,39,140,107,242,181,162,207,115,42,49,161,26,164,154,10,195,245,28,228,63,6,228,246,138,234,124,77,38,228,215,139,139,139,203,198,63,240,194,67,116,241,254,96,80,22,167,192,172,44,130,151,91,242,160,64,34,51,238,211,78,190,154,206,250,12,132,11,73,154,28,3,182,64,78,32,127,227,48,61,110,99,198,153,102,180,100,223,49,69,148,112,120,194,104,173,36,88,179,98,69,244,26,208,4,80,8,9,171,201,224,172,194,131,52,243,201,72,118,128,233,33,226,184,182,50,18,142,82,78,6,221,208,6,217,61,2,218,61,171,124,179,153,140,83,103,225,28,52,9,63,75,36,62,208,176,139,51,36,182,237,162,232,64,89,204,97,79,234,40,122,121,93,239,91,95,215,39,114,106,75,103,74,203,220,148,184,154,174,13,255,166,98,187,87,89,186,190,140,70,238,82,46,74,83,113,191,211,210,219,80,73,218,178,83,88,109,206,30,73,222,82,189,78,62,44,85,124,182,40,211,174,95,23,79,36,65,27,201,137,229,49,116,174,166,192,74,156,4,113,64,10,45,227,66,160,216,48,236,49,24,134,178,180,129,110,4,43,176,152,80,62,159,10,229,8,128,138,63,26,60,88,182,249,154,21,35,199,33,154,221,112,83,129,164,136,48,14,255,255,5,219,47,180,52,48,167,76,142,173,237,136,96,57,35,187,44,203,26,213,26,207,161,74,185,145,18,139,224,218,50,153,16,251,115,207,42,72,30,116,254,73,60,249,168,113,194,0,69,73,98,123,127,233,212,97,252,184,71,231,146,185,88,156,150,232,210,54,134,143,46,62,40,154,97,50,227,90,196,167,122,99,208,136,222,197,247,176,150,128,99,178,3,142,2,212,196,233,160,226,214,65,231,108,1,58,30,236,144,30,102,197,96,132,157,111,83,157,236,10,162,201,103,130,146,14,79,59,241,217,122,197,220,209,120,197,193,213,62,183,199,188,4,169,223,57,121,241,63,161,171,155,103,200,141,134,54,218,151,159,234,188,115,67,110,129,239,140,114,195,76,213,168,217,138,65,129,211,182,17,175,77,134,125,130,186,87,44,117,2,150,251,91,199,89,16,172,159,101,123,23,4,95,65,124,200,208,177,236,76,180,158,15,217,169,31,181,127,255,189,199,30,239,124,119,225,216,164,220,48,169,13,45,125,127,90,29,250,13,73,174,153,51,199,168,124,199,185,12,132,77,185,75,177,163,52,227,43,129,205,120,146,103,216,152,245,110,58,225,244,240,13,116,39,158,176,161,126,187,220,55,175,27,139,126,236,76,122,211,242,36,76,210,76,207,227,16,195,203,96,132,6,61,142,8,39,61,250,170,196,170,182,235,248,153,76,50,215,247,167,71,82,252,108,155,107,68,236,119,19,78,132,13,66,163,181,244,239,233,231,229,191,206,77,219,64,195,100,81,151,76,127,230,216,27,90,197,65,212,13,215,99,211,179,147,167,238,176,10,167,240,209,170,71,28,5,109,149,120,198,246,235,43,120,207,207,228,24,95,243,183,22,254,198,198,56,200,22,194,200,252,0,179,95,237,254,1,82,217,79,49,25,167,173,89,80,221,103,204,188,4,253,131,184,81,195,177,110,203,181,121,22,195,92,94,131,234,102,115,124,174,43,98,239,242,149,15,7,191,27,110,190,252,15,19,173,190,135,39,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f21e75ff-18af-4453-8d4a-578418fcde6a"));
		}

		#endregion

	}

	#endregion

}
