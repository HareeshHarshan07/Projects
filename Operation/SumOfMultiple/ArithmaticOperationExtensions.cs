using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiple
{
    public static class ArithmaticOperationExtensions
    {
        //Method to Find the sum of all natural numbers that are a multiple of 3 or 5 below the limit
        public static Int32 AsSumOfMultipleOfThreeOrFive(this Int32 limit)
        {
            limit--; // since we need below the limit
            return SumOfArithamaticProgression(limit, 3) + SumOfArithamaticProgression(limit, 5) - SumOfArithamaticProgression(limit, 15);
        }

        private static Int32 SumOfArithamaticProgression(Int32 limit, Int32 number)
        {
            limit /= number;
             
            // formula: n * (n + 1) * a/2
            return (limit) * (1 + limit) * number / 2; 
        }
    }
}
