using System;
using Tyuiu.DatskiyDE.Sprint1.Task3.V14.Lib;

namespace Tyuiu.DatskiyDE.Sprint1.Task3.V14
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Организация ввода и вывода в консольных приложениях              *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая позволяет определить число,                *");
            Console.WriteLine("* полученное выписыванием в обратном порядке цифр заданного              *");
            Console.WriteLine("* трехзначного числа Ответ округлите до 3 знаков после запятой.          *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Число должно быть трехзначным                                          *");
            string s = Console.ReadLine();
            char[] str = s.ToCharArray(); 
            string a;
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            for (int i = str.Length - 1; i > -1; --i)
            {
                a = Convert.ToString(str[i]);
                Console.Write(a);
            }
            Console.ReadKey();
            

        }
    }
}
