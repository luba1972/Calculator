using Calculator.Models;
using Calculator.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels.Bases
{
    public abstract class CalculatorViewModel : ViewModelBase, ICalculatorViewModel
    {
        public abstract string CalculatorType { get; }

        public ICollection<Calculation> Calculations { get; }
    }
}
