﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnMessageRedactorSchema

	/// <exclude/>
	public class EsnMessageRedactorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnMessageRedactorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnMessageRedactorSchema(EsnMessageRedactorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6629a3bc-6810-4a2f-8b11-7ca823a7ac06");
			Name = "EsnMessageRedactor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,87,93,111,219,54,20,125,78,129,254,7,46,125,152,12,24,242,123,18,123,72,29,55,48,176,100,70,221,110,15,195,30,104,241,218,38,38,81,42,73,165,48,134,252,247,145,20,41,83,18,101,203,203,250,162,152,228,229,57,247,139,135,12,195,25,136,2,39,128,190,0,231,88,228,91,25,207,115,182,165,187,146,99,73,115,22,47,214,207,239,223,253,243,254,221,85,41,40,219,161,245,65,72,200,110,235,177,191,45,203,114,22,94,225,208,55,31,127,194,137,204,57,5,209,107,177,96,146,202,202,64,153,124,224,176,83,126,33,52,79,177,16,55,104,33,216,19,8,129,119,240,25,136,193,50,102,147,201,4,221,81,182,7,78,37,201,19,52,153,169,201,63,31,96,139,203,84,126,164,140,40,162,72,30,10,200,183,209,178,139,49,26,253,165,236,139,114,147,210,4,37,154,41,64,132,110,80,96,171,218,167,211,85,59,170,210,41,36,102,82,249,186,226,185,132,68,2,49,46,86,62,138,50,203,48,63,204,220,132,137,246,128,68,178,135,12,35,166,234,19,215,182,19,223,184,112,96,40,209,12,72,72,174,147,119,116,168,66,90,27,160,103,133,131,166,232,122,157,39,20,167,214,224,250,246,132,31,43,78,245,88,129,167,101,198,254,155,35,22,99,110,32,156,11,75,114,146,215,198,95,116,233,209,119,85,77,245,165,105,138,54,128,138,92,104,206,172,138,229,98,223,42,158,37,105,58,231,102,135,184,104,153,223,148,33,91,137,166,19,67,202,163,79,27,48,249,179,64,5,230,234,199,255,226,205,202,64,181,115,226,102,135,228,164,100,244,91,9,104,73,126,116,225,170,182,254,26,174,95,189,120,210,229,175,2,184,70,103,138,71,43,221,57,71,56,96,146,179,244,96,54,206,235,125,173,161,101,252,0,140,84,2,96,199,190,26,240,82,11,133,22,4,35,48,149,133,21,155,174,160,68,45,190,178,49,28,33,163,54,87,205,217,120,190,135,228,239,123,190,43,117,151,60,151,105,26,233,74,40,177,107,237,30,221,154,221,45,138,105,139,196,24,189,158,142,236,9,228,62,39,70,229,232,11,150,96,163,170,6,174,63,230,42,137,18,108,128,145,45,170,237,4,23,201,11,230,78,254,166,173,228,198,126,125,159,48,83,187,120,252,8,114,105,36,54,129,143,7,221,8,81,191,6,218,112,53,133,110,67,69,80,49,197,149,99,149,121,43,225,118,143,182,143,215,32,213,29,82,245,220,239,56,45,65,68,173,101,111,45,10,29,240,113,29,110,181,143,131,44,57,51,222,248,89,118,121,123,201,41,65,10,86,185,116,79,50,202,62,211,221,94,138,200,166,19,204,31,151,184,106,20,55,77,85,136,143,105,190,193,233,125,81,40,28,169,18,46,226,79,42,216,146,67,211,114,201,22,217,6,8,1,242,107,190,163,73,200,155,77,158,167,104,169,18,195,109,92,15,144,130,132,176,59,93,175,237,122,35,112,235,180,5,26,13,98,93,227,151,154,179,213,60,93,210,96,186,157,248,24,164,209,133,237,125,254,18,87,45,137,24,124,175,69,89,230,166,192,61,18,99,102,148,140,227,204,200,229,244,90,219,62,96,137,175,103,250,139,182,234,169,225,144,12,204,221,196,88,31,55,87,81,137,217,221,196,253,106,74,87,232,244,217,94,87,61,250,135,122,35,185,217,135,47,191,33,71,239,31,72,199,63,109,29,97,103,27,63,53,210,76,183,40,250,233,177,164,36,94,100,133,42,239,226,91,137,83,113,180,94,146,145,67,191,170,107,209,57,60,157,247,195,24,249,8,21,213,171,249,246,131,116,47,122,15,197,45,90,172,115,40,129,91,199,3,171,87,131,189,230,55,217,201,166,73,170,171,93,55,205,233,59,114,72,223,56,48,135,212,105,157,198,126,115,211,219,74,170,219,115,182,106,190,45,150,228,141,173,103,95,45,231,91,111,140,116,243,160,150,67,126,67,186,192,126,64,67,90,232,183,53,100,31,97,43,162,33,164,157,87,217,184,147,24,159,217,182,157,5,188,76,219,188,247,72,240,63,40,247,74,49,146,92,105,182,173,169,211,99,75,59,66,211,89,232,166,112,203,183,151,145,184,234,182,69,63,76,226,73,254,48,146,5,161,50,28,199,216,189,60,237,216,215,197,254,146,5,110,125,127,127,67,30,58,23,155,151,162,166,96,156,13,33,156,165,58,4,59,246,67,232,23,188,254,135,203,128,16,26,119,238,144,16,204,105,95,169,163,228,170,96,38,50,215,223,99,20,208,138,64,69,66,194,208,212,28,111,211,248,136,63,176,34,232,23,135,30,55,148,192,36,13,221,160,227,113,191,60,240,186,118,221,64,3,117,59,113,37,219,64,47,47,150,138,206,181,195,5,209,249,154,98,231,252,169,215,127,1,215,20,244,233,98,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6629a3bc-6810-4a2f-8b11-7ca823a7ac06"));
		}

		#endregion

	}

	#endregion

}
