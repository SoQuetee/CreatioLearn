namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailQueueJobDispatcherSchema

	/// <exclude/>
	public class BulkEmailQueueJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailQueueJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailQueueJobDispatcherSchema(BulkEmailQueueJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36fbfa11-e34f-c606-1a25-604da3e18cd6");
			Name = "BulkEmailQueueJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,111,26,49,16,61,111,164,252,135,145,122,73,36,180,168,87,66,145,72,66,34,170,82,165,37,85,15,85,15,222,245,0,86,188,246,118,108,131,86,40,255,189,227,253,64,144,38,180,244,182,59,243,222,248,205,243,140,141,40,208,149,34,71,120,68,34,225,236,194,167,55,214,44,212,50,144,240,202,154,243,179,237,249,89,18,156,50,75,152,87,206,99,193,121,173,49,143,73,151,222,163,65,82,249,213,14,179,95,134,48,157,231,43,148,65,35,189,134,248,142,25,163,138,194,26,206,114,254,29,225,146,171,194,141,22,206,13,224,58,232,167,73,33,148,254,18,48,224,71,155,221,42,150,234,185,34,213,240,126,191,15,67,23,138,66,80,53,106,255,231,72,107,116,144,49,21,48,114,225,87,36,195,70,249,21,112,171,78,44,57,189,176,180,15,17,65,42,52,236,65,73,54,103,12,171,76,187,250,253,189,3,202,144,105,149,67,30,229,29,83,7,172,93,56,60,130,232,193,116,92,150,147,53,26,255,73,177,169,38,182,148,108,235,182,118,54,60,144,45,145,188,66,246,130,191,61,123,142,178,129,212,210,148,225,74,202,75,155,247,163,186,164,236,48,96,215,236,177,146,8,211,137,9,5,146,200,52,14,15,229,204,26,47,30,171,18,71,48,214,218,110,80,238,197,28,124,168,107,38,6,55,240,38,243,199,79,216,214,168,228,77,72,58,150,114,220,250,123,93,221,41,237,185,251,211,56,86,75,164,169,60,141,21,109,253,43,227,43,22,108,21,119,223,241,254,149,113,106,67,47,105,81,93,205,121,190,106,239,28,141,108,174,253,112,6,102,232,87,86,254,255,0,172,173,146,208,45,33,143,224,133,243,20,151,112,99,233,169,222,251,207,252,0,244,160,141,6,135,20,3,151,237,181,242,140,238,22,120,183,202,51,101,130,71,93,113,181,225,145,17,31,93,52,166,112,240,158,108,40,155,131,94,156,219,29,216,3,158,116,101,229,212,52,213,185,225,247,173,169,202,53,207,206,55,134,14,192,83,136,114,59,81,131,93,111,221,29,20,202,45,20,225,212,112,75,161,126,164,6,176,223,198,236,143,124,58,231,253,246,15,150,87,187,186,140,207,84,242,252,234,157,52,209,195,32,199,126,3,74,212,88,173,66,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36fbfa11-e34f-c606-1a25-604da3e18cd6"));
		}

		#endregion

	}

	#endregion

}

