namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: MkpMarketplaceCreatioWebServiceMethodsWrapper

	/// <exclude/>
	public class MkpMarketplaceCreatioWebServiceMethodsWrapper : ProcessModel
	{

		public MkpMarketplaceCreatioWebServiceMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			string dateInput = Get<string>("ProcessSchemaParameterDateTimeString");
			var culture = CultureInfo.CreateSpecificCulture("en-US");
			DateTime ParsedDateTime = DateTime.Parse(dateInput, culture);
			Set("ProcessSchemaParameterDateTime", ParsedDateTime);
			return true;
		}

		#endregion

	}

	#endregion

}

