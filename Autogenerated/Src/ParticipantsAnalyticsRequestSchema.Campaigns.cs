namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsRequestSchema

	/// <exclude/>
	public class ParticipantsAnalyticsRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsRequestSchema(ParticipantsAnalyticsRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80");
			Name = "ParticipantsAnalyticsRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,111,219,48,12,61,167,64,255,3,145,93,218,139,115,95,63,128,33,69,187,30,58,20,77,119,26,118,96,100,218,33,32,75,174,68,111,200,138,254,247,81,118,156,196,105,215,194,192,46,65,40,62,145,239,61,145,118,88,81,172,209,16,60,82,8,24,125,33,217,220,187,130,203,38,160,176,119,199,71,207,199,71,147,38,178,43,97,177,142,66,213,217,65,156,61,52,78,184,162,108,65,129,209,242,159,246,158,162,20,247,41,80,169,1,204,45,198,248,25,238,49,8,27,174,209,73,252,226,208,174,53,138,15,244,212,80,148,22,63,155,205,224,60,54,85,133,97,125,185,137,55,121,168,49,40,89,161,0,133,15,91,44,17,152,64,197,197,116,142,85,141,92,58,101,241,139,13,101,135,241,13,201,155,237,79,222,35,117,58,157,93,102,155,94,106,139,32,187,184,35,18,19,19,48,104,77,99,81,40,234,223,174,103,130,108,107,2,246,69,251,74,231,179,61,137,63,174,80,48,213,14,104,228,167,30,212,205,210,178,1,147,44,251,192,177,201,115,235,218,214,230,251,224,107,210,11,148,188,110,203,116,249,67,91,59,61,61,89,206,73,31,176,224,206,89,248,189,98,179,26,42,112,68,121,220,9,29,42,122,45,169,211,116,71,213,146,194,201,55,245,10,46,96,218,123,115,155,79,79,147,204,94,231,77,195,249,150,203,109,14,105,220,38,147,146,228,12,162,254,164,232,229,29,21,11,81,162,80,176,77,131,145,227,122,4,163,238,82,91,64,179,52,164,149,78,30,117,170,225,122,136,26,203,239,170,161,29,59,161,209,244,244,254,135,228,54,152,177,212,174,45,150,32,43,20,96,151,179,105,39,184,137,180,191,84,7,226,117,27,244,237,243,215,136,158,165,230,135,27,209,247,138,130,162,95,11,29,153,118,198,100,69,58,103,222,18,232,188,178,207,71,216,162,12,147,244,174,111,28,250,178,244,222,194,247,1,224,255,152,130,37,129,47,118,251,109,125,153,158,19,199,241,254,202,81,124,88,167,228,219,188,247,0,255,228,189,217,120,114,121,183,244,109,220,41,26,30,190,252,5,166,14,228,254,220,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80"));
		}

		#endregion

	}

	#endregion

}

