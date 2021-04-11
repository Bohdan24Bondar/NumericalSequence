using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequenceTask
{
    class Viewer
    {
        public Viewer(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }

        public void ShowSequence(IEnumerable<long> sequence)
        {
            Console.WriteLine(Message);
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var number in sequence)
            {
                Console.Write(string.Format("{0}, ", number));
            }

            Console.SetCursorPosition((Console.CursorLeft - 2), Console.CursorTop);//todo
            Console.WriteLine(" ");
        }

        public void ShowMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Message);
        }
    }
}
