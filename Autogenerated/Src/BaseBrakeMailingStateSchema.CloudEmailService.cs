﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseBrakeMailingStateSchema

	/// <exclude/>
	public class BaseBrakeMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseBrakeMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseBrakeMailingStateSchema(BaseBrakeMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5db3ffbb-42cb-49e9-93bf-aaabc11728ef");
			Name = "BaseBrakeMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,201,78,35,49,16,61,55,18,255,96,101,46,110,41,178,114,153,11,17,35,37,33,160,72,128,24,146,12,103,211,174,116,44,58,118,143,237,14,155,248,247,41,187,151,164,179,48,136,67,22,187,92,239,85,189,90,20,95,129,205,121,2,100,6,198,112,171,23,142,141,180,90,200,180,48,220,73,173,78,79,222,79,79,162,194,74,149,146,233,171,117,176,234,55,231,109,23,3,236,98,136,38,52,254,48,144,162,39,25,101,220,218,51,50,228,22,134,134,63,193,13,151,25,186,77,29,119,16,30,230,197,99,38,19,194,31,173,51,60,113,36,241,14,135,223,147,51,210,118,143,222,3,196,134,76,43,235,184,114,72,120,103,228,186,166,136,242,242,64,18,111,39,82,57,196,119,201,114,42,223,128,156,147,159,189,94,191,194,1,37,74,168,54,238,157,209,57,24,39,33,0,107,7,137,3,81,67,87,199,77,6,87,133,20,228,82,42,158,221,67,34,115,9,202,221,163,190,200,13,228,157,164,224,250,228,227,168,51,254,4,149,125,130,181,215,72,23,202,141,116,86,172,212,45,150,234,203,32,227,53,82,99,188,169,1,107,71,60,247,165,188,78,222,166,193,58,210,226,155,72,55,248,225,41,124,134,116,76,200,27,112,75,45,14,169,88,22,104,173,81,186,7,35,29,92,235,148,6,33,31,139,236,105,188,194,178,79,68,55,148,206,212,162,6,89,98,226,91,51,138,228,130,208,182,133,252,34,189,218,26,13,107,148,144,9,130,167,96,24,254,76,212,66,211,22,197,5,198,49,147,43,96,115,151,220,234,231,110,233,31,93,129,107,18,254,195,179,2,232,127,213,141,191,232,123,72,207,184,235,155,217,193,139,99,115,11,6,255,43,148,11,25,216,168,48,6,157,253,173,31,82,135,85,194,176,43,166,29,109,250,225,250,195,127,239,149,56,72,61,5,55,40,4,58,36,77,179,209,70,170,141,244,181,140,107,110,72,145,11,84,72,148,18,159,147,94,201,33,116,173,244,239,2,204,107,245,10,237,10,158,201,60,28,232,225,132,186,164,211,48,206,184,193,46,234,196,85,54,12,195,163,27,107,29,225,68,116,188,58,126,28,216,29,55,56,17,14,12,61,60,112,113,204,30,150,96,128,118,208,43,102,19,69,43,236,200,7,54,133,12,131,56,18,88,204,102,58,167,205,162,136,89,73,73,59,22,233,75,184,75,163,87,244,104,248,152,192,192,250,231,77,12,193,115,184,233,54,31,145,29,255,45,120,70,247,242,105,196,103,19,17,111,67,42,113,88,147,173,55,71,65,171,245,25,246,164,101,123,40,247,192,197,235,76,79,113,122,61,105,213,63,209,78,201,203,35,27,191,64,82,96,89,235,87,101,225,155,176,231,223,234,128,118,237,63,219,130,117,203,151,188,229,253,248,37,247,3,229,199,100,32,4,245,204,7,173,159,2,55,99,27,69,123,250,109,43,17,239,246,214,215,42,89,169,181,163,211,158,154,205,18,220,246,238,182,166,175,30,111,242,188,148,25,144,86,112,97,249,245,183,6,127,103,35,151,183,237,75,188,251,7,247,174,149,178,10,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5db3ffbb-42cb-49e9-93bf-aaabc11728ef"));
		}

		#endregion

	}

	#endregion

}
