﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationManagerSchema

	/// <exclude/>
	public class BulkDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationManagerSchema(BulkDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c848255-c02c-4ca5-9d7c-159a0d6b4582");
			Name = "BulkDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,27,107,115,219,54,242,179,59,211,255,128,168,157,150,186,168,116,210,251,150,88,206,56,126,164,110,235,199,217,206,229,67,38,211,161,73,200,230,133,34,21,130,76,236,113,245,223,111,23,47,2,4,64,201,113,122,151,206,116,26,147,196,46,246,189,139,197,170,76,230,148,45,146,148,146,11,90,215,9,171,102,77,188,91,149,179,252,170,173,147,38,175,202,120,143,102,237,162,200,83,254,244,237,55,119,223,126,179,209,178,188,188,34,231,183,172,161,243,231,189,103,128,46,10,154,226,98,22,191,162,37,173,243,116,112,205,201,229,127,224,207,163,42,163,133,179,238,247,188,252,224,188,60,166,77,247,206,162,110,191,72,88,147,167,241,94,53,79,242,30,229,241,69,194,222,175,128,123,67,47,119,22,57,242,223,212,73,218,176,248,140,126,104,41,107,216,253,225,216,2,120,163,29,28,188,105,206,175,147,122,209,189,50,5,62,159,87,165,255,75,77,67,239,227,253,178,201,155,156,178,224,130,3,32,166,170,3,43,142,219,60,62,167,245,199,60,165,92,248,241,254,77,67,75,134,58,241,45,7,30,227,95,154,102,17,239,92,50,206,165,189,144,211,114,219,233,149,76,135,182,218,75,154,68,73,43,238,131,2,82,64,251,93,77,175,16,207,46,200,152,61,35,47,219,226,189,37,251,163,164,76,174,104,205,215,110,110,110,146,45,214,206,231,73,125,187,45,159,17,128,100,38,4,153,11,144,88,65,108,26,32,111,247,232,44,105,139,230,101,94,102,192,79,212,220,46,104,53,139,14,67,251,142,199,239,0,106,209,94,194,123,146,34,141,65,18,9,80,159,48,234,251,52,33,193,13,0,251,29,103,78,75,226,32,167,69,6,162,56,173,243,143,73,67,197,199,133,120,32,53,77,178,170,44,110,201,225,121,147,212,141,133,81,90,177,176,134,91,242,7,91,177,226,185,31,177,67,41,122,212,110,145,211,178,33,127,92,134,63,6,208,237,44,22,231,233,53,128,20,180,126,83,39,11,16,212,31,137,243,206,2,78,193,228,26,2,230,135,22,119,200,94,151,57,144,189,211,192,243,101,219,208,99,8,101,96,118,35,245,97,52,4,123,94,181,117,74,133,233,121,48,152,159,125,120,114,224,249,40,185,57,160,77,122,125,10,234,98,0,246,244,201,147,231,82,99,180,204,132,210,108,13,158,214,21,176,132,46,139,90,172,26,176,119,154,41,61,202,71,242,49,175,155,54,41,248,22,187,215,52,117,197,10,26,110,90,118,88,54,224,82,176,112,186,77,158,174,216,152,251,90,139,202,197,157,185,209,202,109,133,1,135,140,48,122,205,104,13,192,165,116,234,214,122,156,32,134,141,13,159,38,93,69,142,193,13,46,193,13,34,27,199,152,220,113,44,249,140,68,66,57,241,33,59,110,139,226,164,222,159,47,154,219,200,34,75,4,218,215,117,49,86,112,27,191,87,87,241,126,93,87,117,52,242,47,37,57,35,20,81,197,163,49,215,228,198,146,255,255,99,82,247,248,217,69,213,10,49,237,212,87,237,28,13,123,74,74,250,137,120,190,68,35,27,120,52,233,97,147,155,173,244,54,216,130,199,56,249,8,57,179,217,90,233,196,219,145,224,126,37,3,138,138,1,255,244,18,48,224,236,247,222,219,53,6,216,50,224,234,203,97,67,62,162,205,117,101,5,193,141,13,211,59,133,199,34,226,121,242,175,150,130,116,129,155,61,201,5,85,9,115,159,125,144,198,70,40,7,64,199,87,22,133,118,65,217,7,169,121,7,97,207,37,98,115,129,142,234,6,86,33,3,64,24,3,201,152,109,56,22,200,118,237,188,4,83,223,41,62,37,183,236,156,98,238,131,45,65,130,180,131,128,173,118,178,121,94,158,229,87,215,13,179,62,215,180,105,235,18,9,53,197,166,196,176,151,115,226,96,183,45,193,231,68,70,190,109,148,7,166,98,90,95,84,66,157,130,20,164,245,40,89,72,177,188,125,7,113,14,95,179,137,71,164,176,169,41,44,22,70,39,133,24,38,39,146,242,65,60,11,33,159,14,1,64,7,228,134,95,5,224,12,234,156,36,189,38,17,98,16,52,67,228,84,212,235,40,49,64,227,91,220,99,39,203,196,203,72,64,142,249,22,239,128,2,241,108,6,14,12,85,143,6,16,198,59,229,109,116,131,97,249,38,254,141,130,127,79,61,172,253,249,39,124,253,119,82,180,212,251,125,188,54,229,1,233,188,91,71,120,130,159,65,86,178,44,242,38,218,137,63,255,142,45,235,28,192,236,179,218,87,109,158,161,125,158,85,159,206,104,90,213,217,97,22,121,76,167,226,7,134,109,82,87,159,214,176,206,207,178,42,7,240,156,239,45,245,133,59,191,117,240,190,139,47,42,177,44,178,165,128,108,197,167,73,13,185,47,132,115,236,19,135,83,82,251,66,89,228,21,192,132,112,2,6,194,192,128,106,64,181,191,231,172,217,210,123,29,150,179,106,91,196,52,216,209,204,216,234,29,28,55,90,76,36,83,242,68,27,174,228,190,11,162,29,39,145,147,136,85,162,161,74,241,24,237,52,118,17,30,197,110,183,232,88,226,175,88,45,54,130,136,70,196,172,179,136,41,58,230,144,195,37,54,40,17,151,190,177,39,254,228,112,60,197,232,227,35,66,203,5,23,206,242,154,53,150,124,77,118,15,240,171,138,32,106,67,20,110,207,55,112,187,9,183,119,73,12,199,157,91,197,43,224,117,55,139,197,10,19,181,103,145,250,44,113,163,190,109,220,154,165,13,164,68,198,138,96,97,61,225,217,75,81,186,148,72,59,64,111,144,241,144,165,86,90,54,36,141,205,39,248,123,187,150,107,31,126,31,123,152,139,237,151,80,35,213,201,101,65,183,48,64,40,155,70,203,146,98,197,40,117,70,25,230,107,36,68,84,31,70,61,113,144,23,112,2,0,223,43,104,82,251,62,160,92,241,121,23,76,180,161,226,237,155,188,129,3,75,13,100,224,146,72,188,220,173,230,139,164,206,25,84,121,112,236,141,247,63,192,249,99,18,138,146,167,73,115,45,43,127,77,178,242,80,136,223,96,180,16,238,186,80,56,142,247,32,152,228,37,124,29,143,237,192,200,177,234,174,3,214,157,62,207,244,190,183,139,176,241,160,247,122,131,43,214,183,18,43,135,232,180,255,170,174,218,133,101,16,252,205,95,18,104,135,226,236,68,228,195,43,220,28,66,220,223,203,40,214,137,218,43,140,100,32,154,255,79,13,231,51,66,252,170,168,246,144,72,63,24,255,48,217,174,178,108,73,227,43,97,87,32,77,105,97,82,125,176,45,230,94,31,127,98,63,159,55,125,172,192,82,129,97,69,155,172,165,7,139,51,110,132,162,76,231,178,242,158,182,196,2,69,51,175,149,246,111,22,53,101,76,88,130,23,168,91,225,82,208,125,227,86,173,173,190,203,101,250,149,170,246,50,209,25,140,46,171,170,24,203,236,37,133,37,235,73,191,154,197,146,215,92,198,188,6,60,166,159,240,223,72,32,89,122,227,18,151,164,58,24,7,58,63,188,43,4,126,243,107,117,169,142,177,76,104,168,127,142,77,189,253,163,206,213,195,231,51,85,100,75,169,220,13,117,162,128,142,253,27,154,182,112,244,151,199,97,164,131,239,34,236,221,160,78,73,110,109,132,135,101,70,111,122,248,244,187,165,97,146,1,134,53,70,110,240,66,97,130,132,117,41,0,95,116,151,186,104,35,83,7,193,206,7,120,249,188,250,40,82,10,64,179,104,29,138,7,208,169,231,163,188,4,187,43,110,1,108,107,77,198,84,31,103,29,10,148,49,219,189,143,55,85,253,158,95,30,197,66,47,189,207,187,109,93,67,0,194,183,177,129,100,157,166,230,100,165,233,66,109,152,20,204,127,114,18,231,151,67,78,61,88,51,47,176,38,196,206,179,219,132,55,111,187,232,120,80,87,115,121,73,225,54,135,38,188,29,91,205,102,144,121,197,223,41,158,120,76,95,235,34,166,186,253,1,239,18,178,166,124,43,217,193,235,242,189,90,183,29,237,117,92,242,86,45,134,220,154,231,212,117,253,147,140,152,81,120,35,201,35,179,13,69,180,223,145,17,21,183,86,218,137,70,134,67,153,235,4,183,240,85,252,97,126,226,204,195,23,254,175,250,176,180,171,59,87,30,113,39,236,23,49,87,206,75,221,40,145,233,104,12,69,1,42,47,242,234,213,46,151,4,8,175,153,184,124,249,243,201,236,97,26,21,127,54,213,162,67,115,74,107,142,90,41,91,242,231,83,109,136,64,75,195,252,245,223,87,205,248,193,146,15,63,251,43,33,193,106,175,240,122,70,178,236,55,110,53,4,199,198,79,196,61,255,228,31,6,85,186,134,130,220,109,58,213,200,45,190,14,205,248,171,3,223,121,161,39,166,151,183,92,222,43,108,223,60,90,172,136,109,107,155,187,180,244,239,71,119,193,112,182,220,188,147,155,46,71,247,144,236,250,38,58,32,187,11,47,11,23,219,74,60,80,22,114,5,10,173,31,14,53,30,5,44,175,39,121,66,98,162,162,35,159,174,105,141,27,61,67,214,34,51,57,72,16,89,111,225,48,128,36,32,178,183,21,247,27,241,171,253,11,29,76,249,50,53,137,112,80,213,243,4,209,224,13,186,120,136,127,101,178,201,97,159,84,62,104,242,240,188,226,161,185,107,212,137,45,160,8,215,233,53,234,160,177,135,61,49,176,137,174,245,132,232,181,188,144,230,136,197,113,206,105,238,213,93,62,68,206,197,177,36,150,218,64,13,72,10,36,32,54,154,20,72,44,43,222,42,163,228,209,148,224,0,66,247,38,62,249,205,115,13,248,253,136,43,152,128,48,200,93,9,36,86,179,232,98,188,132,114,33,47,104,22,19,20,244,51,114,103,202,125,25,147,14,171,248,214,223,29,150,140,200,99,121,68,248,126,100,200,17,214,203,139,203,95,171,188,140,192,22,225,63,87,220,40,70,54,94,70,235,45,230,50,134,229,99,117,103,105,158,240,46,6,250,167,102,241,161,217,64,99,233,100,235,91,11,118,217,22,133,87,154,232,193,120,75,216,151,103,206,192,174,160,84,203,131,50,237,228,40,113,44,227,175,85,134,242,139,43,177,7,180,141,196,43,37,227,200,45,11,58,173,241,87,129,203,140,135,244,25,205,16,52,207,203,64,206,6,83,249,185,59,66,229,140,95,188,119,107,15,75,181,202,166,215,40,231,140,254,127,103,103,33,68,150,149,161,28,192,200,248,202,14,191,72,77,228,174,183,33,164,13,50,131,196,198,89,134,204,6,110,203,237,77,166,182,103,14,128,221,231,94,198,142,37,128,209,247,93,137,217,221,243,135,222,28,160,177,241,60,41,186,188,170,203,176,49,72,169,92,180,28,139,14,209,73,45,167,147,34,35,68,218,116,122,28,88,138,214,18,17,185,188,29,144,109,89,161,155,183,101,246,151,8,86,163,80,119,87,61,233,234,43,173,123,92,199,244,13,113,108,218,241,113,213,28,228,160,170,172,239,165,83,151,22,105,193,91,3,110,98,90,118,8,181,79,1,188,211,138,237,170,46,240,226,173,178,106,103,174,214,8,223,232,139,171,228,254,45,195,158,92,134,2,2,95,48,233,119,26,29,6,229,10,243,206,200,183,208,102,45,208,168,84,154,244,224,132,101,166,183,184,125,204,213,227,38,198,204,20,159,29,204,75,168,245,242,38,171,82,146,214,116,54,29,5,7,249,176,127,100,189,71,179,24,109,110,243,180,18,24,191,226,217,193,7,23,62,244,52,144,45,140,27,198,36,197,33,50,167,127,162,122,95,131,3,65,72,241,142,31,62,50,15,17,250,208,162,44,13,125,35,184,177,136,80,56,248,16,88,18,119,109,32,39,158,245,173,213,149,150,14,172,135,140,199,204,179,182,148,3,51,147,238,11,188,44,81,124,83,209,60,82,97,214,190,147,228,177,202,223,158,194,185,165,149,196,27,119,177,243,228,198,58,10,11,19,30,192,114,228,7,120,36,196,161,24,249,225,135,123,34,136,127,73,24,47,135,20,134,23,247,69,96,65,63,35,63,61,53,184,92,212,85,74,25,163,25,44,79,193,64,84,227,60,40,170,170,73,10,129,87,70,146,109,242,132,72,228,47,160,64,173,192,45,232,56,4,126,170,182,179,80,108,222,99,187,127,224,172,166,220,239,153,42,89,116,210,248,212,89,73,208,12,166,36,208,192,140,79,41,31,32,6,59,215,153,254,254,72,36,5,246,173,126,155,34,219,171,137,123,20,198,187,155,148,41,45,104,102,24,210,103,96,57,224,39,41,183,166,30,118,76,203,47,185,251,77,244,151,142,41,83,1,221,119,201,59,255,110,203,65,173,9,56,206,52,224,130,10,236,180,103,186,56,11,89,149,80,120,52,96,54,135,101,243,207,159,35,175,117,171,123,32,51,161,194,14,120,246,198,51,234,254,77,74,23,214,149,160,63,9,47,63,59,163,240,196,200,204,110,167,39,165,248,79,34,196,11,238,235,18,185,195,128,50,206,127,102,231,180,215,12,208,54,19,160,243,142,8,50,245,16,174,170,153,182,86,20,44,219,209,152,24,151,66,98,154,51,52,8,234,204,106,174,158,105,92,49,67,169,165,133,183,157,54,78,56,180,200,54,53,111,100,77,165,24,253,139,84,149,197,197,171,59,60,80,126,194,219,156,224,89,11,254,217,178,231,208,225,213,227,199,214,172,145,93,75,49,57,108,180,186,99,110,25,130,67,250,196,165,52,208,249,85,197,129,213,156,178,137,178,46,212,59,50,187,236,239,130,24,109,142,129,51,119,255,128,189,234,100,161,104,181,251,36,189,13,251,165,201,70,90,129,168,74,53,153,171,235,136,13,221,77,16,44,241,91,110,63,210,177,91,129,36,69,129,21,46,215,19,205,12,197,56,229,49,151,149,62,191,56,106,49,107,179,16,206,142,25,175,145,234,108,191,113,9,58,124,111,19,235,129,120,60,13,146,17,180,111,242,19,233,203,203,132,51,154,168,144,248,129,9,113,29,32,56,49,123,93,38,44,217,182,156,71,118,22,3,72,58,25,184,76,138,255,187,3,14,157,131,235,253,1,173,248,253,156,119,78,69,192,137,5,43,207,185,125,212,199,244,166,209,58,113,197,110,221,190,213,198,47,208,30,144,102,156,136,41,175,23,220,100,179,110,87,172,135,104,189,180,115,143,235,138,64,142,25,32,207,156,65,255,74,82,133,209,41,152,174,113,193,99,10,79,75,73,73,72,72,199,131,251,11,182,97,88,223,84,157,233,34,215,75,188,135,247,65,27,22,55,134,15,177,98,238,239,216,219,29,42,150,248,34,179,88,114,193,135,127,61,50,164,61,231,22,211,107,83,131,69,146,69,159,190,101,26,234,206,176,161,206,140,111,185,241,193,104,150,252,213,177,69,236,122,175,58,54,128,99,173,168,210,213,178,41,55,238,19,51,164,72,115,95,29,88,130,197,235,231,215,174,82,218,162,156,134,179,171,182,153,151,139,57,209,45,118,164,167,82,217,192,228,224,171,138,102,15,41,88,197,81,77,203,113,96,94,199,212,179,142,123,134,10,141,252,31,192,222,47,234,60,133,142,191,128,149,141,5,171,132,53,81,7,138,88,230,233,138,74,84,120,203,245,220,11,115,50,115,250,215,10,198,26,155,81,234,191,225,67,181,87,123,102,60,122,112,168,151,68,88,59,41,191,80,228,245,171,177,131,188,204,122,147,62,40,114,71,26,86,253,221,67,234,148,221,253,77,239,209,201,222,240,118,165,21,21,234,152,187,161,155,204,254,31,177,168,85,170,127,232,175,248,45,50,53,131,253,51,130,104,116,227,118,8,116,150,148,87,96,213,142,254,60,231,132,154,166,52,255,104,94,68,56,241,220,52,199,248,188,157,43,77,240,133,145,245,227,17,119,75,133,173,207,154,129,135,83,221,67,230,47,90,43,125,62,8,144,109,21,234,126,198,182,76,207,198,118,114,136,230,237,169,47,140,135,203,123,107,238,64,114,121,40,238,48,163,241,138,70,206,255,253,108,112,161,19,133,10,72,107,170,108,252,197,83,187,251,219,101,236,29,218,105,29,103,169,137,127,225,192,72,115,239,142,35,248,203,106,224,125,229,207,174,165,49,200,223,65,4,127,111,109,78,245,122,110,60,134,103,123,112,20,202,185,98,177,7,162,56,153,35,61,248,115,122,114,126,209,185,208,186,163,63,223,129,233,30,239,95,28,156,237,28,237,191,57,57,251,205,134,7,211,124,89,101,183,81,80,34,184,225,119,84,223,135,24,112,136,127,29,216,50,203,103,166,64,134,230,125,28,137,116,99,176,246,28,144,237,144,200,245,139,216,110,80,219,9,1,183,110,204,171,26,11,214,189,160,225,248,155,181,58,222,178,169,111,37,31,238,47,188,143,221,143,233,247,25,223,119,102,198,53,234,238,183,222,10,177,57,149,227,247,29,62,164,243,227,157,57,111,255,163,53,168,227,142,228,244,175,137,13,142,150,68,182,180,117,59,27,98,109,191,177,253,96,162,112,76,82,99,13,211,242,128,128,4,134,124,81,137,216,140,69,146,39,18,245,86,132,38,38,225,240,208,242,69,221,175,64,141,195,65,98,35,57,179,194,2,236,240,218,0,101,234,171,148,98,55,255,57,237,130,140,231,38,91,253,128,185,35,76,172,121,109,147,229,158,58,248,244,73,212,163,94,87,141,99,243,148,55,28,211,84,142,179,135,100,205,240,165,120,90,17,183,244,150,222,232,213,15,94,126,225,218,145,203,23,184,134,224,116,212,90,25,180,190,232,132,162,144,65,52,218,77,74,28,239,0,10,165,85,97,81,196,83,55,58,140,116,23,114,247,100,73,146,50,3,111,1,171,32,119,79,151,49,185,184,166,100,78,25,3,227,70,63,186,251,121,57,82,247,89,222,235,249,9,233,123,253,224,236,155,193,208,212,195,80,104,110,66,190,179,71,41,150,255,5,186,102,201,156,96,76,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c848255-c02c-4ca5-9d7c-159a0d6b4582"));
		}

		#endregion

	}

	#endregion

}

