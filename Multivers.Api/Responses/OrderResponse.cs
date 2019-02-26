using Multivers.Api.Contracts;
using Multivers.Api.Enums;
using Multivers.Api.Responses.ChildElements;
using Multivers.Api.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Responses
{
    public class OrderResponse : MultiversResponse
    {
        public string AccountManager { get; set; }
        public string AccountManagerId { get; set; }
        public IEnumerable<BrokenRule> AllBrokenRulesCollection { get; set; }
        public bool ApplyOrderSurcharge { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public bool AutoUnmatchToPurchase { get; set; }
        public bool Blocked { get; set; }
        public IEnumerable<BrokenRule> BrokenRulesCollection { get; set; }
        public bool CanChange { get; set; }
        public OrderChargeVatType ChargeVatType { get; set; }
        public string CollectiveInvoiceSystemId { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonId { get; set; }
        public string CostCentreId { get; set; }
        public string CostUnitId { get; set; }
        public decimal CreditSqueezePerc { get; set; }
        public string CurrencyId { get; set; }
        public string CustomerCountryId { get; set; }
        public string CustomerId { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryConditionId { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string InvoiceAddress { get; set; }
        public bool IsDeleted{ get; set; }
        public bool IsNew { get; set; }
        public bool IsValid { get; set; }
        public string MainOrderId { get; set; }
        public string MandateId { get; set; }
        public bool MatchedToPurchase { get; set; }
        public string OrderDate { get; set; }
        public string OrderId { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }
        public OrderState OrderState { get; set; }
        public decimal OrderSurcharge { get; set; }
        public int OrderSurchargeVatCodeId { get; set; }
        public OrderType OrderType { get; set; }
        public string PaymentConditionId { get; set; }
        public string ProcessedBy { get; set; }
        public string ProcessedById { get; set; }
        public string ProjectId { get; set; }
        public string Reference { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalCreditSqueezeAmount { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalDiscountAmount { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalGoodsAmount { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalOrderAmount { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalVatAmount { get; set; }
        public int VatScenarioId { get; set; }
    }
}
