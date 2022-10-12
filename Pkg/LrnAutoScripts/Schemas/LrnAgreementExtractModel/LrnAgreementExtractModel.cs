using System;
using System.Collections.Generic;
namespace Terrasoft.Configuration.LrnAgreementExtractModel
{
    public class AgreementExtractModel
    {
        public string Number { get; set; }
        public AutoModel Auto { get; set; }
        public ContactModel Contact { get; set; }
        public decimal Summa { get; set; }
        public decimal FactSumma { get; set; }
        public bool Fact { get; set; }
        public List<InvoiceModel> Invoices { get; set; }
    }

    public class AutoModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Details { get; set; }
        public string VIN { get; set; }
    }

    public class ContactModel
    {
        public string FullName { get; set; }
    }
    public class InvoiceModel
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool Fact { get; set; }
    }
    public class CustomFile
    {
        public byte[] FileContent { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
    }
}
