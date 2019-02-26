using Multivers.Api.Enums;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Requests.ChildElements
{
    public class OrderLine
    {
        [MaxLength(8)]
        public string AccountId { get; set; }
        public bool AutoCalculatePrice { get; set; }
        public bool AutoUnmatchToPurchase { get; set; }
        [MaxLength(8)]
        public string CostCentreId { get; set; }
        [MaxLength(8)]
        public string CostUnitId { get; set; }
        public string DeliveryDate { get; set; }
        [MaxLength(254)]
        public string Description { get; set; }
        [Range(0,1)]
        public decimal Discount { get; set; }
        [MaxLength(8)]
        public string DiscountAccountId { get; set; }
        public decimal OrderLineAmount { get; set; }
        public OrderLineType OrderLineType { get; set; }
        public bool PickListText { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [DataType(DataType.Currency)]
        public decimal PricePer { get; set; }
        [MaxLength(14)]
        public string ProductId { get; set; }
        public decimal QuantityBackorder { get; set; }
        public decimal QuantityDelivered { get; set; }
        public decimal QuantityOrdered { get; set; }
        public int QuantityScale { get; set; }
        public decimal QuantityToDeliver { get; set; }
        [MaxLength(6)]
        public string Unit { get; set; }
        public int VatCodeId { get; set; }
        public string WarehouseId { get; set; }        
    }
}