using Multivers.Api.Contracts;
using Multivers.Api.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Multivers.Api.Requests.ChildElements;

namespace Multivers.Api.Requests
{
    public class InvoiceRequest : MultiversRequest
    {

        public decimal AmountCreditSqueezeCur { get; set; }
        [MaxLength(55)]
        public string ContactPerson { get; set; }
        [MaxLength(8)]
        public string ContactPersonId { get; set; }
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
        [Required]
        [Range(0, 9999)]
        public short JournalTransaction { get; set; }
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
        public short? VatScenarioId { get; set; }
        public IEnumerable<VatTransactionLine> VatTransactionLines { get; set; }
    }
}