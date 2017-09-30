using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
         static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int index = 0;
            while (index < 6)
            {
                list.Add(index);
                index++;
                if (index == 3)
                {
                    break;
                }
            }
            foreach(int element in list)
            {
                Console.WriteLine(element);
            }

        }
    }
}
