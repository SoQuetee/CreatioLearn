namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsItemSchema

	/// <exclude/>
	public class ParticipantsAnalyticsItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsItemSchema(ParticipantsAnalyticsItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f63154a0-be3b-4482-959d-f99cde09a649");
			Name = "ParticipantsAnalyticsItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,148,77,111,219,48,12,134,207,41,208,255,64,164,135,109,23,251,190,126,0,131,91,116,61,172,8,150,222,134,29,20,153,118,8,88,146,39,74,24,178,162,255,125,148,189,4,110,83,27,241,105,23,27,164,95,145,239,35,202,178,202,32,183,74,35,60,161,247,138,93,21,178,194,217,138,234,232,85,32,103,207,207,158,207,207,22,145,201,214,176,222,113,64,115,249,38,206,190,71,27,200,96,182,70,79,170,161,63,221,58,81,137,238,194,99,45,1,20,141,98,254,12,43,229,3,105,106,149,13,252,197,170,102,39,17,63,72,141,78,156,231,57,92,113,52,70,249,221,205,191,248,22,89,123,218,32,131,141,70,234,107,213,0,217,82,222,193,121,134,202,121,9,165,0,252,166,176,149,213,136,160,61,86,215,203,84,245,161,92,230,251,66,87,249,160,242,143,91,21,148,96,6,175,116,248,41,137,54,110,26,210,160,147,205,41,151,139,231,206,233,129,107,229,93,139,162,198,4,215,213,232,191,191,69,233,18,133,50,173,162,218,2,37,195,84,162,108,91,69,232,179,195,138,161,199,222,228,55,52,27,244,31,31,101,76,112,13,75,234,169,62,37,207,123,211,247,145,74,232,113,33,205,106,177,168,49,92,2,203,35,69,47,19,142,134,164,160,157,204,241,104,31,247,166,7,210,108,29,176,45,156,105,27,12,152,182,24,136,1,127,69,25,77,240,17,103,224,232,125,145,161,145,34,249,120,141,40,35,134,98,84,251,223,169,43,213,240,28,108,235,236,56,205,49,249,227,148,124,2,254,189,214,242,147,59,127,66,207,187,119,117,51,155,181,222,105,228,116,85,156,208,113,53,46,158,217,150,35,183,104,203,147,246,118,61,170,157,123,170,158,92,144,163,208,30,159,173,202,59,3,97,139,135,255,255,3,67,227,234,25,231,101,75,44,183,221,238,4,156,175,35,202,9,152,11,193,239,111,179,46,238,179,175,147,47,127,1,157,205,168,163,38,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f63154a0-be3b-4482-959d-f99cde09a649"));
		}

		#endregion

	}

	#endregion

}

