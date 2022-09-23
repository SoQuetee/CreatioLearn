namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContactsToSyncRequestSchema

	/// <exclude/>
	public class IContactsToSyncRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContactsToSyncRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContactsToSyncRequestSchema(IContactsToSyncRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe2401fc-4445-4ccb-8923-5d73436003de");
			Name = "IContactsToSyncRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,223,78,194,80,12,198,175,33,225,29,26,188,209,196,176,123,254,236,70,13,33,209,196,0,62,192,97,235,224,36,172,7,219,158,11,36,190,187,221,6,200,80,19,239,214,246,219,215,223,183,142,92,137,178,115,25,194,18,153,157,132,66,7,15,129,10,191,142,236,212,7,234,117,15,189,110,39,138,167,53,44,246,162,88,142,174,106,211,111,183,152,85,98,25,76,145,144,125,246,173,185,180,101,180,190,77,110,24,215,166,134,25,41,114,97,203,135,48,179,165,234,50,149,101,88,236,41,155,227,123,68,209,90,157,36,9,140,37,150,165,227,125,122,172,231,184,99,20,36,21,40,81,55,33,23,208,0,107,84,200,142,62,80,4,134,220,169,3,49,191,13,7,242,31,117,160,193,201,50,185,240,220,197,213,214,103,224,79,64,127,242,116,14,53,211,57,194,75,179,125,8,175,181,67,51,188,38,62,34,107,100,18,136,228,205,11,124,110,244,190,240,200,2,161,248,31,246,79,238,166,179,115,236,74,32,59,229,164,31,5,217,216,169,57,72,63,157,145,168,35,75,100,75,198,130,8,25,99,49,233,191,181,101,73,58,24,39,181,205,239,174,230,193,250,232,20,251,233,162,122,172,16,241,231,43,220,100,76,159,189,232,69,42,11,43,38,62,77,43,249,236,137,98,137,236,86,91,28,79,163,207,83,152,162,182,191,249,109,155,17,218,201,238,161,194,89,250,18,225,12,119,55,58,30,7,41,111,238,83,215,159,205,79,215,106,90,239,11,29,159,190,110,251,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe2401fc-4445-4ccb-8923-5d73436003de"));
		}

		#endregion

	}

	#endregion

}

