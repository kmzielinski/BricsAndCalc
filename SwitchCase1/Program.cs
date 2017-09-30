using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 5;
            switch (value)
            {
                case 1:
                    Console.WriteLine("jest 1");
                    break;
                case 5:
                    Console.WriteLine("jest 5");
                    break;
                default:
                    Console.WriteLine("nie ma takiej opcji");
                    break;

            }
        }
    }
}
