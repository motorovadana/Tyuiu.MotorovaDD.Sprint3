﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MotorovaDD.Sprint3.Task5.V22.Lib
{
    public class DataService : ISprint3Task5V22
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
           
            double sumSeries = 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries = sumSeries + ((Math.Pow(x, 3) * Math.Sin(k)) + 2);
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
