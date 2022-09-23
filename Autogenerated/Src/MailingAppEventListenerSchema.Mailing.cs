namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingAppEventListenerSchema

	/// <exclude/>
	public class MailingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingAppEventListenerSchema(MailingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f77b591-a8a7-4600-8f2b-2803c4f5ce85");
			Name = "MailingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,79,220,48,16,61,47,18,255,97,148,94,150,75,114,103,63,164,5,65,65,2,21,149,174,56,84,85,53,155,76,182,22,142,29,141,157,168,91,212,255,222,89,59,65,36,75,129,75,34,191,121,243,102,252,102,108,176,34,87,99,78,240,141,152,209,217,210,167,231,214,148,106,219,48,122,101,205,241,209,211,241,209,164,113,202,108,7,20,166,217,43,248,3,109,36,86,85,214,72,84,226,159,152,182,34,2,231,26,157,59,133,91,84,90,18,86,117,125,209,146,241,55,202,121,50,196,129,154,101,25,204,93,83,85,200,187,101,119,254,74,53,147,19,166,131,138,252,47,91,56,240,22,148,81,94,161,86,127,8,164,243,71,220,82,218,231,103,47,4,234,102,163,85,14,249,190,244,255,42,195,41,140,161,51,116,36,217,79,161,169,231,11,92,42,210,133,220,224,142,85,139,158,98,176,142,7,88,59,98,49,205,80,190,119,12,126,54,131,243,172,83,34,83,68,177,161,242,109,188,216,199,164,63,147,31,34,211,190,125,129,60,253,246,144,199,255,9,236,199,54,153,168,18,166,163,126,96,177,0,211,104,221,83,38,45,50,96,93,11,163,39,244,42,169,168,139,135,97,17,190,39,171,192,233,72,201,15,64,7,3,104,22,229,14,202,13,196,211,251,157,248,92,173,199,22,73,226,223,240,101,242,13,191,102,98,32,124,204,201,48,249,24,28,175,85,0,206,148,145,85,234,150,199,73,156,8,114,166,114,145,132,69,189,196,220,91,222,37,217,18,148,244,234,210,103,161,108,172,52,175,145,177,2,35,207,104,145,116,174,37,203,107,227,60,26,121,84,182,124,41,62,154,149,232,167,243,44,8,4,189,110,97,109,43,207,73,21,4,173,85,5,124,49,146,117,239,145,253,123,163,222,143,241,192,250,195,133,233,179,162,231,221,187,184,66,83,104,98,183,246,114,244,138,92,122,97,112,163,105,37,57,45,221,177,109,165,33,238,89,211,97,153,147,55,134,19,209,33,40,216,63,213,29,208,228,119,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f77b591-a8a7-4600-8f2b-2803c4f5ce85"));
		}

		#endregion

	}

	#endregion

}

