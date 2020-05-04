using Calculator.Core.Calculators;
using Calculator.ViewModels.Bases;
using Calculator.ViewModels.Calculators;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public string Title { get; } = "Cool Calculator";


        public ShellViewModel(ICalculator calculator)
        {
            var viewModel = new BasicCalculatorViewModel(calculator);
            SelectedCalculatorViewModel = viewModel;
        }

        private ViewModelBase _selectedCalculatorViewModel;
        public ViewModelBase SelectedCalculatorViewModel
        {
            get => _selectedCalculatorViewModel;
            set => SetProperty(ref _selectedCalculatorViewModel, value);
        }

    }
}
