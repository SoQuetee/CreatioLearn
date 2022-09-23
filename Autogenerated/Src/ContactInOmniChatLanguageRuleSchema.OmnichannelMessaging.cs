namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactInOmniChatLanguageRuleSchema

	/// <exclude/>
	public class ContactInOmniChatLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactInOmniChatLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactInOmniChatLanguageRuleSchema(ContactInOmniChatLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba21deee-aa7e-5f17-8481-2cba8316ae86");
			Name = "ContactInOmniChatLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,77,111,219,48,12,134,207,41,208,255,64,120,151,4,48,236,123,154,24,216,130,161,8,176,110,221,218,238,174,218,180,35,192,150,60,74,202,96,4,253,239,163,229,143,217,238,86,244,22,210,228,195,151,47,21,37,42,52,181,72,17,30,145,72,24,157,219,232,160,85,46,11,71,194,74,173,174,175,46,215,87,43,103,164,42,224,161,49,22,171,155,49,158,182,16,254,47,31,125,86,86,90,137,134,11,184,36,142,99,216,25,87,85,130,154,164,143,15,165,48,38,132,154,244,89,102,104,160,20,170,112,162,192,16,114,210,21,124,171,148,60,156,132,133,14,207,250,172,72,109,52,192,226,9,173,118,207,165,76,33,109,129,67,225,81,13,128,47,61,247,135,43,17,182,240,73,24,156,166,184,255,226,53,174,62,16,22,188,124,75,48,150,92,106,53,153,45,220,123,120,87,177,92,163,219,131,80,88,214,47,185,75,40,54,85,231,92,132,8,41,97,190,15,222,212,19,196,73,52,130,227,37,121,87,11,18,21,40,62,215,62,112,6,137,89,10,211,246,66,65,242,196,49,164,99,34,218,197,190,218,55,247,134,188,57,122,253,52,3,194,156,191,105,49,171,45,60,179,91,235,197,39,184,192,75,239,24,170,172,51,109,238,224,29,218,147,206,222,99,222,253,242,250,243,227,135,175,175,255,30,175,116,223,126,204,130,100,124,71,216,190,200,6,120,26,255,200,37,210,204,50,207,144,234,132,36,109,166,83,136,167,70,234,51,63,110,110,132,91,39,51,184,197,209,200,99,182,246,169,191,3,217,29,111,221,89,16,160,249,5,123,80,248,27,252,191,161,121,72,79,88,137,239,14,169,89,184,31,77,11,238,132,98,52,133,16,12,218,131,205,205,8,29,140,58,232,210,85,234,43,239,203,51,120,82,244,49,203,186,220,122,120,115,209,32,51,98,35,54,81,91,219,113,186,105,163,234,62,236,48,188,93,23,47,36,134,211,37,59,140,95,189,28,173,96,192,156,216,178,30,155,26,123,93,63,69,233,112,215,54,37,235,215,91,244,76,66,235,72,77,168,62,253,239,247,198,217,151,63,54,40,23,175,204,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba21deee-aa7e-5f17-8481-2cba8316ae86"));
		}

		#endregion

	}

	#endregion

}

