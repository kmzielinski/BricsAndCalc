using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZajeciaCzwartek28.Operations
{
    class Multiplication : IOperation
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }

        public string GetName()
        {
            return "Mnożenie";
        }
    }
}
