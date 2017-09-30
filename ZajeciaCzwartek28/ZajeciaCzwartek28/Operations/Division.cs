using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZajeciaCzwartek28.Operations
{
    class Division : IOperation
    {
        public double Calculate(double a, double b) => a / b;

        public string GetName() => "Dzielenie";

    }
}
