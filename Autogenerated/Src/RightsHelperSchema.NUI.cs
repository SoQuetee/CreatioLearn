﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RightsHelperSchema

	/// <exclude/>
	public class RightsHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RightsHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RightsHelperSchema(RightsHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf88b463-ba93-4b8a-bda8-612ad1556887");
			Name = "RightsHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e3c1e484-f7d7-414f-86c2-8efa1a10cabc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,29,107,111,220,54,242,243,22,232,127,96,54,64,32,3,27,249,250,181,201,250,224,87,18,23,137,19,196,78,139,67,17,20,178,68,123,117,209,74,91,82,187,142,47,245,127,63,146,195,55,41,237,195,219,216,185,139,11,164,150,52,28,206,12,103,134,51,195,145,92,103,83,76,103,89,142,209,57,38,36,163,205,101,155,30,54,245,101,121,53,39,89,91,54,117,250,190,188,154,180,244,12,147,69,153,227,31,127,248,242,227,15,131,57,45,235,43,116,118,67,91,60,125,230,93,179,209,85,133,115,62,148,166,47,113,141,73,153,7,48,175,203,250,207,224,230,25,206,231,164,108,111,204,131,83,124,221,50,52,156,166,95,104,83,155,7,54,173,211,105,215,19,130,187,238,187,44,118,66,29,29,116,62,58,174,219,178,45,49,237,4,120,59,195,128,253,117,115,197,128,24,216,99,130,175,216,53,58,172,50,74,127,70,32,215,87,184,98,128,226,249,238,238,46,122,78,231,211,105,70,110,246,228,181,128,69,237,36,107,209,140,52,139,178,192,20,101,136,226,22,53,151,104,34,198,162,41,110,39,77,65,209,101,67,208,117,67,62,113,98,174,203,118,130,136,152,33,85,168,119,45,220,179,249,69,85,230,40,23,232,93,74,6,95,4,53,154,220,23,37,174,10,70,239,59,82,46,178,22,195,195,25,92,160,15,20,19,38,203,26,22,28,253,49,119,174,159,73,76,184,46,0,153,139,153,1,210,150,204,243,182,33,28,191,32,73,162,7,242,108,194,18,111,42,119,166,29,196,245,114,48,240,8,64,99,20,80,52,24,220,246,147,245,6,228,217,193,49,163,152,11,248,37,110,223,227,188,33,133,52,143,124,130,167,217,17,190,60,101,246,148,72,24,218,204,73,142,225,145,34,144,224,118,78,106,231,81,122,214,102,164,165,191,177,37,75,134,204,22,134,59,232,159,2,118,0,120,184,178,230,89,155,216,99,70,104,40,38,102,176,63,35,23,76,160,24,161,56,180,205,191,226,104,209,148,5,58,83,252,188,107,104,201,37,165,153,16,24,56,91,35,244,114,206,32,217,48,174,69,204,204,231,211,250,215,172,154,179,7,101,205,244,83,14,84,156,50,140,135,115,218,54,83,31,175,133,48,134,107,168,45,103,4,35,79,10,198,142,198,190,230,10,54,45,91,120,92,192,115,223,194,196,141,35,220,98,50,45,107,102,89,215,19,54,144,89,20,251,71,242,141,38,25,69,68,144,1,230,132,152,145,213,77,155,106,116,187,62,190,231,179,140,100,83,84,51,6,199,67,195,236,112,239,156,97,229,119,185,233,154,25,210,231,187,98,64,124,124,40,160,225,222,59,184,135,114,113,19,45,248,221,126,44,130,242,215,120,129,171,225,158,80,4,84,241,139,112,16,104,39,221,123,190,171,126,3,69,145,82,68,23,77,83,113,213,127,149,73,141,183,108,96,29,133,1,245,14,80,8,18,41,50,228,42,93,90,100,68,226,53,112,204,182,25,37,113,28,75,148,12,148,72,217,98,18,96,126,226,144,48,30,91,151,235,169,159,229,210,162,186,247,88,253,140,248,175,250,210,220,23,143,2,104,27,2,217,151,200,60,72,195,81,200,7,66,191,156,189,61,29,161,199,113,204,143,251,148,92,233,199,97,12,101,26,144,236,112,20,33,229,103,53,224,108,158,231,152,237,73,79,67,186,173,95,71,10,252,248,243,27,6,157,93,97,53,64,1,128,88,20,182,49,186,204,42,138,145,167,215,176,203,72,189,61,156,224,252,211,97,86,31,78,178,250,10,239,23,204,37,104,79,244,146,100,117,139,113,178,3,234,40,204,128,186,184,65,165,36,46,172,201,26,163,51,240,206,199,211,25,132,54,131,65,203,140,23,16,13,142,14,84,212,115,92,95,49,31,132,48,252,111,236,111,165,169,15,9,168,6,0,159,174,68,188,28,98,8,103,155,175,196,115,43,254,101,219,71,62,65,201,241,231,28,207,196,246,137,63,43,11,28,148,151,40,193,159,81,73,145,166,67,129,105,152,129,205,55,254,156,202,11,57,239,45,194,124,13,98,176,53,190,70,175,155,60,171,202,255,100,23,21,6,145,37,190,8,222,99,185,169,177,128,129,141,83,187,154,12,16,134,96,40,252,103,24,224,162,233,105,83,27,194,129,238,20,28,170,146,203,173,37,9,233,26,120,212,201,8,88,96,210,178,240,148,148,28,41,126,123,241,111,70,80,194,105,150,188,24,53,147,178,149,14,238,216,17,135,252,29,102,113,246,177,30,223,224,104,181,107,70,95,207,216,237,189,36,115,116,139,237,205,123,39,133,70,211,187,11,137,145,31,234,178,61,41,232,112,79,18,96,13,22,63,187,203,241,228,89,205,86,48,159,183,88,99,121,220,77,193,255,158,163,98,129,85,220,192,197,110,235,175,15,108,194,191,127,68,182,248,71,176,147,27,73,42,19,94,203,179,209,62,207,198,253,133,111,192,39,20,82,61,77,30,101,38,205,144,240,216,194,56,145,118,66,154,107,225,18,60,104,3,172,93,79,226,26,239,221,253,41,75,162,112,198,157,32,15,57,230,66,90,44,186,117,132,103,185,59,112,190,157,11,18,174,5,96,28,217,146,119,25,248,238,156,191,57,231,252,0,157,244,21,40,32,247,206,17,111,166,16,46,73,61,100,198,37,81,184,30,178,27,197,255,143,191,213,25,173,240,187,90,228,241,108,120,123,142,245,62,66,198,174,92,158,215,26,162,35,153,189,91,2,9,193,34,57,253,119,223,247,77,249,190,192,233,221,135,159,35,178,64,20,196,147,10,215,255,129,123,58,194,21,110,59,236,87,134,126,90,76,15,208,27,57,1,151,34,148,135,92,1,209,218,115,245,113,172,70,125,15,171,190,69,215,34,246,36,183,14,203,200,39,152,109,168,92,46,80,141,21,252,163,182,65,185,216,185,248,193,136,160,4,139,128,154,47,161,220,122,250,107,181,210,138,22,37,105,231,89,5,85,112,119,79,124,7,136,143,21,94,189,43,74,25,220,85,247,163,27,177,156,20,234,154,238,62,220,39,57,182,67,211,110,73,208,85,29,234,204,158,253,3,143,31,37,61,170,30,206,18,152,63,231,24,149,5,91,147,242,178,196,164,63,136,116,115,254,227,122,62,101,246,202,52,84,213,192,197,115,145,21,89,40,105,63,78,59,255,143,20,239,217,99,41,0,163,26,82,17,108,180,177,229,103,66,236,88,115,154,200,82,182,43,158,17,58,49,60,61,231,32,123,110,158,13,54,209,145,108,223,85,127,180,235,52,137,255,135,254,140,213,36,172,142,154,5,26,30,242,105,161,139,100,175,183,119,83,79,29,9,62,0,53,29,238,237,199,116,114,213,92,233,148,121,72,117,21,57,154,89,79,235,220,12,35,92,20,127,221,227,169,199,150,220,148,175,52,62,141,75,116,38,122,128,215,113,32,199,183,247,30,117,121,0,90,178,169,51,139,173,63,240,187,93,199,115,239,46,198,97,106,19,47,179,170,103,249,48,43,50,174,45,204,197,151,53,99,137,249,153,70,5,133,235,166,17,195,61,29,79,178,68,162,87,23,106,113,164,107,192,249,117,255,174,213,20,206,0,126,221,59,160,192,52,39,229,12,220,138,25,103,221,238,76,110,120,46,243,148,45,221,52,107,85,244,174,51,155,147,58,175,230,188,141,132,170,216,174,64,141,136,238,216,14,202,187,70,46,161,223,35,76,108,184,138,67,175,9,143,136,101,212,119,57,175,170,27,181,223,22,105,52,193,145,57,133,232,73,193,132,52,132,249,169,203,181,114,156,15,51,190,178,110,196,15,42,169,150,110,36,207,217,132,240,244,5,23,178,190,176,36,247,0,243,160,13,170,50,162,7,233,6,204,199,171,251,159,139,52,0,158,132,36,216,3,223,100,53,99,143,164,47,113,123,82,211,54,171,115,124,112,35,186,88,194,170,205,208,157,217,155,83,222,28,119,147,146,30,50,111,210,98,0,244,83,29,133,155,39,93,143,98,152,211,23,152,165,106,47,72,51,61,58,48,121,158,73,196,162,99,216,174,117,132,47,173,179,127,234,31,25,116,13,179,198,36,67,81,175,242,115,203,149,70,138,222,143,145,80,203,181,198,29,114,127,49,18,26,188,214,184,35,203,109,140,28,157,239,197,146,45,190,31,16,127,99,201,242,123,60,109,22,216,218,238,76,150,247,30,60,41,111,21,4,63,38,58,8,75,126,131,239,13,202,225,19,60,35,152,242,72,69,184,58,21,102,177,123,243,106,229,22,39,171,6,183,79,72,118,195,163,33,67,146,140,132,218,155,117,54,171,111,122,175,138,85,167,190,133,66,220,247,13,104,131,138,36,119,122,75,247,42,111,247,48,163,227,190,24,20,72,11,89,237,83,223,43,153,15,208,57,15,6,150,3,0,29,51,237,10,86,75,163,238,84,140,60,13,27,39,157,182,71,215,170,87,53,103,213,103,236,60,226,54,102,155,158,213,135,17,107,157,180,184,148,28,170,254,79,230,31,246,103,51,92,23,49,166,190,46,63,39,212,230,8,168,98,179,239,87,85,115,141,139,85,185,1,155,123,104,220,8,170,214,103,230,184,40,163,218,118,159,172,112,154,214,231,228,61,206,30,156,138,113,154,86,228,164,171,193,185,167,111,121,229,30,234,45,48,44,246,55,187,159,186,223,91,108,214,100,189,113,31,152,69,217,147,113,151,40,83,169,36,232,175,62,8,174,124,232,47,185,191,244,192,129,23,176,247,84,169,19,97,255,183,227,248,59,28,201,102,205,241,246,194,230,10,33,116,237,247,138,193,38,94,29,56,200,193,240,254,194,184,187,115,127,201,43,25,46,25,214,194,62,242,230,208,139,103,191,253,196,131,59,21,217,165,236,250,8,215,37,46,52,132,12,119,60,29,25,33,223,176,220,21,241,38,238,115,34,16,201,222,223,194,216,243,139,71,238,26,5,143,255,174,133,10,38,90,99,181,96,108,64,208,198,107,23,151,73,143,93,153,157,224,235,46,30,159,215,217,30,182,185,52,183,206,219,110,129,202,222,23,207,102,118,75,93,255,30,246,187,150,219,132,48,91,97,157,163,91,129,113,14,230,26,167,24,184,5,247,169,9,240,108,210,224,223,196,117,242,209,27,24,159,153,116,185,219,212,132,111,113,53,60,204,171,40,163,6,142,249,78,195,207,22,252,167,55,95,212,135,122,19,222,221,143,110,184,144,81,106,186,60,139,42,236,112,112,96,58,182,130,84,29,156,112,128,175,27,88,3,81,157,137,194,200,38,106,105,113,148,37,130,213,141,236,16,162,166,120,99,189,19,189,122,109,19,234,20,86,121,83,162,237,127,231,82,12,29,238,73,239,81,214,80,226,244,142,237,98,231,193,130,116,88,90,154,88,11,171,235,135,64,207,8,73,212,196,241,31,27,199,219,155,188,118,113,235,230,17,210,226,248,10,129,17,118,191,34,13,68,167,216,90,127,75,209,57,70,70,201,9,35,131,215,101,108,182,211,223,38,152,224,68,62,69,227,61,5,152,150,148,55,95,140,161,48,182,147,158,55,98,189,18,11,37,102,186,133,139,30,172,6,128,35,54,87,6,55,212,127,159,60,113,31,194,214,86,104,128,232,236,5,0,245,76,111,65,240,249,173,75,119,142,40,131,240,21,130,228,232,0,206,217,27,54,225,133,254,53,86,130,165,115,130,143,14,204,173,196,84,38,205,72,120,57,253,156,100,53,205,114,123,233,237,218,243,96,191,40,152,124,236,213,86,11,196,212,212,87,13,85,10,213,5,78,56,194,119,70,91,43,181,2,2,59,19,144,8,108,97,7,240,22,123,252,251,17,101,148,191,91,36,11,170,61,21,83,11,209,251,166,170,46,178,252,83,12,21,216,86,88,168,236,109,133,20,149,106,97,143,178,227,145,127,223,65,154,205,221,220,151,193,185,252,173,113,75,236,242,221,113,138,192,104,85,19,205,210,206,135,245,60,161,240,128,161,58,245,249,65,185,103,133,106,18,117,144,178,188,47,170,251,37,183,52,189,57,0,62,189,186,210,9,169,143,16,240,48,197,241,104,73,41,190,90,34,207,40,120,215,74,186,128,48,162,195,185,233,7,209,79,40,112,100,230,211,7,112,109,98,33,251,116,92,60,82,125,87,104,111,140,254,97,52,50,252,142,67,40,22,139,41,57,207,59,239,77,140,21,117,20,12,119,235,250,9,219,107,241,176,117,52,226,180,238,65,71,181,58,88,95,47,232,80,136,251,211,217,219,237,169,174,24,127,87,181,133,131,243,173,171,45,17,104,87,83,219,181,213,45,178,197,173,29,26,174,172,85,48,89,111,237,183,83,143,124,157,232,212,43,190,11,241,124,49,233,84,176,29,175,7,208,41,22,160,215,37,109,159,91,116,237,249,1,167,74,111,90,126,144,232,100,55,250,40,214,202,109,160,233,65,157,102,250,184,237,56,142,222,80,39,174,197,252,115,87,114,32,92,4,39,203,32,214,84,166,93,67,91,110,195,17,226,231,195,59,233,62,117,31,240,155,75,198,9,143,23,142,132,219,61,99,207,111,102,184,115,94,254,48,62,183,167,16,111,103,4,20,98,81,113,100,242,56,86,224,51,138,34,239,186,200,172,21,25,134,83,217,79,173,147,255,110,32,229,6,52,12,63,119,55,16,234,238,9,91,14,242,75,83,46,101,70,13,120,235,78,99,152,210,16,44,129,253,147,229,109,171,75,39,74,138,89,211,142,153,59,212,194,158,61,208,167,254,153,132,6,88,179,5,40,124,96,143,254,216,204,74,171,92,80,200,108,28,57,170,110,91,31,27,44,109,250,142,59,64,254,94,135,110,242,27,133,133,134,172,205,196,60,124,210,158,14,18,238,96,134,59,59,106,166,253,186,72,66,117,57,161,47,69,176,77,66,10,158,254,164,199,190,37,5,38,7,55,251,52,95,162,161,29,128,102,90,148,81,233,40,156,204,77,228,136,27,167,108,54,18,62,56,234,165,82,249,218,6,175,237,50,238,204,108,86,83,202,245,164,172,48,74,10,150,210,48,168,196,110,87,145,141,97,44,60,23,253,19,118,205,77,195,12,68,164,28,22,134,248,66,201,102,12,182,84,71,7,176,122,141,216,1,10,242,59,215,217,143,59,35,141,197,86,44,229,91,237,91,102,190,129,216,120,54,154,211,179,43,123,254,65,81,210,89,149,221,252,42,145,251,224,194,199,126,100,57,184,236,118,217,209,35,111,227,76,112,90,238,76,164,244,205,54,161,166,51,124,13,228,39,117,43,112,27,229,181,81,90,177,228,6,56,125,223,111,99,214,145,223,6,120,181,253,124,212,178,190,141,247,72,185,71,183,66,103,35,69,81,85,115,19,53,107,47,74,14,95,172,233,46,149,10,48,22,47,48,65,226,66,231,85,80,139,171,91,211,10,9,47,231,152,147,100,59,248,96,178,56,194,245,141,109,176,27,119,205,89,85,227,244,67,136,215,59,250,239,176,86,183,140,203,155,140,123,163,65,87,84,70,70,176,42,92,154,220,167,82,249,69,20,95,88,59,35,148,116,160,215,10,186,99,228,8,72,187,70,128,108,141,152,71,49,225,186,31,128,147,130,232,209,17,245,158,86,252,131,134,65,152,217,249,157,68,9,122,69,154,249,108,198,126,59,212,21,109,26,127,119,11,170,238,94,94,36,222,170,41,216,86,160,28,35,115,224,184,208,119,195,131,132,97,75,103,127,4,233,149,217,162,203,118,98,182,188,225,185,98,132,109,230,65,16,229,193,190,179,153,148,99,236,240,163,15,28,220,67,180,117,36,62,250,101,68,108,226,67,19,225,237,174,249,21,235,214,251,104,98,55,118,37,40,59,112,59,229,206,148,57,255,196,204,79,22,186,67,243,81,102,35,10,233,22,240,82,196,114,127,78,98,231,195,145,151,198,122,141,50,254,118,160,229,143,156,108,200,78,205,86,56,198,219,172,222,31,45,244,227,37,166,207,80,175,225,30,0,111,87,231,149,124,155,156,127,75,214,127,136,198,160,51,75,157,225,178,182,168,80,158,189,205,81,143,86,153,240,80,191,113,107,122,202,135,230,116,52,78,206,112,199,169,19,37,203,5,61,70,203,4,45,130,66,244,228,137,218,130,31,37,61,34,77,95,101,244,69,149,93,37,171,55,27,176,88,29,253,165,90,181,182,67,177,232,254,178,40,222,10,193,230,128,120,235,244,130,105,111,157,98,187,253,194,10,234,173,99,63,255,156,67,238,108,233,11,81,156,74,226,109,222,67,247,187,215,67,19,236,13,3,69,214,152,211,211,230,136,71,1,229,197,156,31,246,190,97,3,193,105,188,224,39,41,130,135,115,70,244,191,154,249,171,108,193,114,73,141,52,112,35,177,246,239,165,6,197,102,201,241,10,30,212,118,158,48,205,178,5,30,69,188,105,151,245,247,158,254,52,179,146,127,234,27,58,211,85,165,146,52,83,212,212,88,126,219,89,21,183,229,201,118,219,160,172,110,224,187,25,25,185,194,173,251,124,229,47,22,91,223,141,134,138,186,112,239,206,55,139,249,183,22,136,38,67,206,79,39,205,188,42,208,197,146,111,17,195,32,248,110,164,122,71,90,97,151,152,88,6,154,79,60,222,175,203,170,98,184,81,206,5,83,8,81,244,207,3,50,88,137,15,126,163,192,148,105,98,38,223,127,90,135,33,152,104,9,67,124,154,94,134,218,102,233,123,226,76,39,156,32,54,246,153,113,107,255,86,130,214,251,188,47,17,9,167,232,87,46,193,71,7,111,4,237,147,171,249,148,177,119,58,175,170,183,68,188,130,148,132,186,34,173,209,159,169,7,69,176,76,18,133,162,222,29,234,204,203,195,76,123,190,14,96,189,62,10,179,115,18,227,113,176,44,140,241,57,150,56,195,90,180,93,87,15,145,38,241,217,71,122,209,172,194,130,21,41,73,117,130,168,95,150,248,191,132,142,73,50,18,172,55,64,134,238,72,195,58,243,130,67,133,201,157,150,20,167,113,65,55,33,184,135,236,155,249,182,204,115,41,220,165,41,103,70,212,81,9,120,64,193,213,38,95,97,239,245,2,114,250,172,46,58,156,2,125,152,110,238,62,189,79,183,223,137,186,151,16,79,68,253,157,34,130,65,97,171,150,247,241,117,184,235,221,116,255,202,133,152,244,199,224,239,91,176,228,139,237,222,252,111,121,68,255,6,133,122,15,211,183,175,47,136,209,244,140,39,231,207,208,109,63,252,97,6,239,227,45,25,18,49,204,213,70,28,65,169,178,99,96,159,188,34,2,18,171,178,182,148,196,82,159,20,157,4,67,145,205,47,135,118,65,59,149,94,183,236,219,49,130,103,182,38,202,238,131,178,18,190,62,48,93,169,236,2,18,61,149,208,22,182,4,68,53,110,121,96,145,69,89,227,47,163,88,197,74,101,89,78,217,246,233,79,224,185,173,138,171,188,181,178,62,216,130,223,76,33,22,171,40,177,83,104,223,72,111,53,223,155,26,119,175,65,115,109,88,135,56,254,31,251,229,191,11,103,118,101,89,105,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNonSecurityExeptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNonSecurityExeptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("11f05f99-5a96-44d1-a2bc-de756371aa82"),
				Name = "NonSecurityExeption",
				CreatedInPackageId = new Guid("4a3f1389-e76d-4538-a217-e8c066942d4e"),
				CreatedInSchemaUId = new Guid("cf88b463-ba93-4b8a-bda8-612ad1556887"),
				ModifiedInSchemaUId = new Guid("cf88b463-ba93-4b8a-bda8-612ad1556887")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf88b463-ba93-4b8a-bda8-612ad1556887"));
		}

		#endregion

	}

	#endregion

}

