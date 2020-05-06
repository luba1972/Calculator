using Calculator.ViewModels.Bases;
using Calculator.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;

namespace Calculator.ViewModels.Calculators
{
    class BasicCalculatorViewModel:CalculatorViewModelBase
    {

         public override string CalculatorType => "Basic";

        public override int Height { get; set; } = 400;
        public override int Width { get; set; } = 350;

        public BasicCalculatorViewModel(ICalculator calculator):base(calculator)
        {
        }


    }

}
