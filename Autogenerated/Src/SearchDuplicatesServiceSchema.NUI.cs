﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SearchDuplicatesServiceSchema

	/// <exclude/>
	public class SearchDuplicatesServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SearchDuplicatesServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SearchDuplicatesServiceSchema(SearchDuplicatesServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("449defd7-b106-43db-aaba-d60a41e7a093");
			Name = "SearchDuplicatesService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,29,105,115,219,182,242,179,59,211,255,192,170,51,45,213,202,140,228,56,135,155,23,103,108,73,78,213,137,99,215,114,154,78,51,157,14,45,194,54,27,138,84,64,202,137,155,241,127,127,139,139,56,8,94,178,211,151,167,54,31,20,11,216,93,44,246,194,98,1,82,177,63,71,233,194,159,33,231,20,97,236,167,201,121,230,13,147,248,60,188,88,98,63,11,147,216,155,34,31,207,46,71,203,69,20,206,252,12,165,83,132,175,194,25,250,242,139,143,95,126,177,177,76,195,248,194,153,94,167,25,154,63,49,190,3,157,40,66,51,66,36,245,158,163,24,225,112,86,128,25,249,153,95,104,124,17,198,239,10,141,39,203,56,11,231,8,248,193,161,31,133,127,81,238,10,80,156,187,195,36,64,81,101,167,183,7,156,93,213,19,241,94,163,179,2,0,180,1,80,154,2,242,52,3,161,20,0,126,157,43,163,255,188,244,113,246,151,249,221,155,204,23,145,119,138,195,139,11,132,83,217,171,234,97,62,87,185,83,123,48,42,107,247,70,251,165,93,99,16,97,22,162,146,209,0,96,58,187,68,193,50,66,216,6,65,102,157,243,4,253,95,99,116,1,18,112,136,14,193,102,50,236,207,50,218,241,70,109,249,29,26,22,203,51,176,30,103,22,249,105,234,76,129,106,132,78,208,187,37,74,51,135,88,17,67,56,68,243,51,132,9,184,128,127,190,12,3,103,18,56,31,157,11,148,61,113,82,242,113,83,1,159,102,152,112,252,18,108,186,45,206,94,148,33,28,131,57,92,161,86,232,47,194,52,251,15,159,11,145,205,50,38,94,2,82,217,117,180,175,5,130,55,13,36,101,163,251,73,4,182,36,29,141,177,232,40,26,83,167,215,11,100,25,182,201,28,89,120,33,94,180,76,43,231,198,121,29,130,83,54,230,52,64,179,112,238,71,206,49,194,51,20,103,141,241,160,21,157,66,176,113,134,151,126,124,129,142,86,83,159,38,34,26,76,238,84,121,141,213,112,183,218,231,88,211,100,6,97,248,16,5,161,191,162,230,247,130,0,67,12,253,68,130,225,212,91,138,132,203,20,150,26,124,221,22,237,132,70,195,214,131,133,89,155,145,68,184,98,179,107,139,246,91,184,88,73,85,135,8,95,64,196,206,150,184,58,254,132,224,99,173,28,148,243,53,66,233,12,135,139,149,3,37,241,85,177,116,53,9,34,83,68,18,19,20,140,252,235,214,50,252,49,89,226,214,72,135,97,188,132,220,169,100,114,95,163,56,96,107,41,155,43,207,63,212,233,190,217,75,23,47,17,89,10,22,224,234,103,97,4,102,67,150,135,16,163,57,68,182,212,85,191,16,151,114,158,58,53,40,4,202,227,13,65,183,36,48,23,242,62,231,7,103,223,79,17,255,214,115,38,39,200,15,142,226,232,90,205,135,128,214,71,58,149,60,71,56,68,217,101,18,164,63,56,199,116,12,210,69,165,118,180,64,44,207,84,39,187,241,6,82,141,73,124,149,188,69,46,67,132,217,116,142,143,166,167,157,158,179,159,4,215,211,236,58,34,51,4,176,67,24,214,191,64,121,171,247,26,251,139,5,10,122,132,206,6,95,65,15,18,60,247,51,13,129,53,121,63,165,73,220,3,215,77,23,144,165,162,106,184,174,170,216,179,36,137,156,231,40,219,155,205,72,184,128,21,230,28,32,153,208,142,226,169,127,133,220,46,51,197,13,204,28,199,37,40,93,208,255,20,101,25,24,69,122,236,99,72,53,32,239,112,59,156,10,76,175,99,161,212,233,146,116,108,227,102,125,164,70,248,6,182,111,41,53,78,101,237,165,70,147,76,178,90,236,58,7,97,28,112,99,145,174,233,234,41,53,102,255,27,130,4,17,42,24,138,197,9,240,53,148,150,244,79,57,117,176,31,26,48,201,90,149,190,13,23,77,197,68,97,215,80,70,196,162,184,35,221,206,162,164,55,154,22,181,54,178,146,145,107,85,123,146,66,90,43,123,162,113,125,106,241,54,26,190,157,48,125,153,200,198,158,42,210,88,233,32,205,61,167,137,233,193,80,47,146,153,31,229,168,170,167,22,73,174,91,136,19,226,46,250,237,223,38,110,105,200,235,47,110,173,70,33,215,20,181,217,76,91,104,194,162,116,231,230,185,182,66,225,6,209,74,40,194,136,214,83,40,134,153,36,11,83,30,169,236,89,115,251,48,140,163,90,20,255,40,171,240,113,86,38,11,210,245,207,178,139,58,97,172,183,101,136,10,150,102,33,174,86,219,202,148,47,230,26,205,155,57,154,146,15,105,72,235,34,185,171,132,150,92,231,201,85,46,47,62,197,220,130,88,111,222,188,230,174,36,230,169,185,212,202,214,35,211,187,117,183,30,33,175,58,235,89,187,216,163,22,245,233,223,197,205,27,61,161,8,3,109,7,17,228,221,140,65,218,85,60,234,218,117,102,106,27,39,161,158,249,236,58,62,251,102,152,226,156,240,98,175,193,16,86,148,241,205,33,4,189,245,168,59,20,244,83,220,237,125,30,250,145,177,162,165,126,254,223,61,136,70,17,89,245,216,75,135,151,104,246,22,5,117,138,17,2,77,145,138,83,106,231,107,39,47,110,48,183,149,87,153,221,25,242,50,78,215,44,71,82,152,92,4,66,172,119,193,190,56,191,206,163,81,50,91,146,147,50,178,187,61,198,104,225,99,20,64,115,117,109,84,197,251,48,143,64,46,49,122,175,82,115,25,123,4,112,28,209,147,56,7,177,255,79,146,247,41,192,3,150,55,196,8,152,224,253,110,7,67,15,95,120,54,42,110,156,104,238,150,18,64,32,199,249,243,244,91,36,207,158,81,190,202,137,9,54,207,19,96,101,118,233,184,214,203,40,218,136,78,24,91,88,16,130,177,79,184,116,190,98,186,22,52,219,157,7,43,25,11,96,78,182,156,150,55,137,99,132,79,209,7,34,61,109,62,158,13,250,52,153,210,51,94,183,156,97,126,195,194,202,35,235,51,217,98,173,21,156,48,0,29,9,196,233,237,129,31,199,193,240,50,140,2,183,124,138,221,70,136,108,12,1,11,75,3,103,58,61,77,0,195,133,201,244,20,77,26,101,63,149,120,106,163,14,237,28,146,122,234,70,120,238,184,69,235,241,232,101,12,231,63,206,224,182,118,244,169,249,39,195,219,193,120,64,18,235,231,7,118,55,80,36,40,34,224,208,224,88,96,210,8,39,61,199,58,251,154,42,174,197,34,201,29,55,187,61,66,143,144,153,2,172,153,162,8,41,164,67,131,44,51,36,128,227,36,137,150,5,58,184,237,87,79,233,45,24,111,60,95,100,215,21,26,46,243,240,162,67,27,254,43,199,42,58,106,53,211,185,151,220,104,171,137,80,151,178,80,233,71,60,252,198,7,34,87,45,175,201,246,97,238,147,249,215,168,72,33,135,233,194,58,67,124,233,144,61,174,186,2,48,216,25,95,12,75,97,233,121,0,171,161,236,95,67,90,23,158,135,136,94,215,0,140,138,163,245,34,247,157,169,133,72,167,141,86,175,124,236,160,244,29,95,191,57,199,99,101,160,159,151,8,95,187,175,82,132,97,101,143,217,205,97,79,5,56,244,99,200,46,48,75,83,32,29,160,146,246,88,182,225,118,126,121,255,177,127,147,43,2,178,2,115,18,93,161,120,202,9,237,28,38,209,114,30,3,47,146,49,15,124,144,53,187,29,54,248,150,180,49,9,117,16,146,27,163,41,129,118,149,102,102,159,172,243,117,152,93,230,34,77,93,214,72,175,227,224,48,101,161,216,27,191,91,250,145,152,16,31,111,32,143,80,65,154,221,191,107,112,86,71,56,58,87,69,216,233,247,183,251,131,173,199,219,155,7,247,31,238,111,14,182,7,253,205,157,193,227,209,230,86,127,120,112,191,255,120,56,28,143,6,29,77,176,220,36,197,85,99,93,182,144,73,141,133,224,249,221,112,67,225,130,20,93,14,116,82,124,45,216,117,250,185,77,201,244,132,145,229,106,165,153,136,142,44,81,20,245,79,2,105,0,180,193,99,214,226,177,102,114,109,61,219,191,38,182,227,170,246,226,41,1,13,254,209,228,85,16,148,164,0,151,72,153,15,241,139,31,45,17,247,77,125,112,79,1,208,9,11,239,102,122,230,72,121,55,91,118,248,127,236,147,126,112,63,187,189,131,21,252,231,73,78,63,12,84,207,81,92,134,124,59,73,146,140,203,145,102,206,225,220,199,92,114,84,148,93,133,208,57,179,228,231,56,89,46,202,56,22,182,155,91,12,12,2,59,133,228,2,172,52,202,55,67,36,184,207,50,239,8,43,212,99,24,142,97,115,70,111,227,33,108,105,236,105,171,159,72,146,149,89,80,101,201,129,149,8,105,202,211,121,10,59,52,177,233,115,190,249,38,167,108,94,70,135,120,26,47,163,168,2,196,123,129,226,139,236,82,243,141,2,83,183,21,192,70,199,24,85,17,134,209,211,213,82,35,50,176,26,178,84,206,218,172,32,38,157,85,38,244,50,201,180,57,53,50,88,91,60,190,145,206,166,133,186,230,49,46,183,9,123,108,43,15,109,168,16,211,90,135,32,225,192,122,40,35,28,125,149,71,29,186,191,14,227,84,134,30,37,136,138,44,165,113,108,82,53,172,111,34,45,230,61,52,182,93,166,108,104,162,195,214,255,93,64,38,251,20,45,7,226,93,121,170,87,189,139,13,51,52,39,114,181,142,46,231,204,199,161,51,38,40,158,190,65,186,209,211,156,100,126,155,8,236,216,115,28,200,112,52,230,234,178,156,228,236,79,24,100,162,69,107,32,160,7,108,210,208,52,102,43,84,43,104,218,23,142,242,32,152,215,214,115,89,115,154,102,162,3,77,183,117,248,141,98,89,128,92,98,1,69,177,105,189,249,221,249,232,116,238,143,70,163,253,251,195,225,230,131,251,227,241,230,246,206,112,123,115,239,209,224,96,115,188,51,222,122,240,232,224,193,206,120,123,167,147,147,220,232,236,236,61,218,219,223,30,236,111,62,124,4,72,163,131,193,96,115,103,127,107,111,179,223,31,140,30,246,199,59,247,31,15,31,118,110,186,134,173,220,221,44,217,20,29,81,78,232,9,167,208,178,199,59,22,168,101,143,99,73,91,213,8,201,156,130,143,219,46,23,84,72,180,203,3,21,68,35,7,100,250,30,19,110,26,38,129,170,225,223,54,9,52,70,47,207,2,105,80,206,195,109,49,40,147,184,89,21,180,73,127,206,152,125,97,173,141,231,194,96,109,129,157,151,53,4,1,189,248,186,250,118,217,188,79,217,102,135,124,103,41,112,49,252,54,217,96,218,247,151,197,141,229,32,47,180,220,65,98,163,165,170,214,189,220,193,96,103,180,61,120,52,110,180,151,35,44,76,210,17,136,54,140,103,164,146,146,225,37,146,93,39,201,123,230,133,79,157,193,3,231,123,170,41,217,59,133,111,10,132,236,252,76,210,165,59,222,1,126,170,13,96,165,79,182,118,65,113,105,212,184,201,89,234,128,85,183,70,233,168,77,11,90,242,100,6,100,163,123,127,233,10,162,232,92,162,115,173,67,198,32,213,206,167,46,173,83,102,155,38,215,4,145,36,154,57,110,17,160,36,158,220,180,174,187,85,237,103,72,64,46,76,74,53,229,127,43,101,159,119,165,76,76,182,167,169,209,7,27,96,139,58,88,193,191,37,177,207,164,36,150,75,131,178,36,246,67,68,26,197,243,101,198,118,202,238,83,49,175,35,45,110,195,149,83,81,147,25,89,100,90,38,56,80,246,210,150,1,155,149,93,245,205,132,22,200,243,209,249,73,79,203,68,166,104,113,105,229,20,90,207,153,90,220,114,17,16,47,196,73,44,66,239,43,218,98,216,127,207,54,167,110,158,185,122,176,166,185,197,140,103,18,192,196,184,57,201,131,13,38,235,174,130,253,250,18,97,148,103,100,228,64,9,242,30,234,239,110,1,91,141,53,146,194,94,28,228,1,176,26,95,10,34,55,104,69,6,222,248,3,154,45,97,250,178,87,74,105,223,159,189,253,76,132,84,51,201,90,33,213,8,185,173,144,132,211,59,40,74,81,110,96,234,106,40,93,157,127,127,234,212,175,157,36,88,77,98,16,5,36,84,90,192,211,37,252,68,27,79,142,196,190,31,132,152,166,21,6,3,226,24,147,194,148,68,251,13,27,41,162,198,17,58,87,194,99,234,214,34,40,208,110,135,141,28,28,145,210,145,120,205,5,108,233,223,183,163,34,21,169,45,192,43,208,216,162,52,114,157,183,162,96,55,103,110,189,213,148,232,147,198,2,228,222,119,118,237,77,209,44,137,131,58,245,45,27,169,143,209,106,163,63,137,113,43,5,150,144,81,53,88,39,253,74,18,91,13,141,160,132,200,42,58,20,164,152,18,191,187,87,186,33,202,119,5,133,205,16,155,178,99,61,252,46,221,17,241,142,89,94,22,21,235,25,167,134,249,149,56,135,237,51,238,184,22,209,81,223,197,64,206,226,115,142,69,38,96,175,205,42,105,186,194,249,167,42,60,80,198,79,19,198,33,63,36,170,173,147,220,125,53,128,166,221,90,34,11,112,111,250,191,175,80,219,83,180,170,18,178,229,178,34,253,159,85,101,177,150,45,123,90,98,165,218,5,127,243,233,185,18,51,21,34,208,112,141,138,153,254,144,222,93,219,233,243,40,57,83,42,12,114,48,164,26,234,2,39,51,148,166,168,236,36,185,115,44,1,228,83,27,20,53,75,50,63,42,67,59,101,157,6,10,201,31,202,48,84,105,176,23,62,145,232,170,32,207,146,160,17,178,71,222,125,243,233,106,122,159,145,107,25,202,203,211,170,70,158,102,32,107,206,70,170,190,121,127,3,143,3,248,93,147,160,54,112,97,15,105,24,80,59,214,21,196,2,219,180,175,41,203,5,14,202,216,205,107,128,226,29,102,79,29,134,76,116,226,116,159,57,135,126,118,233,157,128,150,2,215,229,239,59,235,186,82,36,206,119,206,160,15,202,187,199,248,235,246,156,173,174,243,131,211,159,43,226,144,206,209,78,26,18,207,18,48,201,89,133,120,123,90,189,80,68,38,179,235,154,204,84,233,81,58,102,59,198,37,94,9,227,236,5,74,117,76,139,83,102,147,141,230,129,191,172,86,171,5,111,245,17,200,154,160,207,64,249,6,177,152,192,116,14,194,56,76,47,81,126,107,146,147,251,51,57,227,209,214,94,46,160,99,179,176,174,86,14,120,30,82,94,64,216,91,44,242,55,74,230,239,150,156,204,231,228,173,113,25,226,67,254,148,156,185,133,220,6,26,201,145,133,217,76,175,140,116,196,233,184,206,118,207,220,212,189,78,240,91,250,110,83,207,218,61,92,98,242,230,14,210,170,90,65,219,117,211,102,237,106,94,110,66,49,211,234,76,98,96,253,130,60,14,211,49,32,164,163,247,159,172,104,49,198,211,124,165,9,109,237,211,129,159,179,61,177,7,244,136,245,20,238,20,124,95,180,156,74,131,226,228,39,0,52,66,153,31,70,100,6,192,182,54,30,91,188,21,163,109,60,108,73,254,206,141,217,106,203,172,177,218,160,173,48,37,86,189,49,25,98,72,42,216,219,102,97,95,196,254,103,86,173,244,144,119,210,222,94,156,37,199,14,125,7,148,237,124,28,220,56,207,96,85,250,184,117,99,60,93,234,241,183,228,25,173,244,133,123,70,155,250,2,191,188,78,196,103,229,17,171,254,45,137,137,221,137,63,39,241,121,226,189,202,102,28,82,211,171,40,242,228,1,138,232,22,212,209,19,98,18,244,219,70,134,134,161,161,65,108,168,8,14,205,162,131,242,188,107,254,68,107,205,82,242,105,125,173,217,138,151,44,110,187,224,77,151,41,185,217,47,35,84,201,171,72,236,1,199,46,71,109,204,186,98,129,182,185,0,253,10,198,25,58,47,238,86,23,118,43,55,84,204,8,120,121,87,25,139,148,81,184,27,50,251,36,14,99,230,251,222,41,72,120,144,87,105,61,177,169,33,5,90,222,232,29,224,100,238,150,179,176,76,37,40,175,18,179,93,80,121,129,183,32,18,81,39,22,4,44,59,157,10,114,197,45,144,227,167,92,150,76,231,76,200,70,229,184,160,91,245,121,91,243,25,215,82,45,223,221,19,184,236,213,73,229,79,225,170,207,210,21,88,229,127,51,51,82,122,69,40,162,31,247,238,105,76,200,142,230,247,242,228,121,68,147,179,8,69,39,194,68,168,157,142,231,176,196,202,131,7,64,76,69,102,203,47,38,233,240,211,183,236,146,94,83,248,31,147,57,58,190,132,176,223,2,231,48,57,11,163,214,88,45,224,185,109,87,159,125,132,242,212,195,106,180,226,148,163,246,58,249,29,107,236,53,58,251,52,82,161,240,96,239,33,225,194,143,218,98,30,248,31,254,86,233,75,159,201,107,193,138,71,169,186,176,156,184,214,222,220,101,131,104,39,87,22,250,171,158,94,149,176,170,213,185,20,136,188,86,196,43,198,230,35,168,53,215,2,148,1,204,237,176,82,149,131,85,137,236,246,213,203,216,204,74,71,180,199,92,175,248,50,65,151,164,178,233,104,75,73,229,140,106,44,129,19,58,194,181,84,226,2,129,84,189,181,116,154,236,97,236,95,203,75,33,150,105,155,150,70,63,248,221,5,215,242,34,249,234,7,175,181,231,174,249,217,22,1,224,127,150,104,178,254,76,82,210,168,58,200,210,161,180,211,30,122,184,163,63,201,44,79,140,42,240,234,14,189,170,80,45,15,129,155,60,84,60,34,93,65,57,191,107,109,123,52,187,1,190,246,10,253,2,25,173,183,158,90,165,141,146,55,36,216,72,40,167,160,55,60,69,224,185,135,26,227,120,2,82,19,221,56,98,195,184,166,209,92,53,162,21,24,83,98,25,239,179,68,49,13,235,46,226,151,120,25,127,211,200,85,100,91,139,89,37,156,55,142,86,229,248,171,197,41,62,61,51,66,137,224,164,253,140,3,31,155,4,36,75,218,42,66,145,198,97,81,35,245,113,72,35,80,21,138,10,128,197,104,196,65,148,56,84,141,84,23,138,170,177,181,159,165,80,70,215,218,213,235,87,2,64,254,40,69,201,21,254,26,174,5,186,50,102,222,102,92,36,83,135,205,127,212,98,165,81,5,182,50,168,104,170,24,147,255,36,198,106,243,164,184,234,36,45,151,166,155,233,168,168,157,102,42,254,45,92,40,168,191,137,183,60,215,160,149,120,173,26,185,13,252,66,240,46,70,89,53,148,221,238,210,83,33,198,170,59,226,16,165,167,9,221,117,202,149,129,106,141,129,42,59,84,81,226,218,28,20,187,212,31,1,129,157,76,71,11,51,142,75,226,45,5,47,189,189,201,62,77,142,190,127,42,208,228,27,32,58,163,14,169,125,188,90,44,32,122,118,73,9,171,215,81,37,201,15,197,124,170,26,226,147,92,60,228,240,109,100,105,239,26,146,221,91,44,120,207,49,78,174,194,128,9,150,55,193,232,22,18,234,121,115,154,193,164,3,90,14,14,150,56,47,49,234,173,197,50,81,150,46,254,56,212,11,23,178,46,175,225,122,218,225,179,88,21,216,254,73,110,130,90,32,25,66,39,63,107,54,119,191,237,125,219,93,149,22,55,56,8,23,126,244,106,178,10,75,165,181,243,106,106,71,203,108,177,204,148,31,153,96,5,195,63,174,136,190,200,141,111,139,238,44,94,211,153,196,25,162,106,109,51,22,194,56,193,127,204,217,91,180,90,12,70,94,118,146,143,196,126,182,205,29,237,179,5,59,1,83,62,203,255,180,4,129,20,216,25,237,203,38,87,94,211,149,136,30,61,178,57,197,126,156,250,12,106,146,38,17,219,108,160,43,20,17,69,5,175,98,146,92,134,25,44,143,34,102,153,211,22,73,132,164,172,46,118,38,180,204,83,108,23,221,45,113,133,188,133,191,91,78,133,28,228,82,121,62,177,144,208,227,79,5,145,1,39,66,202,140,44,218,233,171,139,34,181,33,149,135,42,182,238,147,13,37,208,224,66,13,175,178,238,172,190,254,108,197,146,164,16,95,217,85,247,54,55,207,239,254,198,185,86,21,23,151,103,221,149,46,61,223,226,198,115,171,59,225,74,242,93,188,8,222,60,227,46,41,90,179,235,170,70,234,173,73,41,191,164,250,63,22,83,205,173,112,187,152,6,119,36,38,126,35,212,82,225,87,223,254,71,90,110,254,11,216,122,47,229,242,116,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("449defd7-b106-43db-aaba-d60a41e7a093"));
		}

		#endregion

	}

	#endregion

}

