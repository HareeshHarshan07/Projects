using System;
using System.Collections.Generic;
using Runner.SolutionFactory.Enum;
using Runner.SolutionFactory.Interfaces;

namespace Runner.SolutionFactory
{
    public static class SolutionFactory 
    {
        private static readonly Dictionary<OperationType, Func<IOperation>> SolutionTypeMapper;

        static SolutionFactory()
        {
            SolutionTypeMapper = new Dictionary<OperationType, Func<IOperation>>
            {
                {OperationType.SumOfMultiple, () => new SumOfMultiple()},
                {OperationType.SequenceAnalysis, () => new SequenceAnalysis()}
            };
        }

        public static IOperation GetOperation(OperationType operationType)
        {
            return SolutionTypeMapper[operationType]();
        }
    }
}