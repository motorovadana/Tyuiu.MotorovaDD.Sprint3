﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint3.Task5.V22.Lib;

namespace Tyuiu.MotorovaDD.Sprint3.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
            public void ValidGetSumSumSeries()
            {
                DataService ds = new DataService();

                int x = 2;
                int startValue1 = 1;
                int stopValue1 = 3;
                int startValue2 = 1;
                int stopValue2 = 12;
                double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
                double wait = 68.991;
                Assert.AreEqual(wait, res);
            }
    }
}
