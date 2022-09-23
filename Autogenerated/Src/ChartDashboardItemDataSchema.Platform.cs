﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChartDashboardItemDataSchema

	/// <exclude/>
	public class ChartDashboardItemDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChartDashboardItemDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChartDashboardItemDataSchema(ChartDashboardItemDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e1ce786-21ed-4c7f-bd65-8d7710672b23");
			Name = "ChartDashboardItemData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,28,107,115,219,54,242,179,111,166,255,129,209,205,180,212,68,199,182,247,154,155,186,238,76,100,59,169,115,205,227,98,167,109,206,227,233,208,18,100,243,34,147,10,65,57,230,165,254,239,7,96,23,224,226,69,74,182,167,189,15,173,35,114,177,88,236,46,22,251,2,203,252,138,241,85,62,99,201,9,171,235,156,87,139,38,219,175,202,69,113,177,174,243,166,168,202,207,254,240,233,179,63,236,172,121,81,94,36,199,45,111,216,213,174,243,91,192,47,151,108,38,129,121,246,140,149,172,46,102,30,204,65,222,228,222,195,19,118,211,116,15,247,171,171,171,170,164,191,107,150,29,150,77,209,20,140,119,143,95,178,143,141,152,73,18,250,156,87,101,246,67,81,126,232,222,210,85,72,116,10,38,252,186,102,177,231,217,193,52,244,234,237,81,246,19,59,23,220,105,234,106,201,179,55,140,87,235,122,198,190,207,203,249,146,213,146,68,49,232,143,53,187,16,156,72,246,151,57,231,223,36,251,151,121,221,28,11,150,176,131,156,95,158,87,121,61,63,18,75,63,102,146,99,211,117,177,156,179,90,141,91,173,207,151,197,44,153,201,97,27,141,74,190,73,166,57,239,69,187,243,73,161,238,104,18,124,107,242,178,17,116,189,174,139,235,188,97,240,126,5,63,146,153,124,159,240,166,150,235,254,249,201,77,193,133,104,215,87,229,147,101,145,243,100,47,25,221,200,103,163,93,196,202,202,57,32,150,191,188,121,234,245,172,169,106,49,147,90,24,78,4,139,220,100,121,233,91,206,106,129,168,4,205,74,214,214,207,137,166,146,207,46,217,85,254,82,104,241,36,41,202,38,105,138,43,246,239,170,100,175,22,11,206,154,137,156,116,103,231,249,73,245,158,149,201,42,175,5,92,35,68,53,73,240,17,151,68,188,38,207,207,171,106,153,84,181,32,96,218,62,171,171,245,234,105,193,150,243,177,194,243,77,114,46,24,158,122,148,16,18,156,233,201,148,227,228,147,66,242,139,51,165,96,171,243,100,87,193,189,114,105,16,128,30,93,10,244,214,23,7,21,198,235,186,90,177,90,238,33,41,245,170,17,100,179,185,150,59,254,132,101,123,83,74,24,160,250,130,53,64,150,86,21,142,15,110,109,13,170,89,62,175,202,101,171,249,235,174,118,215,158,22,161,142,109,32,107,90,245,23,126,237,212,172,89,215,17,164,146,18,143,28,84,146,95,102,74,141,95,231,205,165,67,192,117,81,55,235,124,169,1,247,13,92,148,134,98,145,164,4,95,118,196,95,174,151,203,87,245,225,213,170,105,211,177,22,179,16,116,7,36,68,231,44,49,251,49,95,174,217,183,48,237,119,41,108,44,152,125,52,222,69,12,114,42,128,112,102,33,168,201,132,206,140,135,252,67,246,166,170,154,99,165,158,153,216,240,87,121,221,194,28,25,252,81,68,72,197,213,51,222,194,223,91,155,221,14,247,44,78,111,164,117,190,5,120,254,234,252,63,66,2,192,22,56,111,118,45,0,165,144,223,231,92,156,27,236,68,108,170,167,85,125,149,55,81,169,160,252,230,22,180,96,66,156,227,54,168,97,58,174,249,81,144,239,246,152,241,176,222,93,200,173,180,239,40,31,44,208,209,188,103,54,100,191,250,57,104,123,116,208,129,28,86,196,118,59,69,116,240,91,218,232,207,253,112,42,25,98,236,70,122,249,130,53,151,213,60,118,0,202,19,228,25,107,148,33,20,0,85,93,136,69,42,23,164,5,154,165,58,10,230,53,255,90,179,186,125,186,46,213,17,112,84,10,78,94,11,89,22,248,15,205,5,137,110,133,104,128,68,254,177,104,102,151,73,234,66,238,204,196,201,146,108,60,83,246,66,56,33,151,223,32,139,244,20,130,195,95,107,182,157,11,75,252,126,247,78,184,127,98,236,125,0,245,159,31,8,245,60,111,3,216,255,242,0,216,15,130,152,255,250,0,152,191,23,142,94,0,245,223,30,8,245,139,162,92,55,44,48,193,223,67,19,204,217,34,95,47,155,0,248,87,1,112,216,56,184,111,44,101,116,108,214,113,85,139,19,241,160,80,228,137,109,249,173,208,81,237,102,125,39,119,5,2,88,54,144,167,65,203,171,213,250,58,175,205,156,18,179,160,177,100,31,251,167,74,209,236,192,207,211,51,7,181,116,152,236,39,217,241,106,89,52,233,23,187,95,224,200,133,112,225,115,185,203,228,244,11,56,10,138,210,197,99,182,222,246,251,91,144,96,28,87,25,216,188,109,138,165,12,125,26,61,92,143,72,23,244,164,216,161,172,200,158,204,231,169,103,107,140,93,152,36,11,239,144,113,165,40,209,132,36,121,93,21,243,68,160,215,162,2,59,201,167,45,172,188,95,100,253,106,224,203,34,170,24,193,195,82,90,196,162,156,179,155,78,91,141,180,228,187,247,172,13,136,42,251,39,107,59,121,17,169,186,170,192,79,5,130,179,93,203,39,200,117,240,162,133,51,74,30,3,13,187,191,181,252,233,76,106,134,195,155,85,205,56,151,7,19,56,89,228,193,30,238,101,111,80,182,47,24,214,48,120,178,239,12,75,237,51,118,66,92,90,77,133,59,147,136,107,101,112,241,108,93,204,51,17,92,203,191,122,15,42,94,127,160,188,192,29,60,200,51,73,199,196,48,108,226,45,79,79,96,33,23,59,153,205,138,69,171,48,169,160,51,85,210,139,82,46,166,101,37,76,44,8,179,113,145,119,100,49,140,127,160,60,246,22,227,136,37,181,112,118,222,77,136,101,232,168,196,100,13,130,64,70,160,51,36,54,41,60,78,45,186,50,51,33,161,252,42,95,33,189,100,115,130,142,79,146,74,185,211,223,25,250,78,71,160,121,163,51,49,6,254,57,49,175,174,165,143,165,216,171,94,43,22,219,196,51,69,60,218,141,23,249,234,84,193,72,96,65,197,110,231,137,122,17,99,199,161,39,171,213,18,49,40,168,20,22,174,87,132,254,156,218,135,143,31,199,61,233,24,27,5,231,158,92,92,8,167,78,0,105,30,234,160,2,125,88,25,84,104,122,52,172,96,219,73,187,98,40,5,247,233,94,226,60,17,78,233,186,108,232,121,148,228,222,152,1,143,122,33,100,169,93,105,201,179,112,104,225,160,237,28,233,24,165,169,243,104,124,88,174,175,164,210,115,150,54,226,119,181,240,32,180,6,184,115,209,35,102,59,19,229,139,167,223,56,225,214,112,76,148,19,251,32,61,91,152,169,77,172,20,97,134,109,168,130,12,206,78,170,99,33,166,89,147,106,174,185,228,76,228,6,38,98,141,200,41,162,82,70,188,182,205,34,176,135,98,151,250,74,169,159,102,7,5,111,138,18,207,255,152,236,250,77,142,109,218,58,78,2,248,139,13,204,77,106,137,74,218,9,215,182,192,27,216,18,1,251,150,117,150,222,195,36,78,246,92,141,147,235,37,200,8,26,170,101,42,195,108,224,1,155,103,198,28,77,235,144,190,208,102,141,216,142,16,9,226,140,135,225,214,108,105,228,116,67,127,13,222,198,61,53,215,82,246,203,81,171,14,218,35,149,19,60,40,106,166,21,63,110,137,108,208,97,155,100,195,187,38,41,123,229,206,156,218,79,2,22,201,1,208,6,201,153,232,46,209,188,159,98,170,174,89,93,23,115,17,216,168,180,114,162,242,202,169,94,132,171,26,27,235,186,62,100,110,58,69,209,103,0,252,66,174,35,156,206,237,141,156,225,237,198,195,91,58,252,161,242,92,82,232,94,118,205,8,184,39,118,8,122,245,59,55,206,174,161,51,158,121,94,58,202,55,97,75,17,41,7,130,176,13,108,151,239,213,246,56,69,224,57,9,33,227,96,192,57,241,42,28,26,149,103,54,92,64,219,17,114,23,191,141,201,208,83,62,132,51,117,107,44,248,154,51,181,131,213,108,189,218,97,65,106,229,160,218,40,163,84,185,49,158,99,66,183,117,199,76,236,217,198,136,35,38,207,220,113,218,228,241,22,112,229,168,11,71,204,84,156,69,30,135,220,137,44,47,7,77,2,135,63,123,170,174,147,161,129,176,76,55,64,196,202,44,248,204,177,78,161,10,160,85,231,146,138,160,32,191,252,242,203,228,91,190,190,146,89,208,239,240,183,2,23,27,6,225,147,143,197,252,130,53,153,134,254,146,128,159,122,88,211,145,26,62,26,159,125,22,170,40,122,240,161,26,34,80,23,44,29,14,149,244,124,122,208,94,149,170,56,166,109,223,76,201,117,146,12,84,248,252,114,158,85,134,3,156,26,151,59,216,25,8,106,114,123,111,146,241,229,185,136,91,196,95,146,178,126,216,213,132,240,111,179,194,123,213,2,205,193,249,131,240,49,181,169,72,36,111,186,225,114,68,176,62,97,141,153,91,99,244,62,179,49,233,164,166,245,80,154,157,55,121,121,193,148,237,177,112,126,74,70,170,252,135,214,65,216,159,17,150,69,229,63,85,176,37,254,74,127,99,164,221,139,29,171,188,38,222,182,246,207,119,234,103,190,82,94,81,247,90,161,79,110,157,202,208,60,64,189,29,184,122,124,68,165,57,54,117,98,109,75,163,92,196,185,70,93,105,121,116,223,18,135,107,107,212,3,113,54,241,68,185,236,50,73,144,204,228,142,248,130,39,239,18,201,129,204,12,163,70,199,248,174,112,186,74,20,138,127,74,75,211,35,41,220,55,44,151,253,9,115,243,207,201,102,13,13,51,31,200,2,160,89,229,128,255,54,52,28,122,73,200,152,112,200,147,198,61,137,177,231,25,12,206,233,70,28,48,39,242,238,26,207,103,193,67,197,190,41,162,22,152,83,202,61,67,158,125,56,169,225,244,108,218,70,198,63,111,39,227,159,127,7,25,171,93,139,142,57,26,98,125,60,91,41,126,233,223,21,229,246,242,55,206,131,244,45,4,18,153,102,78,30,109,160,72,110,194,194,248,105,219,232,146,156,240,71,35,193,251,43,5,166,33,134,104,143,123,253,232,201,6,92,62,60,19,199,36,58,215,233,197,9,208,59,54,68,216,110,125,64,87,119,156,154,238,109,151,66,185,59,237,56,139,90,64,160,98,82,138,168,54,20,127,235,227,93,240,90,170,234,180,85,106,158,62,127,82,215,121,155,228,242,255,166,85,168,201,235,11,220,7,122,90,163,133,26,79,33,144,72,85,84,35,13,113,136,64,171,179,4,210,81,158,122,227,198,136,138,25,240,42,59,96,108,117,248,97,157,47,121,74,8,152,0,50,82,110,199,133,22,216,159,231,112,119,136,13,176,94,40,96,228,169,58,111,225,25,156,225,116,83,170,202,187,170,246,228,122,107,42,72,189,51,85,227,6,191,172,214,75,33,60,160,246,9,127,135,75,63,14,61,87,90,237,238,107,36,137,131,54,136,185,160,42,100,72,137,243,222,12,233,152,179,181,0,160,227,33,68,44,217,45,10,205,73,221,10,8,189,83,192,64,34,178,137,154,232,20,3,248,51,156,241,88,87,57,205,92,59,91,208,117,171,87,132,139,22,252,151,138,11,230,130,170,48,17,147,86,22,186,54,51,110,79,41,5,89,85,135,49,96,118,187,247,161,192,80,47,27,117,211,29,98,56,17,212,27,233,4,117,52,107,244,114,156,187,120,170,216,81,45,32,184,238,190,15,55,215,70,215,120,155,74,188,166,107,81,173,203,121,88,84,6,107,72,80,221,184,71,158,168,244,100,6,198,112,216,85,23,186,84,216,215,38,175,164,56,13,54,60,110,56,8,55,181,253,128,142,79,109,65,212,174,15,239,238,168,53,81,99,106,198,215,75,25,130,139,224,146,253,127,217,0,28,209,246,140,104,125,171,241,232,136,171,183,52,145,10,98,77,126,253,53,9,188,108,205,75,245,175,76,215,13,96,18,149,236,7,62,252,250,171,22,124,20,16,216,48,166,167,47,178,119,33,78,16,115,254,90,237,36,161,109,133,98,135,209,61,18,15,44,71,159,150,242,255,154,16,68,167,158,105,147,99,150,163,158,198,87,253,249,231,201,35,0,17,167,191,98,63,31,30,138,234,112,167,177,96,160,229,88,4,169,224,73,58,150,128,240,239,76,173,117,24,215,203,97,191,67,121,205,16,108,166,244,156,157,233,220,112,192,12,207,48,217,168,244,234,0,218,129,116,252,122,214,155,239,11,141,112,144,182,91,35,13,141,112,43,32,216,225,217,199,9,146,118,76,195,237,217,27,6,7,49,55,118,52,51,49,62,239,175,217,254,76,51,2,99,125,148,201,105,219,248,180,237,189,167,125,23,157,150,119,188,9,79,206,251,115,182,144,15,25,154,95,65,153,121,7,80,242,166,93,110,128,83,129,137,8,166,170,55,198,28,244,35,6,198,180,56,166,165,99,76,18,151,54,25,247,120,191,199,250,216,176,142,30,76,5,197,238,12,56,245,184,46,101,227,119,246,59,188,241,19,66,36,215,29,172,200,117,200,199,110,232,227,123,84,96,202,245,6,179,53,200,217,110,238,146,60,150,159,210,84,148,180,6,221,207,40,44,53,30,114,62,250,144,174,132,106,57,77,21,32,149,244,78,8,189,106,225,93,221,32,36,152,66,6,152,215,167,197,82,130,164,22,126,15,131,25,100,215,6,172,65,118,145,64,210,60,143,5,66,112,123,72,37,40,230,231,135,55,108,182,110,42,185,40,59,79,156,29,150,124,93,179,131,105,247,136,52,112,35,142,112,198,197,208,150,1,118,6,143,211,110,54,18,31,126,188,44,150,44,33,9,132,76,254,161,189,226,102,53,189,238,127,69,170,159,32,33,146,25,162,233,9,139,109,221,120,61,193,54,241,67,69,74,166,48,231,187,7,155,51,104,55,112,140,130,215,131,251,162,16,106,38,212,32,95,21,73,246,56,100,131,116,203,230,91,90,75,227,90,111,251,239,121,37,231,90,161,55,50,80,166,162,58,96,184,3,87,82,162,118,9,203,145,78,135,128,76,248,235,212,219,214,157,255,192,89,58,30,185,161,24,76,159,67,199,17,188,77,225,207,126,117,181,202,235,130,99,203,141,32,182,106,36,189,58,107,134,130,14,9,193,181,25,15,195,251,7,168,202,74,230,91,47,220,107,31,50,132,176,1,48,113,52,122,42,157,255,81,39,158,168,162,157,247,155,198,91,170,71,11,53,6,243,64,3,186,212,193,234,213,104,1,10,82,96,242,105,43,111,106,166,29,36,2,170,194,238,49,88,198,41,148,197,80,212,253,196,70,100,171,78,61,68,96,196,250,172,46,84,108,187,149,104,77,49,16,72,134,234,183,189,213,22,168,140,247,218,112,4,189,151,3,120,176,107,79,42,154,187,116,211,171,2,211,22,23,161,20,181,30,142,238,128,33,34,215,45,195,40,8,202,167,9,229,231,196,109,82,215,41,10,59,201,236,41,83,28,163,147,228,176,240,28,121,77,11,128,77,29,136,133,98,0,60,112,12,27,24,160,35,2,96,205,111,120,28,177,101,20,115,207,157,178,1,109,85,201,219,62,8,237,211,130,5,228,80,145,174,171,143,170,31,17,75,165,248,72,223,94,149,63,149,210,30,201,54,221,62,71,215,248,119,242,119,74,198,192,122,54,219,105,2,15,176,114,96,33,102,5,158,19,73,88,252,74,249,153,58,84,243,36,171,95,163,232,95,231,23,44,63,95,178,55,200,15,49,204,97,141,120,195,129,47,240,206,186,96,172,135,219,125,120,240,12,104,55,111,178,253,117,45,27,211,157,145,194,89,152,23,242,61,166,41,134,219,209,64,81,44,239,2,151,31,12,114,192,134,9,57,117,182,33,13,203,87,157,242,230,169,204,104,124,229,6,27,222,221,91,107,31,105,69,51,229,156,174,209,205,51,76,38,29,105,21,245,157,154,187,135,233,148,208,247,167,228,235,179,248,174,209,215,43,45,253,12,175,219,187,37,14,122,77,248,229,233,181,190,144,179,109,132,23,141,64,165,194,191,97,179,170,158,243,254,253,154,244,110,85,188,199,46,188,1,99,176,84,2,48,116,102,37,246,153,210,27,211,220,97,235,199,219,75,67,193,236,128,161,112,2,68,52,255,195,166,207,240,176,227,31,225,157,71,243,78,248,196,31,214,135,187,69,156,218,181,195,35,192,28,107,142,187,210,143,171,231,148,219,38,164,237,235,163,164,221,15,80,223,230,189,245,245,93,43,136,189,87,32,252,128,145,240,38,161,240,102,177,112,176,11,193,97,18,69,186,109,133,127,163,238,1,66,78,95,160,139,237,13,94,185,190,171,17,245,197,188,6,40,94,43,136,69,182,157,109,19,180,8,21,101,114,135,162,142,68,12,49,90,153,21,192,203,166,12,117,123,15,119,56,127,81,205,215,75,246,139,121,0,191,229,173,62,101,145,30,39,208,4,137,143,97,9,82,215,112,126,231,179,45,194,235,133,191,74,30,113,184,180,35,71,59,27,109,195,78,207,52,153,83,241,75,224,64,108,217,83,214,204,46,29,179,137,144,202,60,53,181,186,61,51,171,100,64,147,189,61,121,250,15,121,127,16,43,13,4,37,201,52,145,225,178,181,4,245,113,172,62,130,115,192,36,27,243,101,241,95,150,218,211,232,190,243,237,15,55,164,154,17,215,9,77,254,214,231,157,198,69,66,156,62,52,161,80,8,49,180,27,98,8,124,199,64,90,89,107,184,19,76,217,168,71,71,115,218,115,103,178,39,82,181,64,37,177,20,132,141,241,163,79,95,221,254,242,233,107,241,223,159,111,71,19,143,107,19,186,246,9,93,6,189,121,35,145,163,250,201,213,117,130,60,213,243,158,37,57,215,166,168,91,150,53,208,13,18,37,230,101,193,85,39,52,186,97,166,161,135,140,59,29,81,32,83,67,150,232,173,209,94,29,154,120,12,113,165,164,40,140,89,33,166,227,116,36,235,171,178,57,64,174,79,217,140,221,168,173,137,245,177,232,32,255,13,91,48,225,99,207,88,199,127,115,81,189,54,89,40,16,11,218,167,139,206,42,233,149,209,152,193,146,39,122,76,64,159,87,131,6,95,227,200,244,33,120,120,201,117,177,163,174,166,44,76,33,132,231,228,250,128,170,56,74,35,57,238,62,66,245,114,93,100,194,43,184,46,102,76,88,56,182,84,237,180,234,155,84,185,56,255,172,59,6,217,15,85,245,126,189,74,62,255,92,155,241,158,228,29,33,197,108,162,218,231,163,44,226,24,201,91,25,69,252,198,71,248,98,116,215,44,71,166,51,122,48,132,96,127,201,242,186,67,113,188,94,44,138,155,180,27,101,21,224,109,73,121,77,19,142,32,61,39,164,123,251,34,47,69,112,86,75,242,143,212,119,179,102,194,34,43,39,215,214,33,175,57,135,34,113,175,177,208,233,179,167,69,57,167,96,211,150,112,200,91,24,94,187,114,148,59,208,23,210,113,248,52,40,66,114,49,207,65,150,69,191,188,18,138,173,72,237,182,59,212,177,162,20,221,60,38,4,33,171,12,108,184,7,225,155,27,203,216,30,156,113,119,162,229,90,187,239,49,195,218,213,120,96,188,56,144,114,73,196,104,66,215,104,50,33,100,131,226,251,238,183,145,75,224,50,99,108,58,219,100,76,192,94,120,86,226,240,166,97,37,87,159,232,179,112,155,231,217,73,37,239,235,165,14,73,99,167,150,58,236,230,97,35,192,176,155,215,53,203,242,135,10,54,251,76,246,157,118,186,151,97,50,174,156,42,96,28,20,124,181,204,209,125,71,18,61,77,125,29,129,77,137,95,18,197,231,238,110,100,152,254,122,136,183,239,236,173,22,67,171,133,106,185,54,182,115,182,117,158,154,14,127,180,23,159,250,110,43,33,216,131,196,183,27,18,191,129,95,136,44,151,29,64,206,99,233,19,222,145,254,54,70,191,117,71,152,15,103,135,250,247,148,239,205,160,159,239,199,94,193,76,141,53,208,81,61,15,105,96,167,123,72,157,54,66,3,25,92,168,123,158,72,62,78,219,99,131,179,199,144,72,239,17,135,7,141,125,140,49,189,196,223,193,2,69,189,79,226,114,82,159,16,89,111,168,63,29,161,38,168,83,218,101,152,5,56,208,145,65,58,194,73,184,176,249,221,161,200,237,48,253,221,186,129,76,221,70,137,124,55,195,233,241,219,105,32,84,41,241,126,148,182,149,183,63,206,121,226,124,156,115,70,101,224,93,223,210,11,237,73,29,244,39,12,188,52,70,96,53,61,195,221,149,184,249,135,187,92,141,15,94,16,122,163,200,225,224,41,153,43,66,228,10,170,234,124,53,195,237,139,66,206,93,123,178,133,85,57,215,216,37,210,160,107,182,169,186,13,104,32,119,45,192,89,215,22,137,119,168,105,159,164,181,167,239,95,103,176,47,159,24,44,238,209,27,152,39,214,117,101,122,246,250,64,29,247,148,54,74,59,75,236,90,160,187,214,45,184,172,106,53,168,121,153,101,227,51,118,13,209,110,212,10,121,161,110,109,72,111,17,168,186,116,101,231,205,200,113,145,234,104,38,74,21,240,142,136,254,212,22,215,153,46,162,115,210,205,23,253,16,198,40,231,179,81,39,224,237,191,78,177,197,167,52,84,164,110,143,151,233,143,25,83,13,11,134,113,62,141,115,102,136,12,172,222,153,70,174,223,126,180,27,25,51,109,7,122,118,53,84,232,0,234,176,65,168,216,253,14,28,66,170,11,180,127,46,218,2,234,99,144,218,160,123,4,149,18,145,235,64,189,103,88,175,49,43,208,143,79,170,133,174,123,232,226,112,175,37,211,86,127,163,203,140,126,127,162,255,81,234,72,243,8,232,67,160,57,51,244,121,151,105,187,141,44,195,159,176,78,246,58,92,66,239,212,139,105,171,94,141,156,12,100,207,21,60,52,85,119,248,128,183,117,20,195,234,221,243,216,107,230,164,15,252,111,114,235,77,69,205,214,30,101,37,236,42,75,147,134,214,183,177,126,205,33,174,185,207,161,169,85,205,246,239,213,22,216,162,212,59,228,249,247,58,184,200,21,167,240,76,112,108,88,49,253,221,57,54,197,86,157,126,206,249,197,239,255,51,110,78,212,53,168,64,41,119,19,6,235,92,10,222,28,145,44,86,39,237,29,89,10,123,136,91,151,82,46,236,119,65,175,6,13,158,229,233,197,35,186,175,112,148,131,25,26,163,12,138,223,198,225,115,115,45,146,131,78,200,153,200,79,44,211,223,223,238,249,228,224,87,3,9,216,227,199,222,69,52,120,185,25,147,252,62,131,32,191,28,148,189,247,249,172,209,61,241,68,232,11,55,183,255,3,162,18,222,131,53,100,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e1ce786-21ed-4c7f-bd65-8d7710672b23"));
		}

		#endregion

	}

	#endregion

}

