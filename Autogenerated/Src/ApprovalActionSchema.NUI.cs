﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApprovalActionSchema

	/// <exclude/>
	public class ApprovalActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApprovalActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApprovalActionSchema(ApprovalActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b8e060c-eca2-44fa-9ba3-99cc638d437f");
			Name = "ApprovalAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,223,111,211,48,16,126,46,18,255,131,41,47,137,84,101,239,221,152,68,219,117,84,192,52,169,3,30,16,15,158,115,105,13,169,93,252,163,165,218,246,191,115,142,157,52,201,210,85,32,193,3,226,165,141,237,239,206,119,223,125,103,91,208,21,232,53,101,64,110,64,41,170,101,102,146,177,20,25,95,88,69,13,151,226,249,179,187,231,207,122,86,115,177,32,243,157,54,176,58,109,141,17,159,231,192,28,88,39,151,32,64,113,182,199,140,165,130,228,66,24,110,56,232,253,116,125,55,5,135,230,147,201,232,224,210,148,50,35,149,119,138,152,151,10,22,24,1,153,9,3,42,195,132,134,100,246,122,189,86,114,67,243,215,204,103,130,176,181,189,205,57,35,188,68,61,6,245,92,190,189,91,41,115,50,94,82,177,128,18,16,105,163,92,28,224,146,217,93,33,113,3,114,105,121,74,120,58,32,19,94,152,83,181,59,243,176,1,145,183,95,145,149,115,66,211,148,23,107,57,18,101,87,226,35,205,45,232,216,135,221,181,209,39,110,150,239,36,43,232,191,248,193,96,237,62,158,218,221,249,233,253,86,4,189,7,79,30,136,212,243,215,224,114,156,83,173,135,164,131,198,147,147,19,114,166,237,106,133,219,157,135,113,19,70,152,51,38,153,84,100,43,213,55,23,250,22,243,170,80,164,212,68,233,237,164,230,238,243,4,50,106,115,51,226,34,69,203,200,236,214,32,179,168,85,171,56,254,178,175,168,223,174,9,232,144,128,171,174,163,171,74,17,69,107,148,117,82,26,146,235,194,149,7,4,183,77,251,232,131,6,133,38,194,203,157,216,198,48,38,133,116,122,45,208,171,22,204,209,30,120,111,19,95,133,117,173,228,26,148,163,103,232,190,13,90,66,26,2,43,135,164,181,79,107,120,71,22,96,78,201,145,141,222,131,89,202,180,107,23,190,161,6,72,33,207,75,48,51,61,229,168,159,185,161,198,234,168,16,158,46,190,103,105,153,246,134,42,178,225,154,122,204,28,220,153,128,201,11,216,18,63,104,177,23,23,86,189,196,107,50,234,135,45,250,229,252,84,201,85,212,255,88,121,172,22,62,45,65,1,226,211,126,156,204,244,197,119,139,189,233,157,36,215,84,97,103,96,111,71,85,116,49,161,58,4,112,234,227,108,197,152,204,215,192,120,182,187,146,216,116,223,222,224,209,160,163,216,67,21,24,171,196,163,172,146,139,31,192,172,129,57,163,57,85,103,142,163,243,96,242,219,116,151,69,221,112,101,48,33,79,124,147,245,162,99,118,225,4,168,179,94,230,138,108,251,69,60,134,205,13,246,76,90,235,247,51,87,180,243,168,63,15,224,126,51,199,71,53,174,8,252,181,188,30,183,80,35,163,63,122,164,6,74,60,79,115,182,132,21,13,174,195,224,85,171,73,146,58,244,61,21,116,1,202,113,55,195,67,129,10,6,163,34,166,104,31,94,224,172,81,137,138,117,239,38,25,43,192,206,241,144,182,228,189,57,207,72,244,34,84,106,10,134,45,157,212,39,163,136,99,47,221,223,183,170,30,202,93,38,87,214,43,163,185,6,239,238,161,248,13,254,230,96,106,156,96,185,193,76,48,156,62,242,137,127,55,124,5,201,7,195,174,228,54,196,114,216,108,180,67,145,12,218,140,141,173,82,104,227,102,221,67,193,224,45,92,106,164,200,171,187,52,228,5,30,4,54,207,171,44,240,94,0,202,150,36,114,250,229,248,138,192,43,249,72,89,15,197,234,172,147,183,176,27,20,126,146,98,50,4,20,168,121,168,11,189,116,66,55,208,236,217,227,114,253,91,23,243,63,160,227,170,104,102,169,228,182,184,4,220,73,126,37,205,84,90,145,238,217,139,235,26,118,14,159,86,127,211,93,13,121,192,227,255,174,56,210,21,245,26,250,158,232,224,218,45,56,190,125,59,28,226,58,52,24,62,167,224,208,157,241,244,123,211,109,81,246,90,181,135,174,191,219,253,43,175,83,73,100,72,246,223,119,15,221,86,93,130,57,106,120,40,251,46,195,102,102,56,247,19,92,209,77,142,97,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b8e060c-eca2-44fa-9ba3-99cc638d437f"));
		}

		#endregion

	}

	#endregion

}
