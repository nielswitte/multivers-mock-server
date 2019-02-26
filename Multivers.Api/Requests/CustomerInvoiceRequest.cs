using Multivers.Api.Requests.ChildElements;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Requests
{
    public class CustomerInvoiceRequest : InvoiceRequest
    {
        [MaxLength(8)]
        public string AccountManagerId { get; set; }
        [MaxLength(8)]
        [Required]
        public string CustomerId { get; set; }
        public IEnumerable<CustomerInvoiceLine> CustomerInvoiceLines { get; set; }
        public bool DunForPayment { get; set; }

        [MaxLength(12)]
        public string MandateId { get; set; }

        // Can be null
        public string OrderId { get; set; }
    }
}
