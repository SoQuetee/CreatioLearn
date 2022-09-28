﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RestSharpExtSchema

	/// <exclude/>
	public class RestSharpExtSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RestSharpExtSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RestSharpExtSchema(RestSharpExtSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("412cd130-59d7-4126-a567-47ba5a825132");
			Name = "RestSharpExt";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,223,111,218,48,16,126,166,210,254,135,83,120,161,27,11,239,107,201,212,181,84,165,83,91,4,108,123,118,147,3,92,5,59,179,29,218,174,234,255,190,179,157,144,64,161,45,72,147,38,33,144,143,251,238,251,124,191,18,193,230,168,51,22,35,140,81,41,166,229,196,132,167,82,76,248,52,87,204,112,41,62,28,60,125,56,104,228,154,139,41,12,81,155,209,140,169,236,232,165,41,60,67,141,138,179,148,255,65,165,201,129,92,58,157,14,28,235,124,62,103,234,49,42,206,3,37,23,60,65,13,185,225,41,55,143,128,15,6,133,38,38,152,163,153,201,68,195,68,170,42,46,196,41,211,26,117,88,198,235,212,2,102,249,109,202,99,208,134,164,198,222,179,66,246,30,12,185,60,57,37,141,166,194,169,229,184,242,28,95,96,224,160,254,207,117,157,206,112,146,144,148,100,121,41,151,12,152,49,145,164,116,63,48,18,204,12,97,202,23,40,96,216,27,141,137,157,163,48,225,50,94,103,61,224,113,198,20,155,131,160,140,119,3,69,42,79,29,34,136,106,112,27,87,163,201,179,240,184,227,220,29,122,245,154,11,201,19,24,89,167,179,85,117,23,133,184,150,153,113,159,7,207,0,21,217,33,80,62,154,124,2,215,189,241,249,240,228,170,247,235,102,248,221,82,52,250,245,250,213,238,77,135,46,8,188,175,242,122,169,165,160,22,89,160,50,168,90,135,71,14,94,81,132,148,184,66,73,43,96,89,70,202,157,186,206,29,225,130,246,74,232,215,193,134,90,99,79,212,195,231,61,217,216,130,233,88,241,204,236,132,253,248,105,11,93,19,83,141,111,228,183,47,168,176,130,38,240,61,121,94,13,51,69,83,63,159,196,54,209,173,67,232,70,27,25,118,45,213,198,240,239,175,217,190,240,101,241,246,230,175,87,113,143,32,203,114,110,197,54,81,36,124,98,99,60,191,178,66,78,21,50,67,171,206,13,184,194,223,57,209,193,61,55,51,184,28,221,92,67,44,133,249,87,43,99,19,90,230,42,198,32,250,49,236,131,156,184,245,85,104,122,29,121,43,147,199,32,250,70,223,59,193,252,54,15,162,139,241,120,80,172,118,43,53,215,248,18,167,72,191,18,58,170,39,138,188,74,243,203,29,216,183,83,50,44,50,234,211,108,199,165,176,248,5,216,223,184,1,219,20,66,217,39,87,153,144,54,200,219,59,140,13,216,123,182,93,91,52,252,83,162,84,221,45,158,26,225,224,102,52,118,27,148,92,22,76,185,168,165,136,110,141,35,244,138,74,53,21,147,15,216,134,51,102,216,185,84,115,102,66,43,187,214,141,5,198,153,71,59,172,224,141,59,189,30,144,250,219,150,176,101,111,185,186,153,214,188,108,236,53,207,178,215,27,190,32,245,123,31,237,51,3,255,123,199,239,210,186,117,92,178,44,107,16,141,137,204,158,237,219,140,173,243,214,158,47,13,91,18,180,211,12,236,213,255,111,182,124,189,95,191,66,117,73,219,149,121,154,110,159,136,178,103,75,139,247,107,12,11,102,63,51,27,68,116,11,25,206,248,236,135,131,250,187,85,81,135,23,76,255,100,105,142,37,249,74,23,23,191,75,149,53,156,3,249,136,207,239,104,105,219,251,254,205,209,157,201,74,159,191,219,211,139,35,52,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("412cd130-59d7-4126-a567-47ba5a825132"));
		}

		#endregion

	}

	#endregion

}
