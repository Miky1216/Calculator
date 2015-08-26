using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {

        public Program()
        {

        }
        static void Main(string[] args)
        {
            CalculatorBody calculator = new CalculatorBody();

            
            calculator.AddNumbers();
            calculator.SubtractNumbers();
            calculator.MultiplyNumbers();
            calculator.DivideNumbers();
            calculator.ExponentNumbers();
            calculator.SquareRootNumbers();
            calculator.FactorialNumber();
            //calculator.UserInput();

        }
    }
}
