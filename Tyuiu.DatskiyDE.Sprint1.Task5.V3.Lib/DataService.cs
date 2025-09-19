using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DatskiyDE.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {        
        public int Calculate(int k)
        {
            if (k < 100)
            {
                throw new ArgumentException("Число должно содержать 3 цифры");
            }

            int h = (k / 100) % 10;
            return h;
        }
    }
}
