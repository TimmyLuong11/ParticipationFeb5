using System;

namespace ParticipationFeb5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double number = 7.777; //local variable 

            Console.WriteLine("Enter in 3 different number:");
            Console.WriteLine("Enter in the first number >>");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in the second number >>");
            double val2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter in the third number >>");
            double val3 = Convert.ToDouble(Console.ReadLine());

            double sumTotal = val1 + val2 + val3;
            Console.WriteLine("Sum Total: " + sumTotal);
            double multiTotal = sumTotal * number;
            Console.WriteLine("Multiply Total: " + multiTotal);
        }
    }
}
