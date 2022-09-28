﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProviderValidatorSchema

	/// <exclude/>
	public class ProviderValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProviderValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProviderValidatorSchema(ProviderValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9651ca92-7510-4b7c-a4e3-8498edb76804");
			Name = "ProviderValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,77,111,227,54,16,61,123,129,253,15,179,41,176,144,129,128,110,175,73,236,34,31,222,192,69,62,10,216,216,61,20,61,208,210,216,38,42,145,90,146,114,235,46,242,223,59,162,40,90,178,37,59,5,124,49,53,124,243,222,204,240,145,146,103,104,114,30,35,44,80,107,110,212,202,178,123,37,87,98,93,104,110,133,146,31,63,252,248,248,97,80,24,33,215,48,223,25,139,217,245,193,127,138,79,83,140,203,96,195,30,81,162,22,241,81,204,147,144,223,247,139,205,92,89,166,100,247,151,6,11,118,63,157,83,16,133,253,164,113,77,11,112,159,114,99,174,224,119,173,182,34,65,253,149,167,34,225,86,105,23,52,26,141,224,198,20,89,198,245,110,226,255,63,115,201,215,104,96,91,69,150,24,106,5,203,34,253,11,48,227,34,5,42,132,113,17,185,199,52,64,49,124,75,223,248,82,164,194,238,88,13,61,106,96,231,197,50,21,49,196,37,159,99,58,112,5,119,220,224,115,133,221,96,57,248,225,152,6,61,180,51,71,109,5,86,162,44,21,20,147,42,228,80,141,91,120,68,107,192,110,16,114,101,140,168,248,129,85,32,164,165,18,22,185,133,120,195,133,211,184,173,179,26,22,224,154,10,6,121,157,15,212,150,54,147,0,88,42,149,194,204,220,46,149,182,175,242,235,190,102,227,9,88,93,224,181,103,143,50,169,4,180,213,60,163,221,168,196,73,17,91,110,177,250,154,87,127,192,88,93,246,154,36,220,81,249,231,57,113,95,160,177,117,241,166,90,43,237,43,22,205,166,178,200,80,243,101,138,55,213,190,9,72,101,105,58,164,163,92,111,50,67,40,7,117,48,216,114,221,25,240,82,78,58,140,125,114,246,155,18,50,186,184,4,250,117,195,93,7,52,44,249,188,106,177,22,210,179,34,24,34,255,20,255,59,119,96,84,158,2,163,139,151,14,28,39,174,84,57,45,103,204,111,191,240,224,26,109,161,101,205,232,139,210,25,183,209,113,182,110,134,78,79,5,244,214,87,222,5,193,172,79,20,52,16,155,84,103,224,155,176,155,46,21,173,226,230,77,2,11,117,135,33,156,202,114,26,134,205,177,116,138,168,58,112,99,159,149,53,37,53,234,30,206,225,97,146,227,22,246,115,106,224,117,85,241,127,55,180,46,105,71,59,203,28,89,192,107,119,245,68,238,203,30,161,237,33,241,192,93,253,246,103,53,52,243,139,86,89,56,84,81,88,62,221,155,75,104,14,198,99,33,146,137,51,71,183,117,150,180,38,64,152,0,79,66,63,157,196,101,33,116,150,176,233,247,130,167,38,42,209,217,52,203,237,110,8,159,63,183,210,144,237,23,210,70,67,152,192,47,45,253,141,156,205,26,188,195,128,206,123,169,183,183,150,245,147,117,118,221,13,29,55,66,135,161,186,149,156,107,158,129,164,137,28,95,56,20,170,141,197,127,236,197,228,129,124,250,111,170,23,80,169,74,96,189,107,230,18,114,165,110,70,110,247,30,172,170,130,153,52,156,184,30,53,177,42,39,27,76,17,199,136,9,187,25,213,177,61,214,238,237,161,22,189,31,16,207,15,154,100,155,109,247,194,83,12,231,153,186,63,71,189,21,49,222,230,130,238,126,123,123,20,18,13,217,241,162,131,28,176,111,27,212,24,213,53,159,145,238,210,19,154,255,217,204,236,207,131,223,229,61,228,228,182,30,71,113,202,76,109,83,94,34,243,231,176,156,62,143,237,111,166,112,154,30,238,134,158,236,9,231,34,174,116,0,94,138,52,125,213,110,184,163,225,81,234,94,103,172,57,181,75,19,178,125,58,174,125,249,64,178,116,195,155,168,195,68,235,90,45,212,147,32,15,240,60,104,82,162,51,60,72,68,205,221,119,254,224,150,114,95,43,184,183,182,184,62,204,32,173,55,233,31,63,255,121,64,176,215,77,238,105,98,215,74,239,102,116,15,140,233,77,71,167,80,174,41,204,88,195,188,53,99,226,250,182,31,235,176,229,80,82,207,13,121,134,237,240,80,125,231,251,225,188,234,112,25,186,113,106,247,143,61,80,219,132,140,67,235,60,227,94,151,63,227,237,61,243,238,199,228,215,247,61,197,186,223,73,21,196,213,123,239,207,158,183,80,183,157,87,171,237,197,183,255,0,190,107,33,101,179,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9651ca92-7510-4b7c-a4e3-8498edb76804"));
		}

		#endregion

	}

	#endregion

}
