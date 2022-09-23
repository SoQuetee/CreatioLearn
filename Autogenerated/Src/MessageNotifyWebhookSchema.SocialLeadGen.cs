namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessageNotifyWebhookSchema

	/// <exclude/>
	public class MessageNotifyWebhookSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessageNotifyWebhookSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessageNotifyWebhookSchema(MessageNotifyWebhookSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b64b5e73-bc62-4ff2-a773-7df631ba5e5b");
			Name = "MessageNotifyWebhook";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,203,78,195,48,16,60,183,82,255,97,5,23,184,164,119,64,189,180,8,21,81,168,84,36,14,136,131,227,108,18,131,99,71,94,71,85,168,248,119,236,196,125,36,42,80,46,145,178,153,157,153,157,221,40,86,32,149,140,35,60,163,49,140,116,106,163,169,86,169,200,42,195,172,208,42,90,105,46,152,124,64,150,220,161,26,13,55,163,225,160,34,161,50,120,196,181,213,170,233,184,39,173,174,119,31,86,53,89,44,28,141,148,200,61,7,69,174,21,141,224,14,227,80,231,6,51,87,133,169,100,68,87,240,130,113,174,245,199,146,25,66,211,0,198,227,49,220,80,85,20,204,212,147,240,190,64,34,150,33,40,109,69,90,195,186,109,138,182,232,241,1,252,213,219,121,138,223,157,248,197,2,139,24,205,202,137,51,41,62,219,137,158,74,59,87,151,111,14,89,86,177,20,28,184,55,178,85,120,108,4,130,41,135,217,52,150,250,166,3,184,253,214,247,219,20,102,72,220,136,24,9,124,40,18,161,8,19,164,218,132,41,162,93,243,161,253,163,174,124,221,71,127,68,172,19,15,215,9,194,58,23,60,135,100,103,96,157,51,11,57,43,75,116,171,216,147,116,68,219,212,150,70,151,104,108,125,113,230,137,206,154,144,118,134,200,26,191,222,169,151,216,64,134,246,26,200,63,190,218,20,254,112,102,235,18,79,21,247,216,158,184,80,22,158,93,249,31,202,51,180,76,72,76,66,18,165,95,62,232,116,187,136,83,205,28,116,31,15,100,118,64,223,115,55,24,4,139,231,168,146,246,130,186,231,20,100,4,186,155,90,54,172,191,156,84,136,146,220,150,183,191,214,15,39,212,27,33,76,76,193,127,176,63,191,85,85,129,134,197,18,111,2,245,100,175,113,36,231,222,16,109,181,91,252,250,6,47,76,203,32,81,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b64b5e73-bc62-4ff2-a773-7df631ba5e5b"));
		}

		#endregion

	}

	#endregion

}

