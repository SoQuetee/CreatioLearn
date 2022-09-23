namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountRequestSchema

	/// <exclude/>
	public class AccountRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountRequestSchema(AccountRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2254511-5ed7-2a4b-f1ee-949aba2a67b2");
			Name = "AccountRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,203,106,195,64,12,69,215,49,248,31,4,217,219,251,166,20,138,3,165,80,136,105,243,3,202,88,54,3,182,198,149,102,22,37,228,223,27,207,216,193,125,144,141,64,143,195,185,98,28,72,71,52,4,71,18,65,117,173,47,42,199,173,237,130,160,183,142,139,15,103,44,246,111,132,205,11,113,158,157,243,44,207,54,91,161,238,186,132,170,71,213,7,120,54,198,5,246,239,244,25,72,125,188,40,203,18,30,53,12,3,202,215,211,220,239,143,7,144,116,3,173,19,192,132,65,24,27,244,164,197,130,149,43,110,12,167,222,26,48,147,232,143,103,147,210,220,226,212,226,70,18,111,233,154,169,142,96,218,255,14,19,7,149,208,244,33,52,110,64,203,197,237,110,109,95,244,234,197,114,183,32,251,72,192,25,58,242,59,208,169,92,238,136,234,21,10,150,213,35,27,186,239,59,57,215,71,110,198,94,103,234,63,231,150,184,73,255,199,62,77,127,14,47,223,109,19,228,33,231,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2254511-5ed7-2a4b-f1ee-949aba2a67b2"));
		}

		#endregion

	}

	#endregion

}

