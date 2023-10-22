using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint3.Task0.V17.Lib;

namespace Tyuiu.MotorovaDD.Sprint3.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NotImplementedException()
        {
            DataService ds = new DataService();
            int startvalue = 4;
            int stopvalue = 7;

            double res = ds.GetSumSeries(startvalue, stopvalue);
            double wait = 11.579;
            Assert.AreEqual(wait, res);


        }
    }
}
