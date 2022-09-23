﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UIMenuUtilitySchema

	/// <exclude/>
	public class UIMenuUtilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UIMenuUtilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UIMenuUtilitySchema(UIMenuUtilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8bc88c7e-c979-41ae-a3ae-b2a602ee6e90");
			Name = "UIMenuUtility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,91,91,111,219,56,22,126,246,0,253,15,172,23,152,202,173,71,110,186,216,151,166,41,144,164,153,174,103,167,73,80,59,237,67,183,24,48,50,237,104,34,75,30,138,182,155,73,253,223,247,28,222,68,73,148,157,107,183,45,154,135,216,34,121,14,207,245,227,33,69,167,116,202,242,25,141,24,25,50,206,105,158,141,69,184,159,165,227,120,50,231,84,196,89,250,224,167,203,7,63,181,230,121,156,78,200,224,34,23,108,186,93,121,134,241,73,194,34,28,156,135,175,89,202,120,28,213,198,244,143,106,77,111,217,88,147,21,93,174,16,211,105,83,15,103,190,246,147,126,248,158,157,130,240,130,103,73,190,121,68,232,12,133,193,255,224,108,2,178,144,253,132,230,249,115,242,234,34,165,211,56,122,195,210,57,140,203,5,159,71,34,227,114,228,108,126,154,196,17,137,112,96,227,184,214,165,28,107,217,190,97,226,44,27,1,227,99,30,47,168,96,68,117,207,244,83,46,192,218,209,102,89,67,156,168,15,230,35,175,153,48,223,131,70,178,99,58,97,131,232,140,77,233,73,206,184,110,38,51,104,237,194,148,28,205,51,5,38,71,75,240,218,126,18,179,84,244,95,117,81,174,86,75,119,131,118,197,216,136,206,208,95,93,162,57,245,167,192,137,68,206,67,49,20,76,116,190,159,141,88,135,92,74,134,11,202,229,92,82,248,29,146,178,229,53,180,13,58,219,146,137,97,16,238,115,6,102,27,237,93,236,254,73,63,1,59,176,59,171,12,57,72,233,105,194,222,197,108,57,16,104,226,29,50,166,73,94,29,117,8,250,161,56,240,81,233,57,233,143,160,227,245,60,30,133,135,108,137,159,53,41,134,116,2,67,172,170,85,25,149,181,112,132,250,86,233,87,214,219,41,217,79,197,98,171,197,153,152,243,212,26,76,82,174,100,60,177,116,164,66,170,41,190,100,116,234,232,82,145,170,131,107,145,197,35,162,188,252,150,77,179,5,51,214,221,187,64,43,220,113,20,17,39,128,220,24,200,35,30,207,4,168,173,250,195,131,233,76,92,40,203,232,174,39,182,239,215,140,79,169,8,218,72,39,40,159,48,209,79,71,12,253,125,249,116,21,78,84,6,4,157,48,6,37,242,48,198,190,163,241,127,216,69,240,232,114,107,245,168,179,77,254,155,182,187,62,217,164,80,213,73,219,241,152,4,238,52,15,119,200,47,91,4,132,71,62,27,68,148,18,225,76,33,151,182,221,187,144,60,92,126,32,207,106,229,151,72,203,82,216,231,13,77,193,188,28,52,29,184,207,128,175,98,127,206,57,16,5,104,255,112,55,159,161,119,74,186,152,177,187,163,145,34,14,84,123,199,68,81,67,104,12,128,119,54,157,101,41,112,55,161,177,143,177,61,136,39,41,77,110,21,31,251,211,153,214,117,100,219,114,201,246,176,33,62,20,10,181,203,142,206,210,224,81,108,196,122,212,37,227,121,42,87,144,0,27,187,132,45,96,134,46,193,7,156,71,126,74,203,147,75,233,67,242,68,115,109,169,136,194,236,197,65,33,124,221,174,15,152,81,158,107,168,58,58,253,19,214,42,0,0,217,24,42,210,70,170,129,64,207,145,131,79,34,156,139,56,9,127,27,28,29,134,44,141,0,35,52,35,228,210,37,255,236,84,232,151,16,195,217,50,44,44,141,240,166,83,59,28,158,241,108,169,172,120,128,138,190,143,197,217,49,229,96,63,193,120,174,98,190,75,30,93,62,195,15,37,69,133,255,106,213,45,103,142,234,47,133,118,53,178,85,115,183,236,65,25,123,199,60,139,88,158,135,125,88,246,104,26,177,19,233,219,194,169,95,60,166,123,61,178,4,155,144,124,198,162,120,28,51,8,105,41,13,1,124,148,32,93,15,124,187,156,106,221,82,8,96,177,59,6,131,222,211,226,106,122,134,18,23,222,244,239,105,213,189,98,146,221,14,132,183,200,147,219,2,113,213,12,53,80,174,8,129,16,237,155,18,158,75,80,75,126,254,185,64,100,255,144,16,32,111,103,135,72,9,17,228,47,175,181,88,220,23,252,59,37,146,91,225,169,168,106,16,174,91,132,72,57,42,138,34,76,77,128,214,123,168,37,239,231,135,243,36,57,226,210,245,129,19,38,38,78,138,66,5,65,72,34,14,84,102,200,49,28,216,209,24,66,246,97,123,19,157,109,80,110,55,241,252,10,184,212,84,83,204,86,235,205,174,241,18,140,143,53,193,214,106,219,218,87,85,96,214,76,182,73,110,80,160,28,212,115,107,48,193,242,17,108,9,6,233,108,242,116,37,250,36,96,184,110,238,18,35,212,214,170,179,221,20,83,53,17,191,32,90,54,21,151,119,9,161,247,133,158,113,42,136,132,151,175,31,47,215,65,21,198,6,66,148,15,163,176,207,98,211,179,13,216,164,108,113,43,136,146,113,218,8,77,122,138,31,8,245,141,35,20,68,210,13,145,169,30,1,223,54,64,237,206,102,176,135,254,38,206,78,190,32,42,213,106,54,181,251,189,175,186,232,74,34,172,133,165,180,188,197,248,129,74,223,20,42,209,209,72,250,231,123,168,149,70,44,97,19,60,97,148,103,145,223,125,161,180,43,79,92,94,168,142,151,160,175,140,209,127,211,116,148,48,254,163,104,250,63,20,77,205,192,33,31,80,45,27,163,65,38,15,160,72,14,107,32,227,221,43,156,193,91,166,187,124,146,19,187,0,73,181,164,36,204,46,166,40,19,104,200,194,131,79,130,211,226,108,234,195,211,143,225,59,154,152,35,250,86,57,102,2,15,23,173,217,74,125,244,30,251,84,44,157,81,214,85,189,11,77,91,45,37,176,253,187,142,210,207,140,210,14,125,133,221,149,13,81,252,105,147,60,238,125,229,8,255,157,214,157,55,4,251,111,170,232,188,11,132,255,1,122,183,5,189,175,55,181,191,135,226,205,255,254,203,120,227,93,156,199,167,113,18,67,133,127,219,84,213,43,148,54,199,105,6,99,22,24,21,183,173,148,138,40,8,23,40,109,194,124,209,80,204,44,39,13,135,217,64,178,1,47,14,179,223,179,37,4,226,70,231,59,51,209,72,204,105,18,255,205,250,249,59,53,105,208,241,79,248,229,223,254,84,222,140,171,214,74,99,229,146,199,73,31,29,126,34,164,167,235,119,59,74,221,228,57,129,71,65,95,81,65,7,140,199,104,6,188,96,240,160,118,213,67,222,3,41,189,137,95,247,226,222,185,53,226,125,121,95,18,34,208,161,150,170,139,51,100,94,122,52,33,85,25,180,83,25,86,236,105,189,91,90,19,205,236,147,128,173,120,177,173,45,183,3,215,118,73,180,182,179,241,244,123,196,170,124,204,179,25,212,6,49,107,186,174,32,147,231,247,108,18,167,22,30,245,93,10,37,11,64,209,54,128,185,240,38,180,33,206,230,226,166,212,135,153,216,157,139,179,140,67,164,143,174,75,92,177,83,65,166,2,186,76,122,37,19,241,76,128,231,216,200,92,25,210,143,164,226,231,202,227,26,121,45,135,107,130,219,31,152,161,107,24,111,190,156,210,164,202,34,230,136,44,68,47,212,111,25,29,169,36,163,127,51,72,50,245,214,92,174,166,1,38,32,246,3,150,112,249,97,34,84,211,74,160,195,215,246,16,211,102,25,192,97,33,18,245,83,145,153,107,60,218,95,226,98,198,126,133,177,230,88,166,6,193,78,166,28,252,5,66,230,129,102,168,113,235,80,150,45,40,214,123,14,59,82,30,186,240,160,36,31,58,115,104,215,94,148,15,141,42,82,232,25,0,28,21,94,43,213,59,78,142,185,90,5,157,59,147,84,78,228,23,209,24,214,145,173,193,69,250,134,31,106,141,195,240,51,112,21,236,52,41,114,52,23,65,121,237,94,216,10,170,22,188,114,209,134,194,58,185,40,178,5,117,147,50,228,205,113,210,235,157,210,28,22,154,70,74,61,92,71,9,148,253,209,25,241,88,210,26,38,2,118,164,221,126,174,119,106,189,222,128,46,216,62,5,72,77,241,127,63,29,103,170,38,117,109,39,231,122,161,45,181,7,101,1,163,233,203,192,110,247,78,97,228,249,213,33,117,221,245,47,147,91,210,94,199,156,205,40,191,209,101,47,163,175,66,129,29,217,230,129,193,210,116,111,217,152,179,252,12,62,24,152,45,2,227,222,229,196,245,149,78,150,16,39,245,229,110,141,136,38,7,152,78,29,114,14,171,158,83,156,129,252,243,196,95,156,169,11,166,129,44,114,100,167,74,43,125,103,104,224,52,5,69,26,57,68,35,155,137,154,228,183,60,75,139,244,12,234,77,80,163,10,32,207,131,78,183,52,101,193,190,37,27,76,165,18,20,83,152,208,82,73,215,170,168,165,1,161,168,15,221,12,69,92,81,227,195,33,143,167,129,124,57,224,154,163,90,36,104,211,3,190,228,121,172,228,255,0,102,253,40,51,0,249,212,35,219,231,154,87,44,223,224,28,131,73,155,230,165,185,150,183,0,74,77,170,22,10,171,128,130,29,87,249,154,147,53,168,184,78,86,77,138,165,215,211,220,165,49,46,213,84,46,87,199,143,30,124,111,181,240,201,250,182,132,83,90,90,159,73,209,148,210,191,101,180,11,138,176,34,75,21,34,6,33,31,171,231,80,246,42,76,111,55,128,26,212,254,8,237,217,56,40,99,25,4,104,3,133,222,115,22,158,120,147,79,32,9,23,32,198,195,138,55,74,189,118,41,233,64,197,234,174,92,228,243,103,109,30,223,216,215,120,49,3,148,25,211,8,180,232,187,132,237,78,109,198,150,171,121,211,250,214,182,243,128,246,246,123,73,47,215,29,45,143,53,135,116,22,75,74,25,168,39,253,81,205,142,42,178,58,120,71,170,50,180,52,145,58,8,244,120,188,20,42,141,139,225,242,44,6,3,54,188,221,242,172,121,214,80,87,92,62,125,97,108,150,125,155,105,77,241,90,18,223,27,169,190,176,94,58,112,215,188,219,239,167,177,80,208,130,187,132,23,195,151,193,144,100,242,236,194,220,129,173,29,132,169,35,40,8,229,61,26,157,119,148,122,203,51,88,216,200,16,118,135,123,115,33,108,217,93,230,180,249,212,90,49,187,135,3,171,155,157,88,107,218,146,194,235,78,167,87,27,140,93,62,254,204,253,214,126,21,75,115,83,126,161,45,110,150,184,151,242,146,238,144,78,242,221,212,108,199,242,245,246,31,103,16,119,88,182,161,250,154,186,32,38,113,234,101,233,196,182,35,46,74,91,149,181,198,50,132,189,158,175,89,218,179,43,97,191,116,6,123,73,86,157,198,69,176,217,116,126,203,153,35,92,247,202,128,255,232,55,198,255,235,77,119,183,63,212,184,194,175,40,244,150,167,172,20,121,66,218,127,180,225,127,116,253,31,86,232,159,101,212,9,205,47,46,226,169,173,32,43,137,138,122,224,49,83,96,104,156,101,170,209,10,120,207,187,159,99,6,190,101,127,1,2,10,27,72,13,220,181,2,210,96,149,137,74,197,190,46,238,143,146,145,41,240,201,152,103,83,242,175,112,139,252,2,158,129,77,16,103,176,174,137,12,93,94,7,81,156,57,129,212,86,254,181,233,167,209,165,247,216,91,114,63,238,233,67,204,205,94,215,113,115,42,63,244,107,136,107,102,177,221,147,221,204,194,106,106,101,88,245,163,150,221,36,49,17,214,235,173,238,0,12,80,176,134,188,198,234,177,253,185,93,128,173,188,40,114,131,56,41,178,110,128,219,51,10,14,189,86,234,89,170,162,82,108,149,184,153,36,243,226,150,37,113,173,105,146,192,178,176,156,87,132,37,57,43,68,175,80,121,100,89,153,245,4,100,142,83,187,190,172,204,185,194,29,0,206,85,16,167,6,57,235,172,225,65,155,134,40,168,18,12,237,239,74,54,242,54,128,228,91,30,244,88,159,79,28,188,184,41,50,85,249,174,129,164,82,41,235,100,131,155,45,224,152,57,128,246,75,242,180,244,170,204,190,216,208,179,153,183,3,136,238,97,150,202,99,210,84,236,159,209,116,194,208,77,250,16,185,165,208,14,119,12,132,154,51,127,213,102,246,248,165,250,94,117,5,109,251,126,160,109,68,175,80,135,253,116,145,157,51,253,10,18,173,174,160,240,195,71,176,184,22,118,117,181,42,117,13,206,129,90,176,29,16,24,122,170,136,47,198,154,253,117,181,61,112,216,33,93,193,108,226,225,82,122,119,228,229,167,99,170,89,200,192,199,87,121,81,235,95,66,205,243,197,12,113,114,157,48,45,191,36,50,104,129,28,195,191,56,94,104,31,182,97,103,131,205,50,133,60,38,111,80,172,105,191,48,96,234,71,81,230,245,106,169,116,47,172,73,139,23,37,235,78,213,54,191,74,90,253,15,118,9,218,115,58,61,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8bc88c7e-c979-41ae-a3ae-b2a602ee6e90"));
		}

		#endregion

	}

	#endregion

}

