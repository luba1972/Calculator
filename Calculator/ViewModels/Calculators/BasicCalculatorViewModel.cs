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
    class BasicCalculatorViewModel:ViewModelBase
    {
        private readonly ICalculator _calculator;
        private bool hasCalculated = false;

        private string _expression = string.Empty;

        public string Expression
        {
            get => _expression;
            set => SetProperty(ref _expression, value);
        }

        public DelegateCommand<string> AddNumberCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }
        public BasicCalculatorViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }

        private void Calculate()
        {
            Expression = _calculator.Calculate(Expression).ToString("N2");
            hasCalculated = true;
        }

        private void Clear()
        {
            Expression = "";
        }

        private void AddNumber(string digit)
        {
            if (hasCalculated == true)
            {
                Expression = string.Empty;
                hasCalculated = false;
            }
            Expression += digit;

        }
    }

}
