﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailResponseMappingSchema

	/// <exclude/>
	public class BulkEmailResponseMappingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailResponseMappingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailResponseMappingSchema(BulkEmailResponseMappingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("44828261-c259-31f0-fb6b-1cdd083ded1f");
			Name = "BulkEmailResponseMapping";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,219,110,226,48,16,125,78,165,254,131,197,190,4,9,229,3,150,165,18,165,23,33,149,189,148,118,247,113,53,77,6,176,234,56,169,47,180,81,197,191,239,216,14,151,4,202,242,208,167,196,227,153,51,199,103,206,72,200,81,151,144,34,123,64,165,64,23,51,147,140,10,57,227,115,171,192,240,66,158,159,189,159,159,69,86,115,57,103,211,74,27,204,251,173,115,114,199,229,203,54,184,139,163,240,163,120,114,45,13,55,28,245,135,9,83,19,202,233,254,139,194,57,81,97,35,1,90,127,101,151,86,60,95,231,192,197,61,81,47,164,198,9,148,37,33,248,220,210,62,9,158,50,109,136,125,202,82,87,113,164,32,122,247,69,155,14,55,28,69,70,45,126,42,190,4,131,225,178,12,135,53,166,66,200,10,41,42,58,43,199,251,239,83,27,126,84,8,129,169,83,111,4,233,2,199,36,210,119,210,153,13,88,103,143,74,43,183,211,175,9,161,204,2,167,38,193,9,154,69,241,63,134,94,219,138,221,162,217,107,119,89,141,138,12,227,71,141,138,198,44,67,103,102,27,199,30,27,123,46,126,2,44,117,191,61,198,165,97,41,149,118,153,243,67,20,45,65,49,212,47,244,38,137,175,117,199,41,101,230,240,203,162,170,226,38,100,178,155,48,1,9,115,84,189,3,106,116,214,240,209,120,46,169,251,21,215,165,128,234,55,8,139,154,122,25,101,177,23,18,218,210,158,60,134,221,122,170,243,239,243,161,85,223,127,232,85,9,169,155,131,170,252,83,8,198,230,50,25,235,161,120,133,74,79,209,129,214,92,250,27,45,156,54,33,179,230,227,96,134,89,22,98,113,199,201,222,233,38,238,114,91,164,246,152,214,133,52,186,160,216,246,166,165,104,55,160,40,52,86,201,3,64,201,13,87,218,252,80,87,56,3,43,76,252,198,6,23,236,205,1,63,84,37,214,180,188,174,223,104,180,23,113,147,127,151,13,6,97,220,190,205,234,84,83,250,229,171,61,217,88,196,91,203,51,103,200,245,108,198,217,105,78,60,100,187,180,158,92,203,98,195,178,164,134,176,153,119,242,135,155,197,93,145,130,112,71,218,212,184,187,175,60,193,28,89,147,54,155,122,23,182,194,68,124,198,226,45,22,45,131,21,98,227,97,159,158,220,99,94,44,49,62,217,159,53,114,244,89,20,87,135,140,178,118,248,142,15,142,76,58,68,155,65,138,253,3,198,24,255,11,61,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44828261-c259-31f0-fb6b-1cdd083ded1f"));
		}

		#endregion

	}

	#endregion

}
