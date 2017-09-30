using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZajeciaCzwartek28
{
    interface IOperation
    {
        double Calculate(double a, double b);
        string GetName();
    }
}
