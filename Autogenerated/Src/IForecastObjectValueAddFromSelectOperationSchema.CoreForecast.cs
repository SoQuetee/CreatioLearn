namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueAddFromSelectOperationSchema

	/// <exclude/>
	public class IForecastObjectValueAddFromSelectOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueAddFromSelectOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueAddFromSelectOperationSchema(IForecastObjectValueAddFromSelectOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856");
			Name = "IForecastObjectValueAddFromSelectOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,203,78,195,48,16,69,215,68,202,63,140,178,2,169,74,36,182,132,72,20,168,212,85,37,130,186,119,237,73,107,240,35,248,81,168,170,254,59,142,221,68,5,196,114,102,124,207,28,219,138,72,180,61,161,8,175,104,12,177,186,115,229,163,86,29,223,122,67,28,215,170,92,104,131,148,88,183,190,205,179,99,158,93,121,203,213,22,218,131,117,40,239,166,250,50,109,176,124,154,135,81,24,86,85,5,181,245,82,18,115,104,206,245,82,57,52,221,176,178,211,6,8,99,67,190,59,111,1,189,121,67,234,96,79,132,71,8,61,109,152,45,71,82,117,129,234,253,70,112,10,124,162,45,71,211,85,68,172,7,194,3,99,11,163,101,139,34,116,86,61,166,59,133,244,49,234,253,241,139,13,120,254,66,234,29,14,110,163,2,56,13,23,252,8,127,137,163,114,226,84,191,65,117,79,12,145,160,194,27,223,23,118,135,232,138,102,132,64,172,203,186,138,103,254,137,68,237,162,73,250,51,248,228,110,7,68,136,32,245,225,185,65,6,84,11,47,149,253,129,217,107,206,96,238,197,123,184,124,82,180,215,237,176,44,173,156,65,194,65,162,223,12,127,120,202,179,211,55,70,234,142,162,10,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856"));
		}

		#endregion

	}

	#endregion

}

