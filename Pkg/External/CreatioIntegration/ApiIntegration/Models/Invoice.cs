using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatioIntegration.Models
{
    public class Invoice
    {
        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedById { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedById { get; set; }
        public int ProcessListeners { get; set; }
        public string LrnName { get; set; }
        public string LrnNotes { get; set; }
        public DateTime LrnDate { get; set; }
        public DateTime LrnPayDate { get; set; }
        public string LrnAgreementId { get; set; }
        public bool LrnFact { get; set; }
        public string LrnInvoiceTypeId { get; set; }
        public float LrnAmount { get; set; }
    }
}
