using Runner.SolutionFactory.Interfaces;
using SequenceAnalysis;

namespace Runner.SolutionFactory
{
    class SequenceAnalysis : IOperation
    {
        public void Process()
        {
            var sequenceAnalysis = new StingSequenceAnalysis();
            sequenceAnalysis.GetSortedUpperCaseString();
        }
    }
}
