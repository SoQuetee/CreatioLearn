namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkEmailAudienceRepositorySchema

	/// <exclude/>
	public class IBulkEmailAudienceRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkEmailAudienceRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkEmailAudienceRepositorySchema(IBulkEmailAudienceRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a");
			Name = "IBulkEmailAudienceRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,147,203,78,195,64,12,69,215,173,212,127,176,194,6,164,42,217,67,137,4,109,85,117,129,120,20,62,96,154,56,141,69,50,19,230,33,20,33,254,29,103,210,180,233,67,37,187,241,216,103,174,175,29,41,74,52,149,72,16,222,81,107,97,84,102,195,169,146,25,109,156,22,150,148,28,13,127,70,195,129,51,36,55,176,170,141,197,242,110,119,238,151,104,12,231,210,146,37,52,251,4,31,169,167,170,40,48,105,96,112,15,7,153,225,113,2,151,114,241,149,198,77,147,189,148,22,117,198,226,110,97,249,232,138,207,121,41,168,120,112,41,161,76,240,13,43,101,200,42,93,251,154,40,138,96,98,92,89,10,93,199,219,243,12,77,162,105,141,6,50,39,61,95,20,252,28,100,74,131,216,98,64,101,96,115,132,53,243,1,155,7,194,142,22,245,112,149,91,23,148,0,117,138,254,17,52,248,241,162,118,157,60,161,205,85,106,110,225,197,115,218,203,99,201,62,176,64,107,46,136,131,111,178,57,164,174,98,138,176,8,137,146,41,53,157,153,112,135,140,142,153,147,74,104,81,130,228,89,223,7,235,78,247,50,13,226,15,73,95,14,129,82,228,65,100,132,250,140,29,147,200,151,159,167,161,249,10,226,21,54,227,3,38,233,250,140,228,174,155,203,164,93,79,239,117,133,65,220,185,218,235,213,242,197,101,134,170,188,21,199,138,218,232,105,169,70,235,180,52,113,111,65,89,189,198,132,42,126,155,231,112,106,182,21,140,221,219,197,204,14,210,80,79,246,189,213,209,245,114,189,112,148,66,111,0,227,237,31,178,74,114,182,234,213,171,101,71,199,13,107,112,178,96,179,190,67,112,224,215,25,208,115,219,117,215,253,205,221,118,35,81,166,237,82,250,243,111,251,195,245,130,192,223,104,200,241,63,236,51,94,224,27,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a06eeb92-03f3-e55d-a005-1861571a3c8a"));
		}

		#endregion

	}

	#endregion

}

