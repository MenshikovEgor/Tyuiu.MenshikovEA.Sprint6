using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint6.Task4.V12.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] valuearray = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 6.49, -9.88, -12.26, -4.6, 0.52, 4, -0.75, 4.55, 12.23, 9.86, -6.5 };
            CollectionAssert.AreEqual(valuearray, wait);

        }
    }
}
