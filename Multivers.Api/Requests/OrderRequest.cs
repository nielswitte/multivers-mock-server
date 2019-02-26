using Multivers.Api.Contracts;
using Multivers.Api.Enums;
using Multivers.Api.Requests.ChildElements;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Requests
{
    public class OrderRequest : MultiversRequest
    {
        [MaxLength(8)]
        public string AccountManagerId { get; set; }
        public bool ApplyOrderSurcharge { get; set; }
        // UPPERCASE
        [MaxLength(8)]        
        public string ApprovedBy { get; set; }
        public bool AutoUnmatchToPurchase { get; set; }
        public bool Blocked { get; set; }
        public OrderChargeVatType ChargeVatType { get; set; }
        [MaxLength(3)]
        public string CollectiveInvoiceSystemId { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonId { get; set; }
        public string CostCentreId { get; set; }
        public string CostUnitId { get; set; }
        [MaxLength(3)]
        public string CurrencyId { get; set; }
        [MaxLength(8)]
        [Required]
        public string CustomerId { get; set; }
        [MaxLength(254)]
        public string DeliveryAddress { get; set; }
        [MaxLength(3)]
        public string DeliveryConditionId { get; set; }
        // Between 0 and 1
        public decimal DiscountPercentage { get; set; }
        [MaxLength(254)]
        public string InvoiceAddress { get; set; }
        [MaxLength(12)]
        public string MandateId { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public string OrderId { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }
        public decimal OrderSurcharge { get; set; }
        public int OrderSurchargeVatCodeId { get; set; }
        public OrderType OrderType { get; set; }
        [Required]
        [MaxLength(3)]
        public string PaymentConditionId { get; set; }
        [MaxLength(8)]
        public string ProcessedById { get; set; }
        [MaxLength(60)]
        public string Reference { get; set; }
        [Required]
        public short VatScenarioId { get; set; }

    }
}
