﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WeekHelperCalendarEditPageSchema

	/// <exclude/>
	public class WeekHelperCalendarEditPageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WeekHelperCalendarEditPageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WeekHelperCalendarEditPageSchema(WeekHelperCalendarEditPageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16d259fa-db24-4b5d-9c2a-21f1b7873908");
			Name = "WeekHelperCalendarEditPage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,91,79,27,57,20,126,14,18,255,193,13,18,154,72,209,240,94,46,18,13,151,70,11,133,109,40,60,84,213,202,153,57,9,222,245,120,82,219,19,148,110,249,239,123,206,216,115,51,19,216,27,15,17,30,159,235,119,174,46,140,80,75,54,219,24,11,217,225,238,78,209,58,198,147,92,74,72,172,200,149,137,47,65,129,22,73,72,114,37,212,247,250,219,29,104,205,77,190,176,200,169,33,62,87,86,88,1,6,239,119,119,20,207,192,172,120,2,29,42,181,16,203,66,115,82,177,187,243,39,209,13,246,52,44,241,200,38,146,27,243,158,61,0,252,241,17,228,10,244,132,75,80,41,215,231,169,176,183,124,9,37,245,193,193,1,59,50,69,150,113,189,57,241,231,189,238,31,171,126,89,117,174,41,216,176,67,179,55,100,93,166,189,151,199,184,82,122,208,210,250,117,134,216,112,41,126,240,185,132,111,248,97,85,204,165,72,88,66,62,188,226,2,123,207,62,112,3,219,252,27,32,34,131,6,16,12,131,213,69,98,115,141,184,220,150,26,74,12,42,109,219,245,68,35,86,138,26,156,241,141,185,211,0,151,90,164,40,207,234,92,126,194,192,176,99,54,36,238,246,245,240,176,226,184,219,172,128,36,5,12,254,134,248,232,214,211,79,205,153,88,44,46,116,158,221,114,13,202,246,48,134,36,161,4,101,65,175,185,52,158,237,138,111,242,194,182,205,236,167,104,12,54,101,230,109,206,184,229,179,188,208,9,132,62,54,55,195,67,7,225,224,78,100,80,201,37,183,188,232,83,41,184,169,88,91,26,238,133,182,5,151,253,42,94,92,122,198,10,218,25,248,178,154,60,114,181,132,243,53,130,176,45,12,1,173,147,244,236,140,222,195,32,187,228,240,103,159,41,215,96,31,243,148,146,68,231,22,185,33,245,121,82,29,89,190,198,34,20,41,176,233,185,42,50,208,148,183,71,168,118,170,170,212,185,153,255,142,164,39,236,18,44,153,83,103,208,101,33,82,150,120,162,105,138,38,255,182,194,12,139,27,103,227,83,180,119,13,159,243,167,91,45,168,66,176,141,20,153,186,231,178,0,135,195,154,235,90,132,75,88,20,163,224,137,85,202,191,88,33,77,244,197,96,38,231,74,57,255,71,62,59,182,25,124,194,210,42,242,216,115,80,96,87,3,54,48,91,97,27,77,106,251,13,194,42,212,184,20,61,112,16,155,153,165,238,69,142,35,246,136,22,177,32,101,52,242,38,104,176,133,86,61,44,215,160,151,80,43,105,64,26,119,76,139,93,72,35,196,238,164,244,186,7,247,40,29,141,70,78,195,32,190,209,41,232,15,27,199,144,34,210,155,155,5,105,249,84,100,115,208,163,118,70,244,68,248,23,216,148,208,223,114,161,143,40,122,227,62,133,101,160,47,132,54,182,115,73,81,173,67,47,148,101,153,80,181,126,196,120,82,104,170,96,242,151,146,149,200,227,107,161,42,83,75,197,253,6,123,20,123,37,204,112,152,72,184,209,103,176,224,133,180,175,74,99,199,199,29,163,222,130,99,158,231,146,124,13,155,80,212,3,10,133,173,114,222,155,187,61,217,227,151,217,78,182,161,136,184,73,183,55,140,91,231,88,92,23,66,74,223,91,125,19,170,35,64,133,3,230,187,175,22,215,229,102,201,35,100,252,215,2,244,38,168,152,184,77,112,205,21,90,174,199,117,223,30,250,56,160,188,248,52,77,79,165,116,132,206,126,204,118,119,237,100,52,155,0,57,68,236,84,97,196,138,80,134,36,253,133,75,182,115,41,243,39,72,125,137,144,24,172,43,239,205,149,48,182,204,207,19,239,236,160,1,193,88,174,172,137,31,114,77,124,88,80,219,8,104,146,168,180,34,120,174,154,251,2,171,147,39,143,44,114,166,50,139,92,76,52,190,196,15,143,160,33,42,63,99,170,245,154,73,219,138,197,94,97,74,178,158,104,99,197,6,150,211,80,35,108,167,184,41,109,227,26,179,246,197,153,48,43,201,59,82,29,122,207,127,55,171,155,122,10,242,59,72,228,57,238,29,241,91,28,63,127,178,169,161,13,165,202,224,232,173,242,234,171,34,55,66,162,114,114,88,63,214,62,67,146,107,12,212,255,57,86,168,63,165,97,119,232,107,48,95,67,43,190,133,93,165,74,156,255,50,169,194,37,172,51,42,58,56,185,155,212,195,149,184,19,82,144,245,1,147,233,109,142,46,235,210,174,212,86,219,161,70,212,2,119,127,159,133,180,61,93,53,132,114,127,223,15,164,52,246,6,207,44,183,133,97,239,142,217,171,190,118,168,99,63,84,61,72,98,193,162,150,195,40,74,21,82,214,133,228,147,181,161,232,154,221,170,141,65,231,130,140,127,109,5,120,185,1,132,238,142,217,191,216,9,182,143,115,28,36,255,108,115,107,173,247,225,27,39,120,228,244,253,203,218,207,149,151,239,149,234,197,208,29,60,31,185,74,37,80,248,174,114,142,207,131,108,69,174,214,141,163,236,24,219,104,182,47,255,184,238,216,123,97,4,46,108,209,187,176,155,108,5,197,127,107,127,122,254,11,224,172,200,55,171,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16d259fa-db24-4b5d-9c2a-21f1b7873908"));
		}

		#endregion

	}

	#endregion

}
