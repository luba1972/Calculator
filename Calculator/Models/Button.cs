using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public abstract class Button
    {
        protected Button(string label, string commandParameter, int order)
        {
            Label = label;
            CommandParameter = commandParameter;
            Order = order;
        }

        public string Label { get;  }
        public string CommandParameter { get; }
        public int Order { get; set; }
    }
}
