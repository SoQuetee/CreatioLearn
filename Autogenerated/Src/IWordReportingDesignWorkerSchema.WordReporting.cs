﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWordReportingDesignWorkerSchema

	/// <exclude/>
	public class IWordReportingDesignWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWordReportingDesignWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWordReportingDesignWorkerSchema(IWordReportingDesignWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("532b7c5e-889b-48cc-a3bd-5a26de533631");
			Name = "IWordReportingDesignWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,193,110,226,48,16,61,83,169,255,96,181,151,86,170,194,189,101,185,64,183,226,128,90,65,187,123,168,122,48,201,132,122,215,177,35,219,97,151,173,246,223,119,108,199,1,18,66,129,86,218,30,128,56,243,102,222,123,227,177,43,104,6,58,167,49,144,71,80,138,106,153,154,104,32,69,202,230,133,162,134,73,17,77,32,151,202,48,49,143,190,75,149,216,143,159,160,78,79,222,78,79,58,133,198,101,50,93,106,3,217,77,237,25,179,112,14,177,77,161,163,59,16,160,88,220,136,25,221,55,150,38,133,48,44,131,104,138,0,202,217,31,71,2,163,48,238,92,193,28,31,200,128,83,173,175,137,165,227,201,141,41,19,35,145,74,23,245,60,164,134,162,4,163,104,108,94,112,33,47,102,156,197,36,182,168,45,160,161,65,92,231,205,97,171,18,15,74,230,128,170,1,235,60,56,188,127,239,146,143,33,155,129,178,169,67,238,187,130,37,196,167,29,37,228,141,204,193,220,16,109,63,254,238,196,105,163,172,116,143,28,208,220,106,61,0,238,202,162,111,99,153,20,28,142,169,92,129,119,20,63,7,145,120,91,220,179,95,173,45,214,90,99,107,222,207,126,96,251,167,96,236,222,209,206,229,119,187,211,130,251,140,238,220,226,182,50,203,105,252,10,25,125,58,198,170,195,219,83,2,199,52,86,82,175,198,225,147,60,94,237,228,195,60,110,193,253,167,9,216,218,113,98,103,179,249,230,163,105,159,95,200,35,157,113,104,190,252,188,230,140,132,1,149,226,121,122,77,70,43,167,135,160,217,92,132,163,19,195,187,221,46,233,233,34,203,168,90,246,203,103,116,124,193,18,32,202,65,52,73,28,136,164,133,112,204,40,143,2,176,187,134,44,5,179,80,183,189,108,189,195,99,48,175,50,169,181,183,78,204,45,220,129,33,148,243,192,44,170,2,187,245,200,158,2,83,40,161,251,19,255,93,137,137,43,135,163,94,55,4,89,212,232,86,20,25,40,219,151,222,214,195,185,111,203,251,213,181,62,93,92,222,188,67,216,87,222,197,53,167,138,102,68,224,13,248,229,76,149,91,247,172,239,75,17,150,32,81,23,241,158,184,53,65,164,252,179,136,173,115,182,210,18,22,47,220,228,132,242,59,85,61,229,92,210,16,75,240,178,204,57,53,176,175,194,16,127,214,127,44,127,217,3,10,104,214,212,121,136,49,11,105,239,32,186,128,144,245,98,234,178,86,252,174,72,67,97,167,211,170,241,27,222,249,137,229,150,200,248,55,73,25,223,91,159,141,181,52,191,226,119,157,100,73,41,36,175,168,58,102,30,184,211,249,9,100,114,1,199,58,191,151,133,190,196,38,179,61,61,27,202,95,226,35,59,227,168,189,111,26,155,104,125,170,203,77,112,85,222,129,151,21,199,118,129,173,242,6,50,199,91,168,46,206,181,141,164,74,102,68,203,66,197,182,59,49,142,28,193,33,195,147,19,103,203,253,231,88,174,238,107,133,79,53,169,12,153,134,212,173,190,172,163,215,234,174,82,12,55,200,180,246,31,85,46,55,205,217,228,82,142,209,150,18,193,188,61,174,41,92,251,7,57,185,182,104,241,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("532b7c5e-889b-48cc-a3bd-5a26de533631"));
		}

		#endregion

	}

	#endregion

}

