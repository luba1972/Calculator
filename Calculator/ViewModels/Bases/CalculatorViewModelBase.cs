using Calculator.Core.Calculators;
using Calculator.Models;
using Calculator.ViewModels.Interfaces;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels.Bases
{
    public abstract class CalculatorViewModelBase : ViewModelBase, ICalculatorViewModel
    {
        public abstract string CalculatorType { get; }

        public ICollection<Calculation> Calculations { get; protected set; }

        private readonly ICalculator _calculator;

        private bool HasCalculated = false;

        private string _expression = string.Empty;

        public string Expression
        {
            get => _expression;
            set => SetProperty(ref _expression, value);
        }

        public DelegateCommand<string> AddNumberCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }
        public abstract int Height { get; set; }
        public abstract int Width { get; set; }

        protected CalculatorViewModelBase(ICalculator calculator) 
        {
            _calculator = calculator;
        }

        public override void RegisterCollections()
        {
            Calculations = new ObservableCollection<Calculation>();
        }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }



        protected virtual void Clear()
        {
            Expression = "";
        }

        protected virtual void AddNumber(string digit)
        {
            if (HasCalculated == true)
            {
                Expression = string.Empty;
                HasCalculated = false;
            }
            Expression += digit;

        }

        protected virtual  void Calculate()
        {
            var value = _calculator.Calculate(Expression).ToString("N2");
            var calculation = new Calculation(Expression, value);
            Expression = value;
            HasCalculated = true;
            Calculations.Add(calculation);
        }
    }
}
