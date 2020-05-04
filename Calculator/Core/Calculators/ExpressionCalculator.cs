using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Calculators
{
    public class ExpressionCalculator : ICalculator
    {
        public double Calculate(string expression)
        {
            DataTable dataTable = new DataTable();
            var res = dataTable.Compute(expression,"");
            return Convert.ToDouble(res);
        }
    }
}
