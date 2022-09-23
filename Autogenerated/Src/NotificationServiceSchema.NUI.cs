﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationServiceSchema

	/// <exclude/>
	public class NotificationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationServiceSchema(NotificationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d916dde4-0597-4238-84d3-06b9338b7cf6");
			Name = "NotificationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,223,79,226,64,16,126,174,137,255,195,132,123,105,19,82,222,85,48,232,169,225,18,148,0,23,31,204,229,178,180,3,110,108,183,189,221,45,103,99,252,223,157,221,182,208,10,182,151,123,33,236,204,55,223,252,158,10,22,163,74,89,128,176,68,41,153,74,214,218,191,78,196,154,111,50,201,52,79,132,127,159,104,190,230,129,125,168,211,147,183,211,19,39,83,92,108,96,145,43,141,241,249,167,183,191,64,185,229,1,78,147,16,163,86,165,63,14,52,223,90,222,118,220,35,174,14,0,36,35,144,82,100,188,208,76,227,30,80,207,35,142,235,220,117,141,252,194,66,162,127,203,2,157,72,142,234,24,194,248,221,241,146,254,155,196,13,197,0,215,17,83,234,12,234,197,42,115,176,176,167,242,65,165,213,146,248,127,25,217,88,165,247,168,137,45,37,252,138,71,92,231,115,252,147,113,137,49,10,173,220,250,195,84,2,134,208,97,98,80,126,41,8,61,227,36,205,86,17,15,32,48,225,29,139,14,206,224,138,41,44,95,125,152,204,145,133,15,34,202,235,197,37,158,55,155,198,46,221,91,142,81,72,249,206,164,233,96,145,163,147,22,15,152,76,153,124,169,251,26,43,195,122,243,138,65,70,149,133,223,113,171,254,188,116,133,34,44,188,53,93,83,9,149,150,153,233,145,9,192,230,87,250,47,114,61,146,165,235,193,27,188,119,162,126,42,148,68,47,48,48,82,200,26,207,190,49,118,186,114,107,79,205,179,28,103,176,162,146,187,77,122,138,208,42,59,138,67,51,208,89,61,199,121,111,47,225,76,38,41,74,77,35,254,159,29,236,80,15,71,255,148,202,229,37,184,157,233,90,38,199,174,87,177,152,185,127,135,250,162,35,194,145,43,240,111,125,84,198,114,147,153,21,113,123,205,178,247,138,182,58,78,179,247,158,231,117,140,225,20,245,115,18,126,154,192,193,0,22,168,21,76,108,48,176,166,4,68,253,124,250,5,104,0,23,41,147,44,6,65,215,119,216,171,67,150,121,138,147,176,55,186,24,88,196,232,168,1,109,59,23,225,146,199,120,4,40,81,103,82,40,82,84,255,140,234,233,129,58,110,61,212,79,144,243,68,247,108,34,182,201,11,186,69,66,52,95,189,217,195,98,217,235,195,85,18,230,11,157,71,230,238,16,108,74,7,129,109,112,39,245,31,37,75,83,12,251,96,14,14,42,125,155,200,152,233,6,184,16,249,63,84,181,62,115,250,216,80,29,176,29,107,47,87,181,168,141,175,81,185,169,21,205,23,131,232,222,101,60,132,195,178,246,129,198,193,220,243,125,1,171,181,219,50,73,210,146,117,8,229,244,124,233,216,245,236,158,57,90,230,37,129,115,232,206,191,126,198,224,165,154,188,155,56,213,185,107,26,152,172,221,67,176,87,50,58,251,216,154,246,247,89,20,85,230,181,248,43,51,147,64,72,187,59,223,169,40,141,239,36,176,76,51,38,41,232,154,89,105,213,190,69,126,241,7,143,132,219,255,228,172,36,124,7,2,5,207,224,222,188,6,152,218,43,138,175,85,141,157,170,192,254,94,59,36,125,105,106,127,139,153,221,181,162,229,154,21,210,166,144,100,31,119,13,167,238,209,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d916dde4-0597-4238-84d3-06b9338b7cf6"));
		}

		#endregion

	}

	#endregion

}

