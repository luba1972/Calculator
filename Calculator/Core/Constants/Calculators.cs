﻿using Calculator.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Constants
{
    public static class Calculators
    {
        public static CalculatorType Basic => CalculatorType.Create("Basic", "BasicCalculatorViewModel");
        public static CalculatorType Scientific => CalculatorType.Create("Scientific", "ScientificCalculatorViewModel");

        public static CalculatorType[] CalculatorTypes = new[]
        {
            Basic,
            Scientific
        };

    }
}
