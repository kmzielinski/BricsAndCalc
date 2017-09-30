using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            if (number > 4)
            {
                Console.WriteLine("liczba jest większa od 4");
            }
            if (number < 4)
            {
                Console.WriteLine("liczba jest mniejsza od 4");
            }

        }
        static void CheckElseIF()
        {
            int number = 3;

            if (number > 4)
            {
                Console.WriteLine("liczba jest większa od 4");
            }
            else if (number < 4)
            {
                Console.WriteLine("liczba jest mniejsza od 4");
            }
        }

        static void simpleIF()
        {
            int number = 3;

            if (number > 4)
            {
                Console.WriteLine("liczba jest większa od 4");
            }
            else
            {
                Console.WriteLine("liczba jest mniejsza od 4");
            }
        }





    }   }
