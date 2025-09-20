using System;
using Tyuiu.DatskiyDE.Sprint1.Task6.V9.Lib;

namespace Tyuiu.DatskiyDE.Sprint1.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема:  Преобразование типов и класс Convert                            *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                         *");
            Console.WriteLine("* Напечатать все слова,                                                  *");
            Console.WriteLine("* перенеся их последнюю букву в начало.                                  *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string result = ds.MoveLetterToStart(inputText);
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}
