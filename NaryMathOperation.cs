using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class NaryMathOperation : CalculatorBody
    {
        public string numbersToCalculate;
        public double resultOfDoubleConversion;
        public string resultOfStringConversion;
        public NaryMathOperation()
        {
            numbersToCalculate = "";
            resultOfDoubleConversion = 0;
            resultOfStringConversion = "";
        }
        public void CalculateNary()
        {
            Console.WriteLine("Enter numbers to calculate. Make sure to put operands in between numbers");
            numbersToCalculate = Console.ReadLine();
            
            string[] numbersArray = numbersToCalculate.Split();
            
            for (int counter = 0; counter < numbersArray.Length; counter++)
            {
                if (numbersArray[counter] == "*")
                {
                    double doubleValue1 = convertStringToDouble(numbersArray[counter - 1]);
                    double doubleValue2 = convertStringToDouble(numbersArray[counter + 1]);
                    double calc = product.Calculate(doubleValue1, doubleValue2);

                    string stringValue = convertDoubleToString(calc);
                }
                else if (numbersArray[counter] == "/")
                {
                    double doubleValue1 = convertStringToDouble(numbersArray[counter - 1]);
                    double doubleValue2 = convertStringToDouble(numbersArray[counter + 1]);
                    double calc = quotient.Calculate(doubleValue1, doubleValue2);

                    string stringValue = convertDoubleToString(calc);
                }
                else if (numbersArray[counter] == "+")
                {
                    double doubleValue1 = convertStringToDouble(numbersArray[counter - 1]);
                    double doubleValue2 = convertStringToDouble(numbersArray[counter + 1]);
                    double calc = sum.Calculate(doubleValue1, doubleValue2);

                    string stringValue = convertDoubleToString(calc);
                }
                else if (numbersArray[counter] == "-")
                {
                    double doubleValue1 = convertStringToDouble(numbersArray[counter - 1]);
                    double doubleValue2 = convertStringToDouble(numbersArray[counter + 1]);
                    double calc = difference.Calculate(doubleValue1, doubleValue2);

                    string stringValue = convertDoubleToString(calc);
                }
                else
                {
                    Console.WriteLine("Not a valid math operation");
                }
            }
        }
        public double convertStringToDouble(string stringInput)
        {
            resultOfDoubleConversion = Convert.ToDouble(stringInput);
            return resultOfDoubleConversion;
        }
        public string convertDoubleToString(double doubleInput)
        {
            resultOfStringConversion = Convert.ToString(doubleInput);
            return resultOfStringConversion;
        }
    }
}
