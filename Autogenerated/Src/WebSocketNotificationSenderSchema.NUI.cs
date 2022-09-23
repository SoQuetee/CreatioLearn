﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebSocketNotificationSenderSchema

	/// <exclude/>
	public class WebSocketNotificationSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebSocketNotificationSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebSocketNotificationSenderSchema(WebSocketNotificationSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dbf82f63-6b83-4a3a-bf0c-9e269fb22dab");
			Name = "WebSocketNotificationSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,219,110,219,56,16,125,118,129,254,3,225,162,133,12,164,250,128,100,189,64,226,216,169,176,73,54,27,59,232,99,192,136,99,153,136,76,122,73,42,173,176,240,191,239,144,162,108,234,230,162,69,95,12,115,102,56,151,51,103,134,18,116,11,122,71,83,32,43,80,138,106,185,54,241,76,138,53,207,10,69,13,151,226,253,187,255,222,191,27,21,154,139,140,44,75,109,96,123,209,58,163,125,158,67,106,141,117,124,3,2,20,79,59,54,183,92,252,123,20,134,177,20,244,203,183,91,41,250,52,119,160,53,205,80,118,180,65,171,15,10,50,76,128,204,114,170,245,57,249,10,47,75,153,190,130,185,151,134,175,121,234,74,89,130,96,160,156,249,174,120,201,121,74,82,107,125,202,152,156,147,36,148,126,161,130,229,214,199,200,162,114,140,138,165,27,42,12,70,126,80,252,141,26,112,81,70,187,234,64,82,171,39,218,40,135,200,252,254,122,254,72,166,100,28,122,78,196,90,142,171,90,70,31,48,118,229,217,159,125,152,5,135,156,13,197,80,64,153,20,121,73,238,116,54,219,80,33,32,191,163,130,102,88,196,115,218,56,95,244,94,243,217,61,191,72,86,174,202,29,220,35,51,26,150,79,26,20,22,42,170,86,147,231,162,113,254,65,234,14,33,85,104,35,149,45,192,193,239,243,175,90,113,162,9,81,43,114,51,240,228,156,152,13,215,81,83,122,230,235,137,231,219,157,41,39,196,181,107,255,123,34,214,190,73,8,149,15,49,106,193,130,109,238,224,100,173,154,29,65,171,78,215,226,196,113,42,5,127,35,12,134,246,157,54,237,79,55,224,14,204,70,14,146,39,57,134,39,55,96,112,104,47,217,150,139,39,193,141,23,71,55,5,103,68,7,138,186,98,5,166,80,162,77,178,120,193,5,75,112,244,175,202,167,132,69,141,139,97,190,117,6,215,248,179,226,88,218,163,44,4,115,39,185,4,28,28,166,163,131,142,225,159,165,44,84,10,173,224,71,69,124,201,216,138,167,175,58,178,55,150,59,42,98,119,124,0,85,185,35,159,73,20,152,59,37,249,72,6,172,39,167,147,69,172,110,169,54,143,128,165,49,43,233,194,148,176,58,215,55,170,66,205,193,201,148,132,12,124,50,60,231,134,131,221,165,141,70,220,202,148,230,245,165,232,185,195,201,102,204,139,16,158,30,76,123,18,233,45,181,189,163,30,241,185,192,89,118,165,15,233,162,100,46,138,45,40,250,146,195,31,73,219,234,79,34,2,137,14,209,73,49,79,3,74,35,36,13,155,248,235,6,20,68,56,77,120,57,190,81,178,216,89,222,199,137,70,231,110,194,163,201,196,121,25,85,218,171,178,99,92,235,151,96,31,171,40,179,114,103,2,223,124,6,163,145,19,198,127,65,121,230,5,51,155,16,102,83,41,220,41,242,142,246,147,120,37,175,185,67,159,170,50,250,110,157,125,119,151,137,255,239,236,39,126,51,186,2,197,16,154,83,151,199,32,216,62,193,217,17,159,26,42,159,105,120,179,3,159,51,217,87,140,224,107,210,230,142,37,90,162,23,64,145,43,48,23,182,107,44,26,227,10,180,196,88,72,213,240,253,79,1,170,28,79,200,167,79,173,22,93,10,219,132,58,211,161,66,227,230,184,144,169,7,186,59,72,77,239,11,174,52,66,31,47,59,123,196,18,246,200,244,161,184,125,212,182,75,207,210,184,222,187,238,195,162,103,130,207,134,251,178,173,238,92,225,50,14,121,236,197,190,171,75,190,221,229,224,221,215,0,37,12,181,141,40,149,220,186,66,77,224,216,43,190,224,67,237,94,138,154,172,254,11,101,234,63,40,106,202,94,53,223,137,198,187,225,153,27,242,193,227,230,227,245,193,244,38,17,15,27,108,16,160,132,253,28,68,225,107,227,95,13,204,116,224,221,233,221,107,150,197,135,155,136,114,145,231,7,234,85,21,133,220,112,141,62,246,164,219,242,118,49,97,206,149,35,31,44,126,144,218,212,183,188,213,228,231,158,223,238,167,143,3,184,250,178,252,165,205,217,156,148,217,6,210,215,75,149,161,27,97,238,17,152,191,85,181,33,199,13,187,177,47,172,189,149,220,190,236,46,224,122,171,102,118,179,101,125,99,184,198,47,121,154,110,72,212,235,145,112,209,19,230,208,179,96,104,252,0,156,122,94,58,142,112,19,223,114,187,31,124,46,163,144,174,93,107,183,163,187,61,222,15,244,209,203,154,173,221,255,15,71,147,5,148,58,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dbf82f63-6b83-4a3a-bf0c-9e269fb22dab"));
		}

		#endregion

	}

	#endregion

}

