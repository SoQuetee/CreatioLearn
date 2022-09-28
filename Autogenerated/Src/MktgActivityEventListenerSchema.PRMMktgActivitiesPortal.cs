﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MktgActivityEventListenerSchema

	/// <exclude/>
	public class MktgActivityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MktgActivityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MktgActivityEventListenerSchema(MktgActivityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f422b227-295e-4b88-a5ba-a89b4c239fc0");
			Name = "MktgActivityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0d7ed7ad-953f-4448-9eef-c702acc0afc1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,111,219,48,12,61,167,64,255,3,225,93,108,160,144,239,169,29,32,43,178,173,192,186,14,253,56,13,59,40,54,237,104,139,165,64,146,189,5,197,254,251,104,41,206,34,35,238,182,83,66,138,143,124,239,73,180,228,13,154,29,47,16,158,80,107,110,84,101,217,141,146,149,168,91,205,173,80,242,242,226,229,242,98,214,26,33,235,160,68,227,245,68,158,173,164,21,86,160,249,107,1,91,154,189,44,238,119,232,71,253,63,128,221,74,139,186,34,250,255,128,93,117,40,237,116,221,59,94,88,165,61,109,170,121,163,177,166,17,112,179,229,198,204,225,238,187,173,151,133,21,157,176,123,215,232,163,48,22,37,106,87,156,166,41,100,166,109,26,174,247,139,67,60,20,64,165,116,0,7,236,25,209,143,227,195,6,120,58,194,103,6,145,111,141,130,66,99,149,71,175,171,98,111,185,65,151,11,217,69,144,246,253,190,156,57,138,31,139,13,54,252,19,61,0,200,33,58,101,24,37,95,9,180,107,215,91,81,64,209,27,48,173,31,230,48,49,155,90,188,56,119,142,94,222,161,221,168,146,220,252,236,90,251,195,177,119,46,241,129,203,114,139,102,176,234,145,119,88,122,195,216,17,147,142,65,217,142,107,222,128,36,69,121,100,80,150,164,127,225,40,129,143,88,150,186,146,243,8,140,22,79,27,116,190,15,158,207,39,93,119,188,150,21,189,62,55,96,169,107,211,123,13,66,26,203,37,173,83,161,164,229,66,246,15,205,110,112,24,232,36,64,201,45,15,184,28,172,86,29,141,19,37,66,167,68,9,247,210,201,142,213,250,27,22,131,132,43,56,55,26,48,129,126,77,103,179,53,221,5,27,144,3,4,147,107,119,248,108,80,211,114,75,106,215,95,71,27,134,57,196,177,111,158,120,96,194,66,128,111,114,123,114,213,110,29,87,63,177,104,105,117,128,7,81,238,87,199,175,213,158,189,71,155,77,66,23,177,196,31,64,147,140,213,109,95,79,162,218,134,170,226,40,36,25,93,141,88,39,7,105,227,206,199,111,132,179,71,5,81,14,253,180,87,17,35,39,254,88,24,104,100,254,15,58,124,118,186,34,15,162,222,88,243,128,117,187,229,78,95,192,192,247,250,117,88,14,154,224,247,195,197,62,27,38,41,247,27,64,171,134,230,168,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f422b227-295e-4b88-a5ba-a89b4c239fc0"));
		}

		#endregion

	}

	#endregion

}
