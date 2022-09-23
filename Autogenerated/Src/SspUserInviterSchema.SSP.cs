﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserInviterSchema

	/// <exclude/>
	public class SspUserInviterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserInviterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserInviterSchema(SspUserInviterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35314301-48db-4886-bb11-d28d71215caa");
			Name = "SspUserInviter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,88,89,111,219,56,16,126,118,129,254,7,214,125,145,129,64,121,175,227,20,206,209,214,139,108,155,141,155,205,227,130,145,198,54,81,153,84,73,42,137,91,228,191,239,240,146,40,89,138,219,2,65,36,145,115,126,115,112,104,78,183,160,74,154,1,249,10,82,82,37,86,58,61,23,124,197,214,149,164,154,9,158,46,151,215,175,95,253,124,253,106,84,41,198,215,100,185,83,26,182,211,206,55,242,20,5,100,134,65,165,31,129,131,100,217,30,205,5,213,116,111,241,138,241,239,205,98,108,196,118,43,120,255,142,132,161,245,244,226,172,111,235,14,238,95,16,104,118,63,105,93,166,243,123,165,37,117,94,116,13,93,130,214,248,165,200,140,88,69,29,144,118,42,16,32,35,178,190,149,176,198,13,114,94,80,165,222,145,165,42,111,21,200,5,127,96,26,164,165,56,62,62,38,39,170,218,110,169,220,157,250,111,75,77,30,55,44,219,16,102,105,73,133,108,138,104,65,74,33,53,45,210,192,121,28,177,150,213,125,193,50,146,89,238,174,170,145,137,29,254,213,38,93,75,81,130,212,12,208,46,124,215,24,54,200,173,73,123,54,217,5,35,141,100,130,115,23,223,180,38,140,77,24,149,65,146,165,63,175,201,187,159,198,154,209,104,13,218,0,60,122,118,122,75,201,30,40,58,139,240,27,196,255,163,101,121,43,139,233,160,73,103,84,1,65,34,244,218,226,79,42,89,28,180,203,11,159,91,217,100,118,26,212,144,247,239,73,18,222,103,228,35,232,121,35,25,215,146,201,100,250,2,60,113,204,30,133,252,70,30,153,222,152,164,153,231,91,198,111,57,211,39,10,128,100,18,86,179,241,194,71,199,238,49,147,109,90,200,241,241,169,139,221,65,23,122,217,73,239,226,79,98,48,38,202,252,243,40,191,5,158,187,28,240,223,125,9,97,83,233,37,119,235,66,39,98,229,147,210,231,170,58,194,23,165,41,207,64,153,77,189,129,30,215,109,98,90,108,15,250,237,210,250,10,125,58,217,231,62,37,77,154,251,162,27,244,16,243,15,113,169,50,4,6,125,44,15,249,184,192,160,49,90,176,31,232,7,37,28,30,107,191,188,91,36,242,171,93,111,191,232,83,155,41,233,212,72,213,250,156,248,154,137,220,197,52,53,86,13,33,147,76,166,53,71,36,118,214,17,236,136,122,179,199,201,239,219,74,58,198,197,101,60,4,255,223,160,55,34,183,237,198,214,121,111,209,247,212,157,119,252,129,74,159,104,75,116,222,85,105,187,41,227,145,163,255,165,69,5,29,36,143,200,248,58,102,28,31,121,109,233,229,182,212,187,73,122,5,43,253,101,117,195,214,27,189,21,10,95,147,241,241,216,163,199,86,36,241,212,11,245,185,42,138,47,210,114,37,45,91,38,193,202,145,4,93,73,78,204,73,130,22,104,120,194,35,169,146,18,184,38,111,16,79,20,224,232,70,239,9,158,56,183,154,21,204,212,156,177,253,154,26,178,142,251,61,130,210,27,248,94,129,210,19,47,233,221,175,227,240,39,8,60,143,236,193,17,60,107,249,221,215,190,151,96,90,3,57,151,128,95,113,7,252,167,2,185,75,108,186,126,172,88,126,234,78,181,128,156,23,111,51,206,74,232,88,239,189,53,51,70,181,229,201,88,229,232,197,120,145,143,187,27,153,89,191,220,82,86,244,111,25,150,116,174,146,177,129,21,207,249,30,17,78,246,103,156,138,234,173,15,82,108,147,113,236,142,33,81,13,175,133,176,194,58,254,75,48,94,11,247,170,178,154,236,75,45,62,82,143,169,117,249,189,162,69,100,161,39,191,219,128,132,216,217,116,193,19,103,102,138,249,130,22,162,70,149,56,36,39,132,42,15,94,95,96,30,4,203,201,28,193,52,95,6,92,213,42,46,43,227,171,240,136,99,117,69,173,198,219,241,100,14,204,167,52,70,97,145,155,188,54,241,12,185,228,163,103,196,25,114,243,236,112,76,210,175,194,164,65,232,80,125,29,38,109,25,122,182,91,228,222,203,218,194,201,160,143,55,64,115,195,102,70,205,218,197,110,222,253,185,131,46,52,191,239,166,105,37,86,117,58,231,187,164,105,25,1,124,99,174,147,106,43,197,204,152,3,53,228,194,237,164,250,249,52,185,56,187,124,130,172,50,125,59,191,55,175,222,193,166,130,210,75,174,42,9,23,103,205,82,100,69,144,179,48,102,24,4,209,47,233,30,179,62,243,82,167,14,28,105,226,116,70,226,70,56,12,21,64,18,39,35,53,100,177,182,198,109,4,120,70,188,42,211,186,92,118,219,6,230,226,149,216,196,159,238,49,118,34,248,129,241,124,32,128,179,153,215,20,73,9,209,8,109,57,54,109,100,163,105,123,8,42,233,55,205,53,80,52,206,183,154,105,135,219,152,102,58,200,97,1,174,207,116,249,235,246,48,40,192,131,19,245,145,70,198,115,120,11,47,254,233,30,207,67,149,131,71,200,165,148,66,126,16,210,214,221,29,78,177,162,210,214,197,166,91,12,212,77,239,49,249,228,96,156,76,82,148,121,73,179,141,163,245,88,99,164,170,12,7,69,83,141,43,90,40,152,134,117,107,70,152,112,68,102,230,48,122,95,192,210,234,232,28,13,233,29,78,220,246,254,138,105,166,68,37,51,164,19,146,174,225,200,123,223,157,207,176,153,238,9,85,1,242,79,84,125,22,214,234,212,2,93,31,132,189,29,231,94,136,130,156,111,32,251,182,88,205,139,194,89,134,231,52,246,134,206,209,246,38,198,205,180,128,95,64,237,55,7,171,195,247,184,37,10,33,96,51,219,94,81,90,179,251,193,171,199,3,147,26,207,169,144,44,60,247,238,236,31,36,24,237,102,76,29,110,180,46,250,30,224,21,94,169,49,67,72,82,183,6,119,251,101,188,43,179,213,59,75,28,180,241,206,149,223,64,38,30,92,227,188,18,107,44,254,48,92,249,36,112,63,73,80,211,178,28,225,181,103,188,98,252,219,222,172,212,232,175,75,249,200,95,27,67,157,221,32,254,246,184,66,134,79,80,148,182,205,117,151,130,242,26,45,187,103,195,251,146,78,75,208,90,169,235,252,136,132,226,238,122,158,6,143,206,55,148,175,161,49,245,249,183,210,232,208,205,104,158,231,237,188,105,126,153,8,151,64,146,213,55,196,129,164,178,43,165,25,97,8,71,108,103,99,199,57,62,117,179,186,235,240,62,45,15,93,32,79,142,173,160,248,110,229,134,157,220,39,104,178,207,230,101,247,245,52,100,75,252,110,92,127,3,183,68,11,64,25,25,237,126,5,192,97,222,36,174,243,38,148,66,233,46,217,187,151,239,133,161,202,6,239,188,78,92,123,132,107,15,61,126,176,122,185,157,55,99,201,64,255,170,203,172,51,53,78,195,8,20,53,128,40,209,66,195,107,95,205,135,18,208,173,182,23,113,237,127,176,145,99,140,148,20,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateContactHasNoEmailLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateContactHasNoEmailLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6262f843-99e3-4dc0-a187-67f2246e8f46"),
				Name = "ContactHasNoEmail",
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("35314301-48db-4886-bb11-d28d71215caa"),
				ModifiedInSchemaUId = new Guid("35314301-48db-4886-bb11-d28d71215caa")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35314301-48db-4886-bb11-d28d71215caa"));
		}

		#endregion

	}

	#endregion

}

