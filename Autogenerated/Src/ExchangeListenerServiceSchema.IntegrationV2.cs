﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeListenerServiceSchema

	/// <exclude/>
	public class ExchangeListenerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeListenerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeListenerServiceSchema(ExchangeListenerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da324162-86d1-4866-8efd-f30356b3f342");
			Name = "ExchangeListenerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("694e66cc-2320-4882-a72b-77a02cf5e28a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,87,75,111,227,54,16,62,107,129,253,15,132,154,131,140,186,114,95,167,108,236,194,73,156,194,139,60,22,113,218,28,130,160,160,165,177,195,86,34,181,164,236,172,27,248,191,119,248,146,37,191,146,160,187,123,104,47,134,53,239,249,56,156,25,114,154,131,42,104,2,228,6,164,164,74,76,202,248,68,240,9,155,206,36,45,153,224,111,223,60,189,125,19,204,20,227,83,50,90,168,18,114,228,103,25,36,154,169,226,95,129,131,100,201,187,117,153,225,213,6,233,156,241,143,27,196,235,25,47,89,14,241,8,173,208,140,253,109,124,198,103,66,230,180,44,65,170,248,152,113,42,23,27,122,40,63,103,9,92,136,20,178,189,204,184,143,145,206,141,217,253,114,183,48,94,9,12,114,202,50,196,161,148,52,209,128,228,57,229,169,218,197,63,189,169,101,59,205,196,152,102,135,135,90,9,83,57,23,211,41,146,87,252,33,47,97,106,177,237,23,44,214,159,114,130,7,80,179,94,63,10,109,100,59,71,66,124,134,222,133,100,219,117,77,140,167,2,127,249,51,94,46,80,112,44,62,57,217,193,28,120,249,65,10,20,86,141,200,87,10,136,213,42,52,228,127,35,97,138,249,144,147,140,42,117,72,6,159,146,7,202,167,112,206,16,102,172,15,135,179,17,237,116,58,228,72,205,16,80,185,232,185,111,163,70,10,41,230,44,5,69,30,97,76,148,85,33,192,211,66,48,94,146,137,144,4,156,93,146,57,195,149,152,132,143,51,80,165,49,226,226,142,189,179,78,205,219,157,11,197,31,221,189,166,245,85,113,9,37,230,83,224,169,140,89,198,202,197,53,218,99,18,114,68,66,69,245,15,93,43,164,75,158,81,209,82,177,35,164,45,237,164,152,141,51,150,144,196,100,186,3,31,114,72,142,169,130,10,173,224,201,32,86,161,123,198,32,75,17,222,15,82,23,180,133,115,3,79,71,0,32,137,132,73,55,28,98,1,134,157,30,97,92,149,148,39,16,87,50,117,92,130,194,218,36,40,84,98,156,18,104,42,120,182,32,90,157,252,145,225,79,151,224,223,11,202,233,20,36,94,251,82,23,54,200,40,92,79,38,108,189,115,97,227,217,217,200,155,105,92,64,249,32,26,121,4,193,206,76,78,48,146,18,107,34,101,170,200,232,2,227,147,186,20,117,53,28,21,84,210,28,147,36,28,155,88,55,4,93,183,10,115,221,145,162,161,24,157,166,66,207,103,64,44,129,96,17,98,83,154,176,132,226,229,82,36,169,218,93,124,212,49,250,43,115,18,202,153,228,170,119,250,154,240,142,58,94,173,137,188,81,69,100,175,17,124,58,206,192,92,68,165,113,141,44,243,238,222,133,216,34,186,41,7,129,181,67,14,194,187,39,43,17,191,199,203,18,133,237,176,237,37,151,247,161,190,193,193,210,30,194,103,1,90,55,150,87,1,109,21,122,166,35,41,130,237,242,179,129,90,133,242,98,80,141,134,1,117,56,224,179,28,164,166,30,25,114,143,88,123,47,130,215,72,226,8,209,105,68,216,19,122,218,139,237,185,54,238,223,105,54,131,8,90,173,245,51,248,44,248,191,22,126,135,190,6,255,223,35,254,18,192,55,161,176,1,24,3,107,8,27,26,233,118,9,159,101,153,97,4,191,56,83,56,198,138,114,97,105,135,120,20,79,70,54,30,205,198,127,34,240,203,54,25,97,155,57,213,174,245,30,129,237,43,47,136,151,113,156,27,100,140,52,3,165,207,164,200,235,124,144,72,100,169,39,93,224,236,192,6,55,76,151,141,19,243,217,205,5,138,186,209,120,46,104,234,214,0,179,29,68,235,4,87,34,24,1,245,233,178,9,137,86,84,59,161,85,60,84,151,152,246,149,52,153,70,45,47,28,232,182,27,223,82,201,163,131,208,57,61,67,65,11,163,62,155,174,11,219,90,67,72,84,34,89,161,47,213,144,79,68,140,89,32,136,162,40,32,37,223,17,46,92,64,164,192,25,4,169,233,211,65,117,6,246,99,105,126,141,99,109,98,155,99,68,224,121,191,237,144,124,107,173,31,132,100,134,83,218,20,207,126,53,92,202,250,105,206,248,111,156,233,115,117,193,162,210,246,219,187,129,99,107,233,83,154,83,105,213,109,7,117,41,24,192,204,170,97,215,166,133,158,98,71,195,193,22,193,94,228,44,109,179,18,239,42,128,218,121,215,139,231,249,57,104,118,3,203,188,187,42,192,46,135,245,21,37,184,195,141,107,200,231,226,47,136,172,26,166,18,126,184,26,221,96,39,58,22,233,98,84,46,50,189,151,160,152,43,225,138,26,223,74,170,75,160,109,18,186,182,139,146,93,176,27,10,150,20,191,87,130,183,201,53,62,10,112,189,135,253,114,102,179,241,171,141,185,27,151,240,104,32,137,252,76,93,161,75,56,242,244,31,95,223,85,149,89,139,81,232,149,9,195,229,124,152,146,12,248,180,124,208,21,240,61,214,195,234,122,35,225,7,123,107,241,223,143,248,175,86,96,63,45,221,228,27,166,166,118,126,94,134,54,241,192,187,143,177,190,16,3,228,199,231,198,65,187,138,204,174,190,85,187,168,49,134,105,237,163,94,168,151,232,214,57,216,62,185,55,221,182,106,85,90,236,47,77,15,226,142,234,44,214,75,178,130,191,194,186,94,136,95,174,182,92,85,125,149,18,115,169,218,119,161,127,54,130,189,137,209,168,196,49,154,147,9,203,204,138,95,171,182,61,221,153,216,185,99,49,181,79,157,72,31,142,164,143,142,189,197,94,96,3,168,94,170,100,60,209,118,224,145,172,49,252,97,5,13,135,227,73,124,10,202,71,31,57,87,45,66,21,89,143,180,222,153,95,217,122,190,192,137,31,83,9,95,243,156,171,193,243,146,249,250,255,131,199,61,221,177,95,149,24,109,237,131,228,181,15,143,143,174,106,236,186,206,62,58,115,59,22,166,143,143,157,213,180,223,102,72,119,211,186,77,183,62,25,156,251,41,78,56,165,176,247,250,110,123,16,210,57,150,182,110,134,27,138,125,207,105,200,227,227,30,204,50,176,33,63,240,28,211,33,117,199,109,40,230,85,54,59,212,92,186,13,165,68,223,230,79,229,134,210,137,165,87,171,132,222,216,182,7,223,92,211,204,182,180,130,214,105,47,9,100,10,26,130,3,41,133,220,34,185,154,9,24,26,183,79,163,151,172,47,245,163,218,53,39,118,90,140,183,85,81,163,112,254,43,215,229,26,38,88,161,15,55,24,37,247,247,68,159,153,175,110,253,191,126,75,28,249,21,39,176,11,252,237,150,60,242,46,174,126,162,63,108,116,245,136,246,236,145,150,90,39,226,227,30,137,255,0,18,178,86,246,210,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da324162-86d1-4866-8efd-f30356b3f342"));
		}

		#endregion

	}

	#endregion

}
