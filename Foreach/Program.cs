using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liczby = new int[] {Console.Read()};
            
            foreach(int i in liczby)
            {
                Console.WriteLine("czary mary ");

                if (i % 2 == 0) { Console.WriteLine("Podana liczba jest parzysta."); }

                if (i % 2 != 0) { Console.WriteLine("Podana liczba nie jest parzysta."); }
                
            }
          
        }
    }
}
