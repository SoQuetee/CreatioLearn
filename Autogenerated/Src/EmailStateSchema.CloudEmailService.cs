namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStateSchema

	/// <exclude/>
	public class EmailStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStateSchema(EmailStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3683c63-c39e-be9c-9916-00ffa0f49f4f");
			Name = "EmailState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,203,10,194,48,16,69,215,45,244,31,6,220,74,235,107,37,86,16,237,7,136,254,192,88,167,26,72,210,146,135,40,226,191,155,166,86,20,181,46,239,228,112,238,132,145,40,72,87,152,19,108,73,41,212,101,97,226,101,41,11,118,176,10,13,43,101,20,94,163,48,10,131,158,162,131,139,144,73,43,166,144,9,100,124,99,208,144,127,76,146,4,102,218,10,129,234,50,127,100,143,128,174,25,29,183,76,242,2,85,118,199,89,14,228,132,111,190,192,21,6,31,74,63,88,81,129,150,155,198,26,63,177,87,107,176,182,100,105,15,41,12,250,126,183,239,166,133,202,143,236,132,28,168,110,254,161,122,66,41,12,187,100,203,82,84,156,140,107,245,255,248,46,107,33,39,27,117,201,178,115,197,84,183,170,69,82,24,119,174,133,50,39,254,103,171,150,73,97,226,242,173,185,53,201,125,115,238,58,186,217,29,125,87,127,41,38,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3683c63-c39e-be9c-9916-00ffa0f49f4f"));
		}

		#endregion

	}

	#endregion

}

