﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UTCDateTimeJsonConverterSchema

	/// <exclude/>
	public class UTCDateTimeJsonConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UTCDateTimeJsonConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UTCDateTimeJsonConverterSchema(UTCDateTimeJsonConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("023cbd9f-1a91-4c52-be5e-2a96c54c4225");
			Name = "UTCDateTimeJsonConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,203,110,219,48,16,60,59,64,254,97,225,92,100,192,144,238,169,237,139,219,6,238,11,65,172,164,103,90,90,217,108,37,174,64,82,114,221,32,255,94,62,244,176,21,196,117,47,189,8,24,146,59,59,156,89,74,176,2,85,201,18,132,24,165,100,138,50,29,46,73,100,124,91,73,166,57,137,112,77,9,103,249,23,100,233,29,138,235,171,231,235,171,81,165,184,216,194,55,220,107,18,174,226,147,34,241,174,219,88,31,148,198,98,136,195,187,156,54,44,231,191,29,173,217,53,251,55,18,183,6,192,50,103,74,221,194,99,188,124,207,52,198,188,64,203,104,116,212,40,53,74,119,54,138,34,152,169,170,40,152,60,44,26,188,172,148,166,226,72,137,165,0,203,1,218,144,64,210,50,132,45,65,116,196,80,86,155,156,39,144,216,230,111,246,134,91,24,104,25,61,59,61,157,248,175,168,119,148,26,249,247,142,207,111,14,213,122,185,59,76,126,2,207,64,31,74,4,202,160,148,84,26,214,3,112,5,170,42,75,50,29,210,176,171,143,134,4,179,146,73,86,128,48,161,205,199,180,249,129,137,142,13,213,120,17,15,9,247,59,158,236,44,173,64,76,65,19,108,122,55,210,112,22,57,162,158,87,162,174,164,80,139,149,215,225,78,189,86,73,18,4,105,83,221,30,183,245,141,139,100,168,37,79,17,54,68,57,44,89,235,88,224,165,117,90,39,96,39,104,52,242,20,71,27,48,159,187,142,148,5,109,16,19,59,67,163,151,51,142,62,152,177,236,244,93,106,156,52,69,40,199,11,155,43,120,240,218,145,75,157,62,95,137,191,184,210,230,13,60,177,188,50,197,31,26,8,181,197,231,75,21,74,110,159,75,167,180,95,120,59,191,123,38,21,246,142,116,125,206,5,230,111,231,172,180,125,2,251,121,112,174,52,230,76,97,144,225,180,173,57,185,222,212,61,148,117,167,242,72,240,32,244,54,223,112,93,98,194,179,195,103,46,210,160,79,189,137,164,33,109,151,237,161,240,81,39,127,31,138,239,146,155,31,192,191,78,197,222,86,181,94,123,112,62,160,218,103,234,100,94,62,17,255,45,214,154,120,234,173,232,82,117,72,54,151,235,66,172,47,12,175,241,196,145,184,75,7,71,153,57,146,73,24,211,90,75,51,16,193,88,141,251,232,62,146,44,152,94,137,140,194,149,168,153,33,22,14,77,78,178,188,65,145,250,95,170,195,126,245,116,241,229,15,9,252,56,192,175,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("023cbd9f-1a91-4c52-be5e-2a96c54c4225"));
		}

		#endregion

	}

	#endregion

}
