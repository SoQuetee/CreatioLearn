﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityInForecastCellRepositorySchema

	/// <exclude/>
	public class EntityInForecastCellRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityInForecastCellRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityInForecastCellRepositorySchema(EntityInForecastCellRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19a1b566-bff9-4419-a4c3-315439bb0a61");
			Name = "EntityInForecastCellRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,93,111,220,54,242,121,11,244,63,240,182,125,208,162,11,57,45,112,119,64,98,59,112,28,59,183,64,82,187,118,146,62,180,135,66,222,229,174,117,213,74,27,81,235,196,205,249,191,223,144,195,111,145,146,252,145,164,5,238,37,142,168,153,225,112,190,57,164,182,204,214,148,109,178,57,37,175,105,93,103,172,90,54,233,97,85,46,243,213,182,206,154,188,42,211,227,170,166,243,140,53,111,127,248,250,171,143,95,127,53,218,178,188,92,145,85,81,93,100,197,227,199,135,213,122,13,64,47,171,213,10,134,159,232,247,231,215,172,161,107,255,25,72,23,5,157,115,186,44,125,65,75,90,231,243,22,204,203,188,124,215,26,60,167,243,109,157,55,215,230,133,205,111,77,195,227,156,183,24,70,122,84,54,121,147,83,22,5,120,254,44,250,234,56,155,55,85,29,69,182,229,119,150,175,46,27,118,78,235,171,124,30,100,243,103,122,97,88,133,247,223,212,116,5,136,100,86,54,180,94,130,106,30,147,153,224,245,122,86,42,101,28,210,162,56,163,155,138,229,192,198,181,64,219,217,217,33,187,108,187,94,103,245,245,190,124,62,173,171,171,124,65,25,89,211,230,178,90,48,210,84,100,69,27,146,151,203,170,94,11,254,200,178,174,214,100,41,233,146,57,16,102,169,34,183,99,209,219,108,47,138,124,14,168,146,171,126,166,70,220,92,90,124,137,129,23,180,97,56,23,121,159,55,151,100,147,129,249,32,63,213,6,205,67,227,238,248,200,187,155,172,206,214,164,4,211,221,27,43,206,207,47,41,109,198,251,175,47,169,89,12,227,99,48,57,165,100,94,211,229,222,24,129,200,206,126,186,187,35,136,132,105,110,192,46,171,197,108,193,198,251,198,96,73,181,36,248,130,245,96,103,43,154,93,20,20,205,96,188,127,42,159,201,220,182,11,155,173,83,23,35,200,95,77,155,109,93,50,61,224,50,134,162,180,72,114,93,112,66,70,138,54,129,95,78,46,88,85,208,134,38,227,127,166,223,255,157,252,151,188,18,6,66,114,70,22,116,195,197,215,208,69,74,222,48,202,85,197,137,177,68,8,143,56,242,158,146,49,249,142,19,28,141,193,26,182,107,90,243,101,236,190,216,230,139,125,162,165,56,37,237,151,64,164,170,249,203,201,120,242,111,78,193,6,225,243,237,247,76,220,53,159,224,200,21,42,113,181,50,65,87,235,53,206,139,107,201,233,95,216,30,181,168,199,251,103,184,22,142,42,120,249,196,102,22,215,233,179,107,201,202,237,149,219,105,76,195,212,250,215,210,229,103,82,201,173,53,209,41,236,243,236,10,210,78,3,18,227,12,62,152,192,135,89,58,98,226,19,129,252,7,121,106,153,211,186,27,57,47,23,57,132,189,170,86,248,122,96,48,9,37,26,196,199,167,193,200,87,89,177,165,67,48,175,170,124,33,228,203,213,22,214,26,215,148,246,10,249,104,173,79,142,40,118,167,228,45,159,123,6,69,1,17,92,112,205,142,110,162,85,197,204,170,30,192,2,5,74,87,201,48,47,50,198,204,28,253,133,1,136,156,241,191,220,124,52,245,152,253,8,0,253,248,58,128,98,32,36,67,11,58,207,215,89,129,44,145,143,188,36,122,194,103,124,66,110,244,194,191,161,229,2,11,177,104,81,118,203,98,236,232,67,3,52,153,91,107,129,150,20,162,42,210,130,162,68,130,148,102,5,171,164,163,247,23,236,105,79,137,38,195,68,187,178,11,131,147,222,66,20,226,197,172,100,180,110,238,80,18,62,72,196,56,118,195,51,175,115,59,157,142,79,5,129,152,43,194,135,29,224,102,2,143,147,232,207,59,124,93,84,200,238,129,83,80,60,95,12,8,252,168,205,104,248,255,83,45,43,146,68,77,188,236,41,131,230,85,177,93,151,18,67,62,220,75,120,3,179,230,169,96,46,90,193,104,79,17,28,237,43,206,58,69,255,156,242,218,157,125,57,201,131,20,79,111,37,115,237,151,183,20,188,112,66,92,238,157,196,61,92,216,60,236,143,188,184,63,138,4,126,80,126,52,192,245,237,196,87,22,251,178,120,235,138,251,237,216,220,53,121,79,94,149,246,226,77,15,123,156,101,94,0,125,119,131,58,212,160,88,40,242,118,155,5,78,167,246,199,199,161,201,31,202,49,25,90,200,177,53,35,177,167,143,169,62,162,249,158,236,246,201,149,127,231,236,138,136,58,189,222,53,92,220,37,191,50,76,176,44,156,97,145,177,129,206,141,42,22,68,173,26,53,162,183,67,94,118,62,38,138,229,131,205,230,232,10,60,224,101,206,26,222,121,140,214,105,103,128,14,32,53,147,133,235,5,175,156,203,213,29,234,50,211,217,75,253,217,159,101,140,186,229,23,78,22,227,22,106,175,16,9,165,115,181,102,108,227,192,170,79,5,81,204,33,114,130,234,10,24,3,51,36,66,238,39,37,208,59,111,178,186,73,20,97,240,136,134,126,224,49,90,252,157,16,65,122,36,228,136,13,207,235,244,25,8,99,55,82,31,78,73,119,117,184,159,8,165,73,173,185,145,118,136,38,239,216,4,157,173,55,5,93,195,250,30,164,13,26,80,248,176,42,251,151,231,116,153,109,139,230,25,154,83,210,92,111,104,181,76,122,144,39,162,59,22,195,141,230,130,201,148,252,8,14,72,246,200,248,96,222,108,179,2,187,108,142,169,117,79,76,162,27,156,105,111,14,178,45,18,140,138,53,25,8,31,108,178,206,175,178,134,74,163,196,7,110,108,60,156,52,181,104,246,115,151,199,228,172,216,199,192,243,36,138,50,83,219,90,23,77,15,119,160,98,169,224,226,225,88,7,146,216,51,186,56,98,168,3,229,172,122,239,34,192,64,7,184,146,44,64,113,96,235,113,0,146,59,145,59,26,66,135,220,66,94,101,31,78,121,80,166,60,232,29,86,219,178,1,41,252,180,165,245,245,225,229,182,252,29,8,125,255,232,209,163,8,178,180,76,160,1,12,34,182,65,240,221,188,101,24,245,150,135,149,112,188,234,182,207,228,13,19,57,188,148,173,176,173,243,168,98,151,59,154,30,94,210,249,239,7,245,106,203,195,193,143,91,216,215,241,52,5,158,228,97,99,156,26,121,83,236,121,147,196,130,153,189,202,227,156,22,139,152,237,131,99,52,176,208,154,102,139,170,44,174,201,236,101,181,34,191,21,240,207,30,129,255,190,202,202,108,69,235,20,188,141,159,175,209,122,119,72,124,237,226,6,10,17,168,139,249,161,23,231,168,106,96,29,116,225,243,36,236,233,55,172,21,141,57,73,245,75,28,5,118,228,65,73,177,243,224,138,255,27,97,181,214,166,151,206,24,87,192,73,125,180,222,52,215,201,4,161,71,79,73,210,2,5,105,152,189,170,30,77,38,10,231,113,132,91,81,215,141,70,140,51,211,6,1,170,162,49,132,77,31,165,71,179,66,79,249,222,163,108,26,221,184,194,195,2,230,55,167,130,241,4,135,32,199,54,132,45,52,162,228,229,210,32,214,82,112,213,216,228,138,26,180,51,129,178,231,145,75,85,75,192,8,171,37,5,60,189,252,23,45,192,110,220,135,152,166,157,114,1,244,182,107,99,237,39,37,125,111,187,190,226,61,25,187,190,53,158,122,18,87,107,8,179,121,81,85,133,22,234,155,217,219,31,142,74,94,48,46,200,222,190,71,135,179,52,99,199,52,3,102,169,132,74,198,54,234,184,207,139,76,145,21,118,106,225,25,48,205,249,252,146,174,51,97,171,162,223,186,157,45,84,92,146,178,242,88,67,19,71,52,229,252,199,144,242,103,34,133,206,233,179,235,55,179,69,194,201,164,218,200,111,98,179,183,253,197,157,219,177,144,84,35,156,209,37,173,41,76,134,152,94,152,157,60,141,206,44,154,97,135,16,203,112,171,158,32,57,185,231,244,230,22,70,192,225,165,233,200,184,6,234,146,240,156,159,215,80,228,200,236,44,50,44,158,63,36,223,142,63,250,75,187,153,45,198,19,60,245,27,205,76,155,123,32,181,64,5,97,19,196,209,193,212,218,137,216,38,118,42,155,64,3,137,249,21,138,77,10,155,215,157,116,100,159,123,63,241,138,22,69,2,50,246,96,86,156,34,70,240,129,238,24,50,133,246,150,13,246,223,5,238,241,180,238,212,25,22,149,215,48,148,137,240,237,141,189,209,3,254,184,185,152,97,185,139,24,241,88,150,205,47,137,107,105,80,148,180,72,142,176,156,63,88,44,18,203,64,165,101,218,113,69,217,167,128,15,173,204,246,80,81,33,9,79,99,239,180,115,73,255,99,218,245,49,121,89,161,192,245,59,245,164,50,59,231,12,156,92,50,117,149,213,132,178,119,82,4,173,201,147,254,248,49,181,88,145,68,129,96,10,145,139,111,104,176,200,19,106,133,124,124,80,188,207,174,217,57,229,154,129,41,33,66,211,78,140,147,122,65,235,231,121,173,203,35,119,32,61,96,115,42,246,43,79,108,217,2,177,184,100,77,224,210,18,181,23,37,23,3,83,245,175,28,53,31,136,159,183,81,128,107,90,123,114,254,20,173,72,50,234,69,72,119,177,2,36,180,94,220,132,203,107,24,224,107,249,2,70,85,54,100,73,223,9,30,174,174,231,24,79,7,93,36,227,86,11,88,119,201,114,65,129,40,111,176,166,234,192,178,160,20,162,98,166,3,75,129,76,180,145,119,86,50,184,148,73,84,134,109,217,153,99,25,41,0,113,160,20,157,64,64,74,94,4,164,202,70,29,107,112,224,28,100,149,46,250,144,21,156,131,124,218,47,61,7,174,67,44,202,180,102,96,152,181,62,198,186,239,193,176,227,147,198,45,44,175,197,213,60,207,133,51,64,192,216,197,136,56,37,213,197,127,192,67,120,207,29,230,19,87,188,100,88,235,128,149,225,123,212,74,132,83,205,227,205,84,193,4,242,248,212,94,156,129,244,218,12,83,175,22,178,65,253,82,99,170,165,135,9,67,38,192,81,190,36,201,223,100,30,61,166,205,252,242,184,174,214,207,159,37,102,181,83,178,204,10,6,150,172,86,133,186,144,41,24,36,40,178,177,204,74,169,73,24,83,75,95,62,159,170,174,23,179,219,117,54,207,229,135,89,121,4,115,35,37,188,110,35,64,18,171,163,48,69,6,12,83,163,230,18,70,132,94,212,149,203,163,15,115,42,238,228,37,168,30,30,50,215,89,147,72,132,145,200,206,213,28,220,240,15,158,241,207,5,80,50,118,111,76,66,61,63,70,89,166,154,94,250,99,37,24,2,122,41,182,129,117,113,3,57,199,151,131,222,196,72,193,43,0,218,60,167,75,171,100,97,202,6,45,8,235,117,172,172,50,22,213,139,30,41,24,29,99,235,37,226,217,32,18,136,233,55,74,37,84,9,27,131,233,69,111,21,117,202,30,236,154,40,140,237,149,148,83,121,235,226,173,190,63,98,16,33,248,36,241,64,229,6,168,86,236,254,19,132,26,39,228,154,208,208,174,244,37,168,10,237,15,20,112,156,92,243,249,162,142,51,237,255,67,207,39,13,61,110,82,239,163,17,222,98,122,198,247,69,3,144,91,30,125,206,40,36,102,238,13,66,38,4,9,119,208,110,208,218,189,133,175,210,137,195,79,211,204,225,187,52,166,118,77,104,190,252,193,223,24,164,175,171,77,242,189,106,90,74,69,117,108,173,97,239,2,222,156,88,251,55,133,250,243,37,173,163,210,159,192,78,238,232,221,54,131,88,138,219,52,221,219,183,170,124,69,233,160,92,68,108,161,131,140,90,254,132,100,76,174,213,108,87,85,104,65,129,128,199,129,43,55,244,28,124,52,171,101,55,65,109,145,56,100,215,158,4,195,131,179,159,18,99,195,90,14,250,34,64,123,207,14,91,80,165,59,126,132,65,214,226,240,66,157,93,120,91,203,131,205,198,122,122,149,125,144,125,50,133,176,79,30,17,20,231,211,91,162,34,214,227,208,17,10,46,90,116,53,183,140,158,44,151,140,54,34,192,159,242,15,37,248,249,192,11,241,1,14,63,195,165,77,35,142,167,223,4,0,205,254,61,244,22,79,52,34,72,45,177,157,224,135,25,226,38,189,250,127,164,49,161,94,127,212,125,38,134,179,0,194,35,213,10,147,23,242,237,6,130,26,67,163,50,157,132,227,188,102,141,135,103,105,204,210,159,7,116,168,18,33,198,231,222,50,32,177,187,90,163,104,175,202,89,183,121,239,121,252,148,27,90,122,86,85,50,17,166,86,19,38,76,218,30,184,247,20,220,180,133,174,180,228,205,120,29,20,30,190,127,127,153,23,148,36,6,196,129,209,233,154,39,254,144,245,152,124,110,25,74,234,152,128,225,74,166,6,97,161,103,20,6,80,243,216,221,10,102,93,71,66,28,205,110,117,199,132,100,113,162,136,218,204,221,198,20,127,164,31,26,59,161,129,53,240,198,226,89,86,174,104,226,179,168,38,179,196,237,131,164,150,228,71,150,186,190,219,211,74,122,98,219,164,234,222,235,134,170,110,118,14,238,87,10,188,163,243,159,110,127,227,95,170,246,216,59,69,106,159,119,181,163,135,236,99,170,118,41,66,129,224,48,187,192,50,32,38,235,65,188,174,37,6,167,238,7,7,163,190,62,162,216,83,136,115,107,145,242,99,183,135,84,248,7,35,198,230,176,119,28,57,113,79,181,156,243,196,64,139,247,147,183,35,205,177,203,72,117,197,65,148,7,69,81,189,167,11,14,244,186,194,58,54,49,183,163,220,235,113,45,73,128,40,184,152,36,41,33,50,230,96,235,6,59,207,235,2,86,221,227,146,152,90,72,175,32,125,229,230,38,87,98,23,80,6,49,120,130,215,145,190,67,171,235,209,167,221,191,151,18,199,98,73,220,181,223,219,39,119,219,169,136,170,242,204,170,71,90,7,144,194,236,90,98,104,151,147,61,252,115,73,231,120,85,15,227,191,92,182,95,74,206,202,166,74,90,157,125,87,97,120,169,221,165,143,219,181,243,108,25,104,57,99,31,84,71,111,126,11,44,47,213,17,128,90,49,82,112,109,86,148,112,250,171,3,158,104,249,62,139,46,160,160,57,207,255,160,173,104,108,213,232,102,186,151,213,42,78,226,231,172,46,249,206,78,221,181,71,6,53,25,147,219,84,174,64,25,166,106,87,166,202,93,168,149,226,155,176,86,157,235,181,90,61,34,177,93,88,152,140,105,247,122,100,130,219,176,22,141,214,190,204,39,19,222,135,133,121,49,125,107,143,72,96,35,22,166,32,93,193,70,111,237,196,194,152,111,173,110,190,84,22,55,40,169,47,123,47,205,35,114,213,248,225,88,2,202,109,69,210,17,82,68,241,28,182,244,86,147,169,129,252,36,39,136,248,133,52,47,179,250,190,22,189,29,45,70,55,100,158,53,226,168,82,53,32,8,253,160,215,4,166,239,207,106,26,31,156,216,148,67,171,82,2,35,156,232,234,4,78,46,245,161,93,40,45,14,242,177,150,112,248,133,164,148,191,5,19,49,247,248,57,20,70,85,209,248,123,76,62,26,253,222,160,143,235,19,217,133,122,171,187,88,230,195,225,209,183,99,253,185,155,2,51,189,54,121,67,223,122,103,154,107,54,9,239,179,76,1,222,238,177,249,95,111,114,125,181,0,133,237,79,12,241,49,21,82,98,132,129,144,72,145,175,115,81,50,145,249,182,174,97,129,228,252,167,151,4,84,151,17,126,41,115,28,239,115,118,106,89,11,125,74,66,38,34,84,112,84,215,85,13,58,16,127,9,86,233,74,1,156,44,71,17,31,211,195,100,191,142,133,180,158,194,178,211,215,149,236,139,77,110,126,29,59,82,211,250,49,240,250,236,203,195,210,122,48,160,250,164,203,1,37,83,107,2,243,37,163,65,211,103,92,222,12,188,247,103,195,161,151,57,64,99,227,8,29,245,67,160,208,49,245,205,224,252,43,235,82,85,182,255,3,125,109,81,109,249,151,252,107,121,99,146,193,98,212,29,201,4,223,77,250,110,83,238,4,38,48,27,51,44,172,212,172,16,23,27,32,216,92,166,135,52,47,84,6,100,184,103,72,38,64,171,197,137,117,115,64,151,119,136,116,190,41,242,230,164,4,112,30,212,204,60,110,89,141,47,108,25,15,184,6,229,221,36,212,69,81,94,243,187,199,104,255,86,173,223,217,145,225,123,186,217,170,4,159,124,158,179,77,145,93,235,173,187,123,33,65,211,75,188,20,58,9,193,4,206,108,130,112,237,172,30,4,243,43,136,32,144,159,147,131,64,254,213,156,16,140,147,151,99,5,168,39,107,181,133,10,202,122,208,46,143,243,32,169,136,171,51,252,25,47,62,224,232,207,16,107,140,165,39,234,19,155,245,38,171,115,86,149,252,42,81,42,58,136,178,39,211,123,8,162,47,31,64,65,160,185,137,110,204,226,236,137,194,129,35,225,235,182,178,116,86,166,144,68,205,133,202,90,126,25,244,162,174,182,155,88,107,75,45,83,247,26,204,198,117,100,161,243,95,196,1,131,43,78,96,33,153,108,41,248,67,60,178,205,155,244,164,14,160,63,132,192,71,241,83,115,8,33,32,248,93,221,245,154,132,150,208,146,106,191,72,91,90,177,232,117,94,224,244,205,247,200,124,153,218,105,201,33,99,29,46,250,131,114,241,228,203,218,122,167,21,247,203,123,32,122,32,170,13,12,35,136,113,235,96,50,151,181,129,219,104,81,131,183,104,182,220,223,43,239,231,148,15,237,147,193,67,99,45,151,176,83,14,244,201,168,146,251,157,114,112,166,183,190,210,216,217,217,217,205,203,75,48,204,102,81,205,229,15,142,200,79,55,30,242,87,70,172,202,76,183,16,117,7,211,163,19,105,21,234,201,181,85,220,124,214,53,180,15,37,2,191,72,212,190,33,221,186,242,122,47,174,239,241,147,59,200,126,215,239,238,72,230,151,237,190,80,232,198,157,251,35,3,90,87,146,88,27,79,5,10,239,178,34,155,88,197,238,173,109,227,161,67,126,252,166,88,204,175,191,148,117,222,241,23,9,164,142,173,18,162,71,79,70,226,114,193,95,232,220,32,149,231,241,25,111,0,103,86,242,109,229,55,129,39,215,27,197,186,143,218,62,195,111,247,12,63,163,137,223,62,54,211,59,51,155,73,175,172,27,22,225,155,166,183,33,241,48,130,107,53,174,6,136,160,179,219,231,46,200,188,24,202,238,157,63,109,31,206,191,57,232,178,14,110,238,26,62,172,154,59,248,107,48,15,125,250,55,104,183,28,222,11,24,175,31,252,185,200,176,179,226,9,63,129,59,202,230,151,73,222,208,53,184,190,233,251,98,154,240,63,93,178,191,93,226,40,119,248,114,9,9,221,224,95,175,27,227,127,136,210,107,116,247,250,177,148,118,162,239,73,6,247,73,248,75,111,75,212,209,81,247,65,221,175,13,2,153,200,77,65,58,1,169,208,30,255,22,64,46,207,42,44,238,118,206,203,191,50,4,107,192,35,94,151,253,1,71,188,124,222,133,80,36,122,143,188,182,34,70,124,131,149,19,134,239,138,201,211,79,252,138,190,251,86,87,76,198,102,231,22,57,146,177,24,149,46,33,174,149,121,31,159,227,228,101,107,94,150,120,249,118,206,243,237,92,48,208,58,38,82,250,190,21,31,170,225,28,155,95,17,149,243,111,248,252,155,246,252,22,121,239,248,73,188,191,119,193,214,251,75,53,202,229,172,177,14,143,179,49,195,133,139,217,16,200,169,29,202,167,166,56,116,198,207,236,223,218,12,255,150,7,151,133,24,255,218,255,69,15,24,253,31,177,109,131,196,113,90,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19a1b566-bff9-4419-a4c3-315439bb0a61"));
		}

		#endregion

	}

	#endregion

}
