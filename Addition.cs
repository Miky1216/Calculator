using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition : BinaryOperationCalculation, IBasicBinaryMathOperation
    {

        public Addition()
        {

        }
        public void Calculate(double num1, double num2)
        {
            result = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + result);
            Console.ReadLine();
        }
    }
}
