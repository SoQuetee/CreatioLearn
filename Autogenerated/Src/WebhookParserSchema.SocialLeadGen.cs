namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookParserSchema

	/// <exclude/>
	public class WebhookParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookParserSchema(WebhookParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27f94e71-ff84-4026-a617-5aa9c6d13750");
			Name = "WebhookParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,193,110,194,48,12,61,23,137,127,176,224,178,93,218,251,232,122,1,105,210,4,12,105,147,118,78,83,211,102,107,19,148,164,67,12,241,239,75,220,2,131,149,33,237,176,30,34,197,126,239,217,126,78,37,171,208,172,24,71,120,65,173,153,81,75,27,142,149,92,138,188,214,204,10,37,195,103,197,5,43,167,200,178,7,148,253,222,182,223,11,106,35,100,14,115,92,91,37,137,241,104,148,28,245,123,46,53,212,152,59,22,140,75,102,204,29,188,98,90,40,245,190,96,218,160,38,64,20,69,16,155,186,170,152,222,36,237,189,69,193,138,96,225,30,21,125,131,173,234,180,20,28,140,117,77,113,224,94,253,92,60,216,82,129,67,11,51,180,133,202,92,19,11,226,54,201,243,242,20,32,5,40,221,136,32,149,21,203,13,172,219,142,50,102,89,120,224,69,231,196,216,117,204,42,144,206,196,251,129,199,14,146,137,59,97,93,8,94,128,48,32,17,51,176,10,82,4,174,228,7,106,219,220,109,209,93,79,165,111,200,109,24,71,36,124,172,163,209,214,90,154,100,250,27,103,15,242,172,83,191,60,109,78,172,189,213,52,242,49,124,99,172,246,59,245,51,220,130,223,113,16,52,114,224,119,59,110,122,15,39,232,156,118,175,65,124,226,19,85,141,127,40,39,55,164,49,242,18,187,171,158,187,199,103,88,142,255,105,251,133,146,215,156,159,93,161,93,54,191,101,118,248,127,146,249,243,10,186,244,59,182,48,68,153,53,127,6,221,41,10,238,59,141,239,190,0,202,159,170,45,17,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27f94e71-ff84-4026-a617-5aa9c6d13750"));
		}

		#endregion

	}

	#endregion

}

