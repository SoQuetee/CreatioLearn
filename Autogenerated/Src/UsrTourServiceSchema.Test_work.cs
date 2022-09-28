﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrTourServiceSchema

	/// <exclude/>
	public class UsrTourServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrTourServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrTourServiceSchema(UsrTourServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e506be7-9e09-4266-887e-e094cae68ae3");
			Name = "UsrTourService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28de68a3-d799-4b12-9629-18849b1501aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,205,142,211,48,16,62,183,79,97,229,148,72,139,37,174,148,34,181,75,119,85,68,183,203,166,171,30,16,7,111,50,237,90,56,118,214,63,133,168,90,137,183,224,53,16,39,36,4,188,66,120,35,236,36,109,147,254,174,132,165,68,241,204,55,246,204,247,205,4,113,146,128,74,73,4,104,2,82,18,37,102,26,159,11,62,163,115,35,137,166,130,227,91,37,39,194,200,16,228,130,70,208,94,182,145,93,70,81,62,71,97,166,52,36,157,29,11,174,192,35,17,3,59,225,198,83,184,59,5,233,69,154,46,138,108,234,200,122,194,18,14,123,240,235,254,33,103,146,28,58,210,102,117,212,95,28,60,224,154,106,10,170,131,218,5,232,125,149,181,37,80,75,18,233,15,165,181,167,210,43,208,246,180,212,214,112,71,25,213,217,13,60,24,42,33,1,174,149,95,223,184,130,81,23,157,8,113,40,92,25,226,160,188,38,53,119,140,70,40,98,68,41,84,83,236,5,234,19,5,43,249,28,114,89,102,91,228,54,78,161,212,185,153,115,225,179,28,12,249,66,124,4,127,4,250,94,196,54,47,239,122,28,78,188,51,228,238,6,165,47,132,76,136,182,118,11,29,129,82,100,14,165,9,191,81,130,159,161,190,136,179,80,103,12,26,144,181,21,79,37,73,83,136,207,214,119,222,216,102,20,92,193,241,131,131,77,146,85,213,49,68,52,33,12,93,130,118,165,95,75,91,107,63,59,183,52,249,74,75,39,93,100,191,3,180,92,7,186,181,32,18,205,165,48,105,8,145,227,224,157,1,153,217,75,57,124,66,33,48,107,244,111,21,72,75,13,47,1,65,35,220,45,219,8,204,36,220,247,134,177,183,199,123,33,69,226,123,213,8,141,103,51,144,251,80,211,123,144,208,132,185,212,247,64,11,248,80,13,30,12,97,126,121,53,190,38,210,14,177,6,233,23,53,238,6,17,85,85,211,105,184,46,13,141,17,117,170,238,112,128,7,159,33,50,26,194,136,48,34,95,58,228,43,63,104,134,211,25,242,105,220,237,58,39,30,36,169,206,182,233,117,75,130,54,146,163,103,207,155,193,143,237,86,171,229,30,39,129,210,68,27,117,101,139,112,29,150,127,205,191,229,127,242,159,246,253,43,255,241,247,75,254,59,255,238,190,189,206,10,159,50,98,5,137,29,87,199,197,178,248,86,83,160,194,210,16,37,44,46,127,75,149,94,185,43,53,92,62,149,169,117,152,242,77,238,65,137,173,145,109,119,5,199,37,102,232,152,174,165,126,136,99,27,69,103,254,38,166,139,106,12,47,139,59,106,164,218,93,201,229,118,95,167,110,4,254,163,161,47,12,143,112,104,54,68,21,51,229,5,1,238,41,223,155,8,77,88,101,57,209,245,79,108,120,181,119,128,142,247,59,141,43,210,113,143,199,91,138,174,229,62,41,222,48,126,250,204,172,254,51,18,148,97,238,255,180,161,121,75,207,10,185,51,54,141,77,37,100,121,218,6,247,216,46,223,143,255,0,74,70,8,155,159,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e506be7-9e09-4266-887e-e094cae68ae3"));
		}

		#endregion

	}

	#endregion

}

