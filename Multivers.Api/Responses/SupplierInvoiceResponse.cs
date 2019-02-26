using Multivers.Api.Responses.ChildElements;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Responses
{
    public class SupplierInvoiceResponse : InvoiceResponse {
        public decimal AmountFrozen { get; set;  }
        public decimal AmountFrozenCur { get; set; }
        [Required]
        [MaxLength(8)]
        public string SupplierId { get; set; }
        public bool SupplierIsSubcontractor { get; set; }
        public IEnumerable<SupplierInvoiceLine> SupplierInvoiceLines { get; set; }

    }
}