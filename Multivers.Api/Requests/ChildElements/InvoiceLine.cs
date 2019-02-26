using Multivers.Api.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Requests.ChildElements
{
    public class InvoiceLine
    {
        [MaxLength(8)]
        public string AccountId { get; set; }
        [MaxLength(8)]
        public string CostCentreId { get; set; }
        [MaxLength(8)]
        public string CostUnitId { get; set; }
        public decimal CreditAmountCur { get; set; }
        public decimal DebitAmountCur { get; set; }
        [MaxLength(30)]
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        public int? VatCodeId { get; set; }
        public ExtVatType VatType { get; set; }
    }
}