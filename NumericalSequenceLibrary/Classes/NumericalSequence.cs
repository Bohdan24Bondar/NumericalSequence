using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSequenceLibrary
{
    public class NumericalSequence
    {
        public NumericalSequence(long finishRange)
        {
            FinishRange = finishRange;
        }

        public long FinishRange { get; private set; }

        public IEnumerable<long> GetNumbers()
        {
            long currentNumber = 0;

            while ((currentNumber * currentNumber) < FinishRange)
            {
                yield return currentNumber++;
            }
        }
    }
}
