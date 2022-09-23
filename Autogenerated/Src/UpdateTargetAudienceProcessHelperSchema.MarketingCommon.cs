﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateTargetAudienceProcessHelperSchema

	/// <exclude/>
	public class UpdateTargetAudienceProcessHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateTargetAudienceProcessHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateTargetAudienceProcessHelperSchema(UpdateTargetAudienceProcessHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642");
			Name = "UpdateTargetAudienceProcessHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d29fa55e-3363-47c1-bff2-631609e0e3ec");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,61,109,111,220,198,209,223,11,244,63,48,247,20,5,15,57,209,82,28,27,142,149,51,32,233,78,206,181,126,73,117,82,243,33,8,10,138,183,146,89,243,200,51,201,147,35,59,250,239,157,125,35,247,101,150,111,58,37,46,158,18,72,100,145,187,51,179,179,51,179,51,179,179,171,52,92,147,98,19,70,196,59,39,121,30,22,217,85,25,156,100,233,85,124,189,205,195,50,206,210,63,255,233,243,159,255,228,193,179,45,226,244,218,91,222,22,37,89,31,218,175,160,87,146,144,136,118,41,130,151,36,37,121,28,97,205,102,97,25,98,239,95,197,233,7,237,253,117,146,93,134,201,243,231,39,217,122,157,165,193,171,236,250,26,94,107,77,84,146,105,35,231,71,101,60,193,235,48,93,229,113,146,44,73,126,19,71,196,217,39,111,250,20,204,142,155,190,206,211,50,46,99,82,64,27,222,234,255,114,114,13,200,189,147,36,44,138,231,222,95,62,191,1,190,223,201,175,143,30,61,242,190,39,191,70,201,118,69,30,189,224,239,54,219,203,36,142,188,136,118,240,46,54,171,176,36,231,97,126,77,202,163,237,42,38,105,68,126,204,179,136,20,197,15,36,217,144,156,247,249,44,1,170,40,79,99,146,172,0,39,180,47,97,126,200,74,109,180,145,47,189,162,204,233,64,254,149,2,97,222,212,27,181,162,28,29,54,129,201,179,172,92,70,239,200,58,164,35,61,212,8,35,48,1,140,54,140,92,152,44,128,177,141,202,44,167,68,51,46,104,20,115,190,180,146,231,95,20,36,7,96,41,151,73,152,39,245,215,177,247,185,6,73,31,163,245,212,104,175,140,245,174,251,88,128,32,160,132,10,66,195,72,110,226,188,220,134,137,228,28,101,151,73,28,140,209,155,190,224,115,115,168,127,42,148,79,64,245,77,152,108,137,139,88,3,225,203,109,188,242,56,7,249,76,93,44,86,222,103,138,236,144,130,61,236,218,249,52,75,86,36,31,8,226,172,146,147,51,18,101,249,170,71,127,193,48,117,4,156,121,195,251,31,199,233,10,222,129,41,219,174,211,127,82,94,14,129,120,166,201,126,223,222,75,114,189,38,233,16,0,140,161,51,114,117,6,22,29,180,136,244,231,165,236,201,25,48,156,155,247,24,55,7,112,70,174,72,78,117,122,0,27,178,203,127,131,210,122,116,193,32,121,127,42,138,2,84,247,239,228,182,115,207,56,45,45,49,62,235,171,7,203,109,68,109,215,178,12,203,109,209,163,243,101,150,37,222,162,88,146,242,36,92,111,194,248,58,61,141,243,162,92,150,100,211,10,195,176,121,198,175,109,189,95,101,81,152,196,159,194,203,132,44,5,239,248,24,94,195,127,225,53,161,102,233,37,41,95,69,159,248,103,127,164,127,31,141,15,59,65,61,35,107,161,149,225,134,219,102,19,174,217,162,43,228,249,13,200,91,59,120,180,89,87,28,114,86,218,209,184,90,118,197,116,26,198,137,147,245,245,71,3,92,243,2,246,154,148,239,50,238,60,196,55,176,222,234,174,3,123,229,221,100,32,190,71,171,21,136,206,42,166,4,159,102,249,114,123,89,68,121,124,73,127,245,151,132,250,133,94,78,138,109,82,242,95,172,229,87,180,41,182,151,255,216,146,252,22,86,178,147,156,0,244,139,180,16,160,200,106,41,62,250,246,154,49,54,86,197,248,202,243,85,124,193,15,97,81,209,103,33,167,143,214,250,40,93,249,227,224,77,86,194,255,231,191,198,69,89,248,146,50,19,211,157,71,146,194,90,176,45,136,63,189,3,115,214,25,166,107,253,22,28,23,166,74,155,97,241,46,137,62,81,91,105,13,81,126,54,165,230,13,119,27,248,231,0,102,110,29,150,254,200,18,174,34,248,188,127,23,176,5,113,52,169,144,24,100,231,164,220,230,169,151,146,143,182,116,26,222,88,240,83,150,191,103,97,71,0,75,78,182,205,193,208,131,195,7,162,59,233,226,121,78,108,110,163,35,27,15,115,219,106,169,111,243,217,152,245,61,121,71,162,247,139,66,144,8,227,41,195,28,236,197,135,109,156,19,144,35,115,42,110,194,220,139,104,23,110,235,165,188,11,53,25,83,246,241,127,26,60,27,7,124,85,246,71,139,213,104,28,156,230,217,218,215,61,141,177,16,51,214,192,102,81,176,40,230,31,128,106,159,195,9,126,12,115,232,84,130,171,140,40,212,152,41,193,72,44,202,213,186,212,15,238,235,48,127,79,74,230,80,129,83,95,4,210,181,97,192,4,135,10,54,221,208,134,34,53,36,138,199,86,254,236,120,254,43,137,182,32,32,222,234,178,250,231,212,88,176,32,232,42,182,57,153,29,215,175,252,49,170,235,2,236,130,134,162,103,36,4,231,21,100,151,253,152,90,51,19,112,124,132,183,243,107,252,56,104,69,15,56,200,128,118,244,205,129,9,129,116,252,218,180,222,51,107,123,146,144,48,63,217,230,121,229,47,21,182,156,81,65,154,129,32,149,196,18,36,38,59,166,223,92,75,79,65,191,191,204,179,237,6,228,204,57,185,16,164,145,49,38,14,84,112,218,157,234,6,200,152,56,58,240,216,14,107,3,92,205,53,30,143,229,212,250,78,51,97,240,94,44,82,13,43,19,115,229,114,73,52,166,249,5,135,49,245,218,245,220,162,255,96,44,166,110,116,188,77,222,207,215,176,166,139,133,86,56,10,8,147,196,156,2,248,50,140,74,102,57,36,127,228,75,176,232,220,164,48,141,215,64,239,70,237,43,144,2,161,202,58,80,163,176,16,140,64,22,113,221,192,5,12,97,161,18,185,73,226,114,132,235,98,81,47,230,117,135,243,219,13,225,92,72,253,14,166,182,234,71,153,36,251,226,106,111,78,13,195,145,146,252,111,89,156,26,4,192,167,183,61,129,87,147,166,3,146,83,39,166,217,254,88,44,193,165,164,171,226,16,85,174,212,108,196,248,124,14,75,155,38,65,22,160,74,244,45,83,238,246,147,118,49,77,85,115,107,14,28,131,82,22,202,65,163,65,61,159,194,148,226,182,168,81,24,32,62,184,5,152,165,188,244,23,175,192,55,252,158,191,122,33,64,22,150,124,71,84,179,24,12,112,162,222,131,223,180,140,63,81,71,238,201,62,60,6,177,194,108,109,83,96,217,82,154,31,1,248,231,253,95,140,214,87,176,180,250,212,82,197,208,234,224,16,126,124,47,27,3,187,183,41,68,131,241,215,95,227,235,170,134,65,249,45,184,160,255,246,37,206,248,23,183,210,27,156,85,129,44,55,36,138,175,110,223,100,224,93,190,255,1,198,94,88,235,170,64,78,128,175,203,14,134,246,60,219,248,10,255,76,203,123,84,128,20,196,197,123,26,97,214,190,252,8,93,140,152,224,41,212,130,53,45,204,126,135,246,114,16,3,6,88,76,248,220,147,21,99,48,208,108,78,33,107,218,210,134,195,16,195,142,213,95,166,52,84,80,63,251,53,131,126,39,151,171,6,194,82,245,97,186,58,143,215,36,219,82,226,14,158,89,34,203,186,100,46,7,203,193,52,117,204,213,218,174,56,108,8,14,6,77,3,243,245,20,5,239,234,11,75,84,139,251,239,116,19,109,220,83,111,239,192,129,136,62,151,224,119,188,119,124,191,179,95,223,121,31,223,197,9,241,124,156,93,83,213,114,116,179,111,177,131,35,173,254,42,205,62,188,221,16,190,1,99,123,170,212,140,149,89,25,38,122,204,199,208,48,167,252,37,77,8,22,37,242,25,177,0,37,243,25,152,227,210,28,128,240,56,19,236,251,164,1,251,196,155,209,96,20,132,53,120,29,115,239,213,68,41,98,235,156,92,113,187,97,199,211,16,60,195,74,51,49,18,195,38,28,30,9,174,152,203,46,227,46,97,191,154,252,120,43,95,44,189,129,138,160,123,199,130,6,161,58,137,168,27,173,241,197,204,124,241,249,212,223,90,189,169,106,9,54,46,138,55,219,36,121,155,207,215,155,242,214,55,225,225,26,198,69,182,89,172,229,78,224,69,25,39,108,187,46,224,174,125,69,155,193,240,9,35,28,248,195,182,247,110,253,241,68,77,186,193,106,34,114,29,99,36,63,97,81,221,195,77,0,172,149,71,131,36,154,121,212,113,41,91,220,63,240,24,157,225,190,212,208,244,130,74,154,123,229,215,156,40,41,84,203,40,76,194,252,123,224,194,139,206,97,26,99,199,75,36,33,206,25,21,137,215,59,224,147,194,38,137,140,226,169,57,117,82,225,234,199,49,133,70,17,150,185,195,3,19,10,51,117,190,196,44,12,95,101,213,20,50,57,200,129,51,66,89,217,125,74,132,35,66,39,69,4,162,105,37,87,179,219,52,92,199,17,223,69,20,171,40,232,9,15,168,69,199,149,104,19,39,192,29,71,10,25,105,83,77,148,18,233,114,217,166,206,153,120,41,205,156,229,159,177,228,30,207,7,41,81,54,72,198,162,168,136,175,227,171,142,89,105,11,30,106,189,154,210,233,24,47,58,45,223,72,199,29,76,31,93,75,93,179,199,66,25,38,41,16,86,208,6,118,32,67,85,142,80,187,206,128,209,194,3,111,116,104,55,81,147,233,195,146,39,136,225,196,179,74,212,109,183,166,18,85,60,129,234,116,155,70,98,141,146,104,151,44,165,141,72,159,176,164,19,207,162,175,102,194,216,73,23,251,12,178,1,220,40,70,227,158,210,45,13,149,104,60,174,246,36,196,110,4,238,88,14,224,52,51,139,6,186,69,202,37,68,49,141,117,70,202,237,242,182,228,170,56,76,153,39,48,9,41,124,41,116,13,54,238,11,85,114,109,179,172,147,118,171,61,134,171,181,92,31,118,101,148,31,194,244,212,107,216,189,44,15,178,45,217,199,178,240,101,182,107,170,218,97,84,80,152,102,154,154,105,179,24,179,200,171,55,165,101,49,144,60,193,199,32,233,217,125,172,177,25,52,85,110,114,65,117,205,57,190,215,217,42,190,138,201,234,248,86,29,153,173,184,29,86,94,170,67,142,154,134,191,254,213,44,175,129,72,182,98,207,8,85,52,205,237,171,64,45,86,60,18,177,221,196,118,37,231,162,173,236,239,98,124,68,48,202,217,228,91,55,252,157,53,122,75,191,21,60,14,27,142,76,137,176,234,59,183,223,205,9,213,238,251,12,221,109,55,223,142,71,134,168,109,166,15,115,215,185,62,117,117,216,25,214,1,187,168,93,184,226,216,77,223,141,89,103,37,44,95,178,77,103,4,238,192,149,252,239,176,230,162,162,72,190,125,24,51,110,164,106,133,205,161,111,131,74,30,157,195,227,137,16,195,150,15,0,143,172,12,238,177,118,91,43,254,103,3,85,156,247,176,129,76,10,77,3,200,94,254,1,214,175,45,9,49,192,14,106,27,34,230,14,136,44,56,195,77,156,115,47,197,76,113,126,140,203,232,157,185,77,141,58,33,81,88,16,143,179,119,244,28,103,46,139,133,235,73,225,147,218,197,150,97,243,169,78,120,67,128,213,36,179,218,238,21,76,148,173,138,108,126,91,68,70,19,27,11,38,102,71,157,178,32,31,7,147,186,236,16,202,199,216,32,163,204,213,228,195,100,241,34,45,51,131,197,13,195,5,215,181,230,203,196,179,12,62,219,153,175,13,56,229,173,98,112,225,87,205,100,214,172,111,225,50,133,40,232,47,26,234,14,29,236,179,92,16,249,184,54,158,184,72,27,181,24,136,108,27,237,154,196,127,45,98,13,16,134,120,19,3,153,61,149,192,46,106,26,164,7,103,61,21,161,1,112,199,106,168,223,77,119,26,57,252,224,26,100,205,79,139,18,181,115,78,38,213,100,90,76,153,158,221,104,75,35,195,6,234,76,21,175,54,168,66,164,133,40,125,23,3,43,192,249,253,214,131,246,24,138,97,218,173,88,187,185,245,240,171,130,201,235,134,98,1,71,86,99,58,245,174,194,164,192,61,7,140,56,190,194,40,156,158,120,174,28,145,189,214,232,139,139,27,33,125,84,73,112,213,30,56,75,187,190,20,202,41,138,198,148,75,53,148,118,177,232,106,54,220,2,217,219,102,172,200,85,8,26,226,176,21,166,204,110,147,164,7,252,166,74,143,126,222,246,171,140,31,73,96,199,174,240,178,247,132,31,201,154,202,179,89,160,212,180,27,146,253,147,45,249,120,80,181,80,129,189,14,211,16,126,9,106,252,88,129,5,125,94,201,94,188,123,51,55,156,53,8,245,41,49,188,250,64,57,69,54,101,233,199,224,13,249,72,127,250,227,186,76,96,244,166,61,245,199,102,195,34,181,195,57,54,180,196,194,113,42,196,172,77,48,136,226,213,14,94,94,21,62,136,10,14,165,16,226,65,195,34,164,128,4,61,146,165,20,96,220,207,145,237,65,136,94,232,211,64,209,68,225,95,192,121,18,32,165,32,221,169,109,115,33,16,98,93,39,204,134,51,174,217,50,185,249,197,180,232,222,86,170,65,110,59,148,212,56,43,202,28,27,69,17,253,42,79,235,180,103,90,216,174,48,135,168,38,147,44,7,24,49,126,102,155,170,236,253,181,233,138,58,42,223,107,82,197,218,180,211,227,24,103,72,73,152,240,1,40,245,95,221,167,102,255,97,41,199,8,71,37,75,33,227,30,133,72,194,90,26,182,210,28,54,127,207,201,244,10,254,3,41,180,173,27,41,139,29,56,167,101,8,146,123,124,75,57,97,218,91,220,142,19,105,195,11,97,133,88,230,65,80,103,8,51,82,137,17,49,38,23,231,217,41,161,54,158,169,194,207,191,120,159,37,184,31,243,120,29,230,183,124,46,38,198,219,89,92,108,146,80,124,244,238,16,217,255,138,147,23,48,232,84,99,102,199,62,14,217,158,220,137,65,92,83,101,32,230,39,225,178,192,9,234,56,229,226,56,54,86,58,208,126,54,136,151,13,244,168,63,187,108,60,238,97,212,239,241,131,39,142,124,255,165,113,60,5,59,185,34,18,242,151,202,239,111,81,34,154,203,212,20,0,202,177,151,7,59,5,164,48,85,6,183,26,1,189,79,182,116,62,216,210,134,121,40,66,91,112,226,106,218,61,17,72,254,62,85,253,237,7,41,181,210,193,30,103,40,69,233,186,118,134,178,49,56,102,138,87,243,129,173,14,246,200,102,199,84,222,224,197,13,45,100,207,225,119,214,240,60,59,134,238,18,27,216,85,246,214,223,119,70,106,244,209,152,174,252,242,219,111,38,29,61,106,246,59,5,103,21,244,62,53,248,16,248,204,243,60,203,229,73,241,53,175,90,158,120,243,95,35,194,221,51,219,67,103,65,93,21,104,41,209,157,49,36,222,36,96,8,148,162,247,231,222,207,159,15,238,96,113,248,230,238,16,36,30,144,241,140,93,29,30,77,36,29,93,215,84,57,150,69,122,149,25,67,185,47,245,10,200,192,61,8,247,8,122,22,195,138,29,110,109,87,158,47,18,87,98,91,16,93,36,86,160,107,92,104,65,146,133,43,224,77,109,81,242,103,72,195,177,161,15,71,155,141,248,2,212,220,196,66,250,197,43,127,132,129,176,98,86,173,145,183,18,167,37,244,183,83,148,108,196,131,25,201,211,22,45,104,174,129,79,67,81,80,30,183,128,7,55,111,40,244,69,90,18,140,77,154,155,87,42,94,237,0,103,239,98,161,239,41,92,216,21,74,11,21,8,243,100,121,161,198,162,36,107,239,138,253,147,30,46,225,247,166,213,7,32,94,202,235,156,230,197,7,222,161,176,14,65,72,241,68,242,111,232,133,80,19,243,146,169,137,199,10,25,16,231,146,20,31,132,231,99,145,239,171,60,195,162,166,54,39,1,124,12,48,205,247,113,37,128,186,128,21,109,50,239,11,9,139,38,150,224,184,182,209,151,148,75,121,68,86,108,108,74,68,115,148,196,161,163,188,4,89,70,116,138,100,117,113,103,15,165,121,64,116,60,150,158,61,240,128,90,199,168,149,211,96,244,181,66,160,178,55,233,172,206,212,49,32,97,106,215,103,217,128,187,84,196,12,162,248,193,0,115,23,180,109,234,218,170,53,233,179,227,138,77,250,60,76,213,166,205,4,4,69,119,185,167,79,59,3,91,247,30,154,253,62,202,92,105,178,191,106,200,136,211,113,9,163,77,199,39,251,180,4,16,194,29,225,86,93,230,183,40,40,224,50,255,198,237,111,115,106,0,169,166,126,224,164,176,86,232,215,175,216,81,25,235,31,92,243,208,48,140,110,7,164,238,61,148,246,60,178,147,194,78,135,5,238,65,96,91,118,89,47,245,220,197,190,215,240,106,91,49,108,181,132,181,24,120,10,225,15,213,155,166,26,92,57,134,47,95,101,30,108,20,59,208,150,7,160,237,191,66,81,88,228,174,31,207,231,55,95,138,237,254,9,191,72,83,110,109,176,173,147,250,244,189,87,179,138,190,178,239,239,101,135,249,189,45,255,193,99,8,254,206,138,95,12,69,66,82,149,172,68,193,186,250,12,57,180,39,191,161,117,212,12,138,172,88,120,155,98,253,171,187,5,46,202,232,77,246,177,29,140,168,7,108,189,114,201,60,179,131,196,75,58,67,169,99,97,221,116,0,190,27,146,88,112,132,80,220,236,76,60,190,149,8,129,229,38,204,227,162,246,87,79,64,96,182,57,89,92,167,89,78,78,66,90,236,242,219,111,184,28,182,134,114,125,176,56,82,151,82,80,248,63,56,151,95,133,69,121,20,81,105,141,63,209,12,6,193,88,109,8,98,139,119,37,82,84,60,120,21,119,74,212,151,149,221,215,212,183,153,35,7,90,122,204,150,199,228,231,244,226,11,243,192,173,124,118,99,208,157,203,81,71,123,223,48,6,221,88,244,29,70,179,213,116,163,221,205,30,54,219,236,66,139,75,28,152,199,44,146,210,70,236,189,152,122,251,157,197,219,1,23,17,113,29,75,155,136,11,20,157,174,212,234,176,35,43,192,245,189,156,143,47,47,252,134,225,250,174,25,118,181,12,118,175,203,131,94,66,83,45,90,27,221,198,42,38,150,27,124,163,31,91,15,11,245,142,26,232,210,237,14,27,108,43,149,21,30,49,153,146,38,212,184,101,218,117,111,158,78,128,209,169,45,154,84,23,120,13,84,243,53,59,58,171,58,220,177,99,36,21,190,102,27,106,70,183,47,224,238,156,255,207,215,227,32,178,165,109,175,232,23,130,107,213,82,184,210,78,6,223,163,195,204,3,118,179,48,114,29,149,139,181,230,178,172,165,147,229,140,83,233,96,173,135,51,126,183,17,159,254,7,1,108,123,162,157,77,249,49,9,97,58,109,123,34,159,14,127,44,97,234,85,39,95,58,0,209,186,136,2,106,71,55,251,15,35,200,126,226,139,171,35,242,87,13,166,246,153,156,135,169,25,196,254,48,192,180,245,70,167,238,185,204,110,19,82,35,235,55,43,118,193,89,159,185,169,61,196,230,249,209,119,111,20,62,185,188,27,249,160,202,36,31,71,45,247,253,226,251,54,101,194,42,217,119,163,83,74,197,124,143,9,52,142,38,244,153,189,42,95,49,68,185,234,82,211,33,250,101,76,157,249,55,106,120,116,207,202,169,71,7,79,143,231,143,159,62,57,216,123,118,58,255,102,239,219,131,39,223,237,61,155,205,246,247,142,158,237,63,158,125,251,244,217,227,217,236,241,104,124,232,61,122,180,188,45,196,134,235,158,39,146,50,24,26,243,175,217,168,200,158,29,63,57,217,63,56,250,102,239,201,119,243,239,246,190,221,159,157,236,61,123,242,228,120,239,233,252,241,241,252,120,54,59,121,58,159,59,145,113,192,24,202,138,105,226,76,108,207,141,209,246,221,227,137,61,195,166,61,49,54,134,228,164,119,107,22,240,177,241,218,49,164,135,186,41,65,127,231,126,4,127,251,83,92,190,83,142,60,243,151,117,92,79,97,114,239,117,194,43,155,204,252,13,226,100,116,8,50,40,79,81,23,3,185,88,117,83,165,118,115,51,88,44,243,91,204,62,213,247,200,209,12,176,152,56,245,94,95,180,208,186,239,213,149,236,206,252,137,183,119,208,225,142,74,250,112,193,168,255,76,155,204,73,215,219,61,102,139,150,61,31,250,176,64,67,0,10,142,82,151,219,67,31,167,181,70,44,53,227,160,154,75,87,153,104,223,61,39,159,171,12,36,139,186,78,162,214,149,19,6,177,157,51,255,174,34,148,133,13,180,136,142,253,147,242,132,10,224,74,177,199,2,187,20,253,134,195,68,53,72,94,228,216,7,236,191,78,149,142,141,39,202,116,12,246,138,84,3,18,219,52,72,93,145,250,212,114,203,212,21,173,82,170,10,148,134,31,9,211,38,151,239,86,74,160,131,203,229,36,75,12,216,141,66,41,239,1,80,186,192,60,161,187,57,26,216,166,41,209,128,53,109,216,86,204,208,121,174,246,223,1,55,20,224,141,172,112,217,67,236,150,242,26,104,151,237,108,112,174,88,64,211,84,106,72,159,170,70,113,196,126,240,84,16,13,146,101,197,148,23,10,234,2,90,78,136,161,54,174,26,70,90,116,137,192,40,223,28,236,160,151,52,59,119,223,193,221,209,55,205,49,2,174,179,50,211,22,149,150,140,138,153,211,194,67,99,87,28,108,255,169,155,234,179,254,9,94,255,7,172,10,199,150,13,116,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSuccessMessageLocalizableString());
			LocalizableStrings.Add(CreateRemindingCaptionLocalizableString());
			LocalizableStrings.Add(CreateEventRemindingCaptionLocalizableString());
			LocalizableStrings.Add(CreateCampaignRemindingCaptionLocalizableString());
			LocalizableStrings.Add(CreateFailMessagLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cb1d449d-b61c-41a9-a6a7-92bc07cfb9fa"),
				Name = "SuccessMessage",
				CreatedInPackageId = new Guid("d29fa55e-3363-47c1-bff2-631609e0e3ec"),
				CreatedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642"),
				ModifiedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemindingCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("89b55a38-5689-422b-922d-e308897e86c6"),
				Name = "RemindingCaption",
				CreatedInPackageId = new Guid("d29fa55e-3363-47c1-bff2-631609e0e3ec"),
				CreatedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642"),
				ModifiedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEventRemindingCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2892fd88-44d1-4b83-b716-b7b9f69f0b0d"),
				Name = "EventRemindingCaption",
				CreatedInPackageId = new Guid("d29fa55e-3363-47c1-bff2-631609e0e3ec"),
				CreatedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642"),
				ModifiedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCampaignRemindingCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4b8fc3d3-924c-4a81-aa9c-95fa3decc07c"),
				Name = "CampaignRemindingCaption",
				CreatedInPackageId = new Guid("d29fa55e-3363-47c1-bff2-631609e0e3ec"),
				CreatedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642"),
				ModifiedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFailMessagLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2828222c-f435-4078-81d8-836312be6169"),
				Name = "FailMessag",
				CreatedInPackageId = new Guid("d29fa55e-3363-47c1-bff2-631609e0e3ec"),
				CreatedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642"),
				ModifiedInSchemaUId = new Guid("e268014c-5aaa-4b48-b23a-9860db793642")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e268014c-5aaa-4b48-b23a-9860db793642"));
		}

		#endregion

	}

	#endregion

}

