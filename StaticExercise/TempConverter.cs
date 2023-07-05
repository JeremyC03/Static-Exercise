using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            //Celsius = (Fahrenheit - 32) * 5/9.
            double celsius = (fahrenheit - 32)* 5 / 9;
            return celsius;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            //Fahrenheit = (Celsius * 9/5) + 32
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
