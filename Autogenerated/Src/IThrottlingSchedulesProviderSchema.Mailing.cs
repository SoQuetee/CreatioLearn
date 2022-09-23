namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IThrottlingSchedulesProviderSchema

	/// <exclude/>
	public class IThrottlingSchedulesProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IThrottlingSchedulesProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IThrottlingSchedulesProviderSchema(IThrottlingSchedulesProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9ef08c3-4687-47dc-a929-945b22c2edc9");
			Name = "IThrottlingSchedulesProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3e4ee87-43fa-403d-acda-7e0e57f41b53");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,193,110,194,48,12,134,207,32,241,14,22,187,108,151,230,14,29,23,52,33,14,147,16,240,2,161,117,219,72,109,194,108,135,169,66,123,247,133,210,194,96,48,180,91,99,187,223,255,255,113,172,174,144,183,58,65,88,35,145,102,151,73,52,117,54,51,185,39,45,198,217,65,127,63,232,247,60,27,155,223,27,137,166,111,171,101,160,56,203,200,227,65,63,204,63,17,230,161,3,115,43,72,89,192,143,96,190,46,200,137,148,1,180,74,10,76,125,137,188,32,183,51,41,82,243,143,82,10,98,246,85,165,169,158,180,231,118,128,33,243,54,57,104,233,210,72,13,226,32,71,1,57,17,129,59,36,100,142,32,241,68,104,5,60,35,69,29,90,253,96,111,253,166,52,9,152,206,222,3,119,189,125,227,240,20,235,29,165,112,41,143,96,209,112,142,205,107,255,77,97,134,194,247,125,74,129,23,94,97,83,55,53,194,15,111,8,83,96,9,87,140,121,29,157,4,212,181,66,188,213,164,43,176,97,145,175,195,112,43,191,131,44,3,13,89,134,147,246,35,196,102,209,54,164,254,52,82,92,9,34,237,76,232,152,52,138,85,67,62,11,17,138,39,203,147,179,194,63,67,196,170,67,28,152,179,91,94,185,123,72,112,187,253,124,179,220,5,251,43,254,203,184,221,33,218,244,184,198,230,252,117,124,175,23,197,80,251,6,254,7,229,75,24,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9ef08c3-4687-47dc-a929-945b22c2edc9"));
		}

		#endregion

	}

	#endregion

}

