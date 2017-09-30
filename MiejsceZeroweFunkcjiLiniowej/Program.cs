using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiejsceZeroweFunkcjiLiniowej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj a");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj a");

            int b = Convert.ToInt32(Console.ReadLine());
            int x = -b / a;
            
                if (a == b)
            {
                Console.WriteLine("a jest większe od b");
            }
        }
        
    }
}
