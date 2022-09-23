﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillRecipientsHandlerSchema

	/// <exclude/>
	public class MandrillRecipientsHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillRecipientsHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillRecipientsHandlerSchema(MandrillRecipientsHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b342e64-49fc-4ec9-bf50-dddee0295296");
			Name = "MandrillRecipientsHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d25f34fe-c5f7-43c4-95a5-0f83015bba7e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,77,115,219,56,12,61,43,51,253,15,88,247,98,183,30,57,233,116,122,200,215,78,146,205,182,222,78,58,105,147,246,186,195,72,176,205,93,153,212,240,195,219,52,237,127,47,72,81,178,168,200,137,179,211,155,9,10,192,195,195,3,76,193,150,168,75,150,33,92,163,82,76,203,153,73,207,164,152,241,185,85,204,112,41,158,237,220,61,219,73,172,230,98,30,125,162,240,96,131,61,189,202,22,152,219,2,213,250,139,143,150,41,243,141,206,100,121,174,112,78,129,225,172,96,90,239,195,5,19,185,226,69,241,9,51,94,114,20,70,191,35,11,121,251,143,39,147,9,28,106,187,92,50,117,123,28,206,225,30,102,82,129,89,32,44,67,4,80,77,136,180,118,157,180,124,75,123,83,240,12,50,151,119,115,90,216,135,83,166,241,130,241,130,144,55,88,146,59,143,103,141,94,10,109,24,185,237,195,165,226,43,102,176,186,47,171,3,100,238,30,184,48,240,7,206,152,45,204,84,24,84,43,86,192,17,188,122,125,208,247,177,54,202,113,117,166,164,56,255,90,42,212,218,37,58,130,193,46,236,194,30,236,77,246,224,5,252,14,47,6,142,215,164,63,217,5,23,214,160,158,138,119,210,42,242,125,179,27,82,61,71,170,215,67,143,235,184,84,178,68,101,56,250,66,164,193,204,96,30,163,11,184,254,46,149,204,8,212,7,146,140,67,117,146,25,203,10,254,13,79,109,241,239,249,146,248,90,115,89,65,44,235,120,32,87,36,17,158,55,177,46,91,161,156,190,146,100,142,6,238,20,26,171,68,148,233,224,135,187,254,209,143,232,31,121,243,43,208,252,21,194,244,32,9,25,34,20,155,168,188,64,179,144,249,38,65,184,238,188,197,70,6,195,207,26,21,137,72,16,36,231,108,163,227,40,96,89,49,229,28,107,225,12,233,247,168,51,109,209,180,166,87,183,250,10,141,161,170,116,74,217,190,176,194,226,48,142,61,246,145,147,193,37,42,46,243,7,121,27,121,226,18,62,243,153,43,20,135,71,164,198,239,223,215,176,142,187,10,175,193,39,45,228,157,79,170,184,158,212,36,80,205,219,87,157,126,79,221,76,92,43,62,159,211,124,254,201,69,222,58,15,219,92,153,202,246,30,111,41,167,192,255,224,186,49,12,235,46,191,132,65,176,14,198,174,245,111,149,180,165,187,9,213,6,60,39,101,217,44,178,116,234,135,61,67,199,105,157,119,157,107,4,76,71,24,251,106,112,253,167,38,144,244,140,155,77,125,45,195,172,58,106,97,225,76,117,37,1,129,183,209,200,71,51,221,23,122,37,121,78,107,3,233,183,3,65,53,109,167,46,215,215,169,174,171,204,201,239,252,43,215,70,15,71,77,11,63,225,146,166,165,46,127,56,106,55,46,172,200,134,165,207,134,206,110,147,164,49,150,142,252,58,11,110,92,143,95,220,140,160,210,164,181,41,198,32,108,81,140,97,198,10,77,7,163,108,104,217,102,58,218,181,61,133,147,0,253,73,116,52,109,108,109,250,246,192,119,242,29,52,78,75,223,223,226,182,229,215,47,148,40,122,8,240,88,19,250,26,208,79,120,123,41,7,246,187,200,182,237,192,141,148,5,52,44,110,73,252,255,161,47,76,202,176,227,120,111,223,60,132,178,79,255,241,32,222,223,56,148,193,49,241,120,237,219,6,252,237,126,192,199,255,102,252,123,166,186,236,190,147,188,161,82,128,166,213,83,233,21,228,204,63,152,22,213,163,38,109,28,39,93,207,195,146,41,182,4,65,82,56,26,196,204,15,142,167,173,112,238,206,61,63,194,101,122,56,241,158,62,80,120,111,53,255,182,173,185,108,38,104,43,105,120,74,121,77,41,233,98,45,173,254,161,114,255,87,245,39,205,236,62,180,148,234,65,6,36,97,199,14,209,10,233,247,218,220,180,202,26,27,201,246,19,114,253,78,5,118,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b342e64-49fc-4ec9-bf50-dddee0295296"));
		}

		#endregion

	}

	#endregion

}

