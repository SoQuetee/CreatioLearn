namespace Terrasoft.Configuration.LrnInvoiceEntityListener
{
    using System;
    using Terrasoft.Core.Entities;
    using Terrasoft.Core.Entities.Events;
    using Terrasoft.Configuration;

    [EntityEventListener(SchemaName = "LrnInvoce")]
    public class InvoiceEntityEventListener : BaseEntityEventListener
    {
        public override void OnSaving(object sender, EntityBeforeEventArgs e)
        {
            var entity = (LrnInvoce)sender;

            //проверка, что на указанную дату и договор нет счетов
            var esqInvoice = new EntitySchemaQuery(entity.UserConnection.EntitySchemaManager, "LrnInvoce");

            esqInvoice.AddColumn("LrnDate");
            esqInvoice.AddColumn("LrnAgreement");

            var esqFilterByDate = esqInvoice.CreateFilterWithParameters(FilterComparisonType.Equal, "LrnDate", entity.LrnDate);
            var esqFilterByAgreement = esqInvoice.CreateFilterWithParameters(FilterComparisonType.Equal, "LrnAgreement", entity.LrnAgreementId);
            var esqFilterByCurrentId = esqInvoice.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Id", entity.Id);

            esqInvoice.Filters.Add(esqFilterByDate);
            esqInvoice.Filters.Add(esqFilterByAgreement);
            esqInvoice.Filters.Add(esqFilterByCurrentId);

            var esqInvoiceResult = esqInvoice.GetEntityCollection(entity.UserConnection);

            if (esqInvoiceResult.Count == 0)
            {
                //установить тип счета
                var invoiceType = entity.GetTypedColumnValue<Guid>("LrnInvoiceTypeId");
                if (invoiceType == null || invoiceType == Guid.Empty)
                {
                    var esq = new EntitySchemaQuery(entity.UserConnection.EntitySchemaManager, "LrnInvoiceType");
                    var typeId = esq.AddColumn("Id");
                    var esqFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "LrnCode", 1);
                    esq.Filters.Add(esqFilter);
                    var esqResult = esq.GetEntityCollection(entity.UserConnection);
                    entity.SetColumnValue("LrnInvoiceTypeId", esqResult[0].GetTypedColumnValue<Guid>(typeId.Name));
                }
                //если на счете статус Оплачено
                if (entity.LrnFact && entity.LrnAgreement.FetchFromDB(entity.LrnAgreementId))
                {
                    var totalAmount = entity.LrnAgreement.LrnFactSumma + entity.LrnAmount;

                    //проверка, что сумма платежа не превысила суммe договора
                    if (totalAmount <= entity.LrnAgreement.LrnSumma)
                    {
                        entity.LrnAgreement.LrnFactSumma = totalAmount;
                        entity.LrnDate = DateTime.Now;
                        //смена статуса в договоре на Оплачен 
                        if (totalAmount == entity.LrnAgreement.LrnSumma)
                        {
                            entity.LrnAgreement.LrnFact = true;
                        }
                        entity.LrnAgreement.Save();
                    }
                    else
                    {
                        var invalidMessage = LocalizableStringHelper.GetValue(entity.UserConnection, "LrnInvoiceEntityListener", "TotalAmountExceedWarning");
                        throw new Exception(invalidMessage);
                    }
                }
                base.OnSaving(sender, e);

            }
            else
            {
                var invalidMessage = LocalizableStringHelper.GetValue(entity.UserConnection, "LrnInvoiceEntityListener", "DailyInvoiceLimitWarning");
                throw new Exception(invalidMessage);
            }

        }

        public override void OnDeleting(object sender, EntityBeforeEventArgs e)
        {
            var entity = (LrnInvoce)sender;
            if (entity.LrnFact && entity.LrnAgreement.FetchFromDB(entity.LrnAgreementId))
            {
                //условие для тестов
                if (entity.LrnAgreement.LrnFactSumma > 0) {
                    entity.LrnAgreement.LrnFactSumma -= entity.LrnAmount;
                    //снятие статуса Оплачен с договора
                    if (entity.LrnAgreement.LrnFact)
                    {
                        entity.LrnAgreement.LrnFact = false;
                    }
                    entity.LrnAgreement.Save();
                }
            }
            base.OnDeleting(sender, e);
        }

    }
}
