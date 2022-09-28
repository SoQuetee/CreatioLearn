﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoSchema

	/// <exclude/>
	public class AccountInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoSchema(AccountInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("664e29f1-8562-4e4b-9032-ee822c76c25c");
			Name = "AccountInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,77,111,219,48,12,61,183,64,255,131,144,94,54,96,72,238,75,80,32,200,134,45,27,90,4,104,183,29,138,30,20,155,78,132,58,146,39,201,9,130,98,255,125,212,135,19,199,177,29,219,243,78,182,69,62,138,143,148,72,154,211,13,168,132,6,64,158,64,74,170,68,164,135,51,193,35,182,74,37,213,76,240,225,236,243,227,189,8,33,86,55,215,111,55,215,87,169,98,124,69,30,96,167,5,183,218,223,148,224,227,155,107,20,221,74,88,33,130,204,98,170,212,71,50,13,2,145,114,61,231,145,176,226,209,104,68,38,42,221,108,168,220,223,249,111,171,74,34,33,9,67,53,185,177,91,18,186,20,169,38,212,225,137,210,84,167,138,80,30,18,166,21,81,32,183,44,0,53,204,76,142,114,54,147,116,25,179,128,4,214,236,137,3,87,111,214,137,131,147,11,41,18,144,154,1,122,186,176,40,39,47,122,105,23,190,0,110,140,78,42,243,212,107,32,211,197,156,188,194,126,120,64,140,138,144,201,150,198,41,28,62,159,74,65,71,157,103,19,70,239,211,254,221,96,154,176,239,176,31,188,127,49,50,79,74,105,105,66,239,68,228,141,172,64,143,141,71,99,242,167,141,235,28,51,78,68,100,223,125,136,219,209,168,55,80,77,201,169,62,32,186,156,215,81,222,157,220,14,150,100,45,196,43,161,73,130,182,221,113,10,197,134,50,222,142,100,51,67,149,100,127,193,242,43,162,167,73,242,201,98,74,25,23,149,186,211,166,120,117,247,38,39,249,203,209,156,108,9,170,146,217,163,215,61,101,228,87,159,95,178,55,213,157,140,196,130,132,181,5,252,197,111,78,101,32,94,7,132,69,104,224,119,10,10,11,71,26,4,0,225,152,8,52,43,119,12,77,14,176,200,9,57,104,194,211,110,94,154,55,39,234,129,96,128,117,181,93,166,10,136,74,239,103,168,119,234,59,195,74,106,86,123,112,27,59,134,162,171,150,158,159,131,42,157,191,119,170,165,177,247,178,238,44,48,14,176,114,173,173,245,1,123,186,132,175,164,52,63,162,202,14,214,156,159,74,77,203,34,103,152,50,210,183,192,67,215,209,236,183,91,45,44,22,250,114,217,102,141,26,116,104,235,32,38,193,119,100,172,55,185,104,92,238,199,229,27,247,215,152,41,177,241,207,123,186,91,131,185,251,135,89,98,77,189,26,11,9,77,81,196,117,86,220,91,181,243,73,112,167,101,10,147,81,112,103,42,142,94,51,213,112,143,92,53,250,96,204,68,52,86,214,78,163,99,164,126,26,179,83,180,122,54,30,44,133,136,201,169,66,183,91,82,19,198,74,158,189,244,221,203,65,189,188,91,31,225,173,111,222,249,56,55,233,224,29,110,168,239,161,157,166,102,223,203,141,11,38,117,110,110,62,22,170,250,27,122,216,184,223,105,57,63,49,122,255,186,143,156,231,6,46,205,42,149,35,103,78,254,127,174,10,227,24,121,142,217,176,39,89,179,109,115,222,87,101,183,33,75,238,193,220,63,30,247,169,53,82,122,190,157,168,123,159,45,158,195,182,19,233,25,170,38,203,78,183,56,145,250,243,127,120,233,76,37,69,46,29,121,84,65,43,201,252,64,64,57,161,188,228,244,163,175,162,227,204,53,168,58,137,132,16,34,198,33,60,254,164,231,56,94,170,49,217,62,253,22,25,192,2,28,163,107,98,203,66,12,186,41,25,237,114,85,5,173,204,213,194,3,74,107,75,38,236,41,59,249,132,55,200,208,217,185,171,207,201,169,245,126,243,146,53,107,69,82,25,119,251,9,47,66,235,126,187,173,126,213,239,182,51,214,45,35,184,246,23,33,64,168,218,45,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("664e29f1-8562-4e4b-9032-ee822c76c25c"));
		}

		#endregion

	}

	#endregion

}
