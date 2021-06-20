using Runner.SolutionFactory.Interfaces;
using SumOfMultiple;
using System;

namespace Runner.SolutionFactory
{
    class SumOfMultiple : IOperation
    {
        public void Process()
        {
            var sumOfMultiple = new SumOfNaturalNumbers();
            sumOfMultiple.CalculateSumOfMultiple();
        }
    }
}
