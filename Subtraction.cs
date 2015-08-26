using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Subtraction : BinaryOperationCalculation, IBasicBinaryMathOperation
    {
        public Subtraction()
        {

        }
        public void Calculate(double num1, double num2)
        {
            result = num1 - num2;
            Console.WriteLine("The difference of " + num1 + " and " + num2 + " is " + result);
            Console.ReadLine();
        }
    }
}

