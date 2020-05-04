using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Calculators.Tests
{
    [TestClass()]
    public class ExpressionCalculatorTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            string expression = "2+2";
            ExpressionCalculator expressionCalculator = new ExpressionCalculator();
            var res = expressionCalculator.Calculate(expression);
            Assert.AreEqual(4,res);
        }
    }
}