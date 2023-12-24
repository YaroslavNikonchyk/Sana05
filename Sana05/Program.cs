using Sana05;

class Program
{
    static void Main(string[] args)
    {
        Currency currency = new Currency();
        MyDate startDate = new MyDate(2023, 12, 07);
        MyDate finishDate = new MyDate(2023, 12, 08);
        currency.SetName("Euro");
        currency.SetExRate(35.51);
        Console.WriteLine(currency.GetExRate());
        Airplane airplane = new Airplane("Varshava", "Kyiv", startDate, finishDate);
        Console.WriteLine(airplane.GetFinishCity());
    }    
}