using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //Calculate is the name of the delegate
    //Calculation is the parameter that represents the delegate in PrintResult()
    public class Calculator
    {
        double sum;
        public delegate double Calculate(double firstNumber, double secondNumber);
        public delegate void AssignSum(double firstNumber, double secondNumber);

        public double AddTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public double MultiplyTwoNumbers(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public void PrintSum(double firstNumber, double secondNumber)
        {
            sum = firstNumber + secondNumber;
        }
        public double PrintResult(double firstNumber, double secondNumber, Calculate Calculation)
        {
            return Calculation(firstNumber, secondNumber);
            //Console.WriteLine(result);
        }

        public string GetName()
        {
            Console.WriteLine("enter your name");
            var name = Console.ReadLine();
            return name;
        }
    }
}
