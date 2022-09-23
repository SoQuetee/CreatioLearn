namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationResponseSchema

	/// <exclude/>
	public class ValidationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationResponseSchema(ValidationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d");
			Name = "ValidationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,77,139,194,48,16,134,207,22,250,31,6,188,183,247,117,241,226,213,131,168,236,61,157,78,99,216,52,83,102,146,133,85,252,239,155,182,42,34,139,16,194,124,100,222,247,201,4,211,147,14,6,9,142,36,98,148,187,88,109,56,116,206,38,49,209,113,40,139,75,89,148,197,162,174,107,248,212,212,247,70,126,215,183,124,79,131,144,82,136,10,241,68,144,227,228,35,112,7,120,34,252,118,193,194,143,241,174,157,116,64,146,167,234,46,84,63,41,13,169,241,14,1,189,81,133,175,199,192,62,115,113,80,202,47,102,130,197,82,200,142,74,59,225,129,36,58,210,15,216,77,195,115,255,21,241,198,56,66,85,143,254,179,243,221,186,97,246,112,72,136,148,9,46,96,41,174,64,199,235,250,70,120,203,152,89,207,166,241,4,121,135,106,44,1,114,75,239,173,52,202,184,151,45,158,15,83,180,201,19,255,89,46,41,180,243,119,167,60,87,243,249,3,37,78,208,4,173,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d"));
		}

		#endregion

	}

	#endregion

}

