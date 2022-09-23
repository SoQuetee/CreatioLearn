 namespace Terrasoft.Configuration.UsrTourService
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.ServiceModel.Activation;
    using Terrasoft.Core;
    using Terrasoft.Core.DB;
    using Terrasoft.Common;
    using Terrasoft.Web.Common;
    using Terrasoft.Core.Entities; 

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class UsrTourService: BaseService
    {

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
        ResponseFormat = WebMessageFormat.Json)]
        public decimal GetTourPriceByCode(string code) {
            var groupSectionQuery = new Select(UserConnection)
                .Column("Id")
                .From("UsrTourOffer")
                .Where("UsrTourOfferCode")
                    .IsEqual(Column.Parameter(code))
                as Select;
            Guid id = groupSectionQuery.ExecuteScalar<Guid>();
            if (id==Guid.Empty) {
                return -1;
            }
			
			var statusName = "Запланирован";
			var plannedTour = new Select(UserConnection)
				.Column("Id")
				.From("UsrTourStatusList")
				.Where("Name")
					.IsEqual(Column.Parameter(statusName))
				as Select;
			Guid statusId = plannedTour.ExecuteScalar<Guid>();
			if(statusId == Guid.Empty){
				return -1;
			}
			
            var priceQuery = new Select(UserConnection)
                .Column(Func.Sum("UsrTourPrice")).As("TotalPrice")
                .From("UsrTour")
                .Where("UsrTourOffersId")
                    .IsEqual(Column.Parameter(id))
				.And("UsrTourStatusId")
					.IsEqual(Column.Parameter(statusId))
                as Select;
            decimal result = priceQuery.ExecuteScalar<decimal>();
            
            return result;
        }
    }
}