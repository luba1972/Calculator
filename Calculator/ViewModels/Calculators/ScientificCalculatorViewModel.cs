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

        public override int Height { get; set; } = 550;
        public override int Width { get; set; } = 350;

        private string _calculatedExpression;
        public string CalculatedExpression
        {
            get => _calculatedExpression;
            set => SetProperty(ref _calculatedExpression, value);
        }


        public ScientificCalculatorViewModel(ICalculator calculator) : base(calculator)
        {
        }

        protected override void Calculate()
        {
            CalculatedExpression = Expression;
            base.Calculate();
        }
    }
}
