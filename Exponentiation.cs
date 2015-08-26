using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Exponentiation : BinaryOperationCalculation
    {
        public Exponentiation()
        {

        }
        public void Calculate(double num1, double num2)
        {
            result = Math.Pow(num1, num2);
            Console.WriteLine("The power of " + num1 + " to the " + num2 + " is " + result);
            Console.ReadLine();
        }
    }
}
