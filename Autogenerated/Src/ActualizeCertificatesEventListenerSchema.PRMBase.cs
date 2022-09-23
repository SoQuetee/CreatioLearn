﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActualizeCertificatesEventListenerSchema

	/// <exclude/>
	public class ActualizeCertificatesEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActualizeCertificatesEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActualizeCertificatesEventListenerSchema(ActualizeCertificatesEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("164c6445-d998-48c4-bc13-fe0265326980");
			Name = "ActualizeCertificatesEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,223,111,218,48,16,126,166,82,255,135,27,123,73,167,42,236,97,79,3,58,81,74,17,211,214,118,13,221,52,77,19,114,195,65,61,5,39,178,29,214,110,234,255,190,179,227,64,28,8,213,94,104,109,223,143,239,238,190,187,139,96,43,84,25,139,17,166,40,37,83,233,66,135,195,84,44,248,50,151,76,243,84,28,31,253,61,62,58,62,106,229,138,139,37,68,79,74,227,170,187,57,87,149,36,54,221,135,81,252,128,243,60,65,185,79,226,27,222,147,212,106,149,138,237,235,151,156,73,253,39,156,172,178,36,156,74,190,92,162,84,245,215,174,197,149,229,247,9,143,33,78,152,82,48,136,117,206,18,254,7,135,40,53,95,240,152,105,84,163,53,10,253,137,19,112,129,18,222,195,32,203,188,171,115,166,144,12,81,152,173,214,107,137,75,10,26,40,5,74,51,161,213,123,184,145,124,77,102,172,179,86,86,28,32,54,239,160,180,52,112,62,94,159,207,198,183,215,119,55,208,135,246,199,244,126,44,211,60,107,119,27,229,167,183,147,241,120,116,107,164,93,108,7,132,47,70,151,179,225,237,245,213,172,162,245,22,222,194,59,248,0,111,224,205,1,205,225,167,65,20,205,174,6,159,71,70,167,154,145,50,77,182,192,7,44,68,223,163,89,52,154,78,39,87,227,29,12,123,83,125,254,52,148,169,168,4,101,115,138,98,94,164,213,157,93,142,47,57,38,243,166,4,59,4,179,216,216,179,230,60,152,119,10,37,213,72,96,108,66,128,89,238,157,95,112,124,35,211,204,128,70,235,60,213,164,132,243,210,189,59,214,61,212,142,150,44,173,37,106,247,95,75,162,206,229,62,32,244,246,108,127,213,86,152,47,130,154,32,244,251,32,242,36,57,41,69,90,59,2,176,102,73,142,133,69,103,210,254,62,31,14,246,51,234,135,180,49,205,235,148,207,97,34,184,230,182,150,23,76,179,160,236,15,114,174,241,81,27,74,152,191,37,180,8,181,159,140,160,20,232,150,239,21,18,4,197,237,243,30,183,187,134,94,240,188,102,18,88,150,209,235,38,39,78,34,36,205,196,80,144,110,127,180,7,86,198,9,181,127,2,83,224,93,21,56,239,234,249,173,154,14,139,65,119,183,91,205,134,72,188,144,29,222,10,121,201,124,109,36,122,67,214,184,35,35,154,40,175,194,49,234,175,166,212,189,162,7,206,2,31,197,105,193,128,166,222,60,221,153,24,149,10,236,233,48,242,70,61,16,163,82,229,228,186,162,149,176,137,193,241,58,178,194,6,52,37,57,216,78,150,211,237,240,219,91,232,29,39,46,71,255,231,99,55,144,23,249,78,115,254,198,110,134,226,181,211,233,64,79,229,171,21,147,79,103,229,197,80,162,25,90,192,196,28,148,219,80,116,130,95,233,61,44,82,9,113,101,178,1,171,206,204,112,99,179,83,55,218,203,152,100,43,16,20,96,191,237,232,217,62,27,61,98,156,91,158,149,140,237,117,172,160,213,115,59,44,93,19,69,248,220,145,234,90,16,105,35,77,155,238,165,190,168,245,175,223,142,174,2,153,95,99,226,99,83,225,247,169,185,170,121,90,94,37,11,165,9,89,186,64,205,120,98,115,216,55,109,183,89,253,97,145,238,161,89,212,36,215,107,92,72,244,120,230,149,191,134,221,53,128,223,21,37,130,18,169,222,32,22,248,27,42,221,105,62,41,2,63,172,93,15,213,189,227,44,243,5,4,175,188,120,46,82,52,26,163,71,250,142,56,132,247,100,51,212,61,245,137,253,194,136,183,31,71,36,31,80,218,78,75,236,39,93,40,167,124,51,239,233,214,117,246,63,232,5,3,16,202,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("164c6445-d998-48c4-bc13-fe0265326980"));
		}

		#endregion

	}

	#endregion

}

