public class ResultPrinter
{
    public void PrintResult(decimal totalAmount)
    {
        Console.WriteLine($"Итоговая стоимость заказа: {totalAmount:C}");
    }
}
