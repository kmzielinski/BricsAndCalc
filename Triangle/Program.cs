using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());

                if (a + b <= c /*&& b + c <=a && a+c <=b */)
                {

                    Console.WriteLine("twoje liczby nie utworzą trójkąta podaj inne dane");
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                }
                else Console.WriteLine("trójkąt");
                
            }
            while (a + b >= c); 

        }
    } 
}
