﻿using System;
using Terrasoft.Core;
using Terrasoft.Core.Entities;
using System.Collections.Generic;

namespace Terrasoft.Configuration
{

	#region Class: CalendarRemindCalculator

	public class CalendarRemindCalculator
	{
		#region Constructors: Protected

		protected CalendarRemindCalculator(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection { 
			get;
			set;
		}

		#endregion

		#region Properties: Protected

		protected Case Case { 
			private get;
			set;
		}

		private TermCalculator _termCalculator;
		protected TermCalculator TermCalculator { 
			get {
				if(_termCalculator != null) {
					return _termCalculator;
				}
				_termCalculator = new TermCalculator(UserConnection, Case.ServiceItemId, Case.PriorityId);
				return _termCalculator;
			}
		}
		
		private ResponseLabelTermCalculationData _termCalculationData;
		protected ResponseLabelTermCalculationData TermCalculationData {
			get {
				return _termCalculationData ?? GetResponseTermLabelCalculationData();
			}
		}

		#endregion

		#region Methods: Protected
		
		protected static Case getCaseEntity(UserConnection userConnection, Guid caseId, string[] columnsName) {
			if (caseId == Guid.Empty) {
				return null;
			}
			
			var schema = userConnection.EntitySchemaManager.GetInstanceByName("Case");
			var caseEntity = schema.CreateEntity(userConnection);
			var fetchColumns = new List<EntitySchemaColumn>();
			foreach(var column in columnsName) {
				fetchColumns.Add(schema.Columns.FindByColumnValueName(column));
			}
			if (caseEntity.FetchFromDB(schema.PrimaryColumn, caseId, fetchColumns.ToArray())) {
				return (Case)caseEntity;
			} else {
				return null;
			}
		}
		
		#endregion
		
		#region Methods: Public

		public static CalendarRemindCalculator CreateInstance(UserConnection userConnection, Guid caseId) {
			var caseEntity = getCaseEntity(userConnection, caseId, new[] { "ServiceItemId", "PriorityId" });
			if(caseEntity == null || caseEntity.PriorityId == Guid.Empty) {
				return null;
			}
			return new CalendarRemindCalculator(userConnection) { Case = caseEntity };
		}

		public TimeSpan GetRemindTimeSpan(DateTime toDate, bool isResolution,
			ResponseLabelTermCalculationData termCalculationData = null) {
			TimeSpan workingTimeSpan = TimeSpan.Zero;
			if (TermCalculationData == null || toDate == DateTime.MinValue) {
				return workingTimeSpan;
			}

			DateTime userCurrentDateTIme = UserConnection.CurrentUser.GetCurrentDateTime();
			bool isCalendarDays = isResolution
				? TermCalculationData.IsResolutionInCalendarDays
				: TermCalculationData.IsResponseInCalendarDays;

			if (isCalendarDays) {
				workingTimeSpan = toDate - userCurrentDateTIme;
			}
			else {
				var termCalculatorActions = new TermCalculatorActions(UserConnection,
					TermCalculationData.CalendarId);
				var timeZoneConvertor = new TimeZoneConvertor(TermCalculationData.CalendarTimeZone,
					UserConnection.CurrentUser.TimeZone);
				DateTime calendarUserCurrentDateTime = timeZoneConvertor.ToCalendarDateTime(userCurrentDateTIme);
				DateTime calendarResponseDate = timeZoneConvertor.ToCalendarDateTime(toDate);
				workingTimeSpan = termCalculatorActions.GetWorkingTimeSpan(calendarUserCurrentDateTime, calendarResponseDate);
			}

			return workingTimeSpan;
		}

		public DateTime GetSolutionDateAfterPause(long remind, bool isResolution,
			ResponseLabelTermCalculationData termCalculationData = null) {
			DateTime currentDateTime = UserConnection.CurrentUser.GetCurrentDateTime();
			if (TermCalculationData == null) {
				return currentDateTime;
			}

			bool isCalendarDays = isResolution
				? TermCalculationData.IsResolutionInCalendarDays
				: TermCalculationData.IsResponseInCalendarDays;

			var remindTimeSpan = new TimeSpan(remind);
			if (isCalendarDays) {
				return currentDateTime + remindTimeSpan;
			}
			
			return TermCalculator == null 
				? currentDateTime 
				: TermCalculator.CalculateByCalendar(currentDateTime, remindTimeSpan);
		}

		public ResponseLabelTermCalculationData GetResponseTermLabelCalculationData() {
			return TermCalculator == null ? null : TermCalculator.GetResponseLabelTermCalculationData();
		}

		#endregion
	}

	#endregion
}
