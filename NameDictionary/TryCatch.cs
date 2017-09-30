using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameDictionary
{
    public class TryCatch
    {
        public static void TryCatch2()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            try
            {
                dict.Add(1, 1);
                dict.Add(1, 2);

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
