namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenRestResponseSchema

	/// <exclude/>
	public class SessionTokenRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenRestResponseSchema(SessionTokenRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff");
			Name = "SessionTokenRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,143,65,107,195,48,12,133,207,13,228,63,8,118,79,238,235,216,37,131,93,6,45,75,254,128,155,40,153,89,34,5,201,238,24,101,255,125,142,157,110,109,199,14,54,232,61,241,244,61,50,19,234,108,90,132,6,69,140,114,239,138,138,169,183,131,23,227,44,83,81,115,107,205,248,130,166,123,70,202,179,83,158,229,217,230,78,112,8,38,84,163,81,189,135,26,85,195,216,240,59,210,43,170,11,111,102,82,140,187,101,89,194,131,250,105,50,242,249,184,206,213,200,190,3,89,215,224,169,217,193,135,117,111,96,169,103,153,226,97,48,7,246,14,52,69,131,91,178,139,115,92,121,145,55,251,195,104,91,104,23,148,127,73,32,64,94,22,89,188,189,240,209,118,40,191,180,155,212,238,167,94,216,152,81,156,197,208,113,31,207,36,255,182,82,20,234,91,210,191,168,103,86,117,98,105,184,130,133,19,12,232,182,161,111,248,190,86,12,164,46,145,196,57,169,215,98,208,190,1,125,62,81,71,195,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff"));
		}

		#endregion

	}

	#endregion

}

