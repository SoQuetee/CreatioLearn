﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SingleIndexingSectionListBuilderSchema

	/// <exclude/>
	public class SingleIndexingSectionListBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SingleIndexingSectionListBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SingleIndexingSectionListBuilderSchema(SingleIndexingSectionListBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0d0400c-be97-4c80-b4ab-924948561d23");
			Name = "SingleIndexingSectionListBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("22387ba7-4aa5-4ad3-8c5e-98af882ce17b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,93,111,218,48,20,125,6,137,255,96,117,147,154,74,89,208,94,75,91,137,49,64,213,86,137,1,219,30,39,147,92,192,146,99,7,127,176,70,136,255,222,235,56,41,9,217,90,181,82,30,226,235,115,238,61,231,218,190,130,166,160,51,26,3,89,130,82,84,203,181,137,70,82,172,217,198,42,106,152,20,209,148,203,21,229,11,160,42,222,246,186,135,94,183,99,53,19,27,178,200,181,129,116,112,182,70,50,231,16,59,166,142,166,32,64,177,248,132,169,215,80,240,191,120,52,22,134,25,6,26,1,8,249,160,96,131,233,200,136,83,173,175,201,2,9,28,238,69,2,143,248,183,240,181,190,51,109,190,88,198,19,80,200,192,47,179,43,206,98,18,59,206,171,20,114,77,94,204,231,76,187,164,39,41,232,206,40,27,27,169,80,209,172,168,85,97,250,253,62,185,97,98,139,206,77,34,227,254,157,11,150,114,94,19,18,252,212,160,48,185,240,59,196,54,150,87,168,115,69,53,4,231,225,195,241,89,32,136,196,107,60,151,252,0,102,43,19,167,86,73,131,68,72,94,22,92,161,136,220,227,225,176,4,158,91,84,156,78,78,166,96,154,145,224,27,228,191,40,183,48,163,76,221,96,127,112,39,36,126,111,17,111,33,165,63,44,168,252,142,64,17,42,22,168,221,85,235,236,169,34,172,153,255,182,240,26,181,203,212,233,131,130,221,100,70,247,218,247,25,83,224,33,129,199,40,48,86,137,179,34,197,214,241,173,141,104,89,114,189,88,128,187,246,19,169,10,181,197,211,9,234,192,210,181,95,212,109,131,222,161,80,204,240,21,214,99,189,11,26,184,134,118,68,190,79,240,94,178,132,12,179,140,231,51,197,82,170,114,124,164,54,21,115,203,33,104,153,241,123,36,243,72,84,228,3,97,161,164,109,29,69,133,196,31,118,139,51,228,140,234,186,215,53,227,6,159,219,173,99,69,35,5,212,192,164,8,253,102,102,59,163,10,135,17,46,116,224,131,35,153,102,84,49,45,197,50,207,112,42,236,44,229,225,191,139,132,164,168,209,153,90,150,68,227,52,51,121,72,78,255,101,27,93,81,159,89,71,195,36,9,188,154,171,247,245,180,180,236,78,126,199,151,240,104,218,157,116,46,43,247,37,92,123,108,237,114,87,108,135,29,212,161,76,76,170,110,125,188,184,60,28,14,39,63,199,227,241,50,36,237,216,69,227,186,148,181,162,57,100,28,7,124,80,37,12,201,31,150,184,161,243,64,99,37,107,246,223,214,0,38,204,233,214,206,229,223,145,180,194,4,149,223,82,195,167,207,85,250,214,116,58,250,65,221,136,245,186,24,125,2,12,117,231,206,147,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0d0400c-be97-4c80-b4ab-924948561d23"));
		}

		#endregion

	}

	#endregion

}

