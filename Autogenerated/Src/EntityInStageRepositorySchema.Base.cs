﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityInStageRepositorySchema

	/// <exclude/>
	public class EntityInStageRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityInStageRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityInStageRepositorySchema(EntityInStageRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ffe760dd-c173-4824-bde4-149057e09a31");
			Name = "EntityInStageRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,203,110,227,54,20,93,123,128,249,7,194,211,133,12,24,50,186,157,216,14,242,156,6,152,153,164,147,180,93,22,138,117,29,171,144,72,135,164,156,26,134,255,189,151,47,61,44,210,137,227,65,55,137,37,222,23,15,15,15,47,69,147,2,196,50,153,1,121,0,206,19,193,230,50,190,96,116,158,61,149,60,145,25,163,31,63,108,62,126,232,149,34,163,79,228,126,45,36,20,39,59,207,241,215,140,62,215,47,155,113,138,130,81,255,8,135,208,251,248,138,202,76,102,32,130,6,215,201,76,50,110,44,208,230,19,135,39,44,148,92,228,137,16,159,137,118,95,223,208,123,153,60,193,101,34,19,109,52,26,141,200,88,148,69,145,240,245,212,62,27,75,146,81,34,148,45,73,209,152,204,24,149,28,19,196,206,105,180,227,53,22,0,73,46,24,153,113,152,79,250,1,216,204,44,214,42,127,159,140,148,239,178,124,204,179,25,153,169,42,187,69,18,87,184,169,184,167,64,239,20,173,95,124,1,41,8,227,68,168,255,114,1,4,236,52,82,245,99,158,1,143,43,223,209,174,243,120,149,228,37,84,143,15,175,184,215,214,182,250,47,101,150,186,226,83,178,33,79,32,79,84,37,39,100,171,97,126,99,201,236,133,2,127,119,197,102,181,246,196,240,151,125,171,28,142,169,218,228,61,174,234,3,234,213,220,56,190,94,252,203,165,226,54,188,167,94,175,119,167,94,36,45,60,100,5,156,170,162,185,84,143,199,150,13,52,125,119,209,30,223,61,37,95,209,212,87,112,207,20,253,9,131,25,129,105,137,205,13,149,192,231,168,155,159,201,77,107,51,255,128,37,19,25,234,211,58,168,59,149,47,97,243,106,251,57,17,226,149,127,76,172,253,29,103,43,228,141,32,5,200,5,75,201,28,209,98,143,50,201,168,18,71,212,19,73,216,114,201,184,44,105,71,207,194,50,38,215,75,88,38,60,41,8,197,51,0,133,172,161,88,83,133,165,50,80,21,54,52,70,71,28,143,42,215,3,53,209,34,85,67,180,105,36,221,182,117,50,171,64,10,225,59,110,56,79,73,181,14,1,3,181,244,47,11,224,120,208,213,111,15,84,93,133,132,134,123,119,209,28,210,33,162,54,113,6,171,158,6,228,174,250,142,71,21,180,93,103,97,52,193,248,118,20,165,227,202,65,150,156,138,233,120,228,126,169,161,38,0,56,175,175,56,163,22,196,145,150,31,87,231,208,168,145,205,60,56,121,109,103,248,142,225,55,108,10,53,161,154,251,154,227,33,148,15,226,179,173,32,72,105,23,253,8,90,135,88,109,83,59,98,31,190,81,58,232,5,34,135,91,139,238,102,176,3,211,138,250,97,147,161,34,203,107,187,207,25,119,246,151,29,32,158,142,108,72,40,188,68,3,179,225,148,163,227,14,42,221,18,184,106,254,62,171,223,18,102,18,82,99,178,116,143,184,92,92,233,158,137,122,63,91,64,145,92,176,188,44,232,119,92,119,167,226,154,162,198,47,91,41,117,215,201,127,203,132,170,253,30,164,84,33,254,22,221,151,39,237,100,62,55,223,59,173,28,61,76,77,38,83,111,92,114,122,74,34,239,192,196,108,25,211,213,174,99,220,145,99,79,134,105,164,51,244,16,57,130,100,65,16,74,101,127,198,159,202,2,169,28,245,75,1,28,7,40,214,141,80,246,135,228,143,214,139,193,64,111,221,94,79,236,169,113,66,244,57,169,13,183,122,97,218,123,188,222,228,117,5,106,169,52,255,44,222,134,139,1,214,68,237,162,72,187,232,161,91,91,104,172,173,90,213,33,49,147,247,12,155,165,191,75,228,98,128,84,123,76,4,68,187,65,119,163,13,236,106,117,25,228,137,140,152,152,199,27,156,113,66,103,120,253,200,104,218,180,56,95,171,236,81,160,168,147,64,42,77,214,137,39,97,172,70,220,10,28,143,168,143,172,158,165,31,24,128,3,8,122,28,226,86,224,14,182,190,180,19,95,156,87,240,121,45,243,55,236,130,140,115,237,214,4,47,68,224,111,186,149,210,50,163,245,161,45,22,43,166,250,111,207,209,120,157,229,216,150,136,168,89,239,239,37,224,129,5,226,217,158,148,129,131,211,2,115,211,113,53,49,111,240,38,109,93,205,11,50,49,75,130,129,227,11,14,88,150,121,255,87,38,23,119,234,148,2,93,137,121,137,87,109,60,185,50,193,232,3,30,98,241,213,115,153,228,195,128,68,14,171,10,45,57,247,150,36,234,105,255,132,138,60,180,104,19,73,253,110,150,218,108,59,76,102,187,4,241,89,154,70,77,188,2,38,141,250,7,7,18,35,112,254,176,21,158,218,216,117,237,30,116,6,146,219,199,127,208,236,154,179,194,140,90,170,88,204,29,11,86,9,94,93,21,188,19,189,225,226,128,175,117,50,51,83,246,177,187,20,58,229,80,199,133,2,56,53,160,253,169,228,123,172,120,55,141,126,233,111,14,132,123,139,157,229,78,50,123,153,219,155,206,93,165,166,209,27,242,153,128,117,206,102,62,119,19,251,73,217,46,75,216,151,203,126,196,120,27,146,254,173,212,0,204,52,216,122,81,91,226,221,165,141,22,23,100,100,110,98,170,229,54,11,223,166,202,112,151,95,42,180,227,143,38,141,55,134,115,214,214,118,75,152,249,33,68,141,169,189,147,30,38,176,163,225,107,9,194,168,217,56,87,109,37,242,7,122,7,171,234,50,205,200,81,241,59,60,170,138,79,235,216,157,245,94,101,120,33,79,114,210,61,42,144,104,173,149,189,18,207,123,175,92,13,205,64,117,67,194,170,30,176,19,54,106,183,41,13,57,68,25,60,203,243,230,42,136,200,14,239,59,227,244,137,86,151,212,85,98,27,75,55,68,231,107,5,76,212,55,66,150,222,210,254,32,190,229,41,240,243,245,37,136,89,212,112,251,193,94,46,88,73,177,11,37,191,182,246,14,14,214,157,231,219,52,186,209,120,30,126,109,127,223,141,125,102,250,34,72,255,167,187,187,239,43,117,220,190,208,107,123,248,119,6,75,221,2,154,187,165,249,250,30,171,67,252,59,147,215,136,120,122,229,76,250,211,241,168,178,111,126,21,219,145,156,131,191,14,116,168,234,227,122,136,83,45,249,83,186,140,100,169,252,145,108,185,105,71,119,58,222,1,242,143,11,121,203,47,97,158,148,185,116,84,203,230,36,114,161,112,203,148,121,238,170,235,201,5,103,47,196,220,164,194,32,217,11,87,79,9,101,251,6,160,69,140,188,96,219,227,102,48,217,216,31,91,146,208,148,132,133,111,178,113,179,223,186,147,67,211,189,183,131,60,7,129,115,81,119,195,55,116,6,118,255,24,159,80,147,227,249,106,179,253,15,108,217,176,48,254,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ffe760dd-c173-4824-bde4-149057e09a31"));
		}

		#endregion

	}

	#endregion

}
