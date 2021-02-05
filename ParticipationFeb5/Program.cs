using System;

namespace ParticipationFeb5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            double val1, val2, val3, sumTotal, multiTotal;
            const double number = 7.777; //local constant variable 

            //Output information to console to gather user input and taking the user input assiging to variables
            Console.WriteLine("Enter in 3 different number:");
            Console.WriteLine("Enter in the first number >>");
            val1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in the second number >>");
            val2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in the third number >>");
            val3 = Convert.ToDouble(Console.ReadLine());

            //Adding the user input and outputting to console
            sumTotal = val1 + val2 + val3;
            Console.WriteLine("\nSum Total: " + sumTotal.ToString("N3"));

            //Multiplying the user input with a const and outputting to console
            multiTotal = sumTotal * number;
            Console.WriteLine("Multiply Total: " + multiTotal.ToString("N3"));
        }
    }
}
