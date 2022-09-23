namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailNotifierSchema

	/// <exclude/>
	public class BulkEmailNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailNotifierSchema(BulkEmailNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48");
			Name = "BulkEmailNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,203,110,219,48,16,60,59,64,255,97,161,94,36,192,144,239,245,227,144,103,13,52,129,27,187,232,153,150,86,54,27,137,84,249,72,227,6,249,247,46,41,209,150,236,36,72,15,6,196,229,238,112,118,118,188,130,85,168,107,150,33,172,80,41,166,101,97,210,11,41,10,190,177,138,25,46,197,167,179,231,79,103,3,171,185,216,192,114,167,13,86,227,253,185,91,162,240,173,120,122,121,78,87,116,249,89,225,134,16,225,162,100,90,127,129,115,91,62,92,85,140,151,119,210,240,130,163,242,73,163,209,8,38,218,86,21,83,187,89,123,118,153,128,46,21,136,173,102,27,132,90,201,140,62,221,107,162,45,79,67,245,168,83,94,219,117,201,51,200,220,147,167,47,2,177,96,26,191,91,180,120,219,32,31,200,12,158,61,161,3,109,41,180,81,54,51,82,17,251,133,7,110,50,142,57,251,64,39,29,10,250,77,52,34,100,10,139,105,116,194,35,26,205,26,138,233,30,110,116,140,55,169,153,98,21,8,26,216,52,178,26,21,61,32,48,115,51,138,102,147,145,191,245,201,109,203,39,143,196,63,122,69,208,199,72,72,139,53,105,17,31,135,221,248,7,47,173,20,40,242,70,141,190,52,11,37,107,84,134,163,19,70,73,67,181,152,191,163,205,29,53,1,178,0,179,37,73,172,82,40,76,111,140,175,72,80,7,88,144,143,100,47,158,35,144,188,110,254,161,63,15,250,12,27,52,48,157,193,13,154,213,174,198,56,73,93,124,12,47,31,164,163,176,226,34,119,184,68,138,155,29,232,108,75,214,251,111,86,247,1,103,233,235,251,228,220,16,101,17,239,71,148,236,249,189,165,240,45,154,173,204,189,188,252,145,25,108,110,235,230,16,222,164,158,15,83,167,39,226,27,203,115,88,135,208,60,111,167,57,120,100,10,52,150,196,28,166,32,240,15,44,253,225,200,33,137,207,29,208,159,184,180,149,136,35,7,25,133,224,181,146,85,124,210,71,184,253,185,69,133,113,52,207,163,36,157,235,171,223,150,149,113,3,147,46,156,81,209,144,31,187,196,18,96,186,101,49,246,24,13,189,116,89,99,198,139,221,157,252,38,179,135,175,92,24,29,39,77,130,66,99,149,104,219,72,175,158,48,179,6,151,25,43,153,154,52,122,204,218,212,143,75,219,115,238,43,179,245,122,146,202,75,187,254,69,87,243,60,118,235,99,197,244,67,119,133,132,37,21,212,110,153,198,97,119,177,206,38,234,214,37,233,249,65,145,46,243,183,93,70,92,26,251,103,126,89,95,162,206,20,175,221,231,187,204,134,161,222,253,109,125,229,61,106,91,154,158,63,66,143,100,145,94,203,161,187,241,62,117,221,53,93,147,222,247,225,30,171,83,36,58,188,23,204,144,33,4,149,246,29,152,18,18,13,158,149,252,47,91,151,184,244,164,79,92,23,22,64,50,108,220,23,185,214,187,178,172,240,201,68,71,182,241,80,233,181,84,21,51,241,43,92,134,253,174,134,39,82,189,99,173,38,218,15,82,236,31,119,123,98,23,108,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBaseNotificationTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBaseNotificationTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1e854a2a-8c1e-4794-9486-6d3d7913b64e"),
				Name = "BaseNotificationText",
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				CreatedInSchemaUId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48"),
				ModifiedInSchemaUId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48"));
		}

		#endregion

	}

	#endregion

}

