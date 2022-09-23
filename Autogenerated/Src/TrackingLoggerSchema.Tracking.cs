namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TrackingLoggerSchema

	/// <exclude/>
	public class TrackingLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TrackingLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TrackingLoggerSchema(TrackingLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1b4bc65-b177-4549-904d-d9ef71e207d9");
			Name = "TrackingLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("874306e1-e314-437e-96bf-3f336a8aaf12");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,78,195,48,16,60,7,137,127,88,133,75,34,85,206,29,218,30,128,34,85,2,132,212,114,70,198,217,6,139,196,142,252,0,10,226,223,177,157,7,73,10,136,83,188,143,153,157,157,141,160,21,234,154,50,132,45,42,69,181,220,25,114,33,197,142,23,86,81,195,165,32,91,69,217,51,23,197,241,209,199,241,81,100,181,123,194,102,175,13,86,103,125,60,196,42,252,45,79,46,207,93,201,21,79,20,22,142,26,46,74,170,245,41,116,19,174,101,81,160,10,29,181,125,44,57,3,230,27,14,234,145,23,210,147,92,113,44,115,199,114,167,248,11,53,24,224,81,221,4,160,144,230,82,148,123,184,215,168,220,94,2,153,95,10,30,236,40,110,100,69,39,40,242,134,181,141,59,157,82,104,163,44,51,82,249,65,65,91,211,145,101,25,204,181,173,42,170,246,203,46,177,22,220,112,90,242,119,116,53,68,96,10,119,139,120,188,69,156,45,129,59,86,42,24,146,158,41,155,82,205,107,170,104,5,194,93,105,17,143,53,199,203,117,139,7,185,27,14,26,175,234,6,145,121,22,104,2,107,235,236,88,77,50,177,103,60,41,133,96,120,52,49,13,22,112,224,98,20,125,254,109,229,13,154,39,153,79,92,108,53,189,72,158,131,19,148,56,179,253,223,83,201,220,150,120,235,118,159,65,151,66,173,105,129,157,34,231,0,42,227,141,244,159,5,8,124,133,38,151,76,196,166,100,45,140,76,134,87,136,211,32,56,106,208,100,131,38,137,111,250,145,241,204,157,189,180,149,32,119,222,59,52,206,165,111,65,233,79,216,70,219,143,192,86,246,24,181,122,67,102,13,38,233,208,184,127,120,177,122,99,88,135,11,96,247,234,12,241,136,97,107,223,64,182,114,19,152,146,52,253,227,78,77,118,156,252,252,2,158,150,247,59,36,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1b4bc65-b177-4549-904d-d9ef71e207d9"));
		}

		#endregion

	}

	#endregion

}

