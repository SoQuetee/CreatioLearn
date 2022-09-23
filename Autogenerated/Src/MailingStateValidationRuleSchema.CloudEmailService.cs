namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateValidationRuleSchema

	/// <exclude/>
	public class MailingStateValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateValidationRuleSchema(MailingStateValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a9f50c4-bce9-47b7-a069-b260821478be");
			Name = "MailingStateValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,77,79,195,48,12,134,207,171,212,255,96,149,11,92,26,113,133,173,23,196,97,135,73,104,76,220,67,235,108,145,90,167,114,28,4,66,252,119,220,118,31,213,16,82,14,177,99,63,126,253,134,108,135,177,183,53,194,14,153,109,12,78,202,167,64,206,239,19,91,241,129,242,236,59,207,242,108,97,140,129,101,76,93,103,249,171,58,198,91,236,25,35,146,68,144,3,194,198,250,214,211,254,85,172,224,155,109,125,51,2,182,169,69,168,3,9,219,90,202,19,201,204,80,125,122,111,125,13,158,4,217,13,82,214,255,147,238,181,126,18,180,184,97,220,107,22,54,40,135,208,196,7,120,25,57,211,227,181,220,33,177,120,254,196,58,9,194,199,25,9,46,48,196,30,107,239,60,54,192,58,161,60,183,155,171,126,88,246,150,109,7,164,158,173,138,56,136,43,170,157,46,62,94,71,212,133,92,46,205,88,125,105,102,148,196,20,171,53,105,61,233,154,193,169,68,84,115,24,221,170,152,237,169,63,18,40,98,97,42,224,139,197,51,213,154,74,173,68,157,113,130,14,83,254,18,224,152,194,219,185,163,147,222,187,199,163,141,72,205,228,228,24,255,228,153,158,95,23,71,181,188,23,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a9f50c4-bce9-47b7-a069-b260821478be"));
		}

		#endregion

	}

	#endregion

}

