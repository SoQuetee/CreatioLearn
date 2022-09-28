﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueuesServiceSchema

	/// <exclude/>
	public class QueuesServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueuesServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueuesServiceSchema(QueuesServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e");
			Name = "QueuesService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,219,110,219,70,246,89,5,250,15,179,234,11,133,8,76,242,84,108,98,187,240,53,171,108,236,164,150,220,60,4,197,130,34,143,100,38,188,40,51,67,199,218,192,255,190,231,204,133,28,14,41,89,110,226,69,187,216,135,4,230,240,220,239,103,168,34,202,65,172,162,24,216,12,56,143,68,185,144,225,113,89,44,210,101,197,35,153,150,69,248,107,5,21,136,41,240,155,52,134,31,127,248,250,227,15,131,74,164,197,146,77,215,66,66,254,210,123,70,236,44,131,152,80,69,248,10,10,224,105,220,129,49,212,206,203,4,178,173,47,195,247,48,223,14,112,136,172,110,148,164,29,184,25,220,202,206,97,139,160,171,115,158,187,36,252,55,225,107,177,233,53,135,77,231,225,201,209,198,87,167,133,76,101,10,98,35,192,59,94,198,32,122,223,95,84,105,219,8,39,145,140,208,107,146,71,177,220,9,225,244,86,66,33,200,71,125,224,104,163,173,6,65,233,206,144,83,201,183,201,63,141,175,33,169,50,224,8,129,48,63,113,88,34,63,118,156,69,66,188,96,94,84,33,192,211,167,79,217,158,168,242,60,226,235,3,243,60,69,186,25,176,247,105,145,148,95,20,142,242,164,198,10,45,210,83,7,235,131,121,105,173,241,59,157,29,138,213,5,72,212,104,133,129,50,79,179,84,174,47,225,115,149,114,200,161,144,34,112,31,200,62,108,159,221,131,66,80,161,57,72,70,196,100,85,205,179,52,102,49,169,215,214,142,189,96,71,145,0,243,52,118,2,17,125,34,200,9,83,25,73,8,39,151,16,37,111,139,108,237,158,34,101,202,184,218,124,24,21,43,224,20,56,47,240,111,138,124,109,189,193,74,63,176,201,225,106,85,155,254,61,143,16,154,249,71,116,166,168,14,150,32,205,95,3,14,178,226,198,63,218,187,107,204,95,185,215,67,240,32,24,189,84,72,119,244,255,157,22,224,39,40,18,45,164,121,54,18,159,131,188,46,19,95,92,223,219,234,0,217,9,38,175,129,165,9,43,23,234,175,207,100,73,150,162,193,216,124,237,189,227,85,81,80,60,172,116,166,176,180,16,50,42,116,96,116,35,67,159,172,34,30,229,172,192,170,183,63,172,4,112,140,147,66,87,171,225,193,21,62,179,184,62,8,247,158,42,232,126,100,195,244,106,146,12,15,102,74,44,140,139,116,145,34,9,79,60,71,5,131,228,8,221,101,162,253,32,14,126,109,208,38,9,130,217,115,215,217,168,175,196,160,123,85,161,81,208,120,166,100,40,204,9,34,78,146,224,170,165,35,107,171,60,70,2,220,17,6,149,25,153,112,48,164,106,219,238,123,168,182,60,157,22,203,180,128,176,97,126,180,70,42,65,67,112,204,36,175,192,196,139,137,177,128,4,30,89,11,104,92,138,234,245,111,81,86,65,48,252,220,40,48,212,152,119,91,162,230,82,27,70,217,252,134,8,212,14,0,81,86,60,6,163,229,127,37,44,44,207,11,124,26,30,92,90,9,232,229,102,87,83,163,210,162,111,244,179,114,19,90,202,82,212,150,218,205,187,174,76,214,191,233,130,5,109,112,182,191,207,138,42,203,70,94,65,48,198,59,205,87,114,237,100,253,224,38,226,53,229,41,86,139,104,9,221,40,121,95,242,79,106,188,8,47,219,160,47,59,52,16,185,128,47,236,77,25,71,89,250,239,104,158,33,40,113,14,60,38,99,54,108,149,215,225,88,139,107,228,60,43,121,30,201,96,216,161,35,194,175,207,238,66,101,183,225,184,109,19,47,58,27,137,172,69,126,105,89,1,11,186,5,209,244,94,62,168,12,170,70,177,37,158,167,233,210,68,115,92,113,142,85,69,25,149,201,18,185,198,144,222,0,139,188,198,168,43,76,181,74,40,86,138,146,202,80,172,135,183,254,144,255,240,22,179,77,1,184,109,114,240,1,91,210,164,184,41,63,65,160,165,69,151,12,223,189,157,206,208,94,87,60,157,65,190,202,136,3,158,78,171,185,136,121,58,7,52,183,246,198,133,195,86,24,159,28,149,201,122,42,215,25,161,32,237,115,204,118,116,96,125,26,234,94,148,140,169,145,130,144,218,117,45,88,125,164,134,47,77,18,195,104,133,12,96,59,172,234,200,182,37,223,148,88,29,239,17,56,176,81,79,17,233,231,5,107,167,217,203,93,19,72,94,115,116,14,5,245,33,95,86,52,55,92,224,235,211,219,24,86,4,31,12,219,116,135,35,63,189,136,254,36,233,102,213,177,142,11,66,15,39,73,35,207,223,180,102,87,146,230,21,28,17,194,30,77,107,67,112,65,131,190,140,176,107,6,154,209,168,150,220,20,142,92,27,22,5,104,39,151,6,26,116,202,145,95,127,134,135,73,130,104,36,231,172,220,46,139,241,225,112,52,54,90,27,99,12,124,149,222,148,203,19,152,87,203,192,8,183,9,238,30,213,81,178,160,197,200,29,101,122,211,242,74,165,151,78,204,238,92,138,103,0,137,154,78,237,172,196,62,150,243,71,75,64,45,141,86,114,198,211,229,18,56,2,237,154,112,38,149,118,201,58,246,71,51,174,71,194,86,150,161,36,173,36,59,116,159,155,152,246,192,30,154,98,45,170,237,12,243,35,166,79,224,22,247,80,79,238,237,172,189,127,62,113,3,167,160,78,239,76,129,157,41,119,215,33,229,209,198,79,151,9,73,251,174,198,193,37,19,206,211,44,75,5,224,52,148,8,205,216,215,72,245,160,69,201,125,189,112,216,65,109,62,137,154,211,140,71,133,200,83,41,33,97,145,177,78,149,207,181,2,185,195,135,33,93,108,198,175,163,162,66,115,176,231,99,246,252,239,63,63,83,147,146,166,232,234,240,237,153,117,124,29,21,75,168,103,104,210,250,79,150,89,61,18,6,157,65,126,204,178,18,15,182,187,208,230,17,157,207,210,28,122,192,205,88,102,33,2,178,253,152,61,123,78,255,70,84,70,93,122,193,61,236,116,250,245,50,177,12,194,233,10,226,116,177,254,39,214,214,30,114,227,26,144,0,194,43,25,143,154,81,114,167,198,189,169,183,57,3,174,196,48,51,5,102,135,54,255,71,251,188,41,67,3,181,189,57,43,15,138,212,191,203,249,237,213,217,218,12,69,101,4,61,6,238,27,225,72,44,93,129,186,237,185,38,62,28,25,232,65,56,5,28,158,47,58,118,199,20,32,74,136,193,215,239,40,219,64,98,121,220,4,232,31,142,44,253,240,253,53,112,220,240,104,177,11,39,226,244,115,21,101,65,31,97,71,111,164,232,88,199,14,235,3,173,103,120,122,11,113,133,202,217,227,77,51,203,253,195,74,43,161,180,201,18,103,44,113,100,24,215,182,245,21,13,103,165,217,90,70,15,28,96,238,24,78,41,241,53,11,234,184,97,245,178,246,13,74,233,162,167,107,222,41,231,37,111,52,50,74,108,40,120,16,158,111,31,176,80,15,69,208,234,129,40,22,84,37,196,142,99,213,187,82,72,172,130,216,31,3,101,97,129,1,60,194,13,231,225,45,209,189,53,112,111,79,154,214,184,101,3,111,117,31,66,171,175,62,176,61,165,69,211,205,188,13,253,219,251,141,53,64,147,140,59,119,27,211,103,30,187,233,164,184,130,118,164,12,252,178,245,240,13,138,54,91,149,102,199,101,85,144,40,207,254,164,21,154,84,18,56,214,231,81,119,23,83,247,248,235,169,122,123,30,21,40,48,167,27,173,137,185,139,60,90,211,13,67,224,150,90,167,86,131,66,38,13,21,126,120,204,1,205,161,73,122,74,89,52,141,18,162,192,135,73,158,22,151,233,242,90,210,245,220,34,202,132,185,85,81,38,49,112,103,128,69,229,140,151,249,201,81,224,86,48,13,223,108,124,150,238,148,46,189,179,42,47,204,85,92,157,158,202,71,84,23,52,28,170,56,91,99,8,58,192,123,232,208,131,14,198,136,61,97,207,173,240,155,184,232,36,42,185,42,246,202,117,247,32,244,247,29,23,209,177,193,52,186,193,254,208,168,58,112,162,238,201,19,139,112,215,114,249,119,104,35,214,16,157,86,98,24,186,185,243,87,233,21,125,197,234,123,118,10,123,7,231,120,232,222,253,10,103,80,225,180,11,193,22,24,238,76,0,125,133,196,226,189,228,101,181,18,187,54,145,69,153,37,116,43,128,219,205,155,84,72,213,13,234,254,33,236,110,229,19,223,186,69,129,83,33,244,181,48,117,27,83,79,8,164,189,5,150,243,143,72,123,59,73,29,58,77,155,219,161,195,29,162,208,60,165,43,81,20,91,243,96,95,82,121,141,213,125,161,2,132,162,40,154,151,149,244,86,49,36,77,223,249,88,148,36,180,169,21,9,3,114,166,45,207,226,187,55,68,244,231,153,242,66,51,252,62,240,66,209,246,69,246,184,23,139,166,79,245,201,27,80,240,236,105,51,31,176,58,168,234,43,121,63,38,198,204,105,167,173,86,170,142,52,253,58,163,80,186,206,103,58,157,116,30,224,1,205,214,31,126,183,165,129,26,32,122,5,101,168,8,209,246,194,192,255,228,49,246,250,181,158,222,239,156,77,235,6,3,41,81,94,86,153,141,2,245,201,73,183,227,4,6,181,137,26,11,169,89,95,4,142,105,186,54,177,230,104,110,131,60,190,184,66,92,148,170,151,191,229,106,58,112,202,188,169,36,30,70,207,23,12,229,246,77,26,160,228,142,87,31,32,173,97,111,233,223,95,197,196,186,136,177,26,22,101,37,178,53,101,219,255,139,218,119,42,106,143,95,178,236,157,239,95,173,116,109,147,251,209,75,152,89,251,187,85,43,232,187,97,253,223,42,59,224,140,87,20,64,195,70,71,10,93,125,5,180,237,91,239,184,191,79,78,101,196,49,133,237,146,225,172,73,68,58,110,190,27,117,118,50,247,163,146,25,206,140,163,63,150,243,87,84,17,154,137,18,177,98,250,198,170,106,150,254,198,227,219,25,115,100,248,47,252,47,110,125,170,234,185,30,81,223,173,122,126,160,18,158,148,32,94,27,214,167,183,24,139,129,21,196,25,229,73,171,149,189,53,178,65,117,146,42,141,176,28,238,105,129,199,204,134,113,189,2,124,101,78,85,28,55,225,205,238,198,14,72,167,202,117,195,165,141,96,107,88,29,68,236,206,174,23,118,207,232,211,213,30,76,242,28,146,20,35,23,21,223,219,98,93,125,233,85,242,131,218,38,126,203,118,190,188,171,160,182,50,186,254,208,209,222,152,175,222,122,25,224,110,88,219,234,155,2,242,48,195,149,150,106,92,43,46,7,119,131,251,23,25,47,71,234,53,195,6,142,22,203,166,78,171,165,87,153,52,177,240,181,1,110,72,209,211,184,203,132,226,199,125,214,116,91,237,220,252,230,0,213,137,63,209,175,54,254,1,153,242,159,237,66,129,102,222,250,40,244,237,237,229,44,205,50,253,201,81,25,246,129,95,215,31,185,149,168,79,18,158,132,65,95,43,80,153,238,69,41,221,148,136,51,136,208,184,112,90,208,143,53,146,160,163,174,95,92,125,135,235,123,67,189,102,239,48,35,123,128,143,50,35,247,138,100,127,51,117,136,169,235,126,108,12,218,13,103,43,238,9,14,105,18,38,69,68,63,123,5,167,91,183,66,206,251,17,138,62,109,31,226,217,127,0,107,82,187,146,252,43,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInvokeMethodErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateQueueItemPostponeUpdatedMessageLocalizableString());
			LocalizableStrings.Add(CreateQueueItemDateUpdatedMessageLocalizableString());
			LocalizableStrings.Add(CreateAddingUserToQueuesNotificationsSubscribersMessageLocalizableString());
			LocalizableStrings.Add(CreateAddFoldersQueueItemsStartedLocalizableString());
			LocalizableStrings.Add(CreateAddFoldersQueueItemsAlreadyStartedLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInvokeMethodErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bef4e011-9ea9-4a15-841b-a2372e85ac65"),
				Name = "InvokeMethodErrorMessage",
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e"),
				ModifiedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateQueueItemPostponeUpdatedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d450c611-f474-48fc-b440-0c7ccb812879"),
				Name = "QueueItemPostponeUpdatedMessage",
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e"),
				ModifiedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateQueueItemDateUpdatedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2282aee6-b16a-41f9-837f-250591391fa2"),
				Name = "QueueItemDateUpdatedMessage",
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75"),
				CreatedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e"),
				ModifiedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddingUserToQueuesNotificationsSubscribersMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6e0ec865-9a16-4d8e-b653-7fb9f845ee5e"),
				Name = "AddingUserToQueuesNotificationsSubscribersMessage",
				CreatedInPackageId = new Guid("b37272aa-ca79-4db2-9717-1c02e42cc793"),
				CreatedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e"),
				ModifiedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddFoldersQueueItemsStartedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("22aa25e0-e49a-4099-9beb-e385822a3ad1"),
				Name = "AddFoldersQueueItemsStarted",
				CreatedInPackageId = new Guid("a8569787-b88e-4075-aa85-f8031253bd51"),
				CreatedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e"),
				ModifiedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddFoldersQueueItemsAlreadyStartedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ee8bd0fb-16a9-49d6-b9f6-ccaa8ef65a3d"),
				Name = "AddFoldersQueueItemsAlreadyStarted",
				CreatedInPackageId = new Guid("a8569787-b88e-4075-aa85-f8031253bd51"),
				CreatedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e"),
				ModifiedInSchemaUId = new Guid("477b2807-edcc-4595-9f40-28de11e6093e")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("477b2807-edcc-4595-9f40-28de11e6093e"));
		}

		#endregion

	}

	#endregion

}
