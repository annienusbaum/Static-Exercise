namespace StaticExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            double celcius = TempConverter.FahrenheitToCelsius(68);
            double fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");

        }
    }
}


//Now create a static class called TempConverter. The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!
//using System;



//program.cs
//namespace StaticExercise
//{
//class Program
//{
//static void Main(string[] args)
//{
//var celsius = TempConverter.FahrenheitToCelsius(68); // 20
//var fahrenheit = TempConverter.CelsiusToFahrenheit(20); //68

//Console.WriteLine("After conversion:");
//Console.WriteLine($"celcius {celcius}");
//Console.WriteLine($"fahrenheit {fahrenheit}");
//}
//}}

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