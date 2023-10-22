using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MotorovaDD.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {

            double SumSerise = 0;
            do
            {
                SumSerise = SumSerise + Math.Pow((1 / Math.Pow((3 + value), startValue)), startValue);
                startValue++;
            } while (startValue <= stopValue);

            return (Math.Round(SumSerise, 3));
        }
    }
}
        