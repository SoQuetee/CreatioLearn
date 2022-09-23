namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPortalMessageFileReaderSchema

	/// <exclude/>
	public class IPortalMessageFileReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPortalMessageFileReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPortalMessageFileReaderSchema(IPortalMessageFileReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("036d92f0-de76-43ba-9d4d-3a87133b254f");
			Name = "IPortalMessageFileReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,193,78,227,48,16,134,207,32,241,14,35,184,128,180,74,239,148,229,176,237,110,21,105,75,43,90,113,89,237,193,77,38,89,107,29,199,26,219,72,5,241,238,107,59,165,13,137,131,178,151,68,246,252,255,55,99,123,108,201,42,212,138,101,8,91,36,98,186,46,76,50,171,101,193,75,75,204,240,90,94,156,191,94,156,159,89,205,101,9,155,189,54,88,77,59,99,167,23,2,51,47,214,201,2,37,18,207,122,154,71,43,13,175,48,217,184,40,19,252,37,176,79,170,83,242,7,203,189,232,153,103,184,172,115,20,201,156,25,230,42,50,196,50,227,12,206,114,69,88,58,55,192,76,48,173,111,97,93,147,97,98,137,90,179,18,127,112,129,243,237,42,8,127,181,189,191,221,132,178,59,193,51,200,188,111,192,118,230,151,123,76,177,166,90,33,25,142,62,77,48,7,112,67,94,98,181,67,186,126,112,91,8,95,225,50,205,47,111,124,146,247,44,11,203,115,72,115,120,133,18,205,20,180,255,188,13,219,103,132,204,96,254,109,31,161,28,99,255,9,91,201,143,48,109,200,239,246,49,58,22,231,255,81,82,16,140,132,108,248,75,7,194,165,1,63,59,186,140,218,160,142,215,225,35,99,49,219,189,234,20,242,179,174,255,90,229,250,216,86,18,124,120,44,234,9,73,187,62,233,47,235,16,136,113,174,80,230,77,123,185,81,51,215,158,138,52,120,187,188,32,152,76,38,112,167,109,85,49,218,223,31,198,65,11,230,15,51,64,168,8,53,186,50,68,112,66,22,172,201,187,115,210,178,126,126,71,62,102,110,238,70,108,31,114,174,149,96,251,39,38,108,188,81,230,45,65,119,83,226,72,69,220,215,152,86,238,118,14,115,215,93,213,56,248,115,31,24,46,90,28,241,233,33,165,210,32,21,238,5,189,133,180,247,164,60,34,203,145,6,207,236,232,133,162,38,159,212,248,53,169,64,129,170,193,64,225,56,144,187,53,68,207,239,212,115,7,210,80,17,16,14,47,253,46,109,133,196,118,2,239,98,15,224,61,44,208,244,2,250,250,176,221,170,29,73,243,47,224,217,46,176,82,225,249,119,157,215,30,222,76,7,54,239,237,31,227,116,23,251,119,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("036d92f0-de76-43ba-9d4d-3a87133b254f"));
		}

		#endregion

	}

	#endregion

}

