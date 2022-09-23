namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageNotifierSchema

	/// <exclude/>
	public class TouchQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageNotifierSchema(TouchQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38be02db-3e45-4885-b616-878b6f010bac");
			Name = "TouchQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,111,219,48,12,61,167,64,255,3,225,93,82,96,136,239,205,199,97,221,80,236,208,34,107,178,31,160,200,116,162,54,150,60,82,26,16,4,253,239,163,164,184,77,140,164,24,122,48,64,241,227,241,241,81,178,85,13,114,171,52,194,18,137,20,187,218,143,238,156,173,205,58,144,242,198,217,235,171,253,245,213,32,176,177,107,88,236,216,99,51,126,59,31,151,16,138,95,34,95,8,215,82,6,119,91,197,124,11,75,23,244,230,87,192,128,15,200,172,214,248,232,188,169,13,82,74,46,203,18,38,28,154,70,209,110,118,56,167,66,240,14,108,204,220,129,90,185,224,229,44,56,240,39,2,65,147,145,160,37,167,197,140,76,8,57,108,61,143,58,204,242,8,180,13,171,173,209,160,19,238,69,62,112,11,223,20,227,121,170,131,125,162,251,62,156,179,236,41,104,239,72,102,156,167,6,57,163,63,81,30,233,61,29,106,249,38,140,8,154,176,158,22,23,249,20,229,44,83,30,189,193,150,125,220,73,171,72,53,96,101,135,211,34,48,146,52,178,168,227,218,138,217,164,76,209,148,124,144,224,98,179,225,239,147,98,56,197,186,17,109,86,162,205,176,239,222,195,235,65,23,180,85,150,230,84,167,57,57,47,201,88,157,17,201,216,13,146,241,149,211,101,230,216,229,130,251,43,247,202,84,8,34,90,92,110,199,242,81,230,132,233,12,178,104,115,103,172,231,98,252,41,200,39,108,140,173,196,90,232,13,54,170,67,142,74,186,122,152,240,111,198,31,207,246,128,126,227,170,115,235,255,15,26,247,193,84,112,143,126,17,86,207,18,250,89,13,227,229,91,42,126,57,94,79,119,211,69,233,136,51,32,244,129,108,42,30,253,104,90,191,139,79,113,240,250,41,5,164,121,214,85,167,103,254,29,89,147,105,163,249,33,149,175,93,189,107,49,255,32,158,210,211,235,81,236,69,143,121,246,244,204,222,83,167,248,254,1,255,198,208,179,152,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38be02db-3e45-4885-b616-878b6f010bac"));
		}

		#endregion

	}

	#endregion

}

