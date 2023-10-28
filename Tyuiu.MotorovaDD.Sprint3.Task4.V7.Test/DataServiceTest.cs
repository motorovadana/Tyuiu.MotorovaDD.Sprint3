using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint3.Task4.V7.Lib;

namespace Tyuiu.MotorovaDD.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
            public void ValidCalc()
            {
                DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
                Assert.AreEqual(1231.499, res);
            }
    }
}
