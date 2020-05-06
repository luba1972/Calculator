using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class SuperScriptButton:Button
    {
        public SuperScriptButton(string label, string commandParameter, string SuperScriptLabel, int order) : base(label, commandParameter, order)
        {
            SuperScript = SuperScriptLabel;
        }

        public string SuperScript { get; }

        public static SuperScriptButton Create(string label, string commandParameter, string SuperScriptLabel, int order)
        {
            return new SuperScriptButton(label, commandParameter, SuperScriptLabel, order);
        }
    }
}
