﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint3.Task7.V30.Lib;

namespace Tyuiu.MotorovaDD.Sprint3.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
            public void ValidGetMassFunction()
            {
                DataService ds = new DataService();
                int startValue = -5;
                int stopValue = 5;
                int len = stopValue - startValue + 1;
                double[] valueWaitArray;
                valueWaitArray = new double[len];

                valueWaitArray[0] = -15.60;
                valueWaitArray[1] = -12.35;
                valueWaitArray[2] = -10.72;
                valueWaitArray[3] = -8.88;
                valueWaitArray[4] = -2.16;
                valueWaitArray[5] = 3.25;
                valueWaitArray[6] = 6.64;
                valueWaitArray[7] = 10.30;
                valueWaitArray[8] = 16.17;
                valueWaitArray[9] = 28.10;
                valueWaitArray[10] = 38.41;

                double[] res;
                res = new double[len];
                res = ds.GetMassFunction(startValue, stopValue);
                CollectionAssert.AreEqual(valueWaitArray, res);
            }
    }
}
