﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTypePostProcessSchema

	/// <exclude/>
	public class EventTypePostProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTypePostProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTypePostProcessSchema(EventTypePostProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56c02107-d8dd-4eec-92f9-a7d0a311d526");
			Name = "EventTypePostProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,75,111,219,56,16,62,171,64,255,3,161,94,100,52,149,209,107,107,171,112,18,111,144,109,138,24,181,187,61,211,210,216,97,43,137,46,73,57,53,138,252,247,37,69,137,38,105,218,77,54,139,230,16,139,243,248,230,201,225,212,184,2,190,193,57,160,5,48,134,57,93,137,244,130,214,43,178,110,24,22,132,214,233,116,11,181,88,236,54,48,163,92,204,24,205,129,243,151,47,126,189,124,17,53,156,212,107,52,223,113,1,213,123,239,44,65,202,18,114,133,192,211,43,168,129,145,124,47,99,219,170,42,90,135,57,12,142,209,93,23,143,74,93,158,75,150,100,190,98,176,150,114,232,162,196,156,191,67,225,136,164,220,112,56,68,35,222,84,21,102,187,172,59,43,25,4,74,3,9,169,130,114,133,209,203,14,45,225,77,179,44,73,142,184,144,62,229,90,236,136,165,232,87,107,205,184,245,9,196,29,45,164,99,179,22,66,51,125,95,90,194,28,28,95,4,69,130,225,252,187,10,157,3,219,146,28,82,163,59,244,149,71,27,204,112,133,106,89,241,113,220,72,121,153,196,90,151,40,206,190,56,231,116,52,108,133,91,93,55,176,45,37,133,242,195,132,150,184,170,200,69,30,32,213,41,81,180,197,12,149,132,239,213,208,24,213,112,143,110,36,109,100,136,89,50,120,223,138,235,114,38,151,231,211,159,144,55,130,50,84,44,205,231,216,179,145,78,107,222,48,184,60,223,147,146,65,111,56,154,131,234,67,36,240,178,132,238,91,155,214,135,196,243,87,43,69,170,127,155,170,78,226,57,17,96,252,139,207,80,124,93,196,131,116,194,61,142,162,250,170,215,133,100,146,21,1,22,224,241,137,180,183,133,67,142,118,139,178,222,222,5,45,160,183,104,177,52,217,87,254,10,75,238,59,108,1,248,108,23,228,47,70,43,63,96,195,188,129,149,184,109,4,176,191,41,241,189,236,133,162,244,54,16,64,155,176,107,62,253,209,224,50,144,79,91,220,206,162,103,240,32,50,215,104,40,240,223,24,246,85,148,56,194,188,235,11,221,135,125,35,170,246,45,84,231,89,109,148,234,134,132,207,128,11,96,201,190,65,247,189,23,221,223,145,18,80,82,176,84,73,89,93,25,69,251,155,0,222,157,216,95,173,238,54,200,63,35,147,94,23,82,76,2,94,129,208,85,255,7,151,13,140,174,26,82,100,129,166,12,34,180,42,65,24,46,152,12,56,115,155,55,128,177,80,115,231,147,108,159,35,238,240,229,78,64,22,106,217,0,216,71,82,23,191,193,9,119,110,0,107,162,167,80,8,107,73,105,153,217,87,15,125,64,73,107,96,128,222,162,119,230,251,205,91,131,235,140,172,116,82,20,137,177,100,140,63,232,95,253,163,255,59,243,209,29,48,103,238,24,212,40,15,39,102,190,255,0,253,153,161,127,160,235,120,29,103,106,110,91,94,253,111,239,197,153,255,34,120,233,178,158,19,110,129,126,134,31,13,240,253,100,23,7,119,72,105,232,218,117,201,187,161,107,162,250,68,238,43,82,94,72,138,90,84,68,219,42,126,205,116,133,227,233,129,190,28,48,11,58,111,239,204,81,67,51,185,9,220,83,86,60,195,86,15,241,24,115,147,13,249,8,187,103,24,211,0,143,49,37,47,229,100,179,249,194,202,103,88,51,24,142,65,244,26,197,67,187,140,31,86,148,85,88,140,191,113,217,184,218,157,64,253,83,169,114,142,57,201,39,141,184,75,14,203,125,22,174,204,224,36,96,247,169,183,180,36,158,221,206,23,241,9,13,147,255,64,85,142,107,25,66,123,177,198,110,215,159,80,211,79,80,18,46,139,51,92,94,65,93,232,133,179,61,107,170,71,244,22,101,187,0,71,23,228,254,234,181,3,0,228,123,205,209,61,44,251,209,228,96,164,39,246,102,189,48,219,210,114,34,203,90,202,80,185,184,40,137,36,142,72,45,178,195,245,89,238,213,27,96,130,128,183,65,155,57,164,90,10,117,101,209,227,99,13,194,228,212,206,81,167,226,143,32,183,56,167,33,254,67,154,221,28,59,249,176,88,79,12,91,237,3,72,62,170,143,10,184,125,248,144,253,166,63,78,77,167,182,223,39,158,96,170,123,241,159,160,209,189,235,207,78,254,195,191,145,182,202,255,242,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56c02107-d8dd-4eec-92f9-a7d0a311d526"));
		}

		#endregion

	}

	#endregion

}
