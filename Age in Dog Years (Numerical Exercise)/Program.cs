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

            // Create a code that will calculate your age to dog years
            int dogYears = 7;

            Console.WriteLine("Please enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your age in dog years is {age * dogYears}");
            

        }
    }
}
