namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DataProviderResponseSchema

	/// <exclude/>
	public class DataProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DataProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DataProviderResponseSchema(DataProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("128127f7-43f7-4cf4-9f1d-06f7c505c1c3");
			Name = "DataProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,80,203,106,195,64,12,60,199,224,127,16,233,221,190,247,145,75,218,99,33,148,252,128,186,150,55,75,99,173,145,118,19,74,232,191,87,126,5,83,122,89,208,236,104,52,51,140,29,105,143,142,224,72,34,168,177,77,213,62,114,27,124,22,76,33,114,117,20,116,95,129,125,89,220,202,162,44,54,15,66,222,112,216,159,81,245,17,94,49,225,65,226,37,52,36,31,38,21,89,105,228,213,117,13,207,154,187,14,229,123,55,207,11,1,220,176,12,109,20,163,144,141,66,237,203,118,185,180,150,220,214,59,64,110,32,240,137,36,36,106,166,85,210,106,57,81,175,110,244,249,243,28,220,172,254,191,179,205,148,226,30,195,24,61,73,10,100,89,14,227,250,244,255,215,254,8,88,51,9,3,43,88,87,230,221,170,83,244,4,215,19,49,12,50,99,99,16,20,50,107,118,206,190,171,187,214,218,231,98,84,147,88,94,120,27,212,222,103,177,27,120,74,79,160,195,243,51,123,37,110,38,187,227,60,161,107,208,144,95,185,57,18,109,201,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("128127f7-43f7-4cf4-9f1d-06f7c505c1c3"));
		}

		#endregion

	}

	#endregion

}

