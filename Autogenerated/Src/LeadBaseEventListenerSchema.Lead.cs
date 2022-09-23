﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadBaseEventListenerSchema

	/// <exclude/>
	public class LeadBaseEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadBaseEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadBaseEventListenerSchema(LeadBaseEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35d507ab-cec6-4338-b5f5-5484897ca57f");
			Name = "LeadBaseEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,77,79,219,64,16,61,7,137,255,48,50,23,71,170,156,59,9,32,154,2,138,4,133,42,208,75,85,85,27,239,56,217,214,217,141,118,215,169,82,196,127,239,236,135,137,227,56,228,56,227,153,247,102,222,27,175,100,75,52,43,150,35,60,163,214,204,168,194,102,99,37,11,49,175,52,179,66,201,211,147,215,211,147,94,101,132,156,195,116,99,44,46,135,239,113,179,69,227,161,124,118,35,173,176,2,205,209,130,236,102,141,210,186,58,170,60,211,56,39,126,24,151,204,152,115,184,71,198,63,51,131,190,228,94,208,32,18,181,47,28,12,6,48,50,213,114,201,244,230,50,198,117,1,20,74,251,86,64,199,177,1,244,12,89,221,54,104,245,141,12,34,43,141,130,92,99,113,145,124,60,103,230,231,241,184,59,83,37,48,112,120,63,58,62,165,211,124,129,75,246,149,84,135,11,72,220,100,73,255,39,21,175,170,89,41,114,200,221,178,221,187,194,57,28,224,163,118,231,209,187,98,183,2,75,78,146,61,105,177,102,22,189,72,189,85,8,60,246,212,50,91,153,241,2,243,63,132,251,171,108,167,130,1,189,51,148,60,64,198,56,226,63,105,181,66,237,132,112,28,202,98,110,145,215,44,49,132,23,131,154,14,73,82,228,122,90,225,43,204,209,14,161,30,202,184,224,237,99,214,7,180,11,117,112,173,153,82,37,76,140,219,110,34,111,133,100,101,216,40,13,122,129,219,177,15,94,166,222,93,37,56,108,151,158,112,178,194,133,217,29,218,231,205,10,249,88,149,213,82,126,103,101,133,35,87,124,153,38,223,42,86,138,98,83,119,36,253,161,135,218,87,115,139,59,181,116,51,4,77,168,123,101,105,236,215,104,43,45,219,77,89,215,34,205,129,67,247,219,49,103,187,153,163,10,145,122,223,125,184,186,130,180,35,125,1,18,255,238,179,164,187,214,246,59,103,91,43,146,124,186,145,249,66,43,41,254,161,67,161,30,203,114,219,116,232,19,132,224,186,176,168,253,141,95,235,185,1,172,103,22,5,180,232,156,103,19,115,139,52,144,166,127,131,205,74,228,105,210,205,148,244,107,28,15,116,72,228,109,85,212,40,88,229,86,234,69,203,35,96,131,38,24,223,149,223,202,214,241,181,45,94,164,58,128,149,53,130,248,249,11,179,44,13,210,97,246,160,184,40,196,206,253,154,8,249,214,48,229,248,31,230,31,163,232,96,120,152,212,154,158,66,193,163,147,143,242,101,197,201,87,158,170,217,111,26,157,126,96,201,81,31,179,111,70,239,87,246,40,167,108,77,157,117,11,198,9,27,103,64,154,197,171,232,135,170,80,209,122,67,226,79,187,155,13,149,7,46,45,234,180,115,161,45,49,66,118,55,73,185,255,18,164,88,70,39,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35d507ab-cec6-4338-b5f5-5484897ca57f"));
		}

		#endregion

	}

	#endregion

}

