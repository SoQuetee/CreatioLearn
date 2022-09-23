namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatLanguageIteratorSchema

	/// <exclude/>
	public class ChatLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatLanguageIteratorSchema(ChatLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bfb32ab4-18f2-0b7b-7c32-952642edc498");
			Name = "ChatLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,61,107,195,64,12,134,103,7,242,31,132,179,36,80,124,123,190,134,166,75,160,208,82,154,169,116,80,174,178,115,112,62,135,251,160,164,37,255,189,58,59,78,237,36,67,59,24,115,210,171,71,175,36,131,37,185,61,74,130,87,178,22,93,149,251,108,85,153,92,21,193,162,87,149,25,14,190,135,131,36,56,101,138,158,196,210,108,56,224,204,200,82,193,50,88,105,116,110,10,171,29,250,71,52,69,192,130,214,158,152,81,217,90,39,132,128,185,11,101,137,246,176,60,189,91,1,228,252,105,229,124,108,178,61,192,83,105,84,4,129,62,145,92,214,18,68,7,177,15,91,173,36,200,216,249,102,99,152,194,61,58,186,246,147,196,153,126,173,87,198,121,27,36,167,120,130,231,154,90,123,190,50,221,184,54,202,43,212,234,139,28,24,250,4,197,213,104,120,131,85,206,98,34,144,150,242,69,122,203,80,42,150,25,156,193,226,146,60,223,163,197,18,12,223,100,145,6,71,150,157,25,146,241,12,233,114,195,111,144,231,64,54,23,181,186,46,62,109,226,86,203,241,166,199,129,62,118,18,171,147,41,108,121,77,227,139,84,210,108,41,105,137,47,65,243,196,139,122,230,117,55,248,246,14,141,50,137,41,38,120,148,126,109,218,43,118,165,23,110,38,119,157,186,29,114,88,255,187,238,129,114,12,250,15,234,227,44,254,142,205,101,71,100,62,154,243,215,239,38,218,15,30,127,0,82,180,95,187,28,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfb32ab4-18f2-0b7b-7c32-952642edc498"));
		}

		#endregion

	}

	#endregion

}

