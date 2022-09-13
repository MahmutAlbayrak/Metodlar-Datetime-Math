internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now); //günün tarihini getiriyor
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        // Datetime format
        Console.WriteLine(DateTime.Now.ToString("dd"));   //24
        Console.WriteLine(DateTime.Now.ToString("ddd"));  //Sat
        Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

        Console.WriteLine(DateTime.Now.ToString("MM"));     //04
        Console.WriteLine(DateTime.Now.ToString("MMM"));    //Apr
        Console.WriteLine(DateTime.Now.ToString("MMMM"));    //April

        Console.WriteLine(DateTime.Now.ToString("yy"));     //22
        Console.WriteLine(DateTime.Now.ToString("yyyy"));    //2022


        //Math Kutuphanesi
        Console.WriteLine("**** Math Kutuphanesi ****");
        Console.WriteLine(Math.Abs(-25)); //Mutlak alir.
        Console.WriteLine(Math.Sin(10)); //Sinus alir.
        Console.WriteLine(Math.Cos(10)); //Cosinus alir.
        Console.WriteLine(Math.Tan(10)); //Tanjant alir.

        Console.WriteLine(Math.Ceiling(22.3)); //Degerden buyuk en kucuk tam sayiyi getirir.
        Console.WriteLine(Math.Round(22.3)); //Yakinliga gore asagi veya yukari yuvarlar.
        Console.WriteLine(Math.Round(22.7)); //Yakinliga gore asagi veya yukari yuvarlar.
        Console.WriteLine(Math.Floor(22.7)); //Degerden kucuk en buyuk tam sayiyi getirir.

        Console.WriteLine(Math.Min(10,20)); //min degeri getirir
        Console.WriteLine(Math.Max(10,20)); //max degeri getirir

        Console.WriteLine(Math.Pow(3,4)); //Us alma islemi yapar 3 un 4 uncu kuvveti
        Console.WriteLine(Math.Sqrt(16)); //Karekok alir
        Console.WriteLine(Math.Log(10)); //Logaritma islemi e tabaninda
        Console.WriteLine(Math.Exp(3)); //e uzeri 3
        Console.WriteLine(Math.Log10(10)); //Logaritma islemi 10 tabaninda
        
    }
}