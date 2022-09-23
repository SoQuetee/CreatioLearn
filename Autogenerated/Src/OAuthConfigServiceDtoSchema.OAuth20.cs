namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthConfigServiceDtoSchema

	/// <exclude/>
	public class OAuthConfigServiceDtoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthConfigServiceDtoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthConfigServiceDtoSchema(OAuthConfigServiceDtoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2501d98-fcfc-4786-9ed5-b96381b1cbae");
			Name = "OAuthConfigServiceDto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,77,79,219,64,16,61,7,137,255,176,10,151,86,170,34,196,17,84,161,40,72,21,135,2,138,155,83,213,195,102,61,132,149,156,181,153,153,69,106,35,254,123,199,107,194,135,89,19,111,9,148,75,34,239,238,123,99,191,121,51,59,78,47,129,42,109,64,253,0,68,77,229,37,143,38,165,187,180,11,143,154,109,233,70,231,99,207,87,7,251,187,59,171,221,157,129,39,235,22,42,251,77,12,203,163,214,243,104,234,29,219,37,140,50,64,171,11,251,39,224,229,148,156,219,67,88,200,131,154,20,154,232,80,141,243,124,82,88,112,60,133,107,15,196,225,204,207,19,205,90,98,51,106,195,191,100,161,242,243,194,26,101,106,76,4,50,88,5,216,61,247,5,150,21,32,91,144,0,23,1,218,236,7,222,239,176,156,3,126,58,147,207,85,95,213,208,201,255,240,139,58,165,154,205,34,228,178,200,232,225,115,29,119,29,152,24,235,175,11,152,149,90,0,31,41,170,127,110,187,121,133,73,216,12,207,176,24,198,184,166,15,251,109,202,193,160,139,84,87,149,80,4,53,107,222,158,175,61,126,130,234,31,141,66,50,103,4,120,154,111,140,245,205,219,252,46,253,13,34,38,212,30,184,188,201,81,120,110,86,91,139,221,6,161,170,116,4,105,14,105,48,234,80,61,177,178,248,242,198,26,120,160,124,141,131,76,8,37,18,197,180,159,220,109,246,181,77,67,150,129,65,224,23,8,155,3,91,146,120,86,229,154,33,181,12,163,168,90,199,151,85,236,182,219,189,142,61,109,157,42,109,168,244,255,88,214,61,139,58,189,130,123,213,239,179,98,61,222,88,173,49,78,75,99,195,246,166,37,228,188,44,139,99,201,90,179,183,201,150,201,166,204,140,248,136,254,205,154,45,236,71,48,104,119,4,4,42,61,26,56,75,184,148,166,143,48,91,81,254,4,10,72,111,7,81,212,102,181,223,163,25,36,43,16,6,157,12,152,133,57,193,118,113,216,71,208,160,215,109,147,20,165,251,2,138,118,34,185,111,1,19,70,150,108,13,216,74,62,101,30,88,87,73,218,20,209,70,189,233,28,65,117,167,138,182,255,208,195,182,116,217,63,78,95,130,24,49,216,59,76,85,111,59,8,221,254,5,45,218,88,158,244,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2501d98-fcfc-4786-9ed5-b96381b1cbae"));
		}

		#endregion

	}

	#endregion

}

