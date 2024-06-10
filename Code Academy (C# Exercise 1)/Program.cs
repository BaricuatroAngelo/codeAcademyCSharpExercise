// See https://aka.ms/new-console-template for more information
using System;

namespace firstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool convertableBool = true;
            string strToChar = "Meme";
            int intToDouble = 34;
            double doubleToInt = 21.33;

            // Convert bool to string
            Console.WriteLine(convertableBool);
            Console.WriteLine(convertableBool.ToString());
            // Convert string to char
            Console.WriteLine(strToChar.ToCharArray());
            // Convert int to double -> Implicit Conversion
            double convertedInt = intToDouble;
            Console.WriteLine(convertedInt);
            // Convert double to int -> Explicit Conversion
            int convertedDouble = (int)doubleToInt;
            Console.WriteLine(convertedDouble);
        }
    }
}
