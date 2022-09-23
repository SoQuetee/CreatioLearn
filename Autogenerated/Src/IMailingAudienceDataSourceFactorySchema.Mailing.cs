namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingAudienceDataSourceFactorySchema

	/// <exclude/>
	public class IMailingAudienceDataSourceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingAudienceDataSourceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingAudienceDataSourceFactorySchema(IMailingAudienceDataSourceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719");
			Name = "IMailingAudienceDataSourceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("137c1838-0170-451f-b0dc-9c1d36ce6de8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,111,219,48,12,61,175,64,255,3,225,30,214,2,133,141,161,135,2,109,106,96,200,62,224,67,187,2,105,177,195,176,131,98,209,142,0,91,242,36,170,109,86,244,191,143,150,29,47,105,150,45,29,182,245,178,155,40,145,143,124,143,20,181,168,209,53,34,71,184,66,107,133,51,5,197,99,163,11,85,122,43,72,25,189,187,115,191,187,243,194,59,165,75,152,204,29,97,125,58,216,99,99,145,45,182,247,44,150,236,12,153,38,180,5,195,157,64,118,46,84,197,94,175,189,84,168,115,124,35,72,76,140,183,57,190,19,57,25,59,15,129,73,146,192,200,249,186,22,118,158,246,246,165,53,55,74,162,131,26,105,102,36,144,129,220,162,32,4,165,29,9,198,114,96,10,14,67,108,31,138,179,104,115,174,40,73,227,69,154,100,41,207,167,15,83,103,42,36,220,143,62,170,170,130,41,130,197,218,220,160,4,81,48,7,56,142,95,29,199,71,209,193,103,118,110,252,180,82,57,103,239,201,253,154,27,112,212,125,32,56,72,115,30,200,184,19,184,12,104,221,227,99,250,171,252,191,39,92,83,66,227,237,160,198,83,197,88,87,163,187,105,132,21,53,104,158,136,179,200,59,180,60,7,26,243,118,8,162,244,154,237,151,14,242,225,42,30,37,193,255,199,225,60,84,78,148,152,201,40,189,154,33,120,173,190,120,110,159,68,77,170,80,44,47,151,76,252,80,119,165,254,28,108,42,40,159,77,212,87,236,192,28,159,218,248,134,19,180,138,176,32,114,29,192,34,121,171,93,122,241,187,66,141,146,5,68,139,185,217,23,198,161,35,89,159,99,255,122,69,57,88,21,242,16,222,123,37,97,144,231,176,237,49,12,4,15,78,251,153,65,45,187,177,9,246,67,247,199,86,47,183,248,114,19,78,195,46,40,159,239,239,65,143,251,246,142,184,124,23,154,190,85,112,95,40,99,192,173,162,89,8,116,29,159,76,130,243,77,99,44,253,131,175,189,89,67,216,106,199,253,95,3,91,172,1,178,170,44,217,236,215,193,162,209,127,97,45,44,3,12,227,212,1,60,74,190,84,230,243,111,151,97,10,255,200,154,233,159,7,254,79,88,59,15,223,0,17,168,94,105,49,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719"));
		}

		#endregion

	}

	#endregion

}

