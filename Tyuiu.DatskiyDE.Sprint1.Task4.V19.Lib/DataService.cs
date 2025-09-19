using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DatskiyDE.Sprint1.Task4.V19.Lib
{
    public class DataService : ISprint1Task4V19
    {
        public double Calculate(double x, double y)
        {
            if (Math.Abs(x - 2) < 0.0001) 
            {
                
            }
            double numerator = x + y;
            double denominator = Math.Abs(x - 2);
            double result = numerator / denominator;
            return Math.Round(result, 3);           
        }                  
    }
}
