﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RemindingServerUtilitiesSchema

	/// <exclude/>
	public class RemindingServerUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RemindingServerUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RemindingServerUtilitiesSchema(RemindingServerUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ef2215fb-53ef-462c-baa4-4d3784c96c58");
			Name = "RemindingServerUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe3149b2-9704-43d8-935e-39b7af42f452");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,75,111,227,54,16,62,123,129,253,15,92,229,34,3,134,140,30,122,105,18,3,113,236,164,1,146,141,17,39,187,103,70,26,219,106,37,202,37,41,39,70,55,255,189,195,135,36,234,97,197,41,122,216,67,55,192,90,36,103,190,121,15,71,98,52,5,177,165,33,144,71,224,156,138,108,37,131,203,140,173,226,117,206,169,140,51,246,249,211,223,159,63,13,114,17,179,53,89,238,133,132,244,180,177,70,250,36,129,80,17,139,224,26,24,240,56,108,209,60,194,171,108,109,206,168,164,213,166,171,0,135,67,251,193,156,201,88,198,32,14,18,44,120,22,130,56,112,158,166,25,59,200,57,155,226,17,30,158,112,88,163,53,228,50,161,66,252,70,30,32,141,89,132,244,75,224,59,224,79,50,78,180,6,154,118,60,30,147,51,145,167,41,229,251,137,93,159,216,127,229,67,241,68,220,71,231,116,254,26,110,40,91,3,49,18,130,2,119,236,0,111,243,231,36,14,137,144,24,150,144,132,74,181,30,205,6,42,106,165,33,119,32,55,89,132,166,44,52,136,86,188,165,185,222,120,0,153,115,38,72,204,80,16,195,180,200,86,132,23,82,130,146,109,220,228,59,219,82,78,83,194,48,157,206,189,92,0,199,36,98,38,41,188,201,141,3,166,206,72,88,30,6,103,99,205,217,13,180,53,161,252,138,11,111,162,254,87,8,114,3,196,30,244,115,139,252,249,15,148,226,77,46,233,86,201,170,219,210,203,26,129,8,121,188,53,234,207,170,197,7,32,50,12,8,143,35,40,99,228,77,150,241,154,17,153,145,226,136,192,107,44,164,74,196,30,76,110,34,82,115,162,75,94,156,43,134,122,142,232,74,217,147,107,144,165,14,211,189,173,14,255,169,22,35,82,15,217,8,33,184,210,203,9,64,185,103,221,58,82,2,7,3,187,233,56,140,156,19,150,39,201,136,60,103,89,66,90,110,192,227,21,77,4,12,137,78,209,129,85,104,25,110,32,165,133,64,187,58,111,232,21,212,136,239,40,163,107,172,150,43,4,46,188,51,221,43,93,125,71,239,225,169,22,99,156,81,151,114,155,173,15,9,114,201,123,228,120,223,94,176,151,45,74,56,207,74,187,206,227,200,145,242,0,97,198,163,155,8,229,96,52,22,173,125,191,233,254,154,27,44,102,188,34,126,23,36,98,162,180,96,158,110,229,190,112,234,192,100,133,14,132,225,126,115,188,80,229,143,93,31,101,62,106,222,180,190,202,237,161,17,27,92,114,160,18,12,123,195,42,107,198,142,234,250,143,226,34,87,224,133,204,98,77,129,13,229,204,228,211,136,100,58,201,38,133,61,246,103,224,93,228,216,202,184,55,106,106,124,153,115,14,76,170,180,86,23,152,164,161,188,137,12,211,219,136,148,236,246,232,95,243,47,179,156,135,128,236,165,233,72,44,164,8,170,86,172,41,140,154,157,8,166,124,108,79,66,36,91,79,29,148,123,225,198,193,107,164,69,240,84,193,155,16,27,7,219,138,220,80,177,49,249,86,170,246,59,110,249,165,239,157,180,250,98,120,130,27,241,21,19,230,158,235,92,242,157,154,30,150,137,101,181,69,100,203,131,246,135,84,250,69,87,32,30,65,69,93,86,55,255,180,176,118,75,248,241,195,218,252,165,145,153,193,21,200,112,115,197,179,116,54,245,223,203,20,252,243,148,137,40,95,27,255,70,208,155,166,215,56,117,81,199,95,130,156,193,10,39,152,60,101,223,104,146,131,240,107,10,119,208,59,196,190,87,196,249,200,132,178,216,239,161,150,244,255,45,172,73,77,141,122,100,250,30,9,108,184,31,227,20,250,21,198,100,180,75,28,253,64,209,251,195,35,69,56,151,112,103,126,189,107,251,129,178,59,150,189,94,139,218,135,205,91,68,21,228,199,180,105,192,20,61,253,72,16,39,215,75,14,221,245,27,140,250,236,173,103,232,51,77,251,255,161,239,167,24,250,234,51,220,46,195,65,194,196,231,103,30,226,14,205,21,6,190,123,2,61,48,243,88,53,139,235,196,209,105,212,214,195,185,195,90,178,141,5,141,137,168,183,183,211,29,216,238,111,171,229,4,88,100,94,161,236,186,245,62,197,227,29,134,198,156,110,205,162,8,157,158,1,187,199,189,119,226,214,51,18,23,230,104,112,174,240,204,84,89,78,128,213,144,133,46,92,66,98,238,106,117,117,154,69,115,40,179,23,175,26,221,116,111,193,222,180,88,98,87,241,176,55,57,135,234,10,214,93,176,208,13,109,204,133,55,12,46,132,225,112,104,191,111,128,67,13,7,7,139,249,95,57,77,212,230,173,218,52,236,117,17,23,44,42,153,116,135,115,248,140,110,193,66,85,9,72,224,254,47,197,189,97,77,20,239,91,26,60,102,91,228,235,50,248,182,84,84,153,83,132,169,207,126,61,235,91,227,111,59,141,55,118,238,197,247,140,255,169,191,176,212,28,209,50,168,113,107,150,92,1,94,7,109,39,105,240,251,23,6,252,67,168,221,195,195,1,120,221,128,123,176,235,195,168,109,183,232,228,165,110,38,120,177,55,112,135,193,92,117,62,225,151,137,233,16,220,243,8,248,116,239,235,223,89,204,141,194,10,42,148,129,234,197,160,43,85,185,212,104,103,122,98,116,207,188,33,161,194,134,220,164,132,249,182,227,207,166,243,87,8,115,153,113,18,61,151,143,29,175,58,34,231,48,155,86,91,126,53,46,90,168,27,245,165,234,1,40,234,134,69,167,127,206,109,202,5,6,25,204,169,95,73,170,64,108,123,82,231,129,34,115,240,85,19,42,106,216,82,92,215,110,249,51,85,217,19,55,39,79,45,231,155,157,253,107,13,205,94,255,26,210,109,100,141,214,100,251,125,235,221,160,103,186,142,202,163,66,121,221,99,36,47,106,78,211,79,243,56,81,110,176,90,174,50,52,42,220,16,223,160,144,157,50,9,199,12,7,45,48,83,119,245,126,33,121,112,177,221,98,184,125,77,221,152,198,181,129,87,113,2,229,183,46,229,176,187,217,175,90,255,57,11,51,125,161,62,177,24,159,64,157,77,247,56,218,248,10,214,77,205,158,46,111,118,235,155,184,247,15,66,59,7,236,42,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ef2215fb-53ef-462c-baa4-4d3784c96c58"));
		}

		#endregion

	}

	#endregion

}

