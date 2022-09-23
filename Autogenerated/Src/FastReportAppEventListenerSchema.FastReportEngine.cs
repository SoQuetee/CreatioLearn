namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FastReportAppEventListenerSchema

	/// <exclude/>
	public class FastReportAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FastReportAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FastReportAppEventListenerSchema(FastReportAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c2eae70-2e46-4408-b770-04ce11ee4b96");
			Name = "FastReportAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b2e55c4-93df-4e50-a678-d373851bda85");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,203,110,194,48,16,60,7,137,127,216,210,11,92,252,1,65,61,180,20,42,36,80,171,130,196,177,218,36,155,96,201,216,145,109,210,7,226,223,187,137,67,129,42,170,122,33,236,236,204,236,238,88,227,142,92,137,41,193,154,172,69,103,114,47,38,70,231,178,216,91,244,210,104,241,74,165,177,94,234,66,204,208,249,80,77,117,33,53,245,123,135,126,47,218,59,238,93,168,187,248,181,165,166,180,246,27,255,83,210,197,219,80,194,78,187,221,165,75,161,76,130,42,142,3,46,22,166,224,213,10,238,51,227,214,82,193,35,97,162,208,185,24,206,230,247,101,57,173,72,251,133,116,158,52,217,134,93,238,19,37,83,72,107,242,31,92,136,225,55,244,128,142,195,136,14,141,205,207,212,153,36,149,241,216,23,43,43,244,20,154,101,40,96,206,139,194,155,226,109,217,241,14,184,90,162,70,46,196,19,249,69,3,15,7,63,151,15,70,227,214,155,116,22,236,175,103,45,201,111,77,51,172,57,162,157,21,14,50,21,219,200,140,160,50,50,131,103,205,219,175,60,90,63,60,157,193,143,227,233,195,67,26,190,35,168,159,53,138,18,190,74,92,208,79,237,113,211,13,225,60,162,199,149,217,219,148,206,47,60,215,210,75,84,242,139,143,57,255,31,182,186,10,45,228,38,100,55,147,138,54,232,38,150,56,146,140,99,152,93,52,26,212,88,177,182,159,129,112,114,144,57,12,111,186,45,78,171,71,126,43,157,104,227,21,83,107,13,167,89,75,132,98,13,228,44,130,119,116,160,13,95,29,164,98,208,218,31,235,223,99,103,220,1,189,6,25,251,6,187,101,211,161,68,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c2eae70-2e46-4408-b770-04ce11ee4b96"));
		}

		#endregion

	}

	#endregion

}

