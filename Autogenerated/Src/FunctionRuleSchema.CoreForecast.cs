﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FunctionRuleSchema

	/// <exclude/>
	public class FunctionRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FunctionRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FunctionRuleSchema(FunctionRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("13327698-65c3-41bc-9c73-4929199e9a2f");
			Name = "FunctionRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,87,77,111,219,70,16,61,43,64,254,195,148,201,65,134,83,10,232,49,22,5,4,110,148,26,112,90,35,54,114,45,214,228,80,90,148,92,178,187,75,217,174,225,255,222,217,15,82,43,82,146,101,57,200,73,218,143,121,243,118,118,230,237,80,176,18,85,205,82,132,27,148,146,169,42,215,241,121,37,114,190,104,36,211,188,18,241,188,146,152,50,165,191,255,246,246,205,227,219,55,163,70,113,177,128,235,7,165,177,60,235,141,201,180,40,48,53,118,42,254,130,2,37,79,7,123,46,185,248,119,61,25,186,45,203,74,208,10,173,189,147,184,32,16,56,47,152,82,31,97,222,8,11,250,173,41,112,206,82,93,201,7,187,109,50,153,192,84,53,101,201,228,195,204,143,175,100,181,226,25,42,200,221,70,40,81,47,171,140,198,149,132,5,106,109,188,230,30,16,36,33,170,22,105,18,64,213,205,109,193,83,80,154,162,144,66,106,120,108,167,49,50,65,25,48,177,19,223,80,55,82,168,158,55,184,101,10,51,160,97,55,175,31,106,140,59,152,73,31,103,90,51,201,74,16,116,87,73,196,41,134,209,236,102,137,107,115,58,89,217,20,12,204,82,60,157,216,221,107,99,233,88,204,166,10,17,82,137,121,18,133,7,137,38,155,96,134,35,129,180,86,6,102,51,22,161,49,124,65,109,126,199,115,71,225,130,24,88,26,39,96,195,50,250,206,10,158,49,141,159,228,162,41,81,104,53,182,171,103,118,209,249,0,129,119,112,205,203,154,130,26,64,171,177,219,245,100,111,122,84,75,190,34,156,150,196,170,226,25,12,193,67,26,249,250,127,203,38,152,138,207,151,152,254,211,90,254,217,20,197,216,196,183,202,199,161,157,39,202,115,8,167,227,27,186,47,248,37,129,192,157,153,138,91,254,173,191,145,94,202,234,206,30,176,245,244,249,62,197,218,236,25,191,143,62,223,215,84,44,148,11,225,5,194,29,215,75,155,17,16,193,169,131,25,189,143,30,119,249,138,111,170,107,45,41,169,199,39,79,112,219,104,184,99,10,106,74,87,194,237,225,61,246,207,16,218,198,145,63,236,147,143,186,143,252,59,20,153,171,70,26,236,47,205,3,106,242,208,186,99,183,74,75,42,177,45,149,231,74,206,144,108,169,204,57,22,25,113,185,114,57,178,153,48,151,92,233,105,16,188,25,252,221,178,184,98,90,163,244,146,179,113,208,16,157,200,215,40,53,71,227,193,178,115,235,91,75,158,234,65,129,14,235,169,118,78,118,148,183,63,238,144,164,231,230,19,137,116,171,77,41,147,139,253,19,64,146,128,160,20,238,242,110,52,220,97,168,253,142,57,23,152,249,57,95,96,254,198,187,114,220,18,158,32,43,246,159,188,100,247,96,162,197,68,6,105,213,8,13,124,29,129,253,33,224,180,185,189,230,175,236,254,47,135,114,110,65,30,141,112,159,193,179,238,157,203,42,7,133,114,197,233,81,51,5,160,66,14,7,83,184,118,8,230,50,212,203,72,212,149,226,246,230,137,71,206,165,210,93,68,142,226,161,153,212,62,24,87,45,242,139,227,209,101,227,18,89,134,242,184,144,252,97,109,143,136,136,201,138,142,65,129,98,65,130,212,61,130,47,166,65,201,113,233,48,94,227,31,173,246,250,120,248,60,249,1,156,156,164,187,72,245,248,237,210,151,175,174,63,249,8,159,188,230,61,119,156,204,85,241,193,18,35,43,237,158,153,78,84,135,114,179,93,28,246,209,166,46,145,208,26,211,5,29,34,140,23,130,82,151,222,235,255,66,226,237,43,176,151,117,168,253,227,86,225,118,41,69,210,10,103,108,199,182,219,128,100,230,90,35,251,108,39,195,103,155,186,214,166,20,94,13,119,11,192,81,216,158,93,31,124,91,85,175,241,231,92,100,23,34,195,251,87,240,31,84,235,81,244,187,142,230,172,31,118,95,131,201,110,121,56,221,35,166,167,187,180,126,135,159,141,186,74,182,104,193,175,59,121,132,93,100,47,153,135,29,206,176,193,217,210,153,62,223,231,40,107,116,120,187,227,186,156,45,174,160,223,97,5,159,27,92,44,233,3,75,103,85,10,147,94,205,84,43,250,172,34,38,135,85,186,175,169,21,147,173,148,80,136,77,211,58,176,238,246,142,204,114,216,109,183,141,135,75,164,157,121,244,193,111,163,214,189,49,251,76,215,226,155,144,15,71,1,251,220,233,227,70,227,232,85,176,174,164,126,26,219,147,150,173,235,181,54,62,143,234,160,13,243,109,249,168,151,181,52,245,63,39,191,8,195,201,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13327698-65c3-41bc-9c73-4929199e9a2f"));
		}

		#endregion

	}

	#endregion

}

