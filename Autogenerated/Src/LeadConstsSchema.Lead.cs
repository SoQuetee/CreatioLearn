﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadConstsSchema

	/// <exclude/>
	public class LeadConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadConstsSchema(LeadConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b078fa1a-2f37-4251-9ae4-52a9c875b996");
			Name = "LeadConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,150,109,111,219,54,16,128,63,167,64,255,131,144,126,73,129,93,67,138,164,72,174,219,0,190,22,1,134,161,91,186,125,87,45,37,19,32,75,153,94,80,24,69,255,251,78,118,98,56,50,58,39,202,12,88,54,79,71,242,185,59,222,29,199,190,106,110,147,235,77,63,148,235,247,175,95,189,126,213,228,235,178,191,203,87,101,242,169,236,186,188,111,111,134,119,174,109,110,170,219,177,203,135,170,109,146,175,201,164,119,246,166,43,111,167,161,171,243,190,255,49,249,181,204,11,212,235,135,126,251,246,110,252,92,87,171,164,31,112,206,42,89,77,58,7,42,201,215,173,210,217,229,229,101,242,83,63,174,215,121,183,249,229,65,240,102,250,76,207,119,123,149,203,67,157,199,75,119,184,104,219,212,155,228,195,88,21,219,45,174,255,46,215,249,159,87,69,242,115,210,148,95,182,242,139,115,78,77,84,58,104,144,130,88,224,193,90,80,206,56,136,145,105,155,113,197,105,112,231,111,223,159,194,186,39,59,252,221,254,63,159,9,206,147,139,199,106,111,23,26,243,105,115,87,126,232,170,226,99,126,91,62,50,72,165,222,112,33,3,100,130,4,224,66,115,176,169,141,32,99,112,50,48,110,125,164,79,48,40,153,129,191,0,115,238,242,64,188,13,54,77,129,107,134,143,16,2,24,21,83,48,41,151,70,68,23,148,82,207,115,249,247,60,191,19,38,243,119,251,32,188,32,6,31,187,182,24,87,195,85,243,96,101,40,170,97,10,198,220,218,40,45,9,90,16,16,76,11,224,60,56,80,156,57,160,220,56,166,165,161,105,16,79,140,199,247,236,217,159,169,229,230,252,245,229,200,160,185,33,38,106,174,51,76,13,239,5,134,141,83,10,86,147,8,212,137,84,146,40,180,245,242,133,134,252,31,113,152,99,19,225,185,97,145,0,30,125,204,7,158,9,48,134,18,240,150,170,168,131,163,196,159,200,135,227,61,126,216,231,250,131,4,55,189,192,239,209,81,220,75,150,4,197,151,67,94,213,166,239,219,85,181,45,177,174,173,199,117,51,183,80,71,45,180,159,34,97,133,4,30,141,5,203,166,7,177,42,138,168,36,167,167,3,115,15,154,192,113,114,45,32,143,109,93,148,221,228,152,63,202,85,217,12,115,100,71,104,140,150,115,144,156,72,8,4,207,146,201,120,6,52,243,138,57,99,137,86,228,41,37,224,192,225,144,188,144,249,62,202,59,116,83,215,247,227,254,168,124,101,65,145,20,243,0,211,26,221,237,130,1,229,209,138,140,161,88,25,25,40,97,255,205,254,251,152,215,213,205,230,26,41,198,30,193,119,227,106,181,141,241,2,242,71,243,231,184,94,106,130,13,193,3,97,49,2,247,222,130,246,19,51,81,82,166,169,19,42,61,209,224,230,184,190,234,135,174,250,60,46,164,61,156,62,135,165,220,69,151,225,185,8,44,120,236,15,216,198,84,42,53,4,207,25,213,214,42,162,159,233,91,220,237,159,157,123,202,98,25,236,126,250,17,108,170,28,147,84,129,148,212,160,103,105,0,77,152,128,44,26,202,132,195,86,38,79,28,226,57,236,53,18,244,11,73,247,115,143,10,160,33,24,107,39,64,112,138,13,136,98,41,180,193,48,160,84,57,199,136,210,88,61,158,135,249,91,59,36,85,51,148,93,137,183,195,37,172,184,192,213,126,254,156,87,80,227,29,195,54,201,4,97,192,45,214,106,67,240,110,166,108,96,216,74,41,26,176,187,30,156,125,219,221,55,203,166,216,93,57,167,225,183,127,1,142,168,218,146,185,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b078fa1a-2f37-4251-9ae4-52a9c875b996"));
		}

		#endregion

	}

	#endregion

}
