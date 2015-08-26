using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Factorial : UnaryOperationCalculation, IBasicUnaryMathOperation
    {
        public double counter;
        public Factorial()
        {
            counter = 0;
        }
        public void CalculateUnary(double uniVal)
        {
            counter = uniVal - 1;
            uniResult = uniVal;
            while (counter > 0)
            {
                uniResult *= counter;
                counter--;
            }
            Console.WriteLine("The factorial of " + uniVal + " is " + uniResult);
            Console.ReadLine();
        }
    }
}
