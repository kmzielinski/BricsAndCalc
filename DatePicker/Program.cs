using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ta metoda jest inputem i prosi o podanie roku urodzenia
            Console.WriteLine("podaj rok urodzenia");

            //Ta metoda jest inputem i prosi o podanie roku urodzenia

            int dataUrodzenia = Convert.ToInt32(Console.ReadLine());
            //Ta metoda sprawdz czy ktos wpisuje za duza liczbe

            if (dataUrodzenia > DateTime.Now.Year)
            {
                Console.WriteLine("idz pan z tad");
            }
            //Ta metoda sprawdza czy ktos nie jest pełnoletni
            else if (dataUrodzenia < DateTime.Now.Year && dataUrodzenia >= 2000)
            {

                {
                    Console.WriteLine("jestes urodzony po roku 2000 i nie jestes pełnoletni");
                }

            }
            else if (dataUrodzenia == 1999)
            {
                Console.WriteLine("podaj miesiąc urodzenia");
                int miesiacUrodzenia = Convert.ToInt32(Console.ReadLine());
                if (miesiacUrodzenia < 9)
                {
                    Console.WriteLine("jestes urodzony po roku 2000 i nie jestes pełnoletni");

                }
                else if (miesiacUrodzenia > 9 && miesiacUrodzenia >= 12)
                { Console.WriteLine("jestes pełnoletni i nie masz więcej niż 30 lat"); }
                //Ta metoda sprawdza czy ktos jest pełnoletni i ma mniej niz 30 lat
                else if (dataUrodzenia < 1999 && dataUrodzenia >= 1987)
                {
                    Console.WriteLine("jestes pełnoletni i nie masz więcej niż 30 lat");
                }
                //Ta metoda sprawdza czy ktos jest stary ;D

                else if (dataUrodzenia < 1987)
                {
                    Console.WriteLine("jestes za stary na piecie kubusia w pracy");
                }
            }

        }
    }
}
