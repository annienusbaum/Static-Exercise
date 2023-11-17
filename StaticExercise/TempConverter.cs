using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;

            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }

    }
}



//FahrenheitToCelsius
//CelsiusToFahrenheit
//fahrenheit
//celsius
//Both methods will have a single parameter of type double
//Complete the logic so that they properly convert the temperatures

//Call both methods in your Main() method

//tempconverter.cs
//using System;
//namespace StaticExercise
//{
//public static class TempConverter
//
//public static double FahrenheitToCelsius(double fahrenheit)
// {
//var result = (fahrenheit - 32) / 1.8;

//return result;
// }

//public static double CelsiusToFahrenheit(double celsius)
//{
// return (celsius * 9) / 5 + 32;
//}
// }
//}
