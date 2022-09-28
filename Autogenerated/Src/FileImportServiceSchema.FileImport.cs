﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportServiceSchema

	/// <exclude/>
	public class FileImportServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportServiceSchema(FileImportServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc33a226-fa38-40ca-84cb-1237a1b5a371");
			Name = "FileImportService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b49a3d-3e30-4c01-a6cc-3961eeed3fd5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,89,75,111,219,56,16,62,123,129,253,15,172,11,20,50,224,85,238,77,226,34,77,147,194,139,38,205,198,41,122,88,44,10,69,26,59,236,234,181,36,149,212,45,242,223,119,248,144,69,74,148,236,182,105,138,94,12,139,156,25,126,243,30,81,121,148,1,47,163,24,200,21,48,22,241,98,41,194,227,34,95,210,85,197,34,65,139,60,60,165,41,204,179,178,96,130,124,249,253,183,81,197,105,190,34,199,5,131,240,52,138,69,193,40,240,125,119,125,17,223,64,82,165,192,154,245,191,170,136,137,207,205,243,98,205,5,100,237,103,60,57,77,33,150,199,242,240,53,228,192,104,220,161,185,172,114,65,51,60,5,119,163,148,126,86,40,59,84,184,123,75,99,56,43,18,72,195,35,20,121,235,167,123,15,215,72,203,57,238,45,68,36,160,33,176,237,145,101,54,171,228,105,175,173,210,226,58,74,159,63,215,235,225,155,98,181,194,101,220,71,138,167,12,86,40,159,144,227,52,226,252,57,26,41,173,178,156,159,69,101,137,52,151,104,127,212,23,20,233,223,175,34,17,161,253,5,67,219,254,131,11,101,117,157,210,152,196,146,179,135,145,72,137,150,199,140,234,155,237,47,74,114,131,226,148,66,154,32,140,11,37,90,111,170,115,207,32,187,6,38,79,173,143,157,159,228,85,6,44,186,78,225,64,199,128,134,48,171,161,236,15,178,115,193,164,109,46,139,66,200,152,200,162,115,140,54,195,242,20,242,68,35,82,207,247,218,82,238,98,219,112,77,40,26,29,181,205,142,120,121,14,136,44,43,81,255,107,154,82,177,190,132,255,42,202,32,131,92,240,192,126,144,1,65,14,201,22,22,73,21,154,133,100,210,241,67,7,7,186,224,101,196,193,60,77,201,188,67,129,107,151,16,37,111,243,116,109,135,91,219,57,232,72,46,34,68,128,238,97,50,102,181,138,163,82,63,144,88,238,215,118,109,14,185,96,69,140,82,165,121,81,185,113,103,99,236,55,186,39,38,124,135,206,165,110,141,76,96,228,195,210,122,218,119,104,205,185,17,67,44,184,201,47,161,44,56,197,58,177,38,31,104,239,158,43,195,62,75,23,153,181,123,164,89,220,162,21,42,95,2,19,88,160,122,20,83,214,102,149,148,117,196,86,149,116,61,121,199,129,249,214,15,103,146,115,148,195,157,143,45,24,87,154,47,215,229,107,60,173,5,153,133,201,126,203,166,3,118,26,216,58,156,13,89,145,188,120,161,64,6,67,52,135,58,155,140,9,177,204,138,131,1,48,179,160,199,32,147,142,70,62,175,249,214,164,14,30,103,34,120,18,120,55,124,136,61,130,103,193,6,83,95,68,88,122,180,10,224,222,222,30,57,224,85,150,69,40,168,94,56,102,128,154,113,66,85,82,98,154,23,75,34,214,37,32,37,96,46,50,88,30,142,59,153,62,38,123,179,112,35,114,207,150,105,138,72,135,37,152,144,47,228,254,17,129,168,149,82,186,155,228,232,242,195,177,109,246,241,76,138,34,212,60,134,7,123,138,114,88,3,167,60,216,210,38,29,127,163,63,91,229,99,247,36,46,4,166,19,36,3,166,114,177,247,248,161,150,227,41,109,206,67,7,122,39,70,81,25,79,40,202,24,181,151,131,86,49,216,22,167,103,32,110,138,78,61,246,234,139,109,132,9,174,44,106,212,38,165,46,250,187,250,158,26,71,170,174,52,79,198,51,51,237,113,189,66,104,130,233,78,151,180,29,10,38,239,111,11,154,104,20,157,182,19,188,174,112,175,37,127,162,198,200,209,232,54,98,164,220,84,28,180,163,44,173,175,168,50,16,98,61,208,77,110,74,138,235,143,104,181,153,225,26,125,33,227,121,11,240,180,125,132,204,37,36,189,87,93,101,244,103,113,253,182,84,51,37,249,184,249,171,183,232,146,4,79,92,223,72,215,205,249,41,230,91,197,224,36,151,163,79,18,140,145,230,21,44,163,42,21,250,240,70,230,120,82,43,52,106,164,27,109,172,147,13,201,72,14,21,192,5,86,216,184,184,5,85,220,150,81,42,167,191,81,131,248,158,64,170,7,183,142,216,70,100,104,0,25,22,245,219,82,5,71,229,218,19,222,89,97,74,206,40,95,226,140,51,55,101,81,50,45,208,152,41,92,49,186,90,161,199,79,113,247,188,184,155,90,174,154,182,97,77,52,132,247,140,10,56,74,18,72,154,195,16,46,142,194,65,59,4,52,131,252,185,119,155,136,10,166,1,65,219,2,42,45,36,106,180,19,18,159,69,121,36,85,64,135,190,81,203,129,85,35,143,202,18,115,15,139,157,193,34,153,241,77,136,35,7,114,107,13,27,106,41,77,111,158,124,18,144,115,101,127,93,148,125,68,129,111,241,10,235,117,120,145,70,57,36,173,108,65,221,58,33,108,96,105,125,194,121,190,44,2,3,79,239,248,236,182,136,110,107,31,111,156,21,180,23,44,71,214,134,235,239,254,225,187,50,65,241,129,197,99,159,190,189,124,109,235,176,232,27,142,67,173,122,151,32,153,126,175,177,16,238,90,194,152,206,42,167,115,97,253,210,179,185,217,116,138,151,146,192,0,115,60,231,179,227,254,243,15,246,106,34,171,251,245,188,134,189,6,225,238,88,94,232,52,76,83,7,106,112,181,43,106,172,199,55,16,255,91,143,90,231,85,154,6,82,209,98,25,212,244,38,62,52,58,167,5,133,67,56,106,249,115,95,180,13,77,32,202,81,180,213,24,48,42,89,166,111,9,6,28,85,91,176,221,86,44,110,175,153,93,140,72,109,91,186,179,249,195,76,44,43,3,171,79,214,117,189,23,89,96,120,4,22,118,83,189,37,123,187,61,29,146,30,63,236,55,60,78,107,116,252,123,74,243,164,147,230,254,242,161,26,156,37,233,9,226,71,77,201,179,103,118,144,55,239,231,239,16,28,210,200,42,27,158,100,165,88,111,122,155,194,196,21,17,226,105,245,153,19,156,15,196,90,139,176,170,238,220,76,171,47,215,40,55,232,59,176,134,58,170,141,28,46,124,238,181,250,143,193,17,202,22,86,115,155,142,79,226,72,196,55,36,56,249,20,131,106,78,4,54,42,108,228,55,155,135,4,236,246,105,178,169,38,220,154,20,102,246,50,105,33,103,242,27,208,147,216,29,21,55,234,137,151,16,203,217,41,177,199,168,175,173,106,158,9,124,240,198,71,91,239,49,51,98,8,142,39,41,90,241,243,234,229,2,226,10,187,254,250,36,95,209,28,52,146,227,40,63,249,132,235,2,222,226,27,128,146,28,140,113,81,171,116,202,138,76,58,50,173,59,248,183,100,205,96,57,68,91,55,33,123,14,216,182,177,221,157,23,232,67,57,181,225,188,4,86,146,237,56,68,94,160,44,202,113,132,176,218,191,53,65,142,188,45,188,221,125,219,3,162,141,83,10,8,220,164,24,245,12,231,195,202,63,114,42,25,80,96,222,100,162,60,33,28,85,193,228,146,9,214,180,10,34,10,4,134,249,191,75,199,217,196,141,196,129,163,114,95,59,31,72,37,105,79,105,186,192,158,50,191,47,248,157,176,108,228,255,20,179,47,126,210,252,101,76,175,199,214,159,48,55,185,62,248,250,129,105,186,209,202,112,110,159,160,148,169,245,107,250,110,115,211,195,13,184,15,145,7,230,66,227,145,39,173,239,74,45,11,242,86,55,74,74,107,158,248,25,105,88,143,17,234,190,227,87,10,12,109,212,183,10,247,47,20,28,14,236,173,1,98,83,255,240,32,121,144,143,99,198,240,59,124,87,236,245,217,87,126,58,12,234,15,80,166,163,140,39,246,215,192,55,56,248,236,250,21,113,35,105,105,242,210,21,101,125,0,179,62,41,250,248,169,229,54,87,134,237,80,231,97,171,180,230,230,209,17,168,238,166,186,47,116,223,234,207,222,151,204,29,28,218,255,234,252,176,223,138,31,216,77,144,92,22,119,252,184,168,242,150,175,42,154,215,62,178,104,30,217,237,87,209,170,63,162,113,115,70,54,127,135,34,58,47,68,71,19,143,182,231,30,178,1,169,230,206,127,88,230,69,135,104,64,34,115,190,218,123,29,235,253,176,239,147,37,10,17,165,67,200,174,28,130,157,191,142,108,187,94,92,124,251,173,149,221,100,155,129,120,243,113,196,185,35,236,157,107,187,215,24,59,92,199,214,233,130,134,179,78,177,146,104,115,101,107,162,216,161,107,133,52,210,186,182,117,169,59,118,71,250,110,148,184,60,222,40,218,96,234,101,243,69,51,114,249,226,124,8,35,249,99,7,161,77,34,250,48,152,4,221,125,36,123,148,208,233,176,242,38,249,102,58,203,212,198,131,197,219,180,78,227,230,160,58,4,183,220,192,153,249,199,77,127,180,52,183,107,193,215,12,51,184,246,63,139,144,37,155,137,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc33a226-fa38-40ca-84cb-1237a1b5a371"));
		}

		#endregion

	}

	#endregion

}
