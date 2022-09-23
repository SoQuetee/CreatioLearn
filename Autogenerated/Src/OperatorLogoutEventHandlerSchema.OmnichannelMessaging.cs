namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OperatorLogoutEventHandlerSchema

	/// <exclude/>
	public class OperatorLogoutEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OperatorLogoutEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OperatorLogoutEventHandlerSchema(OperatorLogoutEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c46064d2-8bfb-8ae3-a732-e51330addf7c");
			Name = "OperatorLogoutEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,77,79,194,64,16,61,99,194,127,152,224,165,36,102,123,71,240,32,106,36,17,49,65,79,198,195,184,59,45,155,180,187,205,126,160,132,240,223,157,150,130,160,226,169,187,111,223,155,233,188,121,6,75,242,21,74,130,103,114,14,189,205,130,24,91,147,233,60,58,12,218,26,49,43,141,150,11,52,134,10,49,37,239,49,215,38,239,158,173,187,103,157,232,249,8,243,149,15,84,94,238,239,135,133,28,157,194,197,29,202,96,157,38,207,12,230,156,59,202,185,29,140,11,244,126,0,179,138,184,191,117,15,54,183,49,220,46,201,132,123,52,170,32,215,176,211,52,133,161,143,101,137,110,117,213,222,231,20,192,182,50,240,1,3,1,215,139,158,28,20,77,21,177,19,166,63,148,67,79,132,133,183,32,29,101,163,222,228,119,211,94,122,85,171,95,111,40,195,88,132,107,109,20,143,148,132,85,69,54,75,254,16,244,47,224,145,173,133,17,244,78,143,210,235,191,113,209,42,190,23,90,130,172,7,255,103,110,24,192,31,125,88,191,110,28,217,27,56,165,176,176,138,45,124,106,234,110,31,155,41,181,89,144,211,65,89,121,122,80,177,253,54,80,242,194,222,113,24,12,201,58,9,125,54,161,174,213,254,239,210,106,5,167,217,16,101,31,234,144,116,58,193,173,218,83,103,137,14,100,116,142,249,53,125,162,216,160,40,197,248,27,18,19,117,249,205,221,237,115,138,6,115,246,96,4,134,62,246,38,181,104,194,173,90,205,15,190,24,115,112,115,218,241,231,117,40,146,163,254,23,112,144,239,125,188,121,12,31,188,56,210,137,137,225,196,234,37,113,124,21,181,13,55,32,49,200,5,36,183,159,146,170,198,37,88,195,166,126,219,180,107,33,163,182,155,105,238,91,244,24,100,236,11,203,86,127,12,135,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c46064d2-8bfb-8ae3-a732-e51330addf7c"));
		}

		#endregion

	}

	#endregion

}

