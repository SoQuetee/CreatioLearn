namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailLimitValidatorSchema

	/// <exclude/>
	public class IEmailLimitValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailLimitValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailLimitValidatorSchema(IEmailLimitValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45824530-29b2-4569-b8ff-91a6519d7e62");
			Name = "IEmailLimitValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,77,75,195,64,16,61,91,232,127,24,210,139,130,36,119,77,115,41,34,5,5,105,213,251,154,76,210,129,236,110,156,221,173,148,210,255,238,108,155,6,219,170,144,75,102,103,222,188,143,49,74,163,235,84,137,240,138,204,202,217,218,167,51,107,106,106,2,43,79,214,140,71,219,241,232,42,56,50,13,44,55,206,163,190,31,143,164,50,97,108,228,25,230,198,35,215,2,112,7,243,7,173,168,125,34,77,254,93,181,84,41,111,89,58,229,203,178,12,114,23,180,86,188,41,250,255,23,182,107,170,208,129,70,191,178,149,3,111,97,125,24,67,192,136,4,95,228,87,224,208,84,113,121,27,113,93,122,68,203,126,192,117,225,163,165,18,232,72,229,47,38,219,61,243,11,54,251,66,223,39,124,162,212,182,167,144,14,253,217,249,64,222,41,86,26,140,24,56,77,196,68,167,26,156,87,73,241,102,232,51,32,136,52,227,169,38,100,176,53,248,21,66,223,147,230,217,126,242,119,32,198,146,58,146,81,55,179,193,248,164,88,12,5,40,99,229,196,166,218,242,185,63,23,232,140,62,176,113,69,47,48,102,198,232,66,235,83,201,206,121,101,196,47,97,152,59,68,40,25,235,105,114,146,255,18,121,77,37,46,228,74,172,113,152,100,133,172,56,98,198,37,255,117,15,174,62,31,180,95,63,6,170,96,48,235,54,70,6,103,146,111,228,190,174,118,135,187,153,136,182,195,157,197,228,118,223,218,144,47,248,173,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45824530-29b2-4569-b8ff-91a6519d7e62"));
		}

		#endregion

	}

	#endregion

}

