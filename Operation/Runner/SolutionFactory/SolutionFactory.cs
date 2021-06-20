
using Runner.SolutionFactory.Enum;
using Runner.SolutionFactory.Interfaces;
using System;
using System.Collections.Generic;

namespace Runner.SolutionFactory
{
    public class SolutionFactory : IOperationFactory
    {
        private Dictionary<OperationType, Func<IOperation>> m_SolutionTypeMapper;

        public SolutionFactory()
        {
            m_SolutionTypeMapper = new Dictionary<OperationType, Func<IOperation>>();
            m_SolutionTypeMapper.Add(OperationType.SumOfMultiple, () => { return new SumOfMultiple(); });
            m_SolutionTypeMapper.Add(OperationType.SequenceAnalysis, () => { return new SequenceAnalysis(); });
        }
        public IOperation GetOperation(OperationType operationType)
        {
            return m_SolutionTypeMapper[operationType]();
        }
    }
}
