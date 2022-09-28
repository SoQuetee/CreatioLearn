﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateModelSchema

	/// <exclude/>
	public class DCTemplateModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateModelSchema(DCTemplateModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a14cf0e-3682-4065-847c-86519c791585");
			Name = "DCTemplateModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,148,219,110,219,48,12,134,175,83,160,239,192,165,55,9,48,216,247,205,161,216,146,33,8,208,110,69,155,62,128,34,51,137,86,91,114,37,185,73,16,244,221,167,131,101,231,212,172,235,114,99,91,20,249,243,179,40,146,147,12,85,78,40,194,4,165,36,74,204,116,52,16,124,198,230,133,36,154,9,30,13,215,156,100,140,26,163,70,174,163,59,145,96,170,46,47,54,151,23,141,66,49,62,135,199,181,210,152,117,246,214,70,37,77,145,90,9,21,141,144,163,100,244,192,231,150,241,151,218,248,65,130,33,209,196,126,75,66,181,9,54,225,87,18,231,198,17,6,41,81,234,26,134,131,9,102,121,74,52,58,88,231,18,199,49,116,85,145,101,68,174,251,229,218,185,131,22,32,49,151,168,140,54,36,70,27,50,27,5,51,33,77,4,34,80,137,179,94,179,22,109,198,125,48,190,76,175,163,32,28,111,41,231,197,52,101,20,168,19,63,64,105,108,28,78,133,124,47,69,142,82,51,52,220,247,46,210,239,239,243,58,195,19,103,47,5,2,75,108,250,25,67,25,85,174,219,4,1,97,84,176,4,198,9,108,96,142,186,3,202,62,222,160,231,236,209,79,92,218,119,171,221,249,151,132,32,102,144,50,254,140,201,214,17,252,133,224,1,169,144,201,62,199,137,172,245,205,177,233,76,113,140,84,89,21,229,202,66,11,41,109,181,116,121,182,167,33,198,63,120,145,161,36,211,20,187,195,193,131,151,115,229,232,67,185,82,159,100,11,0,48,151,162,200,207,133,24,174,204,200,138,150,160,238,251,191,49,167,169,160,207,231,198,252,110,69,75,76,247,253,89,76,162,181,100,211,194,112,158,137,240,91,16,44,233,170,245,81,194,43,228,137,239,202,221,22,189,67,189,16,201,7,218,243,215,171,25,96,166,87,20,224,202,94,43,166,129,10,254,106,219,219,76,55,51,103,142,142,147,48,202,236,88,209,235,188,254,193,129,143,85,192,139,52,181,225,246,253,206,239,59,75,78,36,201,192,204,74,236,53,221,9,54,251,33,73,57,211,196,244,183,57,110,88,46,24,93,4,54,76,162,110,236,66,183,15,82,105,51,123,105,253,35,118,74,17,109,234,113,8,222,218,27,114,62,87,27,122,78,175,225,51,127,233,57,124,103,105,220,0,199,229,17,37,216,248,253,134,25,22,61,47,19,141,147,175,165,177,154,35,97,43,24,106,135,178,153,107,7,111,184,137,30,209,222,179,214,202,64,65,171,26,2,33,111,123,213,142,38,226,150,41,221,106,7,177,178,225,130,148,95,30,8,237,180,234,41,185,178,49,130,156,95,190,43,231,182,79,201,109,221,228,32,89,155,14,100,171,173,99,146,94,241,205,191,174,93,149,58,71,27,194,183,201,174,209,216,254,0,169,94,34,87,66,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a14cf0e-3682-4065-847c-86519c791585"));
		}

		#endregion

	}

	#endregion

}
