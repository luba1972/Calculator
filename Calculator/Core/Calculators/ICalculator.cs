using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Calculators
{
    public interface ICalculator
    {
        double Calculate(string expression);
    }
}
