using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MotorovaDD.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            
            double multseries = 1;
            {
                multseries = multseries + ((1 / Math.Cos(startValue)) + stopValue);
                startValue++;

            }
            return Math.Round(multseries, 5);
        }
    }
}
