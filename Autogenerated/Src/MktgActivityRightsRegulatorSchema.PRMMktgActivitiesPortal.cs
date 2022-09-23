namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MktgActivityRightsRegulatorSchema

	/// <exclude/>
	public class MktgActivityRightsRegulatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MktgActivityRightsRegulatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MktgActivityRightsRegulatorSchema(MktgActivityRightsRegulatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd6f3ed9-1bd8-42f5-9da1-eedf8c901d2e");
			Name = "MktgActivityRightsRegulator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0d7ed7ad-953f-4448-9eef-c702acc0afc1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,111,219,48,12,61,187,64,255,3,209,93,18,160,112,238,73,215,34,8,130,34,135,52,69,211,237,174,202,140,44,212,146,12,125,36,243,138,253,247,201,82,154,218,110,188,245,99,59,146,20,223,123,124,38,45,137,64,83,18,138,112,143,90,19,163,54,54,157,41,185,225,204,105,98,185,146,167,39,79,167,39,137,51,92,50,88,87,198,162,152,28,226,102,139,16,74,30,175,104,236,203,167,115,105,185,229,104,210,169,169,36,93,149,24,57,205,187,27,210,133,180,168,55,126,142,186,215,119,127,209,200,124,1,102,5,49,102,12,203,71,203,166,212,242,45,183,213,29,103,185,53,119,200,92,65,172,210,225,249,104,52,130,11,227,132,32,186,186,220,199,161,21,118,57,167,57,224,15,164,206,162,1,245,76,9,27,165,129,230,68,178,90,166,14,152,224,211,77,166,20,158,161,71,13,236,210,61,20,156,2,13,240,127,16,6,99,88,132,121,171,249,22,165,109,79,236,113,158,130,242,195,164,183,186,214,86,155,51,134,219,72,17,31,236,249,214,166,140,104,93,154,190,194,100,143,143,50,139,20,109,190,37,218,92,101,53,153,230,91,98,113,79,22,3,216,42,158,193,146,72,194,176,57,226,74,51,34,249,207,48,66,164,27,244,142,56,213,204,0,209,204,9,95,50,67,168,247,48,73,250,212,166,145,44,214,142,208,28,128,226,14,85,139,236,60,224,37,221,194,76,21,78,200,239,164,112,126,205,174,209,222,87,37,102,33,188,184,118,60,187,28,156,77,41,85,78,218,69,118,54,124,133,177,42,178,15,192,12,235,133,79,126,189,205,194,157,68,253,63,189,107,224,31,119,232,19,214,5,240,207,26,119,0,25,78,160,105,220,223,55,53,92,66,235,42,130,201,243,120,221,131,111,6,181,255,249,73,164,225,194,93,43,60,135,127,228,54,124,237,191,197,171,43,144,184,235,173,15,186,146,186,95,96,77,115,20,228,198,255,212,227,74,37,111,58,193,23,233,189,77,141,165,232,188,62,110,126,204,182,147,62,247,27,247,15,195,178,111,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd6f3ed9-1bd8-42f5-9da1-eedf8c901d2e"));
		}

		#endregion

	}

	#endregion

}

