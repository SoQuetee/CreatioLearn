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

	#region Class: UsrAddToursProcessTest_work1MethodsWrapper

	/// <exclude/>
	public class UsrAddToursProcessTest_work1MethodsWrapper : ProcessModel
	{

		public UsrAddToursProcessTest_work1MethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			var userConnection = Get<UserConnection>("UserConnection");
			Terrasoft.Configuration.MsgChannelUtilities.PostMessage(
			    userConnection,
			    "AddingTours",
			    "");
			return true;
		}

		#endregion

	}

	#endregion

}

