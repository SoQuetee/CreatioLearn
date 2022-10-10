using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatioIntegration.Models
{
    public class InvoiceCreate
    {
        public string LrnName { get; set; }
        public DateTime LrnDate { get; set; }
        public Guid LrnAgreementId { get; set; }
        public DateTime LrnPayDate { get; set; }
        //захардкодил, в идеале получать отдельным запросом
        public Guid LrnInvoiceTypeId { get; set; } = new Guid("832188F3-0444-43EF-88A3-5B2C6BC04CCF");
        public decimal LrnAmount { get; set; }
    }
}
