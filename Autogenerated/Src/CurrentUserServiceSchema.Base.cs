﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CurrentUserServiceSchema

	/// <exclude/>
	public class CurrentUserServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CurrentUserServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CurrentUserServiceSchema(CurrentUserServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88fa4d35-55b7-4ecd-9071-4428ea6d1d0a");
			Name = "CurrentUserService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("90e8157f-4651-4349-83a7-f0455fc70915");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,88,219,110,219,56,16,125,118,129,254,3,225,46,80,5,48,148,247,196,245,34,177,211,198,139,164,113,227,180,1,54,40,22,180,52,182,137,74,148,67,82,105,221,32,255,190,195,139,100,221,172,149,119,95,22,232,75,100,145,51,135,195,51,60,51,84,56,141,65,110,104,0,228,14,132,160,50,89,42,127,156,240,37,91,165,130,42,150,240,215,175,158,95,191,234,165,146,241,21,153,111,165,130,248,180,242,238,223,166,92,177,24,252,57,8,70,35,246,211,248,213,172,112,246,137,5,112,157,132,16,181,78,250,247,176,104,55,56,11,20,123,170,172,82,12,95,128,63,57,223,59,117,129,209,42,6,114,175,193,92,225,223,166,89,12,12,45,226,184,121,221,221,108,22,237,109,146,42,180,65,99,52,127,35,96,133,17,147,113,68,165,60,33,227,84,8,224,234,179,4,225,172,141,213,241,241,49,25,202,52,142,169,216,142,220,187,155,39,203,68,144,21,40,13,73,24,199,183,216,112,64,232,2,215,33,129,5,36,41,34,250,25,210,113,5,106,40,0,95,191,201,209,221,154,73,34,29,48,254,164,65,0,82,178,69,100,151,129,31,10,4,167,145,65,147,3,34,19,194,20,145,235,36,141,66,254,86,233,48,8,154,73,124,80,190,197,39,151,200,233,19,20,227,218,5,145,45,138,3,15,110,51,120,198,148,160,129,250,170,199,38,176,164,105,164,10,172,193,128,204,229,166,56,96,12,207,228,230,35,40,36,121,131,43,44,88,196,212,246,22,30,83,134,11,224,214,165,87,124,209,71,133,188,35,255,224,162,173,124,55,16,30,233,69,54,233,34,98,1,9,116,154,26,178,68,78,200,57,149,144,231,172,247,108,242,86,77,175,246,24,227,158,82,1,83,164,196,218,84,147,107,6,102,55,227,27,183,154,102,94,19,254,86,98,54,141,175,102,88,231,91,250,185,127,49,165,72,29,85,180,200,101,57,252,90,20,61,29,110,207,249,93,67,188,0,225,125,196,18,128,68,245,181,134,255,76,56,166,38,132,190,161,34,71,147,74,152,179,94,176,32,207,250,16,156,234,0,79,201,139,221,95,43,172,126,111,135,53,30,135,194,78,195,10,232,135,148,133,57,228,52,236,12,232,24,111,198,203,72,60,24,110,255,174,199,59,131,67,65,175,40,95,165,116,213,14,156,25,117,6,15,169,2,205,219,123,35,224,102,30,38,21,155,127,9,190,159,149,73,205,174,186,68,175,231,214,121,3,60,180,162,43,43,240,26,212,58,9,81,131,51,131,220,34,189,15,88,190,212,26,74,165,179,160,189,74,45,107,144,159,43,169,104,205,229,104,92,119,51,138,174,174,224,235,130,104,93,140,132,111,54,96,91,109,73,199,15,216,78,166,252,41,249,6,158,221,144,102,113,118,51,191,235,15,200,121,18,110,231,106,27,105,102,209,236,26,43,55,38,58,31,245,239,5,221,108,32,28,24,126,117,113,3,169,44,161,37,7,59,228,255,33,19,62,32,183,120,13,72,184,132,118,59,155,179,7,27,255,9,113,6,51,42,48,81,170,65,76,72,133,203,179,75,115,165,34,233,20,20,106,172,155,241,142,136,45,83,79,20,91,145,124,68,68,14,223,137,105,220,219,121,176,198,118,242,41,5,177,245,140,79,194,57,4,38,73,69,131,107,202,49,50,49,32,125,188,65,156,133,49,227,159,57,83,253,12,185,135,174,102,244,150,173,214,74,226,10,75,26,73,176,148,245,166,43,142,87,128,9,147,155,136,110,191,208,8,9,68,11,37,82,48,243,47,167,230,129,145,249,51,193,244,105,48,225,140,147,40,141,185,63,149,95,152,237,164,14,244,52,223,75,94,99,172,41,26,104,140,179,208,189,123,58,86,199,129,175,5,88,243,212,252,118,240,181,250,170,121,103,37,161,3,66,102,90,131,42,118,137,125,56,119,133,218,92,247,220,191,251,135,204,241,68,163,159,236,96,190,250,205,80,109,116,180,128,85,247,84,173,124,251,32,203,197,169,18,83,189,194,117,132,169,70,3,230,20,59,55,212,135,61,213,149,179,62,32,149,179,95,80,17,6,230,224,216,146,120,25,28,106,40,141,162,252,252,91,9,155,49,107,107,74,107,62,140,114,171,74,213,57,22,90,235,59,23,171,142,242,110,139,21,199,238,208,8,102,168,251,197,200,171,38,221,236,246,104,80,134,26,219,171,90,11,152,237,14,59,184,221,233,107,4,116,101,232,0,192,93,190,74,128,187,190,223,97,175,21,117,55,1,117,15,172,38,248,38,184,188,199,31,2,89,174,2,37,216,90,123,239,176,235,102,241,180,192,118,231,96,159,164,44,120,161,20,191,180,55,121,217,212,229,215,9,134,177,209,228,5,250,27,160,67,131,191,44,123,252,2,109,92,115,52,219,93,52,203,87,181,114,235,190,116,166,165,222,173,169,54,167,168,181,88,21,74,223,255,170,215,103,90,163,184,72,125,15,115,253,189,140,217,214,179,254,61,83,235,171,36,160,145,126,69,114,188,254,101,78,93,17,102,170,32,118,228,254,150,155,252,245,108,121,122,233,255,199,219,197,158,126,147,173,227,219,47,187,131,59,141,141,206,249,185,6,97,93,127,111,175,55,5,177,118,147,41,171,43,149,200,45,15,214,34,225,236,39,132,228,59,242,76,174,38,103,179,46,122,29,6,35,157,198,225,113,48,34,216,9,139,64,191,130,120,153,156,23,118,92,150,240,34,73,34,77,249,84,22,255,195,81,48,55,7,58,164,155,146,156,37,68,120,38,16,219,155,155,95,71,90,169,246,103,229,208,216,226,220,235,249,187,171,101,142,109,160,49,133,125,103,228,191,23,73,236,85,164,235,166,238,215,128,159,3,125,125,211,194,147,127,241,152,210,200,115,66,216,109,184,253,38,84,62,183,118,11,254,197,15,8,82,5,115,84,44,21,67,205,198,200,43,157,209,202,199,165,29,45,15,226,216,223,89,66,134,217,62,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88fa4d35-55b7-4ecd-9071-4428ea6d1d0a"));
		}

		#endregion

	}

	#endregion

}

