using Multivers.Api.Responses.ChildElements;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Responses
{
    public class CustomerInvoiceResponse : InvoiceResponse
    {
        [MaxLength(8)]
        public string AccountManagerId { get; set; }
        [MaxLength(55)]
        public string AccountManager { get; set; }
        [MaxLength(8)]
        [Required]
        public string CustomerId { get; set; }
        public IEnumerable<CustomerInvoiceLine> CustomerInvoiceLines { get; set; }
        public bool DunForPayment { get; set; }
        [MaxLength(12)]
        public string MandateId { get; set; }
        public int NumberOfReminders { get; set; }
        public string OrderId { get; set; }
    }
}
