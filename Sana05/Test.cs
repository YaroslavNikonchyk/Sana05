using Sana05;

class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("Статистика польоту №1");
        MyDate startDate = new MyDate(2023, 7, 12, 18, 00);
        MyDate finishDate = new MyDate(2023, 7, 12, 19, 30);
        Airplane firstAirpale = new Airplane("Zhytomir", "Ovrych", startDate, finishDate);
        Console.WriteLine($"Тривалiсть польоту в хвилинах: {firstAirpale.GetTotalTime()}");
        Console.WriteLine($"Чи прибуття в тей же день : {firstAirpale.IsArrivingToday()}");
        Console.WriteLine();
        Console.WriteLine("Статистика польоту №2");
        Airplane secondAirpale = new Airplane(firstAirpale);
        MyDate newFinishDate = new MyDate(2023, 7, 13, 17, 30);
        secondAirpale.FinishDate = newFinishDate;
        Console.WriteLine($"Тривалiсть польоту в хвилинах: {secondAirpale.GetTotalTime()}");
        Console.WriteLine($"Чи прибуття в тей же день : {secondAirpale.IsArrivingToday()}");

        Console.WriteLine();
        Console.WriteLine("Iнформацiя про продукт:");
        Currency currency = new Currency("Dolar", 35.51);
        Product product = new Product("Laptop", 1000, currency, 10, "Dell", 2);
        Console.WriteLine($"Цiна продукту в гривнях: {product.GetPriceInUAH()} UAH");
        Console.WriteLine($"Цiна всiх продуктiв в гривнях: {product.GetTotalPriceInUAH()} UAH");
        Console.WriteLine($"Загальна вага всiх продуктiв на складi данного типу:{product.GetTotalWeight()} kg");
    }
}
