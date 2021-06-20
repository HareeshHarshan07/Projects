using Runner.SolutionFactory;
using Runner.SolutionFactory.Enum;
using Runner.SolutionFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        private static IOperationFactory m_SolutionFactory = null;
        private static OperationType m_OperationType;
        static void Main(string[] args)
        {
            GetOperationInfomation();
            m_SolutionFactory = new SolutionFactory.SolutionFactory();
            var operation = m_SolutionFactory.GetOperation(m_OperationType);
            operation.Process();
            Console.ReadLine();
        }
        static void GetOperationInfomation()
        {
            DisplayItems();
            GetInputFromUser();
        }
        static void GetInputFromUser()
        {
            Console.Write("\r\nSelect an option: ");
            int selectedOption;
            Int32.TryParse(Console.ReadLine(), out selectedOption);

            m_OperationType = (OperationType) selectedOption;
            if (!Enum.IsDefined(typeof(OperationType), m_OperationType) && !m_OperationType.ToString().Contains(","))
            {
                Console.WriteLine($"Selected option is not valid. Press enter to retry...");
                Console.ReadLine();
                GetOperationInfomation();
            }
        }
        static void  DisplayItems()
        {
            Console.Clear();
            Console.WriteLine("<<<<<<<<<<<<<<<<   Operations  >>>>>>>>>>>>>>>>>");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) SumOfMutiple");
            Console.WriteLine("2) SequenceAnalysis");
        }

    }
}
