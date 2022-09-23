namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorCustomerServiceSchema

	/// <exclude/>
	public class CalendarRemindCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorCustomerServiceSchema(CalendarRemindCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187");
			Name = "CalendarRemindCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,193,106,194,64,16,61,71,240,31,6,189,68,16,63,64,241,20,74,201,161,80,106,123,42,61,172,155,49,93,72,118,195,236,174,34,154,127,239,108,18,107,180,8,233,37,240,102,246,205,123,111,38,222,42,157,195,230,104,29,150,171,241,200,55,240,29,137,132,53,59,183,72,12,33,151,199,35,45,74,180,149,144,120,211,212,59,149,123,18,78,25,61,30,157,194,187,104,74,152,51,132,164,16,214,46,33,17,5,234,76,208,27,150,74,103,140,164,47,132,51,148,120,235,76,137,180,65,218,43,137,13,181,242,219,66,73,144,129,57,148,8,143,37,120,34,91,138,174,142,140,182,142,188,228,22,27,123,37,181,23,174,21,142,170,22,12,21,141,63,44,18,143,211,40,67,116,240,55,112,22,38,70,75,216,10,139,241,93,11,26,71,117,171,58,101,173,214,91,135,59,163,47,232,190,77,22,60,54,11,233,44,182,203,177,142,183,45,7,111,39,33,228,92,41,7,23,90,226,191,98,204,225,217,171,12,36,167,72,179,206,120,180,23,212,84,158,180,83,238,8,107,200,209,37,191,56,190,159,208,146,231,160,241,240,249,5,39,152,116,202,41,255,109,105,54,153,195,132,207,96,136,169,140,160,158,173,26,17,181,139,251,26,107,208,190,40,224,124,238,41,47,174,188,240,32,56,93,60,149,149,59,94,140,70,132,206,147,110,168,237,212,186,249,94,202,120,24,124,236,63,39,132,144,152,179,247,76,214,171,7,119,237,106,253,82,253,3,60,249,78,255,116,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187"));
		}

		#endregion

	}

	#endregion

}

