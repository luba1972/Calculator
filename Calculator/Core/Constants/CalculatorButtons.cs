using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Constants
{
    public static class CalculatorButtons
    {
        public static Button[] ScientificCalculator => new Button[]
        {
            SuperScriptButton.Create("X","2","2",1),
            SuperScriptButton.Create("X","Y","y",2),
            CalculatorButton.Create("sin","sin",3),
            CalculatorButton.Create("cos","cos",4),
            CalculatorButton.Create("tan","tan",5),
            CalculatorButton.Create("√","sqrt",6),
            SuperScriptButton.Create("10","sn","x",7),
            CalculatorButton.Create("log","log",8),
            CalculatorButton.Create("Exp","Exp",9),
            CalculatorButton.Create("Mod","mod",10),
            CalculatorButton.Create("CE","CE",11),
            CalculatorButton.Create("Undo","Undo",12),
            CalculatorButton.Create("π","PI",13),
            CalculatorButton.Create("C","C",14),
            CalculatorButton.Create(".",".",15),
            CalculatorButton.Create("7","7",16),
            CalculatorButton.Create("8","8",17),
            CalculatorButton.Create("9","9",18),
            CalculatorButton.Create("*","*",19),
            CalculatorButton.Create("±","negate",20),
            CalculatorButton.Create("4","4",21),
            CalculatorButton.Create("5","5",22),
            CalculatorButton.Create("6","6",23),
            CalculatorButton.Create("(","(",24),
            CalculatorButton.Create(")",")",25),
            CalculatorButton.Create("1","1",26),
            CalculatorButton.Create("2","2",27),
            CalculatorButton.Create("3","3",28),
            CalculatorButton.Create("+","+",29),
            CalculatorButton.Create("-","-",30),
            CalculatorButton.Create("0","0",31)
       }.OrderBy(x=>x.Order).ToArray();
    }
}
