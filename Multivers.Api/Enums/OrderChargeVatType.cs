namespace Multivers.Api.Enums
{
    public enum OrderChargeVatType
    {
        Exclusive= 0, // VAT is not included in the prices 
        Inclusive = 1, // VAT is included in the prices 
        Subcontractor = 2, //VAT is not charged because customer is a subcontractor 
        NoVat = 3 //No VAT is charged 
    }
}
