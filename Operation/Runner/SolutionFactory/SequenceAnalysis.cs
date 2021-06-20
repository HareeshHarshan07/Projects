using Runner.SolutionFactory.Interfaces;
using SequenceAnalysis;

namespace Runner.SolutionFactory
{
    public class SequenceAnalysis : IOperation
    {
        public void Process()
        {
            var sequenceAnalysis = new StringSequenceAnalysis();
            sequenceAnalysis.ProcessStringSequence();
        }
    }
}