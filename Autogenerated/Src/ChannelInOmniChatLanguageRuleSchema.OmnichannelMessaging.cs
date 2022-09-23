namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChannelInOmniChatLanguageRuleSchema

	/// <exclude/>
	public class ChannelInOmniChatLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChannelInOmniChatLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChannelInOmniChatLanguageRuleSchema(ChannelInOmniChatLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("793788e6-b334-a107-994a-4852353f66cb");
			Name = "ChannelInOmniChatLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,77,111,219,48,12,134,207,41,208,255,64,120,23,7,8,236,123,154,24,216,130,161,8,176,110,221,218,238,174,218,180,35,192,150,60,74,202,96,4,253,239,163,229,143,217,222,214,245,38,210,228,195,151,175,100,80,162,66,83,139,20,225,17,137,132,209,185,141,14,90,229,178,112,36,172,212,234,250,234,114,125,181,114,70,170,2,30,26,99,177,186,25,227,105,11,225,191,242,209,71,101,165,149,104,184,128,75,226,56,134,157,113,85,37,168,73,250,248,80,10,99,54,80,147,62,203,12,13,148,66,21,78,20,184,129,156,116,5,95,42,37,15,39,97,161,195,243,81,41,44,163,1,22,79,104,181,123,46,101,10,105,11,28,10,143,106,0,124,234,185,223,92,137,176,133,15,194,224,52,197,253,23,175,113,245,142,176,224,229,129,173,48,150,92,106,53,153,45,220,123,120,87,177,92,163,219,131,80,88,214,47,185,75,40,54,85,231,92,132,8,41,97,190,15,94,213,19,196,73,52,130,227,37,121,87,11,18,21,180,215,181,15,156,65,98,101,10,211,246,134,130,228,137,99,72,199,68,180,139,125,181,111,238,13,121,117,116,248,52,3,194,156,191,110,49,171,45,60,179,91,225,226,19,92,224,165,119,12,85,214,153,54,119,240,14,237,73,103,111,49,239,126,121,251,255,187,252,183,88,165,251,238,99,22,36,35,9,219,7,217,0,15,227,67,46,145,102,142,121,134,84,39,36,105,51,157,66,60,245,81,159,249,109,115,35,220,58,153,193,45,142,62,30,179,208,167,126,15,100,115,188,115,103,65,128,230,7,236,65,225,79,240,63,67,243,144,158,176,18,95,29,82,179,48,63,154,22,220,9,197,104,218,64,48,104,15,214,55,35,116,240,233,160,75,87,169,207,188,47,207,224,73,209,251,44,235,114,225,240,228,162,65,102,196,70,172,163,182,182,227,116,211,70,213,125,216,97,120,187,46,94,72,220,76,151,236,48,126,245,114,180,130,1,115,98,203,122,108,106,236,117,125,23,165,195,93,219,148,132,127,110,209,51,9,173,35,53,161,250,244,223,159,27,103,95,126,1,179,72,254,133,204,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("793788e6-b334-a107-994a-4852353f66cb"));
		}

		#endregion

	}

	#endregion

}

