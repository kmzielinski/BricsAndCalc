using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Imiona = new Dictionary<string, string>();
            string imie;
            string plec;
            int index=0;
            do
            {
                index++;
                Console.WriteLine("podaj imie");
                imie = Console.ReadLine();
                if (imie[imie.Length - 1] == 'a')
                {
                    Console.WriteLine("kobieta");
                    Imiona.Add(imie, "kobieta");
                    if (!Imiona.Keys.Contains(imie))
                    {
                        Imiona.Add(imie, "kobieta");
                    }
                    else
                    {
                        Console.WriteLine("LOL");
                    }
                }
                else
                {
                    Console.WriteLine("facet");
                    Imiona.Add(imie, "facet");
                    
                    if (!Imiona.Keys.Contains(imie))
                    {
                        Imiona.Add(imie, "kobieta");
                    }
                    else
                    {
                        Console.WriteLine("trollo");
                    }
                }
              
            }
            while (index < 3);
        }

        
    }
}
