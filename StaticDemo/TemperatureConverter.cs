using System;

namespace StaticDemo
{
    class TemperatureConverter
    {

        public double CelsiusToFharenheit(string tempCelsius)
        {
            double celsius = Double.Parse(tempCelsius);
            double fahrenheit = (celsius * 9/5) + 32
                return fahrenheit;

        }
        public double FahrenheitToCelsius(string tempFahrenheit)
        {
            double fahrenheit = Double.Parse(tempFahrenheit);
            double celsius = (fahrenheit - 32) * 5 / 9;
                return celsius;

        }

    }
}
