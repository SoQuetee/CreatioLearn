﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FullPipelineStageGetRepositorySchema

	/// <exclude/>
	public class FullPipelineStageGetRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FullPipelineStageGetRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FullPipelineStageGetRepositorySchema(FullPipelineStageGetRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd7a294e-b8fa-4762-8890-98c15d37db0a");
			Name = "FullPipelineStageGetRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,111,26,49,16,61,111,164,252,135,17,189,44,82,180,220,33,137,148,64,105,56,164,161,37,85,15,85,85,57,120,22,44,121,237,173,199,38,66,81,254,123,199,235,37,93,218,77,122,232,9,60,51,126,31,227,183,70,84,72,181,88,35,220,163,115,130,108,233,139,169,53,165,218,4,39,188,178,230,244,228,233,244,36,11,164,204,230,104,196,225,228,149,122,49,187,126,181,53,23,107,111,157,66,226,9,158,121,231,112,195,28,48,213,130,104,12,243,160,245,82,213,168,149,193,149,23,27,252,128,254,51,214,150,20,95,218,55,55,70,163,17,156,83,168,42,225,246,151,237,121,233,236,78,73,36,168,208,111,173,36,176,37,56,244,193,25,160,173,125,4,101,160,12,198,160,6,138,160,84,28,112,70,29,160,111,51,44,69,208,254,90,25,201,194,115,191,175,209,150,249,226,72,194,249,212,86,149,53,141,182,153,240,226,114,120,6,31,121,131,112,1,131,21,83,45,204,188,33,106,6,104,48,252,206,192,117,120,208,106,13,235,104,241,31,14,97,12,125,182,179,167,198,250,203,182,230,10,181,228,117,45,157,218,9,143,169,89,167,3,27,23,210,26,189,103,175,46,62,192,15,153,124,117,229,77,173,14,149,233,19,62,152,180,84,104,100,98,59,166,230,104,48,110,136,143,24,5,52,214,90,254,100,243,109,131,249,23,66,199,24,6,215,49,91,16,142,142,103,201,253,141,162,56,187,66,239,163,1,250,187,54,140,132,217,24,30,4,97,254,39,70,223,60,196,12,103,207,111,123,187,77,233,137,123,181,158,209,80,30,54,219,30,193,238,56,205,156,52,88,161,230,10,176,183,244,47,111,25,178,157,112,64,169,121,209,200,43,58,51,147,102,228,74,202,238,198,231,74,123,116,121,186,212,142,28,194,219,212,38,29,233,191,165,236,148,243,65,104,216,89,37,161,31,178,21,217,34,119,4,74,69,181,22,123,94,204,81,16,222,78,74,82,54,26,221,223,205,238,198,112,27,200,195,67,76,91,197,75,145,240,184,85,26,227,115,194,108,122,219,249,204,178,76,149,144,247,60,107,209,212,86,235,45,86,34,194,23,239,127,178,29,202,7,159,248,71,149,123,110,251,192,95,208,65,119,246,138,232,193,130,102,169,131,114,144,52,62,191,240,38,235,197,141,32,14,136,84,49,31,47,120,109,239,202,200,188,15,122,88,44,168,145,148,167,90,177,20,142,203,113,175,156,127,28,182,47,213,62,85,151,184,5,254,186,69,135,255,1,221,31,214,84,61,46,114,237,23,109,43,237,18,198,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd7a294e-b8fa-4762-8890-98c15d37db0a"));
		}

		#endregion

	}

	#endregion

}
