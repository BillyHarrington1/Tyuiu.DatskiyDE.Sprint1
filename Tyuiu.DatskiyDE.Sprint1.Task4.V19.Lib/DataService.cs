using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DatskiyDE.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public double Calculate(double x, double y)
        {
            var res = x + y / Math.Abs(x - 2);
            res = Math.Round(res, 3);           
            return res;
        }                  
    }
}
