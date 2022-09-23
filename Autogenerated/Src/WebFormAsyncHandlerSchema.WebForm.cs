﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebFormAsyncHandlerSchema

	/// <exclude/>
	public class WebFormAsyncHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebFormAsyncHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebFormAsyncHandlerSchema(WebFormAsyncHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dca1436f-2ac8-4592-b68e-c3189ff10c2c");
			Name = "WebFormAsyncHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("562f1acd-62c8-4466-b19f-73d792872a6e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,25,219,78,219,72,244,57,149,250,15,83,239,170,114,180,145,121,7,2,106,185,116,179,130,150,45,161,125,168,86,104,176,79,130,183,142,29,102,108,104,90,241,239,123,230,234,153,177,29,232,246,133,216,51,231,126,63,166,164,43,224,107,154,2,153,3,99,148,87,139,58,57,170,202,69,190,108,24,173,243,170,124,249,226,199,203,23,163,134,231,229,146,92,110,120,13,171,189,224,29,225,139,2,82,1,204,147,119,80,2,203,211,14,204,89,94,222,117,14,231,183,12,104,134,7,201,156,242,175,188,189,119,101,89,173,170,114,248,38,249,139,15,93,59,74,36,167,121,1,179,213,186,98,245,211,176,82,5,90,67,246,25,110,78,43,182,186,4,118,159,167,208,143,200,6,207,147,147,178,206,235,28,6,212,66,128,11,86,165,192,157,251,101,81,221,208,98,119,87,171,118,86,45,151,120,140,247,8,241,27,131,37,74,71,142,10,202,249,46,209,178,189,225,155,50,253,147,150,89,1,76,130,237,236,236,144,125,222,172,86,148,109,14,244,59,242,185,207,51,224,228,1,110,200,2,177,8,167,247,64,110,5,154,48,190,65,219,9,240,246,57,0,45,120,69,82,6,139,105,52,100,175,153,150,69,139,17,145,29,65,96,221,220,20,121,74,82,33,110,159,180,100,151,4,136,136,36,66,205,106,122,154,67,145,161,170,23,44,191,71,119,72,245,70,107,245,66,68,224,84,101,177,33,87,28,24,202,83,170,0,36,215,141,247,190,231,99,241,26,69,78,91,228,25,154,152,92,23,248,103,74,240,241,156,150,116,9,12,35,160,22,182,7,22,71,40,226,188,250,112,243,47,146,139,198,154,218,111,80,102,74,70,253,110,92,131,9,80,179,38,173,43,198,53,95,101,132,30,245,227,64,110,95,236,49,145,150,24,5,218,160,148,29,245,70,163,199,95,227,53,177,126,80,9,114,65,25,93,113,157,4,21,35,121,223,233,68,138,103,16,117,32,107,118,252,148,10,19,108,200,66,253,78,72,155,125,232,247,133,243,242,83,122,142,60,50,83,143,144,107,136,33,247,160,148,107,96,34,35,69,76,85,53,146,134,204,196,135,126,37,66,157,99,90,211,246,65,73,184,132,90,9,193,245,195,163,31,89,158,108,215,29,209,28,6,46,160,247,98,25,233,167,17,131,186,97,165,79,141,28,30,170,203,81,236,159,79,9,70,173,75,47,30,143,149,196,143,70,110,242,131,132,56,247,180,104,96,143,60,246,104,20,150,193,79,180,200,51,25,17,215,15,193,73,160,226,48,102,231,96,80,231,144,133,171,119,231,110,74,74,120,24,102,27,7,225,213,107,152,30,162,91,140,19,148,46,139,174,223,3,131,132,208,193,235,83,70,48,112,135,135,36,14,207,148,234,62,193,80,223,73,199,238,219,44,208,82,238,209,255,89,185,37,11,145,87,148,110,170,170,32,151,77,42,170,68,152,80,182,54,7,137,165,48,177,160,138,206,120,194,88,197,206,17,27,235,243,207,17,56,249,150,194,90,22,149,246,233,121,4,134,116,61,135,250,182,26,108,76,94,74,119,82,82,179,190,167,126,29,212,110,244,96,195,160,85,178,186,88,137,122,144,115,198,230,18,91,186,180,18,249,99,74,98,142,178,3,155,16,202,150,124,76,166,7,38,178,46,161,150,64,151,216,8,27,30,139,235,196,152,21,195,75,190,91,59,153,155,73,112,110,130,167,71,34,28,5,155,85,169,251,193,47,137,227,51,209,25,49,84,242,141,241,239,171,60,19,141,92,18,181,214,22,13,62,81,71,191,71,242,119,151,252,112,35,234,49,105,131,67,92,153,231,199,104,188,141,139,14,232,88,199,40,79,111,97,69,223,227,64,61,33,239,26,4,209,9,53,203,60,183,235,190,34,230,86,116,187,248,73,112,194,204,49,53,191,67,108,186,142,214,94,74,126,12,55,205,82,72,46,253,76,126,180,124,30,73,206,197,112,38,138,94,66,206,48,113,81,14,84,192,50,70,197,196,3,193,164,167,120,238,242,222,166,219,213,26,17,192,86,139,143,77,1,60,30,174,234,247,182,172,56,122,102,57,167,55,5,124,132,5,48,96,23,21,230,226,6,245,181,26,30,38,149,180,49,63,76,250,64,199,98,8,251,36,10,208,7,118,12,11,218,20,117,172,141,146,47,72,220,139,98,162,202,202,147,28,43,176,147,111,24,47,37,45,174,88,161,165,86,67,6,14,107,224,20,194,62,83,4,17,170,93,189,210,49,170,57,154,202,134,51,9,206,203,154,164,87,178,166,6,69,221,181,33,58,232,131,173,140,39,78,49,3,155,150,90,154,246,106,218,94,42,190,1,209,149,155,106,189,66,96,81,209,238,22,62,139,221,176,22,7,179,108,40,212,117,81,146,161,170,51,3,197,9,106,90,226,66,153,225,251,52,47,179,25,14,210,180,76,225,237,70,132,121,92,226,159,106,17,59,146,140,157,88,48,212,177,134,54,69,49,30,168,45,97,248,158,165,223,175,234,188,144,27,154,28,248,211,239,151,210,198,50,232,226,72,9,245,190,170,79,171,166,204,36,165,104,162,71,144,104,219,192,28,77,66,53,141,176,186,138,185,173,87,53,2,177,231,200,89,83,181,129,227,92,162,225,38,182,175,220,62,209,109,240,192,164,128,49,67,34,50,250,212,226,39,120,126,66,211,219,56,147,196,108,153,109,57,124,17,55,137,176,231,63,200,76,190,168,46,175,100,210,228,133,84,242,152,63,91,34,5,254,37,154,101,145,160,236,197,72,50,175,148,105,67,96,99,70,15,103,11,188,32,39,65,131,170,217,234,55,145,57,237,4,135,181,84,90,149,53,238,35,173,177,200,171,32,96,134,65,135,236,106,4,219,106,84,107,85,229,113,39,102,0,171,18,39,235,246,81,25,251,45,229,208,27,89,241,216,126,155,104,241,117,248,79,180,195,76,128,116,199,132,207,121,125,171,8,198,45,75,199,82,186,136,89,115,184,13,78,178,56,76,84,111,107,115,125,184,118,234,69,219,205,239,191,27,192,157,16,51,77,123,93,228,249,145,178,180,153,23,248,221,243,214,98,17,159,192,239,180,189,58,76,226,167,171,204,132,68,97,65,208,253,112,132,132,147,55,89,166,38,153,24,3,26,16,125,145,167,178,105,104,73,147,203,13,55,143,87,24,190,253,168,71,178,51,107,29,7,96,230,155,53,36,74,180,171,220,18,210,227,14,194,246,149,102,89,113,177,172,177,90,216,240,3,243,248,104,177,98,191,44,251,101,90,165,101,215,154,79,57,167,127,36,149,248,106,54,153,10,66,162,154,42,147,119,23,145,48,118,68,224,25,220,32,29,181,13,132,220,201,201,106,93,111,194,186,153,115,79,113,193,92,82,18,252,133,89,181,141,101,61,223,23,27,200,193,128,75,4,49,110,92,176,157,140,144,230,64,121,237,218,122,173,13,0,65,73,171,120,98,44,242,243,61,15,35,42,182,242,56,134,242,40,203,100,20,70,139,206,128,102,17,121,253,154,188,10,44,242,124,83,174,149,143,145,241,179,212,239,205,137,235,54,39,174,157,156,16,130,187,228,167,142,24,207,19,112,102,34,176,92,230,37,24,89,245,91,215,190,30,244,158,79,225,27,164,141,152,88,215,193,251,212,167,154,4,240,173,115,243,114,221,184,197,251,169,246,104,20,180,189,78,165,222,214,30,217,179,247,4,242,38,234,193,248,163,53,47,150,53,237,123,228,49,9,165,29,158,243,176,32,157,154,73,66,205,63,122,222,148,157,85,149,125,125,34,219,140,191,199,58,227,203,208,96,50,175,206,114,94,199,78,154,184,77,86,126,204,107,155,109,206,120,221,78,253,11,209,112,23,178,189,38,39,119,13,14,216,177,149,202,29,3,125,130,65,49,113,200,163,174,177,92,182,61,9,237,178,56,26,149,50,177,28,213,221,102,111,62,139,248,173,125,104,32,243,21,155,87,111,24,163,155,184,167,111,62,253,173,193,249,168,18,126,227,151,7,234,179,13,39,245,45,168,111,252,114,14,177,224,59,33,252,190,28,2,136,80,118,26,153,197,48,58,152,123,232,251,59,18,234,192,249,158,34,227,69,49,19,74,219,1,203,46,182,221,165,168,93,179,44,240,212,130,171,11,191,91,225,181,249,162,5,197,90,125,144,183,179,98,108,25,117,42,35,166,145,142,16,167,198,252,159,133,64,123,188,111,47,184,42,191,150,213,67,105,197,81,149,16,204,166,103,119,4,187,36,152,127,139,252,204,90,208,187,128,119,62,226,181,201,36,76,50,171,97,213,110,183,31,129,99,242,180,134,180,88,137,126,130,184,175,23,191,26,162,148,40,119,182,198,236,91,121,195,157,119,144,216,185,187,12,135,219,240,208,158,228,213,75,162,251,200,123,120,16,191,6,53,92,88,131,93,181,87,229,112,240,237,114,239,150,199,160,156,79,6,139,185,102,36,254,191,153,124,108,202,56,118,63,127,57,117,80,106,244,212,76,231,140,115,254,36,167,237,230,148,65,164,247,170,183,213,246,41,227,246,12,139,223,85,66,91,99,228,7,118,210,83,12,76,133,243,58,78,80,227,212,169,127,136,103,255,1,15,32,236,230,145,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dca1436f-2ac8-4592-b68e-c3189ff10c2c"));
		}

		#endregion

	}

	#endregion

}

