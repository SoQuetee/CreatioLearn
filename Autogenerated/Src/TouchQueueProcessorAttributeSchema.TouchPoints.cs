namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueProcessorAttributeSchema

	/// <exclude/>
	public class TouchQueueProcessorAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueProcessorAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueProcessorAttributeSchema(TouchQueueProcessorAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9dc9ea7-5170-4749-8f69-4d60ffecdb57");
			Name = "TouchQueueProcessorAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,80,49,142,194,48,16,172,47,82,254,176,130,230,104,226,158,3,36,148,15,28,34,87,33,138,197,108,140,165,196,206,237,218,5,58,241,119,108,114,164,160,160,243,204,142,103,118,199,97,79,50,160,38,104,136,25,197,183,161,170,189,107,173,137,140,193,122,87,22,127,101,241,17,197,58,3,251,171,4,234,191,202,34,49,115,38,147,198,80,119,40,178,132,198,71,125,217,69,138,244,205,94,147,136,231,109,8,108,79,49,208,67,175,148,130,149,196,190,71,190,110,254,241,164,128,224,225,76,173,117,249,149,140,224,55,59,65,90,77,208,16,12,79,75,208,57,173,122,218,169,23,191,149,16,97,39,30,52,83,187,158,141,235,86,83,202,12,84,86,30,38,226,39,187,127,78,176,65,54,20,164,122,156,180,56,38,233,16,79,157,213,99,234,219,19,97,9,175,105,233,123,110,238,54,182,69,238,60,22,150,97,226,238,185,156,196,129,120,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9dc9ea7-5170-4749-8f69-4d60ffecdb57"));
		}

		#endregion

	}

	#endregion

}

