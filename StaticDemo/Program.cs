using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string selection = string.Empty;
            while (selection != "q" && selection != "Q")
            {
                Console.WriteLine("Enter C)elsius to Fahrenheit of F)arenheit to Celsius or Q)quit");
                selection = Console.ReadLine();
                double farenheit = 0, celsius = 0;

                switch (selection)
                {
                    case "C":
                    case "c":

                        Console.WriteLine("Please enter the Celsius temperature:");
                        
                        //TemperatureConverter converter = new TemperatureConverter();
                        
                        farenheit = TemperatureConverter.CelsiusToFharenheit(Console.ReadLine());
                        Console.WriteLine($"Temperature in Fahrenheit: {farenheit}");
                        break;
                    case "F":
                    case "f":

                        Console.Write("Please enter the Farenheit temperature:");
                        //TemperatureConverter converter2 = new TemperatureConverter();

                        celsius = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                        Console.WriteLine($"Temperature in Celsius: {celsius}");
                        break;
                    case "q":
                    case "Q":
                        break;

                    default:
                        Console.WriteLine("Please try Again");
                        break;
                }

                
                
            }
        }
    }
}
