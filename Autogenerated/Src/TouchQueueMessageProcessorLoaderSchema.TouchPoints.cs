﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageProcessorLoaderSchema

	/// <exclude/>
	public class TouchQueueMessageProcessorLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageProcessorLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageProcessorLoaderSchema(TouchQueueMessageProcessorLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d82fe34-a6a1-4613-a17e-ba392938c2ae");
			Name = "TouchQueueMessageProcessorLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,93,143,211,58,16,125,46,18,255,97,238,34,161,68,66,233,59,180,69,189,213,2,149,22,150,11,69,60,174,220,116,210,154,117,226,98,59,133,222,213,254,247,59,118,236,124,117,155,114,95,170,248,227,28,207,156,57,30,183,96,57,234,61,75,17,86,168,20,211,50,51,201,66,22,25,223,150,138,25,46,139,231,207,30,158,63,27,149,154,23,91,248,122,212,6,243,55,189,49,237,23,2,83,187,89,39,239,177,64,197,211,147,61,55,188,248,121,50,249,5,51,15,108,150,218,97,228,249,185,21,133,52,79,43,47,20,110,9,14,11,193,180,126,13,43,89,166,187,127,74,44,241,35,106,205,182,248,89,201,148,190,164,186,145,108,131,202,97,198,227,49,76,116,153,231,76,29,103,126,236,240,96,36,8,218,167,129,9,1,236,192,184,96,107,129,52,77,172,240,211,210,66,94,241,194,62,16,235,36,80,142,91,156,251,114,45,120,10,169,163,189,28,213,232,193,69,214,164,67,82,26,85,166,134,248,95,195,103,71,86,237,232,7,239,38,150,5,55,156,9,254,47,106,40,240,23,112,66,179,130,106,42,51,48,59,172,194,72,106,248,184,143,159,236,153,98,57,20,228,133,233,85,169,81,209,249,69,85,152,171,217,55,26,67,90,79,212,228,201,100,236,96,142,197,231,123,41,211,232,91,135,28,186,103,197,96,173,54,26,221,117,167,97,218,219,247,198,237,178,73,215,244,171,227,30,117,20,187,149,71,175,37,22,155,74,206,174,182,239,56,138,141,85,85,241,3,51,88,45,238,171,1,80,106,134,242,80,200,54,178,16,71,144,235,31,116,38,220,9,153,222,223,86,223,83,39,113,181,224,78,124,2,191,188,46,202,28,149,117,207,196,134,54,131,187,125,39,212,30,172,39,203,221,73,190,67,9,125,68,179,147,103,51,58,13,229,61,154,185,214,152,175,197,177,146,45,140,128,249,143,80,136,48,78,22,59,76,239,231,106,75,76,133,249,84,10,17,89,175,200,44,170,17,177,47,202,201,105,198,167,75,139,70,29,61,241,200,205,146,148,1,255,150,26,135,105,23,113,244,8,41,51,116,237,162,166,73,216,117,235,163,235,223,41,238,157,80,24,247,9,49,113,44,201,247,29,42,140,168,90,20,1,252,69,53,163,160,3,179,251,85,104,74,85,180,194,123,236,234,182,150,82,192,7,166,157,165,107,159,205,141,81,124,93,26,140,236,49,14,29,66,104,17,218,100,22,165,54,50,175,247,235,200,46,144,98,205,21,57,37,141,95,1,221,122,140,171,148,146,219,204,30,50,25,66,204,162,56,153,23,199,174,243,7,75,223,191,50,240,0,238,184,3,83,117,53,86,94,204,19,167,244,140,153,124,151,234,222,189,30,111,155,207,128,240,106,123,89,58,212,161,58,86,194,233,172,41,96,178,212,95,203,181,235,86,183,89,16,236,111,166,241,124,95,137,189,88,163,151,47,135,170,229,10,245,164,72,7,201,55,240,84,47,241,101,229,25,68,189,203,91,251,41,152,175,202,177,237,46,219,47,8,215,180,141,122,239,159,240,117,8,61,163,43,80,15,55,125,170,160,30,213,63,99,218,3,39,43,121,195,181,137,218,151,162,39,205,176,242,176,160,46,105,154,241,210,191,11,103,111,198,156,60,67,188,82,37,21,178,6,216,189,175,250,77,47,38,203,92,136,224,79,186,125,211,28,47,61,162,95,92,148,255,239,237,135,140,116,72,75,165,168,45,214,22,31,122,104,43,41,244,204,74,111,95,231,137,70,122,158,21,102,211,171,225,92,175,198,179,250,229,213,244,244,6,162,214,227,123,224,202,148,76,116,174,253,48,105,183,33,52,158,239,88,77,251,23,207,134,124,137,47,184,169,103,190,228,157,84,215,44,221,133,27,31,124,110,207,169,255,171,76,207,26,202,121,201,219,186,245,191,107,190,217,44,179,79,210,92,255,166,200,116,20,136,130,161,187,253,167,193,13,184,166,154,237,78,210,220,127,56,32,140,249,36,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d82fe34-a6a1-4613-a17e-ba392938c2ae"));
		}

		#endregion

	}

	#endregion

}
