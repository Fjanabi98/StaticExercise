using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            return (fTemp - 32) * (5.0 / 9.0);
        }

        public static double CelsiusToFahrenheit(double cTemp)
        {
            return (cTemp * 9 / 5) + 32;
        }
    }
}
