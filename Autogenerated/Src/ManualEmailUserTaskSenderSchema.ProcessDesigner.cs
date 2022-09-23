﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ManualEmailUserTaskSenderSchema

	/// <exclude/>
	public class ManualEmailUserTaskSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ManualEmailUserTaskSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ManualEmailUserTaskSenderSchema(ManualEmailUserTaskSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("085e9c61-efcf-4de2-a67b-20be42e3e075");
			Name = "ManualEmailUserTaskSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,26,219,110,219,200,245,217,11,236,63,76,84,96,65,21,42,179,233,75,139,56,113,224,139,156,21,144,216,134,37,119,31,130,60,140,201,145,60,13,69,106,103,134,114,212,172,255,125,207,220,47,36,109,57,221,2,125,137,197,225,153,115,191,51,53,94,19,190,193,5,65,11,194,24,230,205,82,228,167,13,35,249,21,107,10,194,57,60,212,75,186,106,25,22,180,169,127,252,225,219,143,63,28,180,156,214,43,52,223,113,65,214,135,201,51,192,87,21,41,36,48,207,223,147,154,48,90,120,152,144,198,122,221,212,253,111,2,130,253,0,140,12,157,231,103,39,131,175,166,181,160,130,18,62,8,96,68,238,123,255,17,211,42,159,147,186,36,12,94,3,192,95,24,89,1,127,232,180,194,156,191,70,31,113,221,226,106,186,6,176,27,78,216,2,243,47,26,90,1,111,218,219,138,22,168,144,176,195,160,232,53,154,245,98,56,248,166,176,56,154,192,231,134,48,41,202,107,116,165,80,235,247,134,140,188,14,74,172,181,21,210,199,111,104,69,196,33,226,242,159,7,125,239,229,203,151,232,13,173,239,192,86,162,108,10,244,242,40,192,118,219,52,21,186,32,164,148,120,102,181,32,12,107,68,111,143,144,96,45,57,52,188,1,175,154,189,152,215,143,68,220,53,165,100,148,209,45,22,196,112,170,31,16,23,96,229,2,109,27,90,162,57,17,87,152,129,59,2,137,147,221,49,16,217,82,177,203,148,70,22,100,189,169,224,130,213,12,106,205,143,9,178,128,8,155,31,19,73,224,224,128,11,38,77,184,177,40,47,224,207,24,125,83,47,149,39,236,230,197,29,89,99,240,215,118,93,163,66,255,121,235,208,228,250,117,174,223,243,252,156,214,229,201,78,98,201,98,156,135,10,37,93,162,204,226,120,139,234,182,170,44,177,3,70,68,203,106,13,246,160,254,109,110,255,13,214,48,52,255,133,171,150,132,132,223,19,113,234,223,24,172,29,50,250,218,139,132,150,213,75,46,181,169,221,100,167,209,68,76,79,66,218,227,128,181,135,71,237,99,117,125,77,214,160,141,69,115,121,15,241,125,6,128,89,215,10,232,113,195,89,142,165,64,142,105,133,111,86,230,51,62,93,111,192,246,227,71,116,232,212,101,46,129,6,83,60,135,93,10,154,243,19,178,132,120,151,202,251,217,81,112,248,34,225,0,171,113,114,9,179,197,12,109,116,146,56,51,9,234,10,130,166,145,196,179,171,190,23,227,94,202,250,157,65,74,107,129,154,229,18,2,18,176,252,237,21,250,43,234,189,99,160,165,182,23,116,77,16,75,109,0,183,79,48,39,134,13,171,240,27,65,43,149,245,242,227,178,188,84,100,22,141,50,153,119,116,129,153,144,71,19,195,135,137,160,131,94,81,141,183,12,232,203,48,210,97,110,216,197,148,111,157,50,2,191,93,204,199,105,240,35,240,128,87,82,176,45,149,105,114,29,63,187,160,126,212,223,128,169,228,94,30,17,57,244,56,12,61,11,223,115,19,34,52,132,204,140,78,18,41,204,173,137,247,249,195,61,229,239,99,227,57,1,245,34,206,249,146,223,25,63,7,18,45,35,211,26,223,86,164,204,70,55,206,87,192,176,224,97,107,194,142,57,167,171,122,77,106,49,242,161,231,66,155,168,172,9,234,184,188,229,77,5,169,100,63,121,131,164,4,46,168,132,56,22,2,23,119,146,14,207,52,214,137,21,51,15,222,117,238,79,191,146,162,5,138,75,72,99,150,236,28,111,201,188,96,116,35,12,42,123,171,155,50,28,158,152,113,93,13,44,251,189,70,114,58,24,16,253,191,49,152,76,42,54,152,64,185,53,185,119,228,178,216,142,70,50,31,184,68,156,145,101,80,43,120,150,130,168,188,248,190,165,101,126,65,238,229,223,14,196,98,183,33,10,202,18,5,122,92,112,29,29,242,229,141,77,164,238,138,17,116,232,230,101,43,86,13,212,94,135,193,34,240,197,169,213,5,208,69,150,61,73,121,163,162,34,67,80,189,249,214,100,176,189,179,178,202,125,179,58,76,200,221,188,248,220,204,170,253,47,137,193,211,150,49,112,80,121,170,42,188,126,180,233,60,27,251,176,177,76,77,34,97,198,251,74,253,106,15,177,227,243,68,238,179,150,252,89,245,164,67,208,148,150,136,223,113,79,157,118,46,5,104,86,13,219,245,180,4,131,176,3,190,156,130,89,175,76,218,137,46,88,216,89,164,111,83,151,185,107,238,103,181,236,28,203,182,82,221,131,55,106,252,42,185,120,77,10,178,161,224,16,129,183,47,26,57,11,21,88,204,150,23,141,208,226,143,14,71,105,0,159,54,155,93,223,245,211,98,175,235,39,21,84,234,33,28,39,197,158,72,154,114,23,94,131,199,52,17,241,95,196,186,50,112,190,165,10,114,153,26,129,60,142,115,214,172,53,204,163,141,167,239,55,147,170,115,78,171,42,112,3,19,134,124,248,130,99,197,120,252,180,34,178,10,197,246,239,38,195,227,170,106,238,73,121,77,120,91,137,16,20,130,92,31,26,136,56,67,127,160,245,23,203,222,162,49,36,135,153,115,88,103,220,11,5,133,5,74,145,228,111,137,43,78,18,72,11,167,4,8,10,130,6,211,213,209,157,15,118,38,67,106,252,238,134,127,54,173,91,104,53,100,19,242,70,207,104,71,14,71,64,64,150,45,111,247,144,178,209,136,236,137,161,81,64,153,25,244,186,56,16,173,251,48,187,4,98,166,176,77,56,38,37,6,140,71,168,46,50,219,107,12,38,73,240,93,221,94,132,19,157,87,89,23,227,36,230,39,156,205,158,71,133,187,100,234,201,244,246,54,70,127,129,182,85,217,125,98,240,238,157,223,32,73,235,14,173,116,74,150,221,13,39,149,174,246,217,92,253,26,203,30,71,255,76,59,156,220,140,30,7,90,146,108,164,120,25,185,115,153,21,178,145,101,212,159,255,122,71,24,201,70,179,18,142,128,139,223,90,92,101,26,69,238,150,10,221,234,50,43,199,113,183,104,88,181,141,230,188,192,21,102,214,77,179,200,24,230,66,218,211,244,105,184,207,229,135,156,219,232,205,96,7,69,125,250,108,85,9,98,23,77,11,189,185,41,162,35,184,8,189,178,127,254,64,112,233,30,46,55,155,134,137,182,150,106,178,103,179,26,98,186,32,30,134,65,206,117,79,224,94,82,130,8,61,11,241,159,53,69,171,134,3,123,112,77,126,3,71,19,220,115,64,185,0,241,66,148,202,151,61,206,59,92,175,72,248,30,148,178,14,16,86,4,122,14,15,238,31,30,66,205,238,177,109,106,4,200,66,74,107,9,243,136,182,20,148,130,43,157,220,250,147,240,119,167,54,217,95,195,232,43,115,190,246,189,155,56,247,38,27,37,112,1,179,80,26,65,203,36,90,14,190,235,234,139,137,202,162,169,75,42,93,3,138,29,6,92,131,41,64,45,141,2,216,36,176,38,41,95,105,82,72,219,213,153,173,130,245,138,214,68,54,123,230,64,154,88,174,117,123,106,85,174,240,70,44,239,133,92,154,193,156,44,26,51,141,197,187,156,73,71,137,145,8,80,213,198,207,115,143,238,214,84,237,57,77,220,63,111,1,49,177,86,209,183,193,108,50,114,200,87,185,224,83,127,255,204,13,133,242,49,92,4,165,189,39,171,105,80,37,17,135,182,211,240,5,237,190,94,103,68,61,105,244,50,184,72,123,27,141,199,250,144,224,178,101,112,250,21,188,133,7,49,160,150,123,174,147,28,163,159,126,66,47,122,40,249,137,224,125,213,220,226,234,120,179,129,26,39,85,203,115,179,199,128,222,42,88,24,235,146,167,55,101,215,196,152,49,110,228,128,150,41,22,225,160,5,97,39,23,182,6,84,31,228,83,198,26,183,87,234,168,67,141,254,229,19,193,56,75,225,59,1,25,70,141,173,66,82,226,72,85,3,122,210,40,29,135,3,155,39,183,33,51,216,31,130,242,165,214,68,177,153,28,186,189,176,37,43,21,251,101,224,87,42,238,164,164,153,241,253,73,226,11,147,174,71,142,163,142,212,183,178,15,221,248,180,14,226,34,237,201,207,3,231,109,93,188,209,157,222,167,207,19,133,229,8,65,89,175,228,108,107,202,140,90,141,115,100,161,252,55,3,62,176,163,241,0,159,126,254,140,48,119,243,166,247,91,15,221,251,53,32,236,216,19,77,250,125,118,186,226,62,252,63,107,160,7,190,216,116,251,206,190,70,247,127,209,217,118,135,31,55,150,5,147,182,60,233,172,164,250,231,42,63,168,42,247,99,22,155,117,160,44,112,149,238,114,46,236,249,71,233,84,57,154,104,191,72,174,129,10,142,75,24,114,175,233,234,78,101,206,192,81,60,110,188,117,75,103,227,79,154,181,158,184,209,251,101,92,23,164,218,63,106,142,149,137,92,220,124,71,196,60,94,241,97,142,111,182,46,195,164,157,69,79,69,75,154,12,205,69,178,229,209,66,146,82,39,113,159,85,7,141,21,43,202,207,65,46,59,169,70,106,191,222,207,220,166,181,220,164,171,85,215,101,61,23,100,3,22,252,208,0,7,244,63,50,96,231,10,74,150,64,48,253,37,211,217,61,200,161,201,229,177,150,243,93,60,147,70,53,15,102,158,244,214,104,252,46,95,52,154,20,148,142,119,239,140,104,185,34,167,81,190,70,195,84,115,133,56,106,67,177,94,97,196,81,197,159,40,129,199,189,151,210,58,56,176,204,115,214,83,13,15,88,14,130,198,16,155,61,85,123,175,98,232,164,151,140,226,198,38,50,182,133,185,8,28,167,248,178,128,162,245,11,169,96,108,129,16,102,84,90,206,110,116,15,228,220,106,75,174,250,58,54,173,110,58,251,33,251,245,236,160,6,51,133,239,212,135,215,240,182,149,37,145,206,193,80,30,53,150,164,60,217,205,233,170,134,233,37,253,214,9,30,53,0,154,18,188,72,152,210,215,35,214,72,240,117,220,128,251,137,219,65,49,82,52,107,72,101,37,214,255,27,160,187,64,112,33,226,5,74,93,205,115,247,200,247,132,240,75,132,187,128,157,87,21,13,43,135,26,97,47,147,13,105,219,154,7,224,211,228,157,55,32,60,92,5,86,30,69,7,42,74,188,62,112,184,7,84,45,111,175,251,27,240,135,40,3,245,255,7,140,79,246,99,83,54,250,71,254,234,159,249,223,209,239,102,130,129,110,20,213,141,144,245,25,164,64,184,46,209,61,173,42,116,171,62,11,67,102,45,213,171,13,88,72,70,239,109,75,171,18,166,203,207,65,182,179,9,25,122,113,186,164,48,212,232,109,87,120,148,169,222,41,5,60,66,183,254,171,128,61,76,214,22,61,16,217,99,3,154,62,141,15,31,254,0,29,119,188,124,154,36,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("085e9c61-efcf-4de2-a67b-20be42e3e075"));
		}

		#endregion

	}

	#endregion

}

