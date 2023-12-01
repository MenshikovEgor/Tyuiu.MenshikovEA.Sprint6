using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint6.Task0.V30.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6;
            double wait = 18;
            Assert.AreEqual(wait, ds.Calculate(x));
        }
    }
}
