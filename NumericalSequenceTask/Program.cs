using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NumericalSequenceLibrary;

namespace NumericalSequenceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleController application = new ConsoleController("100", DefaultSettings.INSTRUCTION);
            application.Run();

            Console.ReadKey();
        }
    }
}
