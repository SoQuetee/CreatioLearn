﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseServiceAppEventListenerSchema

	/// <exclude/>
	public class CaseServiceAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseServiceAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseServiceAppEventListenerSchema(CaseServiceAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("275ace0f-397e-48ac-bfc3-190283dc2f98");
			Name = "CaseServiceAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,75,111,19,49,16,62,7,137,255,48,44,151,4,69,27,132,16,135,182,137,20,66,129,34,90,10,229,113,64,72,56,187,147,196,176,107,175,252,72,27,161,254,119,198,246,190,155,70,92,184,36,241,120,158,223,55,158,137,96,57,234,130,37,8,159,81,41,166,229,202,196,11,41,86,124,109,21,51,92,138,135,15,254,60,124,48,176,154,139,53,44,100,158,75,113,220,58,43,236,158,186,182,205,221,213,78,27,204,175,208,24,58,105,152,238,81,142,73,167,82,232,57,189,74,54,152,218,12,85,35,255,134,203,184,78,135,164,143,21,174,201,9,44,50,166,53,28,193,130,105,188,66,181,229,9,206,139,226,116,139,194,188,231,148,131,64,229,245,39,147,9,156,104,155,231,76,237,102,229,25,230,144,120,115,179,97,6,52,26,91,252,212,244,237,189,192,10,153,177,10,53,80,20,86,20,160,13,83,38,174,92,77,90,190,10,187,204,120,82,250,58,144,8,165,217,23,189,36,109,242,240,199,231,216,20,37,5,69,19,198,21,118,169,248,150,25,12,10,253,42,188,224,21,227,217,14,240,6,19,235,112,133,2,21,151,105,92,235,183,83,29,20,193,29,36,46,4,112,97,8,65,73,37,159,86,230,151,222,154,24,123,246,28,158,192,139,167,199,119,173,180,81,158,42,111,248,78,46,223,40,105,139,11,106,44,178,138,92,253,225,198,139,163,227,178,52,20,105,168,174,91,234,107,142,89,122,167,206,66,73,131,137,193,20,190,144,35,130,67,208,201,169,119,143,14,183,193,96,176,70,227,179,172,211,212,165,224,246,112,236,115,52,27,89,6,47,227,29,128,249,13,18,31,150,226,59,20,170,124,86,74,230,174,59,136,127,223,212,128,142,93,167,97,240,198,220,195,129,151,20,76,177,28,4,161,54,141,74,245,104,54,191,215,211,201,196,27,52,246,138,218,85,9,61,251,210,205,136,20,171,155,131,64,82,53,93,201,176,106,205,69,136,88,69,30,149,32,111,153,114,133,182,92,76,235,228,90,105,127,143,230,109,165,232,7,48,13,29,81,160,138,175,96,216,115,55,5,97,179,108,4,33,222,192,108,148,188,6,129,215,48,87,107,155,83,102,23,116,253,65,157,230,133,217,157,222,36,88,248,180,123,241,70,193,253,173,255,12,72,116,211,142,195,104,234,22,223,238,150,189,228,87,19,73,3,131,156,11,107,144,158,220,47,185,60,196,176,217,21,216,102,249,51,61,149,104,70,31,224,110,136,168,90,97,127,87,132,119,124,38,206,125,60,29,205,202,167,201,69,153,130,238,116,69,67,245,150,43,99,89,6,91,201,211,58,115,138,123,226,50,152,13,221,163,239,249,30,193,245,6,21,237,4,151,221,17,156,209,87,24,8,82,149,244,19,106,14,178,51,177,146,144,88,165,136,14,223,121,211,94,99,197,139,230,50,80,81,78,11,63,29,203,33,225,10,151,171,161,139,54,138,231,90,99,190,204,118,31,41,101,190,226,152,58,165,166,73,30,17,191,245,62,136,95,73,212,62,57,154,159,195,218,229,120,207,44,26,213,141,212,113,80,253,58,47,73,108,96,185,235,98,220,175,237,155,84,191,253,242,140,253,117,112,63,104,193,17,228,125,116,199,190,177,199,96,148,197,118,127,30,108,56,63,109,10,215,99,250,222,81,190,159,112,183,199,168,12,61,172,16,88,74,153,1,215,115,162,211,23,73,12,116,247,115,76,211,224,43,203,44,14,187,5,143,105,156,59,131,79,168,101,182,197,212,205,118,29,117,10,113,20,181,92,215,160,183,219,174,89,9,45,160,123,11,103,15,46,255,48,182,253,226,61,128,226,91,38,82,255,104,91,115,181,222,227,255,97,50,151,255,4,228,150,254,91,241,20,3,33,31,132,235,64,23,245,222,25,91,17,69,64,197,45,245,234,58,96,211,155,224,211,61,51,188,107,208,234,132,3,235,48,72,187,194,219,191,107,229,63,40,39,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("275ace0f-397e-48ac-bfc3-190283dc2f98"));
		}

		#endregion

	}

	#endregion

}
