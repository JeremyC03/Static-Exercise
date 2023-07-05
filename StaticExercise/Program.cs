namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number to convert into celsius.");
            double fTemp = double.Parse(Console.ReadLine());
            TempConverter.FahrenheitToCelsius(fTemp);
            Console.WriteLine($"{fTemp} farenheit converts to {TempConverter.FahrenheitToCelsius(fTemp)} celsius");

            Console.WriteLine("Input a number to convert into fahrenheit.");
            double cTemp = double.Parse(Console.ReadLine());
            TempConverter.CelsiusToFahrenheit(cTemp);
            Console.WriteLine($"{cTemp} celsius converts to {TempConverter.CelsiusToFahrenheit(cTemp)} farenheit");
        }
    }
}
