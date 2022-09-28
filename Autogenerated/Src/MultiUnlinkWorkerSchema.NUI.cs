﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiUnlinkWorkerSchema

	/// <exclude/>
	public class MultiUnlinkWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiUnlinkWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiUnlinkWorkerSchema(MultiUnlinkWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3647bd5f-9aef-4409-ae8e-dcb6df07e1df");
			Name = "MultiUnlinkWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,219,110,211,64,16,125,118,37,254,97,48,82,101,139,200,226,57,33,145,74,137,74,68,11,85,47,240,128,120,216,172,39,205,82,103,215,221,75,73,84,245,223,25,239,218,174,29,151,194,75,218,29,207,229,156,57,103,87,178,13,154,146,113,132,43,212,154,25,181,178,217,177,146,43,113,227,52,179,66,201,87,7,15,175,14,34,103,132,188,129,203,157,177,184,153,236,157,41,191,40,144,87,201,38,59,65,137,90,240,65,206,169,144,119,79,193,238,44,141,127,139,103,115,105,133,21,104,40,129,82,222,104,188,161,25,112,92,48,99,198,112,230,10,43,174,101,33,228,237,119,165,111,81,251,164,210,45,11,193,129,87,57,195,20,24,195,7,102,240,2,185,210,185,249,90,98,224,216,212,71,15,190,71,59,233,92,43,74,169,16,140,171,255,45,145,196,60,164,148,205,17,238,133,182,142,21,240,81,248,21,48,189,123,111,172,38,54,35,248,196,204,250,18,109,125,158,205,32,96,161,253,82,132,9,105,13,76,103,32,241,247,127,21,87,58,68,81,248,141,98,218,235,81,190,17,242,90,10,27,143,124,147,189,10,120,128,152,70,89,198,237,34,143,225,209,23,250,223,199,73,205,19,101,30,168,246,121,7,128,142,91,165,43,230,126,165,53,237,176,222,193,98,147,107,131,154,202,100,240,1,184,222,113,4,139,103,8,170,229,47,250,60,131,146,105,50,161,69,109,82,15,113,12,75,210,40,217,111,209,73,171,87,209,234,55,223,34,119,4,22,166,126,15,65,222,0,143,160,189,208,104,226,183,241,242,50,206,208,174,85,222,119,64,20,61,239,129,165,82,5,28,51,25,102,39,222,191,59,64,255,103,4,129,56,20,74,221,186,146,46,141,219,200,47,132,164,161,163,209,58,45,135,30,161,187,224,164,77,182,149,87,182,217,103,220,193,116,90,247,204,46,249,26,55,172,234,2,135,135,244,245,27,43,28,102,94,117,33,77,50,24,149,86,181,239,186,180,159,72,168,123,186,125,34,71,168,97,159,160,61,215,72,219,194,60,68,250,124,26,216,139,185,116,27,18,98,89,96,235,60,238,39,146,187,33,121,230,115,122,222,42,240,35,14,224,76,252,115,50,232,118,226,68,62,3,237,213,188,192,21,106,148,28,23,249,160,173,207,235,53,189,24,212,52,253,87,244,174,48,190,134,164,22,131,183,187,1,33,27,220,13,181,168,151,116,234,151,233,83,167,221,186,183,16,211,253,10,237,35,177,130,228,245,147,3,26,233,247,59,164,237,136,136,147,88,66,58,172,27,132,107,26,85,156,224,190,82,19,90,177,73,144,171,93,137,121,88,153,151,58,112,79,6,237,59,104,134,251,203,142,228,46,97,149,157,88,54,191,35,223,154,196,79,74,59,168,26,127,161,237,76,27,204,161,119,199,21,69,218,131,254,216,53,115,104,243,47,191,109,57,150,254,217,32,134,157,75,93,71,147,6,85,255,94,215,198,104,143,100,138,126,66,58,120,31,38,93,104,253,242,108,56,247,133,199,33,68,251,65,138,253,1,168,3,172,181,77,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3647bd5f-9aef-4409-ae8e-dcb6df07e1df"));
		}

		#endregion

	}

	#endregion

}
