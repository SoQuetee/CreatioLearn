﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarEditPageChangesStoreSchema

	/// <exclude/>
	public class CalendarEditPageChangesStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarEditPageChangesStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarEditPageChangesStoreSchema(CalendarEditPageChangesStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91248fd0-2062-41d4-80a9-84ae90d77069");
			Name = "CalendarEditPageChangesStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,90,221,111,219,54,16,127,118,129,254,15,92,10,20,10,96,40,91,247,150,196,30,218,52,13,12,180,77,55,119,235,195,176,7,70,98,28,173,178,156,82,84,186,172,201,255,190,227,151,68,82,164,36,59,110,26,172,121,136,37,234,120,188,207,31,143,39,85,101,86,44,208,252,186,100,100,121,240,248,81,101,220,198,71,171,60,39,9,203,86,69,25,159,144,130,208,44,113,73,94,103,197,167,122,236,61,161,20,151,171,115,6,51,41,9,12,199,199,5,203,88,70,74,120,254,248,81,129,151,164,188,196,9,177,168,138,243,108,81,81,204,87,126,252,232,11,167,27,61,161,100,1,183,232,40,199,101,185,143,142,112,78,138,20,211,227,52,99,239,240,130,28,93,224,98,65,202,57,131,21,4,253,222,222,30,58,44,171,229,18,211,235,169,186,127,162,255,60,87,205,144,115,27,107,102,123,6,183,63,231,96,12,156,103,255,226,179,156,252,5,3,151,213,89,158,37,40,225,210,245,8,55,2,133,70,181,62,199,69,181,4,117,4,69,58,103,152,85,165,144,191,165,64,64,3,228,83,70,8,221,150,186,45,182,150,155,128,20,174,16,35,41,232,232,148,102,139,172,192,57,154,160,31,199,98,228,45,249,12,55,63,201,27,53,11,6,158,201,129,151,36,39,76,12,252,204,239,111,165,58,79,192,34,82,101,117,111,251,243,5,46,149,153,210,211,179,191,33,232,250,141,32,127,199,65,199,233,75,52,212,203,235,24,12,159,149,140,226,132,41,143,123,196,215,230,171,21,133,44,98,180,74,32,8,246,209,59,186,98,64,69,82,169,230,232,82,223,183,57,69,187,72,50,26,89,254,1,243,90,247,177,118,211,129,32,86,86,111,153,189,22,7,36,184,36,148,231,33,72,35,116,82,4,45,147,135,82,167,185,142,155,137,150,245,180,177,108,193,237,187,47,104,65,216,1,42,249,191,94,161,223,16,118,177,74,203,46,251,213,142,153,9,156,185,150,70,68,39,132,153,247,209,238,65,120,38,252,112,216,170,167,204,147,11,178,196,111,1,169,154,105,3,68,220,200,168,118,112,219,89,222,152,217,245,66,7,39,43,244,235,155,125,131,193,94,251,42,232,80,49,116,137,41,94,34,142,220,147,157,170,36,20,34,187,144,219,196,206,244,112,79,60,181,220,127,181,202,82,52,199,87,36,250,221,162,70,246,228,58,206,109,207,17,243,102,226,117,36,159,164,156,86,214,190,50,105,29,15,10,250,207,25,75,46,80,100,69,99,45,194,40,129,52,116,18,76,225,218,126,77,51,186,194,20,145,242,19,172,84,0,34,154,75,253,90,17,122,29,217,250,197,38,193,27,92,192,198,64,199,134,192,90,178,209,8,120,198,207,211,244,121,158,75,98,216,135,171,101,81,70,13,133,100,165,108,3,235,243,25,181,182,206,186,99,203,132,241,44,109,216,100,231,40,82,60,126,0,37,170,60,111,44,0,98,136,39,74,111,99,241,91,117,161,127,71,103,148,224,143,7,97,203,193,126,97,88,205,149,189,223,74,92,181,25,160,39,46,18,242,226,90,184,209,48,91,45,111,124,4,114,48,226,53,130,97,92,169,213,156,176,151,228,92,90,246,15,156,87,196,52,175,101,176,87,89,158,43,158,114,124,55,22,193,92,147,15,182,131,186,251,222,34,104,168,29,187,3,235,54,184,175,13,173,49,94,226,235,89,161,107,179,181,138,141,96,145,129,106,112,246,128,241,214,138,13,89,99,132,197,71,222,250,169,187,0,49,119,39,181,76,120,129,200,122,164,22,77,205,177,177,179,173,39,94,88,117,43,24,139,74,249,217,90,10,104,172,101,238,177,184,105,109,157,142,255,58,234,29,159,181,108,181,124,85,79,143,108,142,68,168,95,140,147,10,246,93,153,113,179,84,187,0,214,133,213,41,97,21,45,108,161,32,175,133,48,67,12,60,160,16,91,93,193,129,46,75,73,95,33,166,5,243,137,100,187,219,195,187,171,84,115,24,239,88,156,119,194,145,52,20,78,222,103,75,50,43,24,161,87,56,223,34,154,180,134,190,22,158,4,229,223,18,156,4,249,71,31,86,244,35,184,205,36,80,43,127,110,63,25,35,31,118,108,142,47,158,197,129,210,179,240,183,195,26,191,131,59,50,61,108,80,159,182,15,4,124,60,162,61,12,8,242,8,182,85,32,242,240,191,19,28,53,137,232,132,160,62,126,119,180,163,106,233,0,29,75,85,134,190,206,74,118,24,46,6,166,186,98,211,194,91,243,130,89,175,167,245,104,19,74,167,129,237,48,79,73,22,64,71,101,156,62,101,145,48,140,74,153,75,154,93,193,9,195,74,157,245,4,115,7,7,8,23,182,40,106,60,208,33,96,200,210,70,2,137,73,42,102,20,7,113,104,255,141,44,33,194,213,162,194,72,106,189,168,163,24,133,130,77,7,85,77,31,75,78,112,30,137,50,52,153,162,44,246,101,191,197,20,80,99,34,170,191,88,163,136,21,63,90,206,25,111,160,18,202,183,184,67,79,221,53,229,41,217,40,80,70,2,151,146,122,13,45,105,83,125,148,241,135,11,2,137,145,114,57,83,91,166,216,22,174,97,131,158,62,85,219,84,148,198,206,46,228,54,234,120,247,244,230,6,245,210,169,187,93,125,192,133,35,43,239,198,123,5,27,148,90,222,214,212,144,240,245,157,114,186,227,183,213,39,2,63,238,76,155,185,102,155,200,236,18,193,153,21,204,3,170,133,78,28,6,92,133,226,143,252,3,89,35,188,13,184,36,28,58,135,64,203,201,41,133,3,63,174,242,218,130,245,238,164,226,172,62,215,138,67,109,195,197,61,216,10,158,50,160,13,178,221,26,194,53,9,40,19,113,92,236,56,87,193,178,227,118,120,236,90,238,220,28,249,238,226,166,65,190,106,18,171,207,95,188,209,145,56,213,153,55,220,15,190,185,123,93,49,27,210,33,153,173,146,245,151,240,163,253,46,197,183,30,92,118,161,188,81,96,109,61,174,250,194,74,170,63,36,172,190,101,156,132,55,199,150,223,186,189,234,44,52,32,202,154,30,155,220,183,220,22,217,221,16,72,53,186,215,15,150,187,190,158,108,133,77,166,203,227,105,128,125,247,62,162,61,210,113,224,212,43,104,139,134,15,197,202,65,198,153,177,169,110,220,200,82,53,142,25,89,89,115,196,105,135,87,205,212,141,49,183,128,114,39,88,184,208,16,107,191,135,143,224,89,125,186,222,234,238,179,109,151,123,161,168,199,241,74,161,13,156,191,230,38,245,192,98,37,176,111,213,213,245,61,108,94,247,16,174,219,218,207,190,114,204,174,23,178,106,195,251,110,240,202,199,107,59,219,222,54,48,112,227,253,47,116,53,86,225,85,55,126,67,113,103,53,220,208,58,33,200,223,146,164,50,254,198,6,35,119,95,54,175,205,120,108,241,43,87,21,77,136,105,187,178,137,110,159,142,45,110,210,69,165,1,227,225,169,154,214,72,13,243,92,31,76,135,41,156,105,233,162,17,81,158,238,133,45,228,183,72,3,185,120,180,213,177,38,90,48,235,77,229,83,32,221,60,79,226,247,43,254,176,249,140,164,175,193,147,216,123,25,164,133,155,103,178,89,177,118,83,5,178,218,20,198,49,21,55,99,123,241,89,106,244,212,13,48,145,109,9,7,67,20,215,128,121,140,126,16,227,243,60,75,241,207,0,25,206,138,50,18,111,156,123,248,113,16,229,44,34,107,47,12,152,105,248,78,120,115,211,79,174,251,52,142,33,60,190,208,74,168,102,83,64,151,77,81,7,173,7,54,254,235,161,120,211,180,190,140,77,111,108,125,99,212,198,158,78,196,129,160,116,32,102,13,72,233,133,16,111,107,80,128,199,7,66,62,250,58,131,227,254,249,92,100,11,39,130,84,10,18,248,165,147,118,225,121,73,211,181,212,105,239,244,50,141,54,166,219,180,100,68,252,227,209,202,127,121,144,197,111,50,249,165,203,224,204,135,69,78,207,185,125,172,204,151,103,105,183,23,169,9,21,79,173,180,145,232,169,145,232,38,231,38,209,109,70,46,167,58,197,13,57,236,132,210,164,119,219,183,229,245,255,38,141,58,169,207,233,106,201,227,67,207,240,190,174,24,187,163,157,44,217,202,96,184,33,191,175,146,232,122,208,159,236,173,76,8,230,242,184,206,40,164,205,103,12,73,245,31,56,42,76,39,181,232,252,205,133,249,232,112,162,85,232,64,9,173,173,33,14,35,125,16,193,200,80,108,0,94,54,40,40,225,238,5,18,116,160,58,95,91,120,209,64,223,117,165,123,71,29,28,224,214,27,227,18,164,79,248,23,140,226,164,194,213,6,32,141,122,95,102,245,84,50,250,224,227,184,206,251,254,109,13,92,117,32,114,40,54,186,159,22,187,214,211,127,161,115,53,255,184,80,189,234,30,246,225,177,176,215,171,21,61,198,201,133,214,93,124,161,232,144,187,175,191,215,152,35,150,56,202,9,166,173,151,232,214,176,231,77,158,26,51,135,110,255,3,181,205,209,142,189,51,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91248fd0-2062-41d4-80a9-84ae90d77069"));
		}

		#endregion

	}

	#endregion

}

