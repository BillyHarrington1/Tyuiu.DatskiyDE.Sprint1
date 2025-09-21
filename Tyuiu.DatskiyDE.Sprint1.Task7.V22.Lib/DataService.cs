using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;
// z = (1 - tan x)^ctg x + cos(x - y)

namespace Tyuiu.DatskiyDE.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {

            double res = Math.Pow(1 - Math.Tan(x), 1 / Math.Tan(x)) + Math.Cos(x - y);          
            return Math.Round(res, 3);
        }
    }
}