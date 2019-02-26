using System.ComponentModel.DataAnnotations;
using Multivers.Api.Enums;

namespace Multivers.Api.Requests.ChildElements
{
    public class VatTransactionLine
    {
        public decimal AmountNotDeductibleCur { get; set; }
        public decimal AmountTurnoverCur { get; set; }
        public string CurrencyId { get; set; }
        public int FiscalYear { get; set; }
        public decimal VatAmountCur { get; set; }
        [Range(0,9)]
        public int VatCodeId { get; set; }
        public short? VatScenarioId { get; set; }
        public ExtVatType VatType { get; set; }
    }
}