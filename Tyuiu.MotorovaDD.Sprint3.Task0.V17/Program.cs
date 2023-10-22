using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint3.Task0.V17.Lib;
namespace Tyuiu.MotorovaDD.Sprint3.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Моторова.Д.Д | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл for                                                          *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Моторова Дана Дмитриевна | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* сумму ряда по формуле                                                   *");
            Console.WriteLine("*    10                                                                   *");
            Console.WriteLine("* S=      (-----------------)                                             *");
            Console.WriteLine("*    i=1  cos i * 1/2                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 4;
            int stopValue = 7;
            Console.WriteLine($" Стартовое значение цикла = {startValue}.\n Конечное значение цикла = {stopValue}.");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double p = ds.GetSumSeries(startValue, stopValue);
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}
