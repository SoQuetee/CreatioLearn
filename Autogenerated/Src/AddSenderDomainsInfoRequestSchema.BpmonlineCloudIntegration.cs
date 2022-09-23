namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddSenderDomainsInfoRequestSchema

	/// <exclude/>
	public class AddSenderDomainsInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddSenderDomainsInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddSenderDomainsInfoRequestSchema(AddSenderDomainsInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cef863d-9684-4a82-a74b-e9746da57616");
			Name = "AddSenderDomainsInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,77,79,194,64,20,60,75,194,127,120,41,23,189,180,119,62,76,180,24,227,1,67,40,55,227,97,105,95,235,38,237,110,125,111,139,65,226,127,119,187,11,136,64,32,156,218,55,157,153,190,153,93,37,42,228,90,164,8,115,36,18,172,115,19,198,90,229,178,104,72,24,169,85,24,63,37,19,157,97,201,221,206,186,219,233,118,110,26,150,170,128,100,197,6,171,112,214,40,35,43,12,19,36,41,74,249,237,52,3,199,235,17,22,118,128,184,20,204,125,120,200,178,4,85,134,52,214,149,144,138,95,84,174,103,248,217,32,27,71,143,162,8,134,220,84,149,160,213,253,102,118,82,200,53,1,121,38,24,13,34,203,64,225,23,176,115,131,204,217,133,91,135,232,192,98,200,136,162,100,13,41,97,62,10,46,166,12,31,5,163,77,179,148,41,110,214,11,32,106,221,222,198,194,8,171,50,36,82,243,110,129,186,89,148,50,133,212,45,121,38,30,244,225,216,212,234,125,157,187,158,166,164,107,36,35,209,150,53,117,214,254,251,97,49,14,120,70,195,96,123,225,246,105,62,112,175,134,227,30,60,178,20,101,131,187,113,126,74,243,71,113,97,39,88,45,144,110,95,237,29,129,17,4,158,30,220,181,217,183,225,217,80,123,27,124,104,88,67,129,102,208,46,53,128,159,107,182,87,237,47,116,238,222,107,210,75,105,139,188,46,203,5,135,243,201,182,130,118,62,153,111,186,71,56,149,178,103,143,222,31,163,155,61,250,31,180,216,47,138,202,41,50,109,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cef863d-9684-4a82-a74b-e9746da57616"));
		}

		#endregion

	}

	#endregion

}

