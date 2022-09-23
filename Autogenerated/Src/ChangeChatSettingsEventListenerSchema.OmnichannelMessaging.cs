﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChangeChatSettingsEventListenerSchema

	/// <exclude/>
	public class ChangeChatSettingsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChangeChatSettingsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChangeChatSettingsEventListenerSchema(ChangeChatSettingsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba4b43c8-f982-4731-bcc4-789f93b7df6e");
			Name = "ChangeChatSettingsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,79,219,64,16,61,7,137,255,48,10,18,114,36,228,220,33,137,148,6,132,34,65,105,5,244,82,245,176,177,39,201,86,246,174,217,143,84,22,240,223,59,222,181,19,59,31,132,32,184,36,246,250,189,55,51,111,102,71,176,20,117,198,34,132,7,84,138,105,57,53,225,72,138,41,159,89,197,12,151,34,188,75,5,143,230,76,8,76,194,91,212,154,205,184,152,29,31,61,31,31,181,172,166,71,184,207,181,193,244,98,237,61,188,225,226,105,117,88,87,87,184,235,60,188,18,134,27,142,122,47,32,188,90,160,48,5,142,144,39,10,103,148,42,140,18,166,245,57,140,40,219,25,210,175,185,71,99,72,68,59,240,13,167,188,4,42,71,233,118,187,208,211,54,77,153,202,7,229,187,163,67,166,228,130,199,168,11,25,243,211,162,197,187,12,201,11,169,0,139,224,57,160,11,13,20,37,78,72,61,172,228,186,53,189,223,46,209,188,17,56,184,143,230,152,178,239,100,57,244,161,189,161,223,238,252,121,55,179,104,135,199,103,118,146,240,8,34,151,252,158,210,225,28,190,49,141,91,34,144,208,179,51,102,105,230,45,154,185,140,201,206,31,74,26,140,12,198,254,251,186,115,165,117,200,148,6,154,19,3,178,44,71,131,194,76,106,78,143,57,49,16,33,82,56,237,183,199,35,70,213,220,211,49,182,187,3,224,66,27,38,34,12,151,226,221,117,245,94,198,20,75,65,80,249,253,182,141,218,131,154,218,163,70,69,3,43,40,67,202,186,33,216,235,58,158,147,201,170,34,96,33,121,236,243,173,124,215,46,161,160,169,4,54,234,64,49,228,173,214,130,41,136,10,8,121,47,240,159,27,140,138,235,169,132,189,112,80,7,11,157,186,255,82,158,175,211,30,20,19,122,138,202,185,80,208,55,57,175,111,216,125,73,93,83,124,98,13,58,203,53,24,89,179,125,146,251,70,60,21,195,245,181,182,110,200,68,213,80,143,227,246,96,180,204,194,2,93,41,154,186,41,71,245,86,95,28,117,85,221,102,79,206,224,218,18,174,22,166,222,165,167,6,189,96,172,58,214,148,150,106,213,180,13,86,88,203,160,30,169,222,151,19,20,177,191,41,187,174,141,187,151,181,38,114,49,71,197,77,44,163,210,227,29,87,49,188,19,99,65,117,147,41,228,187,51,201,95,113,185,160,93,72,62,122,171,86,168,64,78,254,146,65,160,41,37,84,103,224,53,135,83,131,202,9,15,213,76,3,86,62,77,40,106,45,68,80,177,176,116,163,240,177,92,116,125,8,188,86,199,131,60,96,219,221,241,132,176,217,174,82,112,189,167,91,177,103,101,204,240,26,205,67,158,97,60,146,137,77,197,47,150,88,236,21,45,31,4,171,133,73,179,213,217,188,36,7,248,251,152,197,108,175,189,37,232,67,238,86,220,131,205,229,83,168,12,170,239,252,218,210,135,211,211,154,87,126,225,215,221,210,65,39,28,138,60,136,162,5,244,7,64,127,225,82,99,172,135,228,246,2,201,190,50,223,131,187,249,250,121,105,250,4,90,59,179,173,247,27,94,94,32,216,94,75,17,41,152,72,153,116,138,239,78,188,179,170,239,43,167,207,155,241,193,25,188,196,4,247,206,96,9,250,208,12,86,220,131,103,176,0,216,230,226,237,195,86,223,118,47,4,251,158,77,96,63,113,5,172,237,227,162,51,205,163,215,255,61,145,89,106,235,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba4b43c8-f982-4731-bcc4-789f93b7df6e"));
		}

		#endregion

	}

	#endregion

}

