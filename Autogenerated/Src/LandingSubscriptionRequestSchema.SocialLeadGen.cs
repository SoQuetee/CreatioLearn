namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingSubscriptionRequestSchema

	/// <exclude/>
	public class LandingSubscriptionRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingSubscriptionRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingSubscriptionRequestSchema(LandingSubscriptionRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0ca51e0-3be3-3d77-16f1-134361882e48");
			Name = "LandingSubscriptionRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,142,65,106,195,48,16,69,215,49,248,14,3,221,219,251,38,116,147,66,40,4,26,234,92,96,44,141,221,1,91,114,53,18,33,152,220,189,182,100,7,211,69,55,130,249,250,188,255,12,246,36,3,42,130,43,57,135,98,27,95,28,173,105,184,13,14,61,91,83,84,86,49,118,103,66,125,34,147,103,99,158,237,130,176,105,161,186,139,167,126,159,103,83,242,226,168,157,202,112,236,80,228,21,206,104,244,84,169,66,45,202,241,48,115,190,232,39,144,248,216,46,203,18,14,18,250,30,221,253,109,185,223,175,159,224,82,7,110,236,191,129,77,99,93,31,29,0,107,27,60,116,137,90,172,132,114,131,24,66,221,177,2,53,239,255,59,191,27,163,194,211,248,226,236,64,206,51,77,218,151,8,73,255,127,29,99,176,128,129,117,241,236,108,45,86,141,83,96,189,150,63,52,140,208,146,223,131,204,207,99,153,39,163,147,65,188,83,186,13,31,191,236,203,241,68,154,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0ca51e0-3be3-3d77-16f1-134361882e48"));
		}

		#endregion

	}

	#endregion

}

