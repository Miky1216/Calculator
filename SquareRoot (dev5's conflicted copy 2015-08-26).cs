using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SquareRoot : UnaryOperationCalculation, IBasicUnaryMathOperation
    {
        public SquareRoot()
        {
            
        }
        public void CalculateUnary(double uniVal)
        {
            uniResult = Math.Sqrt(uniVal);
            Console.WriteLine("The square root of " + uniVal + " is " + uniResult);
            Console.ReadLine();
        }
    }
}
