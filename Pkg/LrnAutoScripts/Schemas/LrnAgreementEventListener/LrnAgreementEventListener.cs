namespace Terrasoft.Configuration.LrnInvoiceEntityListener
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
    using Terrasoft.Core.Entities.Events;

    [EntityEventListener(SchemaName = "LrnAgreement")]
    public class AgreementEntityEventListener : BaseEntityEventListener
    {
        public override void OnInserting(object sender, EntityBeforeEventArgs e)
        {
            var entity = (LrnAgreement)sender;
            
            if (entity.LrnContact.FetchFromDB(entity.LrnContactId))
            {
                var esq = new EntitySchemaQuery(entity.UserConnection.EntitySchemaManager, "LrnAgreement");
                esq.AddColumn("Id");
                var esqFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "LrnContact", entity.LrnContact.Id);
                esq.Filters.Add(esqFilter);
                var esqResult = esq.GetEntityCollection(entity.UserConnection);
                if (esqResult.Count == 0)
                {
                    if (entity.LrnContact.LrnDate == DateTime.MinValue)
                    {
                        entity.LrnContact.LrnDate = entity.LrnDate;
                        entity.LrnContact.Save();
                        //все равно не работает
                        //var contact = new Contact(entity.UserConnection)
                        //{
                        //    Id = entity.LrnContact.PrimaryColumnValue,
                        //    LrnDate = entity.LrnDate
                        //};
                        //contact.Save(false, false);
                    }
                    
                }
            }
            base.OnInserting(sender, e);
        }

        //public override void OnDeleting(object sender, EntityBeforeEventArgs e)
        //{
        //    var entity = (LrnAgreement)sender;
        //    if (entity.LrnContact.FetchFromDB(entity.LrnContactId))
        //    {
        //        if (entity.LrnContact.LrnDate != DateTime.MinValue)
        //        {
        //            entity.LrnContact.LrnDate = установить пустое значение
        //        }
        //    }
        //    base.OnDeleting(sender, e);
        //}
    }
}
