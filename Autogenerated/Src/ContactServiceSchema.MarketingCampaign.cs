namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactServiceSchema

	/// <exclude/>
	public class ContactServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactServiceSchema(ContactServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a");
			Name = "ContactService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,77,111,218,64,16,61,59,82,254,195,136,92,64,66,230,158,4,34,130,26,149,74,36,81,0,229,128,170,106,177,199,100,213,253,112,118,214,84,168,234,127,239,236,218,16,130,92,122,243,190,153,121,251,230,237,140,141,208,72,165,200,16,22,232,156,32,91,248,116,98,77,33,55,149,19,94,90,115,121,241,251,242,34,169,72,154,13,204,119,228,81,167,115,116,91,153,225,204,230,168,110,206,5,211,113,230,229,54,210,156,207,123,197,245,71,194,135,16,134,89,140,214,177,156,227,87,14,55,204,5,19,37,136,174,129,117,122,145,249,134,41,102,172,154,67,8,57,142,125,15,216,152,202,71,244,76,84,178,148,181,84,210,239,94,240,189,146,14,53,26,79,221,227,67,208,3,67,248,79,73,200,74,27,32,239,133,75,202,106,173,100,6,89,80,118,34,12,174,225,94,16,30,100,38,193,208,67,47,207,206,150,232,188,68,110,232,57,146,196,70,146,210,5,231,240,132,235,43,42,206,134,31,89,11,90,123,148,12,6,3,184,165,74,107,225,118,163,61,48,53,228,133,97,45,182,104,101,76,15,149,131,227,210,166,171,86,13,173,96,108,45,217,160,135,225,168,93,37,220,221,65,183,61,50,4,131,191,90,121,187,75,66,199,1,131,89,24,166,94,239,38,222,67,231,238,25,194,86,168,10,99,230,159,218,154,43,52,121,109,123,115,110,222,96,134,254,205,230,39,15,208,234,227,11,106,187,69,130,66,137,13,60,90,195,3,94,9,5,133,179,122,47,28,132,201,15,223,97,122,43,35,179,184,3,255,48,57,34,165,112,66,131,225,109,28,118,10,169,60,58,234,140,30,234,15,240,22,8,21,70,190,200,155,222,14,98,65,123,61,79,40,207,235,60,123,67,45,150,211,188,51,170,63,129,133,188,87,8,50,15,9,133,228,87,63,166,89,61,177,107,81,231,241,242,36,43,94,194,169,217,218,159,216,173,109,98,99,59,207,79,243,69,167,15,75,39,23,168,75,21,230,148,209,57,250,218,143,47,90,72,69,156,112,111,243,221,220,239,84,8,51,207,12,137,196,6,15,104,250,234,68,89,98,222,143,175,25,246,9,201,63,88,167,133,255,84,80,67,233,55,178,166,207,79,64,165,53,132,231,243,226,82,238,231,119,107,101,14,39,234,186,228,93,248,219,52,102,247,161,57,159,152,215,107,70,186,117,105,150,101,206,173,55,161,49,237,76,54,177,14,187,7,202,83,174,122,22,147,164,117,26,235,25,61,6,25,249,11,197,122,229,232,159,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRemindingUpdateMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRemindingUpdateMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dcc3279a-ae13-4ada-8127-1557b79bc092"),
				Name = "RemindingUpdateMessage",
				CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc"),
				CreatedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"),
				ModifiedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"));
		}

		#endregion

	}

	#endregion

}

