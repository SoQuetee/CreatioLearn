﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SimpleCryptoSchema

	/// <exclude/>
	public class SimpleCryptoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SimpleCryptoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SimpleCryptoSchema(SimpleCryptoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("993dfa50-74b4-4910-81c6-ade279107913");
			Name = "SimpleCrypto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,77,107,219,64,16,61,43,144,255,176,164,23,23,130,92,232,87,136,147,64,45,59,173,73,3,6,169,167,210,195,70,26,75,34,210,174,152,93,185,21,193,255,189,43,237,200,150,28,199,113,114,43,244,18,103,103,223,123,59,59,51,111,145,224,57,168,130,135,192,2,64,228,74,46,180,235,73,177,72,227,18,185,78,165,56,62,122,56,62,58,62,114,74,149,138,152,249,149,210,144,143,182,214,110,0,127,244,163,160,15,97,137,169,174,92,15,171,66,203,24,121,145,84,163,70,236,13,66,108,180,217,76,104,192,133,57,253,156,205,124,141,134,108,177,13,104,56,28,178,11,85,230,57,199,234,138,214,65,2,44,109,73,44,2,21,98,122,7,138,105,19,7,17,214,228,90,151,139,200,108,182,75,183,21,27,118,212,138,242,46,75,195,142,216,86,2,142,185,182,227,168,38,198,166,86,218,34,6,20,52,133,83,60,134,83,70,235,130,43,85,36,166,134,240,118,212,225,78,224,229,220,149,173,18,136,200,22,170,87,52,47,51,224,115,230,167,121,145,193,51,245,154,213,152,28,132,110,122,201,228,162,169,212,251,201,212,103,60,139,165,105,79,146,239,43,79,88,159,213,59,138,61,106,149,99,7,100,157,223,45,232,68,70,38,195,121,163,97,55,183,147,107,2,84,86,69,85,112,215,192,225,54,242,162,224,200,115,38,204,180,94,158,80,241,78,174,124,89,162,233,28,177,47,134,13,104,55,103,83,224,147,171,233,102,80,238,161,122,204,67,208,37,10,213,226,32,218,156,208,110,213,88,42,209,43,71,132,53,243,229,220,85,26,126,254,98,8,170,204,180,106,230,198,249,17,92,159,25,57,25,213,148,82,47,206,216,37,19,240,155,117,227,3,59,99,206,237,228,163,237,131,15,184,76,67,152,163,92,166,17,32,75,184,74,214,11,203,127,10,219,106,81,46,218,216,234,6,42,67,234,106,152,87,33,47,74,13,223,76,108,80,39,229,126,5,61,54,12,53,232,220,138,148,236,59,48,88,114,108,212,190,180,163,70,137,4,152,154,121,50,67,248,68,58,109,113,156,30,217,181,73,81,122,163,93,136,91,25,129,129,120,105,145,0,214,11,119,234,141,119,34,231,60,106,202,123,201,232,191,6,61,191,241,252,207,132,167,106,68,92,243,64,82,119,13,188,127,117,106,48,93,187,189,247,204,222,43,64,46,212,66,98,222,62,77,18,41,255,77,30,30,2,215,48,109,247,59,119,119,104,38,12,101,77,119,215,146,215,169,224,217,56,147,225,253,160,151,225,41,123,119,218,207,217,253,14,34,214,73,155,226,170,249,177,127,237,52,51,243,222,47,1,181,27,200,177,233,225,167,15,52,195,116,190,37,174,246,216,152,94,184,87,219,120,135,207,14,116,242,4,14,115,50,225,14,115,242,75,31,236,255,78,254,151,156,76,221,173,181,105,236,175,81,230,189,193,63,208,212,244,129,241,164,169,39,176,215,212,107,250,30,83,147,68,199,212,20,121,222,212,109,99,247,152,121,235,251,98,215,71,199,234,47,209,106,211,201,32,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("993dfa50-74b4-4910-81c6-ade279107913"));
		}

		#endregion

	}

	#endregion

}
