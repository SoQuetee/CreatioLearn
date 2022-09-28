﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventQueueMessageSchema

	/// <exclude/>
	public class EventQueueMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventQueueMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventQueueMessageSchema(EventQueueMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90318f18-5c62-4c7b-a8fa-43a623c58fb9");
			Name = "EventQueueMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,75,111,219,70,16,62,59,64,255,195,66,61,84,2,12,42,105,218,139,99,11,112,108,37,117,16,219,137,101,244,82,228,176,38,135,242,214,124,40,187,75,219,106,224,255,222,217,23,31,34,69,209,138,252,8,144,139,19,114,103,103,231,249,205,12,87,9,141,65,204,168,15,228,28,56,167,34,13,165,119,144,38,33,155,102,156,74,150,38,191,188,248,246,203,139,173,76,176,100,74,38,115,33,33,126,179,240,140,244,81,4,190,34,22,222,123,72,128,51,191,70,243,145,37,95,139,151,39,112,35,145,90,29,246,65,164,73,177,80,22,34,142,219,86,220,70,36,248,149,195,20,15,39,227,36,139,119,200,167,236,34,98,190,94,24,14,135,100,87,100,113,76,249,124,100,159,15,33,100,9,8,114,115,73,37,129,91,234,203,104,78,252,52,145,148,37,130,124,205,32,3,130,38,17,116,10,158,99,49,44,241,152,105,246,4,240,44,50,190,134,68,126,86,91,142,205,142,243,249,12,144,70,89,108,107,63,8,246,179,128,65,226,195,219,249,71,38,36,217,35,47,183,107,43,239,210,40,0,126,20,224,234,171,134,85,22,73,224,184,246,187,94,59,131,56,189,134,26,219,215,141,139,249,222,63,202,203,81,228,40,112,229,79,92,184,51,54,132,36,48,102,172,152,244,32,162,66,236,212,21,93,106,222,183,84,0,57,60,63,37,97,202,113,17,128,248,28,194,189,222,49,229,87,32,209,145,5,171,222,112,212,102,97,95,29,93,63,121,71,31,81,149,69,25,92,169,152,75,141,177,37,121,230,203,148,139,74,64,212,68,214,47,74,228,139,98,215,142,183,66,215,165,54,111,102,148,211,152,36,152,84,123,61,80,123,143,130,222,104,119,168,95,107,42,171,92,141,111,255,125,198,2,98,183,12,200,14,185,64,45,251,3,162,67,105,107,108,222,163,199,44,133,202,11,235,185,69,215,229,86,248,196,211,25,112,201,160,139,13,144,121,26,18,14,17,149,96,229,88,162,167,213,64,203,235,228,250,70,166,32,223,16,161,254,220,181,156,98,149,37,18,243,132,4,247,203,196,229,162,52,166,33,209,127,186,10,118,6,50,227,120,106,196,146,43,212,159,131,159,242,0,133,137,178,56,209,238,108,151,64,72,196,74,245,15,87,80,117,166,119,159,224,46,178,55,210,187,211,176,111,77,53,120,211,238,180,99,144,151,105,208,41,106,57,160,175,132,51,17,65,163,73,170,210,58,228,105,76,62,76,78,79,150,7,106,37,78,45,3,21,169,206,63,44,64,97,89,200,128,123,229,224,173,133,248,191,136,193,189,209,196,168,205,97,198,65,224,70,93,55,84,56,57,239,181,242,224,128,219,65,28,164,89,34,123,163,147,44,190,64,208,210,177,168,223,19,153,146,25,79,125,100,85,82,149,248,10,103,144,202,199,162,112,73,48,105,177,60,164,13,210,114,227,216,209,145,179,14,238,89,145,223,6,121,144,149,219,155,51,131,91,31,102,90,57,179,123,159,79,179,24,25,156,100,81,116,202,199,241,76,206,199,142,164,135,71,230,82,130,90,50,62,217,29,230,92,26,34,168,38,143,117,179,129,135,220,83,219,46,212,148,3,182,209,30,146,148,205,232,96,67,173,122,7,151,224,95,53,72,218,183,129,169,136,6,3,13,40,91,215,148,35,35,145,69,170,170,168,2,235,29,162,71,57,163,17,251,15,118,107,194,141,250,230,252,4,110,52,245,196,145,242,9,72,5,246,194,10,178,165,146,81,37,196,95,52,9,34,37,248,30,89,124,229,97,105,210,196,119,86,24,35,136,167,97,47,215,188,178,116,76,111,49,113,249,92,43,141,84,101,27,56,66,229,66,171,83,25,52,181,63,89,114,137,18,203,32,245,201,176,236,12,172,147,156,99,14,104,195,190,7,89,130,21,132,100,204,233,62,46,12,212,99,115,54,119,41,169,7,151,89,114,69,47,34,232,94,91,27,202,106,165,154,18,134,157,22,145,10,78,115,24,13,217,109,142,103,2,95,43,67,21,25,181,186,254,46,23,147,52,182,5,141,165,152,38,82,33,26,79,37,182,137,16,180,21,8,122,75,146,28,2,10,24,18,42,226,83,142,170,96,238,167,201,170,194,240,143,138,198,163,105,130,59,190,104,191,186,163,149,97,176,101,82,126,181,34,23,205,235,71,22,51,21,69,175,94,190,124,185,2,165,151,55,24,214,120,203,205,86,41,244,219,228,72,53,173,192,21,233,174,90,25,17,145,102,220,135,49,42,46,117,127,55,48,25,100,59,130,188,67,48,137,53,89,32,70,241,23,247,111,188,85,208,231,40,80,211,71,148,157,164,34,139,197,179,148,235,24,211,162,18,234,186,77,93,150,48,122,19,132,160,54,183,89,89,230,125,236,212,41,102,237,223,52,202,202,184,209,244,218,51,190,30,124,41,185,160,110,217,154,177,26,186,131,53,50,25,27,118,237,229,106,91,190,193,140,190,97,242,210,180,76,109,149,75,193,145,87,27,58,58,53,217,171,53,32,237,128,245,112,13,248,106,209,214,233,200,53,75,146,37,12,187,204,206,205,206,98,98,245,70,5,118,168,124,48,235,14,107,127,67,190,194,107,104,253,87,107,180,25,136,216,174,147,89,208,208,157,241,94,115,219,92,143,160,46,248,209,189,107,125,71,149,151,231,136,223,106,135,151,119,177,170,133,176,152,46,76,192,187,217,2,83,28,219,114,3,57,214,196,26,121,16,172,114,191,31,133,88,246,160,84,57,44,97,25,155,152,32,83,125,24,87,37,50,169,12,167,141,165,0,3,11,109,56,139,152,20,170,96,164,36,132,27,119,160,19,245,222,145,215,52,103,117,142,186,66,192,222,232,59,80,120,121,151,92,13,232,123,167,97,181,101,174,118,182,229,40,94,205,109,84,233,123,93,68,155,48,111,207,135,66,5,213,169,233,29,205,203,134,153,55,81,14,62,77,52,186,137,126,115,36,12,28,45,168,183,125,195,79,239,208,3,30,134,110,135,164,94,72,75,189,221,101,36,78,248,66,178,88,197,196,89,122,35,92,63,91,162,244,244,187,190,149,228,206,73,116,158,238,115,78,231,253,37,99,101,199,242,181,248,53,234,25,212,46,247,89,108,205,250,85,215,227,30,237,234,3,21,174,186,76,143,86,186,66,103,205,145,17,98,197,254,165,149,170,174,194,66,173,210,79,238,180,252,51,214,66,211,218,189,254,184,40,48,195,92,233,83,105,88,94,216,100,115,123,144,15,78,198,80,168,78,213,175,74,67,79,15,208,203,189,183,209,62,86,155,52,87,253,161,90,86,243,177,248,57,36,190,22,100,221,180,175,105,241,12,210,190,38,211,163,165,61,136,175,249,39,25,228,81,252,159,224,138,106,14,66,115,69,96,91,214,142,24,80,211,103,1,3,236,167,169,202,225,27,128,2,125,172,1,130,113,153,181,250,40,94,126,222,56,36,148,142,26,79,62,123,5,68,168,239,121,246,115,11,246,147,23,234,139,182,40,104,169,40,56,230,225,81,220,98,157,100,12,251,9,126,205,124,56,78,3,136,188,67,42,169,98,205,177,67,182,157,6,90,132,63,22,204,88,175,85,77,187,25,180,49,55,79,207,102,70,110,186,68,235,132,55,157,244,120,178,73,185,147,116,189,225,232,81,144,103,67,179,114,39,157,158,116,92,110,10,166,167,154,152,223,102,209,213,56,166,44,250,57,53,175,55,53,115,237,76,243,165,178,58,55,175,49,50,119,205,199,206,83,115,39,134,63,218,224,220,45,195,31,101,118,110,189,24,142,233,173,190,94,154,219,59,20,5,190,238,58,210,94,166,168,194,218,18,216,206,201,199,85,78,211,102,255,215,174,160,202,87,93,230,18,234,245,250,51,127,163,213,159,114,4,104,254,237,202,250,85,249,233,7,129,142,98,253,72,179,64,71,149,30,106,28,104,142,145,159,19,193,51,155,8,58,180,56,165,123,247,37,160,224,45,66,94,175,253,130,254,1,208,113,63,138,42,161,254,164,192,88,252,106,239,30,152,216,166,193,211,192,97,73,143,199,0,193,10,110,181,89,163,249,215,119,107,128,83,161,223,247,13,1,207,44,67,240,221,255,211,202,52,18,41,44,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90318f18-5c62-4c7b-a8fa-43a623c58fb9"));
		}

		#endregion

	}

	#endregion

}
