﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailTemplateServiceSchema

	/// <exclude/>
	public class BulkEmailTemplateServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailTemplateServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailTemplateServiceSchema(BulkEmailTemplateServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751");
			Name = "BulkEmailTemplateService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,93,111,219,56,242,57,11,244,63,176,238,1,167,0,94,165,87,236,1,139,38,241,33,77,218,61,223,37,109,55,78,175,15,65,112,167,72,76,172,141,108,185,164,156,214,45,242,223,111,248,41,146,162,100,89,177,211,6,216,125,216,90,212,112,56,156,239,25,82,153,70,19,76,103,81,140,209,25,38,36,162,249,85,17,30,230,211,171,244,122,78,162,34,205,167,79,126,250,246,228,167,173,57,77,167,215,104,180,160,5,158,236,58,207,0,159,101,56,102,192,52,252,13,79,49,73,227,10,204,113,58,253,84,25,60,157,79,139,116,130,195,17,76,137,178,244,43,95,176,2,5,111,111,211,24,159,228,9,206,26,95,134,31,241,101,51,192,1,80,121,235,95,229,12,127,41,202,65,147,25,4,135,111,162,184,200,73,138,169,31,98,50,49,17,218,115,107,113,190,134,189,23,141,40,195,127,81,63,94,216,103,185,42,188,127,70,240,53,236,9,29,102,17,165,47,209,171,121,118,243,122,18,165,217,25,158,204,178,168,192,146,7,28,118,103,103,7,237,209,249,100,18,145,197,64,60,63,51,254,67,250,255,200,29,212,255,134,98,218,222,142,129,230,92,174,1,186,83,16,224,214,5,27,59,160,179,183,184,0,74,103,192,243,203,52,75,139,197,41,254,52,79,9,158,224,105,65,3,243,129,9,8,237,163,37,83,24,84,40,7,146,109,182,200,108,126,153,165,49,138,217,214,107,119,142,128,41,17,45,249,176,245,141,243,162,100,28,168,110,17,1,254,151,232,61,97,26,34,120,181,53,19,15,40,102,239,81,58,45,208,127,11,137,249,213,162,192,244,56,157,164,5,80,253,247,23,191,188,248,245,215,231,187,18,43,158,38,2,177,189,202,9,46,198,121,82,183,198,101,158,103,232,63,96,6,9,60,41,250,95,229,201,226,24,79,175,139,113,64,11,194,180,224,18,70,182,17,179,201,173,173,219,136,240,103,78,203,97,14,214,4,180,188,158,198,121,2,144,225,193,232,112,56,4,131,44,216,107,254,54,224,147,119,249,92,130,139,57,153,162,167,129,131,96,176,239,219,163,152,116,103,83,44,41,130,21,142,227,175,35,254,0,244,207,177,34,53,139,191,190,5,247,98,82,155,229,49,55,244,203,12,139,9,12,0,136,22,51,194,55,57,153,68,69,208,59,118,193,104,248,237,249,93,200,177,247,250,26,241,110,61,94,192,57,197,159,81,5,81,192,167,108,125,160,152,128,208,167,194,109,133,31,115,114,195,189,32,232,22,205,231,36,6,232,156,68,215,184,143,122,90,167,70,51,208,70,169,66,140,8,223,86,12,146,110,25,177,64,70,5,78,108,67,0,166,87,40,144,128,64,240,60,203,20,179,182,234,167,3,191,15,231,25,72,15,11,110,115,151,27,101,14,229,225,17,190,146,96,125,116,21,101,84,209,118,103,138,255,86,147,226,200,150,123,167,5,147,173,101,79,98,56,248,109,158,38,72,105,201,48,49,37,140,45,240,209,239,82,16,98,226,40,30,195,251,223,231,152,44,2,71,4,38,192,73,52,133,29,144,190,224,68,207,162,160,39,183,225,174,19,130,81,49,103,196,145,67,68,154,79,166,225,144,30,100,159,163,5,29,97,22,159,128,146,130,40,198,87,166,31,36,137,152,21,244,70,243,203,63,0,190,118,37,3,84,13,139,144,217,102,6,179,232,158,161,38,22,44,144,88,153,203,68,32,184,110,115,172,111,10,192,178,105,11,133,79,184,199,41,45,246,132,201,13,152,136,63,76,233,252,146,198,36,189,196,39,81,76,114,202,21,139,6,166,92,99,161,75,20,72,44,21,144,126,76,139,241,48,9,140,253,76,56,2,14,199,13,208,88,202,4,195,244,211,125,52,3,217,74,33,168,214,236,167,159,86,212,6,70,209,20,204,87,64,50,41,0,10,67,104,204,180,77,161,205,34,2,209,232,109,195,140,247,28,34,52,39,50,136,55,105,86,96,66,25,100,192,158,15,9,6,242,197,40,227,37,76,131,25,12,36,16,131,60,18,146,20,18,129,179,197,12,146,134,79,243,40,131,221,15,147,158,180,142,147,136,220,224,2,216,203,99,24,13,61,124,49,196,251,129,100,160,45,146,160,43,72,67,162,120,204,60,144,150,239,112,122,149,67,160,211,226,214,254,136,81,59,2,79,47,221,17,147,140,84,2,144,191,49,57,252,55,86,33,70,8,154,75,175,76,17,37,171,180,86,151,111,28,185,87,145,176,169,206,28,96,40,161,197,59,2,206,46,2,26,148,134,113,191,170,38,57,142,117,11,130,57,240,75,137,94,250,67,173,2,122,17,70,34,227,185,20,41,55,9,173,201,165,178,132,134,219,119,116,163,29,42,87,151,44,132,202,154,184,194,252,165,119,254,236,91,9,126,23,126,99,100,220,61,187,232,249,92,187,154,106,58,128,22,153,73,94,0,103,113,34,222,187,201,34,31,56,229,248,255,71,81,196,178,105,72,3,120,2,93,58,136,207,160,199,104,152,208,80,99,216,113,81,236,9,26,233,96,111,71,253,18,254,73,174,142,110,83,82,128,166,163,163,148,139,25,230,238,177,152,211,71,134,215,114,125,144,223,89,241,92,219,170,104,66,200,248,229,92,38,152,242,137,250,53,80,242,83,225,92,141,159,60,59,109,96,38,164,211,63,91,57,118,53,221,54,127,89,137,121,19,131,103,204,145,112,133,222,239,93,170,12,6,188,198,160,186,140,124,226,16,225,222,14,159,233,71,100,5,150,70,100,234,95,62,163,124,215,140,158,200,188,222,176,18,106,174,81,199,39,123,113,131,179,186,156,41,147,184,94,51,9,44,25,150,75,42,164,213,9,74,101,155,104,170,45,69,32,77,155,129,167,198,161,173,250,231,239,102,88,168,167,89,65,109,157,67,169,55,156,222,230,55,56,16,58,5,26,221,123,255,110,116,6,9,232,7,146,26,121,67,111,20,221,226,202,162,0,198,18,142,81,177,200,24,16,96,59,193,148,66,8,213,163,225,71,18,205,192,53,137,112,194,74,43,76,11,145,135,91,19,196,16,47,73,251,72,109,162,25,142,215,103,170,64,91,198,15,228,165,95,100,154,134,2,11,50,249,168,163,141,202,55,32,159,26,233,151,76,192,250,33,230,110,193,116,28,96,223,96,230,50,51,89,74,178,140,40,163,121,28,195,230,97,22,207,179,85,96,22,252,16,249,146,83,32,245,68,245,254,154,144,156,244,182,133,239,46,179,139,152,19,78,207,114,198,18,152,207,120,9,233,60,149,93,18,188,103,120,69,177,147,62,202,121,202,58,24,4,190,221,55,164,155,53,9,190,195,219,237,178,90,177,17,60,173,84,45,68,167,165,76,197,208,190,12,186,178,192,27,210,183,0,254,142,188,158,204,96,21,81,203,254,195,38,170,49,88,202,244,25,234,121,54,119,183,186,168,240,244,101,69,105,47,40,5,46,105,90,105,97,55,211,151,56,94,74,37,50,242,142,167,13,69,188,201,155,237,50,37,17,106,23,58,138,180,107,191,45,21,202,174,150,61,234,117,150,231,199,17,185,198,78,229,36,53,115,107,203,215,197,216,65,127,123,254,226,151,237,114,81,30,245,196,218,213,84,73,155,36,144,179,60,95,103,172,29,242,22,75,12,75,178,228,37,48,92,178,226,165,204,134,189,213,206,182,45,235,108,198,204,81,212,105,110,209,212,44,71,167,184,19,18,211,187,9,223,224,34,30,191,33,249,228,232,85,96,184,29,67,86,37,44,164,195,172,200,54,12,77,231,159,54,148,1,18,240,212,221,244,104,219,54,115,235,39,106,47,36,119,208,119,25,161,48,45,71,33,149,184,239,152,77,123,4,220,12,251,150,169,47,159,204,139,161,190,237,222,206,197,232,197,242,217,35,200,181,48,241,227,48,222,181,198,36,116,175,6,149,120,121,97,42,137,129,15,0,3,209,82,105,48,225,178,186,244,88,176,207,102,149,120,1,123,34,209,188,1,223,165,187,5,26,141,163,8,108,45,91,17,106,224,133,67,182,132,86,3,169,189,168,173,31,203,125,131,85,129,24,239,239,58,166,192,118,78,245,12,57,207,22,220,202,121,241,6,210,89,59,53,92,117,67,107,207,9,221,232,174,237,254,7,73,10,45,226,116,90,229,167,58,240,37,125,181,185,155,23,115,240,112,137,80,157,65,221,35,227,216,245,98,150,70,189,114,10,229,199,182,142,144,218,197,7,128,170,252,60,17,202,92,140,65,121,164,25,160,40,203,224,247,12,116,37,162,40,191,18,84,117,170,123,69,178,146,38,172,35,115,149,66,74,82,107,187,90,15,69,78,205,18,188,34,74,167,172,96,160,48,91,211,179,9,107,61,138,79,37,246,246,70,42,205,115,211,182,90,146,102,26,106,57,90,41,213,172,83,42,183,148,130,89,57,77,139,156,44,234,138,173,18,194,159,10,50,180,137,90,157,31,239,178,168,219,176,80,104,147,91,77,193,132,19,145,202,182,239,34,15,69,223,56,160,4,237,15,56,201,242,181,50,121,117,148,69,194,195,104,198,59,244,170,67,75,111,196,56,251,37,7,135,137,24,26,38,194,102,182,195,179,252,128,144,104,17,216,93,39,182,142,135,243,114,201,211,146,90,69,184,81,76,118,49,184,210,64,184,189,89,10,255,3,24,96,19,121,155,176,71,200,6,75,157,25,38,143,197,42,93,178,31,218,54,87,85,222,37,86,91,217,142,185,19,101,151,176,65,191,93,10,91,75,19,153,167,26,150,214,209,86,98,118,80,78,225,55,134,152,63,185,196,132,169,34,193,113,58,75,217,29,5,116,149,67,122,193,14,86,84,246,172,84,180,173,221,144,82,223,6,156,84,177,0,31,252,171,101,163,237,141,136,119,229,5,185,180,142,94,69,230,70,3,219,169,90,152,223,55,144,199,88,43,26,21,106,103,80,210,246,214,30,234,236,45,112,227,58,191,64,165,212,30,151,117,233,245,245,182,228,92,177,59,99,91,170,79,35,45,238,75,157,193,9,139,251,194,142,2,117,203,201,230,25,127,205,211,72,249,126,13,102,73,161,112,22,86,201,54,44,107,181,49,100,173,36,75,167,55,160,230,36,159,104,147,108,111,138,92,209,122,131,179,49,70,68,169,95,42,123,89,204,144,246,40,198,40,38,248,106,223,110,193,255,83,173,44,117,181,183,51,168,183,214,161,31,161,117,110,229,116,159,123,225,206,96,163,103,8,122,3,44,234,109,214,224,154,246,137,106,136,10,26,185,173,100,229,20,136,2,163,176,187,166,69,85,22,86,128,149,26,173,109,98,218,46,191,109,39,110,6,114,59,218,243,17,163,224,7,242,226,209,150,92,25,138,167,57,155,121,64,174,231,236,102,91,208,155,91,166,206,100,99,219,126,89,177,105,227,173,227,140,220,123,248,170,12,147,125,197,144,176,132,83,245,26,138,163,130,93,3,120,253,37,198,60,113,69,250,206,22,36,175,41,192,94,127,40,216,85,188,20,211,240,56,191,14,249,185,133,236,62,203,109,245,206,235,78,75,234,168,188,120,137,56,30,244,121,156,130,223,7,235,101,9,222,216,84,58,125,12,94,140,73,254,217,95,93,114,113,45,245,21,167,50,189,197,16,1,165,141,48,83,155,151,55,35,228,121,185,190,111,197,65,248,245,168,186,131,236,181,196,197,202,213,155,31,167,57,83,33,205,12,134,149,151,250,252,221,49,25,201,214,253,198,123,70,90,181,117,96,171,95,92,5,153,19,133,88,172,224,132,15,117,158,182,105,229,246,237,202,209,236,107,92,176,251,57,250,66,70,147,98,223,59,222,201,104,141,198,56,74,88,166,247,179,8,123,44,152,245,197,79,14,215,71,84,52,109,250,104,70,176,0,254,51,36,46,15,137,130,171,63,80,60,148,169,151,36,44,240,81,91,19,17,187,133,182,106,10,185,177,200,166,246,212,28,205,4,80,93,74,42,94,243,6,142,118,28,170,171,35,218,50,95,66,227,89,101,171,239,149,77,112,0,253,164,94,151,199,77,252,125,249,104,3,168,243,81,5,193,159,53,136,238,180,194,107,241,91,21,168,223,35,46,219,122,228,143,205,142,111,105,19,160,91,230,89,171,85,223,80,70,84,243,252,213,253,157,130,21,215,166,13,100,27,113,132,135,249,108,81,99,153,143,193,13,250,200,255,190,110,208,162,200,113,131,13,204,126,84,110,176,105,143,202,3,142,184,250,122,157,163,49,104,157,205,252,233,87,26,58,224,202,147,128,189,85,243,170,198,75,173,94,223,96,216,175,97,190,102,219,101,195,206,96,253,190,192,238,25,153,242,221,184,71,240,242,173,172,74,234,108,165,158,221,171,184,131,78,205,58,95,231,161,97,23,70,45,36,239,137,74,0,113,196,99,180,237,26,210,35,111,163,46,176,121,178,253,69,67,57,39,79,226,100,77,92,168,175,91,252,200,122,237,165,193,221,199,145,139,209,94,194,46,1,173,194,254,33,138,184,118,14,139,192,232,138,30,203,127,83,92,140,58,131,206,103,156,13,185,124,221,151,156,44,237,5,214,241,174,254,209,217,59,84,228,188,74,116,233,13,213,108,235,11,206,163,168,136,76,151,96,125,89,217,16,81,159,240,207,41,107,188,44,176,22,92,41,65,20,203,19,147,242,240,130,57,49,102,13,75,19,47,78,217,9,102,71,23,150,47,96,103,90,134,198,161,111,172,212,222,101,75,237,162,38,207,191,132,166,182,249,96,19,89,149,160,236,18,247,248,52,160,145,24,247,131,218,247,36,135,40,195,204,177,197,55,16,21,121,24,113,215,56,47,254,78,202,161,242,129,136,249,200,213,136,176,125,201,249,5,82,206,207,67,76,7,7,81,31,213,86,208,14,32,100,13,202,209,68,202,163,212,141,117,137,67,132,177,135,183,214,70,98,214,43,145,7,50,144,229,196,200,132,194,228,90,123,82,76,78,33,39,87,89,143,126,216,155,237,160,26,107,51,213,58,74,214,171,23,30,82,155,197,17,200,142,90,79,165,85,219,15,232,76,109,244,109,165,2,233,130,82,127,118,139,194,113,80,190,251,31,43,74,203,38,11,189,180,244,116,83,18,155,68,244,102,53,235,97,127,26,195,236,171,118,142,182,138,132,52,233,224,211,245,13,161,22,58,209,225,91,205,247,152,128,144,39,224,233,166,40,157,176,165,82,126,57,237,22,68,193,48,241,110,162,81,150,87,123,208,80,140,51,67,174,131,161,172,248,247,111,187,210,96,144,106,39,208,242,14,164,82,196,9,255,83,55,181,61,4,53,32,154,150,252,202,52,104,49,227,125,185,21,131,8,235,251,92,193,107,90,68,5,147,185,98,65,206,27,10,32,69,167,234,246,244,224,77,170,85,5,103,180,116,28,109,151,21,158,217,141,55,17,84,26,243,86,95,222,130,172,180,232,237,14,189,7,214,108,214,219,39,6,22,112,245,240,160,108,236,219,88,101,255,217,194,200,239,201,248,240,169,107,161,13,31,27,183,113,106,182,179,88,167,75,235,224,202,54,229,185,40,151,23,55,139,213,124,134,252,10,212,208,154,78,110,75,174,223,161,84,180,8,16,186,216,217,113,10,241,200,83,142,110,100,72,197,189,39,9,203,206,147,155,137,40,109,253,135,112,225,134,206,214,56,112,235,64,228,113,187,111,115,43,129,187,243,101,174,219,202,159,127,20,199,221,236,139,215,226,98,151,125,36,94,235,118,171,31,132,249,63,23,147,63,107,190,138,234,224,135,151,83,124,47,223,236,219,195,106,174,128,255,37,52,245,33,101,91,111,100,46,217,201,243,168,143,51,87,90,208,252,120,175,203,162,238,119,87,171,46,190,158,213,229,215,105,223,103,113,254,1,219,122,106,56,239,71,127,109,242,30,167,92,155,105,125,215,7,17,29,211,157,42,49,235,173,216,52,201,177,245,23,110,30,80,25,234,73,98,127,161,97,35,154,177,34,29,247,201,137,90,216,103,7,61,173,189,220,216,70,87,121,168,231,26,198,210,243,4,203,235,171,50,23,96,99,190,59,137,29,226,68,3,149,247,82,98,121,113,83,201,103,197,62,157,16,204,249,133,66,179,214,238,15,127,213,170,33,211,158,7,77,13,11,127,167,162,89,37,235,10,149,134,206,76,93,75,166,177,153,99,125,174,177,30,46,91,223,113,217,74,223,204,116,223,164,14,252,215,13,70,117,155,195,219,97,4,221,210,31,207,172,105,223,77,151,96,219,214,229,204,178,43,151,228,237,91,42,247,62,213,171,144,246,40,207,110,90,30,91,104,38,174,70,129,102,18,123,205,218,208,165,48,186,105,203,221,255,1,211,189,28,230,132,91,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCommonErrorLocalizableString());
			LocalizableStrings.Add(CreateTooLargeEmailTemplateLocalizableString());
			LocalizableStrings.Add(CreateTemplateSavedSuccessFullyLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCommonErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2dfe3dab-c5ec-4a61-a0d0-c5b8b2cfce34"),
				Name = "CommonError",
				CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549"),
				CreatedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"),
				ModifiedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTooLargeEmailTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("36dbe531-89f8-46fb-81f6-dfabaee006f6"),
				Name = "TooLargeEmailTemplate",
				CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549"),
				CreatedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"),
				ModifiedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateSavedSuccessFullyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b6d6976d-e463-4b21-a037-e00156e9c177"),
				Name = "TemplateSavedSuccessFully",
				CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549"),
				CreatedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"),
				ModifiedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"));
		}

		#endregion

	}

	#endregion

}
