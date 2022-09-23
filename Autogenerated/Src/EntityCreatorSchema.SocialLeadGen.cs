﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityCreatorSchema

	/// <exclude/>
	public class EntityCreatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityCreatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityCreatorSchema(EntityCreatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("420dd940-d3d3-435c-84c7-f48acd934670");
			Name = "EntityCreator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,219,78,227,48,16,125,14,18,255,96,178,43,148,138,202,31,64,149,69,108,105,17,18,237,94,10,203,11,18,50,201,164,181,54,177,139,237,116,85,161,254,251,250,146,132,184,109,160,43,237,83,106,207,245,156,153,241,148,145,2,228,146,36,128,238,64,8,34,121,166,240,144,179,140,206,75,65,20,229,12,207,120,66,73,126,11,36,189,6,118,124,244,122,124,20,148,146,178,57,154,173,165,130,2,223,82,246,50,104,46,219,94,138,130,179,253,18,1,93,247,120,196,20,85,20,164,86,208,42,159,4,204,117,18,104,152,19,41,207,145,21,174,135,2,136,226,194,42,44,203,231,156,38,72,42,157,108,130,18,163,182,173,21,188,90,205,198,215,152,66,158,106,103,223,5,93,17,5,78,184,116,135,218,145,84,194,228,246,196,184,154,144,229,18,82,103,52,33,137,224,18,197,40,212,130,167,194,74,158,50,43,10,7,239,184,73,120,94,22,236,110,189,132,43,162,136,177,79,245,247,64,147,183,160,133,253,21,14,42,60,192,82,7,201,199,55,1,181,224,31,1,92,113,154,162,25,168,95,36,47,225,142,15,109,180,200,49,55,75,22,80,16,36,237,167,95,209,137,192,126,250,117,130,238,232,236,166,186,137,26,193,202,120,236,33,211,39,65,176,34,194,211,212,40,156,91,236,206,18,143,41,75,191,174,141,135,104,219,101,111,208,248,80,154,135,212,230,170,61,24,14,13,49,247,138,230,182,87,176,149,92,74,115,25,217,248,125,47,170,147,27,105,229,210,9,177,198,239,20,172,220,139,223,111,133,116,70,155,110,30,199,52,207,91,142,228,65,60,154,137,154,114,69,179,245,3,60,47,56,255,141,254,184,111,205,93,117,196,70,209,181,223,5,126,88,128,128,40,67,241,23,148,97,3,8,197,241,78,123,157,158,162,19,87,12,124,35,167,101,158,127,19,163,98,169,214,81,134,71,219,20,247,240,152,139,17,73,22,145,109,99,227,216,69,15,118,154,163,198,81,3,176,6,59,30,235,251,22,115,193,230,32,6,167,254,172,253,31,18,77,243,56,122,52,206,173,8,186,149,222,231,216,17,177,151,104,55,148,78,65,243,157,225,170,57,227,142,55,163,209,60,188,50,142,59,154,161,168,19,192,73,140,82,200,72,153,43,83,244,46,53,124,201,214,81,175,102,196,82,178,149,227,204,141,110,92,205,48,182,73,185,248,31,181,225,161,112,144,101,169,163,101,123,46,84,208,52,163,159,95,171,43,131,96,127,234,103,49,138,246,83,187,87,191,135,46,80,216,15,209,185,135,184,78,35,8,206,208,231,240,49,124,245,109,171,85,248,67,79,184,217,140,6,214,230,209,248,216,213,180,221,160,133,97,69,98,61,2,174,158,255,146,104,83,182,206,234,118,13,112,176,251,190,31,58,194,251,83,169,16,160,6,203,198,77,119,107,182,63,222,73,118,95,87,15,129,183,187,159,57,207,145,93,218,16,117,142,117,31,221,75,16,250,15,10,131,196,212,0,149,222,177,143,120,169,252,55,162,253,16,56,248,186,205,125,43,220,126,105,38,132,145,57,8,124,13,234,134,233,212,88,2,213,122,170,7,161,173,221,90,83,46,92,107,193,89,40,78,57,242,3,238,108,161,43,200,188,253,81,41,236,236,149,237,250,213,143,221,155,250,246,35,250,190,133,0,85,10,134,234,68,200,202,174,79,170,255,156,192,79,120,41,169,128,244,28,101,36,151,254,14,220,170,178,187,245,47,245,221,95,55,249,240,138,91,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("420dd940-d3d3-435c-84c7-f48acd934670"));
		}

		#endregion

	}

	#endregion

}

