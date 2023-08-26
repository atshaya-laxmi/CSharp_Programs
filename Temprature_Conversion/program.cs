using System;
class FahrenheitToCelsius
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Fahrenheit Temperature:");
        double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
        double Celsius = FahrenheitCelsius(Fahrenheit);
        Console.WriteLine("The converted Celsius temperature is:" + Celsius);
        Console.ReadLine();
    }
    private static double FahrenheitCelsius(double Fahrenheit)
    {
        return (Fahrenheit - 32) * 5 / 9;
    }
}