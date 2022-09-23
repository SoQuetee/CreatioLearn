﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NonPersistentColumnProcessorSchema

	/// <exclude/>
	public class NonPersistentColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NonPersistentColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NonPersistentColumnProcessorSchema(NonPersistentColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a6c31aa-e931-47f7-9a2a-e8f05e85d51f");
			Name = "NonPersistentColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,223,111,218,48,16,126,166,82,255,135,27,123,88,144,16,188,151,31,213,70,75,85,77,155,170,149,238,117,50,201,209,122,74,236,200,118,50,33,196,255,190,139,237,132,36,64,138,38,237,5,197,246,241,221,119,223,125,103,11,150,160,78,89,136,176,66,165,152,150,27,51,90,72,177,225,175,153,98,134,75,49,90,242,24,31,147,84,42,115,125,181,187,190,234,101,154,139,87,120,222,106,131,9,133,198,49,134,69,156,30,61,160,64,197,195,73,21,83,71,84,72,251,116,146,102,235,152,135,192,214,218,40,22,26,8,99,166,53,124,151,226,9,149,230,132,41,12,97,102,137,120,82,50,68,173,165,154,174,126,160,206,98,51,135,27,248,194,52,182,142,135,240,120,122,247,60,38,209,216,89,50,189,143,10,95,137,59,44,57,198,145,190,129,39,197,115,102,208,29,166,110,1,119,220,22,200,212,118,74,164,169,176,33,84,148,126,41,251,161,39,30,15,69,228,32,155,248,164,40,253,53,11,141,84,54,139,52,36,26,70,46,104,60,30,195,148,139,55,18,207,68,50,132,80,225,102,214,63,81,84,127,60,175,226,117,150,36,196,168,218,88,40,36,174,26,56,37,98,130,218,41,55,96,182,41,82,36,162,135,236,82,121,231,75,218,83,146,81,149,101,220,78,51,77,153,98,9,8,114,205,172,159,105,84,84,153,112,6,232,207,95,104,13,97,181,49,154,142,109,244,220,137,233,107,238,236,117,240,210,128,132,102,134,1,57,96,77,178,4,237,237,29,236,187,245,167,4,41,42,195,241,140,250,237,50,157,22,250,140,16,135,90,186,172,225,49,96,118,112,9,220,222,66,80,45,102,32,240,79,23,68,48,24,188,227,171,111,104,222,100,116,97,81,159,163,168,232,78,78,66,16,245,156,197,25,130,145,80,210,9,171,81,190,176,253,161,237,221,207,2,167,63,175,217,204,93,22,139,218,233,120,94,183,194,17,144,165,178,148,234,153,229,132,36,215,191,137,70,193,76,211,250,180,135,114,174,76,198,98,200,37,143,138,186,86,210,171,29,28,37,135,26,205,74,90,168,167,36,255,20,232,189,156,41,175,202,172,254,167,145,253,157,216,16,190,129,224,67,105,14,114,160,97,52,111,95,113,27,216,255,13,74,164,94,25,66,212,130,35,168,97,51,187,67,222,87,248,245,67,152,145,73,178,56,174,128,159,201,8,126,90,238,149,162,129,169,161,215,145,246,29,62,88,56,15,248,26,219,70,248,164,237,189,241,79,30,104,55,89,161,201,148,208,116,80,126,157,110,99,217,21,207,204,194,117,119,178,20,196,225,66,132,27,70,0,129,7,114,74,188,119,39,184,151,168,235,14,126,244,82,99,100,147,106,90,230,60,194,242,34,246,111,153,55,236,146,11,23,230,123,215,40,224,14,181,225,194,62,168,68,182,250,166,103,234,146,42,11,91,148,150,90,169,237,3,122,137,78,88,75,102,166,146,179,152,31,71,233,224,204,2,234,176,127,228,175,75,12,230,189,90,106,127,64,171,59,185,228,80,93,56,62,95,179,199,199,224,141,97,110,140,110,19,201,135,123,14,205,179,73,123,2,142,27,123,254,17,106,246,182,125,209,248,166,222,11,195,205,22,120,109,209,108,165,239,226,59,253,29,218,26,46,240,137,239,207,127,168,201,71,4,103,30,81,151,114,255,23,176,72,1,116,38,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a6c31aa-e931-47f7-9a2a-e8f05e85d51f"));
		}

		#endregion

	}

	#endregion

}

