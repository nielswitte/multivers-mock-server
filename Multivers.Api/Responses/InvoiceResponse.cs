using Multivers.Api.Contracts;
using Multivers.Api.Enums;
using Multivers.Api.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Multivers.Api.Responses.ChildElements;

namespace Multivers.Api.Responses
{
    public class InvoiceResponse : MultiversResponse
    {
        public IEnumerable<BrokenRule> AllBrokenRulesCollection { get; set; }
        public decimal AmountCreditSqueeze { get; set; }
        public decimal AmountCreditSqueezeCur { get; set; }
        public decimal AmountRebate { get; set; }
        public decimal AmountRebateCur { get; set; }
        public decimal AmountTotal { get; set; }
        public decimal AmountTotalCur { get; set; }
        public string BordereauxNumber { get; set; }
        public IEnumerable<BrokenRule> BrokenRulesCollection { get; set; }
        public bool CanChange { get; set; }
        [MaxLength(55)]
        public string ContactPerson { get; set; }
        [MaxLength(8)]
        public string ContactPersonId { get; set; }
        public bool ContainsCustomProperties { get; set; }
        public AdministrationContext Context { get; set; }
        [MaxLength(3)]
        public string CurrencyId { get; set; }
        public int DocumentNumber { get; set; }
        public decimal ExchangeRate { get; set; }
        [Required]
        public int FiscalYear { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }
        [Required]
        public DateTime InvoiceExpirationDate { get; set; }
        [MaxLength(8)]
        public string InvoiceId { get; set; }
        public InvoiceType InvoiceType { get; set; }
        [Required]
        [MaxLength(3)]
        public string JournalId { get; set; }
        public string JournalSection { get; set; }
        [Required]
        [Range(0, 9999)]
        public short JournalTransaction { get; set; }
        public bool KVCPaymentCondition { get; set; }
        public bool OpeningBalance { get; set; }
        [Required]
        [MaxLength(3)]
        public string PaymentConditionId { get; set; }
        [MaxLength(16)]
        public string PaymentReference { get; set; }
        [Required]
        public int PeriodNumber { get; set; }
        [MaxLength(55)]
        public string ProcessedBy { get; set; }
        [MaxLength(8)]
        public string ProcessedById { get; set; }
        [Required]
        public DateTime RebateExpirationDate { get; set; }
        public string Reference { get; set; }
        public bool SystemInvoice { get; set; }
        public decimal TotalAmountVatExcl { get; set; }
        public decimal TotalAmountVatExclCur { get; set; }
        public bool VatAdjusted { get; set; }
        public decimal VatAmount { get; set; }
        public decimal VatAmountCur { get; set; }
        public bool VatOnInvoice { get; set; }
        public short? VatScenarioId { get; set; }
        public IEnumerable<VatTransactionLine> VatTransactionLines { get; set; }
    }
}