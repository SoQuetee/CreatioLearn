﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseRecordsOperationWorkerSchema

	/// <exclude/>
	public class BaseRecordsOperationWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseRecordsOperationWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseRecordsOperationWorkerSchema(BaseRecordsOperationWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5");
			Name = "BaseRecordsOperationWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,87,223,111,219,54,16,126,214,128,253,15,156,247,34,3,134,176,231,36,14,144,38,78,102,160,89,219,56,91,31,186,162,160,165,139,205,141,38,29,146,114,99,20,249,223,119,20,169,95,148,233,120,64,16,75,228,241,238,190,187,239,142,39,65,55,160,183,52,7,242,8,74,81,45,159,76,118,45,197,19,91,149,138,26,38,5,249,241,243,79,73,169,153,88,145,197,94,27,216,156,7,239,217,123,38,158,7,139,215,146,115,200,173,2,157,221,129,0,197,242,86,166,107,74,65,108,61,155,9,195,12,3,125,88,96,179,145,162,221,89,113,185,164,252,236,204,173,103,239,229,106,133,203,184,143,18,191,42,88,89,36,215,156,106,125,70,222,81,13,15,144,75,85,232,15,91,112,40,63,75,245,47,168,74,122,91,46,57,203,9,93,106,163,104,110,72,110,79,29,57,68,206,200,60,178,243,163,82,216,216,191,101,192,11,116,224,163,98,59,106,192,109,110,221,11,209,6,79,230,68,1,45,164,224,123,50,71,8,228,27,199,127,83,130,143,247,84,208,21,40,140,165,177,216,64,165,163,251,146,27,118,3,28,12,140,198,231,222,20,136,194,89,139,153,150,6,211,2,69,109,220,191,182,118,255,212,160,144,0,194,37,47,120,61,143,28,154,223,176,106,159,170,253,5,134,13,35,63,33,114,249,15,74,93,146,143,84,33,199,12,40,29,156,246,81,107,130,54,123,129,188,52,82,145,193,202,27,224,208,63,52,90,230,40,121,12,98,60,133,105,0,186,236,189,78,172,154,36,57,134,113,219,96,28,87,245,146,36,129,198,105,160,179,10,69,210,134,6,5,182,253,56,189,30,199,140,40,17,131,173,142,3,136,29,163,170,242,217,47,242,53,108,232,167,18,212,158,124,3,253,28,36,97,40,52,211,207,30,195,10,140,127,74,216,19,73,237,105,50,157,18,81,114,94,195,76,18,23,10,162,43,13,127,32,2,132,210,226,250,50,90,52,27,163,175,217,163,92,84,226,233,248,220,31,119,74,137,128,239,67,87,130,180,100,93,1,95,15,147,142,225,158,206,236,170,40,174,56,119,194,216,140,202,141,208,141,213,87,247,163,192,148,74,180,81,113,235,111,4,254,30,204,90,70,171,216,241,11,19,146,131,214,80,204,118,32,204,149,90,105,130,117,27,219,75,239,74,102,107,201,238,206,139,58,178,179,151,28,182,21,119,224,5,3,132,231,59,101,225,183,106,64,11,186,3,236,10,41,188,76,90,61,110,203,99,180,241,141,218,111,146,249,224,207,162,189,90,141,39,127,235,205,20,253,113,193,234,210,180,198,191,147,8,165,118,167,11,97,66,14,162,180,188,66,124,191,4,172,178,125,47,155,41,37,85,234,8,99,239,164,156,154,180,62,223,97,210,4,181,103,247,8,9,249,80,189,120,228,175,4,184,134,158,198,185,120,146,167,40,28,233,50,183,65,250,91,140,198,227,33,53,122,96,31,96,35,119,208,70,181,226,104,234,126,218,75,144,64,176,48,241,116,247,27,189,120,184,141,48,38,161,134,204,89,246,226,71,220,244,134,144,65,183,76,105,115,170,135,67,151,58,182,175,101,41,12,185,36,191,53,238,121,162,13,36,43,155,233,193,156,212,220,68,148,111,4,249,106,187,229,251,128,191,135,203,38,90,128,42,182,49,61,90,155,65,57,125,16,161,23,102,205,244,36,170,125,28,45,146,70,246,86,170,43,110,111,210,189,187,203,11,127,71,165,243,153,40,55,88,242,75,14,23,22,235,37,201,91,250,248,178,60,53,137,59,170,6,123,86,167,133,63,52,52,30,100,113,1,246,41,101,56,218,145,233,37,169,98,63,182,111,25,182,193,13,94,137,174,197,254,69,121,89,247,225,161,251,80,245,3,40,58,254,78,59,152,50,215,47,6,100,171,252,244,74,159,112,46,164,249,218,57,64,236,159,56,160,182,33,229,65,222,176,34,40,150,36,25,100,231,134,105,195,68,110,194,0,159,94,54,78,240,203,87,39,128,247,180,237,156,97,88,31,229,21,14,180,251,244,64,200,220,249,75,82,120,79,30,64,227,188,231,228,250,107,181,98,180,145,221,41,89,110,223,237,83,102,179,196,14,37,167,78,37,88,9,168,203,211,59,48,172,115,14,84,165,97,240,91,54,217,248,247,189,137,247,43,188,145,227,205,234,132,235,54,50,214,237,152,50,37,229,46,111,195,250,116,35,26,209,168,223,142,11,209,254,64,109,181,214,185,179,171,191,83,81,112,80,23,177,19,151,100,237,36,48,254,129,204,121,211,56,107,145,176,153,251,245,180,118,139,54,189,162,23,149,230,35,36,28,216,108,207,250,168,0,103,198,224,202,33,109,132,131,48,185,166,83,29,25,78,90,199,122,77,237,180,155,244,144,209,174,217,233,106,78,200,163,61,162,234,14,237,173,58,14,201,142,115,38,94,97,26,140,59,231,252,232,236,221,50,110,39,200,62,5,187,27,150,79,246,253,26,89,105,192,173,126,102,102,221,78,159,169,91,196,111,66,68,205,180,20,143,251,45,126,86,62,35,93,234,6,138,231,125,145,84,14,184,74,201,236,56,57,105,113,142,131,54,94,199,180,73,79,59,233,196,231,180,99,44,143,125,64,222,195,102,137,56,188,93,247,97,10,150,128,228,68,138,14,137,217,209,212,171,156,170,85,54,246,143,223,62,53,35,162,116,234,136,158,119,186,225,145,182,137,84,178,185,192,240,13,90,110,255,43,192,43,140,54,232,65,63,246,159,90,111,94,183,157,203,117,216,212,187,40,234,214,55,13,71,170,200,169,239,107,198,225,141,177,206,41,11,42,186,215,44,147,193,87,113,230,30,130,9,240,240,157,231,68,226,151,117,114,120,140,29,78,173,125,91,255,51,18,71,26,190,91,237,47,226,218,127,13,113,128,147,159,18,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSuccessMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("54fcb780-2ca1-4811-a181-edfffeacf325"),
				Name = "SuccessMessage",
				CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f"),
				CreatedInSchemaUId = new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5"),
				ModifiedInSchemaUId = new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a27a219-d701-4c92-b60b-0be3aacd0ff5"));
		}

		#endregion

	}

	#endregion

}
