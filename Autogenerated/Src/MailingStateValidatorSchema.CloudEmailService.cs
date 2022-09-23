namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateValidatorSchema

	/// <exclude/>
	public class MailingStateValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateValidatorSchema(MailingStateValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c9024bb-355f-4ec3-8193-b5436b64da82");
			Name = "MailingStateValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,203,106,195,48,16,60,39,144,127,88,114,74,47,246,7,212,241,161,165,148,64,123,73,66,175,69,177,55,173,64,150,221,93,41,37,148,252,123,87,242,163,78,250,160,7,129,189,171,157,97,102,86,86,85,200,141,42,16,182,72,164,184,222,187,228,182,182,123,253,226,73,57,93,219,217,244,99,54,157,120,214,246,5,54,71,118,88,73,223,24,44,66,147,147,123,180,72,186,184,190,188,243,160,237,155,20,165,156,166,41,100,236,171,74,209,49,239,254,215,216,16,50,90,199,224,94,17,14,202,232,82,185,154,96,47,167,82,218,4,36,118,202,33,131,42,138,154,202,80,112,117,188,77,222,32,39,61,114,58,130,110,252,206,232,2,10,163,152,225,177,133,217,4,148,167,158,64,46,5,57,147,134,244,65,234,64,168,202,218,154,35,172,238,172,175,144,212,206,96,182,250,97,84,196,174,133,55,135,231,72,223,74,251,166,45,22,110,5,84,160,181,21,1,150,17,222,181,123,5,110,176,208,123,141,37,236,188,54,37,82,50,204,167,151,0,89,163,72,85,96,37,154,229,60,208,221,180,35,243,124,43,242,207,236,137,102,8,100,68,204,210,56,24,113,58,43,126,52,97,241,139,192,142,6,70,148,87,16,237,154,180,170,97,57,238,73,246,46,120,194,139,171,16,255,228,244,135,39,29,9,182,121,255,150,236,151,73,67,198,255,177,40,194,205,243,168,38,110,208,97,144,116,230,73,28,36,116,158,44,231,89,218,127,141,236,58,104,114,94,153,179,109,24,45,128,188,20,217,121,89,130,94,206,98,108,100,43,171,119,172,69,239,214,37,217,96,120,49,139,152,214,50,143,242,146,1,164,157,27,76,12,231,244,9,29,239,175,165,152,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c9024bb-355f-4ec3-8193-b5436b64da82"));
		}

		#endregion

	}

	#endregion

}

