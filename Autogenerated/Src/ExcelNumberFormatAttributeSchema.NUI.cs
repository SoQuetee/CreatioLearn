﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelNumberFormatAttributeSchema

	/// <exclude/>
	public class ExcelNumberFormatAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelNumberFormatAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelNumberFormatAttributeSchema(ExcelNumberFormatAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5641821c-39ed-4a72-847f-ca3f93100c38");
			Name = "ExcelNumberFormatAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,111,218,64,16,61,131,196,127,24,41,23,35,81,147,180,183,80,42,161,0,106,46,41,81,160,169,20,229,176,216,99,179,210,122,215,217,143,22,138,248,239,93,239,98,203,128,3,57,244,96,172,221,121,51,239,189,153,49,156,100,168,114,18,33,204,81,74,162,68,162,195,59,193,19,154,26,73,52,21,60,156,172,115,33,245,92,76,214,17,178,78,123,219,105,119,218,45,163,40,79,225,105,163,52,102,131,234,60,22,145,201,144,235,169,144,25,209,225,143,28,249,175,140,93,138,135,79,185,68,18,171,21,162,30,184,234,87,18,83,75,13,119,140,40,117,11,142,249,193,100,75,148,62,115,164,181,164,75,163,209,161,251,253,62,124,85,38,203,136,220,124,219,159,43,4,36,66,66,140,145,40,220,88,9,88,212,2,251,176,34,98,107,1,114,147,65,66,145,197,97,89,172,95,171,246,82,149,90,40,146,98,80,29,231,68,166,168,85,56,45,82,187,175,22,154,155,37,163,17,68,133,234,51,162,225,22,106,6,90,190,161,149,231,153,20,57,74,77,209,26,159,185,130,62,126,236,210,93,56,18,224,142,165,244,67,157,143,83,35,165,188,197,61,215,95,62,67,93,26,108,193,90,25,192,238,34,85,194,72,218,3,181,18,134,197,96,20,238,185,61,53,141,207,18,47,133,96,48,202,115,182,249,79,220,181,89,254,38,204,32,188,25,97,219,107,183,41,161,235,203,82,30,11,244,204,129,63,46,34,18,204,100,28,254,208,88,175,206,247,121,44,236,27,127,58,97,207,5,252,227,36,222,205,74,72,250,87,112,77,24,16,70,83,94,124,57,231,41,191,87,25,163,50,193,241,171,166,200,145,156,43,228,177,95,193,195,125,180,127,6,74,75,19,105,33,143,54,114,79,250,254,162,7,174,205,228,120,226,61,40,178,91,173,253,34,242,250,50,12,225,122,81,198,99,215,64,223,106,27,184,185,30,247,124,128,90,241,171,6,67,67,248,116,83,38,59,234,183,218,132,135,144,16,166,176,11,91,7,120,56,100,173,139,24,56,192,233,162,14,79,173,120,232,243,94,97,109,226,225,84,138,204,159,3,103,160,235,161,143,7,138,106,250,124,152,38,16,76,172,150,240,94,141,237,45,199,56,208,155,28,69,18,188,59,218,110,175,169,23,221,210,103,171,105,242,67,56,83,175,161,154,23,183,43,126,155,183,197,223,30,94,238,254,1,189,207,222,174,91,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5641821c-39ed-4a72-847f-ca3f93100c38"));
		}

		#endregion

	}

	#endregion

}

