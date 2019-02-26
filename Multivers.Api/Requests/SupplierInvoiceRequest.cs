using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Multivers.Api.Requests.ChildElements;

namespace Multivers.Api.Requests
{
    public class SupplierInvoiceRequest : InvoiceRequest
    {
        public decimal AmountFrozen { get; set; }
        public decimal AmountFrozenCur { get; set; }
        [Required]
        [MaxLength(8)]
        public string SupplierId { get; set; }
        public bool SupplierIsSubcontractor { get; set; }
        public IEnumerable<SupplierInvoiceLine> SupplierInvoiceLines { get; set; }
    }
}