using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            /* use this space to write your own short program! 
            Here's what you learned:

            DATA TYPES: int, double
            ARITHMETIC OPERATORS: +, -, *, /
            INCREMENT/DECREMENT: ++, --
            MODULO: % 
            BUILT-IN METHODS: Abs, Pow, Sqrt, Floor, Ceiling, Min, Max

            Good luck! */

            // Create a code that will calculate compount interest
            double rate = 0.04;
            int compound = 4;
            int year = 3;
            Console.WriteLine("Please input principal amount: ");
            double principalAmount = Convert.ToDouble(Console.ReadLine());
            double compountInterest = principalAmount * Math.Pow((1 + (rate / compound)), (compound * year));
            Console.WriteLine(compountInterest);

        }
    }
}
