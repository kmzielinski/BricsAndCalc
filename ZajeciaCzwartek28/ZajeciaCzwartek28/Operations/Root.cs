using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZajeciaCzwartek28.Operations
{
    class Root : IOperation
    {
        public double Calculate(double a, double b)
        {
            return Math.Pow(b, 1/a);
        }

        public string GetName()
        {
            return "Pierwiastek";
        }
    }
}
