using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DatskiyDE.Sprint1.Task2.V13.Lib
{
    public class DataService : ISprint1Task2V13
    {
        public double ConvertMilesToKm(int value)
        {
            double result = value * 1.60934;
            return Math.Round(result, 3);
        }
    }
}