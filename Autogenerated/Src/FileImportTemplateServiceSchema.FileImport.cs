﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportTemplateServiceSchema

	/// <exclude/>
	public class FileImportTemplateServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportTemplateServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportTemplateServiceSchema(FileImportTemplateServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd0694cd-3334-8a6b-963d-c4b5031b2e17");
			Name = "FileImportTemplateService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,27,219,110,219,56,246,217,3,204,63,112,61,139,129,12,24,10,246,109,209,92,138,52,77,6,217,153,164,221,58,157,60,4,69,65,75,116,162,173,44,169,36,149,212,91,244,223,247,240,38,147,148,40,43,78,154,12,22,125,105,97,234,240,220,175,36,83,224,37,97,21,78,8,186,32,148,98,86,46,120,124,84,22,139,236,186,166,152,103,101,17,159,100,57,57,93,86,37,229,63,255,244,245,231,159,70,53,203,138,107,52,91,49,78,150,187,222,111,216,154,231,36,17,251,88,252,27,41,8,205,146,22,204,187,186,224,217,146,196,51,248,138,243,236,191,146,76,11,10,190,222,102,9,57,43,83,146,199,135,128,242,214,131,179,249,93,46,237,47,151,100,222,90,179,161,41,208,230,240,111,139,230,31,89,241,57,184,229,245,171,245,167,115,114,199,65,68,241,237,95,108,3,243,253,146,1,175,45,128,11,242,133,7,217,56,193,9,240,158,17,6,16,0,243,11,37,215,160,22,132,142,114,204,216,11,180,182,214,5,89,86,57,230,68,147,147,208,87,250,7,88,152,83,64,244,65,172,29,178,234,156,112,80,88,5,26,158,103,121,198,87,239,200,231,58,163,100,73,10,206,34,251,135,96,26,237,163,13,91,4,84,172,23,210,137,32,82,213,243,60,75,80,34,152,12,243,136,94,160,87,152,173,57,30,125,149,92,175,133,60,201,72,158,130,148,111,169,112,7,37,211,168,82,63,208,233,26,47,161,74,77,43,244,113,209,94,220,245,246,9,154,246,94,119,147,7,77,9,78,203,34,95,33,198,169,48,207,199,204,149,36,185,33,75,124,14,81,5,106,26,183,37,29,107,116,191,144,34,85,82,185,34,190,165,101,69,40,7,251,10,41,75,14,193,68,210,1,114,118,173,237,31,116,138,143,94,190,68,81,231,135,125,229,69,250,39,4,48,223,235,34,118,16,77,38,27,117,232,252,240,57,105,179,0,180,59,40,9,22,236,229,232,61,35,20,156,183,80,57,166,97,35,164,205,51,194,111,202,150,195,236,236,236,160,61,86,47,151,24,100,49,11,127,66,42,74,149,129,63,215,132,113,84,97,10,86,4,162,172,217,179,227,111,218,147,64,168,0,192,253,177,222,56,62,16,28,35,229,22,136,107,187,35,166,93,92,67,237,237,200,173,221,152,50,118,78,72,106,56,50,174,115,154,142,15,50,134,10,248,132,110,13,183,13,254,44,69,243,21,130,95,124,133,174,235,44,181,9,24,43,221,150,0,101,208,190,83,140,68,193,104,212,0,134,227,41,154,151,101,142,66,188,129,1,57,173,201,4,137,26,49,26,233,77,241,209,13,73,62,29,210,235,90,36,134,243,58,207,35,33,98,185,136,52,128,52,33,192,103,11,100,150,98,197,205,140,48,6,54,20,152,247,209,111,32,81,124,44,132,51,4,70,252,134,150,119,160,141,59,100,163,63,254,146,144,74,248,134,71,199,71,106,232,126,11,80,183,5,179,201,163,95,127,13,170,224,97,172,89,120,108,222,190,245,248,236,97,85,65,34,106,92,128,151,198,235,146,50,175,151,5,90,226,170,18,57,10,23,41,98,248,22,156,132,135,129,238,237,239,153,171,209,241,129,146,3,60,93,174,32,215,7,3,219,109,231,62,245,66,166,199,137,79,33,5,80,41,190,171,188,72,88,10,121,156,77,145,181,218,54,151,48,190,255,77,26,157,112,65,33,35,169,111,160,19,90,46,143,48,100,250,40,243,189,202,184,0,37,188,166,133,239,99,157,100,218,174,109,167,60,168,163,11,74,216,205,145,180,214,153,50,86,139,174,38,132,72,206,136,193,114,139,105,163,75,181,155,33,41,213,133,179,232,162,180,212,179,187,70,147,216,144,111,27,71,241,146,182,200,214,154,80,11,52,192,177,196,142,149,150,29,30,15,157,181,40,192,64,172,191,79,125,65,13,122,135,189,217,112,246,166,30,83,241,69,249,71,6,201,18,66,115,100,217,116,22,116,145,139,178,211,65,166,109,47,220,221,20,229,160,13,132,133,9,116,103,141,202,133,27,194,247,11,216,190,136,59,109,135,172,114,100,118,112,216,203,193,222,142,129,115,186,130,227,2,178,31,197,243,156,236,41,82,74,157,7,97,47,236,141,84,225,44,140,8,38,92,71,126,141,57,158,201,245,144,23,219,177,32,160,97,191,66,20,31,127,33,73,45,250,54,156,99,186,55,95,113,114,245,1,26,156,93,93,197,132,80,238,206,191,237,163,2,178,185,242,175,151,72,244,255,208,145,220,66,211,22,191,38,76,207,52,228,205,252,63,128,125,47,168,129,131,232,184,72,202,20,68,142,223,95,156,252,83,132,206,76,54,148,145,77,108,50,81,100,94,200,98,34,60,208,197,18,13,243,30,109,43,209,111,217,13,137,84,228,124,101,39,220,167,240,36,101,169,110,143,81,223,2,182,29,238,27,66,91,122,147,215,49,66,32,87,209,63,180,90,117,250,136,198,54,177,177,249,40,178,124,20,108,239,13,212,229,13,161,36,26,131,14,38,241,41,59,254,92,227,60,82,104,227,38,189,180,189,114,130,48,211,28,58,158,198,214,75,155,140,234,134,163,142,195,166,154,223,101,252,198,228,48,191,23,29,104,100,141,114,124,112,228,225,94,128,98,12,206,117,215,208,91,236,189,244,108,112,118,162,52,176,131,83,209,125,100,223,34,81,121,165,40,12,155,152,98,20,6,241,203,148,118,222,5,76,246,80,46,80,180,46,182,40,43,12,194,73,184,162,139,174,219,69,25,159,100,148,241,55,244,53,89,224,58,231,81,34,134,175,36,158,149,53,133,233,3,250,13,133,84,47,152,58,169,23,33,129,241,172,144,7,45,172,133,218,205,124,144,250,220,207,206,102,13,19,200,91,22,100,147,106,191,217,97,160,5,127,64,28,72,31,72,109,113,158,200,235,55,57,105,139,177,45,60,82,179,118,9,168,44,85,110,246,204,245,112,102,107,89,167,48,237,118,251,6,218,177,103,124,88,172,160,249,105,218,160,141,150,121,95,185,227,105,42,74,39,212,154,166,64,166,222,252,241,104,149,103,195,216,241,0,251,58,19,200,12,230,41,183,155,60,100,93,83,200,154,213,190,188,224,25,72,4,122,173,52,168,138,153,82,103,52,199,140,196,110,69,155,134,79,160,76,137,130,46,213,43,113,83,225,69,179,198,20,246,55,197,209,241,151,138,170,158,53,50,172,61,66,193,83,82,168,120,87,226,153,246,107,128,71,53,236,118,77,183,9,228,79,222,124,33,13,247,218,170,252,190,193,111,56,247,107,75,48,220,255,93,19,186,106,211,239,14,110,198,33,170,18,36,247,248,250,190,135,101,238,27,239,45,43,181,90,208,87,208,254,178,200,110,105,103,110,67,187,246,134,123,117,158,246,41,149,180,72,34,134,163,248,251,29,52,24,173,119,37,135,46,139,200,128,5,134,195,147,126,215,193,130,29,174,159,200,74,13,37,46,10,185,249,119,178,10,204,191,218,50,110,72,199,26,74,24,93,88,229,79,156,215,36,2,2,83,251,176,192,232,127,52,234,9,153,78,11,240,242,187,235,255,209,14,122,102,109,155,152,209,122,139,163,158,237,13,21,182,208,21,32,252,0,24,125,154,219,198,135,52,141,224,242,89,194,99,77,62,148,186,228,173,71,88,125,125,113,162,189,253,239,227,175,30,192,183,143,6,15,160,24,15,240,108,121,38,210,221,225,63,121,142,57,12,242,209,159,107,54,30,46,14,78,57,157,152,158,61,243,244,216,231,217,51,80,159,205,194,153,104,195,89,223,67,19,210,54,102,220,62,47,109,31,93,79,153,161,194,134,26,158,169,250,245,186,101,194,210,72,187,242,150,248,111,243,141,164,188,17,239,237,119,59,203,67,86,52,106,147,51,149,156,39,51,95,159,66,45,3,141,243,176,107,75,163,121,231,205,136,181,139,85,48,61,122,167,46,87,111,42,162,0,237,119,8,163,171,75,50,63,45,110,203,79,36,82,90,18,55,232,111,223,204,46,96,92,209,119,145,39,37,93,98,113,192,7,160,103,32,44,190,38,106,73,62,195,152,162,87,101,186,154,241,85,78,28,144,102,53,190,164,224,214,36,157,74,227,190,211,204,245,35,149,207,23,204,251,5,71,202,230,154,84,161,233,106,85,6,95,174,26,135,243,47,103,155,187,215,5,206,25,177,14,179,141,102,245,124,216,199,152,57,97,225,48,160,232,131,164,158,174,42,112,95,58,69,193,219,74,115,247,148,96,46,142,176,154,107,78,68,172,219,48,197,74,188,254,184,143,72,199,193,143,1,124,208,112,225,196,199,124,245,160,232,120,196,230,234,255,45,24,92,71,104,194,160,99,138,234,205,177,222,178,251,98,64,54,28,230,190,188,117,217,26,12,135,110,214,58,2,161,113,76,159,229,174,17,161,239,226,247,217,130,160,223,251,197,217,8,150,175,4,212,213,127,82,83,10,106,237,126,2,240,253,67,226,71,149,64,67,31,45,124,207,240,184,103,181,16,24,218,47,23,182,137,143,81,240,221,198,192,123,242,167,142,176,163,156,224,34,216,11,159,222,239,190,244,71,200,108,23,50,176,41,33,210,18,129,1,236,175,30,64,91,60,19,145,227,246,57,185,19,255,71,147,231,43,47,189,5,67,150,23,125,79,49,151,37,198,143,16,81,132,254,154,167,140,63,130,204,155,94,240,173,55,169,60,214,240,242,168,117,232,17,94,162,133,94,132,182,222,187,249,23,172,170,230,5,46,95,55,188,80,51,216,123,175,13,67,35,214,52,192,208,119,79,11,222,41,134,90,245,22,7,255,5,130,118,11,245,135,8,234,66,107,29,63,195,254,64,160,65,17,254,203,0,235,88,69,18,57,35,203,57,161,145,121,145,223,74,19,78,132,200,58,226,107,127,119,19,182,117,206,10,33,107,32,186,223,171,15,210,171,139,169,88,148,38,82,6,40,52,48,170,189,232,141,192,103,209,242,0,205,192,218,255,0,143,226,226,127,182,52,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd0694cd-3334-8a6b-963d-c4b5031b2e17"));
		}

		#endregion

	}

	#endregion

}
