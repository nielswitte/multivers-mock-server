namespace Multivers.Api.Enums
{
    public enum ExtVatType
    {
        Goods = 0, // mount concerns goods
        Services = 1, // mount concerns services
        Investments = 2, // mount concerns an investment
        NoVat = 3, // mount is not subject to VAT
        NotApplicable = 4, // Vat is not applicable
        Purchase = 5, // Purchase (A = 'Aankoop')  
        Sales = 6, //Sales (V = 'Verkoop')  
        Empty = 7 // Not filled
    }
}
