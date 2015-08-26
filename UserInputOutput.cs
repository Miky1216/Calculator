using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class UserInputOutput : BinaryOperationCalculation
    {
        public string operators;
        public UserInputOutput()
        {
            operators = ("");
        }
        public void TakeUserInputCalcOutput()
        {
            try
            {
                Console.WriteLine("Enter first number");
                value1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an operator (+, -, *, /, ^)");
                operators = (Console.ReadLine());

                Console.WriteLine("Enter second number");
                value2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                switch (operators)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        result = value1 / value2;
                        break;
                    case "^":
                        result = Math.Pow(value1, value2);
                        break;
                    default:
                        result = 0;
                        break;
                }
            }
            Console.WriteLine("The result of " + value1 + operators + value2 + " is " + result);
            Console.ReadLine();
        }
    }
}
