namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueueEntityEventAsyncOperationArgsSchema

	/// <exclude/>
	public class QueueEntityEventAsyncOperationArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueueEntityEventAsyncOperationArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueueEntityEventAsyncOperationArgsSchema(QueueEntityEventAsyncOperationArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ee00480-4744-4349-9314-bc0a08994574");
			Name = "QueueEntityEventAsyncOperationArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("64ebcdcc-1a9c-4eb3-9403-16c8221d18f7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,111,107,194,48,16,198,95,43,248,29,14,247,198,193,104,223,171,19,68,68,132,193,28,219,23,136,233,181,11,180,105,201,37,131,34,126,247,93,19,171,173,48,149,189,232,159,164,207,221,253,238,185,84,139,2,169,18,18,225,11,141,17,84,166,54,90,149,58,85,153,51,194,170,82,143,134,135,209,112,224,72,233,12,62,107,178,88,204,174,214,172,207,115,148,141,152,162,13,106,52,74,94,52,221,180,6,163,181,182,202,42,164,187,130,104,73,181,150,239,21,6,140,38,128,67,158,12,102,188,130,85,46,136,166,240,225,208,161,143,168,215,63,168,109,63,102,105,50,242,81,113,28,195,156,92,81,8,83,47,78,107,159,1,12,86,6,137,35,137,5,136,32,13,166,175,227,155,25,199,241,2,148,254,230,46,109,105,32,229,203,17,242,78,55,129,231,218,178,55,228,147,188,41,246,137,125,225,208,168,197,137,59,60,149,219,231,74,130,244,72,247,123,130,41,220,233,121,112,240,125,95,236,98,3,173,113,146,137,217,181,157,47,23,20,167,210,247,139,78,194,87,64,255,120,129,32,107,104,176,125,123,102,176,189,32,156,180,154,206,151,230,16,13,142,39,42,212,73,0,235,83,238,76,201,21,155,225,247,25,175,199,119,218,232,187,29,198,66,86,104,62,203,242,124,34,163,179,190,107,120,219,246,118,173,93,193,77,238,115,156,135,254,22,193,10,10,192,131,12,237,12,136,111,103,252,71,128,66,170,30,145,120,128,134,71,212,252,16,75,47,253,19,224,95,229,203,118,148,160,146,102,58,169,66,115,27,102,227,84,2,231,19,176,77,110,240,92,205,51,236,246,55,143,191,147,112,236,157,104,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ee00480-4744-4349-9314-bc0a08994574"));
		}

		#endregion

	}

	#endregion

}

