namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISendingEmailProgressRepositorySchema

	/// <exclude/>
	public class ISendingEmailProgressRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISendingEmailProgressRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISendingEmailProgressRepositorySchema(ISendingEmailProgressRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae");
			Name = "ISendingEmailProgressRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,193,106,195,48,12,134,207,13,228,29,12,189,108,48,154,251,58,118,41,99,228,48,8,105,95,192,179,213,84,16,91,65,178,11,161,236,221,167,36,45,108,48,58,240,197,150,254,79,159,112,180,1,100,176,14,204,1,152,173,208,49,109,118,20,143,216,101,182,9,41,150,197,165,44,86,89,48,118,102,63,74,130,176,45,11,125,169,170,202,188,72,14,193,242,248,122,189,183,48,48,8,196,36,38,157,192,236,33,122,141,189,5,139,125,195,212,105,77,180,133,4,19,241,104,28,197,196,214,165,205,141,86,253,192,13,249,179,71,103,48,38,224,227,164,87,223,167,105,228,50,123,173,214,12,157,122,155,15,72,39,242,242,108,154,25,181,20,207,132,222,212,209,49,4,213,108,24,6,203,224,91,112,56,224,228,253,240,158,181,1,166,25,181,127,154,198,155,225,218,116,160,201,96,71,57,166,199,237,223,52,114,234,244,15,78,150,53,238,112,52,14,120,6,95,71,76,104,251,86,255,135,162,192,111,216,45,186,86,220,178,240,124,255,42,11,61,223,254,215,147,53,213,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae"));
		}

		#endregion

	}

	#endregion

}

