using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        // Создаём экземпляры модулей
        ICalculator calculator = new OrderCalculator();
        ResultPrinter printer = new ResultPrinter();


        // Данные для расчёта
        List<decimal> itemPrices = new List<decimal> { 250, 300, 600, 150 };


        // Вызов метода расчёта из модуля OrderCalculator
        decimal total = calculator.CalculateTotal(itemPrices);


        // Передача результата в модуль ResultPrinter
        printer.PrintResult(total);
    }
}

