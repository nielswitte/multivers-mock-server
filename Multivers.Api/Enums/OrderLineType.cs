namespace Multivers.Api.Enums
{
    public enum OrderLineType
    {
        //[AssociatedCode("A")]
        NonStockProduct = 0,      // Order line for product without stock
        //[AssociatedCode("B")]
        Amount = 1,               // Order line for fixed amount
        //[AssociatedCode("S")]
        ConstellationProduct = 2, // Order line for constellation product
        //[AssociatedCode("T")]
        Text = 3,                 // Order line containing only text
        //[AssociatedCode("V")]
        StockProduct = 4,         // Order line for product with stock
        //[AssociatedCode("U")]
        Hours = 5,                // Order line for hour type
        //[AssociatedCode("K")]
        OrderCosts = 6,           // Order line for order costs
    }
}
