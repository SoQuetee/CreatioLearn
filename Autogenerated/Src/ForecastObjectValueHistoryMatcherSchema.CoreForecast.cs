﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastObjectValueHistoryMatcherSchema

	/// <exclude/>
	public class ForecastObjectValueHistoryMatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastObjectValueHistoryMatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastObjectValueHistoryMatcherSchema(ForecastObjectValueHistoryMatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cdc37d9-7e92-22a7-f203-41f2f84b377c");
			Name = "ForecastObjectValueHistoryMatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,223,107,219,48,16,126,118,161,255,131,200,160,56,80,100,216,99,27,7,186,180,217,2,109,87,218,210,151,177,7,213,62,39,218,108,41,147,228,150,48,242,191,239,36,203,142,237,164,36,27,244,109,15,73,208,233,251,238,199,119,119,138,96,5,232,37,75,128,60,130,82,76,203,204,208,137,20,25,159,151,138,25,46,5,157,74,5,9,211,230,233,35,249,125,124,116,124,20,148,154,139,57,121,88,105,3,5,98,243,28,18,11,212,244,51,8,80,60,57,239,99,174,185,248,181,49,182,227,20,133,20,187,111,20,208,41,75,140,84,28,244,185,11,251,65,193,28,195,144,153,48,160,50,155,241,25,153,213,201,125,125,254,129,89,60,177,188,132,47,92,35,109,117,195,76,178,0,229,168,81,20,145,145,46,139,130,169,213,216,159,61,140,72,199,36,47,150,170,73,81,177,8,175,131,208,154,30,181,248,203,242,57,231,201,6,116,64,30,94,187,166,138,27,48,11,153,234,51,114,231,124,85,151,253,60,157,193,57,232,164,73,48,150,84,169,166,13,39,234,147,70,75,166,88,65,4,118,55,30,228,144,153,77,159,6,227,199,5,16,107,35,73,99,36,70,226,169,64,22,80,116,231,216,187,157,41,62,95,108,121,115,198,131,221,41,48,165,18,122,60,210,0,36,81,144,197,131,135,5,128,25,68,227,81,84,95,90,244,236,74,148,5,40,246,156,195,200,203,217,18,248,222,169,48,174,4,10,219,216,29,160,174,6,167,214,123,176,135,210,171,116,104,7,53,112,61,4,145,86,109,116,109,91,227,199,206,103,215,90,55,122,146,51,141,109,126,167,65,221,57,158,223,46,33,99,101,110,62,113,145,226,94,133,102,181,4,153,133,251,135,116,120,74,110,177,201,36,38,3,239,98,48,252,190,153,247,196,150,178,191,146,131,246,242,255,62,252,195,62,248,62,188,223,90,16,183,23,127,187,24,182,151,200,234,250,162,147,5,36,63,47,212,28,61,9,115,91,230,121,104,5,195,57,236,226,134,213,94,5,61,167,111,211,251,209,61,255,133,41,162,228,171,198,225,21,240,74,174,81,151,183,197,9,61,41,195,49,101,56,77,225,22,196,41,51,195,127,47,124,229,123,42,213,245,186,144,24,235,94,190,250,160,111,197,11,107,103,62,108,96,19,165,23,105,26,86,244,218,236,106,176,229,185,192,113,95,104,58,229,10,87,74,249,221,12,185,67,141,125,211,2,123,164,247,144,93,9,195,205,106,150,146,56,110,170,232,216,79,78,218,12,244,95,22,162,7,111,140,93,236,29,254,191,203,180,135,109,140,93,236,206,52,106,163,7,214,133,243,140,132,173,194,81,77,108,120,163,115,80,169,68,189,188,15,134,25,251,70,181,143,244,18,114,48,144,122,127,107,247,83,125,87,11,228,102,195,221,174,253,195,179,245,136,111,189,225,235,63,42,29,84,103,29,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cdc37d9-7e92-22a7-f203-41f2f84b377c"));
		}

		#endregion

	}

	#endregion

}

