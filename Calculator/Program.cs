using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj a");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj b");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" podaj działąnie + - * / sqrt ");

            string value = Console.ReadLine();
            
                switch (value)
            {
                case "+":
                    Console.WriteLine(Sum(a, b));
                    break;
                case "-":
                    Console.WriteLine(Dedup(a, b));
                    break;
                case "*":
                    Console.WriteLine(Multiplication(a, b));
                    break;
                case "/":
                    Console.WriteLine(Division(a, b));
                    break;
                case "sqrt":
                    Console.WriteLine(Math.Sqrt(a));
                    break;

            }
         
        }

        static int Sum(int a, int b)
        {
                return a + b;
        }
        static int Dedup(int a, int b)
        {
            return a - b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }

        static double Sqrt(double a)
        {
            return Math.Sqrt(a);
        }

    }
}
