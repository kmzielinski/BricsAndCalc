using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCounter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wprowadz liczbę");
            int number = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(number);

            if (number == 2)
            {
                if (list.Contains(2))
                {
                    Console.WriteLine(number + "dodałeś 2");
                }
                else
                {
                    list.Add(number);
                    Console.WriteLine();
                    foreach (int li in list)
                    {
                        Console.WriteLine(li);
                        Console.WriteLine("We add " + number);
                    }
                }
            Console.WriteLine("trollo");
            }
        }
    }
}
