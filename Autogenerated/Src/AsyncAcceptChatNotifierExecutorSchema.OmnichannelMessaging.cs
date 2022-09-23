namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncAcceptChatNotifierExecutorSchema

	/// <exclude/>
	public class AsyncAcceptChatNotifierExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncAcceptChatNotifierExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncAcceptChatNotifierExecutorSchema(AsyncAcceptChatNotifierExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de6fad3b-1ad3-c490-fb1b-04c758b887d2");
			Name = "AsyncAcceptChatNotifierExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,219,110,218,64,16,125,38,82,254,97,228,62,212,72,200,126,111,0,9,81,20,81,53,33,106,67,223,151,245,0,91,217,179,214,94,72,172,136,127,239,120,49,190,160,244,197,218,185,157,51,151,99,18,5,218,82,72,132,87,52,70,88,189,119,201,82,211,94,29,188,17,78,105,74,54,5,41,121,20,68,152,39,79,104,173,56,40,58,220,223,125,220,223,141,188,229,39,252,174,172,195,226,225,198,102,148,60,71,89,67,216,228,17,9,141,146,93,78,159,172,40,52,125,30,49,200,126,142,124,49,120,96,28,88,230,194,90,248,6,11,91,145,92,72,137,165,91,30,133,123,214,78,237,21,154,144,155,166,41,76,173,47,10,97,170,121,99,255,194,210,160,69,114,22,4,129,168,171,143,70,147,246,22,120,50,7,212,0,36,215,250,180,7,80,250,93,174,36,200,192,253,31,230,213,59,74,239,180,225,222,214,63,244,238,106,114,245,71,104,170,157,224,9,221,81,103,245,12,47,1,246,18,189,237,57,56,26,108,11,186,68,62,133,54,220,252,78,123,23,90,230,198,181,39,55,152,37,175,146,22,44,189,69,155,150,194,136,2,136,207,61,139,188,69,195,71,166,203,121,162,249,150,109,6,188,58,146,105,26,178,63,47,14,111,116,104,108,52,127,105,223,131,154,102,101,39,101,156,23,57,156,180,202,224,178,19,140,183,3,110,24,182,50,129,245,119,21,94,220,251,212,58,195,138,152,128,222,253,229,240,28,58,230,49,212,242,27,141,212,30,226,206,11,179,25,144,207,243,107,116,228,120,51,111,64,248,6,11,115,240,5,11,224,153,195,27,179,42,74,87,173,222,235,43,50,85,220,27,9,164,160,175,14,118,24,128,162,241,67,0,58,135,239,79,101,221,244,209,171,108,222,59,201,172,215,21,203,220,253,17,185,199,56,106,19,162,73,224,239,106,227,113,3,122,18,166,21,30,195,212,89,181,164,54,77,229,85,90,241,112,67,77,241,158,255,13,33,143,16,215,40,87,178,117,6,138,186,222,218,53,180,242,222,18,87,101,53,139,93,214,242,9,28,85,220,213,247,231,61,55,202,69,202,46,226,13,246,197,59,116,158,255,1,157,250,151,138,69,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de6fad3b-1ad3-c490-fb1b-04c758b887d2"));
		}

		#endregion

	}

	#endregion

}

