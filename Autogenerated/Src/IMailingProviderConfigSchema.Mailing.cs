namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigSchema

	/// <exclude/>
	public class IMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigSchema(IMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468");
			Name = "IMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,81,193,74,195,64,16,61,39,208,127,24,210,139,94,18,196,67,161,173,5,81,132,28,196,66,11,30,196,195,38,153,141,11,217,221,48,187,41,132,224,191,187,110,146,18,11,209,131,183,157,55,111,222,123,51,171,152,68,83,179,28,225,136,68,204,104,110,227,7,173,184,40,27,98,86,104,181,8,187,69,24,52,70,168,18,14,173,177,40,55,139,208,33,75,194,210,181,33,85,22,137,59,129,53,164,207,76,84,142,183,39,125,18,5,82,175,227,217,73,146,192,214,52,82,50,106,119,67,61,208,12,228,158,7,154,131,253,64,144,189,8,212,131,74,60,142,39,147,249,186,201,42,145,131,24,205,103,189,131,206,251,159,227,186,126,141,100,5,154,53,236,189,72,223,191,12,232,129,84,25,203,148,83,31,162,109,13,34,228,132,252,46,26,253,142,40,235,138,89,124,98,185,213,212,70,201,46,62,203,77,3,7,51,3,112,89,127,95,59,8,74,180,27,255,48,195,227,243,127,49,239,155,66,160,163,60,50,203,14,186,161,252,239,192,111,47,153,209,21,90,188,138,94,69,85,65,134,64,40,245,9,11,96,220,157,29,86,241,205,42,190,141,174,223,167,235,205,26,193,124,167,131,95,119,94,162,42,250,223,243,117,143,254,4,29,246,5,93,196,209,57,201,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468"));
		}

		#endregion

	}

	#endregion

}

