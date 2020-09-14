using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                bool isDigit = false;
                double firstNumber = 0;
                double secondNumber = 0;

                while (!isDigit)
                {
                    
                    Console.WriteLine("Enter your first number: ");
                    string sRes = Console.ReadLine();
                    
                    isDigit = Double.TryParse(sRes, out firstNumber);

                    if (isDigit)
                        break;
                }
                isDigit = false;
                while (!isDigit)
                {

                    Console.WriteLine("Enter your second number: ");
                    string sRes = Console.ReadLine();

                    isDigit = Double.TryParse(sRes, out secondNumber);

                    if (isDigit)
                        break;
                }
 
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
