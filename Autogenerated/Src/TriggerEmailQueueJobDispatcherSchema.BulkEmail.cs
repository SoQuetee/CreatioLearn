namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TriggerEmailQueueJobDispatcherSchema

	/// <exclude/>
	public class TriggerEmailQueueJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TriggerEmailQueueJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TriggerEmailQueueJobDispatcherSchema(TriggerEmailQueueJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0d4e234-cd3d-0785-1103-1944273b2e8b");
			Name = "TriggerEmailQueueJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,77,107,219,64,16,61,43,144,255,48,208,75,2,70,162,87,197,53,36,169,9,46,117,73,145,67,15,165,7,125,140,229,37,171,93,117,118,215,70,152,252,247,142,180,146,144,155,56,133,222,164,153,55,111,230,205,188,85,105,133,166,78,115,132,13,18,165,70,111,109,120,175,213,86,148,142,82,43,180,186,188,56,94,94,4,206,8,85,66,210,24,139,21,231,165,196,188,77,154,240,1,21,146,200,111,70,204,148,134,48,76,242,29,22,78,34,189,133,248,129,25,163,170,74,43,206,114,254,3,97,201,172,112,47,83,99,98,216,144,40,75,164,101,149,10,249,221,161,195,47,58,251,44,120,90,203,164,212,85,68,81,4,115,227,170,42,165,102,209,255,39,72,123,52,144,57,249,12,216,214,194,239,182,24,14,194,238,128,213,154,180,228,244,86,19,88,223,0,11,143,51,225,192,24,77,40,107,151,73,145,67,222,206,244,143,145,32,134,187,212,224,29,119,62,131,152,193,234,182,174,151,123,84,246,171,224,101,170,86,71,112,236,180,140,242,31,73,215,72,86,32,239,128,191,45,239,26,11,15,233,166,19,138,153,132,45,116,30,181,3,6,245,128,1,189,231,221,138,2,97,181,84,174,66,74,51,137,243,211,113,214,126,1,155,166,198,5,220,74,169,15,88,76,98,6,62,117,156,129,194,3,156,173,252,249,11,142,29,42,56,11,9,19,84,197,116,93,29,254,229,166,151,202,73,175,246,84,250,26,237,78,23,255,175,123,175,69,1,131,231,120,243,87,134,111,204,158,59,104,122,238,108,254,141,253,62,131,62,234,12,82,27,184,238,213,240,105,70,191,142,206,93,11,229,44,202,134,217,230,239,159,127,113,229,119,194,193,7,210,174,246,189,254,106,61,244,156,1,223,88,232,98,165,124,3,214,252,113,230,235,133,241,15,237,137,161,49,155,212,181,19,15,115,197,163,60,234,225,149,48,91,65,184,82,172,202,117,207,50,134,169,146,245,171,124,152,176,185,237,163,102,95,55,215,237,195,12,94,222,60,139,143,158,6,57,246,7,59,226,99,128,52,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0d4e234-cd3d-0785-1103-1944273b2e8b"));
		}

		#endregion

	}

	#endregion

}

