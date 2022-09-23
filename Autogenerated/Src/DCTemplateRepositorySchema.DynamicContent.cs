﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateRepositorySchema

	/// <exclude/>
	public class DCTemplateRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateRepositorySchema(DCTemplateRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d20157f-1dee-4d97-a656-8ac5eaa3937c");
			Name = "DCTemplateRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e81fdc99-2bd3-4785-b2cd-a2accfc6f9a3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,92,235,111,219,70,18,255,236,2,253,31,182,62,160,165,1,29,253,245,144,216,58,196,175,212,104,156,180,142,210,126,40,250,129,34,87,22,47,20,169,114,41,219,186,192,255,251,205,190,103,151,203,135,252,232,181,5,130,24,162,118,102,103,103,126,51,59,51,187,98,153,172,40,91,39,41,37,51,90,215,9,171,22,77,124,90,149,139,252,102,83,39,77,94,149,241,217,182,76,86,121,10,15,27,90,54,95,127,245,229,235,175,246,54,44,47,111,200,199,45,107,232,234,181,247,25,200,139,130,166,156,150,197,111,105,73,235,60,109,141,121,151,151,191,183,30,206,232,125,99,31,98,121,86,171,170,12,127,211,45,105,124,85,101,180,96,97,178,154,118,61,143,207,203,38,111,114,202,9,97,200,63,106,122,3,188,201,105,145,48,246,138,156,157,206,232,106,93,36,13,189,166,235,138,229,77,85,111,197,184,195,195,67,114,196,54,171,85,82,111,167,234,51,12,169,41,3,81,24,185,145,122,32,243,132,81,82,27,82,114,183,204,211,37,89,211,122,81,213,43,70,78,175,63,157,253,179,130,143,98,65,4,254,53,106,186,88,207,113,232,77,114,212,108,215,116,157,212,201,138,192,234,233,241,254,108,127,58,131,71,164,90,144,21,215,0,1,214,104,202,152,92,54,36,77,74,50,167,32,48,165,36,173,233,226,120,223,46,76,168,109,255,112,74,212,4,64,157,151,75,144,190,225,202,90,209,213,156,214,241,209,161,153,150,11,178,222,204,11,88,93,202,149,20,212,209,209,108,10,107,165,53,192,140,96,45,138,201,38,164,164,119,209,1,240,249,34,116,105,149,14,16,106,18,208,223,43,242,99,93,53,0,42,154,201,17,107,253,145,164,124,12,97,77,45,77,41,217,206,146,121,65,223,131,58,200,177,208,74,181,136,236,156,7,175,123,56,128,200,176,146,36,200,64,125,215,75,175,39,121,91,87,155,117,175,24,98,196,40,94,39,69,149,126,238,229,37,70,140,226,245,166,129,207,243,77,135,138,204,183,189,188,204,168,203,178,91,52,127,80,47,71,49,226,178,236,83,190,59,228,224,181,66,10,45,51,9,22,23,57,0,23,240,34,238,198,45,232,248,158,170,30,24,79,248,196,104,13,192,43,101,8,227,142,144,11,20,166,194,7,219,78,136,214,228,146,250,31,191,64,20,104,94,147,7,31,193,2,88,202,79,174,105,146,125,88,139,216,121,52,155,16,131,57,225,39,83,114,70,23,201,166,104,208,40,205,149,9,214,228,152,179,222,3,119,218,129,107,52,164,76,225,134,245,38,5,86,35,213,137,40,200,93,222,64,132,227,145,130,54,16,57,194,58,20,79,112,20,219,184,86,152,94,150,16,127,146,34,255,47,40,140,127,199,241,163,190,132,96,100,2,145,142,68,161,24,20,121,246,112,167,56,32,95,132,238,188,65,199,222,48,129,226,135,126,125,93,209,102,89,101,66,85,249,45,136,160,13,46,62,16,177,191,108,237,38,73,222,210,70,239,57,145,242,135,186,170,154,143,233,146,174,18,238,6,19,237,38,105,85,108,86,37,127,116,81,213,23,121,1,250,156,144,106,254,31,96,68,22,226,227,207,73,177,161,19,177,144,189,119,57,107,142,36,229,148,208,251,180,216,100,52,59,53,44,152,94,241,109,82,19,42,132,146,83,254,180,161,176,51,29,243,160,172,132,69,207,61,37,198,120,192,85,82,38,55,92,36,87,124,233,249,98,26,41,36,240,110,205,23,159,214,20,180,35,23,245,11,64,230,71,141,24,22,201,135,144,5,128,153,115,86,149,124,123,139,207,127,223,36,133,90,105,80,47,72,33,74,130,246,164,96,32,14,65,241,65,106,38,190,100,63,231,44,135,0,4,82,2,132,105,23,233,155,44,123,83,20,242,137,36,101,145,158,167,173,235,24,4,59,79,210,101,116,79,142,167,161,213,75,14,241,53,93,85,183,244,100,203,137,162,251,131,78,193,229,34,25,151,34,146,11,85,67,107,218,108,234,50,48,131,70,25,66,158,103,203,3,140,237,63,14,173,26,134,74,114,204,223,103,60,100,103,145,72,16,140,251,232,160,103,85,102,174,173,94,137,84,155,0,109,135,115,0,42,134,61,128,43,251,82,109,26,202,150,136,115,167,161,148,15,40,145,70,24,231,182,202,51,136,181,235,45,247,8,9,33,161,7,22,169,5,178,106,83,167,160,22,245,177,73,106,216,44,240,210,172,70,25,172,76,14,231,210,35,102,226,203,8,57,177,164,65,227,181,244,242,185,116,201,248,23,158,237,73,184,223,115,167,226,172,78,139,170,164,124,115,39,223,126,139,167,230,121,124,147,192,54,27,221,199,222,204,218,5,32,137,165,224,63,36,178,18,192,190,172,101,209,75,218,147,43,140,63,58,43,136,228,40,159,245,36,188,222,142,209,90,144,135,128,29,46,207,114,97,36,8,37,71,111,55,121,54,33,252,255,169,48,141,1,243,229,121,185,89,65,102,15,203,63,146,246,80,129,0,190,84,113,12,177,145,128,212,254,50,229,9,124,1,85,90,134,173,140,13,185,74,214,107,142,96,25,182,195,242,68,33,93,74,0,114,93,106,97,140,50,249,215,192,77,129,231,24,185,139,36,138,91,49,126,207,12,231,38,128,108,197,1,165,30,20,68,172,100,57,177,19,234,209,74,138,203,140,75,0,203,136,223,211,59,254,55,10,206,137,13,185,127,153,237,79,36,173,30,155,47,72,20,82,37,249,6,20,183,41,10,179,118,87,73,1,18,174,177,62,163,244,9,22,160,139,127,160,176,248,208,23,120,7,83,240,51,127,208,12,201,45,53,26,81,96,16,187,131,50,21,216,142,171,28,115,62,146,160,224,90,58,112,213,244,128,35,148,98,214,27,127,68,114,14,53,253,103,154,141,195,187,176,36,159,83,166,245,153,114,0,103,231,152,85,87,201,122,210,233,92,74,46,173,239,199,130,218,129,242,112,4,30,9,113,62,75,85,100,87,82,70,129,221,65,67,160,85,143,132,182,235,14,195,68,94,193,168,221,67,125,24,164,119,204,162,212,255,43,94,229,111,1,22,8,151,161,208,41,32,4,123,37,20,107,90,54,165,253,153,108,95,224,32,167,155,33,78,44,106,213,252,106,54,211,57,233,54,19,30,226,40,234,154,166,85,157,9,253,8,33,98,253,96,136,16,145,4,6,91,93,12,107,65,180,7,152,175,5,7,229,55,124,136,168,225,56,210,229,172,146,204,65,187,24,22,84,153,219,164,208,198,19,227,251,192,109,6,180,151,110,69,178,235,239,26,95,102,244,222,35,225,143,250,169,44,132,67,170,214,68,187,131,206,180,43,250,85,158,192,48,79,227,150,210,209,122,162,31,11,193,79,182,141,200,176,206,203,180,202,120,104,254,52,187,248,23,143,5,226,139,200,176,117,163,189,195,231,105,249,103,119,255,39,56,153,9,143,222,244,99,2,164,199,164,15,73,129,161,109,76,89,229,88,59,15,17,158,38,162,221,225,80,171,103,99,89,240,40,237,205,47,31,245,48,16,214,84,244,226,143,34,247,128,48,122,249,202,69,144,6,176,135,12,145,15,248,74,139,124,119,175,81,125,164,126,159,169,81,179,201,186,141,38,117,156,70,13,125,26,212,253,46,34,6,184,154,192,192,219,153,112,12,184,29,6,125,208,110,13,108,3,27,43,6,217,165,159,82,157,110,248,228,234,241,56,30,87,9,251,236,51,224,207,198,81,15,192,106,64,124,227,152,174,248,174,111,122,60,112,110,203,179,76,101,97,222,38,18,185,11,139,86,242,28,1,243,220,13,201,138,79,31,142,231,124,136,135,98,73,230,96,88,12,123,158,96,237,118,215,49,142,197,36,6,197,104,202,49,24,70,196,125,8,246,134,181,241,107,21,130,204,223,75,165,226,25,38,196,1,173,143,246,199,58,175,106,248,194,37,215,79,71,205,206,84,251,220,147,64,63,198,250,213,57,19,78,170,226,139,188,102,205,135,90,13,55,189,13,190,2,114,124,140,121,10,2,103,105,188,240,148,76,91,149,102,159,204,222,113,145,205,177,144,198,31,2,75,247,61,70,32,137,251,11,202,115,148,207,88,177,135,60,166,139,145,114,154,9,241,234,11,233,43,130,191,94,173,159,50,181,155,69,98,120,140,78,143,64,137,110,135,72,234,245,64,145,234,198,42,223,205,56,189,214,42,183,34,123,146,23,118,30,115,153,98,92,167,76,106,0,239,136,141,118,194,61,68,216,231,133,254,56,15,30,86,72,157,170,32,100,12,208,182,139,65,169,252,46,6,24,84,15,166,142,9,128,164,29,159,17,68,240,217,147,14,216,46,60,36,77,27,26,106,112,172,142,2,71,2,99,46,77,243,156,200,232,56,174,116,112,49,119,198,236,6,13,151,182,23,29,237,161,158,145,213,55,56,225,192,6,30,164,31,1,18,159,71,24,39,24,41,162,251,35,218,128,110,205,175,251,212,250,164,30,213,254,37,189,155,217,242,223,214,212,99,181,138,232,123,20,234,205,212,217,116,244,184,5,187,142,150,73,136,8,41,73,53,218,28,146,144,214,250,218,204,170,93,32,20,91,21,153,101,100,91,109,72,30,164,87,177,155,48,212,30,224,189,187,112,131,96,66,16,30,96,141,206,60,238,90,156,206,183,156,98,226,119,166,253,22,183,242,207,47,196,207,48,93,131,200,237,46,140,171,62,13,161,13,107,119,45,153,90,169,75,83,237,186,250,177,218,178,83,189,148,198,198,233,75,69,238,174,33,178,109,227,246,96,77,220,99,87,143,61,142,16,108,207,146,38,225,57,118,104,14,52,73,135,41,220,205,218,49,131,192,179,78,161,248,44,188,237,142,243,62,123,140,226,216,68,206,55,214,30,174,65,188,196,77,204,42,79,16,30,156,16,169,226,168,86,29,111,222,95,39,229,13,189,92,188,175,154,243,251,156,53,144,178,41,93,4,218,244,14,241,174,190,97,234,248,221,61,67,237,41,190,49,252,189,241,177,222,160,217,255,17,209,195,61,206,96,254,121,70,135,254,52,54,194,135,225,82,170,214,137,248,227,142,53,196,84,218,57,230,237,210,83,31,118,120,182,240,143,209,253,93,93,239,233,190,67,116,157,236,216,83,28,75,166,206,223,241,10,3,96,237,85,184,201,32,134,117,221,245,189,70,139,214,74,167,49,53,163,142,76,78,232,40,144,57,177,126,220,248,21,195,227,23,98,55,129,209,75,233,44,87,196,98,218,117,130,98,31,12,21,232,232,110,166,174,158,65,66,117,203,251,37,149,188,86,171,159,247,30,243,29,232,59,159,50,217,127,37,239,121,186,215,15,10,115,209,202,220,221,208,172,119,60,174,182,204,196,193,167,43,176,97,42,25,28,132,66,168,101,16,82,138,90,68,7,91,149,185,42,238,35,214,141,174,93,216,147,193,17,215,46,212,196,237,147,203,241,183,47,212,46,181,195,29,12,197,245,83,201,111,13,193,98,126,253,141,124,241,230,87,87,169,36,41,121,64,130,175,148,188,220,190,82,35,122,89,238,146,220,59,82,202,168,178,34,156,213,91,200,178,213,165,206,173,204,179,91,98,78,194,138,236,190,83,242,224,238,59,98,170,33,119,64,158,164,28,131,95,174,244,115,203,230,165,146,200,198,223,51,141,130,153,200,89,92,31,109,9,27,249,142,47,245,203,130,170,119,68,198,71,65,173,78,88,194,169,146,161,59,6,188,71,118,31,187,119,49,44,255,86,91,76,108,120,234,216,204,12,51,71,102,206,33,139,169,68,239,85,102,21,56,104,251,40,182,224,104,142,207,95,30,58,97,192,134,113,224,228,119,8,11,222,1,110,15,30,158,80,122,181,112,96,114,39,31,1,1,49,85,65,54,24,250,67,237,60,119,141,122,151,27,84,204,141,115,44,237,128,214,132,253,224,116,221,69,130,41,16,2,167,221,39,207,81,31,32,168,186,237,255,176,171,133,132,71,194,56,73,254,85,183,215,1,134,109,247,24,38,82,162,240,79,110,75,197,248,174,46,20,34,196,58,120,145,103,36,176,221,43,231,220,220,110,121,208,160,218,0,223,179,214,119,204,73,37,175,154,59,87,40,157,43,177,142,217,205,77,77,41,50,143,10,138,65,252,125,194,46,138,228,38,10,205,18,159,75,150,74,182,239,155,85,161,207,192,12,30,188,89,69,90,96,14,208,28,21,61,161,146,193,234,240,38,28,242,77,247,26,254,112,142,9,123,160,223,24,7,8,245,58,33,246,92,132,15,85,151,244,239,108,137,243,217,216,115,8,193,166,43,158,249,170,236,79,81,253,154,68,236,21,202,41,246,226,143,148,231,102,35,182,26,55,215,53,183,162,238,91,103,10,120,95,145,203,81,147,169,236,73,78,37,23,98,179,35,209,61,213,98,121,82,201,6,180,254,110,86,189,169,235,100,27,185,217,70,135,93,113,79,27,148,106,43,161,39,91,213,117,103,124,66,106,44,234,60,236,180,169,108,243,182,140,58,162,132,122,138,49,253,254,51,50,40,214,25,193,231,111,158,33,231,230,92,201,177,228,60,100,73,57,246,49,150,156,113,173,56,191,107,227,231,31,94,177,230,7,80,57,195,14,191,0,82,161,209,94,233,14,180,202,237,141,42,174,150,64,78,130,178,7,88,27,143,194,184,208,240,156,66,177,64,41,110,63,185,187,79,6,178,5,36,94,136,222,1,163,226,96,220,1,7,91,189,75,180,247,134,22,223,222,192,137,29,168,21,243,12,125,151,131,58,212,174,119,217,53,53,24,22,186,20,210,190,37,14,25,204,129,198,208,69,93,73,163,239,35,142,164,52,247,25,53,253,27,92,138,244,40,114,212,22,140,110,192,41,143,249,55,206,234,252,26,68,15,122,229,43,91,201,246,86,167,197,8,40,234,43,147,215,181,131,222,181,221,189,29,43,72,143,117,54,98,199,26,216,149,71,252,160,107,248,183,111,242,94,9,35,119,203,170,160,246,202,170,248,25,156,73,49,154,138,156,157,140,253,45,156,72,220,246,167,230,248,43,133,8,86,39,105,227,254,240,205,252,158,240,54,175,155,77,82,132,110,185,248,247,91,130,23,111,87,232,46,64,240,78,106,247,0,255,118,65,112,16,190,178,19,28,96,124,11,13,121,232,209,248,25,132,110,142,100,163,107,213,7,32,31,26,136,255,164,16,33,216,54,71,51,49,156,52,75,88,205,205,146,192,68,105,146,117,253,184,179,101,12,27,129,246,167,159,202,252,247,13,205,51,206,122,145,195,84,213,2,25,92,252,180,187,164,48,53,88,91,78,234,88,76,176,150,144,100,211,147,10,208,146,240,159,20,48,168,168,57,35,243,51,112,32,210,163,194,134,158,3,173,82,130,49,116,79,217,185,211,45,106,158,142,155,8,115,65,155,116,121,81,87,171,179,19,188,9,152,124,219,243,175,88,202,20,133,138,145,69,82,48,58,104,217,211,106,157,99,195,38,101,70,146,162,240,77,26,195,38,193,31,49,17,118,140,161,133,203,137,170,177,226,64,120,188,133,73,135,137,193,174,105,181,222,118,91,53,76,190,164,86,206,237,160,117,91,103,229,207,106,219,111,118,53,174,56,13,63,95,173,155,173,95,63,249,231,230,129,243,125,147,173,216,173,17,159,241,41,162,86,150,18,62,78,55,247,177,29,226,96,158,210,205,64,110,36,14,7,39,77,113,206,48,112,122,226,144,4,243,147,208,148,161,195,14,44,194,196,227,143,200,218,135,11,46,33,82,197,200,123,5,65,151,187,150,96,180,72,146,237,91,225,75,216,237,182,186,131,51,183,73,232,119,140,108,124,196,107,190,242,93,27,232,119,246,18,18,251,135,211,23,241,203,26,178,148,182,95,98,118,42,235,217,159,234,95,210,47,32,207,97,234,109,25,73,102,53,208,237,222,51,87,71,250,61,1,66,22,254,10,142,222,247,107,12,249,253,204,201,157,67,173,151,93,139,134,39,4,138,221,227,4,111,230,6,226,254,136,26,41,144,227,219,46,203,112,54,240,68,0,187,67,94,2,199,181,78,198,7,80,236,72,242,119,194,242,201,86,215,35,18,213,90,33,127,48,166,187,54,63,252,235,47,45,90,31,188,219,101,222,78,21,221,235,191,148,123,252,185,227,251,179,128,121,48,35,235,143,204,222,251,12,156,161,78,252,110,189,203,197,49,222,112,45,42,222,116,210,99,105,126,197,16,217,121,1,232,86,10,135,133,59,165,37,178,209,47,75,170,18,120,94,35,101,21,101,229,119,13,161,252,250,17,201,27,174,73,81,220,58,25,185,122,21,11,78,200,53,59,81,129,221,229,140,170,2,136,137,244,61,47,249,235,174,228,59,174,16,188,4,51,61,3,76,6,137,75,177,125,108,145,44,15,142,3,175,134,145,29,87,126,253,210,43,134,37,197,233,146,166,159,223,212,55,155,21,44,230,61,120,121,164,94,65,36,199,42,119,245,170,45,239,55,48,94,209,61,178,140,53,197,142,85,134,95,231,152,30,131,168,34,106,112,16,40,121,42,194,54,233,82,133,42,126,42,118,118,66,86,2,37,68,225,24,37,237,47,92,230,142,41,135,58,24,41,82,199,245,164,197,76,5,212,229,106,246,137,107,62,177,98,109,63,156,171,180,238,155,5,60,244,17,125,135,174,242,116,87,179,113,183,131,1,205,146,31,96,255,101,250,18,210,88,168,25,241,50,230,242,92,111,23,131,181,246,190,140,223,165,147,123,4,207,149,216,154,166,92,97,82,104,62,0,228,135,0,117,254,241,39,213,191,203,111,150,16,155,82,46,53,183,13,233,176,172,153,64,154,21,88,195,67,69,172,54,47,223,69,223,127,122,247,238,255,191,83,62,106,131,148,134,151,187,226,203,216,188,99,19,253,27,89,252,90,250,151,202,87,68,234,190,2,169,248,27,32,151,148,191,54,18,158,129,113,252,253,91,39,254,127,163,42,250,217,33,248,148,178,226,69,96,107,242,246,231,196,175,218,115,244,118,242,167,140,91,99,43,223,63,51,242,92,224,9,118,244,62,165,242,230,139,36,194,217,227,135,90,64,229,92,15,129,12,117,89,87,119,37,191,33,90,182,220,217,40,72,190,126,85,176,167,252,69,119,12,11,101,179,57,233,9,102,254,182,47,188,68,169,173,121,244,120,132,45,155,59,253,1,73,102,133,10,249,133,87,8,201,167,238,67,120,246,63,84,53,244,26,200,88,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d20157f-1dee-4d97-a656-8ac5eaa3937c"));
		}

		#endregion

	}

	#endregion

}

