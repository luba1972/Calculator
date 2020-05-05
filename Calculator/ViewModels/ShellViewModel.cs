using Calculator.Core.Calculators;
using Calculator.ViewModels.Bases;
using Calculator.ViewModels.Calculators;
using Calculator.ViewModels.Interfaces;
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

        private ICalculatorViewModel _selectedCalculatorViewModel;
        public ICalculatorViewModel SelectedCalculatorViewModel
        {
            get => _selectedCalculatorViewModel;
            set => SetProperty(ref _selectedCalculatorViewModel, value);
        }

        private bool _flyoutOpen;
        public bool FlyoutOpen
        {
            get => _flyoutOpen;
            set => SetProperty(ref _flyoutOpen, value);
        }

        public DelegateCommand OpenFlyoutCommand { get; set; }

        protected override void RegisterCommands()
        {
            OpenFlyoutCommand = new DelegateCommand(OpenFlyout);
        }

        private void OpenFlyout()
        {
            FlyoutOpen = true;
        }
    }
}
