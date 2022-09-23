namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateExecutionResultSchema

	/// <exclude/>
	public class MailingStateExecutionResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateExecutionResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateExecutionResultSchema(MailingStateExecutionResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a95e0eb-333a-4e72-a071-49117847afde");
			Name = "MailingStateExecutionResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,148,205,110,219,48,12,199,207,46,208,119,32,218,75,11,12,246,61,77,115,73,179,162,64,183,5,117,94,64,86,232,84,171,44,25,250,200,154,6,123,247,81,146,157,38,109,230,13,185,216,162,68,253,249,19,73,73,177,6,109,203,56,194,2,141,97,86,215,46,159,106,85,139,149,55,204,9,173,206,207,182,231,103,153,183,66,173,160,220,88,135,205,205,7,155,252,165,68,30,156,109,126,143,10,141,224,159,124,158,188,114,162,193,188,164,85,38,197,91,212,38,47,242,187,52,184,34,3,166,146,89,59,130,111,76,72,218,88,58,230,112,246,138,220,7,207,39,180,94,186,232,94,20,5,140,173,111,26,102,54,19,232,38,230,70,175,197,18,45,180,70,183,104,156,160,161,174,193,61,35,84,94,190,0,54,164,10,22,213,50,48,25,58,50,193,98,222,203,21,189,30,77,180,190,146,130,3,15,52,195,48,217,54,2,237,14,48,223,197,30,193,60,170,164,245,3,226,7,37,92,204,0,17,50,80,248,11,132,178,142,41,170,64,7,60,182,136,192,13,214,183,23,139,81,151,190,31,213,79,202,240,5,20,147,4,150,31,32,247,204,3,180,87,139,77,139,96,195,74,24,93,67,168,106,150,69,87,184,125,95,200,23,186,116,134,68,174,174,67,13,179,223,225,243,233,16,253,196,212,27,131,202,201,13,96,12,135,203,164,148,239,118,28,195,180,49,0,164,216,91,88,161,187,129,225,56,247,232,168,158,134,10,72,255,144,163,163,39,13,150,183,176,102,210,255,131,96,104,123,247,235,184,108,7,247,87,180,148,222,80,187,174,187,134,35,87,90,75,40,61,231,104,255,63,198,193,241,241,149,99,27,120,135,3,205,122,183,189,209,105,241,148,111,208,176,74,198,6,85,218,137,90,240,120,125,65,106,30,239,114,88,227,154,174,95,14,131,76,15,179,157,214,56,53,193,4,190,239,9,62,114,155,154,111,26,196,78,195,221,103,82,244,184,5,232,19,154,115,182,166,190,126,228,111,239,60,199,112,46,169,228,233,242,71,59,205,126,152,236,116,67,26,135,250,46,61,39,116,35,95,68,219,226,242,75,24,223,105,133,113,64,47,178,19,202,39,227,43,137,224,178,15,71,159,63,197,83,206,244,196,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a95e0eb-333a-4e72-a071-49117847afde"));
		}

		#endregion

	}

	#endregion

}

