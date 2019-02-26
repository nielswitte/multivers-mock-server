using System.Collections.Generic;
using Multivers.Api.Responses.ChildElements;

namespace Multivers.Api.Responses
{
    public class SupplierInvoiceInfoResponse : InvoiceInfoResponse
    {
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public IEnumerable<SupplierInvoiceLine> SupplierInvoiceLines { get; set; }
    }
}