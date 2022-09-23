namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatMessageSchema

	/// <exclude/>
	public class ChatMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatMessageSchema(ChatMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21c9a1d7-90b7-429c-ad25-dd578ea023a7");
			Name = "ChatMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,65,79,2,49,16,133,207,146,240,31,38,156,244,210,253,1,34,9,130,33,36,162,70,184,25,15,165,59,192,36,219,150,116,186,70,52,252,119,167,11,139,172,146,189,108,218,125,243,189,190,125,93,167,45,242,86,27,132,5,134,160,217,175,162,26,121,183,162,117,25,116,36,239,212,179,117,100,54,218,57,44,212,12,153,245,154,220,186,219,249,238,118,174,74,150,37,156,13,188,4,255,65,57,6,86,99,111,53,57,245,224,34,69,66,190,61,77,207,119,28,209,254,221,203,153,69,129,38,29,200,106,130,14,3,153,127,51,175,165,184,89,84,115,81,117,65,95,85,62,153,146,185,44,203,160,207,165,181,58,236,6,199,253,168,208,204,96,188,139,146,4,3,172,124,0,201,25,193,86,95,129,172,106,48,59,35,223,198,58,106,105,32,6,109,226,187,188,216,150,203,130,12,152,202,109,36,252,161,4,20,41,117,112,0,102,104,151,24,174,159,164,77,184,131,30,229,189,155,196,214,240,164,164,28,166,249,33,235,69,66,151,113,227,67,147,74,135,165,36,18,4,134,149,222,98,144,154,105,226,28,67,42,111,33,66,27,135,159,241,50,39,66,11,151,83,56,220,87,19,62,150,51,174,85,56,173,218,50,236,182,120,209,102,33,2,164,71,91,115,81,10,218,88,116,145,155,30,143,196,177,127,52,26,158,134,6,240,187,230,22,91,226,123,95,95,117,211,119,233,125,1,211,51,57,253,168,251,110,103,255,3,91,7,137,235,76,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21c9a1d7-90b7-429c-ad25-dd578ea023a7"));
		}

		#endregion

	}

	#endregion

}

