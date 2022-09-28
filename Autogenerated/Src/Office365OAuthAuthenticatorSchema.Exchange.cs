﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Office365OAuthAuthenticatorSchema

	/// <exclude/>
	public class Office365OAuthAuthenticatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Office365OAuthAuthenticatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Office365OAuthAuthenticatorSchema(Office365OAuthAuthenticatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4bd7c72-2bab-433b-a88b-a5cf9daf8afb");
			Name = "Office365OAuthAuthenticator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2137d3bc-8953-4060-9df8-39c52dc22e74");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,77,107,219,64,16,61,59,144,255,48,40,80,28,48,210,161,180,135,196,118,112,66,27,82,234,58,228,131,28,66,15,107,105,228,44,149,118,149,221,149,193,24,255,247,206,172,37,71,114,106,183,13,165,23,161,157,157,125,51,239,237,155,85,34,71,91,136,24,225,14,141,17,86,167,46,188,208,42,149,179,210,8,39,181,58,60,88,30,30,116,74,43,213,12,110,23,214,97,126,186,181,14,111,209,204,101,140,99,157,96,182,119,51,28,197,78,206,61,236,254,188,7,156,190,36,52,27,51,72,113,218,137,162,8,250,182,204,115,97,22,195,106,125,131,133,65,139,202,89,16,10,38,105,74,112,239,63,126,128,201,168,116,79,32,232,67,123,50,246,229,193,174,203,133,53,86,212,0,123,172,122,33,29,156,17,177,251,206,177,145,45,190,161,187,208,121,65,0,83,153,73,183,184,193,231,82,26,204,185,100,183,185,96,18,48,128,223,28,225,172,176,10,36,199,92,164,40,167,153,140,33,206,132,181,47,4,124,255,163,151,246,181,129,19,56,23,22,247,100,16,216,210,11,213,57,50,56,99,194,68,198,58,83,198,180,105,79,224,218,87,90,103,180,180,236,91,68,136,13,166,131,224,53,106,247,158,100,35,32,133,49,139,120,28,68,195,150,112,53,129,61,141,109,65,64,217,70,36,102,83,98,214,221,14,179,7,59,171,191,238,247,77,29,110,154,104,151,61,66,149,172,181,108,11,59,70,247,164,147,125,154,214,129,81,203,130,214,115,7,169,128,162,96,11,140,101,202,157,173,221,90,20,89,149,23,110,240,162,109,192,126,33,140,200,65,209,12,15,2,70,251,170,103,82,5,67,214,24,50,254,7,167,61,124,19,175,31,249,99,191,70,201,133,204,216,254,104,174,146,96,56,166,149,31,21,194,43,149,124,46,17,100,194,20,82,137,166,5,244,56,41,112,253,96,52,167,166,243,72,147,124,165,230,250,7,118,215,58,209,88,4,151,159,238,130,30,220,27,121,135,121,145,9,199,179,18,52,196,65,238,255,108,195,103,176,220,252,174,222,53,251,27,44,155,171,85,208,227,138,157,115,157,44,110,221,34,99,84,170,62,70,107,197,12,55,209,240,193,144,24,152,244,128,71,15,173,251,172,77,46,92,43,121,29,10,191,88,173,56,205,22,116,91,184,63,207,207,111,237,46,77,13,25,18,10,104,226,248,5,219,230,214,173,226,27,94,61,184,44,101,2,77,58,149,249,58,6,93,105,148,55,100,248,10,167,1,208,58,123,186,107,92,234,192,181,209,49,113,64,187,253,46,198,252,116,165,70,231,111,55,34,67,4,195,209,107,220,127,107,152,138,66,187,206,5,149,57,227,90,131,37,127,201,19,240,167,126,240,106,255,7,79,204,53,221,244,206,230,107,107,112,247,181,5,252,221,239,62,225,83,79,119,188,84,28,91,253,4,177,80,3,244,229,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4bd7c72-2bab-433b-a88b-a5cf9daf8afb"));
		}

		#endregion

	}

	#endregion

}
