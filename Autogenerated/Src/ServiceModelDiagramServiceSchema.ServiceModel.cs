﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceModelDiagramServiceSchema

	/// <exclude/>
	public class ServiceModelDiagramServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceModelDiagramServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceModelDiagramServiceSchema(ServiceModelDiagramServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("301d84c0-554d-4891-b443-d01ee67136fb");
			Name = "ServiceModelDiagramService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,92,235,111,219,182,22,255,236,1,251,31,56,247,139,140,217,202,163,73,182,229,85,36,142,93,120,88,186,46,201,109,63,20,23,23,138,197,36,218,100,201,21,229,116,190,69,254,247,75,74,36,197,183,36,219,45,138,187,20,69,107,139,228,121,241,240,156,195,31,41,39,193,12,162,121,48,133,224,6,102,89,128,210,187,220,31,166,201,93,116,191,200,130,60,74,19,255,26,102,143,209,20,94,166,33,140,191,255,238,243,247,223,117,22,40,74,238,193,245,18,229,112,118,164,124,247,47,130,60,208,30,14,211,56,134,83,66,14,249,175,97,2,179,104,170,245,17,249,56,27,253,247,240,214,221,225,12,179,122,44,164,175,250,137,234,205,102,98,11,165,96,162,250,91,148,124,52,147,200,160,237,185,63,74,242,40,143,32,178,118,184,56,215,24,93,45,240,160,25,36,106,68,65,28,253,215,42,60,150,178,82,0,183,127,160,138,227,57,203,179,96,154,255,155,60,59,67,243,55,48,199,221,230,152,206,109,20,71,249,242,10,126,92,68,25,156,193,36,71,158,248,133,88,12,156,128,154,33,164,151,79,31,132,61,194,100,190,184,141,163,41,152,198,1,66,64,180,254,69,20,220,103,193,140,62,58,4,231,1,130,244,11,248,92,200,220,121,145,193,123,172,31,184,132,249,67,26,162,67,240,182,32,86,54,110,109,109,129,99,180,152,205,130,108,121,202,30,188,160,127,248,135,23,250,163,129,218,230,115,114,91,42,189,227,121,128,101,4,9,246,254,147,46,36,19,182,188,158,62,192,89,240,6,63,233,158,218,153,72,95,252,227,173,130,142,133,108,92,216,110,18,86,244,90,209,202,96,190,200,18,116,170,247,117,168,124,188,197,134,17,58,31,126,159,195,114,25,139,254,209,249,128,189,104,146,60,166,127,65,175,156,2,236,0,221,183,191,95,223,116,251,128,76,50,68,249,56,205,102,65,142,159,227,174,151,16,161,224,30,150,143,252,95,81,154,244,193,121,26,46,175,243,101,12,165,46,252,169,255,62,11,230,115,24,246,9,187,43,28,97,240,202,135,110,154,133,87,49,183,178,59,20,35,6,94,195,92,236,117,5,227,66,81,244,16,205,233,136,73,114,151,122,40,207,200,10,82,231,184,15,94,47,162,16,240,57,234,17,223,236,116,58,143,65,6,50,198,226,4,36,240,83,3,89,188,222,81,49,56,207,150,148,76,135,209,240,47,131,40,25,149,92,48,61,250,137,72,230,43,10,208,38,202,193,251,23,130,25,158,180,164,12,155,125,131,2,149,236,37,247,167,226,223,105,144,79,31,128,55,250,123,10,231,100,36,128,61,77,166,170,241,4,64,113,112,233,59,220,0,69,211,19,93,179,48,9,203,101,43,175,225,33,9,0,242,10,254,64,114,128,228,112,13,131,5,159,219,67,32,229,32,181,153,134,17,46,195,219,44,197,126,78,98,174,44,136,30,75,164,96,34,172,36,191,234,46,197,138,82,151,75,56,187,133,153,71,204,78,86,202,172,154,210,110,233,181,76,65,97,122,129,56,241,116,2,238,97,94,90,187,131,216,167,39,166,138,98,222,167,70,166,20,249,169,70,193,163,80,30,224,216,141,109,146,145,116,8,105,135,121,249,13,76,73,7,64,215,7,177,247,4,103,162,202,193,136,166,236,105,247,200,62,146,78,142,62,88,104,104,48,94,92,191,239,34,248,137,81,121,247,201,208,193,69,143,201,108,39,104,234,209,68,195,132,13,52,202,87,53,187,104,93,192,57,158,105,152,76,151,67,220,118,159,102,75,92,27,45,102,9,35,167,183,183,163,118,5,31,97,134,96,29,81,218,77,161,141,253,37,199,190,149,193,32,76,147,120,89,134,72,62,24,178,193,147,144,70,70,210,238,117,71,59,195,139,221,131,225,197,224,96,239,98,60,216,219,25,237,15,126,217,61,248,105,176,187,191,183,191,189,253,243,232,98,119,123,191,219,107,192,9,187,113,188,112,48,218,27,237,143,246,135,251,231,131,241,203,189,157,193,222,207,47,15,6,103,227,189,209,224,167,241,193,206,238,104,103,188,253,242,151,139,130,145,113,69,241,133,49,142,96,28,106,171,194,21,42,26,36,94,91,252,96,10,255,22,161,252,56,189,253,19,135,243,83,113,201,32,170,161,216,238,113,29,26,9,165,72,178,33,25,153,51,187,5,180,26,89,10,201,198,240,67,93,64,206,115,224,63,11,233,251,81,179,48,174,25,196,26,207,221,220,149,175,85,216,46,63,208,239,44,77,26,101,165,153,244,169,73,6,42,254,239,3,97,238,6,173,146,19,83,230,54,77,99,48,65,52,153,226,154,74,168,183,169,2,64,145,125,164,148,19,224,228,196,28,201,141,90,53,155,246,54,153,88,158,205,86,233,56,10,149,44,92,6,147,176,65,214,117,75,5,86,18,135,20,255,138,64,52,90,23,61,54,35,212,106,162,105,27,29,163,152,154,107,172,41,178,97,207,214,110,126,81,177,159,87,165,165,78,95,182,173,109,214,23,107,87,133,83,158,180,76,238,40,164,180,141,120,192,218,226,230,203,57,180,251,192,13,109,93,223,174,162,128,214,144,221,206,208,172,84,197,33,124,129,44,230,86,250,20,29,54,170,203,166,181,25,186,221,71,235,181,97,141,54,171,12,113,31,183,34,101,143,141,79,203,102,213,40,182,168,110,61,104,151,13,40,98,114,172,86,82,135,188,80,167,219,66,164,8,94,148,112,194,150,241,84,168,237,217,144,53,23,188,1,48,107,23,235,217,22,160,177,10,19,117,196,10,155,109,121,207,156,45,166,121,154,181,218,32,40,89,185,125,9,110,193,36,235,208,72,17,51,212,105,68,86,228,81,26,199,170,72,193,172,50,106,38,224,101,17,7,202,58,197,230,44,10,169,141,245,122,82,24,220,208,250,21,28,220,220,240,210,146,7,173,252,143,233,253,152,98,197,198,81,28,23,154,115,253,8,18,72,33,182,155,224,54,134,35,244,145,110,133,68,93,255,88,192,108,169,128,117,190,216,225,50,72,130,123,152,245,181,178,138,238,136,11,62,100,190,164,45,187,194,216,63,11,195,178,221,235,150,73,219,23,106,115,66,129,21,73,77,169,148,137,209,103,149,149,74,78,206,177,18,209,210,53,252,209,108,158,47,13,35,140,176,70,205,24,146,12,218,244,47,130,174,125,0,40,71,68,119,192,251,193,176,43,226,51,220,113,104,89,107,58,217,102,29,167,250,14,98,28,229,49,147,211,44,227,32,69,250,90,200,232,6,115,208,41,58,203,132,158,132,37,81,184,177,129,194,107,152,151,46,174,65,215,28,161,46,166,132,17,192,107,105,17,199,61,101,99,42,51,148,34,9,225,64,116,164,130,190,11,112,220,63,46,39,254,212,147,87,16,227,199,183,7,78,26,100,39,113,234,233,43,72,148,218,237,72,106,185,233,230,71,34,233,169,103,117,190,31,65,151,212,28,71,10,109,9,20,107,76,221,224,143,22,250,101,69,214,134,182,226,156,22,186,180,66,106,67,88,117,87,153,50,245,141,235,224,17,94,67,114,172,12,67,195,57,10,242,38,97,31,24,167,109,5,12,192,114,238,104,43,55,173,57,71,203,209,194,174,209,118,74,104,218,234,201,199,133,58,89,4,131,108,250,192,0,238,2,199,99,244,43,114,4,121,178,109,210,129,149,141,124,44,217,214,48,242,249,164,12,61,74,117,93,117,58,86,1,235,133,30,94,81,136,84,118,195,241,69,2,46,13,170,155,114,58,90,55,159,91,79,5,196,196,78,153,149,67,165,0,108,130,235,94,153,142,97,14,157,184,156,192,100,66,87,84,21,155,145,28,217,45,194,24,228,125,195,163,105,91,98,100,173,250,101,137,98,168,78,232,12,215,144,166,201,188,60,27,246,186,159,183,159,124,185,92,233,219,236,218,19,153,242,253,208,146,161,25,53,124,133,115,18,50,66,87,67,166,72,207,80,86,32,76,71,222,112,8,198,202,67,14,223,141,25,24,78,145,122,43,84,119,224,91,47,239,214,172,238,20,43,26,22,31,241,230,149,235,189,102,228,87,172,0,155,17,95,165,38,108,70,217,93,37,222,69,113,78,66,104,109,192,51,159,30,31,26,2,33,101,34,10,57,46,184,32,34,172,71,181,19,155,135,25,196,182,45,59,189,143,242,135,183,36,147,65,50,194,27,83,249,102,56,187,69,40,77,138,85,51,250,184,8,226,190,38,123,81,192,138,203,167,236,80,115,146,107,170,60,168,231,118,94,53,58,184,165,157,15,157,103,198,95,217,42,46,81,250,66,82,150,236,149,209,92,204,17,26,225,68,81,204,249,158,88,112,27,210,56,248,65,221,51,88,58,250,195,116,65,174,219,156,128,237,170,111,117,185,69,150,134,173,11,234,189,133,196,6,154,95,34,121,219,231,109,253,9,99,28,58,78,93,250,38,85,253,155,244,44,203,130,165,215,235,245,244,165,13,121,14,167,87,58,149,200,193,247,129,85,15,165,158,98,68,239,82,172,25,185,172,84,58,201,52,205,66,16,37,58,131,106,14,139,90,130,108,37,202,222,142,173,132,82,19,249,166,29,138,160,13,171,4,5,8,204,82,98,244,69,12,140,239,80,29,242,176,29,170,86,90,21,50,245,248,68,73,251,187,169,140,243,227,9,56,146,151,178,47,108,109,29,204,229,173,173,84,126,249,98,237,231,40,61,38,141,236,237,42,91,140,198,103,122,240,147,38,81,105,178,116,109,210,48,123,189,106,98,116,91,13,88,42,207,72,29,182,39,165,21,127,178,57,107,139,19,174,191,1,58,168,53,118,83,232,64,99,210,110,78,155,99,8,26,35,14,38,52,102,226,6,19,52,6,21,170,208,152,131,27,85,224,241,191,22,87,224,43,144,224,11,213,114,180,225,12,36,241,200,25,71,140,240,74,128,117,230,168,117,17,139,186,171,210,255,84,192,162,249,125,106,55,94,33,73,191,46,76,241,88,221,49,116,86,206,198,107,142,135,206,91,144,66,105,134,196,3,155,13,85,232,155,4,89,30,237,152,10,75,237,78,225,197,75,168,231,93,44,53,191,210,122,222,93,29,65,17,89,175,133,158,72,58,56,145,147,51,156,133,110,23,57,116,107,75,241,17,162,231,4,141,163,36,136,187,6,90,155,70,97,36,115,60,35,48,155,68,96,190,117,0,102,221,243,181,134,203,98,83,16,140,141,254,102,48,24,27,245,13,128,48,54,210,27,66,97,196,48,121,38,133,201,51,22,64,190,220,78,149,1,29,78,220,229,139,111,148,255,31,145,13,102,217,245,161,141,6,121,244,43,96,25,207,80,198,106,80,134,122,245,228,25,195,120,198,48,154,97,24,238,252,254,12,98,60,131,24,95,27,196,248,54,160,139,175,134,41,24,39,79,131,22,74,187,203,0,195,29,159,195,34,19,170,248,3,110,230,175,120,25,239,71,212,214,50,98,1,196,222,20,51,87,15,138,40,184,124,16,185,139,112,132,241,198,135,139,110,245,154,218,161,202,70,169,28,137,195,94,5,201,61,244,52,168,70,52,165,164,145,86,126,74,68,44,247,83,68,106,102,133,56,89,186,82,224,10,43,68,3,194,236,14,7,26,175,16,94,106,216,22,72,195,155,199,19,36,188,253,76,205,196,73,106,111,189,153,110,237,26,111,40,23,55,117,107,67,155,252,98,127,159,189,40,164,75,196,221,190,68,235,29,29,248,101,54,41,236,85,247,26,141,151,23,69,95,52,14,107,113,33,186,249,171,116,230,235,208,186,79,24,38,183,121,36,133,214,219,233,77,241,222,90,79,171,13,186,43,105,168,134,94,246,210,83,241,50,168,16,229,44,161,151,253,56,131,237,122,124,53,195,213,111,46,20,43,124,149,223,122,40,233,218,156,166,133,23,88,210,218,26,153,84,126,241,85,153,66,133,95,157,35,252,195,93,73,121,229,120,161,184,130,193,211,74,199,178,248,155,242,78,50,78,157,198,151,148,107,142,190,29,254,199,139,216,234,141,9,67,3,63,118,144,122,72,187,228,8,199,69,97,143,236,235,239,34,145,58,25,39,211,170,86,85,95,245,233,9,120,9,249,21,37,157,51,27,42,87,66,106,29,142,204,5,44,237,182,82,86,150,61,74,106,89,33,222,42,149,141,118,50,230,58,24,107,178,132,196,66,74,34,238,175,78,63,131,88,161,191,144,108,35,109,65,153,41,203,33,0,200,29,149,110,64,126,38,216,148,74,32,46,79,254,174,143,236,38,206,202,25,148,216,156,171,128,6,10,124,103,120,175,238,196,90,205,155,126,96,163,175,151,239,82,193,206,222,111,208,94,126,179,179,49,252,186,70,51,46,53,63,81,163,60,198,79,241,223,255,1,139,41,247,132,87,78,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("301d84c0-554d-4891-b443-d01ee67136fb"));
		}

		#endregion

	}

	#endregion

}

