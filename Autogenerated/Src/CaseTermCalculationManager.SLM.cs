﻿namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Configuration.Calendars;
	using Terrasoft.Configuration.TermCalculationService;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	/// <summary>
	/// Class for case term calculation.
	/// </summary>
	public class CaseTermCalculationManager
	{
		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes new instance of <see cref="CaseTermCalculationManager"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public CaseTermCalculationManager(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Calculates term for case entity.
		/// </summary>
		/// <param name="entityCase">Case entity.</param>
		public void Calculate(Entity entityCase) {
			var parameterReader = ClassFactory.Get<CaseCalculationParameterReader>(
					new ConstructorArgument("userConnection", _userConnection));
			var dictionaryParams = parameterReader.GetParams(entityCase.PrimaryColumnValue);
			var caseTermCalculateEntryPoint = ClassFactory.Get<CaseTermCalculateEntryPoint>(
								new ConstructorArgument("userConnection", _userConnection));
			ServiceTermResponse response = caseTermCalculateEntryPoint.CalculateTerms(dictionaryParams, _userConnection.CurrentUser.GetCurrentDateTime());
			entityCase.SetColumnValue("SolutionDate", response.SolutionTime);
			if (_userConnection.GetIsFeatureEnabled("DoNotRecalculateResponseDateIfAlreadyResponded")) {
				if (entityCase.GetTypedColumnValue<DateTime>("RespondedOn") == default(DateTime) || entityCase.GetTypedColumnValue<DateTime>("ResponseDate") == default(DateTime)) {
					entityCase.SetColumnValue("ResponseDate", response.ReactionTime);
				}
			} else {
				entityCase.SetColumnValue("ResponseDate", response.ReactionTime);
			}
		}

		#endregion

	}
}
