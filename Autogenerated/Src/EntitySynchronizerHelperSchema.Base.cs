﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntitySynchronizerHelperSchema

	/// <exclude/>
	public class EntitySynchronizerHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntitySynchronizerHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntitySynchronizerHelperSchema(EntitySynchronizerHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee8a0989-fafe-4e76-8535-27ef7c3823cc");
			Name = "EntitySynchronizerHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("008b5e35-cd1d-462d-aec0-4fb9d28e872d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,89,111,219,56,16,126,118,129,254,7,174,251,34,3,94,101,129,125,75,19,23,117,146,182,193,182,73,145,164,219,135,197,162,160,37,58,22,34,145,46,73,57,241,22,249,239,59,60,116,31,150,143,180,77,219,151,196,146,200,153,225,204,55,167,68,113,68,196,28,123,4,93,17,206,177,96,83,233,94,46,169,247,244,201,151,167,79,122,177,8,232,53,186,92,10,73,162,231,165,107,247,136,133,33,241,100,192,168,112,95,19,74,120,224,101,107,78,169,36,215,28,171,167,47,231,129,171,46,249,20,216,136,108,73,198,240,136,69,17,163,245,79,56,105,186,239,30,143,27,31,189,194,158,100,60,208,236,96,205,51,78,174,65,18,116,20,98,33,246,209,9,149,129,92,170,99,206,56,163,193,127,132,191,33,225,156,112,164,23,239,237,237,161,3,17,71,17,230,203,145,189,126,207,217,34,240,137,64,17,145,51,230,11,52,101,28,205,49,199,160,130,16,137,148,146,62,48,242,24,157,134,129,39,5,226,68,176,112,65,92,75,230,140,220,34,162,153,15,145,199,9,150,196,71,70,254,18,137,33,82,18,131,154,57,172,8,40,234,87,69,238,163,144,177,155,120,158,208,254,64,131,207,49,129,197,62,185,67,139,128,133,70,150,57,39,11,96,137,252,120,14,34,1,71,195,24,30,37,27,15,246,114,135,253,231,152,76,113,28,202,49,208,1,185,28,185,156,19,54,117,78,155,84,54,24,252,11,187,230,241,4,136,35,79,169,183,81,187,251,168,145,10,144,80,112,203,236,4,152,146,152,74,176,213,123,30,44,64,106,109,153,138,105,244,141,11,163,227,156,214,141,98,172,166,17,5,136,187,233,238,252,97,123,115,67,92,109,21,18,9,201,149,41,62,145,138,148,103,64,2,29,214,90,65,65,176,215,34,155,199,56,192,133,133,62,192,75,206,48,133,63,129,64,11,28,130,173,34,12,92,39,4,108,29,177,5,241,59,9,25,128,45,63,113,77,246,74,134,199,120,41,64,176,223,255,52,56,239,61,35,212,55,58,180,215,86,161,239,12,108,115,234,108,17,90,59,51,44,18,104,130,5,129,231,68,131,102,122,216,191,36,202,227,251,123,35,36,89,254,126,147,93,221,6,93,2,133,134,195,234,59,202,177,34,109,183,195,126,236,245,71,57,78,31,4,225,128,14,106,2,15,8,18,104,164,120,196,61,216,211,219,50,42,156,200,152,83,49,170,149,63,183,45,89,151,215,181,89,8,154,144,213,163,153,103,78,81,18,20,123,3,164,49,220,51,244,16,5,95,183,75,225,153,126,210,83,49,51,142,168,243,42,166,30,252,142,169,116,250,167,126,127,144,60,126,197,89,228,52,232,108,128,176,176,4,53,230,238,91,92,226,104,70,188,27,129,130,41,154,204,35,240,131,64,59,2,14,193,243,253,101,46,214,64,112,1,67,42,248,193,153,133,84,145,179,163,89,140,140,32,251,168,2,3,23,238,238,141,42,230,216,202,168,195,90,50,65,150,100,76,78,234,143,114,121,7,206,169,238,25,255,111,68,199,21,143,201,80,105,202,70,139,68,73,185,248,11,122,207,171,172,1,50,19,198,194,12,48,111,153,119,67,252,87,140,95,104,229,42,99,58,54,190,36,170,27,162,10,132,134,6,7,118,97,229,120,224,233,52,14,195,18,208,90,121,102,204,98,64,92,204,57,220,80,108,1,125,84,66,146,52,79,134,85,94,131,71,15,50,118,11,97,76,109,62,185,3,59,82,28,162,64,233,80,223,70,144,204,129,206,52,0,77,252,66,234,106,164,190,142,3,31,89,133,110,141,91,27,92,133,249,119,216,26,101,179,208,249,113,6,71,116,172,249,85,208,116,79,197,201,231,24,135,142,9,170,238,123,165,54,2,138,112,148,180,234,82,144,20,255,131,52,198,190,164,190,211,63,50,197,215,120,5,33,123,226,65,57,246,246,192,10,206,111,230,184,176,251,12,14,119,206,79,162,185,92,58,85,71,74,142,221,75,15,108,126,24,73,78,43,200,104,145,167,142,120,73,178,251,124,104,176,140,78,238,136,23,131,105,61,28,98,126,0,68,70,206,0,141,208,31,107,184,184,117,223,85,94,14,145,160,171,115,27,138,167,112,8,83,185,254,69,150,253,145,45,98,45,144,84,145,173,125,22,42,224,66,252,216,173,203,62,90,143,133,31,56,204,59,108,141,78,191,173,183,154,152,162,76,219,130,234,26,169,127,94,143,211,129,73,53,142,170,194,87,192,223,174,204,206,53,137,221,51,174,118,69,195,12,197,198,35,111,200,178,221,95,252,128,27,128,245,71,74,12,148,94,183,111,251,54,73,122,151,30,159,248,232,130,65,138,52,230,171,218,169,152,81,181,91,106,159,78,181,180,227,20,219,28,15,96,97,202,20,189,208,92,221,51,114,171,254,59,3,247,138,93,234,157,128,214,253,76,88,131,115,45,96,146,79,235,200,228,51,174,242,97,32,81,36,111,232,44,48,71,85,188,94,122,51,18,97,32,11,117,170,213,159,190,243,14,83,124,13,0,128,176,115,106,205,56,94,42,112,55,246,73,109,92,128,126,19,107,55,111,59,21,201,12,157,234,114,247,146,200,99,50,53,161,226,111,213,200,11,167,117,113,110,101,177,242,24,38,246,238,190,61,45,127,134,169,41,186,111,206,162,241,176,14,26,221,9,85,67,104,99,7,81,75,14,47,136,147,54,24,173,227,19,53,24,73,162,97,97,140,210,41,44,22,230,36,42,26,250,106,94,162,202,10,207,180,66,40,86,189,208,67,142,34,10,225,193,156,39,47,111,96,194,67,227,48,65,193,216,135,156,34,137,73,189,99,44,106,194,203,177,94,145,165,223,98,149,123,78,117,134,123,75,132,168,38,184,99,88,113,21,64,76,59,99,183,238,75,223,87,154,114,138,138,27,152,156,103,152,24,163,26,145,146,52,231,116,104,22,109,94,179,103,1,192,241,101,197,16,53,163,67,157,14,196,78,44,212,95,119,90,100,14,220,97,90,100,22,174,52,207,170,137,209,106,243,54,119,241,63,128,5,118,82,22,124,11,51,22,115,119,205,24,176,236,158,237,115,62,247,99,32,103,111,32,156,10,71,109,190,96,183,170,224,87,55,156,65,169,188,222,164,141,205,185,113,183,214,47,233,249,66,221,118,104,200,148,222,86,108,80,93,86,27,61,243,240,87,145,185,121,91,217,98,160,181,218,202,234,8,232,225,11,86,235,45,41,121,155,199,94,116,153,110,106,233,82,65,234,167,153,150,222,126,107,23,157,35,183,225,76,244,10,98,170,100,218,18,169,223,60,66,135,249,154,88,175,237,44,155,160,46,98,207,131,50,102,10,200,217,20,239,71,152,154,176,9,109,137,45,246,87,99,125,55,232,174,97,157,227,153,99,183,249,172,254,199,70,166,122,7,155,4,115,52,66,143,37,156,63,10,136,239,52,156,155,143,26,156,227,177,233,16,64,124,127,146,254,180,61,190,136,57,57,30,103,76,156,108,110,151,45,118,47,37,230,242,138,99,42,176,93,101,58,144,158,4,64,219,229,102,56,216,144,200,234,61,108,69,186,72,37,233,245,26,71,58,27,17,126,158,144,205,29,81,125,254,18,212,158,49,141,28,18,64,146,220,187,183,255,59,81,184,71,30,150,222,12,76,49,57,159,19,35,202,201,157,71,230,234,71,118,202,28,173,11,22,134,19,236,221,212,82,171,14,60,167,56,20,133,106,114,245,39,8,250,99,145,142,165,167,113,137,210,247,53,230,69,3,212,61,33,187,181,222,177,73,63,255,112,111,32,138,93,207,119,26,103,74,74,109,212,102,41,208,152,79,125,138,113,198,78,165,168,41,165,148,130,214,122,35,81,184,220,85,102,173,229,172,209,58,44,115,220,238,237,119,51,72,115,136,193,215,100,107,188,110,249,205,197,207,10,74,219,47,104,84,22,102,216,95,9,136,9,187,220,112,125,168,3,250,78,112,248,157,141,72,183,5,153,181,164,121,153,18,18,204,107,18,111,171,213,18,123,52,142,90,75,203,59,43,184,48,38,179,117,89,162,244,41,103,145,85,4,156,181,209,61,214,248,234,173,171,30,187,143,212,186,121,171,199,252,102,131,124,160,234,220,90,167,1,17,237,118,24,162,38,199,217,108,180,93,180,154,29,131,237,228,125,110,199,137,118,64,103,132,7,210,103,158,53,68,227,215,172,174,42,64,85,226,41,206,82,76,137,157,232,165,28,124,6,96,201,114,40,171,167,163,11,18,157,205,138,37,123,147,190,107,138,249,213,65,43,229,97,51,102,151,178,118,67,109,181,14,160,214,81,87,251,36,43,61,209,230,122,106,96,80,214,213,214,95,218,173,161,188,146,75,174,129,176,58,143,222,26,80,107,190,174,202,94,128,126,223,14,157,83,211,210,234,120,11,77,47,203,101,200,143,161,246,28,173,228,55,180,156,116,172,206,221,237,187,189,236,99,61,219,150,186,231,188,227,55,68,53,69,86,42,209,81,200,4,49,98,60,44,54,148,11,193,194,56,130,70,123,18,146,47,198,146,247,91,56,100,142,218,129,33,50,74,90,42,95,124,13,168,60,20,66,138,86,165,149,237,194,73,143,185,222,219,231,210,248,193,220,45,222,132,123,255,3,101,129,105,69,247,52,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee8a0989-fafe-4e76-8535-27ef7c3823cc"));
		}

		#endregion

	}

	#endregion

}

