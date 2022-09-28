﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLExceptionsSchema

	/// <exclude/>
	public class MLExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLExceptionsSchema(MLExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("adbab915-dfa7-4d76-8933-ffdeab5c8df5");
			Name = "MLExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,77,79,219,64,16,61,7,137,255,48,50,61,128,20,37,247,20,168,84,74,43,36,168,40,65,189,111,236,113,178,149,189,155,238,174,27,104,196,127,239,236,172,157,196,6,28,2,1,81,14,72,235,204,206,155,121,243,241,108,80,34,71,59,21,49,194,53,26,35,172,78,93,239,68,171,84,142,11,35,156,212,170,119,113,190,187,51,223,221,233,20,86,170,49,12,111,173,195,252,99,227,220,187,42,148,147,57,246,134,104,164,200,228,95,190,74,86,100,183,103,112,76,7,56,201,132,181,3,56,83,127,200,32,185,54,66,170,33,186,31,5,154,219,211,155,24,167,254,6,95,232,247,251,112,104,139,60,23,230,246,184,60,95,225,212,160,69,229,44,80,152,218,88,112,19,225,64,199,113,97,32,41,140,15,69,42,135,134,204,156,63,232,20,46,206,33,215,9,102,240,219,99,0,222,120,23,214,167,84,129,244,27,40,135,22,81,100,86,67,108,48,61,138,202,220,22,209,69,208,247,150,211,98,148,201,24,98,159,79,123,58,48,128,149,212,58,115,78,111,73,136,86,214,153,34,118,148,206,0,46,217,107,176,104,50,192,15,206,148,116,204,45,90,16,160,112,70,9,91,39,20,149,142,146,117,19,228,240,203,208,91,195,138,250,199,33,250,222,2,172,223,68,59,156,10,35,114,240,237,113,20,81,139,88,49,198,232,248,154,80,202,67,40,64,130,54,54,114,132,150,3,224,210,244,14,251,124,151,93,149,92,181,134,179,79,44,248,146,149,142,15,252,189,206,0,70,194,226,126,245,12,124,7,118,238,254,3,122,152,131,58,73,212,121,25,1,5,142,12,210,144,41,72,201,136,41,171,80,107,180,221,131,144,74,161,89,70,24,144,22,109,198,40,50,248,143,69,97,23,41,211,116,24,26,154,165,105,183,242,78,240,196,82,145,101,20,80,138,100,68,60,201,20,148,6,134,90,113,78,126,237,20,99,153,74,76,94,90,219,238,114,30,160,158,210,67,85,239,54,109,106,93,176,135,42,9,147,196,231,240,180,241,176,177,123,190,107,119,170,116,49,158,124,17,78,124,213,134,99,166,240,94,184,127,36,147,109,208,83,165,52,177,205,24,144,16,8,215,121,177,136,92,137,183,205,5,180,54,167,141,150,144,209,14,99,135,201,182,6,109,109,116,27,15,155,84,169,14,253,191,2,115,61,104,211,161,250,233,204,59,8,68,178,119,46,228,68,103,73,152,31,91,218,98,2,122,244,139,200,8,117,20,35,93,184,250,196,194,8,125,107,187,137,209,179,53,227,27,107,210,166,27,183,113,220,142,182,69,78,32,39,229,253,102,216,222,47,111,150,18,160,16,25,120,130,76,206,14,86,162,182,186,48,190,66,198,175,108,82,72,113,111,231,76,171,218,175,111,169,253,123,132,50,106,23,154,1,87,113,213,166,59,152,86,191,180,205,244,155,72,229,246,91,244,197,114,185,190,0,13,201,132,215,149,203,87,166,232,157,75,230,82,43,43,156,165,100,238,51,75,153,80,227,153,54,9,51,53,33,98,252,160,18,161,240,83,90,63,146,159,133,149,241,193,51,245,117,211,102,88,167,177,91,23,217,135,244,242,148,75,58,155,200,12,129,148,51,145,49,191,149,251,79,6,122,66,252,74,119,251,160,10,214,180,109,200,230,167,108,125,89,122,209,106,141,178,213,194,217,168,205,23,219,184,38,184,101,44,51,233,38,228,98,81,170,208,181,21,96,73,102,111,171,155,1,30,232,134,53,148,108,244,46,221,233,188,119,190,66,163,156,37,209,113,200,152,119,192,116,145,118,251,2,224,119,46,127,247,130,95,190,90,174,62,145,219,111,133,76,160,10,169,11,124,44,65,106,68,127,136,30,105,255,112,23,230,149,143,59,8,31,209,225,237,112,94,250,186,139,90,246,247,27,23,8,132,74,200,104,185,240,156,102,144,230,18,123,100,157,210,147,213,109,253,30,106,253,22,58,177,228,171,66,244,127,219,214,138,231,172,135,150,22,126,226,183,217,6,205,237,171,208,104,237,1,204,235,190,63,245,46,66,167,221,69,221,32,79,143,201,81,24,7,250,247,15,154,80,101,254,180,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("adbab915-dfa7-4d76-8933-ffdeab5c8df5"));
		}

		#endregion

	}

	#endregion

}
