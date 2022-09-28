﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CopyOrderProductsFromOpportunityOperationSchema

	/// <exclude/>
	public class CopyOrderProductsFromOpportunityOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CopyOrderProductsFromOpportunityOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CopyOrderProductsFromOpportunityOperationSchema(CopyOrderProductsFromOpportunityOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ebfdef75-7e35-474a-b50e-06a84f9be85c");
			Name = "CopyOrderProductsFromOpportunityOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c8dbc813-f433-4d53-b0ee-3a05b62a07e1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,89,91,111,219,54,20,126,78,129,254,7,206,27,90,185,117,148,116,216,195,86,199,65,83,215,41,12,180,77,178,164,219,67,215,5,140,68,219,194,116,11,73,165,49,146,252,247,29,138,164,68,81,23,203,233,246,18,71,212,185,240,28,126,231,227,33,21,227,136,176,20,123,4,93,16,74,49,75,22,220,157,38,241,34,88,102,20,243,32,137,159,62,185,123,250,100,39,99,65,188,68,231,107,198,73,52,182,158,221,15,65,124,93,27,156,38,97,72,60,97,129,185,239,73,76,104,224,149,50,166,175,40,74,226,230,55,148,180,141,187,179,152,7,60,32,172,230,246,130,220,114,247,119,178,204,66,76,103,183,41,37,140,137,41,128,28,72,254,72,201,18,158,208,52,196,140,189,70,211,36,93,159,80,159,208,83,154,248,153,199,217,49,77,162,147,52,77,40,207,226,128,175,79,82,162,115,0,202,105,118,21,6,30,242,132,238,54,170,59,119,185,250,70,231,71,116,201,164,228,222,222,30,58,96,89,20,97,186,62,212,3,240,58,139,72,204,25,90,36,180,191,127,183,48,184,103,90,84,193,164,152,242,0,135,109,65,201,41,237,232,8,202,16,32,163,28,195,92,94,163,83,26,220,96,78,148,64,42,159,144,39,4,16,227,84,172,204,101,42,205,125,8,24,63,197,156,19,26,163,9,122,51,248,219,249,178,191,251,219,209,238,49,222,93,124,189,251,245,225,203,238,87,115,224,23,49,48,64,47,115,195,59,111,6,181,119,157,3,175,126,126,24,58,127,141,186,60,24,182,123,24,108,244,240,226,167,193,88,231,134,196,190,76,143,149,44,72,38,44,134,0,43,100,43,79,187,18,168,45,115,62,98,44,34,10,124,88,240,96,17,16,234,150,26,123,53,149,131,27,28,102,164,124,190,88,17,148,108,52,99,40,41,52,188,207,2,223,244,63,247,209,29,90,18,62,70,76,252,121,232,158,183,0,206,119,205,184,195,64,219,92,133,74,203,44,53,20,45,16,206,129,36,216,184,51,18,133,126,99,42,108,4,182,161,86,192,158,143,174,214,0,111,80,217,58,192,84,219,21,83,232,142,78,77,250,212,152,51,186,147,96,133,72,245,191,59,148,240,12,138,201,142,77,188,122,144,63,204,144,14,22,200,201,93,185,115,246,41,11,195,19,58,139,82,190,118,134,195,66,68,89,84,54,180,145,92,19,56,149,220,130,230,71,204,189,149,180,51,106,42,109,211,90,101,98,80,243,185,86,97,28,145,144,145,82,152,175,104,242,13,197,228,91,65,117,179,91,143,164,130,196,156,24,118,169,100,225,152,249,24,14,173,89,202,159,110,144,10,134,67,56,12,139,181,224,137,194,221,34,196,203,173,86,180,191,169,250,242,94,37,73,136,230,76,152,56,10,67,205,182,141,48,54,105,165,136,206,230,154,77,188,220,72,203,38,211,159,123,43,18,225,79,144,101,88,165,129,249,102,48,110,55,80,50,69,179,153,218,251,121,12,8,33,172,203,168,146,252,12,90,208,65,100,81,204,0,87,43,97,206,120,115,169,254,47,126,53,11,183,37,230,56,32,161,159,103,37,225,208,148,16,95,231,69,61,34,74,176,159,196,225,26,125,102,132,66,26,99,217,186,88,143,227,22,165,188,27,89,203,232,27,242,106,169,53,110,179,168,216,177,139,141,222,82,203,65,3,203,234,145,63,3,190,186,192,183,132,109,136,58,135,3,5,15,9,181,246,30,133,195,222,93,132,99,165,37,171,60,234,138,175,142,186,211,21,241,254,209,209,8,194,209,101,108,105,171,66,182,92,76,44,39,82,168,158,92,16,172,106,186,230,106,124,196,49,94,18,42,25,2,250,80,128,160,168,16,143,188,93,11,152,58,205,69,32,103,180,161,216,62,18,190,74,252,182,82,83,37,222,80,35,128,242,144,56,114,146,101,147,172,105,4,182,154,124,107,131,253,91,23,141,175,243,171,232,94,75,66,39,156,197,220,33,185,37,52,57,68,242,63,17,229,197,58,37,190,172,159,63,4,251,28,8,155,135,206,96,238,15,134,104,50,177,172,195,192,171,45,35,110,41,163,155,0,130,133,126,242,38,129,16,230,16,181,211,12,118,12,127,116,84,117,224,195,146,10,1,185,226,85,196,195,171,188,255,175,28,81,92,232,253,207,9,231,144,89,113,214,224,121,200,22,100,71,130,64,76,75,131,17,90,96,216,128,42,107,93,143,196,4,211,89,70,232,26,29,39,52,170,47,235,236,252,204,209,17,221,96,138,8,187,134,185,138,221,172,102,193,249,30,188,118,112,174,46,36,112,237,66,172,98,251,202,253,73,28,192,214,125,20,126,195,34,83,2,114,48,57,160,6,82,106,28,249,10,48,142,102,90,87,24,29,12,59,69,4,27,111,16,129,108,111,150,112,79,9,245,96,237,187,37,91,222,158,101,56,79,97,171,50,172,123,203,187,163,72,212,80,203,203,47,198,150,243,90,253,175,127,191,186,159,178,232,138,208,147,197,91,204,136,144,96,143,178,98,39,240,56,8,97,143,100,194,128,35,158,167,176,201,112,34,71,5,118,79,161,11,141,136,16,113,36,72,228,43,56,70,67,127,26,176,36,22,165,239,206,174,1,187,163,202,22,12,120,175,87,154,91,233,246,53,128,68,187,247,67,131,112,173,99,41,90,61,129,120,69,75,16,182,2,190,104,10,15,228,182,126,232,52,152,51,187,57,247,60,13,129,45,158,143,158,23,125,221,163,178,209,157,14,13,163,145,49,89,237,239,193,164,88,240,213,66,11,130,216,128,107,36,110,84,135,162,200,92,182,127,202,199,8,233,193,90,197,234,172,249,196,131,34,13,17,199,183,210,220,184,58,156,112,28,54,189,192,249,24,154,52,152,110,228,126,165,119,104,163,221,240,175,170,239,49,54,117,11,6,69,124,105,21,177,192,81,149,116,11,192,20,49,131,75,71,5,244,194,152,201,16,237,33,231,213,254,62,122,105,14,42,100,24,153,17,91,133,145,162,234,153,162,143,19,240,209,97,85,186,55,23,65,194,196,92,105,23,224,96,164,70,243,205,168,37,149,13,162,26,130,157,86,223,5,204,19,211,16,116,58,170,39,165,83,87,173,251,72,69,213,71,69,109,32,143,208,212,19,45,84,247,183,240,119,81,46,130,136,178,124,234,99,227,251,148,245,58,203,236,154,138,173,44,160,55,158,255,134,7,174,149,181,199,84,161,189,5,118,134,90,8,143,10,159,22,37,196,246,222,246,136,57,201,170,106,57,207,189,68,131,214,253,83,79,226,10,94,156,149,57,209,83,45,185,165,62,203,67,180,143,158,61,67,71,84,62,231,188,207,156,134,212,23,68,100,57,169,155,124,97,57,238,65,0,111,13,155,144,99,211,197,134,110,83,3,203,236,152,115,163,143,197,86,231,60,243,254,174,39,79,73,146,151,29,97,191,122,86,199,139,173,28,136,243,73,31,235,98,105,182,52,125,169,116,122,217,7,50,216,214,188,84,233,101,93,93,91,182,116,100,242,165,178,83,107,53,170,235,223,176,240,133,158,77,78,253,52,107,208,204,15,178,86,65,41,216,165,85,172,229,231,214,180,172,247,185,15,5,149,118,80,133,60,148,182,51,132,94,177,113,205,252,52,163,20,178,181,133,151,26,12,198,13,71,106,109,111,210,232,167,99,47,0,227,30,97,13,167,125,43,85,186,98,27,206,253,149,44,154,231,243,126,225,53,231,233,127,88,6,65,188,21,235,112,44,80,247,200,232,254,94,117,225,22,94,10,160,220,223,35,37,209,113,53,82,222,132,84,174,41,10,202,110,96,194,153,230,239,250,125,142,58,51,72,9,235,232,173,27,202,186,41,81,179,239,200,194,72,19,115,180,116,51,63,215,109,20,167,140,46,55,248,134,56,198,61,132,220,94,122,223,195,24,87,122,141,31,13,103,183,196,203,56,97,40,209,68,131,248,10,115,228,37,105,144,143,150,31,137,116,214,139,123,236,150,47,135,249,136,248,22,18,33,113,157,55,25,136,171,154,193,161,252,230,164,157,224,130,206,14,246,114,89,243,163,99,94,49,106,102,61,238,135,242,107,164,124,64,102,168,126,35,35,239,90,58,238,101,76,197,134,210,3,101,113,184,132,218,176,69,154,241,98,148,0,43,209,95,224,211,252,134,34,187,133,69,2,24,244,86,200,98,3,20,212,203,127,167,157,74,10,14,41,116,54,66,230,1,201,239,222,149,209,135,127,1,183,143,11,142,244,31,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ebfdef75-7e35-474a-b50e-06a84f9be85c"));
		}

		#endregion

	}

	#endregion

}
