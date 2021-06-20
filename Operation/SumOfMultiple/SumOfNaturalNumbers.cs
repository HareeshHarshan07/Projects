using System;

namespace SumOfMultiple
{
    public class SumOfNaturalNumbers
    {
        public void CalculateSumOfMultiple()
        {
            Console.WriteLine("Please enter the limit to find sum of natural numbers that are multiple of 3 or 5 :");

            int.TryParse(Console.ReadLine(), out var input);
            if (input > 0)
            {
                var result = input.AsSumOfMultipleOfThreeOrFive();
                Console.WriteLine($"Sum of natural numbers that are multiple of 3 or 5 below {input} is : " + result);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}