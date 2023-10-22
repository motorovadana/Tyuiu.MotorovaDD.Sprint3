using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint3.Task2.V11.Lib;
namespace Tyuiu.MotorovaDD.Sprint3.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Моторова Д.Д | СМАРТб 23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 3                                                                  *");
            Console.WriteLine("*Тема: Оператор цикла do-while                                             *");
            Console.WriteLine("*Задание #2                                                                *");
            Console.WriteLine("*Вариант #11                                                               *");
            Console.WriteLine("*Выполнил: Моторова Дана Дмитриевна| СМАРТб 23-1                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму    *");
            Console.WriteLine("* ряда по формуле, при х=0,5                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;
            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadLine();
        }
    }
}
