namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingResponseSchema

	/// <exclude/>
	public class MailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingResponseSchema(MailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e");
			Name = "MailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6e206974-7c3f-4704-9c49-6b38b2d992b2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,77,79,194,64,16,134,207,144,240,31,38,225,94,238,64,56,136,132,152,128,33,212,155,241,176,221,78,235,198,253,104,246,195,8,196,255,238,116,219,34,8,18,189,52,221,119,223,121,231,233,76,53,83,232,42,198,17,158,208,90,230,76,225,147,185,209,133,40,131,101,94,24,61,232,31,6,253,65,191,23,156,208,37,164,59,231,81,77,126,156,169,66,74,228,181,221,37,75,212,104,5,191,240,108,131,246,66,97,146,210,45,147,98,31,211,39,49,123,104,177,164,3,204,37,115,110,12,107,38,36,21,110,9,140,2,49,90,70,163,17,76,93,80,138,217,221,12,90,97,99,205,187,200,209,65,101,77,133,214,11,122,53,5,248,87,132,44,200,55,64,69,73,224,80,231,53,135,109,243,146,46,110,212,229,145,240,124,207,60,163,15,247,150,113,255,66,66,21,50,41,56,240,26,233,146,168,215,12,229,72,190,57,2,140,97,19,43,155,251,51,236,78,160,152,32,125,77,218,162,37,71,235,41,82,195,180,70,149,161,173,137,58,164,204,24,9,105,224,28,137,236,0,37,250,9,5,209,227,243,70,207,187,147,121,120,230,131,251,95,207,101,16,57,164,177,240,33,255,115,211,37,122,90,136,173,141,14,240,131,99,85,239,252,151,206,109,167,69,103,59,121,187,210,175,117,59,111,235,213,110,81,137,56,201,21,223,167,81,154,155,28,111,212,61,44,116,80,104,89,38,113,218,100,204,224,209,120,81,8,30,255,203,21,119,223,57,87,167,60,164,213,53,203,143,231,70,61,23,73,251,2,51,87,84,21,95,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e"));
		}

		#endregion

	}

	#endregion

}

