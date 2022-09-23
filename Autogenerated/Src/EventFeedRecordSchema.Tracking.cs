namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventFeedRecordSchema

	/// <exclude/>
	public class EventFeedRecordSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventFeedRecordSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventFeedRecordSchema(EventFeedRecordSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("effa70fc-e7f0-40c3-a8f5-cf38bfc84003");
			Name = "EventFeedRecord";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,148,77,143,211,48,16,134,207,187,210,254,135,209,114,97,47,233,157,229,67,75,11,90,36,62,170,54,130,3,226,224,56,147,196,224,216,145,61,233,82,42,254,59,19,167,75,203,210,4,135,75,18,251,125,253,188,51,163,36,70,212,232,27,33,17,82,116,78,120,91,80,50,183,166,80,101,235,4,41,107,146,212,9,249,77,153,242,226,124,119,113,126,214,122,126,132,245,214,19,214,215,15,214,201,170,53,164,106,76,214,232,148,208,234,71,0,176,139,125,143,28,150,188,128,185,22,222,63,129,87,27,52,244,26,49,95,161,180,46,15,150,217,108,6,79,125,91,215,194,109,159,239,215,139,244,3,216,236,43,74,130,187,74,201,10,164,53,36,148,241,160,76,97,93,29,18,160,112,182,6,169,109,155,131,200,108,75,96,13,130,11,228,254,0,31,47,56,44,185,79,153,29,197,124,94,8,18,220,50,113,159,244,133,55,154,54,211,74,50,143,43,253,187,208,179,93,40,246,119,67,75,103,27,116,164,144,187,90,134,147,189,30,176,239,176,206,208,61,126,207,67,134,103,112,169,242,203,171,46,225,62,194,147,235,166,23,50,222,228,176,131,18,233,26,124,119,249,57,76,161,109,131,195,156,148,213,88,146,225,251,48,41,184,34,73,27,161,219,17,212,199,78,142,101,73,235,105,24,53,103,53,150,148,11,58,93,84,202,111,169,39,81,55,177,164,202,97,113,146,116,203,66,44,132,173,252,141,161,59,9,90,237,197,88,152,22,166,108,69,121,186,191,183,123,49,22,214,104,65,221,231,116,18,182,220,139,177,176,204,217,59,63,208,229,203,94,155,218,164,31,237,210,199,226,188,116,136,230,147,202,169,250,19,168,12,189,128,245,65,157,6,188,69,85,86,52,72,236,229,105,200,165,250,142,122,129,205,72,161,7,203,52,244,205,70,40,61,62,131,131,229,63,208,255,152,198,145,103,26,124,110,181,117,227,35,57,88,30,162,249,127,141,38,239,127,217,33,168,143,59,222,228,157,95,219,222,177,252,13,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("effa70fc-e7f0-40c3-a8f5-cf38bfc84003"));
		}

		#endregion

	}

	#endregion

}

