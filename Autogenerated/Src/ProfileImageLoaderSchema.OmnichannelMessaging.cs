﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProfileImageLoaderSchema

	/// <exclude/>
	public class ProfileImageLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProfileImageLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProfileImageLoaderSchema(ProfileImageLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4bf32fa1-978c-44e5-982d-6da56ab61376");
			Name = "ProfileImageLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,111,156,48,16,61,19,41,255,97,68,46,187,210,10,238,109,118,165,118,15,17,82,190,212,36,234,49,114,96,96,45,129,77,109,147,213,182,202,127,239,216,6,150,133,16,165,189,128,61,126,111,60,51,111,198,130,85,168,107,150,34,60,162,82,76,203,220,68,91,41,114,94,52,138,25,46,69,116,87,9,158,238,152,16,88,70,55,168,53,43,184,40,206,207,254,156,159,5,141,166,37,60,28,180,193,234,235,104,31,37,119,19,211,45,154,163,109,120,159,194,57,123,148,84,172,192,111,247,9,1,8,114,161,176,160,160,96,91,50,173,191,192,189,146,57,47,209,97,174,37,203,80,57,84,28,199,112,169,155,170,98,234,176,105,247,142,177,2,179,99,6,74,130,106,168,61,25,234,157,52,50,234,104,241,128,87,55,47,37,79,33,181,212,119,239,10,108,21,250,160,8,81,163,50,28,93,100,252,149,25,116,225,4,181,223,128,66,150,73,81,30,32,233,178,130,103,238,86,53,247,249,5,23,40,50,239,174,221,191,235,91,26,76,13,102,30,50,206,214,25,158,52,42,72,37,169,150,58,21,123,224,48,63,10,172,245,228,240,219,30,62,218,250,52,131,194,203,23,188,125,28,42,241,180,81,77,106,164,178,193,186,26,126,16,105,34,184,225,172,228,191,81,3,3,129,123,224,196,103,130,90,82,230,164,23,18,5,17,82,133,249,58,156,138,16,198,27,47,208,49,197,154,41,86,129,160,206,94,135,205,73,34,225,38,153,247,125,154,51,249,141,46,99,231,106,51,83,60,223,29,211,144,22,163,98,158,198,176,108,171,57,2,173,71,48,87,233,160,111,15,58,183,165,233,250,102,116,197,242,51,186,220,160,217,201,236,51,146,92,79,231,3,114,37,43,104,84,57,83,102,85,134,155,39,85,66,46,21,100,114,47,236,136,209,52,79,75,56,100,185,228,110,105,73,186,216,165,51,79,41,10,77,163,132,110,49,60,67,97,120,206,81,17,178,59,250,80,161,171,134,103,112,133,166,85,234,222,230,147,100,223,15,20,239,130,58,213,62,58,20,255,10,218,117,31,213,18,188,82,175,76,121,99,146,145,12,214,27,189,100,123,251,95,248,194,7,63,241,229,7,254,106,80,27,15,236,54,107,56,158,68,91,26,127,131,11,186,170,101,249,247,110,225,32,186,166,169,65,216,15,214,235,19,95,17,37,208,29,45,150,93,104,157,143,7,67,206,171,33,189,181,172,135,182,161,15,127,62,240,212,185,234,179,189,193,74,170,67,239,199,182,223,208,68,212,160,163,6,147,139,233,241,174,15,143,114,49,241,212,230,62,236,237,232,129,189,226,20,185,2,223,32,113,45,138,112,117,148,101,213,137,209,187,122,243,127,255,243,95,223,24,29,114,56,30,239,118,188,141,224,216,241,142,53,243,100,78,154,88,187,96,195,77,91,40,122,87,28,29,50,102,216,167,219,223,126,123,234,252,4,216,48,179,214,255,236,28,12,187,222,18,220,216,116,29,162,219,210,254,127,175,143,100,211,255,164,213,188,44,163,87,203,91,135,198,183,191,130,67,174,14,171,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4bf32fa1-978c-44e5-982d-6da56ab61376"));
		}

		#endregion

	}

	#endregion

}

