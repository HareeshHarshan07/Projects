using Runner.SolutionFactory.Interfaces;
using SumOfMultiple;

namespace Runner.SolutionFactory
{
    public class SumOfMultiple : IOperation
    {
        public void Process()
        {
            var sumOfMultiple = new SumOfNaturalNumbers();
            sumOfMultiple.CalculateSumOfMultiple();
        }
    }
}