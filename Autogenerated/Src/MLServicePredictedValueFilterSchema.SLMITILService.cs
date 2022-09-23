﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLServicePredictedValueFilterSchema

	/// <exclude/>
	public class MLServicePredictedValueFilterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLServicePredictedValueFilterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLServicePredictedValueFilterSchema(MLServicePredictedValueFilterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d952c78-4f98-48e7-8948-9c86f90db786");
			Name = "MLServicePredictedValueFilter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e45998c9-62eb-4d7e-9232-63ecc763f5be");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,77,111,219,70,16,61,43,64,254,195,152,45,16,10,85,169,230,26,203,4,108,71,118,21,216,177,80,57,201,161,232,97,69,14,165,5,168,93,117,119,105,69,21,244,223,59,251,65,90,100,44,57,23,123,57,156,121,243,230,237,219,165,4,91,161,94,179,12,225,17,149,98,90,22,38,185,150,162,224,139,74,49,195,165,72,238,239,222,190,217,189,125,211,171,52,23,11,152,109,181,193,213,121,243,124,88,165,240,88,60,249,120,117,244,213,88,24,110,56,234,163,9,55,44,51,82,29,201,184,191,75,38,194,160,42,104,4,155,64,41,191,40,92,16,113,184,46,153,214,31,224,254,110,134,234,137,103,56,85,152,243,204,96,254,149,149,21,222,240,146,202,92,193,112,56,132,145,174,86,43,166,182,105,120,254,147,137,188,68,5,133,84,16,234,161,224,88,230,176,246,48,182,3,229,80,208,226,16,169,164,70,26,30,64,253,253,240,68,84,121,142,255,208,195,186,154,151,60,131,204,242,58,77,203,178,190,98,250,8,229,222,206,209,126,30,84,10,109,84,101,85,162,121,167,174,139,207,232,78,230,2,19,65,122,179,146,255,135,26,24,8,220,0,167,122,38,104,66,89,128,89,34,149,32,66,166,176,184,136,78,210,140,134,169,159,38,105,154,13,187,221,70,107,166,216,10,4,249,236,34,170,52,42,98,43,208,233,23,165,143,212,204,198,32,107,130,201,104,232,42,28,64,80,236,36,137,248,75,11,20,218,61,250,31,96,78,66,198,157,40,88,71,247,246,65,71,20,185,151,178,173,235,61,154,165,204,127,70,210,107,86,150,152,195,102,137,2,208,250,121,27,204,34,16,115,13,70,194,28,65,163,129,249,182,246,15,165,63,217,33,126,86,58,15,235,37,243,235,150,82,63,228,103,178,172,86,194,233,244,153,2,81,106,255,214,27,236,95,6,2,39,97,20,234,170,52,190,109,151,249,15,133,10,77,165,132,78,71,89,74,126,196,209,48,75,225,119,224,133,207,7,78,126,43,75,185,33,128,70,145,1,96,169,145,178,168,166,96,180,180,69,132,92,67,29,184,64,134,163,4,115,41,75,120,16,51,74,89,183,29,17,143,189,248,94,160,1,208,177,176,215,69,71,139,129,5,237,245,220,253,192,11,158,185,123,238,47,55,40,248,121,131,63,122,68,61,62,179,254,73,94,110,87,247,233,54,168,97,106,156,158,31,7,220,132,231,46,180,111,26,116,138,225,236,2,162,224,247,9,221,181,147,60,234,194,88,113,187,40,103,183,21,207,147,71,181,157,50,69,126,247,4,18,135,58,0,89,25,218,3,69,130,31,192,62,179,187,147,139,228,27,83,34,254,181,110,12,156,82,194,182,237,14,177,246,176,97,26,132,52,206,206,180,228,230,157,127,102,54,157,231,112,251,101,242,49,234,159,159,158,219,146,173,217,76,233,126,159,228,112,81,219,250,22,205,227,118,141,249,245,179,46,35,155,159,198,53,59,95,81,55,241,131,149,116,178,9,35,158,185,85,223,94,107,126,217,185,31,250,158,88,47,241,240,177,255,151,184,59,52,126,223,15,175,147,27,37,87,77,191,137,56,104,28,245,147,75,29,71,122,29,213,185,19,194,86,159,36,23,77,193,204,48,83,233,58,211,46,30,132,43,25,208,214,186,119,150,126,50,209,227,127,43,86,186,20,122,99,99,1,242,219,18,21,54,21,109,51,52,101,129,250,212,30,66,180,55,97,107,123,169,208,170,22,245,155,137,47,69,222,129,172,133,124,21,210,39,30,131,116,236,47,73,222,39,60,133,101,109,75,137,87,116,124,145,9,66,241,251,103,212,182,54,162,59,217,92,127,181,70,114,27,79,59,234,183,54,25,127,199,172,50,56,203,88,201,212,136,11,147,198,125,72,225,143,96,52,119,4,14,43,27,115,191,230,238,150,104,47,216,27,114,137,90,188,163,72,69,15,187,150,32,123,136,224,183,208,166,247,12,207,22,10,113,69,118,6,250,245,192,195,241,8,242,4,190,251,214,249,56,36,30,142,9,208,181,148,45,33,30,127,207,112,237,62,108,216,58,175,99,165,164,162,145,78,126,27,95,190,182,232,19,160,228,70,3,54,208,59,220,191,118,100,95,254,86,250,104,59,72,177,255,1,141,172,148,95,86,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d952c78-4f98-48e7-8948-9c86f90db786"));
		}

		#endregion

	}

	#endregion

}

