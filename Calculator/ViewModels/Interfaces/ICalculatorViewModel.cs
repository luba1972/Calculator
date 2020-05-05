﻿using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels.Interfaces
{
    public interface ICalculatorViewModel
    {
        string CalculatorType { get; }
        ICollection<Calculation> Calculations { get; }

    }
}
