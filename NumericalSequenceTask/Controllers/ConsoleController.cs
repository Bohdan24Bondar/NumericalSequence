using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NumericalSequenceLibrary;

namespace NumericalSequenceTask
{
    class ConsoleController
    {
        #region Private

        private ParametersValidator _checker;
        private Viewer _consoleViewer;
        private string _finishRange;
        private string _instruction;

        #endregion

        public ConsoleController(string finishRange, string instruction)
        {
            _checker = new ParametersValidator(finishRange);
            _consoleViewer = new Viewer(DefaultSettings.START_MESSAGE);
            _finishRange = finishRange;
            _instruction = instruction;
        }

        public void Run()
        {
            try
            {
                if (!_checker.IsNumber())
                {
                    _consoleViewer.ShowMessage(DefaultSettings.NO_NUMBER);
                    return;
                }

                if (!_checker.IsAboveThanZero())
                {
                    _consoleViewer.ShowMessage(DefaultSettings.LESS_THAN_ZERO);
                    return;
                }

                long lastNumber = long.Parse(_finishRange);
                NumericalSequence naturalNumbers = new NumericalSequence(lastNumber);
                IEnumerable<long> sequence = naturalNumbers.GetNumbers();
                _consoleViewer.ShowSequence(sequence);
            }
            catch (OverflowException ex)
            {
                _consoleViewer.ShowMessage(string.Format("{0}\n{1}", ex.Message, _instruction));
            }
        }
    }
}
