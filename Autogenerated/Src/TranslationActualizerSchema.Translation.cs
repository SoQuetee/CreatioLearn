﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationActualizerSchema

	/// <exclude/>
	public class TranslationActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationActualizerSchema(TranslationActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f124d613-6807-421d-a5f8-5319edc7d6c6");
			Name = "TranslationActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,89,91,111,219,54,20,126,118,129,253,7,214,219,131,12,120,74,247,176,151,56,118,80,164,201,102,244,146,34,206,182,135,97,40,88,137,118,180,200,82,64,82,238,188,212,255,125,135,23,201,164,72,74,74,215,97,47,137,68,29,30,126,231,194,115,115,129,183,132,61,224,132,160,91,66,41,102,229,154,199,23,101,177,206,54,21,197,60,43,139,248,150,226,130,229,242,249,155,103,143,223,60,27,85,44,43,54,104,181,103,156,108,103,173,119,216,155,231,36,17,196,44,254,137,20,132,102,137,67,115,123,71,9,78,97,225,248,197,60,124,187,45,11,255,23,74,226,203,130,103,60,35,44,72,112,133,19,94,210,46,10,67,32,160,1,170,111,41,217,192,11,186,200,49,99,167,232,55,154,113,242,166,76,112,158,253,141,63,230,228,87,156,87,228,114,71,10,254,146,110,152,220,241,80,125,204,179,4,37,98,67,15,61,58,69,198,222,209,163,220,95,51,88,190,148,170,186,33,172,202,57,82,255,20,166,131,66,70,138,84,129,243,1,53,4,1,62,149,56,159,80,23,159,151,12,96,45,3,251,107,140,245,105,151,69,181,61,69,53,133,36,95,113,204,43,166,69,161,217,14,115,130,8,144,249,169,70,130,227,104,52,90,22,239,105,185,161,132,177,169,124,127,87,114,32,161,156,164,226,245,160,79,181,69,62,202,12,30,197,113,193,65,238,247,234,68,251,248,68,124,71,140,83,105,113,87,178,26,17,229,111,1,0,222,144,91,178,125,200,197,206,185,4,51,54,246,32,108,110,2,166,176,11,205,209,239,143,47,14,40,122,252,225,48,249,99,60,123,242,217,151,69,170,79,6,86,29,167,129,252,95,192,125,117,159,61,12,98,207,128,176,131,127,219,143,217,96,253,25,59,209,78,110,253,87,106,236,6,98,43,179,247,104,173,211,46,255,186,202,72,158,134,156,11,160,115,184,79,34,108,149,69,190,71,229,199,63,33,200,9,140,247,215,234,113,142,10,242,73,175,71,147,158,179,164,47,211,74,4,42,102,197,3,239,141,140,204,139,10,55,104,151,165,112,127,185,187,166,110,213,104,9,97,246,2,2,73,69,201,178,88,151,205,14,230,93,158,90,113,224,77,185,217,216,204,213,202,4,169,43,236,67,50,247,97,145,134,29,5,144,204,3,88,102,237,51,52,156,185,11,200,33,189,164,180,164,63,227,34,205,67,144,16,102,150,172,230,142,153,17,129,186,109,1,65,186,172,104,66,26,174,180,181,96,43,244,255,178,151,98,125,138,248,93,198,34,223,217,65,246,65,219,127,104,75,10,106,110,47,205,6,68,114,160,125,32,84,36,241,238,219,230,201,37,232,67,82,81,42,178,169,231,219,220,183,35,62,38,153,217,192,51,46,194,71,40,69,108,8,215,79,163,28,34,0,138,142,113,160,214,213,104,68,9,168,182,232,2,172,92,88,104,171,249,203,134,112,238,214,129,140,127,46,235,131,173,226,87,153,44,60,48,221,159,169,120,59,213,113,119,129,62,64,181,84,22,164,172,216,13,73,74,154,50,29,219,194,91,122,227,157,109,241,146,131,56,34,231,155,128,220,123,229,184,155,182,159,222,238,217,225,44,56,230,170,141,226,120,242,249,57,138,124,254,45,43,45,85,82,238,161,158,229,103,206,169,32,253,100,230,209,115,3,211,23,12,124,107,13,88,197,173,113,84,189,224,50,14,132,141,192,242,147,217,187,81,198,93,25,200,84,23,187,161,104,29,88,63,22,142,125,7,132,252,78,22,222,194,231,36,0,11,12,17,159,20,129,62,238,172,187,142,95,4,234,124,1,184,199,253,223,18,126,87,58,181,197,201,201,9,58,99,213,118,11,55,106,81,47,172,240,14,138,23,35,4,199,13,233,137,73,91,43,98,87,102,169,2,102,40,49,90,26,40,151,208,113,33,248,190,173,3,72,203,111,90,121,0,124,222,239,64,241,13,20,63,81,38,123,60,253,53,157,56,89,184,161,118,48,201,157,175,201,190,157,120,204,118,12,154,199,106,91,188,131,150,116,42,33,199,82,197,19,211,212,94,173,201,195,24,202,219,101,96,64,121,114,229,1,83,188,69,5,156,53,31,223,147,253,120,97,150,204,176,16,159,157,72,18,255,14,201,126,188,144,248,186,41,147,90,212,148,252,53,94,104,193,81,38,94,187,55,110,203,52,91,103,36,189,46,198,139,183,242,57,81,224,82,48,188,181,213,117,134,182,151,70,186,168,190,151,250,87,207,82,4,208,51,92,3,19,227,20,189,2,94,183,217,150,160,35,130,175,226,59,230,41,218,115,188,142,170,243,77,235,83,36,177,107,208,45,23,90,166,83,3,236,20,173,113,206,72,125,132,213,98,83,245,111,238,228,138,216,175,55,121,113,20,35,173,54,197,225,216,124,168,247,120,201,86,85,146,192,42,58,119,150,226,219,114,37,55,71,19,104,187,245,87,205,33,80,242,198,66,174,232,187,49,92,152,83,244,8,162,31,180,236,240,38,255,195,187,169,79,88,54,95,15,166,62,224,219,241,229,128,190,215,8,96,217,146,229,48,214,130,234,17,206,101,171,12,144,186,152,234,205,154,20,180,39,4,244,234,78,105,60,50,233,91,69,136,244,215,208,105,94,215,152,34,159,57,107,239,204,214,40,170,13,12,62,84,229,57,250,252,217,53,16,172,41,55,59,210,56,53,143,152,129,113,156,21,12,12,208,132,174,201,196,174,35,140,180,63,114,57,188,76,83,35,232,217,86,15,171,99,69,248,146,93,220,225,98,67,210,72,14,187,246,102,58,112,239,235,127,117,53,133,50,91,60,158,43,133,53,90,48,211,20,224,86,209,91,199,155,214,5,173,69,50,35,60,116,192,196,91,58,25,234,184,46,58,71,57,81,19,171,234,126,159,92,209,178,73,117,29,149,188,191,89,56,78,168,58,239,165,10,5,241,85,73,183,152,71,79,25,54,77,109,160,186,3,180,214,226,215,144,28,38,97,15,9,171,228,178,72,163,47,22,189,213,39,133,68,239,159,110,117,33,31,48,93,138,60,163,6,19,128,210,152,109,129,167,15,173,142,89,46,254,133,39,239,202,79,218,18,173,85,211,22,158,43,126,145,19,76,163,47,23,216,52,88,64,220,161,99,176,167,96,28,80,167,182,122,180,186,41,144,82,13,8,250,125,81,250,121,59,40,55,49,101,135,41,34,186,2,232,25,172,215,253,240,77,157,211,21,83,221,250,234,22,248,186,8,151,237,81,173,53,143,242,21,129,149,236,252,253,221,46,163,194,32,74,53,203,130,19,90,224,188,25,24,153,21,112,19,171,196,24,209,12,83,78,45,34,98,178,99,248,168,222,54,117,10,254,150,7,122,161,117,42,162,71,211,196,180,93,152,77,157,81,59,210,100,7,6,49,169,154,34,242,68,79,53,58,59,111,107,208,88,98,72,87,229,212,224,86,96,134,22,225,142,200,234,27,241,82,79,179,237,49,243,90,132,111,171,50,87,205,166,52,64,183,79,120,243,151,80,119,87,32,239,75,98,141,33,62,221,101,208,19,125,29,94,35,245,243,93,188,202,9,121,136,126,124,241,162,190,68,135,208,93,234,76,28,198,15,23,245,61,67,4,202,247,250,184,190,10,192,86,220,172,174,76,246,71,184,158,238,84,174,97,25,163,34,136,192,243,69,67,61,234,188,194,222,195,70,135,70,3,104,157,193,214,252,120,120,79,178,14,206,233,250,124,217,105,117,89,104,80,224,243,64,55,182,212,214,29,152,162,21,238,55,25,227,103,173,186,115,97,20,158,108,64,229,233,142,16,204,17,208,57,16,49,34,155,3,202,60,180,22,47,93,98,26,159,89,212,2,51,245,231,148,62,16,98,42,163,49,56,9,182,19,20,96,247,160,18,119,139,180,161,105,62,78,46,104,140,86,139,63,168,168,232,29,153,64,189,110,69,68,57,16,31,60,48,49,54,90,131,147,96,240,147,109,141,57,233,9,118,56,29,191,52,5,172,172,122,10,166,61,217,108,150,244,37,180,70,7,246,172,195,28,113,28,163,128,213,132,89,221,151,167,81,58,116,101,44,223,207,248,176,246,15,71,32,117,143,118,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f124d613-6807-421d-a5f8-5319edc7d6c6"));
		}

		#endregion

	}

	#endregion

}
