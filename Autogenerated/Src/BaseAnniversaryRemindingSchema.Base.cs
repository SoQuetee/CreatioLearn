﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAnniversaryRemindingSchema

	/// <exclude/>
	public class BaseAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAnniversaryRemindingSchema(BaseAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("627718f7-94a8-40e7-9791-08a084a92574");
			Name = "BaseAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e07b3414-0244-4600-8fa5-7c3b4f179d09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,28,107,111,220,184,241,243,30,112,255,129,183,5,174,218,98,79,185,203,245,1,196,246,6,126,230,246,154,196,185,216,185,160,40,138,64,94,209,182,26,173,180,17,37,59,139,32,255,189,51,124,83,34,37,109,30,104,129,230,131,35,81,156,225,112,94,156,25,146,91,36,107,202,54,201,138,146,75,90,85,9,43,175,235,248,184,44,174,179,155,166,74,234,172,44,190,253,230,195,183,223,76,26,150,21,55,228,98,203,106,186,222,107,189,67,255,60,167,43,236,204,226,39,180,160,85,182,234,244,57,73,234,164,211,248,52,43,222,153,198,227,178,162,241,89,178,170,203,42,163,204,180,219,132,85,52,212,30,159,28,249,63,173,215,101,17,4,58,45,234,172,22,163,65,151,63,84,244,6,102,65,78,139,102,253,136,156,36,91,198,155,55,205,85,158,173,8,133,86,217,56,65,158,76,46,154,130,28,144,159,230,248,252,172,196,231,135,252,249,178,161,240,252,51,127,126,77,83,120,254,179,104,191,109,224,249,47,252,249,172,202,224,249,175,252,249,34,169,225,249,111,240,248,81,144,65,139,84,80,226,80,117,156,39,140,61,34,71,9,163,135,69,145,221,209,138,37,213,246,37,93,103,69,10,83,227,125,31,60,120,64,246,89,179,94,195,151,133,124,71,0,178,66,96,114,93,86,228,6,37,148,212,148,36,6,9,169,20,22,22,43,44,15,44,52,146,3,201,21,171,43,16,144,196,22,166,4,249,131,51,211,164,131,106,212,73,81,11,126,78,54,85,118,135,20,172,176,153,100,69,77,78,232,117,210,228,181,70,241,52,187,166,47,64,145,74,228,222,207,63,238,245,66,61,47,235,236,122,139,146,209,32,15,247,36,1,46,43,53,65,103,25,205,83,96,230,11,129,83,124,108,51,143,55,252,214,80,224,207,166,42,55,180,66,77,129,225,149,182,199,26,200,230,149,166,243,105,198,234,253,191,211,237,239,73,222,208,23,73,86,237,3,247,96,110,115,34,254,95,44,200,155,119,136,253,133,70,62,154,234,178,6,18,104,218,67,247,113,83,85,20,120,196,86,183,116,157,144,2,236,60,72,175,196,38,233,34,23,28,228,57,64,236,141,24,160,162,171,178,74,201,50,29,68,255,164,201,82,242,146,119,95,162,144,240,61,62,93,111,234,109,223,56,23,101,83,129,123,26,139,95,116,95,166,125,40,47,111,41,225,156,39,229,134,187,45,146,102,92,162,208,105,112,148,19,221,85,203,179,95,200,92,131,206,197,64,6,120,64,212,220,98,170,6,157,225,72,121,27,0,51,133,77,82,37,107,46,251,131,105,195,104,5,157,10,161,187,211,197,43,231,29,236,9,45,116,69,227,253,7,28,106,49,196,135,144,245,71,45,196,238,184,51,194,93,231,228,141,219,12,218,224,54,236,137,94,69,215,180,127,248,137,252,73,172,21,206,58,21,195,154,114,65,235,154,251,176,39,180,230,2,105,209,194,189,237,100,66,60,255,166,224,68,232,125,89,213,183,219,211,59,80,107,238,83,178,21,71,45,134,158,206,67,254,102,198,137,253,216,47,80,99,228,45,175,179,131,187,248,205,245,22,146,149,55,180,150,79,147,138,214,77,85,116,220,10,121,252,152,68,157,198,3,82,208,251,17,195,70,51,49,65,156,33,252,101,102,56,15,202,59,68,99,117,223,137,43,195,90,30,82,218,126,79,92,209,36,45,139,124,219,6,127,227,209,57,163,224,173,206,173,215,32,239,125,122,108,179,194,59,175,179,60,185,33,229,181,127,77,86,75,54,62,194,200,210,225,178,228,46,56,111,177,92,95,149,101,78,150,236,137,132,46,139,243,226,2,128,200,7,64,88,239,17,134,127,118,145,15,199,218,51,137,231,205,250,138,86,56,141,26,28,108,10,246,65,174,40,132,28,161,80,131,100,76,71,35,3,18,196,213,190,227,12,246,172,185,98,135,78,28,208,145,81,118,13,118,208,245,41,7,228,71,229,151,122,124,78,192,250,133,132,165,113,104,45,240,210,42,59,89,11,174,101,75,158,97,3,198,20,92,211,10,45,0,206,124,96,111,82,132,121,95,252,177,38,41,205,233,56,230,87,221,208,172,205,127,95,244,230,23,129,7,89,91,10,222,46,61,113,162,95,12,33,170,123,37,225,31,122,23,97,60,241,197,216,50,214,232,183,217,37,230,30,0,123,149,83,233,136,23,68,198,14,134,151,194,118,71,184,215,103,180,190,45,59,113,174,146,235,93,9,241,210,233,123,186,106,106,138,75,11,88,121,164,36,128,102,155,172,110,73,212,183,52,16,219,255,111,65,7,218,43,148,150,231,5,197,152,25,200,230,255,65,232,71,107,140,31,68,115,228,160,137,97,68,185,224,76,116,255,19,244,121,64,179,4,16,237,115,119,124,5,132,26,214,193,24,159,190,107,146,156,69,211,195,213,170,108,138,122,58,51,186,166,71,57,76,83,249,217,10,108,206,178,188,134,39,57,230,204,213,51,28,203,93,24,48,246,88,178,51,154,128,2,210,211,2,5,153,70,83,59,156,248,253,161,61,184,82,21,173,210,204,63,59,155,45,31,9,205,33,167,83,40,128,236,231,244,190,131,192,37,213,214,89,71,1,58,208,142,172,20,161,119,73,133,171,45,80,34,63,31,8,228,24,66,44,173,246,22,55,102,146,196,120,89,212,101,52,213,163,76,245,7,136,217,162,41,0,212,144,87,46,49,200,154,94,52,87,255,166,250,101,203,120,142,190,21,73,137,211,227,56,225,134,129,45,2,241,101,182,166,83,25,228,77,38,14,211,47,183,27,42,128,129,161,43,202,24,198,61,200,122,198,17,130,253,208,74,34,151,9,132,33,241,172,42,215,142,226,73,206,74,211,57,185,226,90,31,217,236,113,66,66,197,110,190,30,31,39,5,164,64,20,181,235,37,132,37,146,85,52,21,179,140,52,135,140,175,86,230,38,83,57,204,203,148,84,60,185,72,201,89,179,192,44,57,205,132,223,16,129,94,79,95,169,72,31,136,18,4,240,65,15,31,107,225,144,143,115,221,241,16,144,221,1,179,9,228,28,148,72,21,219,211,170,194,182,236,48,5,4,175,138,172,150,227,95,88,77,109,45,17,128,104,76,223,217,144,241,25,173,87,183,200,254,147,163,200,76,104,78,174,193,148,169,49,34,233,237,121,171,237,222,145,146,42,187,185,173,217,83,122,71,115,32,164,101,171,39,71,23,32,194,10,24,127,90,220,100,5,69,227,181,213,77,36,171,47,17,5,199,16,57,212,45,83,201,15,35,24,155,111,90,143,229,244,36,149,22,65,241,47,9,195,200,47,242,143,198,98,174,44,73,234,213,38,110,188,30,239,225,152,175,214,29,107,33,186,232,168,17,151,88,115,165,44,91,136,171,199,156,177,226,215,172,139,104,106,172,132,27,137,199,192,227,215,183,180,162,246,135,57,241,25,230,44,94,50,238,162,163,41,227,6,24,234,39,209,30,22,105,11,169,241,33,94,92,202,232,122,113,24,215,227,197,209,11,139,4,42,143,228,133,110,121,173,153,177,150,117,146,21,154,249,82,128,179,177,66,16,255,197,135,224,206,170,140,189,133,108,205,150,136,116,88,240,89,147,226,74,102,22,3,151,225,239,233,123,112,136,176,116,40,53,176,200,179,162,70,43,103,212,147,135,4,81,244,53,211,136,165,107,68,229,165,85,84,241,255,200,129,246,52,14,86,17,14,152,250,129,232,173,86,47,171,50,9,43,85,164,95,85,78,42,255,215,241,138,139,58,43,44,234,103,118,12,234,201,139,190,255,158,124,55,224,158,45,167,236,183,40,179,176,131,191,130,140,77,133,140,38,48,213,238,1,134,140,156,204,26,201,178,166,123,140,129,8,89,88,81,241,9,143,214,65,94,224,125,65,185,124,213,23,22,249,233,234,6,174,202,143,152,21,199,145,194,18,43,246,66,126,68,74,196,242,22,43,189,38,28,200,175,232,58,133,42,242,112,113,31,139,113,139,200,49,59,163,81,148,115,115,24,218,7,133,211,9,194,201,192,20,2,46,232,101,195,178,118,28,49,52,180,229,10,44,44,162,152,218,89,71,108,212,207,146,34,185,17,104,151,53,93,31,109,95,45,211,168,51,188,133,52,197,184,86,120,233,193,105,133,125,136,37,118,140,172,79,80,180,33,116,248,17,99,37,64,120,216,5,83,88,151,90,25,46,233,251,250,172,172,32,47,33,181,121,60,16,59,18,98,199,102,139,99,236,251,52,210,0,47,34,19,51,90,229,202,195,234,6,82,158,2,194,192,86,137,114,222,98,243,204,154,46,240,50,199,9,26,122,144,128,75,108,141,70,70,59,83,99,30,48,148,16,109,140,111,31,29,207,130,163,93,149,233,182,51,216,17,52,126,254,88,42,164,154,158,74,155,128,239,202,60,218,31,37,184,177,3,211,129,11,110,110,233,82,119,18,182,195,69,178,141,173,183,106,86,58,94,209,174,138,214,144,120,91,26,196,162,78,31,19,129,143,81,59,43,94,239,96,58,161,108,85,101,27,89,22,230,130,110,119,121,81,110,154,205,165,82,1,95,143,99,203,65,105,103,213,153,151,99,77,208,19,229,28,232,196,49,41,193,116,250,200,156,1,186,88,251,15,45,30,138,20,3,186,116,156,65,167,175,199,89,13,2,117,131,37,128,210,50,230,246,198,58,157,44,131,237,98,180,34,26,64,101,84,171,221,207,66,34,221,14,8,190,213,24,121,252,83,43,46,86,248,124,193,174,82,29,31,102,253,205,55,132,181,102,165,201,118,89,60,3,93,184,197,130,130,4,138,177,224,38,155,53,166,248,178,132,206,241,63,104,82,205,125,88,99,222,221,113,225,232,30,124,61,1,61,44,225,214,208,143,237,151,71,33,24,135,51,220,199,72,210,118,164,17,61,194,54,156,62,140,10,40,198,102,16,133,66,99,96,49,80,180,99,70,177,182,90,140,243,192,136,13,87,174,67,189,132,137,164,187,47,218,9,33,111,71,167,24,152,6,136,23,49,103,79,116,50,235,141,63,193,6,33,2,13,224,158,133,162,225,49,206,217,13,22,157,68,217,26,221,10,71,109,255,138,66,87,82,104,149,135,38,19,91,73,100,82,50,78,20,99,245,164,78,170,27,55,205,22,210,190,236,180,247,74,183,157,180,122,242,166,54,235,220,196,233,172,41,86,241,179,228,189,157,163,29,131,20,33,218,63,135,208,42,152,216,134,115,169,129,212,85,39,133,50,101,19,75,133,202,165,5,91,66,176,78,222,105,209,235,73,122,7,176,91,32,1,164,221,154,219,104,228,30,208,208,32,158,84,123,8,185,1,177,117,224,147,21,192,66,221,87,200,224,242,150,93,91,242,182,184,106,20,7,166,3,18,20,51,50,233,180,205,133,126,81,183,217,241,2,183,227,193,98,171,104,167,213,124,22,24,82,215,58,123,6,234,154,104,252,10,49,154,58,157,58,198,33,39,139,135,56,34,227,109,132,76,58,35,135,69,110,207,81,32,118,55,157,229,74,40,240,238,121,125,149,111,65,19,51,176,214,50,39,30,224,125,237,66,182,244,140,129,18,118,87,49,94,103,245,237,47,89,81,51,158,6,188,44,239,159,150,171,183,216,160,139,48,254,250,151,41,49,135,249,160,250,24,76,158,114,213,8,81,26,126,146,132,201,25,122,203,215,130,29,222,88,193,44,3,214,166,205,88,119,159,177,238,158,10,88,235,210,211,220,235,239,229,120,252,24,159,249,8,152,188,3,60,38,211,110,235,20,2,46,93,226,118,176,174,56,219,122,144,241,252,10,193,143,178,170,190,229,111,123,95,122,69,107,109,146,25,189,236,223,90,145,222,236,194,42,66,79,207,239,11,169,24,232,188,186,181,79,13,229,165,199,113,136,237,66,227,176,151,224,99,90,198,222,194,195,215,221,227,134,213,229,26,31,113,46,209,244,186,120,115,156,176,154,71,183,165,72,51,64,195,125,11,66,75,1,230,82,118,51,109,40,19,123,124,93,41,25,154,140,142,171,95,213,171,231,229,253,76,113,206,228,169,67,24,118,244,206,28,127,184,194,29,30,231,71,9,219,217,200,234,213,8,173,12,198,105,12,13,100,92,144,0,244,110,140,69,29,53,254,236,61,81,189,162,203,101,100,64,85,69,169,175,53,153,144,150,240,153,244,20,189,62,78,196,170,226,108,10,203,83,7,193,77,225,80,49,248,19,150,203,174,204,190,196,74,105,59,115,199,77,249,157,212,103,69,242,59,56,118,49,251,199,99,171,169,242,176,215,17,47,125,89,59,249,2,205,163,79,68,163,214,3,183,26,209,157,90,112,71,215,59,225,49,44,228,208,129,229,209,11,216,61,196,224,208,236,67,213,179,156,247,158,118,240,30,2,144,122,250,107,153,21,17,254,65,143,21,47,129,225,213,220,187,220,170,8,244,188,48,36,183,213,218,7,103,176,153,242,187,29,82,6,64,204,107,32,148,150,228,24,19,106,129,72,199,125,6,200,83,238,150,78,146,173,177,175,65,203,50,124,13,59,140,79,216,157,253,98,106,242,63,28,65,97,113,241,36,187,190,22,108,18,127,69,12,117,226,124,57,125,191,169,96,205,195,144,33,228,225,157,170,220,249,245,107,74,223,186,248,156,198,209,8,133,196,156,244,47,16,113,137,253,84,112,244,77,158,71,118,18,166,205,97,67,139,163,28,82,5,79,139,143,17,136,236,136,214,247,148,122,22,233,206,97,228,25,31,203,23,53,88,164,180,88,3,35,116,81,179,40,130,84,102,134,168,227,139,70,29,158,158,152,198,103,101,49,39,230,245,178,161,246,235,107,154,58,95,111,27,251,245,172,202,236,215,139,164,214,244,29,231,37,163,45,254,84,59,176,42,176,92,118,78,135,254,64,126,26,224,73,8,149,195,130,255,2,221,15,63,155,110,144,85,31,221,118,211,72,231,167,236,148,39,147,42,174,239,53,224,206,169,38,237,14,165,225,169,67,78,94,204,215,202,166,121,58,161,250,200,29,70,47,200,178,0,128,187,36,199,250,186,84,102,13,11,62,27,43,233,18,124,226,195,57,132,149,87,226,85,87,95,226,194,186,174,69,247,151,57,17,191,81,163,75,253,42,166,213,221,70,98,21,189,103,246,28,253,168,93,217,10,142,134,100,11,90,84,123,100,27,114,166,187,8,183,139,186,43,92,236,99,9,183,3,162,197,128,212,164,255,31,2,222,73,134,188,60,182,196,179,119,138,245,237,219,36,227,239,131,152,188,70,30,77,150,171,221,121,213,206,108,112,192,214,56,238,153,23,221,65,98,138,134,54,171,58,37,61,126,235,75,48,9,171,15,86,122,66,217,59,57,41,59,142,23,213,174,225,92,65,159,42,229,181,62,53,33,128,227,7,0,249,41,61,228,25,63,116,40,229,183,188,41,202,10,52,136,109,242,68,48,16,123,224,9,73,49,99,49,113,32,11,183,149,14,243,92,140,39,228,172,249,130,159,101,180,200,119,159,240,93,84,151,69,43,22,29,173,53,90,52,30,151,235,77,82,101,76,84,17,68,0,232,41,47,171,195,177,59,150,42,190,60,97,173,125,2,125,38,226,213,87,26,206,58,82,220,78,155,59,39,220,112,32,125,14,212,220,109,110,151,223,226,203,242,176,170,146,109,212,187,3,24,56,129,22,218,141,27,115,103,202,58,212,63,124,97,74,22,121,153,188,239,8,212,64,248,145,92,37,44,116,233,163,115,111,144,3,78,23,98,91,182,46,9,21,24,157,123,130,230,30,197,29,4,247,192,115,231,110,129,170,48,47,79,142,240,58,118,82,164,130,26,197,141,119,246,166,108,219,1,120,17,123,221,10,249,64,70,66,105,95,99,123,194,206,13,77,145,47,248,191,121,124,32,94,96,41,192,9,182,78,37,219,206,78,171,136,92,10,197,141,16,158,132,129,96,36,30,13,223,123,243,98,3,141,214,78,176,159,202,248,178,218,234,171,144,102,176,57,41,155,154,99,176,246,135,193,196,108,142,110,35,252,142,151,14,230,188,103,204,145,244,93,41,104,179,124,231,123,178,61,204,150,84,218,231,33,118,196,238,170,149,215,84,94,114,236,76,213,223,239,193,191,144,36,207,229,154,42,46,207,175,228,165,103,113,16,200,127,209,86,192,79,23,50,213,23,119,238,249,197,84,255,93,172,238,141,219,142,249,41,161,40,51,220,168,43,55,54,77,178,66,50,30,27,74,119,186,176,211,116,49,45,251,206,248,14,216,56,243,167,11,188,136,166,233,75,209,57,195,60,193,1,213,224,144,245,221,64,113,157,7,87,222,206,0,66,200,108,241,172,76,97,77,226,87,179,70,203,99,255,129,130,246,59,55,163,165,250,167,12,164,148,90,23,140,90,101,154,241,151,160,80,205,130,26,6,54,198,149,247,157,43,68,112,170,78,11,6,99,57,30,62,241,50,253,237,176,208,250,117,224,238,203,200,137,190,79,214,155,156,46,58,142,195,186,68,50,197,56,61,91,101,155,4,171,80,251,15,20,204,144,116,212,197,36,23,177,244,154,111,209,39,201,103,62,23,229,30,180,35,52,171,2,36,200,194,147,225,25,31,229,209,208,83,3,18,60,239,109,92,27,54,10,108,61,14,188,131,29,226,18,20,104,159,126,68,156,94,137,218,118,66,195,235,251,208,133,91,17,59,112,163,40,243,180,245,35,30,30,6,255,243,252,138,149,60,220,152,138,65,240,138,104,74,33,105,91,225,225,133,121,232,55,96,156,248,240,56,167,73,65,171,95,203,43,178,110,88,77,174,40,87,189,180,201,105,26,79,103,255,226,146,20,151,25,173,176,253,60,79,61,219,240,129,171,150,35,111,247,239,103,69,189,240,95,241,119,34,95,6,121,105,38,240,192,4,215,230,34,191,231,26,169,93,62,180,207,7,68,98,26,179,240,49,129,192,13,24,89,43,116,19,206,177,245,9,239,129,24,231,8,128,189,65,57,39,254,44,115,134,37,161,39,60,116,174,66,149,112,31,43,194,119,93,252,199,86,124,37,68,25,93,12,37,28,246,251,50,157,239,118,110,181,135,208,37,195,67,126,189,71,93,42,109,151,150,212,79,89,33,5,79,70,75,254,244,226,185,77,230,87,147,127,123,28,247,244,209,87,85,2,207,208,187,113,184,231,204,137,255,27,8,98,56,114,179,252,160,149,201,217,241,129,248,205,132,64,188,166,50,207,233,162,245,163,57,208,54,244,115,40,29,71,39,47,241,13,213,39,62,123,147,60,80,13,49,3,201,117,203,185,42,108,187,53,242,149,79,60,141,56,69,104,116,196,202,254,21,26,174,112,59,30,25,107,31,113,234,213,183,29,110,241,131,98,225,124,219,202,37,226,28,252,149,5,8,40,197,166,23,243,235,88,201,111,152,105,78,154,171,103,211,5,255,233,15,235,135,185,50,251,238,47,35,247,183,180,80,33,222,61,76,15,127,246,99,23,173,84,147,104,159,64,142,248,182,98,144,46,91,79,131,157,248,141,185,49,90,172,137,40,138,173,116,219,226,206,221,180,47,218,242,92,209,59,8,83,188,167,235,137,118,114,62,138,188,1,35,235,57,78,104,147,219,254,37,133,65,183,245,153,250,181,187,200,213,188,130,29,184,171,238,137,81,187,191,79,7,45,255,1,216,217,234,234,67,80,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("627718f7-94a8-40e7-9791-08a084a92574"));
		}

		#endregion

	}

	#endregion

}

