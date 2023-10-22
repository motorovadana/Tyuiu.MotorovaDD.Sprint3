using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MotorovaDD.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {

            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries += ((1 / Math.Sin(i)) + startValue);

            }
            return Math.Round(sumSeries, 4);
        }

      
        
    }
}
