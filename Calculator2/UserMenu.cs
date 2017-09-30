using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    public class UserMenu : IOptionChooser
    {
        private readonly string[] _options;

        public UserMenu(params string[] options)
        {
            _options = options.ToArray();
        }

        public int AskUser()
        {
            PrintOptions();
            int choice = ReadChoice();
            return choice;
        }

        private int ReadChoice()
        {
            string input = Console.ReadLine();
            int result;
            while (!(int.TryParse(input, out result)) || result < 1 || result > _options.Length)
            {
                Console.WriteLine("Nieprawidłowe dane, podaj prawidłową liczbę");
                input = Console.ReadLine();
            }

            return result;
        }

        private void PrintOptions()
        {
            for (int i = 0; i < _options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {_options[i]}");
            }
        }
    }
}