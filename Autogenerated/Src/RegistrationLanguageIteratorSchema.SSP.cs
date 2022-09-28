﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RegistrationLanguageIteratorSchema

	/// <exclude/>
	public class RegistrationLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RegistrationLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RegistrationLanguageIteratorSchema(RegistrationLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6da69591-0ead-4f19-a7ad-f14d7ecb200f");
			Name = "RegistrationLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,209,110,211,48,20,125,238,164,253,131,85,94,18,169,114,223,105,83,196,214,49,85,26,98,218,6,60,34,55,185,105,45,18,167,216,9,163,76,251,119,174,237,56,137,211,180,3,33,33,30,170,38,206,189,199,215,231,28,95,91,176,28,212,142,197,64,30,64,74,166,138,180,164,151,133,72,249,166,146,172,228,133,160,247,247,183,231,103,79,231,103,231,103,163,74,113,177,33,247,123,85,66,62,235,189,99,86,150,65,172,83,20,189,6,1,146,199,7,49,55,92,124,107,7,187,51,230,121,33,134,191,72,56,54,78,151,23,51,83,215,43,9,27,156,151,92,102,76,169,215,228,14,223,84,105,203,191,97,98,83,177,13,172,74,192,129,66,154,248,233,116,74,230,170,202,115,38,247,139,250,221,5,144,20,127,25,230,235,249,214,123,146,213,0,138,186,196,105,39,115,87,173,51,30,147,88,79,124,114,94,242,154,172,14,107,25,89,94,155,5,220,202,98,7,178,228,128,171,184,53,208,246,123,191,96,51,240,81,129,36,113,33,132,101,157,54,129,221,2,93,133,58,248,178,137,237,191,62,145,13,148,51,242,108,103,219,73,254,157,149,208,22,124,87,101,64,190,36,144,178,42,43,187,131,179,163,197,45,109,112,67,31,145,24,126,186,68,127,186,229,225,108,36,50,225,163,161,74,200,155,55,36,24,252,16,17,1,143,67,112,129,79,66,24,206,78,144,125,131,202,146,34,37,49,130,84,18,144,247,196,90,226,196,122,174,68,149,163,210,235,12,230,104,11,244,211,194,242,110,33,84,143,245,87,32,18,107,3,223,19,88,33,102,87,49,26,230,119,92,177,18,188,228,44,227,63,113,2,189,112,142,217,76,224,254,198,226,231,10,176,114,9,105,52,62,229,213,241,116,65,201,240,210,204,200,142,73,150,19,129,157,35,26,87,30,135,227,69,223,148,243,169,137,30,78,174,201,84,46,173,230,86,239,62,47,177,38,244,84,205,61,49,137,95,215,100,80,12,55,125,72,158,140,175,122,16,81,15,100,214,6,57,5,163,6,67,251,79,211,173,125,226,38,8,66,147,242,252,247,106,93,229,140,103,15,144,239,50,220,151,186,130,7,166,190,254,247,178,29,36,14,108,207,241,194,117,10,7,99,26,197,63,84,127,98,100,29,249,221,103,160,210,16,91,120,185,229,42,232,131,247,109,116,164,11,29,107,159,47,108,255,247,80,110,139,68,239,124,219,149,253,22,125,15,250,204,37,215,96,112,237,91,112,106,181,151,216,183,92,161,223,153,36,202,2,216,38,89,231,247,250,162,229,71,159,239,85,46,130,241,42,25,247,135,52,104,51,248,78,22,121,48,198,3,223,173,180,249,242,121,11,18,92,52,93,137,192,230,211,91,45,53,160,148,42,240,202,12,9,83,117,77,118,239,73,192,143,162,174,185,75,158,163,195,236,190,235,138,39,11,71,137,113,73,114,177,215,128,127,68,140,86,89,3,172,68,90,212,244,24,244,64,195,19,158,76,136,69,48,39,65,232,246,250,136,167,196,91,4,125,43,246,1,174,228,137,88,18,60,206,125,217,188,74,44,90,125,237,9,150,23,87,63,32,174,244,61,34,89,55,143,81,239,24,167,87,66,33,192,242,162,29,50,83,91,40,135,165,43,144,192,18,208,0,182,20,106,33,225,206,12,7,237,20,157,236,209,227,150,163,143,3,155,74,117,104,23,92,195,183,132,209,183,73,18,184,80,92,165,21,250,19,203,42,176,242,88,27,77,200,112,136,235,159,181,85,66,199,134,209,187,251,111,255,158,187,230,168,57,213,90,125,144,136,13,137,71,236,196,19,54,252,61,19,117,193,94,242,144,107,39,154,160,15,34,219,183,215,226,99,214,241,43,234,88,176,185,122,118,253,103,233,171,25,193,187,42,176,120,107,69,213,104,120,128,12,58,218,248,210,87,8,125,89,86,59,115,171,34,230,129,26,128,40,178,101,181,210,182,55,96,173,170,7,242,142,75,85,158,132,161,60,113,234,13,136,213,66,47,205,141,27,119,65,72,31,10,189,80,255,240,124,185,59,190,116,47,66,41,85,135,81,125,203,215,75,33,107,89,60,118,78,177,35,87,186,131,163,76,66,92,200,4,77,188,184,51,79,40,43,136,146,167,28,221,124,112,6,218,213,170,69,109,29,189,119,241,124,111,23,63,159,186,136,35,215,199,131,150,166,172,151,92,21,67,141,203,57,103,168,17,118,47,49,181,60,94,154,81,122,224,202,76,61,176,160,153,62,244,250,179,7,117,76,197,122,172,59,244,252,11,237,203,199,142,141,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6da69591-0ead-4f19-a7ad-f14d7ecb200f"));
		}

		#endregion

	}

	#endregion

}
