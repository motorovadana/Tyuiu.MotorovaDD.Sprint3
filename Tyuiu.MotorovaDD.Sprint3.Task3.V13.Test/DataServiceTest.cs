﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MotorovaDD.Sprint3.Task3.V13.Lib;

namespace Tyuiu.MotorovaDD.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "?sd!! 5gh. s!";

            int res = ds.ConvertStringToInt(value);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
