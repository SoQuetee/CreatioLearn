﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChannelEventListenerSchema

	/// <exclude/>
	public class ChannelEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChannelEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChannelEventListenerSchema(ChannelEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("881e60a7-fbf6-47bc-91cf-0f917c5cd883");
			Name = "ChannelEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3e2142cb-b5f1-4ce8-8571-f789e137e2ae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,75,79,27,49,16,62,7,169,255,97,154,94,54,82,180,185,3,137,148,18,64,72,80,144,18,122,169,170,202,236,78,130,43,199,155,218,222,84,17,202,127,239,248,181,143,16,158,61,192,37,216,251,205,124,223,60,60,182,100,75,212,43,150,33,204,80,41,166,139,185,73,79,10,57,231,139,82,49,195,11,153,94,47,37,207,238,153,148,40,210,43,212,154,45,184,92,124,58,120,248,116,208,41,53,253,11,13,64,245,61,157,161,192,133,98,203,163,10,54,221,104,131,143,214,68,38,4,102,150,73,167,231,40,81,241,236,17,230,146,203,63,245,102,83,168,194,244,84,26,110,56,234,23,1,233,233,26,165,177,56,66,126,81,184,32,78,56,17,76,235,67,56,241,250,29,226,146,19,41,9,113,184,193,96,0,199,186,92,46,153,218,140,194,218,217,192,74,21,107,158,163,142,182,128,150,103,3,232,88,128,54,115,97,51,17,157,12,26,94,126,56,77,155,22,93,50,205,238,113,201,190,81,65,96,8,221,224,181,219,251,73,248,85,121,39,120,6,153,35,222,167,21,14,225,43,211,184,199,45,89,63,184,72,170,144,79,101,185,164,144,111,20,95,51,131,254,27,210,94,116,60,246,213,176,219,182,200,157,206,173,180,150,228,78,245,221,218,2,172,169,95,77,144,133,181,93,110,3,23,202,220,211,181,185,207,56,138,124,151,124,229,23,160,144,229,133,20,27,152,112,39,129,146,117,220,214,212,111,126,58,47,121,222,7,255,229,88,27,69,201,30,141,70,240,139,121,44,12,157,60,137,127,255,203,95,210,59,122,62,36,58,45,4,46,51,83,40,27,152,171,84,136,203,87,109,95,189,146,30,248,220,94,72,110,130,24,199,244,98,6,175,208,220,23,79,166,112,93,240,28,90,62,3,79,204,74,58,206,243,164,157,132,180,81,95,216,73,215,222,156,4,151,29,120,216,123,246,93,66,116,53,1,110,252,57,33,223,113,231,68,112,74,197,25,179,41,219,164,23,132,102,50,195,134,140,120,162,182,142,103,27,43,240,108,16,85,83,126,100,8,81,196,123,2,168,207,209,135,134,80,203,216,19,68,213,157,173,126,155,20,94,90,226,199,15,4,41,253,157,129,2,62,248,216,145,107,166,226,12,85,23,57,141,188,120,201,156,163,153,109,86,152,211,205,80,46,229,119,38,74,116,25,24,37,221,155,10,223,245,114,58,124,14,73,149,213,153,218,144,177,179,72,252,94,31,138,210,128,165,10,152,94,164,119,150,251,12,107,77,181,113,198,68,136,162,182,119,1,240,87,10,191,210,139,41,26,67,117,209,86,123,58,43,166,174,140,225,204,211,95,77,145,240,60,238,134,212,191,105,44,52,6,144,187,119,184,188,167,75,213,228,5,221,31,10,231,195,238,19,23,69,122,45,39,212,26,6,243,238,96,212,24,95,197,154,174,83,74,136,175,117,5,74,138,187,223,116,111,131,38,65,182,173,188,199,241,156,142,175,115,59,86,11,13,24,179,117,71,156,53,65,18,141,48,4,90,117,80,104,161,94,4,60,57,169,90,221,248,214,56,111,87,57,123,49,206,0,122,87,156,209,118,55,78,219,50,225,153,48,132,118,172,53,128,107,55,70,236,43,192,99,109,99,217,68,44,90,173,69,179,61,61,227,74,155,107,53,193,57,43,133,73,178,108,13,195,17,208,79,234,159,17,244,142,184,8,222,154,7,166,98,248,60,4,89,10,209,58,19,201,93,81,136,94,132,164,142,203,122,162,59,14,235,230,175,42,230,37,62,170,84,156,132,85,39,3,10,141,175,54,175,167,208,171,143,130,223,109,111,110,225,31,87,37,176,251,224,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("881e60a7-fbf6-47bc-91cf-0f917c5cd883"));
		}

		#endregion

	}

	#endregion

}

