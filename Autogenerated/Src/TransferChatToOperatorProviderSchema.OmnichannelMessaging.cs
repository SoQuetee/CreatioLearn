﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TransferChatToOperatorProviderSchema

	/// <exclude/>
	public class TransferChatToOperatorProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TransferChatToOperatorProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TransferChatToOperatorProviderSchema(TransferChatToOperatorProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c");
			Name = "TransferChatToOperatorProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,87,89,111,27,55,16,126,86,128,252,7,98,219,135,21,32,172,144,87,199,86,224,200,174,97,192,71,16,203,237,99,64,113,71,50,219,93,82,37,185,178,21,65,255,189,195,107,47,173,29,3,125,49,180,228,204,55,199,55,7,45,104,9,122,67,25,144,5,40,69,181,92,153,108,46,197,138,175,43,69,13,151,226,227,135,253,199,15,163,74,115,177,38,15,59,109,160,252,220,251,70,249,162,0,102,133,117,118,5,2,20,103,71,50,55,92,252,219,28,182,109,149,165,20,195,55,45,47,178,251,82,112,246,68,133,128,34,187,5,173,233,26,165,135,213,20,224,57,222,76,167,83,114,170,171,178,164,106,55,11,223,223,97,163,64,131,48,154,172,42,225,124,166,5,55,59,34,87,196,40,42,244,10,129,44,32,218,50,196,72,34,55,128,30,72,149,69,192,105,11,113,83,45,11,206,8,43,168,214,100,17,212,231,168,185,144,247,65,239,155,146,91,158,131,34,39,228,43,213,224,46,131,96,188,66,160,189,115,120,244,155,130,53,122,68,240,6,213,13,7,125,130,191,249,150,26,240,2,27,255,65,44,76,180,48,167,236,9,200,15,214,63,250,252,182,66,247,235,108,54,128,64,190,124,33,233,192,241,25,17,240,124,12,153,62,106,140,94,34,69,46,175,227,241,231,16,21,136,220,7,214,141,242,22,204,147,204,95,11,81,27,199,195,21,152,27,246,115,1,47,198,179,14,233,85,197,115,71,207,117,62,33,238,3,189,153,187,239,49,177,181,58,26,165,65,57,146,119,135,69,62,137,136,57,87,232,32,228,247,173,203,49,198,212,170,48,139,22,217,193,138,174,195,60,23,249,197,128,246,215,157,55,159,70,175,26,135,28,9,35,5,166,82,34,56,144,253,33,85,73,77,106,115,120,35,25,150,223,79,186,44,224,193,93,246,114,152,253,37,213,63,174,61,179,239,160,101,165,24,202,73,133,105,152,144,228,237,130,75,38,206,244,40,57,178,161,179,118,21,42,200,27,229,236,79,90,84,144,140,39,189,212,13,230,204,197,118,232,178,182,149,200,71,132,110,112,61,105,17,179,38,142,117,88,11,252,152,198,49,159,68,228,198,11,102,11,25,178,20,242,218,41,191,236,113,147,163,11,231,152,184,173,235,51,61,151,149,48,105,219,234,167,160,120,39,13,95,113,36,247,14,158,23,93,123,238,106,215,209,98,109,46,219,170,143,66,1,205,67,97,6,69,71,43,215,230,212,70,56,35,251,86,212,228,48,57,142,46,192,110,169,34,165,7,122,187,22,237,119,176,168,67,193,141,179,27,170,205,189,186,128,21,173,10,147,14,120,138,37,181,5,165,221,44,253,127,254,78,162,155,125,43,62,25,77,226,223,131,223,169,161,215,230,4,250,142,165,81,49,212,177,195,194,205,92,47,209,159,240,238,224,90,112,195,109,197,131,118,115,138,163,54,21,184,224,112,196,159,106,0,194,20,172,206,126,213,61,211,26,175,51,241,253,201,134,42,90,18,129,77,112,150,84,157,134,77,102,182,129,9,107,58,248,116,234,164,135,149,67,42,147,89,224,132,224,170,220,20,182,145,112,245,44,129,184,5,163,159,32,239,192,132,181,243,118,4,189,73,66,186,126,78,72,189,68,163,233,72,43,110,170,37,110,170,180,175,80,223,239,223,193,89,51,219,127,69,87,140,66,15,174,220,247,48,208,20,84,50,187,206,113,183,187,122,180,116,91,250,107,180,35,34,252,84,214,51,156,172,216,53,86,222,123,208,126,6,80,225,214,139,191,225,53,56,130,69,237,22,33,233,82,202,194,143,182,113,29,87,127,244,197,105,103,27,158,201,162,42,133,14,11,245,130,251,247,136,218,157,250,81,136,83,120,249,55,166,127,22,84,70,123,146,220,55,193,78,186,173,90,139,60,138,141,146,12,217,130,252,86,175,93,47,162,236,167,182,200,131,161,166,210,14,163,53,106,234,146,112,29,167,179,107,129,197,180,198,247,146,182,37,230,117,200,193,129,28,124,243,119,215,47,198,97,127,224,27,75,106,142,110,237,178,57,142,4,131,195,152,23,110,48,164,113,132,132,192,195,8,225,43,146,182,64,206,92,6,179,203,114,99,118,49,91,113,133,166,43,90,104,56,222,176,222,43,163,118,81,62,44,147,102,164,30,63,36,230,175,108,107,71,141,118,207,214,219,182,250,67,251,40,237,78,193,81,47,240,243,60,174,133,180,131,132,156,85,134,252,136,90,183,84,224,161,178,226,93,244,142,210,43,54,230,133,212,176,104,85,107,39,197,71,81,61,248,221,241,77,193,150,195,115,147,240,254,64,31,13,172,239,246,54,60,2,110,239,153,78,20,97,3,244,158,52,243,10,151,137,48,246,52,179,120,209,139,176,219,222,202,67,36,155,48,106,216,19,73,47,95,24,108,220,116,131,151,186,82,110,228,58,187,84,10,189,254,61,57,199,27,251,147,72,198,172,217,156,60,99,45,66,183,199,173,85,178,247,110,28,236,0,138,97,147,125,19,247,33,35,14,148,236,225,37,252,3,2,135,36,166,224,93,213,105,29,187,128,101,181,70,199,236,245,73,99,244,153,234,246,166,125,221,137,164,251,162,76,113,47,30,219,27,158,205,238,20,255,252,7,67,49,17,72,242,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChatTransferredToOperatorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChatTransferredToOperatorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("82850838-c01b-d332-95bd-3af1d1a36883"),
				Name = "ChatTransferredToOperator",
				CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988"),
				CreatedInSchemaUId = new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c"),
				ModifiedInSchemaUId = new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("accd91a0-9e13-456b-b569-3e33b4b3136c"));
		}

		#endregion

	}

	#endregion

}
