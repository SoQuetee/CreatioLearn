﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleVisaNotificationProviderSchema

	/// <exclude/>
	public class SysModuleVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleVisaNotificationProviderSchema(SysModuleVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("573127ee-3eb7-409b-b464-bb2c970d327a");
			Name = "SysModuleVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,75,111,219,56,16,62,187,64,255,3,225,94,108,32,144,23,187,183,196,214,34,113,220,192,11,184,27,212,77,247,76,203,227,152,11,137,242,146,148,83,111,225,255,190,195,135,36,82,146,163,180,183,205,37,209,112,230,155,225,60,190,97,56,205,64,30,104,2,228,11,8,65,101,190,83,209,60,231,59,246,92,8,170,88,206,223,191,251,254,254,221,160,144,140,63,147,245,73,42,200,110,26,223,168,159,166,144,104,101,25,61,0,7,193,146,150,206,61,85,180,22,250,190,178,44,231,221,39,2,46,201,163,251,187,139,71,11,174,152,98,32,81,1,85,62,8,120,198,192,200,60,165,82,94,235,104,86,249,182,72,225,43,147,244,83,174,216,142,37,230,154,143,34,63,178,45,8,99,52,153,76,200,84,22,89,70,197,41,118,223,218,64,18,238,153,144,131,179,33,187,92,16,89,102,160,180,159,120,0,135,98,147,178,132,36,58,136,254,24,200,53,185,163,242,226,241,21,89,250,98,132,255,110,162,174,239,138,97,40,81,36,42,23,120,229,71,227,219,106,52,47,102,4,75,142,249,162,41,251,23,36,161,132,195,11,97,104,79,57,246,68,190,35,106,15,104,2,64,18,1,187,217,176,55,248,225,36,118,247,124,97,106,79,14,84,96,135,41,16,38,49,237,204,88,137,209,34,28,53,103,195,218,98,24,63,86,127,147,45,51,249,69,179,104,58,49,58,198,220,101,182,55,172,209,125,101,63,197,228,96,223,92,145,124,243,55,22,45,246,98,28,107,200,193,53,217,96,250,71,158,152,232,25,24,156,255,63,73,44,36,8,108,3,110,155,114,24,63,5,223,63,151,193,16,131,132,46,130,204,53,142,130,236,125,0,190,181,125,26,54,237,10,212,62,223,234,126,21,236,72,21,216,211,131,253,32,107,208,12,67,30,64,85,113,90,209,200,161,15,142,84,207,160,209,154,25,193,64,23,193,41,61,117,196,58,24,104,226,42,50,62,170,235,97,184,227,52,188,34,90,100,63,214,201,30,50,250,180,220,14,199,209,173,28,13,91,210,139,96,58,145,26,74,255,110,162,52,100,189,24,43,138,44,42,236,113,141,210,146,94,196,209,24,203,140,62,195,111,191,214,122,209,71,145,103,190,82,101,191,196,84,137,63,114,214,10,101,28,253,217,21,158,231,27,141,229,226,159,130,166,13,239,129,141,31,107,151,47,87,135,134,183,186,58,63,226,207,90,121,183,254,107,15,2,58,46,129,77,50,47,164,202,179,206,137,172,227,117,238,108,142,163,138,162,70,59,154,74,24,143,9,174,9,219,118,55,198,68,128,42,4,119,189,121,243,67,147,208,199,220,159,45,52,47,178,13,110,13,228,25,183,132,130,53,245,26,101,216,216,100,124,235,97,4,182,211,73,169,226,81,69,126,196,141,139,73,65,138,51,35,57,207,11,94,15,162,27,85,176,115,226,38,82,171,149,139,185,28,92,155,30,182,35,163,80,119,134,193,164,105,9,87,230,239,23,171,126,246,125,36,218,241,250,231,134,254,99,193,147,200,70,110,218,169,58,191,103,82,49,174,3,244,167,196,15,209,14,223,188,118,62,188,84,116,47,192,104,241,13,146,66,193,58,161,41,21,83,76,93,236,82,240,218,90,177,21,150,193,242,176,46,113,67,120,207,14,114,212,207,147,104,18,191,169,216,157,104,229,190,234,169,121,205,196,205,122,118,212,191,58,37,182,168,54,57,93,44,94,166,231,51,80,189,107,132,249,69,102,113,217,5,15,5,219,150,61,85,242,38,130,90,189,200,52,161,46,235,87,154,22,48,213,202,113,7,85,223,120,88,71,159,129,251,144,26,116,237,227,100,33,7,247,33,181,40,219,199,146,101,86,42,170,238,131,243,56,221,1,249,151,246,46,137,64,254,201,138,114,52,52,168,75,87,247,187,19,198,51,10,210,210,137,233,23,225,173,168,141,194,117,225,218,203,5,233,68,244,58,28,55,183,250,63,12,101,65,27,153,47,65,205,67,192,231,246,234,89,61,51,239,178,215,158,214,237,55,31,254,124,66,9,218,250,119,136,180,236,202,157,207,233,193,140,96,67,197,137,75,45,237,50,188,144,143,161,79,87,225,213,253,235,69,94,233,125,179,47,76,165,80,89,4,238,241,25,165,199,31,217,236,144,210,211,235,48,166,139,76,179,181,59,208,170,156,93,114,221,52,7,249,173,38,188,51,235,209,69,230,31,180,40,162,41,176,164,225,130,252,189,203,171,59,187,110,152,70,79,28,83,127,155,166,163,14,155,22,89,159,199,1,105,135,80,111,166,232,96,111,186,37,78,152,145,19,150,29,82,200,16,24,182,23,214,177,163,217,229,2,23,49,8,186,73,97,26,252,151,183,228,187,60,214,172,235,11,101,69,186,106,47,242,23,211,222,120,190,172,189,45,190,37,96,218,48,220,53,141,167,135,149,250,194,243,127,177,245,18,225,24,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("573127ee-3eb7-409b-b464-bb2c970d327a"));
		}

		#endregion

	}

	#endregion

}

