using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiple
{
    public class SumOfNaturalNumbers
    {

        public void CalculateSumOfMultiple()
        {
            Console.WriteLine("Please enter the limit to find sum of natural numbers that are multiple of 3 or 5 :");

            int input;
            Int32.TryParse(Console.ReadLine(), out input);
            if(input > 0)
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
