namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingStateValidationBuilderSchema

	/// <exclude/>
	public class IMailingStateValidationBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingStateValidationBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingStateValidationBuilderSchema(IMailingStateValidationBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba");
			Name = "IMailingStateValidationBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,77,107,195,48,12,64,207,13,228,63,136,238,178,93,226,251,154,229,176,49,74,15,133,178,142,221,221,68,73,12,254,40,146,220,81,202,254,251,156,164,29,93,97,48,240,193,146,172,167,103,121,237,144,247,186,70,120,71,34,205,161,149,226,37,248,214,116,145,180,152,224,243,236,148,103,179,200,198,119,176,61,178,160,75,117,107,177,30,138,92,44,209,35,153,122,145,103,233,149,82,10,74,142,206,105,58,86,231,120,67,225,96,26,100,112,40,125,104,64,2,116,40,64,209,166,92,27,8,88,180,32,28,180,53,141,150,64,197,133,163,174,64,251,184,179,166,6,227,5,169,29,100,87,107,109,108,82,218,14,205,31,83,111,242,121,142,198,54,72,169,227,52,10,205,238,8,187,148,135,245,56,156,31,97,51,146,166,226,173,238,152,88,162,48,72,143,87,134,110,154,245,219,52,81,139,31,136,186,165,148,132,18,201,115,85,50,34,212,132,237,211,124,245,234,163,67,210,59,139,229,31,254,111,105,102,53,87,21,124,26,233,39,131,162,84,23,214,0,255,47,100,248,199,112,225,251,135,197,121,21,232,155,105,27,99,252,149,103,233,124,3,4,158,131,14,255,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba"));
		}

		#endregion

	}

	#endregion

}

