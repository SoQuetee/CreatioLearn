﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileSecurityExcludedUriEventListenerSchema

	/// <exclude/>
	public class FileSecurityExcludedUriEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileSecurityExcludedUriEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileSecurityExcludedUriEventListenerSchema(FileSecurityExcludedUriEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5df7f81e-f95c-557a-9f87-1d54f9fb1078");
			Name = "FileSecurityExcludedUriEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,84,77,143,211,48,16,61,119,165,253,15,163,112,216,84,66,206,189,95,210,82,90,88,9,150,21,93,196,1,33,228,38,147,198,224,216,149,237,68,84,171,253,239,76,156,164,180,85,67,3,87,110,177,61,95,239,189,121,81,60,71,187,229,49,194,35,26,195,173,78,29,155,107,149,138,77,97,184,19,90,93,95,61,93,95,13,10,43,212,230,40,36,207,181,26,159,125,49,200,22,202,9,39,208,94,12,96,139,18,149,235,142,91,242,216,105,211,81,233,51,174,217,82,72,92,97,92,24,225,118,20,67,81,47,12,110,104,110,152,75,110,237,8,14,3,22,63,99,89,36,152,124,50,194,247,125,39,172,67,133,198,231,69,81,4,19,91,228,57,55,187,89,115,110,3,32,213,6,110,58,74,221,0,86,104,118,128,30,11,107,107,69,39,197,38,22,145,75,171,33,54,152,78,131,63,51,194,94,113,139,254,110,119,52,106,0,81,85,239,203,153,167,112,21,103,152,243,123,82,20,166,16,116,76,27,12,191,82,254,182,88,75,17,67,92,113,212,139,34,24,65,199,68,84,237,201,19,184,103,126,41,80,38,68,253,131,17,37,119,88,63,110,235,3,24,228,137,86,114,7,119,29,109,237,131,209,165,72,168,229,183,109,243,53,110,234,163,74,234,22,199,253,104,95,173,51,69,181,41,212,245,78,57,52,138,203,58,70,52,167,94,32,195,203,51,181,35,13,161,178,69,5,171,62,179,121,134,241,143,91,179,41,114,42,120,95,72,25,42,18,66,167,225,62,99,56,246,25,123,84,36,210,1,192,193,224,249,111,80,62,120,1,27,106,107,49,123,33,28,146,144,46,19,54,244,246,168,237,181,99,111,208,77,46,98,159,133,195,6,245,133,73,223,163,203,116,231,2,148,90,36,240,17,45,186,57,167,133,13,91,38,247,188,176,195,199,62,204,252,238,119,64,202,169,157,253,197,91,174,18,137,182,53,236,138,151,152,212,182,101,251,156,232,52,105,178,229,134,231,80,201,57,13,44,205,64,46,156,121,86,161,62,177,73,228,67,206,103,96,48,123,204,208,187,191,117,254,168,211,251,126,174,219,148,118,214,55,160,125,178,149,227,65,144,246,92,209,95,58,214,202,113,161,170,31,161,203,176,109,232,33,64,194,29,63,154,165,89,12,93,82,59,98,182,166,254,131,242,176,67,189,254,142,113,11,225,37,156,107,13,216,138,179,38,239,179,54,179,77,193,102,163,187,244,234,35,193,107,148,232,254,71,17,26,224,255,36,67,155,219,87,136,19,227,212,183,199,151,116,247,11,156,167,229,94,11,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5df7f81e-f95c-557a-9f87-1d54f9fb1078"));
		}

		#endregion

	}

	#endregion

}
