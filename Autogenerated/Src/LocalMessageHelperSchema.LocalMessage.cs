﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalMessageHelperSchema

	/// <exclude/>
	public class LocalMessageHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalMessageHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalMessageHelperSchema(LocalMessageHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c");
			Name = "LocalMessageHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,107,115,219,54,242,179,58,147,255,192,232,58,25,106,170,48,109,211,246,110,172,88,29,63,91,181,113,236,179,157,203,135,92,46,67,83,144,204,134,34,21,146,114,226,186,250,239,135,197,131,92,128,0,72,217,110,175,215,201,116,38,181,72,96,119,177,239,7,164,85,17,167,115,111,158,100,23,97,178,181,181,151,45,22,89,26,60,207,230,115,250,120,244,224,179,21,123,253,130,124,40,179,180,200,102,101,240,83,145,165,213,243,179,235,162,36,11,237,99,176,151,37,9,137,202,152,238,8,126,32,41,201,227,200,181,228,248,226,23,250,231,81,54,37,137,190,108,63,44,67,253,217,243,56,125,175,63,59,39,31,75,211,179,224,148,204,87,73,152,31,124,92,230,164,40,0,93,181,236,156,228,121,200,142,196,15,109,125,161,30,25,191,205,137,229,113,176,191,107,123,115,144,150,113,25,19,51,29,244,253,89,105,6,251,114,18,188,34,23,123,89,90,230,89,82,4,242,143,246,149,47,203,56,97,24,217,57,96,227,21,201,75,146,195,214,7,159,165,225,130,20,203,48,34,10,29,233,44,158,175,242,16,228,243,224,179,27,88,215,251,91,78,230,244,163,183,151,132,69,177,229,61,207,162,48,57,162,60,13,231,228,71,146,44,73,206,86,45,87,23,73,28,121,17,44,50,174,233,113,104,53,56,42,146,50,76,203,130,63,22,251,115,18,78,179,52,185,246,126,88,197,83,5,206,139,172,140,103,49,201,39,83,111,219,75,201,7,182,194,239,31,236,127,251,229,87,7,251,187,143,255,113,176,123,248,248,155,189,191,127,247,120,231,233,183,251,143,191,59,252,250,233,238,193,215,223,60,253,242,155,167,253,193,200,132,162,40,115,224,31,70,114,22,93,146,69,248,130,178,134,34,233,227,55,253,145,32,159,164,83,126,2,245,56,135,49,73,166,148,61,39,121,124,21,150,68,28,138,127,144,152,222,46,56,172,17,126,87,145,195,244,227,218,123,75,216,255,221,107,162,36,75,201,244,192,177,242,101,65,114,202,226,148,219,154,247,118,165,124,118,65,231,60,160,118,186,90,164,181,181,74,186,240,219,194,5,102,239,50,76,231,228,252,122,73,40,185,213,223,35,149,45,84,209,144,64,38,212,251,120,111,19,250,207,54,149,202,252,40,76,41,179,114,234,73,74,112,75,36,247,85,137,12,90,68,114,146,103,84,243,192,0,182,92,82,193,167,102,146,191,129,69,189,57,41,197,95,189,156,148,171,60,181,40,10,59,81,111,13,255,174,205,240,23,75,42,50,27,80,208,100,6,56,254,53,188,72,200,25,219,227,107,226,10,94,101,249,59,102,172,212,175,21,217,42,143,8,120,11,74,199,80,213,82,110,108,253,33,160,232,55,192,22,1,163,37,248,87,152,172,40,251,130,243,76,160,27,180,30,226,199,156,204,168,255,125,247,39,57,135,36,167,211,81,108,250,193,60,80,190,138,40,5,212,110,153,115,80,124,81,147,32,95,216,31,55,133,161,110,100,234,97,135,77,67,168,237,96,32,216,39,172,138,42,60,50,251,158,98,223,194,221,241,15,62,95,38,78,41,118,7,148,142,231,225,175,215,207,179,16,156,35,61,147,208,74,141,253,244,157,193,13,244,76,150,77,151,74,224,252,121,128,77,190,135,44,154,174,212,204,187,119,70,202,189,85,158,211,253,192,32,33,146,22,97,28,145,242,50,179,58,208,171,140,70,3,29,172,96,225,85,152,123,139,108,10,193,97,186,123,93,19,174,156,39,56,140,83,250,22,12,214,239,31,85,171,69,100,232,197,51,207,71,48,30,82,150,175,146,68,98,168,248,12,20,48,120,76,237,48,160,201,180,63,212,157,108,128,168,101,97,59,140,202,201,212,97,107,66,222,39,113,244,238,229,242,140,153,135,144,186,164,68,24,155,142,136,122,200,73,113,72,66,250,146,238,0,67,161,145,145,162,21,10,8,202,52,73,85,223,233,125,175,70,17,111,75,137,60,26,101,251,49,67,20,230,215,207,32,236,14,89,240,29,123,224,153,99,154,115,209,76,175,128,140,173,162,19,248,217,42,6,142,152,114,110,32,25,238,61,122,164,48,188,109,47,127,255,18,131,168,100,134,72,0,254,128,118,78,145,240,216,57,198,38,64,219,219,236,116,220,87,86,20,245,58,195,234,2,4,231,25,52,209,56,203,162,24,203,70,28,65,138,155,162,84,86,104,60,231,10,197,53,74,241,199,22,169,73,232,55,183,97,207,208,219,136,17,130,168,53,82,122,102,176,9,62,130,240,112,102,114,229,249,96,87,84,169,188,208,137,51,2,233,137,216,207,63,232,49,103,192,41,16,254,203,239,203,60,114,79,131,213,151,11,15,243,108,65,51,13,65,32,85,56,177,161,90,240,234,146,228,96,252,122,94,74,195,208,164,56,120,191,10,19,31,200,249,231,138,228,215,39,97,78,133,76,147,110,223,156,203,14,6,94,88,8,202,249,57,121,82,239,239,239,30,124,36,209,138,198,38,111,122,81,253,185,221,48,253,131,180,160,70,191,191,91,63,242,7,149,2,9,88,19,96,242,41,205,178,8,5,86,255,185,109,227,103,192,241,17,190,206,175,241,215,144,123,31,46,227,132,120,126,13,46,128,255,33,220,92,98,169,133,219,34,197,70,219,127,80,124,235,51,158,119,140,93,242,26,73,68,96,234,15,249,6,42,129,23,212,11,28,231,204,240,124,23,122,76,42,163,181,233,115,58,4,19,39,134,138,66,70,162,1,190,238,180,36,41,186,96,24,79,80,76,182,219,94,19,73,128,22,105,84,49,178,44,184,176,3,83,232,235,117,37,238,56,185,51,125,235,46,164,62,180,147,170,184,153,96,103,58,53,225,63,37,51,106,208,105,68,42,55,55,52,11,192,76,217,218,35,73,65,60,160,207,173,237,122,74,197,14,139,201,109,82,171,229,96,140,52,249,140,38,74,11,234,43,205,244,85,228,201,63,214,56,72,172,113,50,161,96,53,5,127,150,124,237,209,42,173,148,233,200,207,228,154,33,60,9,227,92,9,45,75,250,0,231,101,152,219,70,231,85,191,70,213,222,132,117,6,34,34,76,76,47,208,80,64,72,144,83,173,178,101,140,52,80,232,214,67,3,7,212,4,2,137,222,62,153,33,214,22,190,115,177,154,21,138,56,62,172,10,254,238,123,245,120,59,100,44,13,40,195,55,133,81,111,198,186,97,218,30,94,17,53,71,87,4,79,133,65,139,104,28,189,170,44,111,150,81,230,70,151,158,15,162,0,84,94,156,26,114,194,74,199,21,89,48,85,105,173,59,249,22,40,245,124,241,36,170,221,171,69,209,58,251,238,72,247,212,22,47,189,173,121,105,97,56,34,226,48,183,131,243,27,22,142,12,126,102,82,60,207,178,119,171,37,174,255,52,88,135,89,190,8,75,95,150,183,67,131,199,112,57,128,198,187,253,184,88,38,161,193,71,112,74,133,201,20,168,212,160,108,51,213,31,124,215,69,150,37,80,66,238,76,23,113,122,26,207,47,203,130,58,121,186,5,67,128,106,20,45,224,59,29,11,232,246,89,72,61,168,97,33,20,180,156,103,226,32,194,22,27,130,227,49,19,7,35,5,206,61,132,75,192,48,109,112,179,11,34,153,201,24,80,53,197,131,48,186,89,214,144,194,8,251,116,155,58,181,71,191,128,235,88,132,149,170,121,110,163,187,176,23,137,174,234,5,25,241,50,132,114,185,179,249,246,79,216,122,92,195,171,16,204,102,219,94,106,172,141,20,117,207,193,240,46,139,58,233,196,186,146,174,91,208,141,57,39,2,107,183,240,59,50,130,208,130,170,61,84,235,149,172,14,238,22,209,185,54,237,226,60,59,36,37,141,55,184,33,134,181,227,245,27,201,50,5,137,226,39,135,134,5,82,183,232,121,172,253,133,141,246,193,6,46,17,61,174,4,236,4,80,98,238,239,250,14,42,155,154,55,212,184,48,232,174,31,117,197,127,171,130,255,174,245,126,87,253,53,103,0,20,109,211,77,186,147,129,232,78,9,64,228,244,30,182,160,191,105,40,173,49,153,243,130,219,197,65,133,225,157,35,83,212,30,141,52,217,76,14,210,213,130,228,208,105,148,80,60,181,128,47,148,134,7,127,113,78,22,20,1,221,30,151,100,193,227,8,146,26,212,33,194,180,33,68,84,212,33,134,85,251,40,207,142,83,222,88,175,56,6,251,161,104,58,133,167,62,80,195,222,79,85,150,213,32,112,39,64,112,143,87,114,26,60,223,172,129,78,64,88,12,59,203,101,114,125,146,132,113,10,131,105,31,192,90,244,157,77,195,76,172,213,64,96,246,48,182,105,237,97,70,185,24,247,238,36,9,35,213,219,30,51,182,131,34,212,144,6,27,73,215,196,79,167,33,182,136,244,247,182,85,64,127,23,27,5,250,178,100,234,204,244,180,38,199,6,38,85,43,152,185,119,37,49,67,171,190,162,98,139,143,19,255,0,39,2,135,191,218,52,199,189,135,99,95,201,51,95,25,14,172,11,86,83,92,86,159,76,10,153,165,208,40,233,179,123,4,133,12,103,154,161,84,207,155,205,25,232,181,56,80,212,67,61,142,38,78,75,195,116,79,160,193,195,178,109,15,214,14,244,145,184,5,75,150,78,99,8,152,144,42,115,68,149,189,161,55,120,234,98,228,169,186,90,55,147,122,94,88,75,254,151,2,122,87,226,194,136,236,207,211,205,220,76,14,227,4,238,145,252,132,23,233,233,155,94,187,10,9,42,128,105,210,67,174,232,170,83,50,135,162,0,40,223,75,98,250,224,44,202,227,101,169,204,50,129,170,25,195,139,46,37,108,123,236,106,203,62,161,168,99,24,18,19,245,172,67,175,164,28,206,102,190,78,123,13,131,38,56,149,127,82,14,68,211,38,141,13,107,214,172,183,131,170,141,178,73,168,217,67,153,88,79,138,247,134,12,151,77,19,124,35,75,233,6,176,39,49,224,208,212,88,73,43,3,100,134,176,75,200,145,89,163,78,114,112,158,53,240,235,7,246,41,144,129,49,201,167,192,169,159,48,39,246,29,90,152,130,61,2,158,232,146,183,154,163,96,65,161,90,138,242,170,221,84,212,229,93,4,166,110,57,34,101,120,18,150,151,133,80,78,161,62,88,71,249,189,183,103,53,31,165,255,28,235,232,71,205,62,27,119,177,18,11,116,220,44,248,43,210,27,52,54,135,251,80,163,163,192,187,123,45,161,248,42,58,217,97,214,134,171,10,251,101,191,84,212,28,98,92,166,116,103,198,184,191,32,242,167,64,184,97,133,82,120,232,4,36,222,249,248,113,80,141,5,184,201,61,122,228,61,108,188,14,216,160,174,80,246,29,203,136,59,240,126,251,205,1,121,27,65,54,237,175,80,15,130,157,244,90,114,162,49,214,173,117,201,212,150,175,123,98,166,174,44,205,8,73,58,149,13,89,229,102,82,25,230,229,1,120,85,200,40,197,159,56,41,203,73,177,74,148,180,44,99,250,168,164,101,197,133,28,170,50,205,220,93,197,201,180,186,202,193,115,187,133,154,212,23,236,210,22,166,3,46,53,178,187,91,182,58,160,176,148,252,6,125,7,61,111,96,20,26,161,164,183,207,143,106,6,112,133,170,185,16,80,101,10,142,243,41,76,117,253,18,182,148,193,73,86,176,104,81,91,186,154,84,197,233,59,44,56,96,29,115,151,168,49,29,225,70,15,46,3,180,130,2,109,175,107,20,108,50,28,80,189,27,41,133,156,36,64,50,118,17,112,233,139,238,30,58,159,224,178,100,208,80,200,154,186,242,157,60,15,169,38,54,47,74,49,75,22,192,43,87,248,234,146,242,242,12,238,105,161,238,61,92,204,11,38,233,44,243,63,239,247,189,47,196,153,62,239,239,133,5,217,242,110,4,170,195,56,47,202,227,124,159,204,66,250,209,31,172,71,30,94,204,132,227,177,160,239,201,35,149,130,92,10,196,126,150,245,72,193,201,111,214,176,235,76,116,155,227,226,141,186,143,95,199,144,136,195,210,251,119,234,221,28,164,87,113,158,165,11,192,74,233,139,222,157,231,244,228,235,62,78,135,59,223,94,106,94,35,67,227,51,227,20,133,73,64,77,17,15,180,139,99,193,139,44,213,71,6,56,10,41,6,83,243,16,140,166,213,36,107,115,105,154,163,98,19,15,213,196,26,137,74,235,25,161,193,58,77,198,202,56,213,220,156,132,166,231,208,8,226,41,137,178,124,90,47,216,12,164,158,7,84,96,247,44,193,189,5,168,41,11,175,97,154,115,107,11,72,213,111,35,7,45,150,153,166,109,173,106,200,159,106,15,29,215,182,153,30,224,91,219,162,245,208,188,188,45,86,234,119,183,209,205,90,219,133,103,222,203,104,244,251,38,44,224,152,245,111,60,134,203,191,70,205,28,153,193,55,128,169,1,66,131,167,69,15,27,204,91,221,65,214,160,200,233,37,53,74,2,109,20,71,12,252,153,64,194,220,239,178,180,191,57,50,196,67,23,34,180,172,237,162,187,251,162,166,85,50,72,204,158,221,3,137,198,184,243,94,45,206,101,222,67,85,98,173,150,218,199,29,112,237,24,37,12,210,229,51,176,178,58,97,176,170,17,238,78,242,33,188,174,239,157,169,245,233,66,141,89,248,242,7,39,21,213,105,125,45,192,245,7,65,125,157,92,220,1,170,29,139,27,148,226,131,154,128,20,175,215,2,73,89,219,0,149,107,126,217,13,76,247,226,13,112,68,13,28,110,104,141,201,4,2,198,23,187,230,202,34,149,172,27,7,124,75,85,164,162,162,214,152,147,202,86,78,93,31,139,235,134,178,230,29,215,87,224,155,153,184,8,10,236,187,43,246,233,61,95,164,8,179,94,239,110,187,25,85,69,14,173,84,161,118,4,105,81,26,9,83,151,173,27,106,76,205,222,183,43,143,4,170,153,68,55,74,173,70,39,161,106,138,227,134,218,188,22,160,40,166,24,235,65,30,13,46,206,54,185,234,24,158,220,213,17,115,134,23,127,176,51,84,105,184,171,67,172,123,203,109,14,76,190,109,248,136,152,213,96,238,237,188,78,51,108,149,67,162,182,237,114,93,3,196,82,148,135,110,0,178,136,108,108,79,22,184,26,117,3,81,3,209,159,221,185,169,122,82,21,51,61,229,140,157,92,87,83,67,164,225,114,177,186,225,64,3,112,236,235,74,82,67,144,146,237,6,165,169,47,18,146,20,113,7,63,215,212,25,9,68,111,78,180,59,34,171,2,125,225,245,235,91,6,157,220,17,255,14,13,36,244,147,84,245,41,110,23,51,244,120,127,136,15,100,134,50,221,124,71,170,27,42,154,107,129,105,101,28,177,239,144,178,100,51,120,21,151,151,76,119,224,35,235,61,192,157,197,227,252,148,44,178,43,194,199,169,20,220,144,99,112,157,225,156,205,33,1,232,20,43,35,231,216,249,184,237,32,152,244,15,208,59,162,0,183,68,217,163,76,108,54,63,145,168,250,122,32,75,78,142,236,170,49,108,97,225,157,227,115,221,166,145,112,199,220,186,91,32,97,243,178,104,149,192,87,137,152,138,58,190,211,116,118,93,236,201,149,200,231,153,209,123,219,156,69,14,1,110,88,45,142,125,93,190,29,74,32,212,246,178,18,170,205,106,172,235,204,87,90,220,68,171,119,181,88,135,193,2,159,127,101,44,78,129,106,191,146,136,185,31,199,251,90,108,220,158,205,120,7,136,55,217,10,111,150,229,82,158,91,222,77,5,103,61,242,180,38,154,163,135,86,125,215,194,70,42,116,68,43,208,195,246,2,79,239,51,141,154,71,186,177,224,122,93,225,121,67,57,180,74,203,181,122,222,15,96,214,73,22,78,201,52,216,224,136,65,117,70,179,139,212,85,205,66,221,38,58,168,222,194,111,61,173,226,22,91,60,194,102,137,102,247,20,211,209,78,233,96,223,173,116,118,180,232,102,7,197,98,213,58,137,250,215,109,12,188,111,54,137,42,73,217,13,78,204,40,202,106,48,113,27,197,115,242,182,91,169,96,76,238,90,152,194,141,200,27,123,95,26,61,203,77,235,214,117,227,248,119,182,65,206,239,205,13,81,163,111,83,245,233,168,14,134,16,222,173,5,123,196,200,57,163,249,66,66,74,177,70,244,92,27,175,122,55,56,45,104,249,117,9,230,5,88,228,126,91,160,116,209,220,46,108,253,101,8,195,30,157,62,239,109,164,124,150,215,128,189,106,82,255,127,218,13,238,240,91,18,247,219,241,110,11,23,214,31,92,208,103,94,103,252,103,110,160,3,244,186,189,201,251,134,221,100,217,140,86,108,155,69,77,143,131,144,128,103,248,126,59,61,85,6,112,199,83,109,243,26,162,57,50,217,88,89,186,184,142,123,20,142,222,234,103,2,106,35,242,190,37,162,19,113,123,169,52,143,99,149,76,183,159,231,48,217,156,238,149,100,23,226,78,63,53,113,63,19,140,238,125,185,14,95,202,248,52,165,248,52,165,104,52,242,204,87,103,62,141,41,62,141,41,254,55,99,138,251,247,120,159,70,17,127,237,81,196,189,121,176,79,179,136,63,253,44,226,14,253,238,70,237,137,190,118,218,173,115,213,237,103,208,100,234,110,169,108,191,255,30,174,233,89,171,94,80,201,70,58,170,186,93,126,42,119,98,105,235,221,91,219,243,174,223,28,219,176,63,111,173,183,225,236,109,181,215,95,166,173,126,95,45,238,170,169,221,90,225,59,24,191,109,147,214,125,117,144,219,131,191,171,111,220,185,53,236,108,189,88,213,203,216,139,253,125,123,188,247,208,132,21,114,239,212,63,104,97,204,118,59,217,183,239,89,182,117,45,237,116,179,101,79,158,60,241,158,21,171,5,164,97,99,241,89,154,22,251,93,47,175,204,224,11,91,73,213,23,150,133,103,32,119,63,65,219,95,159,137,111,199,0,203,222,60,112,252,160,176,78,11,239,148,86,49,131,223,133,172,130,211,8,189,20,95,22,130,240,108,120,44,227,45,126,5,95,235,147,209,22,63,231,191,78,172,68,208,81,215,46,176,209,76,219,89,138,134,92,156,189,48,216,99,98,191,39,190,98,98,20,158,178,195,138,8,162,178,89,43,132,116,206,233,197,151,1,130,90,243,153,22,224,154,177,33,2,173,102,234,42,131,31,203,69,194,127,209,181,176,94,131,174,215,60,104,220,127,150,89,75,157,180,212,255,233,233,75,253,51,6,245,215,174,203,203,184,144,47,46,41,30,120,168,126,69,103,46,194,224,41,153,147,143,126,255,217,235,255,140,223,124,49,238,15,249,131,227,37,112,164,8,38,243,52,203,9,124,1,67,77,158,233,254,224,148,80,153,208,12,73,194,167,37,85,223,149,146,153,248,70,159,253,23,52,82,111,230,38,94,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHrefLinkLocalizableString());
			LocalizableStrings.Add(CreateEntitySchemaNameLocalizableString());
			LocalizableStrings.Add(CreateEmptyLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHrefLinkLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a1f1ec7-14b1-498c-a471-77889158ae1e"),
				Name = "HrefLink",
				CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f"),
				CreatedInSchemaUId = new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c"),
				ModifiedInSchemaUId = new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEntitySchemaNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3aee74ac-45e6-46e5-b88b-c00e29268d89"),
				Name = "EntitySchemaName",
				CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f"),
				CreatedInSchemaUId = new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c"),
				ModifiedInSchemaUId = new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("66d5e9de-0568-4549-8ed8-bdb553cf01dd"),
				Name = "Empty",
				CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f"),
				CreatedInSchemaUId = new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c"),
				ModifiedInSchemaUId = new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca6d81d2-a91c-45e6-bcd6-e4650fd6108c"));
		}

		#endregion

	}

	#endregion

}

