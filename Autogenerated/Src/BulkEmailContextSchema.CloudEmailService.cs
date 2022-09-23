namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailContextSchema

	/// <exclude/>
	public class BulkEmailContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailContextSchema(BulkEmailContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20559898-5818-4bc5-ac24-30a5cda72c44");
			Name = "BulkEmailContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,65,111,194,48,12,133,207,67,226,63,88,112,111,239,99,67,98,21,154,122,152,132,198,118,154,118,8,169,219,69,107,147,202,113,166,33,180,255,62,183,5,70,17,48,46,85,237,188,151,239,197,137,85,21,250,90,105,132,23,36,82,222,229,28,37,206,230,166,8,164,216,56,59,28,108,134,131,155,224,141,45,96,185,246,140,213,100,95,159,177,68,201,124,121,90,68,40,125,89,25,19,22,34,132,164,84,222,223,194,67,40,63,231,149,50,165,108,195,248,205,173,38,142,99,184,243,161,170,20,173,167,219,58,181,185,163,170,133,128,90,185,192,176,18,43,96,227,221,89,226,3,79,29,86,165,209,160,27,204,9,202,205,166,37,237,227,44,200,213,72,108,80,50,45,90,107,183,126,28,101,155,197,179,178,50,56,151,3,127,160,8,16,65,19,230,247,163,254,145,163,87,143,36,76,139,186,9,62,138,167,192,235,26,163,253,206,135,137,119,145,251,158,227,114,3,5,242,4,124,243,249,185,152,145,201,101,65,163,135,217,34,5,25,158,140,220,133,12,218,57,192,18,233,203,232,127,146,164,114,155,179,218,236,196,205,239,181,248,196,149,229,54,177,12,73,30,154,87,5,130,201,60,24,219,191,185,243,248,199,96,178,183,119,120,234,204,169,120,175,167,7,203,13,248,143,4,132,218,212,6,45,251,139,80,35,198,231,157,180,219,231,4,117,140,54,235,94,78,91,119,221,126,83,122,191,212,49,218,119,98,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20559898-5818-4bc5-ac24-30a5cda72c44"));
		}

		#endregion

	}

	#endregion

}

