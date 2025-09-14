using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DatskiyDE.Sprint1.Task0.V8.Lib
{
    public class DataService : ISprint1Task0V8
    {
        public double Calculate()
        {
            double a = 15;
            double b = 2;
            double c = 4;
            double D;

            D = Convert.ToDouble(a) / b / c;
            return a / b / c;
        }
    }
}