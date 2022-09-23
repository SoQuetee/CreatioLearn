namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCSegmentationStrategyBaseSchema

	/// <exclude/>
	public class DCSegmentationStrategyBaseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCSegmentationStrategyBaseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCSegmentationStrategyBaseSchema(DCSegmentationStrategyBaseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9");
			Name = "DCSegmentationStrategyBase";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,203,142,219,48,12,60,39,64,254,129,72,47,187,64,97,223,155,7,176,117,22,61,21,93,108,218,15,96,108,218,22,96,75,174,68,103,107,4,253,247,82,126,164,78,224,108,115,234,81,20,57,156,225,144,26,75,114,21,198,4,223,201,90,116,38,229,32,50,58,85,89,109,145,149,209,193,174,209,88,170,88,130,76,154,23,243,211,98,62,171,157,210,25,236,27,199,84,174,22,115,137,124,176,148,73,54,68,5,58,247,9,118,209,158,178,82,242,91,140,61,11,22,101,205,103,116,212,102,135,97,8,107,87,151,37,218,102,219,191,95,169,178,228,164,196,129,235,242,21,57,224,28,25,208,18,184,14,207,247,69,13,88,39,138,116,76,193,0,22,142,208,170,250,80,168,24,240,224,113,98,134,216,115,122,151,210,236,212,210,250,171,194,104,169,173,99,54,86,196,188,180,120,93,198,53,243,54,16,89,18,48,7,194,223,20,71,178,131,128,6,148,224,160,240,132,55,197,57,32,136,196,132,82,165,41,129,216,15,244,23,7,103,212,240,26,118,93,161,197,18,100,252,180,89,186,17,249,168,43,93,110,159,100,44,12,38,29,227,182,69,196,100,221,71,120,203,85,156,183,227,235,28,59,52,163,217,6,235,176,205,109,251,245,51,187,61,164,135,203,175,158,2,76,208,122,4,191,34,179,217,84,250,102,170,96,229,211,127,247,14,144,78,58,19,46,29,121,177,166,34,203,66,251,14,63,70,171,196,57,13,147,134,212,216,179,33,206,79,109,237,72,126,45,165,155,229,109,225,203,112,123,195,163,201,153,13,74,167,98,39,200,136,87,240,15,169,95,137,115,147,220,163,115,215,90,238,122,155,45,85,146,142,224,114,83,23,9,28,252,205,104,6,54,242,19,171,74,238,229,214,178,93,31,140,210,103,254,79,253,161,61,60,174,254,3,145,54,98,137,107,171,221,246,135,86,63,107,2,149,248,179,79,149,156,213,181,101,175,93,35,113,8,196,218,209,215,151,90,37,193,115,89,113,227,221,91,135,3,228,148,88,159,59,168,221,203,145,20,244,44,253,184,121,95,241,190,211,102,169,52,71,2,44,10,240,251,217,186,141,5,36,200,120,231,172,143,70,218,71,5,161,253,86,237,164,236,220,246,106,61,186,165,185,12,74,236,15,148,86,246,116,192,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9"));
		}

		#endregion

	}

	#endregion

}

