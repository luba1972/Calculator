using Calculator.Core.Calculators;
using Calculator.ViewModels.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels.Calculators
{
    public class ScientificCalculatorViewModel: CalculatorViewModelBase
    {
        public override string CalculatorType => "Scientific";

        public ScientificCalculatorViewModel(ICalculator calculator) : base(calculator)
        {
        }
    }
}
