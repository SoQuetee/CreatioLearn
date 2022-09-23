namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LinkedInAdAccountListResponseSchema

	/// <exclude/>
	public class LinkedInAdAccountListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LinkedInAdAccountListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LinkedInAdAccountListResponseSchema(LinkedInAdAccountListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("26f7958d-2eef-c66c-ca40-74d11543a381");
			Name = "LinkedInAdAccountListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5eec482-a90e-42cc-86d3-ef2673139bae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,93,107,131,48,20,134,175,21,252,15,7,122,175,247,109,41,148,94,140,130,140,178,238,15,100,201,169,132,197,68,114,226,160,72,255,251,226,87,106,173,108,12,118,35,248,230,228,125,30,19,53,43,145,42,198,17,222,209,90,70,230,226,210,131,209,23,89,212,150,57,105,116,122,54,92,50,149,35,19,47,168,147,184,73,226,168,38,169,11,56,95,201,97,233,167,149,66,222,142,82,234,39,208,74,190,73,98,63,181,178,88,248,20,14,138,17,173,33,151,250,19,197,81,239,197,158,115,83,107,151,75,114,111,30,238,55,98,183,33,203,50,216,82,93,150,204,94,119,195,251,24,103,147,188,170,63,148,228,192,219,222,159,107,97,13,15,250,62,119,39,107,190,164,64,123,71,71,77,135,159,11,135,198,126,117,110,55,234,61,251,61,10,78,106,162,145,20,80,94,166,66,235,36,122,222,169,219,53,12,60,209,2,110,129,55,2,201,217,246,98,2,241,40,160,129,2,221,6,168,125,220,254,179,251,213,255,56,139,237,43,212,162,255,186,62,24,242,121,252,219,9,252,253,184,219,139,223,6,191,221,93,149,150,60,103,62,125,58,13,111,223,95,18,60,9,27,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26f7958d-2eef-c66c-ca40-74d11543a381"));
		}

		#endregion

	}

	#endregion

}

