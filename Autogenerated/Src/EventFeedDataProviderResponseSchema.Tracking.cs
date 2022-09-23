namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventFeedDataProviderResponseSchema

	/// <exclude/>
	public class EventFeedDataProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventFeedDataProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventFeedDataProviderResponseSchema(EventFeedDataProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf4ac696-3045-4224-8196-29e9ed1c351b");
			Name = "EventFeedDataProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,193,110,194,48,12,61,131,196,63,88,112,111,239,208,113,129,109,151,73,32,198,15,100,169,211,69,107,147,202,78,43,49,180,127,159,219,180,168,154,16,218,37,138,157,247,158,223,115,156,170,144,107,165,17,206,72,164,216,155,144,236,188,51,182,104,72,5,235,93,114,38,165,191,172,43,22,243,235,98,62,107,88,174,240,126,225,128,149,0,203,18,117,135,226,228,21,29,146,213,155,197,92,80,43,194,66,186,176,43,21,243,26,158,91,116,225,5,49,223,171,160,142,228,91,155,35,157,100,174,16,177,39,164,105,10,25,55,85,165,232,178,29,234,17,0,186,83,1,227,73,32,40,37,161,121,90,202,171,111,72,227,84,114,153,110,65,185,28,172,251,20,47,1,243,72,69,78,6,201,253,249,0,218,187,160,172,99,32,212,158,242,40,220,90,110,84,105,191,81,184,17,161,3,24,113,60,50,179,116,226,174,110,62,74,171,7,95,15,195,193,26,238,103,158,93,251,220,183,77,9,162,70,10,22,101,93,199,94,62,190,255,93,76,223,56,24,195,24,192,155,49,67,114,131,78,109,142,62,57,80,247,105,3,235,10,5,134,13,112,119,252,60,24,210,69,250,159,254,155,229,144,221,214,112,234,41,219,184,23,190,55,110,133,46,143,177,251,58,118,167,77,233,252,2,121,154,18,206,152,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf4ac696-3045-4224-8196-29e9ed1c351b"));
		}

		#endregion

	}

	#endregion

}

