namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileUploadInfoSchema

	/// <exclude/>
	public class IFileUploadInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileUploadInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileUploadInfoSchema(IFileUploadInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28ad8049-6da4-4639-b9de-e5c9a1fd33d3");
			Name = "IFileUploadInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,149,95,79,219,48,20,197,159,131,196,119,184,18,175,83,251,206,16,210,86,70,21,9,109,213,218,241,238,198,55,137,193,177,35,251,134,41,66,251,238,187,182,7,148,63,41,53,210,222,106,247,231,115,174,143,237,27,35,58,244,189,168,16,54,232,156,240,182,166,217,194,154,90,53,131,19,164,172,153,93,42,141,191,122,109,133,60,62,186,63,62,42,6,175,76,3,235,209,19,118,159,95,140,121,169,214,88,133,117,126,182,68,131,78,85,175,152,242,7,79,241,228,137,195,134,65,40,13,161,171,185,132,83,40,159,204,74,83,219,136,245,195,86,171,10,212,3,245,26,42,238,35,248,40,184,114,182,71,71,10,253,41,172,226,234,244,255,124,62,135,51,63,116,157,112,227,249,195,68,16,3,52,164,104,4,95,181,216,9,48,156,201,236,113,193,124,119,133,39,23,118,242,45,242,235,136,127,103,26,66,48,69,209,32,133,221,22,127,246,248,93,8,18,47,252,42,171,135,206,28,96,187,136,96,166,97,220,224,251,218,1,251,136,178,146,97,51,181,66,55,161,191,28,148,140,104,41,115,181,105,236,15,53,216,48,154,101,176,177,36,52,212,193,70,163,105,168,157,80,151,88,169,142,201,200,135,170,174,34,157,225,180,18,142,119,112,248,41,39,254,67,103,253,220,234,78,232,97,202,43,134,182,235,116,29,224,220,3,170,44,191,74,67,19,30,107,114,40,58,190,181,17,202,208,254,34,165,10,61,132,99,239,133,227,8,248,233,251,9,147,11,21,219,13,15,207,82,126,159,192,110,111,184,7,157,239,200,172,130,138,207,121,165,193,178,83,6,61,168,26,20,129,242,80,181,131,185,69,9,67,108,61,19,229,108,173,213,80,250,69,98,83,151,202,240,253,58,18,130,19,166,121,231,142,4,238,103,192,114,79,236,142,147,12,93,253,109,117,110,178,112,157,136,12,225,37,146,79,151,13,168,21,4,242,41,188,223,45,82,139,238,95,130,252,147,95,156,243,148,178,220,31,225,101,0,99,142,255,171,20,45,14,171,228,74,236,45,228,4,141,76,95,158,56,78,179,207,39,121,238,47,12,227,19,130,105,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28ad8049-6da4-4639-b9de-e5c9a1fd33d3"));
		}

		#endregion

	}

	#endregion

}

