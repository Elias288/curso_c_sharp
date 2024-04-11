internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cual es tu nombre?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hola, {name}, el {currentDate:d} a las {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
}