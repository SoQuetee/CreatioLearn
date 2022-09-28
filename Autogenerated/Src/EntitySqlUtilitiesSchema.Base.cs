﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntitySqlUtilitiesSchema

	/// <exclude/>
	public class EntitySqlUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntitySqlUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntitySqlUtilitiesSchema(EntitySqlUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("878ce482-6c07-46ea-8968-31a79f9709e1");
			Name = "EntitySqlUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,93,107,219,48,20,125,118,161,255,65,143,10,4,245,117,208,101,37,105,62,8,99,99,144,100,47,101,20,213,190,73,4,182,236,73,114,55,51,242,223,39,235,203,150,221,64,199,30,28,71,242,189,231,156,123,239,145,56,45,64,86,52,5,180,7,33,168,44,143,138,60,150,252,200,78,181,160,138,149,28,221,222,252,185,189,73,106,201,248,9,237,26,169,160,184,31,172,117,66,158,67,218,70,75,178,1,14,130,165,163,152,61,252,86,221,102,159,76,192,181,125,178,226,138,41,6,82,7,232,144,170,126,201,89,138,210,156,74,137,204,167,102,247,51,55,132,84,149,66,43,77,90,169,201,65,130,208,53,112,43,9,61,215,209,186,37,75,218,199,193,141,129,240,0,32,206,159,32,67,146,12,96,209,12,189,193,115,249,79,178,41,90,50,243,135,138,230,227,166,102,217,20,181,191,159,16,184,206,252,147,154,228,168,155,74,211,51,194,175,84,88,136,6,49,62,2,75,124,223,201,60,203,176,141,35,159,161,153,186,28,242,157,230,53,76,44,230,37,174,83,176,87,170,224,154,236,103,232,38,26,154,114,37,214,139,112,162,78,160,188,60,1,170,22,188,3,67,15,15,8,119,171,25,226,240,235,10,42,158,188,45,219,42,145,74,180,46,220,128,10,131,106,125,139,219,84,87,251,46,61,67,65,183,14,207,109,110,51,223,186,174,177,54,80,139,25,140,134,172,122,159,191,80,78,79,32,244,169,81,91,46,21,229,41,44,154,195,214,55,221,147,57,205,189,169,205,34,22,242,168,231,170,192,34,227,1,161,75,102,71,228,71,185,6,149,158,215,162,44,150,11,28,10,8,195,143,76,146,150,121,93,240,96,146,192,103,182,59,195,24,116,27,75,150,84,81,99,144,125,83,1,98,18,45,88,59,133,104,187,75,76,238,238,156,170,29,168,69,163,64,154,32,15,102,137,204,214,87,125,85,5,7,110,222,17,236,71,173,231,140,32,151,208,113,118,140,189,20,135,210,167,24,127,237,97,218,183,123,181,189,98,92,247,93,133,209,184,161,108,205,46,246,121,54,136,44,106,150,103,223,168,208,50,21,8,57,183,133,232,92,37,106,184,143,108,238,50,180,28,111,71,111,225,168,42,23,109,45,76,86,69,165,154,119,57,61,128,58,160,157,249,98,244,129,112,113,126,101,79,86,20,225,197,92,185,90,86,195,171,37,2,36,243,170,2,158,225,209,129,235,223,51,97,32,250,6,138,78,111,92,178,135,220,151,86,159,19,54,44,252,69,187,230,233,7,242,254,9,101,187,134,72,43,64,87,58,238,183,163,91,241,180,204,218,30,31,246,235,15,193,136,216,101,118,172,250,185,252,5,228,101,62,219,95,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("878ce482-6c07-46ea-8968-31a79f9709e1"));
		}

		#endregion

	}

	#endregion

}
