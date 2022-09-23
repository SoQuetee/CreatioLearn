namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventQueueMessageNotifierSchema

	/// <exclude/>
	public class EventQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventQueueMessageNotifierSchema(EventQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2");
			Name = "EventQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,203,110,219,48,16,60,59,64,254,129,80,47,18,96,72,247,248,113,72,226,164,6,154,192,141,92,244,76,83,43,155,141,68,170,124,184,113,131,252,123,249,16,109,201,177,131,244,96,192,92,238,206,206,206,142,200,112,13,178,193,4,208,18,132,192,146,151,42,189,225,172,164,107,45,176,162,156,93,94,188,94,94,12,180,164,108,141,242,157,84,80,143,246,231,110,137,128,115,241,244,246,218,92,153,203,47,2,214,6,17,221,84,88,202,43,52,219,2,83,223,53,104,120,0,41,241,26,30,185,162,37,5,225,146,179,44,67,99,169,235,26,139,221,180,61,187,10,84,251,108,212,8,78,204,95,219,144,181,149,105,40,204,58,149,141,94,85,148,32,98,187,158,111,138,174,208,53,150,112,154,207,224,213,113,58,76,192,153,84,66,19,197,133,25,100,225,26,248,140,99,218,46,208,73,71,165,249,141,37,0,34,2,202,73,116,150,79,148,77,61,229,116,15,155,29,227,142,27,44,112,141,152,217,225,36,210,18,132,105,196,128,216,181,69,211,113,230,110,93,114,43,193,217,102,241,143,94,49,234,99,37,70,155,149,209,38,62,14,91,103,12,222,90,105,128,21,94,157,190,84,11,193,27,16,138,130,21,74,112,101,106,161,248,64,171,71,51,12,226,37,82,27,35,145,22,194,110,188,187,222,19,82,52,1,22,241,173,113,30,45,0,25,185,173,47,194,124,14,244,21,173,65,161,201,20,221,131,90,238,26,136,147,212,198,71,232,237,147,116,4,212,148,21,22,215,144,162,106,135,36,217,64,141,255,155,213,83,192,201,93,125,159,156,93,38,47,99,183,170,100,207,237,156,186,15,160,54,188,112,210,210,45,86,224,111,27,127,8,253,204,188,14,206,54,138,239,53,45,16,216,227,188,104,55,56,216,98,129,36,84,134,45,154,32,6,127,80,238,14,71,174,72,92,238,192,124,211,149,174,89,28,89,184,40,4,239,4,175,227,30,247,112,243,115,3,2,226,104,94,68,73,58,151,179,223,26,87,177,135,72,23,214,160,160,140,255,2,161,4,97,217,118,31,185,122,79,43,205,27,32,180,220,61,242,111,156,60,127,165,76,201,56,241,9,2,148,22,172,165,159,206,94,128,104,5,57,193,21,22,99,63,255,180,77,253,188,148,239,93,74,153,153,130,170,130,19,148,157,219,174,83,214,104,157,235,213,47,115,53,47,98,251,160,44,177,124,238,126,114,225,249,10,218,183,252,227,240,170,225,19,111,84,146,206,188,62,221,57,62,205,235,224,2,255,57,16,247,174,223,130,36,130,54,246,239,135,60,135,161,222,126,198,174,242,9,164,174,84,207,59,97,98,99,159,158,0,97,214,209,62,21,130,17,125,234,193,151,123,140,78,50,235,240,93,96,101,140,194,76,89,223,149,169,65,49,166,192,21,253,139,87,21,228,142,108,207,137,167,30,188,100,232,221,25,217,209,187,178,44,225,69,69,71,214,114,144,233,29,23,53,86,241,9,78,195,195,84,195,119,50,125,96,61,31,237,7,77,236,31,50,170,81,87,147,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBaseNotificationTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBaseNotificationTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("533eb283-d1e0-4283-97c3-990f51f39aaf"),
				Name = "BaseNotificationText",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2"),
				ModifiedInSchemaUId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2"));
		}

		#endregion

	}

	#endregion

}

