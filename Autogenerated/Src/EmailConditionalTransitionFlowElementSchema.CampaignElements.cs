﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailConditionalTransitionFlowElementSchema

	/// <exclude/>
	public class EmailConditionalTransitionFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailConditionalTransitionFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailConditionalTransitionFlowElementSchema(EmailConditionalTransitionFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("23c2b85a-8fc5-4adb-84ae-a79c64f14ea5");
			Name = "EmailConditionalTransitionFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,91,79,227,56,20,126,238,72,243,31,60,93,105,20,164,85,144,150,55,160,172,160,91,102,186,26,102,89,46,226,217,36,167,173,213,196,9,182,3,84,12,255,125,142,99,199,137,211,244,6,188,64,155,248,124,231,246,157,207,118,57,77,65,230,52,2,114,3,66,80,153,77,84,56,204,248,132,77,11,65,21,203,248,231,79,47,159,63,245,10,201,248,148,92,47,164,130,244,168,245,29,215,39,9,68,122,177,12,191,1,7,193,162,165,53,63,24,127,168,31,54,125,165,105,198,187,223,8,8,255,57,195,87,248,242,15,1,83,196,39,195,132,74,121,72,70,41,101,9,134,25,51,237,149,38,55,130,114,89,126,62,79,178,167,81,2,41,112,85,26,238,239,239,147,99,89,164,41,21,139,19,251,189,180,38,81,109,78,148,179,39,185,200,34,144,146,128,1,9,43,140,253,6,72,94,220,39,44,34,145,14,102,187,88,200,33,217,28,110,239,165,12,217,37,123,41,178,28,132,98,128,25,95,10,246,72,21,152,5,237,164,202,7,117,23,72,54,33,2,187,138,253,0,73,158,152,154,101,133,194,104,89,52,15,157,121,51,159,94,110,208,201,120,196,139,20,4,189,79,224,248,91,193,226,19,114,85,225,220,25,152,161,70,33,154,18,189,222,20,20,25,156,144,179,60,197,132,162,249,56,150,225,41,95,4,123,228,215,47,242,125,129,161,39,140,207,237,179,210,160,247,183,169,150,3,13,239,102,32,32,120,214,48,207,228,203,128,92,80,49,7,133,68,192,106,73,37,195,179,34,153,123,38,165,127,136,199,177,1,236,125,253,186,165,225,21,228,9,211,134,54,148,195,119,135,82,35,106,250,246,94,109,243,128,199,166,127,107,154,89,242,103,77,47,111,57,123,40,128,176,24,121,193,38,12,132,110,233,61,6,64,64,71,176,170,139,134,150,186,113,196,69,59,142,201,11,193,78,29,17,169,255,188,110,205,32,9,250,11,196,198,165,35,20,6,37,215,251,95,38,145,95,233,247,198,51,171,168,245,150,80,106,94,126,92,24,74,179,127,183,96,24,87,222,224,116,5,179,138,73,23,128,147,24,183,53,161,26,225,199,12,187,63,122,86,104,172,71,214,85,29,199,210,76,109,45,62,255,23,32,22,225,112,6,209,252,84,76,11,45,66,63,139,36,9,250,173,37,125,67,240,222,117,153,186,99,130,253,58,32,223,64,153,207,103,139,75,138,20,143,88,78,185,106,120,246,204,75,29,146,27,140,203,49,119,150,108,66,130,150,87,28,80,142,177,18,156,127,15,208,62,175,146,237,249,102,33,14,86,198,131,166,133,117,241,138,130,175,201,141,158,118,192,195,248,155,171,45,148,95,44,45,18,155,210,53,82,178,101,190,62,228,86,9,123,38,203,25,239,130,136,57,120,203,155,57,175,142,219,129,181,217,119,202,227,160,63,142,251,123,225,152,183,108,247,26,208,175,62,201,45,248,122,238,88,151,58,168,150,212,163,162,43,202,184,12,182,223,110,246,92,6,143,84,152,166,67,92,166,224,202,194,225,201,6,22,220,74,16,8,201,141,108,216,68,122,203,86,250,232,84,164,60,232,71,57,168,191,250,127,146,254,144,166,57,101,83,222,200,71,87,199,238,118,225,185,200,210,160,127,65,81,25,88,146,152,76,177,118,167,50,232,167,81,189,108,140,174,197,191,25,67,228,97,154,35,154,80,81,206,85,153,218,13,21,40,53,214,200,248,173,236,122,225,127,205,88,42,55,87,128,129,48,84,135,91,211,40,57,122,40,104,82,122,196,85,254,219,142,8,92,81,173,207,123,104,57,196,7,26,167,11,188,110,72,19,220,108,213,117,160,119,84,98,197,155,230,166,174,33,86,17,207,183,10,68,48,161,72,246,189,218,111,201,59,227,120,188,214,176,177,145,238,85,141,212,148,90,58,245,56,130,116,245,217,186,155,149,57,57,75,195,250,182,75,217,196,118,62,187,80,187,138,236,54,56,87,237,217,82,185,103,43,235,237,172,203,183,214,181,85,138,42,61,157,125,251,120,87,39,191,41,251,213,89,215,152,117,210,31,146,245,27,211,182,162,86,253,235,136,228,58,71,238,79,22,63,179,31,89,52,255,142,123,186,83,112,20,77,85,8,222,33,20,77,189,180,139,180,64,30,237,170,114,110,203,104,200,156,47,59,120,23,83,99,121,14,20,157,192,136,235,115,71,220,40,153,6,88,220,100,174,76,184,179,188,89,38,235,163,176,39,147,118,163,216,81,38,151,173,60,153,60,216,90,38,253,84,29,51,196,27,117,242,160,67,39,15,182,209,73,237,178,177,108,133,146,29,188,79,201,132,39,151,187,107,90,71,213,55,211,123,217,232,227,232,221,62,183,46,159,229,193,191,86,12,186,47,171,245,145,170,121,39,26,12,72,12,19,90,36,42,208,96,229,157,245,139,15,216,82,182,118,54,54,73,195,243,214,9,105,53,199,13,150,71,232,141,124,110,211,217,99,230,189,254,100,215,237,68,231,154,132,70,29,85,155,163,53,129,171,40,187,137,94,193,148,68,172,150,238,74,228,106,18,108,28,111,33,178,23,71,27,167,234,234,234,237,199,111,62,246,157,74,210,228,116,235,96,189,122,56,220,108,52,215,111,243,19,65,227,98,151,169,242,146,185,230,86,122,85,122,145,228,65,207,30,81,51,170,8,227,81,82,196,56,9,52,118,191,108,37,217,148,69,43,238,165,229,19,19,173,60,57,163,184,197,31,75,0,18,9,152,12,250,183,121,140,67,218,223,199,49,43,47,147,120,227,213,191,36,17,197,82,32,200,3,50,97,9,214,173,254,25,77,134,199,251,21,152,25,115,155,4,201,30,65,8,22,219,187,233,80,224,142,4,165,100,184,217,190,71,231,161,247,194,148,178,243,30,187,166,148,230,169,255,16,159,253,6,30,61,150,121,229,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23c2b85a-8fc5-4adb-84ae-a79c64f14ea5"));
		}

		#endregion

	}

	#endregion

}

