using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class CalculatorButton:Button
    {
        public CalculatorButton(string label, string commandParameter, int order):base(label,commandParameter,order)
        { 
        }

        public static CalculatorButton Create(string label, string commandParameter, int order)
        {
            return new CalculatorButton(label, commandParameter, order);
        }

    }
}
