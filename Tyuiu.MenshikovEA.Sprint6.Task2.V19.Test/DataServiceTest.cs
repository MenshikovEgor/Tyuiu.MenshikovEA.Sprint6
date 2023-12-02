using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint6.Task2.V19.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task2.V19.Test
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
            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(res, new double[] { -0.62, -16.79, -17.77, -6.3, -5.04, -6, -7.85, -2.43, 5.91, 4.33, -11.82 });
        }
    }
}
