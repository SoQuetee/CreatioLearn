namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseQueueMessageSchema

	/// <exclude/>
	public class BaseQueueMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseQueueMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseQueueMessageSchema(BaseQueueMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04c48118-f957-49c4-a4ac-39fa34b1c523");
			Name = "BaseQueueMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("097cd95f-c972-4e9b-ab53-9b1cae85bae7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,193,78,195,48,12,134,207,155,180,119,176,180,11,92,218,59,3,14,20,36,64,2,13,24,92,208,14,94,235,150,136,38,25,177,163,49,77,188,59,73,58,198,6,211,46,149,252,219,191,253,217,169,65,77,60,199,146,96,66,206,33,219,90,178,194,154,90,53,222,161,40,107,6,253,213,160,223,243,172,76,3,79,75,22,210,163,77,124,79,11,177,38,121,110,217,154,144,8,169,161,163,38,248,160,104,145,249,4,46,144,233,193,147,167,59,98,198,134,82,77,158,231,112,202,94,107,116,203,243,117,28,11,65,119,69,80,91,7,31,209,149,253,84,231,91,229,115,63,107,85,9,56,99,113,88,10,148,113,212,191,73,208,13,159,32,191,239,2,244,86,9,98,67,58,118,118,78,78,20,5,220,113,106,221,229,255,82,38,225,138,69,105,20,170,128,140,168,104,130,210,122,35,217,198,177,77,218,123,141,135,185,105,140,117,52,141,241,26,93,25,249,237,244,104,23,92,196,30,176,130,134,100,4,28,63,95,7,32,158,153,92,232,17,174,164,211,35,129,173,65,222,8,74,239,92,192,2,31,242,135,128,214,27,47,143,46,169,70,223,202,11,182,158,174,209,84,109,124,214,51,216,39,103,221,22,199,219,107,132,251,71,67,196,9,63,141,208,231,222,21,134,100,170,238,212,41,238,212,93,49,104,223,35,193,125,80,138,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04c48118-f957-49c4-a4ac-39fa34b1c523"));
		}

		#endregion

	}

	#endregion

}

