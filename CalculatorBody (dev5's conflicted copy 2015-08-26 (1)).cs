using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorBody
    {
        public Addition sum;
        public Subtraction difference;
        public Multiplication product;
        public Division quotient;
        public Exponentiation exponent;
        public SquareRoot sqrt;
        public Factorial fact;
        public UserInputOutput input;
        public CalculatorBody()
        {
            this.sum = new Addition();
            this.difference = new Subtraction();
            this.product = new Multiplication();
            this.quotient = new Division();
            this.exponent = new Exponentiation();
            this.sqrt = new SquareRoot();
            this.fact = new Factorial();
            this.input = new UserInputOutput();
        }
        public void AddNumbers()
        {
            sum.Calculate(1,2);
        }
        public void SubtractNumbers()
        {
            difference.Calculate(5,2);
        }
        public void MultiplyNumbers()
        {
            product.Calculate(1,2);
        }
        public void DivideNumbers()
        {
            quotient.Calculate(2,4);
        }
        public void ExponentNumbers()
        {
            exponent.Calculate(2,2);
        }
        public void SquareRootNumbers()
        {
            sqrt.CalculateUnary(25);
        }
        public void FactorialNumber()
        {
            fact.CalculateUnary(5);
        }
        public void UserInput()
        {
            input.TakeUserInputCalcOutput();
        }
    }
}
