//OperationClass factory
using Runner.SolutionFactory.Enum;

namespace Runner.SolutionFactory.Interfaces
{
    public interface IOperationFactory
    {
        IOperation GetOperation(OperationType operationType);
    }
}
