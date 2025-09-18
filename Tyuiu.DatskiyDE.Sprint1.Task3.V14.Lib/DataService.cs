using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DatskiyDE.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double number)
        {       
           
            if (number < 100 || number > 999 || number % 1 != 0)
            {
                throw new ArgumentException("Число должно быть целым трехзначным (от 100 до 999)");
            }

           
            int intNumber = (int)number;

            
            int digit1 = intNumber / 100;          
            int digit2 = (intNumber / 10) % 10;    
            int digit3 = intNumber % 10;           

         
            int reversedInt = digit3 * 100 + digit2 * 10 + digit1;

         
            return Math.Round((double)reversedInt, 3);
        }
    }
}
