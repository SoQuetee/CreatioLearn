﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DownloadWsdlEndpointSchema

	/// <exclude/>
	public class DownloadWsdlEndpointSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DownloadWsdlEndpointSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DownloadWsdlEndpointSchema(DownloadWsdlEndpointSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654");
			Name = "DownloadWsdlEndpoint";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0cd720a-279e-436c-a704-8c755267ad15");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,235,79,219,72,16,255,156,74,253,31,182,233,125,112,164,200,234,125,45,7,85,10,161,205,9,40,106,194,81,9,33,100,236,33,177,234,71,186,187,6,114,40,255,251,205,236,195,94,191,2,237,157,116,124,64,246,120,94,59,143,223,204,38,11,82,16,235,32,4,182,0,206,3,145,223,73,255,48,207,238,226,101,193,3,25,231,153,63,7,126,31,135,112,4,34,94,102,192,95,191,122,122,253,234,245,171,65,33,226,108,201,230,27,33,33,221,107,188,163,134,36,129,144,196,133,255,9,80,42,14,91,60,39,113,246,163,69,60,3,233,127,150,114,221,250,96,188,56,205,35,72,118,126,244,39,104,247,94,185,190,155,239,18,110,91,12,11,120,148,109,226,138,67,16,33,193,95,4,226,187,104,125,255,150,38,141,195,184,161,76,83,215,17,247,11,7,255,56,8,101,206,99,16,189,28,174,203,152,23,201,81,162,139,25,79,83,25,195,239,111,57,44,49,4,236,48,9,132,120,207,142,242,135,44,201,131,8,125,157,135,43,72,131,233,99,8,107,10,146,226,94,23,183,73,28,178,144,152,119,240,178,247,204,145,27,232,66,168,76,97,182,37,47,232,68,104,241,92,169,212,28,70,125,191,98,15,5,233,60,88,139,34,88,194,136,132,6,239,217,109,32,192,179,52,246,68,212,237,175,105,28,87,142,179,56,195,130,44,95,187,108,141,155,60,53,219,111,33,139,244,145,213,187,166,54,136,141,240,151,254,157,7,92,192,142,216,247,48,254,203,192,247,104,253,213,168,191,76,221,255,28,114,91,26,151,34,74,166,89,180,206,227,76,42,190,43,211,82,182,155,174,137,54,17,107,132,30,108,160,53,34,199,109,156,196,114,243,21,126,20,49,135,20,50,41,60,247,133,122,145,237,179,103,68,136,203,55,132,104,116,221,215,100,174,123,152,229,143,24,18,227,95,71,158,27,197,116,28,39,32,76,102,56,97,30,52,171,200,112,12,172,166,86,6,21,131,55,155,102,69,10,60,184,77,224,15,157,196,3,86,240,68,152,36,12,6,115,25,132,223,241,204,25,60,48,245,108,217,60,197,182,167,184,182,117,27,53,62,253,102,213,45,65,54,68,140,251,71,177,26,26,1,223,24,65,42,11,121,117,125,192,110,238,200,211,61,215,64,63,179,58,21,219,183,82,236,195,7,230,153,71,125,134,94,81,111,52,218,107,248,116,18,11,89,30,227,102,205,243,16,43,22,162,99,227,143,235,81,141,245,188,198,169,188,169,11,107,183,26,52,237,159,171,168,114,169,187,25,202,242,56,142,33,137,8,0,180,227,245,194,16,18,171,52,100,52,91,15,147,24,11,148,221,172,202,231,189,14,78,154,121,121,150,108,88,87,113,220,196,233,58,231,242,12,107,92,156,209,6,161,253,190,186,102,79,108,168,191,13,199,248,148,133,73,17,193,144,109,107,22,66,194,43,102,208,66,215,225,73,30,170,145,61,145,72,189,45,36,144,86,84,58,20,181,207,195,14,61,212,56,167,193,99,156,22,169,214,37,14,243,2,105,251,236,247,119,239,94,194,63,143,255,134,143,27,169,14,129,34,234,111,111,119,168,79,65,174,242,159,136,245,39,144,213,155,103,219,42,190,195,252,87,89,96,111,48,136,69,146,148,93,199,65,22,60,107,37,138,234,192,72,191,81,144,160,183,136,141,191,224,27,52,228,13,187,176,165,50,143,137,201,139,90,250,71,165,69,215,27,93,137,174,219,174,245,30,223,182,157,145,232,42,33,244,116,166,10,5,34,157,134,11,68,18,59,66,30,83,181,236,144,111,78,172,42,170,63,19,103,24,169,47,252,114,21,75,152,211,254,234,141,154,113,107,55,146,123,128,111,71,121,88,16,82,179,199,242,105,159,149,84,95,205,54,199,164,17,54,186,75,25,31,247,226,16,171,36,160,41,161,7,219,192,191,92,1,7,15,18,208,90,59,250,133,118,108,25,196,153,176,92,62,145,125,170,243,68,61,45,242,147,252,1,56,158,202,42,157,3,173,212,174,86,43,90,54,141,183,163,153,70,117,231,146,38,15,41,108,19,109,73,214,125,120,153,176,255,87,144,20,80,55,91,111,103,18,171,83,40,177,185,212,185,157,166,107,185,209,232,215,42,172,64,108,178,144,209,62,238,22,212,5,143,77,182,108,33,21,60,182,101,113,31,112,150,234,190,159,36,9,6,55,170,218,31,51,143,226,42,250,248,22,205,149,176,55,60,237,97,31,154,98,32,149,184,129,231,220,118,28,74,105,174,30,133,211,78,102,171,78,242,141,45,97,210,92,235,197,6,130,104,129,1,145,190,226,253,13,129,13,78,245,34,133,192,173,223,81,40,120,8,98,233,232,193,187,152,156,80,228,60,234,13,140,150,71,241,177,202,200,166,112,67,98,53,249,182,235,62,227,76,0,46,236,251,9,100,75,185,50,210,212,160,142,244,65,15,198,150,77,58,144,43,158,63,168,38,237,219,39,13,163,78,165,127,156,243,52,144,94,95,10,199,61,6,199,206,153,198,170,30,140,90,123,236,173,5,13,115,216,105,38,10,14,243,34,164,177,140,107,139,44,112,160,68,80,198,220,32,128,142,109,43,68,95,49,68,19,161,243,173,67,109,81,135,97,133,135,43,230,245,173,248,80,134,70,71,6,92,180,50,178,253,220,106,171,121,238,54,100,99,216,93,179,58,58,99,84,237,88,110,1,186,106,171,142,218,54,95,48,32,121,193,67,13,57,78,231,37,154,157,70,128,22,192,250,250,109,120,210,164,10,255,201,213,176,213,24,162,199,254,160,50,81,36,118,62,181,52,120,23,2,56,102,35,211,191,63,96,66,180,186,57,142,72,186,103,232,160,225,1,22,155,53,38,85,225,238,184,237,94,29,238,181,73,23,136,158,223,12,156,107,216,213,151,53,232,95,83,220,75,199,224,10,47,237,179,236,62,255,14,158,22,163,133,231,252,203,124,129,35,26,155,115,1,233,58,161,160,35,21,253,173,239,236,166,222,144,211,246,191,206,45,50,163,86,131,5,154,228,255,41,240,62,117,237,92,224,28,244,236,83,108,181,42,92,237,228,48,25,199,157,207,189,42,80,174,31,107,236,38,81,141,43,135,115,111,32,17,7,180,136,249,57,175,202,123,137,238,82,148,194,251,175,201,237,182,5,166,15,43,84,161,214,7,71,163,175,110,36,190,222,21,15,216,187,10,152,202,209,145,160,222,78,161,243,124,93,194,129,221,76,92,174,250,234,95,205,122,84,89,109,41,216,212,72,143,179,2,172,166,109,221,1,186,176,152,115,151,88,94,31,114,164,239,103,220,80,71,221,239,218,150,29,175,40,29,15,60,207,150,36,85,22,213,75,199,163,210,54,44,189,122,1,202,215,161,169,97,121,220,229,44,1,85,82,142,173,50,108,93,91,166,198,126,65,187,165,101,119,10,3,67,93,125,215,135,236,216,73,157,60,84,54,217,14,68,254,153,24,206,178,48,231,28,177,170,74,156,230,255,47,99,72,225,170,112,221,41,180,234,244,181,253,236,130,74,255,128,189,121,97,89,151,66,118,199,196,117,15,77,79,131,112,85,87,88,198,103,208,221,86,133,112,4,170,243,111,203,199,134,152,254,63,137,34,234,132,49,155,98,44,213,239,180,147,249,225,108,70,203,142,218,0,106,9,44,29,52,171,236,45,186,229,225,253,104,116,59,194,157,123,194,121,80,174,156,109,123,141,0,24,195,125,139,132,69,191,46,167,27,59,65,87,21,149,122,42,144,187,11,18,97,209,162,218,87,104,152,207,178,187,220,96,103,245,110,195,109,55,195,125,6,190,121,54,99,80,255,176,179,224,244,251,63,125,173,94,13,195,182,227,206,103,45,239,24,135,93,63,208,33,237,31,79,61,213,77,109,24,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIncorrectSchemaFileFormatLocalizableString());
			LocalizableStrings.Add(CreateMaximumAllowedSchemaCountLocalizableString());
			LocalizableStrings.Add(CreateMaximumAllowedSchemaSizeLocalizableString());
			LocalizableStrings.Add(CreateErrorDownloadingSchemaLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIncorrectSchemaFileFormatLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c306e853-9250-8ec2-5eb8-8d20c3f1a2f2"),
				Name = "IncorrectSchemaFileFormat",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMaximumAllowedSchemaCountLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eb94bbf5-635a-14b1-5b42-30dedea15cd5"),
				Name = "MaximumAllowedSchemaCount",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMaximumAllowedSchemaSizeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4e504b53-dee4-b7af-dc93-e1edb4c227d3"),
				Name = "MaximumAllowedSchemaSize",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorDownloadingSchemaLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("08b3439f-c526-1082-45a3-699063acba68"),
				Name = "ErrorDownloadingSchema",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"));
		}

		#endregion

	}

	#endregion

}

