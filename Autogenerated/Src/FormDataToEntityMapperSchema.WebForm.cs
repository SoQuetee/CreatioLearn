﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormDataToEntityMapperSchema

	/// <exclude/>
	public class FormDataToEntityMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormDataToEntityMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormDataToEntityMapperSchema(FormDataToEntityMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69720bdd-86d5-4fc8-98a8-0dc605a74145");
			Name = "FormDataToEntityMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,75,115,219,54,16,62,43,51,249,15,136,122,145,167,26,234,30,91,234,180,73,236,106,26,39,158,216,110,14,153,28,96,114,41,161,33,1,13,0,202,86,50,254,239,93,60,72,128,52,73,187,77,226,131,77,18,251,248,246,189,48,167,37,168,29,77,129,92,129,148,84,137,92,39,175,4,207,217,166,146,84,51,193,147,51,224,128,143,144,125,132,155,83,33,203,75,144,123,150,194,243,103,223,158,63,155,84,138,241,13,185,60,40,13,229,113,231,29,229,20,5,164,70,136,114,82,88,26,104,98,117,101,41,120,255,137,132,161,239,201,27,174,153,102,160,6,9,78,105,170,133,116,20,72,243,139,132,13,66,33,175,10,170,212,75,98,76,121,77,53,189,18,86,208,225,156,238,118,32,45,229,98,177,32,39,170,42,75,42,15,43,255,142,199,138,228,200,67,50,100,34,130,107,65,54,108,15,156,128,101,79,106,190,69,196,184,171,110,10,150,146,212,104,28,80,72,94,146,245,16,148,201,55,11,39,32,71,71,106,89,25,171,208,128,11,43,220,81,116,17,219,15,17,121,210,16,45,186,84,39,59,42,105,73,56,230,193,114,186,167,5,67,251,132,156,174,214,200,76,57,230,133,200,81,52,0,73,37,228,203,233,186,155,14,127,55,44,100,177,74,78,22,86,92,191,244,12,114,90,21,26,57,42,56,167,156,110,96,68,207,235,30,226,71,53,84,10,36,154,205,93,214,181,133,155,51,146,54,135,45,65,62,80,253,129,152,13,219,76,26,135,205,141,152,201,164,15,54,233,177,123,78,174,91,80,73,27,249,17,249,102,229,13,43,94,6,213,199,150,180,79,241,178,79,181,35,239,168,95,118,0,88,162,123,159,126,192,51,151,129,237,116,188,144,2,189,99,74,240,9,201,56,22,137,254,228,244,49,233,0,237,188,58,55,109,64,59,171,148,127,184,31,65,114,90,208,13,209,91,170,9,227,25,75,209,187,138,220,110,65,111,17,84,137,1,55,157,4,237,50,181,14,25,81,85,154,130,82,121,85,20,135,113,160,55,66,20,228,210,145,119,113,237,36,219,163,34,242,20,124,231,200,143,113,242,16,21,17,105,90,73,68,146,85,210,64,243,16,199,177,96,221,27,218,90,212,119,160,137,227,86,80,116,24,138,181,29,176,73,191,113,36,35,181,51,124,242,63,162,138,56,169,246,56,93,191,181,254,203,89,81,168,186,10,12,230,10,163,109,72,36,24,205,81,243,30,49,161,175,180,250,190,141,195,30,42,163,115,76,61,145,153,26,114,97,113,167,77,140,92,36,47,65,227,52,173,74,174,78,165,40,141,183,78,25,20,153,50,221,106,214,126,253,244,217,206,169,240,97,78,92,55,243,198,214,189,197,75,150,160,208,142,58,83,150,94,97,242,166,220,233,131,179,131,229,100,214,150,72,94,44,9,199,138,168,69,77,240,24,104,186,37,29,40,1,8,214,90,7,85,195,59,249,11,14,214,141,23,148,201,19,167,126,238,97,172,176,77,24,171,223,97,119,183,52,158,101,178,36,205,39,156,245,18,236,144,59,51,78,178,47,205,97,0,158,152,9,49,15,32,18,155,12,71,199,94,162,247,70,80,135,174,232,232,78,16,104,47,185,61,237,161,183,191,107,14,227,69,239,219,181,122,135,206,123,47,173,143,103,145,140,163,163,218,62,236,142,154,241,192,237,34,120,153,110,161,164,46,17,188,54,84,235,115,216,29,38,62,77,140,51,254,56,24,44,179,0,171,177,246,234,176,3,47,192,62,214,216,19,19,25,11,197,124,78,154,167,216,8,79,185,86,111,133,248,82,237,204,113,136,229,4,19,213,125,119,56,60,245,60,246,212,188,78,196,90,234,61,129,66,65,144,161,229,33,188,88,157,190,67,252,9,5,118,102,84,125,6,98,35,233,110,139,237,187,104,41,178,86,70,112,30,201,174,13,202,241,238,92,6,150,73,91,29,122,50,214,119,205,153,126,160,179,99,96,123,74,53,134,226,79,29,172,186,158,93,150,6,28,38,201,230,17,46,23,131,72,66,215,89,147,137,184,249,7,245,184,230,134,145,180,11,12,6,229,90,179,194,46,200,78,196,239,202,124,156,181,96,134,12,120,28,98,29,200,125,23,79,253,116,79,112,150,154,30,240,230,46,133,157,157,206,112,23,135,162,221,105,126,93,98,91,218,51,41,120,137,10,147,119,112,251,150,113,8,114,125,133,225,74,47,164,231,57,110,229,4,220,153,233,104,226,68,117,163,178,21,250,152,23,29,211,157,55,111,211,175,193,71,24,100,124,191,180,74,157,193,81,62,76,59,90,188,204,233,156,76,7,110,71,211,145,28,240,17,12,54,188,223,227,186,81,136,219,159,109,197,3,61,63,196,142,159,2,21,21,34,88,133,10,127,20,216,225,52,244,93,217,197,120,22,219,240,96,92,244,151,76,45,219,255,117,127,220,111,9,186,146,188,61,100,227,165,160,30,243,123,193,50,210,237,157,131,77,191,110,96,237,166,51,54,229,113,209,53,14,193,205,166,53,219,146,15,144,131,4,220,155,252,244,48,167,206,174,179,10,17,49,188,198,175,179,122,190,61,104,139,107,123,108,54,146,215,141,252,89,91,213,83,26,227,120,195,137,49,224,222,97,112,185,237,132,252,214,58,123,73,102,174,19,30,217,213,228,191,173,94,143,222,165,237,190,168,188,115,73,142,38,215,235,240,83,239,214,185,191,92,78,87,110,53,138,69,140,94,106,157,206,233,202,199,215,254,235,225,22,71,209,214,45,226,177,32,211,77,204,5,1,178,190,235,173,77,50,188,211,206,234,123,46,169,49,13,36,143,205,129,91,23,245,117,22,182,193,23,54,8,87,242,112,65,165,114,59,150,145,146,228,150,110,78,68,165,3,91,24,199,79,235,12,190,152,122,26,196,244,154,127,225,226,150,127,172,69,27,180,57,3,249,29,173,161,190,176,45,73,78,177,155,249,175,174,108,143,163,66,126,100,199,54,252,177,23,194,137,19,178,167,210,18,152,138,241,247,28,4,241,193,182,133,30,127,52,87,161,196,63,193,44,248,51,138,195,144,200,196,153,213,227,249,65,142,246,140,125,170,91,66,233,226,133,40,170,94,53,243,48,67,99,104,150,47,87,165,171,214,255,38,140,166,158,43,149,73,2,47,175,177,127,32,146,205,21,228,225,38,143,119,143,150,46,179,99,5,223,140,117,31,215,193,90,204,159,194,201,231,163,216,21,209,68,25,189,173,117,47,103,173,101,56,248,93,203,10,134,122,152,255,22,127,194,47,255,2,64,211,33,219,203,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69720bdd-86d5-4fc8-98a8-0dc605a74145"));
		}

		#endregion

	}

	#endregion

}

