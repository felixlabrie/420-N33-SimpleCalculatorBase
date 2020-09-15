﻿using System;
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

                bool isOperation = false;
                string operation = " ";
                while (!isOperation)
                {

                    Console.WriteLine("Enter your desired operation out of the following: add or +, subtract or -, divide or /, multiply or * and power or ^ :");
                    operation = Console.ReadLine().ToLower();

                    isOperation = ((operation == "add") || (operation == "+") || (operation == "subtract") || (operation == "-")
                                || (operation == "multiply") || (operation == "*") || (operation == "divide") || (operation == "/")
                                || (operation == "power") || (operation == "^"));

                    if (isDigit)
                        break;
                }
                Console.WriteLine("Enter your desired operation out of the following: add or +, subtract or -, divide or /, multiply or * and power or ^ :"); 
                operation = Console.ReadLine().ToLower();
                

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
                StringBuilder sb = new StringBuilder();
                sb.Append("Your first number ");
                sb.Append(firstNumber);
                switch(operation)
                {
                    case "add":
                    case "+":
                        sb.Append(" plus ");
                        break;
                    case "subtact":
                    case "-":
                        sb.Append(" minus ");
                        break;
                    case "multiply":
                    case "*":
                        sb.Append(" times ");
                        break;
                    case "division":
                    case "/":
                        sb.Append(" divided by ");
                        break;
                    case "power":
                    case "^":
                        sb.Append(" to the power of ");
                        break;

                }
                sb.Append("your second number ");
                sb.Append(secondNumber);
                sb.Append(" equals to ");
                sb.Append(result);

                Console.WriteLine(sb.ToString());
                Console.ReadLine();
             

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
