namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrSessionTimeoutSchema

	/// <exclude/>
	public class UsrSessionTimeoutSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrSessionTimeoutSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrSessionTimeoutSchema(UsrSessionTimeoutSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("86015277-6ddd-476e-a060-e2fa77809026");
			Name = "UsrSessionTimeout";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f7c41f3e-e9a7-4f45-bb40-5d19d1bc3cae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,0,0,69,207,108,233,1,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86015277-6ddd-476e-a060-e2fa77809026"));
		}

		#endregion

	}

	#endregion

}

