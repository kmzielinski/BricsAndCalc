using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaPierwszaAplikacja
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //Console.WriteLine("Mój wcale nie pierwszy program ;] ");
        //string str = "Ala ma kota";
        //string str2 = "Ala ma kota";

        //int nbr = 52;
        //int nbr2 = 36;

        //bool boolean = true;
        //Console.WriteLine(str);
        //Console.WriteLine(nbr);
        //Console.WriteLine(boolean);
        //int wynik = nbr + nbr2;
        //Console.WriteLine("wynik dodawania to");
        //Console.WriteLine(wynik);
        //string wynik2 = str + str2;
        //Console.WriteLine(wynik2);
        //string str = Console.ReadLine();
        //Console.WriteLine(str);


        //int bv = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(bv);
        //Console.WriteLine("podaj pierwsza liczbe");

        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("podaj drugą liczbe");

        //int number2 = Convert.ToInt32(Console.ReadLine());

        //int wynik = number1 * number2;
        //Console.WriteLine("wynik mnożenia to");

        //Console.WriteLine(wynik);

        //int[] array = new int[3];

        //array[0] = Convert.ToInt32(Console.ReadLine());
        //array[1] = Convert.ToInt32(Console.ReadLine());
        //array[2] = Convert.ToInt32(Console.ReadLine());
        //array[3] = Convert.ToInt32(Console.ReadLine());
        //array[4] = Convert.ToInt32(Console.ReadLine());


        //Console.WriteLine(array[0]);
        //Console.WriteLine(array[1]);
        //Console.WriteLine(array[2]);
        //Console.WriteLine(array[3]);
        //Console.WriteLine(array[4]);

        //int wynik = array[0] + array[1] + array[2] + array[3];
        //Console.WriteLine(wynik);

        //List<string> list = new List<string>();
        //list.Add("Ala");
        //list.Add("ma");
        //list.Add("psa");
        //Console.WriteLine(list[0]);
        //Console.WriteLine(list[1]);
        //Console.WriteLine(list[2]);
        //string str = list[0] + " " + list[1] +" " + list[2];
        //Console.WriteLine(str);


        //Dictionary<string, int> dict = new Dictionary<string, int>();
        //dict.Add("Ala",25);
        //dict.Add("ma",26);
        //dict.Add("psa",27);

        //Console.WriteLine(dict["ma"]);
        //bool b1 = dict.ContainsValue(26);
        //Console.WriteLine(b1);
        //int wynik = Sum(5, 5, 6 );
        //Console.WriteLine(Sum(1,2,3));

        //string ma = addS("Ala i ", "Mela" );
        //Console.WriteLine(ma);

        //}
        //static int Sum ( int nr1, int nr2, int nr3)

        //{
        //    Console.WriteLine(nr1);
        //    Console.WriteLine(nr2);
        //    Console.WriteLine(nr3);
        //    int wynik = nr1 + nr2 + nr3;


        //}

        //static string addS(string st1, string st2)
        //{
        //    string addS = st1 + st2;
        //    return addS;
        //}

        //static void Main(string[] args)
        //{

        //    int[] adam = new int[2] { 2, 4 };
        //    Console.WriteLine(Sum(adam));
            

        //}

        //static int Sum(int[] arr)
        //{
        //    return arr[1] + arr[0];
        //}

        static void Main(string[] args)
        {
            int[] adam = new int[2] { 2, 4 };
            List<int> Lista1 = new List<int>(35)
            {
                1,2,3
            };
            Console.WriteLine(Sum(adam, Lista1));


          


        }

        static int Sum(int[] arr, List<int> Lista1)
        {
            return arr[1] + Lista1[1];
        }




        //List<string> list = new List<string>();
        //list.Add("Ala");
        //list.Add("ma");
        //list.Add("psa");
        //Console.WriteLine(list[0]);
        //Console.WriteLine(list[1]);
        //Console.WriteLine(list[2]);
        //string str = list[0] + " " + list[1] +" " + list[2];
        //Console.WriteLine(str);








    }
}
