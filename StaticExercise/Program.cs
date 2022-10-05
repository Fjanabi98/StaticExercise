using Microsoft.VisualBasic;
using StaticExercise;
using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(61);
            Console.WriteLine($"Fahrenheit to Celsius: {celsius}");
        }


         static void Main(string[] args)
         {
            var fahrenheit = TempConverter.CelsiusToFahrenheit(16.11);
            Console.WriteLine($"Fahrenheit to Celsius: {fahrenheit}");
         }

    }
}


         