namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeatureUtilsWrapSchema

	/// <exclude/>
	public class FeatureUtilsWrapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeatureUtilsWrapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeatureUtilsWrapSchema(FeatureUtilsWrapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("857989eb-d198-4858-9f7a-b2ad3d351897");
			Name = "FeatureUtilsWrap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,145,79,107,195,48,12,197,207,41,244,59,136,246,210,192,72,238,221,31,216,186,101,244,48,216,97,101,135,177,131,99,43,169,193,179,131,236,28,74,233,119,159,156,116,163,37,45,131,245,104,249,233,167,247,36,43,190,208,55,66,34,188,33,145,240,174,10,217,194,217,74,215,45,137,160,157,29,143,182,227,81,210,122,109,235,35,9,225,245,153,122,86,8,25,28,105,244,172,96,205,148,176,102,16,44,140,240,126,14,5,138,208,18,174,130,54,254,157,68,211,105,62,30,177,18,173,9,15,218,42,38,206,194,166,65,87,205,150,7,98,29,152,152,166,159,172,110,218,210,104,9,50,2,7,60,152,195,160,141,123,182,221,156,95,51,47,24,214,78,177,157,215,142,213,127,230,121,14,55,218,174,145,116,80,142,7,16,86,183,147,1,45,123,198,176,244,251,234,147,21,165,65,53,91,121,36,94,156,69,25,183,118,5,62,16,7,73,39,249,93,36,239,29,151,206,25,248,187,27,90,249,3,0,233,20,166,16,111,144,36,132,220,19,127,79,58,232,148,241,40,201,238,226,56,133,163,123,187,137,174,46,11,118,150,243,175,136,7,180,65,216,41,90,213,223,182,123,247,213,227,226,238,27,10,28,152,59,237,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("857989eb-d198-4858-9f7a-b2ad3d351897"));
		}

		#endregion

	}

	#endregion

}

