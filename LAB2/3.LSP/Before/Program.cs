using System;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov Substitution Principle");

            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };
 
            SumCalculator sum = new SumCalculator(numbers);
            Console.WriteLine($"1. The sum of all the numbers: {sum.Calculate()}");
 
            EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
            Console.WriteLine($"2. The sum of all the even numbers: {evenSum.Calculate()}");

            // SumCalculator evenSum2 = new EvenNumbersSumCalculator(numbers);
            // Console.WriteLine($"3. The wrong sum of all the even numbers: {evenSum2.Calculate()}");
        }
    }
}
