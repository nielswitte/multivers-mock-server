using Multivers.Api.Responses.ChildElements;
using System.Collections.Generic;

namespace Multivers.Api.Responses
{
    public class CustomerInvoiceInfoResponse : InvoiceInfoResponse
    {

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public IEnumerable<CustomerInvoiceLine> CustomerInvoiceLines { get; set; }
    }
}
