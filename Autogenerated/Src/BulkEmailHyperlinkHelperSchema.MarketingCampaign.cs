﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailHyperlinkHelperSchema

	/// <exclude/>
	public class BulkEmailHyperlinkHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailHyperlinkHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailHyperlinkHelperSchema(BulkEmailHyperlinkHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f613781-62f6-43a2-8e19-4e27f4fcc96f");
			Name = "BulkEmailHyperlinkHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,75,115,219,54,16,62,43,51,253,15,8,51,147,161,18,13,213,30,122,241,67,169,45,201,177,166,150,237,241,163,57,196,153,14,69,65,18,26,62,20,0,180,173,177,245,223,187,0,8,16,164,64,201,110,59,189,88,38,184,88,236,227,219,221,15,76,195,4,179,101,24,97,116,131,41,13,89,54,227,65,63,75,103,100,158,211,144,147,44,253,233,205,211,79,111,90,57,35,233,28,93,175,24,199,201,126,237,25,228,227,24,71,66,152,5,159,113,138,41,137,54,100,206,72,250,99,99,241,6,63,242,224,10,207,243,56,164,195,199,37,197,140,9,37,165,156,109,83,146,100,169,251,141,101,109,48,14,211,41,37,113,124,141,233,61,137,176,123,3,109,92,15,6,199,229,171,83,206,151,183,156,196,132,175,208,161,182,249,11,158,4,214,11,144,6,249,119,20,207,225,116,20,197,33,99,123,232,56,143,191,15,147,144,196,167,171,37,166,49,73,191,159,226,24,254,147,178,203,124,18,147,72,137,110,145,108,61,73,105,163,26,220,100,60,76,57,168,191,164,228,62,228,88,189,239,118,187,232,128,229,73,18,210,85,79,47,128,48,15,35,142,200,20,167,156,204,8,166,104,25,82,72,53,135,255,82,248,13,204,214,174,189,119,169,52,163,72,28,134,24,167,34,12,133,178,209,244,82,171,56,135,31,136,136,23,233,55,222,254,22,99,132,143,8,11,39,17,197,17,89,18,176,233,191,177,204,68,239,74,235,117,24,57,113,8,105,123,223,97,64,139,140,111,115,176,101,186,94,23,235,36,140,104,198,154,60,41,242,239,12,241,88,238,212,166,247,47,206,111,142,250,55,127,142,6,255,42,192,175,54,199,21,87,109,211,213,176,63,186,28,13,207,109,171,154,194,56,198,124,145,77,235,136,213,169,132,8,115,56,249,62,35,83,212,143,113,72,55,139,129,249,159,115,120,107,82,56,154,118,208,45,195,20,226,149,170,142,131,242,202,99,27,137,110,213,106,221,135,20,77,113,12,56,0,155,83,252,128,6,242,193,175,73,75,217,86,112,66,179,196,247,54,143,247,180,192,151,5,166,216,146,0,4,181,131,17,27,254,200,195,216,135,246,151,39,105,96,128,231,91,230,182,219,251,82,133,178,37,24,62,226,40,7,51,212,234,218,25,143,73,150,197,232,52,100,10,10,126,145,146,133,176,9,154,232,119,237,97,37,97,42,195,151,33,135,227,83,240,248,55,239,238,235,187,224,227,167,119,119,223,188,125,19,16,37,5,253,22,63,22,81,145,255,251,149,221,29,181,120,177,84,253,252,60,75,113,225,3,197,60,7,237,150,22,8,193,56,228,209,194,47,173,179,29,115,130,245,104,58,101,101,201,51,196,51,4,109,117,25,139,8,28,200,117,138,103,178,19,28,122,18,2,94,183,215,0,93,185,34,183,84,228,123,55,90,159,124,14,14,186,82,166,231,136,245,128,72,28,128,194,3,21,201,78,17,209,30,26,103,83,50,91,105,85,103,18,140,163,97,154,39,152,134,147,24,31,104,57,121,134,13,59,152,98,121,204,153,198,93,227,9,5,8,90,51,24,59,97,180,64,58,211,66,33,34,105,85,113,75,39,90,88,69,240,84,216,3,39,8,153,253,138,128,28,33,34,130,135,104,12,8,132,37,53,168,8,102,2,161,12,159,242,36,22,2,127,132,113,142,125,91,95,97,79,139,204,144,255,86,169,131,4,159,231,113,124,65,135,201,146,175,124,173,188,141,148,100,171,245,254,61,50,171,193,53,15,41,103,95,8,95,248,222,2,70,228,94,183,235,181,209,243,51,106,148,96,82,164,109,188,212,94,76,113,148,77,149,85,133,51,214,200,13,132,11,3,41,225,219,203,183,84,175,26,59,181,75,174,240,21,138,1,143,166,114,217,77,38,222,248,181,227,141,22,71,244,129,190,0,64,34,124,66,40,227,35,57,53,34,124,49,51,38,116,54,44,31,166,210,198,186,41,198,214,181,250,41,96,244,85,40,250,6,135,217,242,74,114,109,87,101,33,254,79,202,207,85,117,175,44,58,175,119,157,229,52,82,21,87,41,56,41,174,108,100,189,113,225,131,22,211,235,142,202,44,18,230,202,142,133,116,187,238,44,167,118,149,158,134,219,83,3,183,233,160,207,152,159,100,52,17,45,177,152,201,190,99,70,183,209,186,163,53,237,228,34,78,165,77,147,22,52,171,28,87,90,175,145,190,165,68,241,196,160,22,32,120,33,161,215,177,194,177,187,39,23,24,102,141,13,88,244,163,250,59,221,181,143,179,233,234,21,112,169,108,43,91,245,4,30,55,129,227,104,238,103,27,61,221,13,49,94,211,188,27,107,69,20,228,1,163,84,91,166,225,102,219,221,65,163,45,224,170,52,238,34,115,106,18,29,205,231,192,140,132,210,138,54,5,33,63,202,41,5,0,116,10,100,31,246,80,177,162,123,140,204,108,240,59,94,41,145,64,182,240,14,186,150,231,194,5,9,66,66,24,220,129,70,41,212,3,1,250,218,135,150,144,83,60,154,167,48,99,250,33,195,237,151,96,65,198,9,205,52,82,183,211,199,141,52,37,166,58,188,158,2,185,162,245,141,25,59,169,31,244,146,92,57,74,169,66,133,84,13,85,82,80,76,52,181,205,247,62,60,63,253,188,126,254,224,117,236,29,118,116,118,147,90,235,102,80,176,104,155,210,94,135,247,248,101,140,214,137,48,73,3,169,74,124,129,144,23,49,95,49,189,139,109,102,172,54,178,235,138,25,53,125,246,144,17,74,157,140,192,182,185,28,227,42,226,70,129,252,221,86,49,11,99,209,118,218,82,26,94,57,183,198,163,160,64,100,101,92,134,132,54,31,37,90,90,121,174,49,157,211,149,33,35,194,235,146,136,27,97,81,129,22,101,17,76,156,147,52,199,154,37,172,93,92,6,200,73,141,197,148,116,165,170,185,70,89,114,185,241,150,39,69,195,191,194,73,118,143,225,89,92,90,68,187,55,250,235,59,163,80,114,120,216,237,76,93,121,170,140,86,27,125,146,103,237,161,218,11,173,117,183,31,176,61,128,25,157,61,192,29,168,164,94,18,239,139,144,45,10,214,180,145,95,168,229,241,224,87,8,244,66,136,58,252,17,211,125,178,129,222,98,202,111,194,186,126,201,211,106,28,0,204,38,127,129,80,79,220,126,167,68,94,120,154,185,131,150,53,121,127,66,229,133,16,218,136,85,75,134,22,72,33,225,25,188,55,33,208,248,88,239,91,56,123,187,233,96,112,130,225,110,37,210,60,56,246,75,11,109,232,57,54,93,99,62,192,51,117,39,149,249,99,190,137,128,75,222,186,211,130,239,150,19,219,54,245,13,180,10,144,109,19,86,144,1,112,108,19,18,65,2,41,29,164,109,162,162,177,150,62,21,209,92,131,37,92,84,255,240,49,194,202,184,178,255,181,54,48,119,150,205,131,33,165,25,45,198,129,62,206,251,218,244,69,46,104,232,231,223,246,144,84,132,30,22,36,134,49,21,222,87,190,160,148,223,18,208,71,115,8,186,243,96,248,220,121,98,200,150,162,232,1,238,69,104,52,221,67,79,191,172,1,48,48,218,77,41,86,224,85,189,41,172,119,79,116,209,49,24,194,143,156,134,54,77,246,205,247,59,20,166,214,76,178,184,104,27,205,0,127,136,47,48,36,144,188,148,3,48,121,25,128,230,228,245,224,79,243,232,87,47,43,211,190,50,71,13,49,19,14,12,133,249,37,215,213,237,175,144,49,71,214,166,190,131,50,43,117,14,77,90,69,167,233,90,160,194,190,147,233,239,38,89,5,75,221,36,220,255,7,169,126,29,85,118,37,164,250,109,196,197,144,117,22,206,8,227,230,83,9,92,141,23,25,29,198,56,129,152,109,31,245,71,182,168,107,218,111,97,19,246,77,89,158,226,248,146,83,53,165,250,129,171,225,30,80,165,103,149,67,182,241,70,181,90,93,132,181,191,1,21,121,203,161,120,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f613781-62f6-43a2-8e19-4e27f4fcc96f"));
		}

		#endregion

	}

	#endregion

}
