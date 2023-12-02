using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint6.Task1.V2.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task1.V2.Test
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
            

            CollectionAssert.AreEqual(res, new double[] {-15.60, -12.35, -10.72, -8.88, -2.16, 3.25, 6.64, 10.3, 16.17, 28.1, 38.41 });
        }
    }
}
