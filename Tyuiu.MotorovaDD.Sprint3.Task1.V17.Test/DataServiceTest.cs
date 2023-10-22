using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint3.Task1.V17.Lib;
namespace Tyuiu.MotorovaDD.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NotImplementedException()
        {
            DataService ds = new DataService();
            int startValue = 2;
            int stopValue = 5;

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 3.597;

            Assert.AreEqual(wait, res);

        }


        
    }
}
