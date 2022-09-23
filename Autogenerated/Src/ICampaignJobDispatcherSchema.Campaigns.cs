namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignJobDispatcherSchema

	/// <exclude/>
	public class ICampaignJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignJobDispatcherSchema(ICampaignJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef");
			Name = "ICampaignJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,85,77,111,219,48,12,61,167,64,255,3,225,29,182,1,131,125,111,154,92,82,116,240,128,13,93,155,157,7,217,162,109,21,150,228,233,163,89,22,244,191,143,150,99,39,78,90,44,135,96,151,30,69,81,239,241,61,146,182,98,18,109,195,114,132,37,26,195,172,46,92,188,208,170,16,165,55,204,9,173,46,47,54,151,23,19,111,133,42,225,97,109,29,202,233,112,94,104,131,11,38,27,38,74,245,144,87,40,25,204,70,56,6,227,254,62,30,39,238,64,190,123,102,220,31,58,83,228,157,193,146,56,33,85,14,77,65,85,93,65,218,191,251,162,179,27,65,165,58,122,111,66,118,146,36,112,109,189,148,204,172,231,219,243,61,54,6,45,42,103,65,162,171,52,183,80,104,3,143,58,179,239,65,50,197,74,148,116,27,247,207,147,189,247,141,207,106,145,131,232,201,95,229,158,108,2,255,80,238,157,209,13,26,39,208,94,193,93,0,233,238,15,11,12,129,84,89,199,20,161,235,130,46,17,33,55,88,204,162,180,245,133,251,26,77,148,204,97,37,92,5,138,122,179,159,242,51,223,179,48,164,126,163,140,54,157,20,114,44,152,175,131,176,99,101,147,29,58,44,14,65,96,3,37,186,41,60,195,86,21,42,222,9,27,171,252,218,249,121,130,196,30,218,130,194,223,174,53,63,52,193,85,8,182,193,92,20,2,57,244,98,94,169,56,68,26,102,152,12,62,204,34,27,230,38,154,47,171,145,41,199,51,24,12,201,30,49,119,129,117,37,242,10,168,129,208,212,76,217,248,58,9,160,47,115,20,194,224,82,72,236,54,32,154,223,210,25,28,5,32,15,145,126,150,70,40,79,90,240,65,50,17,125,120,97,45,186,226,63,13,230,223,142,136,96,204,251,113,122,130,183,231,180,54,31,21,251,35,229,157,203,94,137,95,30,65,112,90,152,22,216,180,35,219,231,110,37,209,182,116,227,252,63,140,253,236,197,78,220,80,236,57,92,189,71,169,159,104,94,237,150,141,135,47,198,25,173,61,205,211,54,232,214,176,170,218,153,109,123,107,43,237,107,14,25,210,126,215,232,144,31,27,212,149,78,246,216,177,63,41,255,135,98,59,108,233,91,88,208,157,222,115,174,232,193,183,242,185,251,139,141,130,20,251,11,3,205,133,253,101,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef"));
		}

		#endregion

	}

	#endregion

}

