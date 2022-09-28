﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseConstsSchema

	/// <exclude/>
	public class CaseConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseConstsSchema(CaseConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6721b175-9034-4299-afb8-25c85fbb77e6");
			Name = "CaseConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,151,219,110,219,56,16,134,175,91,160,239,32,228,42,69,193,150,103,137,88,44,80,146,146,138,0,61,4,113,179,123,209,244,66,182,40,87,168,44,121,117,72,214,88,244,221,119,36,219,173,173,156,148,34,128,15,12,127,206,231,159,228,204,168,76,86,174,89,39,11,231,125,118,117,157,52,85,214,190,182,85,153,229,203,174,78,218,188,42,95,60,255,239,197,243,103,93,147,151,75,111,182,105,90,183,250,3,190,175,187,121,145,47,188,166,133,57,11,111,81,36,77,227,217,164,113,32,109,218,6,38,244,162,103,111,222,216,164,117,203,170,222,120,200,59,43,23,121,234,202,182,255,199,177,188,118,73,90,149,197,198,123,215,229,233,118,153,157,108,175,57,75,189,63,189,210,221,12,51,78,79,136,193,198,18,161,16,17,88,163,136,16,130,52,35,6,97,76,132,8,49,183,152,132,39,47,123,206,103,183,48,102,174,190,206,225,231,94,184,127,58,215,60,137,102,39,181,73,81,140,129,236,239,3,133,46,75,186,162,245,22,16,9,94,182,227,15,96,53,109,221,239,197,78,118,200,7,72,39,119,12,159,28,197,133,32,85,157,47,243,210,75,119,129,221,42,201,11,47,79,167,88,241,105,144,238,130,68,189,112,228,132,31,171,136,196,36,66,49,151,6,17,78,48,98,92,81,112,66,96,163,69,40,45,11,142,156,216,111,241,16,179,107,192,144,191,147,188,245,178,170,134,240,205,26,206,147,155,2,54,27,212,231,174,76,193,156,17,147,144,152,82,159,43,100,2,236,35,30,196,49,10,124,105,17,54,138,48,22,42,204,164,24,237,14,184,244,147,231,163,187,153,78,0,147,71,209,117,36,98,26,131,15,191,28,137,67,165,111,59,114,87,236,179,242,188,174,150,96,68,51,29,225,151,102,188,55,145,138,9,197,252,144,196,76,37,185,112,213,218,149,110,210,41,217,114,236,21,35,138,24,75,22,25,3,39,36,180,18,113,21,80,20,112,70,80,24,216,88,11,26,71,161,141,239,165,176,69,213,60,133,97,59,127,68,192,34,63,230,20,219,67,31,236,84,31,108,82,46,92,241,4,130,97,254,136,64,194,153,224,148,4,135,4,209,35,4,11,248,41,93,13,239,85,234,126,114,184,212,155,111,188,174,113,245,163,68,91,185,5,245,94,106,54,151,32,28,161,97,25,68,90,178,24,197,34,212,136,135,56,66,6,75,130,148,208,146,235,16,206,79,228,223,190,44,99,184,193,246,223,65,27,132,119,130,249,146,179,136,250,49,18,196,80,196,41,149,72,65,126,69,17,213,88,107,78,132,97,241,17,216,62,211,67,117,107,189,118,179,118,144,252,223,235,199,96,118,170,115,16,125,6,13,40,198,231,87,6,148,198,192,129,97,147,192,32,21,64,54,9,41,82,54,14,169,48,161,214,18,223,145,77,22,223,32,207,122,151,103,211,14,239,48,251,114,92,101,136,31,50,26,43,20,80,95,32,46,24,135,155,3,165,134,88,41,9,17,54,82,246,184,202,124,172,218,60,203,23,67,29,239,127,204,112,141,87,249,144,35,31,195,24,107,127,10,71,80,42,138,164,212,112,157,35,171,66,196,165,244,81,160,148,64,84,69,144,100,69,24,209,112,148,92,187,166,173,86,174,158,193,210,77,6,54,67,128,89,87,95,187,161,58,31,12,238,10,19,116,28,235,2,74,217,163,27,119,107,189,207,59,229,136,152,50,225,43,171,12,210,224,38,216,72,49,10,152,96,200,55,154,105,109,141,96,90,29,94,190,190,27,170,87,131,17,94,149,13,71,189,47,192,245,182,129,0,232,167,113,30,174,247,41,179,219,213,118,221,200,125,196,138,24,159,51,134,32,49,192,157,100,112,49,13,81,28,81,161,112,24,72,38,149,161,7,196,67,93,222,47,5,124,186,105,242,101,233,220,19,65,247,178,123,160,12,247,35,14,71,15,41,72,18,125,162,128,60,46,32,143,115,44,56,244,66,190,165,218,238,54,254,54,210,187,186,234,214,79,228,25,52,247,192,224,208,98,95,40,139,2,108,24,148,120,120,209,1,236,174,31,49,170,168,8,125,24,58,56,133,15,133,9,243,38,153,23,110,6,173,196,101,147,44,221,112,113,142,51,36,36,31,158,250,136,48,156,33,238,36,71,243,44,243,17,118,110,62,103,89,224,124,39,119,177,30,140,227,138,100,115,127,148,20,54,55,200,176,68,52,11,192,84,62,7,163,125,236,80,144,44,136,98,124,49,151,56,155,16,229,108,181,114,105,14,134,221,31,201,49,46,149,72,124,228,167,178,79,43,105,128,230,34,193,200,159,75,149,56,65,231,78,38,7,167,235,142,164,114,56,244,212,188,114,248,125,92,37,3,17,249,4,250,54,104,159,1,76,243,16,25,174,193,145,72,72,10,229,136,17,110,39,110,234,133,91,184,252,218,165,113,93,173,76,145,44,190,23,57,60,202,164,195,177,60,238,21,99,28,98,40,40,200,196,125,149,177,90,33,45,163,8,46,93,96,35,66,181,198,194,78,176,93,119,144,227,250,241,33,194,133,91,23,155,209,141,14,140,208,68,35,18,132,208,146,70,129,70,10,58,2,104,0,172,111,137,134,22,218,196,19,194,124,72,234,239,46,213,205,108,157,172,142,215,135,124,17,193,13,64,148,196,80,164,160,150,163,192,64,27,30,107,106,130,48,160,204,26,253,240,250,187,199,140,129,95,167,105,223,78,158,39,109,235,234,18,2,189,61,57,253,114,117,115,245,250,10,125,125,245,242,237,240,185,255,116,122,122,245,250,244,11,186,186,249,250,242,21,252,157,76,88,127,251,208,152,186,15,73,243,189,127,239,159,97,14,199,166,172,161,139,162,186,1,27,192,243,89,55,95,229,64,153,66,11,188,118,117,187,249,43,41,186,97,209,143,213,148,165,134,159,107,170,116,19,87,117,143,241,33,249,247,189,43,151,237,183,61,219,189,19,134,213,127,188,120,254,227,127,74,27,217,128,82,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6721b175-9034-4299-afb8-25c85fbb77e6"));
		}

		#endregion

	}

	#endregion

}
