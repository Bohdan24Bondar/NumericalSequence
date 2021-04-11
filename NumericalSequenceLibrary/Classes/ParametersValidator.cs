using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequenceLibrary
{
    public class ParametersValidator
    {
        public ParametersValidator(string finishRange)
        {
            FinishRange = finishRange;
        }

        public string FinishRange { get; private set; }

        public bool IsNumber()
        {
            bool isNumber = long.TryParse(FinishRange, out _);

            return isNumber;
        }

        public bool IsAboveThanZero()
        {
            if (!IsNumber())
            {
                return false;
            }

            return long.Parse(FinishRange) > 0;
        }
    }
}
