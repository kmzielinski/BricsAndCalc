using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZajeciaCzwartek28
{
    class AutoChooser : IOptionChooser
    {
        private readonly int _value;

        public AutoChooser(int value)
        {
            _value = value;   
        }
        public int AskUser()
        {
            return _value;
        }
    }
}
