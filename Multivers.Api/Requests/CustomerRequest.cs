using Multivers.Api.Contracts;
using Multivers.Api.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Multivers.Api.Requests
{
    public class CustomerRequest : MultiversRequest
    {

        [MaxLength(8)]
        public string AccountManagerId { get; set; }
        public bool ApplyOrderSurcharge { get; set; }
        [MaxLength(15)]
        public string BusinessNumber { get; set; }
        public ChargeVatType ChargeVatTypeId { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(30)]
        public string CocCity { get; set; }
        public DateTime? CocDate { get; set; }
        [MaxLength(12)]
        public string CocRegistration { get; set; }
        [MaxLength(1)]
        public string CollectiveInvoiceSystemId { get; set; }
        public bool CombineInvoicesForElectronicBanking { get; set; }
        [MaxLength(3)]
        public string CountryId { get; set; }
        [DataTypeAttribute(DataType.Currency)]
        [Range(0, 999999999)]
        public decimal CreditLimit { get; set; }
        [Range(0, 3)]
        public char CreditSqueezeId { get; set; }
        [MaxLength(3)]
        public string CurrencyId { get; set; }
        public int CustomerGroupId { get; set; }
        [MaxLength(8)]
        public string CustomerId { get; set; }
        //The Customer state id. "A" = Active, "P" = Passive
        public char CustomerStateId { get; set; }
        public string Database { get; set; }
        [MaxLength(3)]
        public string DeliveryConditionId { get; set; }
        [Range(0,1)]
        public decimal DiscountPercentage { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }
        [MaxLength(25)]
        public string Fax { get; set; }
        public bool HasOutstandingBalance { get; set; }
        [MaxLength(65)]
        public string Homepage { get; set; }
        public int? IntrastatGoodsCodeId { get; set; }
        public short? IntrastatGoodsDistributionId { get; set; }
        public short? IntrastatStatSystemId { get; set; }
        public short? IntrastatTrafficRegionId { get; set; }
        [MaxLength(2)]
        public string IntrastatTransactionTypeId { get; set; }
        public bool InvoiceOnBehalfOfMembers { get; set; }
        // Aanmanen
        public bool IsDunForPayment { get; set; }
        public bool IsInFactoring { get; set; }
        public bool IsPaymentRefRequired { get; set; }
        public bool IsPurchaseOrganization { get; set; }
        [MaxLength(3)]
        public string LanguageId { get; set; }
        [MaxLength(25)]
        public string MobilePhone { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [Range(0, 99999999)]
        public int OrganizationId { get; set; }
        [MaxLength(3)]
        public string PaymentConditionId { get; set; }
        [MaxLength(55)]
        public string Person { get; set; }
        [MaxLength(3)]
        public string PricelistId { get; set; }
        public bool PrintPurchaseDetails { get; set; }
        [MaxLength(8)]
        public string PurchaseOrganizationId { get; set; }
        [MaxLength(20)]
        public string PurchaseOrganizationMemberId { get; set; }
        [MaxLength(8)]
        public string RevenueAccountId { get; set; }
        [MaxLength(8)]
        [Required]
        public string ShortName { get; set; }
        [MaxLength(40)]
        public string Street1 { get; set; }
        [MaxLength(40)]
        public string Street2 { get; set; }
        [MaxLength(8)]
        public string SupplierId { get; set; }
        [MaxLength(25)]
        public string Telephone { get; set; }
        public bool UsesUBLInvoice { get; set; }
        [MaxLength(25)]
        public string VatNumber { get; set; }
        public short? VatScenarioId { get; set; }
        public DateTime? VatVerificationDate { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
    }
}
