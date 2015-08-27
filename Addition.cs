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
        public void Calculate(double value1, double value2)
        {
            result = value1 + value2;
            Console.WriteLine("The sum of " + value1 + " and " + value2 + " is " + result);
            
        }
    }
}
