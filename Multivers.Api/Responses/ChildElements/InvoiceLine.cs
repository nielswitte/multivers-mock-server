using Multivers.Api.Enums;
using Multivers.Api.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Responses.ChildElements
{
    public class InvoiceLine
    {
        [MaxLength(8)]
        public string AccountId { get; set; }
        public IEnumerable<BrokenRule> AllBrokenRulesCollection { get; set; }
        public IEnumerable<BrokenRule> BrokenRulesCollection { get; set; }
        public bool CanChange { get; set; }
        public bool ContainsCustomProperties { get; set; }
        public AdministrationContext Context { get; set; }
        [MaxLength(8)]
        public string CostCentreId { get; set; }
        public bool CostCentreIdRequired { get; set; }
        [MaxLength(8)]
        public string CostUnitId { get; set; }
        public bool CostUnitIdRequired { get; set; }
        //15, 2
        public decimal CreditAmount { get; set; }
        public decimal CreditAmountCur { get; set; }
        public string CurrencyId { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal DebitAmountCur { get; set; }
        [MaxLength(30)]
        public string Description { get; set; }
        public int DocumentNumber { get; set; }
        public decimal ExchangeRate { get; set; }
        public int JournalSection { get; set; }
        public ReadOnlyCollection<int> LineNumbers { get; set; }
        public decimal Quantity { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        public int? VatCodeId { get; set; }
        public ExtVatType VatType { get; set; }
    }
}