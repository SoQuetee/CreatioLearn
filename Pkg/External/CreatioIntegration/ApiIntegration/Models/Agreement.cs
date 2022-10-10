using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatioIntegration.Models
{
    public class Agreement
    {
        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedById { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedById { get; set; }
        public int ProcessListeners { get; set; }
        public string LrnName { get; set; }
        public string LrnNotes { get; set; }
        public string LrnAutoId { get; set; }
        public string LrnContactId { get; set; }
        public DateTime LrnDate { get; set; }
        public float LrnSumma { get; set; }
        public bool LrnFact { get; set; }
        public string LrnCreditId { get; set; }
        public int LrnCreditPeriod { get; set; }
        public float LrnCreditAmount { get; set; }
        public float LrnFullCreditAmount { get; set; }
        public float LrnInitialFee { get; set; }
        public float LrnFactSumma { get; set; }
        public DateTime LrnPaymentPlanDate { get; set; }
    }
}
