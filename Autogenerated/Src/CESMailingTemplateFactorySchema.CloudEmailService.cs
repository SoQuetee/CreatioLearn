﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingTemplateFactorySchema

	/// <exclude/>
	public class CESMailingTemplateFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingTemplateFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingTemplateFactorySchema(CESMailingTemplateFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b293e1c2-cba2-479c-8e5a-5e6ce5b1f39e");
			Name = "CESMailingTemplateFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,87,219,78,227,48,16,125,46,18,255,96,21,9,5,169,74,223,233,69,90,10,172,34,109,119,17,176,31,96,146,105,177,54,113,34,219,233,170,66,252,251,250,154,139,19,82,96,5,15,60,181,153,241,204,156,153,57,227,73,40,206,128,23,56,6,116,15,140,97,158,111,68,184,202,233,134,108,75,134,5,201,105,184,198,36,37,116,123,124,244,116,124,52,42,185,252,139,238,246,92,64,54,243,158,165,93,154,66,172,140,120,248,29,40,48,18,215,103,94,114,127,185,167,56,35,177,20,10,160,34,92,231,9,164,188,223,140,193,65,119,111,141,39,207,75,139,19,6,91,169,67,171,20,115,126,142,86,87,119,54,233,123,200,138,20,11,184,198,177,200,217,94,31,158,78,167,104,206,203,44,195,108,191,180,207,55,44,223,145,4,56,202,64,60,230,9,71,155,156,161,152,129,12,41,161,16,202,5,166,49,145,250,124,131,196,35,72,123,0,165,223,44,198,145,23,106,60,93,134,46,202,180,17,166,40,31,82,18,163,88,65,28,66,56,122,210,40,171,156,214,6,209,57,186,209,14,140,210,207,65,11,86,10,175,196,104,225,130,2,219,0,122,185,114,177,110,161,200,57,81,225,78,83,49,171,229,186,119,167,91,49,179,57,116,147,48,146,2,51,156,33,217,6,88,140,75,14,76,246,130,26,222,140,151,243,169,214,214,135,25,136,146,81,46,21,238,159,82,217,106,236,8,19,37,78,81,31,182,185,7,108,105,19,188,140,187,103,131,223,45,24,168,141,234,12,41,234,143,70,59,204,144,232,216,162,5,162,240,247,117,16,2,207,241,76,251,53,137,245,184,214,234,231,55,182,236,48,191,52,59,97,7,18,59,131,66,214,17,43,187,196,12,6,138,237,36,190,179,129,145,7,69,233,149,79,123,32,236,52,184,233,236,161,76,255,92,101,18,112,215,143,82,33,80,186,97,23,25,142,89,126,131,153,12,219,117,210,168,203,133,11,181,110,24,72,222,190,72,192,91,243,251,198,90,135,189,188,141,174,104,153,1,195,15,41,204,125,163,138,167,21,119,248,48,61,39,168,202,5,85,5,156,104,102,245,37,137,26,21,58,200,236,129,145,233,165,114,219,17,78,126,21,122,29,84,51,82,219,55,180,254,152,76,204,65,69,76,59,185,6,229,232,190,215,115,115,242,156,60,252,153,83,208,70,207,93,96,210,166,155,108,168,140,47,36,172,56,103,73,148,4,85,37,195,40,153,244,229,100,51,38,27,20,212,142,101,158,101,154,186,178,186,201,86,50,115,250,185,57,240,166,184,142,163,60,240,219,90,55,179,138,31,218,186,240,73,171,141,31,116,81,124,201,59,64,43,57,42,180,250,115,198,221,173,41,223,192,99,192,135,143,185,163,163,28,197,238,27,196,16,253,62,129,107,122,41,109,201,14,168,91,74,252,11,109,37,151,210,120,233,6,88,70,119,111,203,95,96,161,85,12,127,197,98,171,47,188,247,242,189,25,197,95,21,172,186,32,15,77,5,106,95,214,222,14,52,77,50,123,235,7,225,162,155,78,96,55,128,36,46,224,248,17,5,202,131,123,161,34,53,141,171,109,208,140,112,205,242,204,70,177,65,254,115,34,71,163,30,215,161,253,204,145,33,88,91,50,96,99,127,163,164,97,21,37,3,6,17,37,34,240,81,184,18,134,223,146,36,232,177,58,235,89,136,190,109,243,170,57,1,154,152,79,26,253,108,164,109,161,148,253,3,136,158,67,74,207,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b293e1c2-cba2-479c-8e5a-5e6ce5b1f39e"));
		}

		#endregion

	}

	#endregion

}

