﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCEnabledStrategiesAnalizationRuleSchema

	/// <exclude/>
	public class DCEnabledStrategiesAnalizationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCEnabledStrategiesAnalizationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCEnabledStrategiesAnalizationRuleSchema(DCEnabledStrategiesAnalizationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0d13a6b-c13b-4508-ac19-81807f584656");
			Name = "DCEnabledStrategiesAnalizationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,87,75,111,227,54,16,62,123,129,253,15,3,245,98,3,169,188,237,49,217,4,72,157,108,80,96,55,45,54,105,115,88,236,129,166,71,54,177,18,41,144,84,28,39,205,127,239,240,37,59,178,148,199,165,232,205,34,231,249,205,204,55,180,100,21,154,154,113,132,107,212,154,25,85,216,124,166,100,33,150,141,102,86,40,153,159,109,36,171,4,167,67,139,210,190,127,247,240,254,221,168,49,66,46,225,106,99,44,86,71,237,247,174,133,170,82,146,110,232,238,39,141,75,178,3,179,146,25,115,8,103,179,115,201,230,37,46,174,44,57,160,43,52,167,146,149,155,123,239,237,107,83,162,215,154,78,167,240,209,52,85,197,244,230,36,126,71,141,13,104,52,170,188,69,13,154,196,193,174,152,5,230,108,24,52,244,133,96,44,201,129,42,250,156,129,241,81,131,65,107,41,232,60,249,154,238,56,171,155,121,41,56,112,23,241,43,2,6,151,85,10,238,107,140,45,100,50,122,240,217,180,32,156,203,166,34,16,254,212,202,34,183,184,8,183,221,100,253,65,244,74,129,46,43,2,222,123,163,204,82,12,121,171,184,27,249,232,219,167,146,45,205,119,247,179,78,78,0,201,107,47,22,174,150,163,209,165,146,8,199,240,225,192,127,93,104,213,212,174,156,199,240,75,56,161,106,206,133,12,71,191,186,147,199,152,20,202,69,200,235,105,146,212,42,20,103,195,173,210,46,87,15,230,51,137,238,136,131,85,80,107,172,153,70,32,240,45,240,21,19,18,164,90,32,172,133,93,169,134,42,13,18,239,108,40,253,156,190,221,57,44,176,96,77,105,183,62,16,129,107,44,142,51,170,204,14,128,169,74,191,49,131,217,244,4,4,185,102,146,227,0,154,254,132,162,97,21,208,16,224,113,198,221,20,220,217,236,228,84,182,186,174,209,6,29,206,162,2,249,242,237,148,127,156,122,123,253,230,99,26,41,202,236,228,70,148,37,204,145,58,222,54,90,82,41,69,65,104,164,54,216,128,169,145,139,66,224,226,137,221,216,191,47,119,238,184,55,88,136,89,134,234,143,134,17,132,78,188,19,154,132,57,157,143,147,129,125,129,135,157,254,121,75,55,84,184,16,212,196,157,126,240,211,222,182,195,255,164,136,46,30,7,238,182,122,52,137,28,141,249,175,203,55,192,74,144,2,156,132,250,118,107,214,94,63,41,214,208,176,19,149,213,168,45,5,247,58,90,251,93,242,178,89,16,247,20,142,168,28,236,177,71,192,52,117,173,180,125,51,229,109,121,174,143,226,206,130,245,253,139,99,175,60,234,209,201,91,10,252,167,207,100,222,242,225,209,243,208,124,65,98,172,133,199,69,220,146,114,184,173,195,71,111,176,23,184,31,232,56,214,97,116,203,52,49,121,231,246,111,86,54,142,188,103,74,99,103,113,211,122,190,10,75,142,50,66,235,37,199,177,71,242,191,12,106,250,45,9,56,146,141,147,158,245,196,148,29,192,88,72,59,25,194,113,114,228,117,3,65,193,184,199,194,164,63,232,163,157,230,74,152,80,173,29,236,20,237,103,126,127,229,63,66,216,241,162,228,247,151,52,99,9,145,116,170,56,43,197,189,115,18,116,156,12,97,18,174,243,79,74,87,204,142,179,207,93,49,147,63,124,120,204,189,3,202,50,217,62,106,193,222,179,75,54,37,174,97,207,208,0,170,249,141,210,63,252,227,42,119,243,215,104,78,242,74,179,37,70,188,29,95,168,162,15,179,206,160,79,14,250,147,140,193,70,28,110,99,47,236,137,230,91,192,71,196,64,227,40,72,217,52,101,153,192,28,13,171,83,61,102,84,251,70,99,168,198,5,74,212,172,236,36,149,83,139,68,177,3,40,88,105,82,120,143,187,29,114,219,173,253,203,211,243,226,3,98,133,252,135,129,245,74,240,213,16,119,128,91,34,177,17,91,30,185,89,161,244,43,68,201,114,3,238,21,212,50,179,48,91,114,142,219,215,128,176,79,85,137,202,49,189,210,182,158,126,38,147,90,173,195,83,20,239,56,214,190,25,146,230,31,116,172,215,130,182,39,193,92,154,176,190,220,243,85,132,122,251,85,54,196,117,254,36,134,243,234,245,213,125,244,208,102,221,145,117,61,64,167,180,129,146,221,214,81,27,124,20,61,79,223,217,201,117,72,113,77,48,28,38,249,75,213,139,190,7,179,11,253,53,129,128,238,162,145,91,222,231,110,175,23,74,247,160,154,239,44,70,69,139,76,139,133,163,208,193,151,9,181,108,250,62,173,107,210,114,6,175,149,223,154,207,18,42,13,64,63,11,111,121,129,254,49,25,234,247,32,217,33,170,236,82,237,233,158,107,173,244,151,160,148,165,145,165,231,11,117,235,120,207,127,59,142,220,165,209,183,126,220,115,253,48,200,140,124,167,121,82,106,107,51,142,225,69,71,195,118,210,150,75,182,226,128,58,99,103,179,116,153,64,76,20,247,162,213,118,57,246,154,109,111,223,108,247,181,59,185,235,150,186,59,154,142,239,140,215,67,247,56,204,82,225,244,233,33,157,253,11,83,80,139,66,78,15,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoEnabledStrategiesErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoEnabledStrategiesErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("542c751e-6e66-4180-b1f9-e65e7639c0ef"),
				Name = "NoEnabledStrategiesErrorMessage",
				CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a"),
				CreatedInSchemaUId = new Guid("c0d13a6b-c13b-4508-ac19-81807f584656"),
				ModifiedInSchemaUId = new Guid("c0d13a6b-c13b-4508-ac19-81807f584656")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0d13a6b-c13b-4508-ac19-81807f584656"));
		}

		#endregion

	}

	#endregion

}

