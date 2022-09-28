﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleSSPEventListenerSchema

	/// <exclude/>
	public class SysModuleSSPEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleSSPEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleSSPEventListenerSchema(SysModuleSSPEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8");
			Name = "SysModuleSSPEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,193,110,219,48,12,61,167,64,255,129,245,46,54,208,217,247,54,9,144,21,217,16,160,93,139,165,221,101,216,65,181,233,68,131,45,121,146,156,205,104,251,239,163,37,219,177,211,164,93,177,157,226,72,124,143,143,143,164,4,203,81,23,44,70,184,69,165,152,150,169,9,47,164,72,249,170,84,204,112,41,194,37,198,245,239,241,209,195,241,209,168,212,92,172,6,161,10,195,185,48,220,112,212,231,175,5,132,51,93,137,248,186,64,71,253,118,64,184,16,6,85,74,114,255,2,59,223,160,48,135,227,62,178,216,72,229,100,83,204,59,133,43,74,1,23,25,211,250,12,150,149,190,146,73,153,225,114,121,99,137,46,185,54,40,80,217,224,40,138,96,172,203,60,103,170,154,54,255,45,16,10,37,55,60,65,189,37,0,172,5,85,128,86,14,172,153,72,50,146,19,182,52,81,143,231,155,21,95,13,18,250,203,120,141,57,251,76,141,130,9,120,29,175,23,124,39,68,81,222,103,60,134,216,38,63,40,26,206,224,3,211,184,135,157,40,30,108,73,157,1,87,104,214,50,33,11,110,148,52,212,123,76,220,253,110,205,246,224,11,97,136,72,105,208,110,76,128,213,159,89,250,94,163,218,112,26,171,66,42,195,50,224,41,140,11,166,88,174,48,5,65,181,76,60,221,85,18,77,193,84,5,57,245,179,100,153,166,44,136,16,83,224,196,107,134,239,150,110,235,40,170,43,236,180,68,187,98,92,130,103,236,211,30,159,115,160,166,226,66,27,38,98,12,199,145,133,237,103,169,209,47,201,182,77,5,166,86,101,110,187,187,151,181,104,141,132,141,228,73,231,89,83,219,76,47,117,225,59,97,208,145,159,130,59,153,165,20,105,59,54,83,43,13,24,64,189,134,163,209,134,41,40,201,99,218,85,209,56,63,217,162,195,187,193,213,185,133,80,11,252,147,109,200,39,52,11,125,33,179,50,23,95,89,86,226,165,100,9,38,190,103,189,14,224,241,209,130,70,163,1,162,190,76,122,160,49,23,102,218,97,78,38,224,211,65,208,235,90,72,45,107,53,143,20,154,82,53,106,158,186,50,88,189,227,243,223,24,151,180,143,84,133,93,36,183,157,85,157,115,188,232,205,237,172,31,60,245,5,254,2,170,83,27,85,214,241,179,166,17,190,55,244,198,59,221,49,43,8,206,187,252,178,125,94,172,195,19,168,57,119,51,94,247,99,252,94,151,176,33,26,20,17,186,15,180,208,241,179,173,28,50,78,253,129,0,199,247,212,236,36,138,196,173,229,161,29,181,235,255,194,130,246,102,255,192,11,16,94,139,133,32,115,104,62,105,162,247,111,87,243,202,200,13,61,161,244,186,185,57,222,226,124,121,255,131,124,165,197,23,9,170,215,70,247,158,116,244,146,250,45,170,181,114,239,126,52,11,18,236,4,63,253,107,233,119,69,194,182,21,236,151,30,188,213,151,33,233,219,108,105,177,255,193,149,157,233,113,167,195,67,58,251,3,252,87,26,74,2,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8"));
		}

		#endregion

	}

	#endregion

}
