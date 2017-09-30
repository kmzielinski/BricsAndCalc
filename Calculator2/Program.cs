
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator2
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
        static IOptionChooser menu = new UserMenu("Dodawanie", "Odejmowanie", "Mnożenie", "Dzielenie", "Pierwiastek kwadratowy");
        static IOptionChooser repeatMenu = new UserMenu(new[] { "Tak", "Nie" });

        static void Main(string[] args)
        {
            int y = 2;
            do
            {
                Operation math = (Operation)menu.AskUser();
                double nr1 = 0;
                double nr2 = 0;
                double nr3 = 0;
                if (math != Operation.SquareRoot)
                {
                    Console.Write("Podaj pierwszą wartość: ");
                    nr1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj drugą wartość: ");
                    nr2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Podaj wartość do pierwiastkowania: ");
                    nr3 = Convert.ToInt32(Console.ReadLine());
                }

                switch (math)
                {
                    case Operation.Addition:
                        Console.WriteLine("Wynik: " + Add(nr1, nr2));
                        break;
                    case Operation.Subtraction:
                        Console.WriteLine("Wynik: " + Sub(nr1, nr2));
                        break;
                    case Operation.Multiplication:
                        Console.WriteLine("Wynik: " + Mul(nr1, nr2));
                        break;
                    case Operation.Division:
                        Console.WriteLine("Wynik: " + Div(nr1, nr2));
                        break;
                    case Operation.SquareRoot:
                        Console.WriteLine("Wynik: " + SqrR(nr3));
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego działania, wybierz poprawny nr");
                        break;

                }
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