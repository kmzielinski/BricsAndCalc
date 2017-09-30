using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZajeciaCzwartek28.Operations;

namespace ZajeciaCzwartek28
{
    enum Operation
    {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
        SquareRoot = 5
    }

    class Program
    {

        static IOptionChooser repeatMenu = new UserMenu(new[] { "Tak", "Nie" });
        static IOperation[] operations = {new Addition(), new Subtraction(), new Multiplication(), new Division(), new Root() };

        static void Main(string[] args)
        {
            int y = 2;
            do
            {
                IOptionChooser menu = new UserMenu(operations.Select(o => o.GetName()).ToArray());
                int math = menu.AskUser();

                var operation = operations[math-1];
                double nr1 = 0;
                double nr2 = 0;
                
                Console.Write("Podaj pierwszą wartość: ");
                nr1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą wartość: ");
                nr2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(operation.Calculate(nr1, nr2));
                y = repeatMenu.AskUser();

                //Console.WriteLine("Czy chcesz wykonać kolejną operację: \n 1. Tak \n 2. Nie");
                //y = Convert.ToInt32(Console.ReadLine());
            } while (y == 1);
        }

        static double Add(double nr1, double nr2)
        {
            return nr1 + nr2;
        }

        static double Sub(double nr1, double nr2)
        {
            return nr1 - nr2;
        }

        static double Mul(double nr1, double nr2)
        {
            return nr1 * nr2;
        }

        static double Div(double nr1, double nr2)
        {
            return nr1 / nr2;
        }
        static double SqrR(double nr1)
        {
            return Math.Sqrt(nr1);
        }

    }
}