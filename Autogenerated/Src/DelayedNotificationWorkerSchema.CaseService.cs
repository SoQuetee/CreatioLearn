﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DelayedNotificationWorkerSchema

	/// <exclude/>
	public class DelayedNotificationWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DelayedNotificationWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DelayedNotificationWorkerSchema(DelayedNotificationWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d88f3381-ce5e-4136-ab47-76b6f077f281");
			Name = "DelayedNotificationWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,75,111,219,56,16,62,187,64,255,3,215,5,10,25,48,148,197,30,155,196,139,52,117,10,3,77,218,230,209,30,22,123,96,164,113,66,68,34,29,146,74,226,46,242,223,119,248,144,68,201,146,237,52,233,98,79,182,200,225,112,248,205,55,15,146,211,28,212,130,38,64,206,65,74,170,196,92,199,135,130,207,217,85,33,169,102,130,191,126,245,207,235,87,131,66,49,126,69,206,150,74,67,190,219,250,70,249,44,131,196,8,171,248,35,112,144,44,89,145,249,196,248,109,61,24,238,149,231,130,119,207,72,232,27,143,63,188,239,157,154,114,205,52,3,133,2,40,242,70,194,21,26,70,14,51,170,212,59,242,1,50,186,132,244,68,104,54,103,137,61,224,119,33,111,64,90,225,157,157,29,178,167,138,60,167,114,57,241,223,23,154,101,76,47,73,98,20,144,185,144,228,30,23,144,123,166,175,73,234,180,17,30,168,139,75,61,59,129,162,69,113,153,177,196,235,88,99,195,192,96,93,217,252,69,138,5,72,115,150,119,228,139,213,96,173,92,49,211,14,204,184,210,148,163,31,197,28,39,1,72,34,97,190,63,188,80,32,209,159,220,249,103,184,51,33,122,185,128,184,82,19,90,89,154,217,92,211,254,180,38,14,174,64,239,146,133,100,119,84,3,81,248,97,70,31,157,125,111,128,167,238,8,254,187,244,1,18,68,203,34,209,66,182,78,228,55,238,69,38,26,185,109,31,215,2,128,110,167,25,251,1,132,18,14,247,132,5,136,232,107,8,81,233,221,200,0,100,189,212,131,144,29,89,80,73,115,194,49,114,246,135,69,19,223,201,57,110,100,198,72,82,13,198,123,59,118,197,100,171,147,182,208,110,234,247,48,12,90,66,251,45,177,109,156,113,12,250,90,164,198,15,206,137,222,17,222,163,95,11,144,75,114,176,88,100,203,227,34,211,236,19,229,87,5,189,130,115,200,23,25,10,28,177,76,163,177,78,172,88,164,56,100,255,151,6,6,67,198,186,250,43,254,44,163,46,248,135,99,50,156,230,148,101,229,14,179,116,56,178,170,6,241,140,71,198,159,103,96,178,76,11,32,47,131,82,152,133,138,156,71,195,122,33,14,30,73,145,71,78,177,246,138,205,81,2,137,239,215,32,33,234,219,219,111,239,116,199,95,140,27,1,15,174,162,67,170,224,12,228,29,75,192,210,90,197,167,160,80,202,216,20,158,235,124,145,205,210,177,87,182,186,104,170,52,203,173,224,41,220,22,160,180,149,31,141,70,214,133,3,9,186,144,60,196,239,137,174,21,26,97,130,116,77,216,92,88,221,157,169,76,141,77,100,35,238,60,253,128,50,219,134,68,168,98,56,177,233,120,105,98,176,195,235,141,208,88,81,148,32,92,232,138,137,129,141,176,20,184,89,8,114,101,17,217,115,56,169,73,34,10,174,205,94,14,177,148,72,72,132,76,21,46,41,69,28,203,61,46,228,142,73,93,208,12,115,133,246,72,116,88,57,155,207,244,244,129,41,29,249,195,132,39,28,147,143,5,75,137,179,181,164,255,29,197,4,80,72,137,38,27,228,48,4,204,207,57,203,33,190,208,201,137,184,223,173,196,156,165,40,97,40,238,76,104,81,28,35,163,43,96,202,232,56,3,29,13,75,31,97,24,181,185,26,5,134,196,7,105,122,204,120,161,65,69,158,147,141,218,245,17,244,57,150,135,212,233,248,70,179,2,246,16,154,137,15,217,33,18,179,220,214,199,205,161,243,209,40,158,169,233,45,34,185,18,42,145,71,166,92,119,192,211,142,104,171,150,27,20,44,209,107,5,27,45,52,14,152,116,40,109,238,89,65,100,54,59,41,178,44,234,10,178,120,250,0,9,226,227,39,215,21,28,52,133,216,61,73,78,57,230,70,105,105,107,91,132,208,95,75,236,81,126,117,232,172,18,26,11,173,233,141,208,198,3,165,32,191,188,204,150,95,113,220,4,80,122,236,204,61,193,45,187,24,93,146,216,227,178,17,254,75,33,50,132,127,166,190,22,104,197,103,201,174,24,167,153,69,102,56,34,127,58,31,152,174,67,204,163,233,131,70,55,64,106,103,191,99,15,117,76,19,41,148,183,104,20,59,99,3,91,141,145,228,29,57,179,199,137,167,249,66,47,55,58,230,80,130,9,41,67,165,190,14,237,127,151,199,86,61,120,39,48,173,184,163,156,192,125,184,219,75,167,33,207,149,188,166,5,74,110,100,78,131,50,117,62,195,174,11,123,86,159,207,102,246,163,179,100,99,89,213,162,187,21,104,100,54,159,96,198,164,35,51,180,82,139,149,119,137,170,83,252,169,169,46,84,187,66,204,0,138,238,221,2,56,155,170,218,121,234,231,108,221,152,244,158,85,23,158,92,21,8,85,222,219,142,10,142,6,221,217,116,115,223,178,233,178,179,125,211,66,180,32,28,147,189,77,203,74,32,181,203,62,112,235,22,127,171,240,117,109,125,51,118,51,160,178,180,227,72,200,186,65,44,253,21,245,196,236,51,123,130,62,215,219,158,51,50,104,120,146,252,100,17,183,245,212,255,253,188,0,254,62,19,201,205,207,116,245,255,121,91,237,185,57,39,45,56,13,197,103,234,8,115,109,33,97,202,233,101,6,101,151,114,12,74,97,28,55,110,65,88,214,222,190,37,191,61,75,199,183,63,48,110,188,207,7,149,195,55,222,184,156,164,63,200,99,112,215,138,15,51,161,192,185,194,79,63,185,163,121,249,187,192,175,107,225,155,1,103,250,119,99,219,65,150,121,26,90,224,85,95,132,249,35,78,213,173,143,50,87,82,207,146,107,200,169,77,197,109,134,132,2,62,247,247,5,161,67,191,222,194,100,215,242,118,90,119,161,187,77,99,156,128,47,190,221,107,125,182,141,141,80,80,112,211,45,150,218,232,110,174,155,91,66,41,119,254,191,254,46,169,24,172,119,205,135,35,158,233,213,130,56,117,131,135,34,71,55,50,133,241,104,30,149,108,238,64,80,140,179,49,242,61,234,227,181,122,187,53,185,6,29,85,213,112,57,194,175,64,235,150,43,115,214,83,140,24,136,252,177,218,240,122,66,212,79,149,77,168,48,118,157,131,107,129,118,215,82,43,220,162,165,194,106,3,52,185,38,81,219,0,100,106,143,65,85,50,120,137,91,225,179,175,133,53,200,198,202,254,22,160,197,221,250,130,88,21,151,77,215,187,141,251,184,78,39,164,121,245,62,210,157,226,124,94,244,247,151,110,180,177,24,98,158,121,202,85,162,149,13,69,229,36,48,79,3,47,157,16,27,139,202,150,165,54,31,21,212,76,54,239,155,85,83,179,177,43,177,39,234,160,78,212,14,0,178,186,109,239,45,35,93,213,135,228,93,85,224,73,33,139,12,201,61,113,62,52,31,235,90,220,83,156,191,48,245,211,48,137,236,239,19,131,157,47,244,246,28,134,229,86,192,104,24,117,4,96,232,186,32,0,79,58,46,189,46,192,13,55,236,139,79,235,64,91,60,17,53,47,101,30,41,207,86,211,120,244,233,222,39,191,87,54,12,186,175,125,235,84,63,214,196,95,199,103,52,29,131,142,80,108,136,59,171,188,109,147,141,230,49,185,55,158,194,162,207,83,98,105,206,148,109,164,95,156,232,18,11,170,188,81,147,233,67,2,11,77,230,0,233,37,77,110,176,238,219,206,173,233,60,202,77,67,80,118,132,56,87,205,128,205,174,97,28,148,138,195,72,48,17,224,48,120,66,167,0,85,38,118,75,187,159,160,253,91,243,186,11,237,179,222,204,130,247,43,84,30,213,175,88,230,234,229,12,171,170,35,244,181,125,225,213,203,143,133,67,143,255,2,172,22,41,86,15,28,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d88f3381-ce5e-4136-ab47-76b6f077f281"));
		}

		#endregion

	}

	#endregion

}
