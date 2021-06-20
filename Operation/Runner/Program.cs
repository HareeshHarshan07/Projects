using System;
using Runner.SolutionFactory.Enum;

namespace Runner
{
    internal class Program
    {
        private static OperationType _operationType;

        private static void Main(string[] args)
        {
            GetOperationInformation();
            var operation = SolutionFactory.SolutionFactory.GetOperation(_operationType);
            operation.Process();
            Console.ReadLine();
        }

        private static void GetOperationInformation()
        {
            DisplayItems();
            GetInputFromUser();
        }

        private static void GetInputFromUser()
        {
            Console.Write("\r\nSelect an option: ");
            int.TryParse(Console.ReadLine(), out var selectedOption);

            _operationType = (OperationType) selectedOption;
            if (!Enum.IsDefined(typeof(OperationType), _operationType) && !_operationType.ToString().Contains(","))
            {
                Console.WriteLine("Selected option is not valid. Press enter to retry...");
                Console.ReadLine();
                GetOperationInformation();
            }
        }

        private static void DisplayItems()
        {
            Console.Clear();
            Console.WriteLine("<<<<<<<<<<<<<<<<   Operations  >>>>>>>>>>>>>>>>>");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) SumOfMutiple");
            Console.WriteLine("2) SequenceAnalysis");
        }
    }
}