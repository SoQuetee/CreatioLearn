namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatContactSchema

	/// <exclude/>
	public class ChatContactSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatContactSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatContactSchema(ChatContactSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9dfeee86-228f-4670-b6f8-b56e2b8c7992");
			Name = "ChatContact";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,221,74,196,48,16,133,175,45,244,29,194,94,233,77,251,0,171,130,84,17,193,170,184,226,141,120,49,155,78,187,131,249,41,249,17,86,217,119,119,210,90,220,149,237,85,146,57,231,59,147,76,12,104,244,61,72,20,47,232,28,120,219,134,162,178,166,165,46,58,8,100,77,241,168,13,201,13,24,131,170,168,209,123,232,200,116,121,246,157,103,39,209,243,86,172,182,62,160,94,254,59,23,207,209,4,210,88,172,208,17,40,250,26,210,254,92,251,237,220,224,250,36,137,181,109,80,113,255,224,64,6,54,179,189,44,75,113,238,163,214,224,182,151,191,231,74,129,247,66,178,15,200,160,19,173,117,130,239,24,198,146,12,162,129,0,197,4,151,123,244,219,53,43,83,131,119,46,244,113,173,72,10,57,36,86,156,81,141,17,44,165,39,142,64,141,122,141,238,244,129,135,37,46,196,130,154,197,89,98,39,248,54,82,35,238,154,229,156,223,240,122,72,248,224,210,16,146,97,150,234,55,54,216,163,216,83,82,102,57,212,64,234,40,119,147,148,89,14,164,180,252,103,135,228,189,181,31,177,127,5,21,81,92,141,134,20,176,203,179,221,15,86,241,173,64,59,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dfeee86-228f-4670-b6f8-b56e2b8c7992"));
		}

		#endregion

	}

	#endregion

}

