namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnMessageDTOSchema

	/// <exclude/>
	public class EsnMessageDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnMessageDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnMessageDTOSchema(EsnMessageDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c636fc5-728b-4126-9e55-9608ee750af1");
			Name = "EsnMessageDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,75,79,227,48,16,62,167,82,255,195,8,46,187,151,252,0,16,135,221,180,90,33,209,82,209,238,238,1,113,112,147,33,88,77,236,200,30,179,202,86,251,223,215,238,35,77,130,91,12,18,226,18,201,254,30,51,206,60,4,43,81,87,44,69,88,160,82,76,203,71,138,19,41,30,121,110,20,35,46,69,60,158,79,135,131,245,112,16,25,205,69,14,243,90,19,150,151,189,115,124,103,4,241,18,227,57,42,206,10,254,119,163,61,176,14,230,83,195,29,233,153,167,56,145,25,22,241,136,17,179,17,73,177,148,172,96,56,0,136,206,21,230,86,15,144,20,76,235,11,24,107,113,135,44,155,160,214,44,199,209,226,214,241,162,251,182,244,193,94,84,102,89,240,20,82,39,242,105,34,247,140,198,124,166,100,133,138,56,218,0,179,141,114,227,186,181,157,96,185,68,245,101,106,127,15,92,193,217,117,118,246,213,69,216,135,248,97,120,6,215,25,172,33,71,186,4,237,62,255,142,203,19,89,150,40,40,145,246,47,117,141,184,32,104,163,193,142,10,25,97,246,189,238,218,217,71,55,200,136,36,52,135,190,111,20,189,226,124,43,186,206,154,148,43,100,131,134,38,122,195,52,125,75,93,55,28,113,108,19,66,77,199,182,217,168,246,22,101,15,133,90,237,250,195,155,218,14,123,91,86,243,244,9,75,246,243,68,114,13,227,61,198,238,206,155,108,159,20,94,241,182,50,97,149,43,197,171,17,118,188,224,46,224,43,60,210,253,13,20,238,37,86,51,133,207,28,255,56,180,235,184,172,9,239,31,160,199,9,181,158,49,133,253,28,111,164,92,153,42,145,133,41,197,47,86,24,132,45,43,124,246,11,169,252,179,228,16,127,153,206,81,100,219,53,101,79,91,243,246,149,59,190,92,145,191,21,39,124,235,142,236,137,96,191,37,63,96,11,158,154,140,119,206,196,103,173,128,211,53,57,148,164,189,140,195,234,209,89,223,23,158,238,91,31,27,101,251,146,69,93,97,182,161,121,126,203,1,244,246,156,239,69,246,238,63,93,227,19,133,33,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c636fc5-728b-4126-9e55-9608ee750af1"));
		}

		#endregion

	}

	#endregion

}

