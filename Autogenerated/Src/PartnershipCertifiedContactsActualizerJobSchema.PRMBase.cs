﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PartnershipCertifiedContactsActualizerJobSchema

	/// <exclude/>
	public class PartnershipCertifiedContactsActualizerJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PartnershipCertifiedContactsActualizerJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PartnershipCertifiedContactsActualizerJobSchema(PartnershipCertifiedContactsActualizerJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0318491f-8399-4548-852e-806f5f152a57");
			Name = "PartnershipCertifiedContactsActualizerJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,223,111,218,48,16,126,102,210,254,135,83,246,194,36,20,222,75,139,180,81,58,49,141,105,107,183,189,78,198,57,192,91,98,103,182,83,218,85,253,223,119,182,67,126,64,194,216,94,128,156,207,223,221,125,247,221,5,201,50,52,57,227,8,95,80,107,102,212,218,198,51,37,215,98,83,104,102,133,146,240,242,197,211,203,23,131,194,8,185,129,187,71,99,49,155,28,60,211,133,52,69,238,188,77,252,14,37,106,193,143,124,174,153,101,71,198,15,66,254,170,141,155,84,173,88,122,113,49,83,89,166,100,252,65,109,54,100,174,207,63,226,206,82,8,151,226,123,163,100,125,240,185,96,218,254,62,124,142,23,89,158,198,75,102,249,22,181,169,79,155,133,186,64,221,39,26,251,236,109,126,122,189,174,223,246,30,205,165,21,86,96,79,78,228,112,195,184,85,250,148,199,29,21,149,20,41,234,46,143,37,26,195,28,119,117,133,228,245,74,227,198,53,116,150,50,99,46,224,19,113,68,173,50,91,145,207,80,91,177,22,152,80,101,150,66,155,55,220,22,44,21,191,81,191,87,43,127,121,60,30,195,165,41,178,140,233,199,105,249,124,139,185,70,131,210,26,200,169,231,42,17,156,165,96,153,249,9,107,165,33,175,3,0,223,71,0,94,134,0,86,198,240,44,198,251,16,227,70,140,188,88,165,130,3,119,249,158,159,46,92,192,130,190,230,15,200,11,34,145,244,59,120,242,37,84,4,220,8,76,19,199,128,22,247,204,98,56,60,44,208,27,156,4,81,131,144,198,50,201,49,174,28,155,105,14,242,128,3,228,100,41,95,141,44,81,50,125,132,5,93,135,239,41,125,92,57,164,37,147,140,208,104,66,108,192,29,70,85,203,162,215,174,143,131,222,68,22,101,6,160,214,96,183,72,14,136,192,53,174,175,34,47,166,71,55,94,53,13,209,120,90,210,230,26,113,196,244,137,26,186,208,224,59,118,88,39,37,169,40,147,192,107,155,100,234,141,177,186,112,58,118,84,251,86,158,96,122,33,105,34,60,48,41,3,36,238,42,210,59,74,62,91,11,21,15,125,85,7,133,157,141,55,124,13,110,25,14,158,79,215,190,68,187,85,103,43,12,72,4,212,165,181,86,25,252,80,171,158,84,189,133,70,138,101,32,105,103,95,69,248,192,49,119,29,141,166,243,253,207,154,52,215,247,52,44,208,248,114,236,239,181,250,124,175,68,226,130,207,93,236,97,13,80,161,150,149,14,156,126,99,239,117,163,116,198,236,48,170,157,119,180,88,145,154,163,213,78,66,82,104,183,133,206,156,122,82,149,171,53,26,53,34,78,26,212,118,146,181,95,188,61,50,93,33,85,141,4,232,38,191,95,234,71,76,22,6,53,65,203,240,10,139,166,213,184,67,47,115,85,38,93,137,12,191,182,0,161,141,79,196,134,65,31,220,51,13,245,100,57,193,225,131,165,93,225,212,31,112,223,84,147,171,116,195,103,120,128,56,169,224,18,114,154,63,88,237,223,31,37,212,41,117,95,55,253,187,97,59,135,191,149,229,65,245,109,148,81,59,167,209,113,197,127,239,251,45,218,66,75,200,88,158,59,137,57,109,7,20,210,85,90,100,178,111,188,189,69,251,203,102,122,45,124,62,116,6,59,97,183,167,208,46,199,251,75,205,198,215,0,151,180,217,232,234,8,194,247,20,128,118,250,44,92,94,6,216,253,166,240,93,225,173,163,146,187,126,184,234,238,224,9,162,69,66,51,226,62,225,121,84,25,103,170,144,214,219,165,253,198,210,2,233,212,31,62,135,158,133,244,15,226,78,254,105,115,253,109,97,223,22,210,116,143,161,35,244,88,115,156,40,172,100,247,191,147,233,6,203,237,146,210,208,218,108,71,151,253,111,180,148,69,52,117,255,11,234,231,246,70,12,239,0,63,214,225,79,3,158,30,224,17,44,58,122,167,86,63,232,120,218,136,178,239,162,37,197,149,253,60,189,54,58,199,175,123,254,226,234,231,176,84,72,131,241,79,251,20,200,222,33,204,18,56,8,134,187,191,199,208,122,1,84,234,171,94,15,100,43,147,241,187,190,113,191,91,78,193,218,54,62,255,1,100,133,228,38,106,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0318491f-8399-4548-852e-806f5f152a57"));
		}

		#endregion

	}

	#endregion

}
