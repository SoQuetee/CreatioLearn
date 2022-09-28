﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserAdministratorSchema

	/// <exclude/>
	public class SspUserAdministratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserAdministratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserAdministratorSchema(SspUserAdministratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2");
			Name = "SspUserAdministrator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,219,114,219,184,245,89,59,179,255,128,104,95,168,25,15,221,231,56,114,87,150,157,84,29,199,246,88,241,230,161,211,105,97,18,178,216,80,164,150,32,237,104,61,254,247,158,131,11,9,128,32,69,37,238,110,103,218,23,91,4,207,13,7,231,14,102,116,195,248,150,70,140,124,98,69,65,121,190,42,195,121,158,173,146,135,170,160,101,146,103,225,114,121,243,227,15,207,63,254,48,170,120,146,61,144,229,142,151,108,115,226,60,3,78,154,178,8,17,120,248,129,101,172,72,162,94,152,235,251,127,193,207,143,121,204,210,22,220,101,146,253,218,44,154,114,109,54,121,230,127,83,176,174,245,240,252,172,243,213,69,86,38,101,194,184,15,224,51,187,111,113,148,2,46,89,89,194,19,39,83,34,168,56,250,218,113,13,0,136,128,250,83,193,30,224,5,153,167,148,243,183,100,201,183,119,156,21,179,120,147,100,9,47,1,43,47,4,220,241,241,49,121,199,171,205,134,22,187,83,245,44,112,200,42,47,72,84,48,138,68,73,148,103,37,141,74,66,179,152,84,64,136,135,26,247,216,64,78,178,146,21,25,77,73,36,40,248,152,146,183,100,225,23,102,244,44,4,170,37,191,41,242,45,43,80,81,111,241,119,9,39,199,98,9,226,10,45,22,144,36,202,153,201,211,14,107,64,83,194,209,86,83,18,240,243,26,220,125,124,38,15,172,60,33,47,146,225,182,72,30,105,201,200,135,42,137,201,63,56,223,222,230,121,249,161,200,171,237,34,62,233,145,105,150,166,100,155,23,37,168,68,104,141,60,32,206,94,209,4,155,165,197,133,160,51,140,70,32,20,153,10,232,209,200,145,131,188,153,10,196,240,98,179,45,119,18,100,244,103,87,90,181,254,214,93,7,179,178,53,0,14,85,226,123,113,74,119,89,162,1,3,4,251,180,219,50,244,209,201,137,160,199,133,84,30,146,143,52,173,132,143,140,94,122,180,4,198,43,185,148,73,42,60,67,218,207,94,53,181,241,218,43,246,57,254,196,178,88,154,151,109,107,176,109,176,195,42,2,67,4,107,219,86,247,105,18,245,8,188,0,117,36,52,77,126,3,6,148,100,236,137,36,128,79,51,8,104,249,138,148,107,6,40,140,161,247,172,166,99,159,181,143,143,79,251,247,40,36,240,58,80,224,24,106,101,61,78,148,157,56,64,83,7,76,30,91,91,91,83,177,153,214,122,48,49,207,176,75,137,31,89,185,206,99,116,86,225,44,61,250,155,99,88,1,118,166,150,52,79,80,45,106,167,96,81,94,196,29,234,17,43,91,90,208,13,201,32,149,76,199,42,60,45,226,241,233,92,69,170,36,102,16,103,87,9,43,194,119,199,2,214,143,138,127,199,167,34,120,224,207,126,96,26,69,121,149,105,3,31,159,206,228,179,116,235,94,150,5,43,171,34,227,146,145,5,168,223,180,226,140,212,18,34,4,226,185,222,228,17,1,91,192,168,140,66,29,73,96,91,50,109,6,166,86,9,55,31,32,86,176,242,138,61,33,121,19,42,48,184,72,242,14,101,229,241,6,74,184,164,143,76,153,200,72,238,198,226,21,138,24,89,155,143,222,227,99,94,239,209,20,96,145,221,230,41,147,59,70,163,69,65,196,67,1,203,205,206,30,105,209,48,65,48,129,230,26,112,67,207,9,110,179,237,214,120,146,25,214,6,113,55,90,243,8,33,209,158,179,21,212,21,213,38,251,5,3,156,246,15,47,176,41,74,172,28,81,41,100,31,252,173,216,49,224,200,173,119,227,52,250,239,214,177,29,199,185,71,193,126,19,170,79,168,97,24,104,52,59,69,41,37,244,33,120,109,169,211,6,134,177,233,194,146,255,135,66,251,36,115,148,217,84,146,239,164,255,157,162,15,93,38,209,13,141,190,208,7,198,175,192,95,2,21,179,23,217,99,2,56,130,124,182,202,181,54,147,21,9,244,26,148,156,17,203,56,67,180,112,193,175,242,242,170,74,211,235,66,228,239,96,162,81,180,75,161,97,123,68,120,38,62,122,228,69,238,251,197,116,202,86,92,15,45,249,17,143,59,142,114,68,218,233,126,80,26,176,139,182,142,60,0,236,45,95,37,185,40,208,49,137,226,110,113,99,223,145,1,176,128,173,201,12,200,1,66,111,192,154,139,104,64,104,147,117,113,91,82,180,195,210,3,56,47,208,83,5,160,122,217,157,26,122,178,161,71,47,110,226,208,69,209,99,82,148,21,176,179,244,218,17,235,191,53,173,56,213,5,247,132,207,118,61,185,63,228,158,180,35,187,76,85,110,76,15,124,28,189,153,105,127,168,70,48,113,242,83,177,111,207,219,185,86,16,128,212,202,242,49,51,30,208,99,4,67,192,9,160,45,154,184,47,67,20,222,67,100,6,123,121,68,44,40,71,59,132,81,251,69,42,154,186,233,164,126,201,230,85,10,214,34,211,137,221,80,98,16,16,162,182,92,127,12,149,28,122,156,194,29,31,25,253,133,79,141,55,194,208,85,77,36,56,217,230,35,81,64,94,178,161,95,111,160,250,125,130,18,111,246,192,122,68,242,29,52,8,246,209,194,7,193,254,164,228,193,248,234,16,63,133,151,58,148,218,226,42,160,139,175,219,164,96,231,24,226,167,4,255,125,74,32,32,223,149,209,85,254,20,206,226,248,156,238,184,67,116,226,137,174,38,109,29,39,7,20,203,251,122,13,93,43,91,254,124,72,100,212,233,1,2,156,138,29,170,173,7,41,98,90,210,111,174,85,101,143,162,227,141,8,23,183,176,57,56,176,66,20,173,253,153,208,168,63,112,164,209,212,186,117,58,155,55,129,169,94,67,136,43,17,158,234,37,199,234,172,132,239,22,61,86,109,128,200,179,222,130,196,83,193,88,146,224,27,62,233,104,166,194,91,150,230,52,54,207,109,78,163,117,219,205,236,66,165,157,225,183,70,122,150,117,187,91,115,212,186,109,156,192,66,122,3,177,13,74,139,218,13,218,178,130,153,163,88,162,130,136,90,85,192,128,216,173,183,113,164,6,12,38,127,159,183,24,101,112,223,104,0,54,203,117,20,105,119,89,3,61,128,106,219,104,26,182,33,173,90,79,115,183,207,15,64,108,101,82,103,187,218,50,3,51,163,118,116,50,96,36,75,134,6,160,179,158,120,112,142,99,18,202,140,22,140,151,179,59,8,126,99,216,217,36,124,95,228,155,192,174,28,38,225,140,75,160,137,60,150,240,243,154,21,172,198,179,147,9,128,47,248,197,175,176,137,64,210,15,197,88,36,104,101,152,137,166,54,203,226,154,150,55,251,213,124,187,9,183,230,166,173,60,26,94,23,15,20,42,49,17,178,188,188,157,16,208,181,145,70,245,19,66,185,210,109,103,219,42,95,135,23,95,89,84,65,52,136,104,74,139,119,120,132,167,118,175,213,109,183,185,144,251,55,25,106,83,89,156,203,33,195,127,214,112,47,77,86,94,99,85,133,158,12,37,186,103,120,61,251,84,71,164,173,244,250,6,15,201,224,84,155,197,32,155,93,0,221,226,175,121,130,148,12,141,170,249,240,78,97,0,19,141,112,93,243,180,187,111,195,46,76,207,249,191,107,188,138,107,168,116,53,192,57,160,204,35,110,173,88,230,118,133,115,216,252,143,106,60,254,41,191,219,66,85,3,237,156,73,142,11,56,14,229,187,206,174,131,26,57,116,60,75,80,242,180,78,162,53,121,74,210,148,220,51,125,219,192,132,248,56,246,85,82,155,180,117,122,192,73,204,89,146,197,22,61,56,41,81,240,171,218,135,159,237,132,35,94,66,17,85,167,255,246,222,236,222,172,241,84,204,251,109,104,48,7,115,154,224,186,179,4,82,238,44,31,218,141,128,227,161,159,147,114,253,23,176,80,30,32,210,109,254,116,153,71,95,112,33,208,54,56,194,214,43,104,89,223,17,233,178,58,9,47,187,31,23,12,91,33,128,80,14,106,6,16,12,14,218,144,111,80,229,12,138,79,238,81,130,52,107,249,251,164,221,11,40,77,41,131,14,204,130,165,207,144,245,217,137,86,151,147,251,29,89,196,93,35,253,111,176,89,32,214,101,177,166,85,57,22,4,88,210,128,68,174,242,152,207,127,175,185,244,29,191,5,248,62,47,34,54,95,211,236,129,233,174,204,197,90,209,148,27,104,202,120,100,4,252,35,109,102,190,102,209,23,2,186,183,194,29,251,10,39,54,212,114,246,94,89,232,140,111,177,24,90,192,222,231,121,42,165,92,172,68,187,149,151,23,40,93,96,76,135,254,55,106,215,239,75,205,200,213,203,77,6,48,63,113,161,220,239,173,78,201,212,188,9,222,155,142,245,132,65,207,77,15,25,46,176,13,77,210,241,169,248,231,253,98,96,112,158,61,164,192,245,222,241,237,235,201,228,54,21,234,217,238,2,69,214,54,45,228,239,74,171,104,228,250,251,135,214,84,83,124,204,177,91,66,95,191,161,31,105,6,45,111,129,211,171,133,186,15,86,9,125,172,216,194,177,75,49,36,154,235,27,242,180,181,230,186,135,151,6,132,241,58,24,139,61,129,137,137,237,236,129,53,147,50,117,134,39,93,56,194,114,21,249,240,146,173,202,235,213,109,242,176,46,55,57,135,159,193,248,231,241,100,15,5,241,213,74,177,97,200,85,70,104,7,30,175,178,204,23,202,244,245,123,61,145,108,104,14,52,111,113,135,38,44,244,224,217,89,60,246,76,194,122,140,186,82,147,33,133,134,140,189,185,91,25,167,125,15,106,140,156,218,55,116,154,242,144,187,57,136,192,127,251,187,186,29,18,87,163,47,251,11,115,29,9,80,100,254,251,42,139,27,218,226,175,163,46,216,126,77,93,107,12,246,196,40,84,240,129,165,79,146,100,109,208,145,233,218,164,164,247,41,83,191,191,53,8,88,242,142,149,129,43,54,24,220,173,123,108,131,225,128,152,49,58,79,196,35,28,142,106,28,142,212,165,209,41,250,78,156,136,15,224,84,98,238,129,85,91,31,61,19,45,237,88,79,246,200,203,145,245,82,108,226,200,176,47,249,86,93,60,138,234,242,141,181,169,240,61,43,163,53,166,250,243,179,160,17,170,169,53,71,54,120,119,252,115,33,225,167,72,140,34,24,225,46,69,4,209,176,230,233,72,106,234,107,24,241,211,209,180,88,20,23,16,206,169,213,231,229,163,135,86,123,0,61,235,252,219,187,54,35,102,35,105,104,44,27,35,240,120,24,157,70,66,63,29,17,86,58,40,25,159,119,168,33,238,222,42,247,28,202,147,63,58,232,238,15,35,82,202,67,163,238,239,19,23,94,37,44,12,119,147,215,141,31,125,225,163,47,122,188,52,23,24,135,133,14,27,90,158,235,240,54,62,142,213,60,170,190,106,40,115,231,218,94,222,2,188,90,107,159,196,255,52,123,251,131,190,42,176,39,82,242,118,226,251,230,82,234,246,7,164,181,104,11,142,253,179,132,222,207,4,234,100,139,21,52,109,26,209,172,103,40,225,173,105,106,240,142,47,136,186,63,239,217,135,57,160,93,199,33,3,151,247,166,84,78,90,196,55,15,37,45,171,193,179,158,111,10,105,9,87,243,144,230,226,182,45,64,215,145,74,185,145,223,172,198,89,10,20,59,194,137,110,95,115,50,59,158,234,240,65,143,234,117,189,163,156,122,210,18,212,204,38,230,80,198,63,12,111,176,84,174,107,141,100,42,223,20,198,255,133,146,92,181,23,97,237,223,90,132,32,118,141,48,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2"));
		}

		#endregion

	}

	#endregion

}
