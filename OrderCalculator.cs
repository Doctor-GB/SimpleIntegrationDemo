public class OrderCalculator : ICalculator
{
    private const decimal DiscountThreshold = 1000;
    private const decimal DiscountPercent = 0.1m; // 10%


    public decimal CalculateTotal(List<decimal> prices)
    {
        decimal subtotal = prices.Sum();
        decimal discount = subtotal > DiscountThreshold ? subtotal * DiscountPercent : 0;
        decimal total = subtotal - discount;


        return total;
    }
}
