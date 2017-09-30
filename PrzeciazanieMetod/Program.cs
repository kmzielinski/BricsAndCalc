using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            int two = 4;
            int three = 4;
            Double one = 2.3;
            Double four = 4.1;

            Sum(two, three);
            Sum(one, four);
            Console.WriteLine(Sum(two, three));
            Console.WriteLine(Sum(two, four));
        }


        static int Sum(int two, int three)
        {
            return two + three;
        }

        static Double Sum(Double one, Double four)
        {
            return one + four;
        }

    }
}
