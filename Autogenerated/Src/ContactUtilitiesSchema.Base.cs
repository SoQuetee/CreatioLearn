﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactUtilitiesSchema

	/// <exclude/>
	public class ContactUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactUtilitiesSchema(ContactUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ed9513e0-8962-4ef7-9da0-fa9db5e93539");
			Name = "ContactUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,92,221,115,219,54,18,127,118,103,250,63,224,216,23,122,234,210,201,107,98,171,149,191,122,234,37,177,19,197,205,67,175,51,71,147,144,197,43,63,20,130,116,162,94,251,191,223,46,62,72,128,0,41,90,114,157,116,218,135,76,44,16,216,93,44,118,127,187,88,2,204,195,140,178,85,24,81,242,150,150,101,200,138,69,21,156,22,249,34,185,173,203,176,74,138,252,203,47,254,247,229,23,123,53,75,242,91,50,95,179,138,102,207,59,191,161,127,154,210,8,59,179,224,123,154,211,50,137,172,62,103,97,21,90,141,47,146,252,189,213,248,150,126,172,130,55,244,182,78,195,242,252,227,170,164,140,33,229,182,159,46,104,150,21,185,251,73,73,251,218,131,179,147,222,71,231,121,149,84,9,117,114,155,175,115,156,23,60,249,170,164,183,32,19,57,77,67,198,158,17,208,87,21,70,213,117,149,164,124,48,239,115,120,120,72,142,88,157,101,97,185,158,200,223,87,101,113,151,196,148,193,3,74,73,84,210,197,177,39,7,123,135,19,82,115,2,107,146,209,106,89,196,44,80,84,14,53,50,171,250,38,77,34,194,42,88,156,136,68,40,128,131,255,30,174,217,30,254,83,162,190,20,52,159,129,12,201,93,88,81,245,188,43,38,111,120,67,171,186,204,13,49,185,98,214,237,74,163,188,197,194,49,17,92,147,58,79,162,80,245,186,89,19,154,133,73,74,194,56,198,197,12,26,182,135,93,190,71,171,176,12,51,146,131,77,30,123,53,163,37,208,204,37,191,137,198,234,218,124,4,76,146,28,52,146,71,52,56,58,228,52,220,36,185,28,222,228,220,16,103,112,68,36,38,53,139,95,215,180,196,233,215,89,254,10,158,120,19,57,93,146,196,228,61,62,35,17,127,200,199,141,162,137,100,122,169,98,207,49,116,75,177,82,147,135,88,41,160,174,200,33,253,149,48,20,101,106,93,178,228,123,90,185,8,177,147,53,215,175,111,46,18,49,151,243,0,200,150,232,94,124,73,14,144,223,222,94,81,87,170,185,79,239,7,196,238,228,80,228,62,225,14,176,119,23,150,132,114,193,231,209,18,88,189,12,243,240,150,150,228,184,35,14,192,86,101,244,240,165,26,141,70,111,159,132,140,56,30,60,111,152,69,14,141,136,174,92,66,96,156,211,15,6,9,222,238,59,132,60,32,238,133,218,23,220,250,52,4,44,54,8,17,76,227,88,244,247,21,135,96,22,123,251,1,14,55,136,59,52,187,29,121,110,220,14,6,247,161,113,90,82,48,199,248,18,52,16,92,150,49,45,79,214,83,22,249,251,173,242,23,73,90,241,197,221,68,93,144,186,224,221,223,37,213,242,10,157,138,194,15,230,139,70,24,9,142,150,176,34,127,187,94,65,84,120,95,135,41,172,199,171,58,187,1,51,144,230,186,199,109,119,127,220,132,4,93,134,19,243,133,156,114,160,112,185,141,34,131,129,118,61,208,55,109,88,208,251,157,7,31,55,172,139,105,255,135,17,202,222,147,170,32,46,243,34,139,162,148,112,5,88,209,69,65,68,137,45,225,123,38,17,26,177,168,90,2,20,213,101,9,86,207,29,17,103,175,60,113,28,28,183,72,9,146,3,78,2,12,163,11,45,18,90,246,131,228,139,132,85,200,94,82,97,2,124,216,24,220,211,125,184,15,248,206,217,251,77,160,247,125,13,225,162,153,132,142,82,178,145,67,39,59,159,191,238,69,138,14,112,57,208,104,28,112,52,156,116,95,147,6,222,215,83,55,98,235,225,182,78,165,18,32,233,85,173,118,30,81,10,193,218,51,244,133,143,61,177,100,1,80,97,212,239,201,144,3,107,24,60,102,21,11,184,84,56,17,167,171,55,50,111,244,219,171,146,130,200,144,54,174,150,69,78,73,206,23,137,59,234,251,58,137,126,33,140,134,101,180,196,68,43,78,110,19,176,235,34,79,215,99,253,148,211,244,38,87,58,105,192,134,85,89,68,144,29,245,250,210,27,122,7,58,165,177,41,83,181,12,43,49,63,72,200,116,105,6,93,76,134,115,57,205,57,159,141,176,68,95,62,226,76,148,187,68,203,176,252,233,103,209,118,198,89,76,97,93,48,182,194,174,129,126,132,189,195,42,133,13,141,207,59,28,144,239,188,127,159,193,58,122,16,54,222,22,167,48,150,247,86,113,131,255,8,228,108,252,46,77,115,225,208,33,133,64,61,29,229,34,126,69,243,88,164,221,242,183,150,131,199,5,230,224,60,137,31,88,241,31,97,15,5,88,198,56,82,210,143,128,91,84,135,78,9,125,12,54,36,203,178,200,147,95,5,116,51,90,85,32,220,214,25,246,180,73,163,119,2,105,20,235,44,41,21,213,230,79,36,218,17,121,52,218,207,226,206,228,251,81,254,34,13,111,53,157,141,80,146,97,154,198,254,234,166,40,82,50,99,184,243,147,48,117,142,132,55,193,252,92,215,0,49,244,209,23,3,68,171,80,247,101,121,27,130,188,180,132,89,91,153,234,169,232,131,18,4,167,138,138,48,211,57,197,204,128,136,255,166,171,85,145,228,85,134,203,119,44,240,13,237,87,60,236,166,14,50,161,217,219,11,100,36,184,168,243,8,254,174,243,202,247,24,67,247,193,12,81,235,119,81,22,153,239,77,97,248,29,198,31,152,226,92,42,22,252,108,202,248,40,173,251,12,88,149,63,128,64,190,247,18,96,239,166,248,232,24,146,25,67,46,115,222,34,89,7,51,198,161,90,137,227,160,130,221,156,28,231,107,54,141,179,36,191,206,147,74,73,23,118,89,65,139,197,10,217,27,163,77,22,239,150,180,164,106,100,179,22,26,1,161,204,160,137,65,190,22,220,112,43,33,22,67,44,94,178,32,190,97,41,228,248,216,52,164,224,122,149,22,97,99,49,123,142,117,182,215,62,152,230,177,210,217,249,199,85,81,86,114,205,0,93,134,36,173,202,154,218,66,254,78,104,202,232,214,2,204,50,46,64,251,112,27,17,116,68,182,185,157,127,164,81,93,209,121,20,166,97,121,4,173,19,127,159,76,200,19,133,207,3,85,143,221,64,151,124,128,108,163,1,76,158,89,126,98,28,190,31,124,246,213,73,118,6,218,97,197,60,56,246,154,240,106,214,25,148,235,244,3,37,217,132,145,78,128,236,2,128,234,43,64,114,12,224,141,134,171,109,176,106,55,160,146,52,184,27,11,60,158,67,126,67,75,110,29,83,81,68,27,34,37,52,111,249,241,142,30,108,218,138,92,100,172,226,88,178,109,183,39,211,205,6,204,66,252,132,140,126,85,173,141,96,203,248,127,231,178,219,6,235,129,4,116,229,63,29,176,164,126,253,74,2,159,135,69,61,108,228,19,117,118,31,119,193,241,141,88,253,194,81,162,59,207,89,93,210,179,147,182,201,223,111,98,161,164,49,195,215,12,111,104,8,234,35,113,251,231,177,190,76,202,192,196,51,191,101,217,82,227,193,184,29,31,224,127,26,51,89,249,1,178,90,31,94,21,192,73,255,24,166,53,61,18,6,51,233,110,169,85,252,146,255,25,193,140,19,221,57,78,241,16,193,33,151,111,198,254,136,82,206,39,143,79,201,109,94,148,244,10,114,137,48,69,239,102,64,1,134,67,190,112,160,215,185,13,179,63,156,8,173,204,231,87,164,157,12,238,214,165,113,192,94,22,12,83,241,111,85,211,19,253,84,195,31,176,221,192,41,157,172,119,8,122,194,196,56,53,75,85,96,181,139,16,146,184,78,44,20,58,208,53,182,83,48,180,163,224,48,6,105,96,165,234,65,162,79,84,56,112,202,133,56,216,83,50,54,163,94,219,190,117,94,110,41,177,129,2,167,218,236,70,153,4,43,225,53,227,107,247,19,32,221,171,162,234,17,208,135,56,184,143,172,121,209,10,108,120,67,98,236,16,97,135,204,248,13,5,52,163,119,148,181,165,211,20,107,169,178,210,131,208,155,202,218,106,23,111,68,137,245,211,131,141,148,99,66,166,141,168,198,91,73,234,120,17,216,87,55,238,22,140,13,31,62,75,184,52,48,191,35,244,74,149,128,78,180,178,177,122,69,182,49,53,65,198,42,146,200,98,181,163,102,204,164,167,246,113,214,95,145,136,82,161,224,14,195,100,1,92,250,56,37,199,192,38,120,91,38,153,143,197,178,23,197,7,48,189,253,125,233,73,242,49,55,211,87,117,154,94,150,60,29,242,85,121,19,61,229,31,58,3,176,250,181,22,54,205,242,39,211,173,86,136,198,129,104,60,234,184,171,220,237,107,154,177,221,53,52,49,16,203,93,68,31,2,172,75,237,151,149,78,141,103,47,129,75,47,132,34,161,220,130,5,230,235,234,54,83,117,171,40,61,140,128,90,153,123,115,57,91,227,3,147,94,209,252,36,45,162,95,108,137,7,0,77,79,168,155,186,82,112,89,90,68,128,132,207,73,129,197,249,77,199,211,180,96,84,112,109,194,131,120,39,232,243,255,155,162,201,28,248,64,56,159,178,8,146,106,224,168,191,112,128,63,219,119,138,61,89,233,217,73,147,145,238,154,156,162,145,151,102,66,58,38,23,253,176,76,82,74,252,178,39,21,149,27,21,89,128,63,150,28,70,167,163,123,102,234,208,75,0,187,77,124,221,88,27,10,202,161,127,106,168,252,140,94,204,25,109,206,122,13,56,24,122,11,210,23,132,110,214,230,59,8,0,234,48,95,147,10,3,229,167,141,57,92,44,169,112,12,60,171,206,59,22,225,188,15,20,119,120,172,224,171,100,70,26,254,98,103,228,97,12,77,224,129,56,211,114,178,35,203,92,16,58,118,190,204,209,201,107,69,79,109,160,244,243,54,178,108,138,29,13,123,78,27,193,202,37,165,162,50,2,228,94,22,55,224,110,92,105,0,117,7,163,199,93,130,149,148,247,31,246,207,34,107,152,137,57,61,215,38,245,112,33,241,207,18,227,250,194,147,110,36,163,226,156,43,88,182,54,242,121,134,176,63,105,4,106,224,9,95,200,143,141,30,35,234,33,91,68,134,129,205,127,123,64,228,175,185,121,25,169,154,173,247,54,124,95,252,64,27,155,90,22,42,198,236,106,248,174,131,14,236,55,56,177,135,216,108,100,217,192,230,98,62,189,110,224,16,235,22,168,128,145,104,203,251,115,242,13,54,12,215,110,145,151,0,98,201,213,89,15,81,2,247,98,175,234,48,102,159,225,222,40,54,59,68,27,146,5,231,199,223,130,116,151,105,16,193,231,189,8,110,145,217,140,225,127,111,32,198,108,32,148,95,52,195,185,123,110,183,117,104,61,123,56,58,100,133,177,107,88,128,47,246,66,190,234,197,113,113,33,145,72,150,211,19,141,8,175,248,110,125,210,230,33,15,67,66,92,112,108,20,62,191,234,185,25,74,238,10,176,26,177,52,92,6,181,97,217,20,57,122,67,144,154,251,189,138,223,232,81,252,148,125,11,117,237,241,225,6,238,146,138,102,136,120,24,43,94,27,189,249,163,224,95,20,208,3,209,16,43,245,198,150,8,135,95,107,193,108,240,244,77,19,75,172,34,183,234,48,162,146,62,170,148,126,239,90,250,208,27,191,220,239,104,112,171,18,186,210,146,246,235,241,138,230,143,2,213,98,78,187,227,245,195,21,108,2,225,127,218,219,143,126,204,29,147,127,247,191,29,112,38,214,247,200,171,239,127,113,231,193,16,119,215,98,204,69,146,199,157,186,191,111,220,125,33,131,136,167,35,213,2,72,209,134,216,245,44,30,174,200,68,142,108,243,49,78,150,119,25,26,7,182,133,97,245,245,220,254,12,185,125,112,219,170,193,236,122,124,123,204,244,30,118,98,98,10,205,181,19,121,136,73,91,98,253,218,144,112,254,158,219,47,157,115,254,77,96,104,73,129,75,213,105,165,221,239,234,39,52,246,46,202,222,2,32,63,140,150,2,14,133,172,176,33,182,88,53,224,102,25,249,53,7,56,49,18,217,162,110,98,27,229,108,53,4,252,113,123,125,52,208,174,49,77,211,36,100,10,234,248,246,209,118,44,113,180,22,54,239,126,87,30,13,138,29,195,196,245,158,206,136,231,189,25,172,111,147,216,124,141,167,129,219,48,77,187,119,89,176,26,254,215,190,189,99,227,176,253,2,118,92,145,226,94,151,117,134,46,5,117,9,119,227,237,176,251,181,119,91,70,251,157,180,174,46,205,102,251,46,60,17,247,240,253,158,101,109,248,58,25,238,40,11,77,67,88,51,136,215,205,233,89,81,182,250,219,72,221,135,23,95,128,186,56,74,183,11,255,217,24,169,101,141,122,56,177,175,102,158,81,243,110,230,163,216,55,175,255,145,111,173,7,63,61,249,121,156,141,147,103,68,175,9,141,55,116,115,189,209,192,149,197,67,4,27,178,117,18,230,49,137,11,24,149,91,253,68,179,238,16,176,79,151,125,243,162,34,139,162,134,193,73,174,176,31,108,30,149,194,117,195,61,47,18,235,178,219,105,244,79,232,85,58,5,169,140,201,153,152,191,154,117,191,43,158,234,144,51,198,1,181,76,125,11,215,107,94,162,10,65,149,39,202,229,58,38,222,119,30,249,90,62,20,86,188,241,136,177,240,98,59,57,229,211,58,126,136,155,137,45,31,190,135,63,13,25,149,219,131,215,234,183,111,117,42,242,56,145,46,220,246,84,141,190,249,83,36,179,121,140,57,111,147,56,189,160,139,170,77,205,76,50,232,156,237,51,223,44,183,255,46,68,49,197,8,222,36,183,75,141,158,72,194,28,181,26,185,48,251,58,17,152,32,118,127,7,158,51,171,104,230,155,164,15,136,85,83,240,158,122,54,133,243,148,81,99,66,246,176,39,158,85,24,26,243,246,65,63,48,222,20,136,26,198,162,174,51,99,50,89,21,174,225,89,245,36,13,158,187,143,58,111,51,70,188,20,110,94,30,108,115,139,96,187,179,73,125,62,208,188,5,208,99,78,159,58,204,78,155,15,254,60,194,113,244,63,199,73,244,161,224,199,191,18,99,230,118,113,194,86,105,184,38,119,200,252,1,191,245,130,44,146,71,250,216,139,33,128,218,43,3,227,89,60,50,220,116,180,96,6,31,57,12,180,241,75,219,192,215,10,239,116,103,97,69,18,70,60,254,5,152,35,78,109,226,5,141,178,5,249,164,201,48,197,151,98,100,169,141,33,191,36,86,133,37,69,187,104,146,65,126,105,156,191,200,16,116,48,139,176,222,100,232,162,245,101,170,122,156,60,19,115,229,51,216,242,171,47,238,44,86,47,114,242,96,167,197,198,13,223,137,113,117,114,124,205,100,184,88,198,6,82,102,85,202,235,78,80,170,30,39,213,39,155,250,124,136,214,199,245,9,155,78,9,69,100,198,78,57,49,25,114,202,223,224,132,174,73,87,207,129,218,74,223,44,20,140,216,58,190,15,15,5,78,27,245,160,248,132,249,109,74,229,173,40,204,170,142,48,171,18,198,252,53,241,38,158,42,235,228,149,242,249,23,73,198,79,229,191,164,113,82,103,248,117,49,68,101,206,158,103,39,216,50,79,126,165,228,27,242,212,228,37,157,88,206,73,151,49,120,65,243,219,106,73,38,6,19,21,228,190,213,181,17,204,235,27,249,209,128,39,7,166,76,223,24,179,145,52,21,145,103,58,17,41,151,227,216,4,66,127,43,166,72,7,141,219,111,74,127,58,180,51,121,89,131,159,255,135,253,146,208,223,51,149,130,130,61,195,146,249,26,221,3,226,17,239,192,16,119,223,113,235,96,92,220,184,72,82,144,187,103,83,132,48,235,93,212,105,202,155,61,2,27,131,52,38,34,158,58,134,220,209,18,50,132,123,212,12,20,155,30,132,31,23,90,90,198,58,153,153,164,115,129,34,159,106,178,145,36,91,165,20,47,55,218,31,61,112,188,21,69,253,160,210,57,29,159,163,181,10,46,82,250,3,226,230,69,26,193,148,231,99,250,208,52,226,141,242,28,84,219,57,33,163,47,164,100,16,180,126,44,134,6,45,14,226,35,158,94,203,223,243,219,172,185,16,14,212,12,0,8,100,139,58,16,153,220,209,206,87,164,130,166,77,246,121,153,196,113,74,59,157,218,70,33,235,230,18,212,8,35,75,74,38,194,39,190,96,196,210,75,243,67,176,211,45,144,9,19,52,173,225,225,45,177,127,31,247,217,89,40,44,59,39,195,30,217,66,53,171,139,218,63,221,166,10,79,124,221,162,205,82,86,96,153,43,244,87,141,102,79,135,225,98,223,166,217,236,237,50,97,236,222,182,223,59,183,22,48,216,206,113,192,198,186,9,105,119,232,80,37,164,103,209,244,36,72,182,13,39,122,106,253,138,155,255,82,97,20,98,212,44,22,121,238,113,247,187,155,166,185,207,215,76,221,107,198,213,20,153,101,55,211,242,220,198,172,29,11,180,217,10,235,34,191,253,166,66,157,121,222,188,59,0,182,223,162,28,136,71,220,58,199,10,145,144,110,151,42,133,85,4,204,2,205,16,101,167,192,40,107,155,243,110,98,206,139,10,203,226,3,218,22,166,166,187,190,229,157,183,180,148,66,77,242,193,85,153,160,217,105,201,26,232,114,154,126,8,113,233,100,117,3,143,20,117,19,113,49,63,227,123,130,29,202,230,107,74,181,170,218,183,3,37,49,134,23,12,66,216,45,143,36,54,87,253,77,98,102,127,235,85,117,231,249,182,47,168,97,79,121,160,91,135,90,117,235,171,154,58,191,238,51,107,118,163,11,230,252,158,69,63,101,145,14,146,35,242,116,147,161,117,23,210,161,245,14,237,77,181,119,135,77,232,66,15,186,41,239,60,82,228,198,92,118,19,215,97,117,250,65,228,142,119,189,43,96,35,141,95,87,134,25,52,127,79,25,163,217,77,186,158,229,73,149,192,126,253,87,26,143,241,111,45,72,118,107,81,45,27,139,137,44,126,9,187,85,165,252,142,6,177,2,230,70,126,7,52,245,132,104,75,100,113,27,212,181,124,141,10,247,245,253,169,140,78,115,125,153,212,223,174,15,183,117,175,10,104,2,187,63,195,38,90,205,70,222,246,127,139,5,255,245,3,91,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed9513e0-8962-4ef7-9da0-fa9db5e93539"));
		}

		#endregion

	}

	#endregion

}
