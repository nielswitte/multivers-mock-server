using System.Collections.Generic;

namespace Multivers.Api.Contracts
{
    public interface ICompanyDetailsInfo
    {
        string AdministrationDescription { get; set; }
        bool ApprovePurchaseOrders { get; set; }
        bool ApproveQuotations { get; set; }
        bool ApproveSalesOrders { get; set; }
        bool ApproveSupplierInvoices { get; set; }
        bool AutoNumberCustomerId { get; set; }
        bool AutoNumberSupplierId { get; set; }
        bool B2BMandateTypeApplicable { get; set; }
        bool CheckMinimumTotalHours { get; set; }
        string City { get; set; }
        bool CoreMandateTypeApplicable { get; set; }
        bool CostSpecPerOrderLine { get; set; }
        bool CreditSqueezeOnCreditNotes { get; set; }
        int CurrencyDecimals { get; set; }
        string CurrencyId { get; set; }
        bool CustomerDiscountIsOrderDiscount { get; set; }
        int CustomerIdLength { get; set; }
        bool CustomerIdPrecededByZeroes { get; set; }
        bool JournalizeCostPriceOnTimesheet { get; set; }
        string LanguageId { get; set; }
        string Legislation { get; set; }
        bool LowestPrice { get; set; }
        decimal MaximumPaymentDifference { get; set; }
        int NextSupplierId { get; set; }
        IEnumerable<string> PersonIdsOfCurrentUser { get; set; }
        bool PrintMandateFormApplicable { get; set; }
        bool RestrictedSubAdmins { get; set; }
        bool StockLevelBasedOnQuantityOrdered { get; set; }
        string StockValuation { get; set; }
        string Street { get; set; }
        string Street2 { get; set; }
        int SupplierIdLength { get; set; }
        bool SupplierIdPrecededByZeroes { get; set; }
        bool ValidateProductEanNumber { get; set; }
        bool VatEnabled { get; set; }
        bool VatDeclarationIsPeriod { get; set; }
        bool VatOnCreditSqueeze { get; set; }
        string ZipCode { get; set; }
        bool IctListing { get; set; }
        bool IsAuditionApplicable { get; set; }
        short? AuditionCategory { get; set; }
        bool SpecifyQuantity { get; set; }
        string VatNumber { get; set; }
        string CocRegistration { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        bool MatchSupplierInvoice { get; set; }
        bool BlockUnmatchedSupplierInvoice { get; set; }
        decimal GetCreditSqueezePercentage(string creditSqueezeId);
        decimal GetVatPercentage(int? vatCodeId);
    }
}