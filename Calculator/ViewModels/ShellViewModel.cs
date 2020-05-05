using Calculator.App_Start;
using Calculator.Core.Calculators;
using Calculator.Core.Helpers;
using Calculator.Models;
using Calculator.ViewModels.Bases;
using Calculator.ViewModels.Calculators;
using Calculator.ViewModels.Interfaces;
using Calculator.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public string Title { get; } = "Cool Calculator";

        private IContainerHelper _containerHelper;
        public ShellViewModel(IContainerHelper containerHelper)
        {
            _containerHelper = containerHelper;
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
        public DelegateCommand<CalculatorType> CalculatorChangeCommand { get; set; }

        protected override void RegisterCommands()
        {
            OpenFlyoutCommand = new DelegateCommand(OpenFlyout);
            CalculatorChangeCommand = new DelegateCommand<CalculatorType>(CalculatorChanged);
        }

        private void CalculatorChanged(CalculatorType calculatorType)
        {
            var newCalculator = (ICalculatorViewModel)_containerHelper.Create(calculatorType.TypeName);
            SelectedCalculatorViewModel = newCalculator;
            FlyoutOpen = false;
        }

        private void OpenFlyout()
        {
            FlyoutOpen = true;
        }
    }
}
