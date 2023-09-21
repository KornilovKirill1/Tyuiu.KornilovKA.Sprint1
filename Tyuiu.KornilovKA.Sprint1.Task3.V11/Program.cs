using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KornilovKA.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KornilovKA.Sprint1.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Корнилов К. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Корнилов Кирилл Андреевич | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Расчеты: Напишите программу, которая вычисляет площадь треугольника,    *");
            Console.WriteLine("* если известны координаты его углов.                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты углов: ");
            Console.Write("x1 -> ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1 -> ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2 -> ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y2 -> ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x3 -> ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y3 -> ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь треугольника: " + ds.TriangleArea(x1, x2, x3, y1, y2, y3) + " кв.см");

            Console.ReadKey();
        }
    }
}
