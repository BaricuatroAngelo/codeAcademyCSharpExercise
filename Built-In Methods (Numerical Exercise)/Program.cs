using System;

namespace LowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            // Use built-in methods and save to variable
            // Math.Floor converts decimal to nearest whole number
            // Math.Sqrt finds the Square Root of the whole number
            /* Since numberTwo is a negative, use Math.Abs to find absolute 
               value to make the number positive */
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            // Math.Min returns the smaller of two numbers
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

        }
    }
}
