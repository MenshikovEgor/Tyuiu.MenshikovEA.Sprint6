using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint6.Task5.V24.Lib;
using System.IO;

namespace Tyuiu.MenshikovEA.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V24.txt";

            CollectionAssert.AreEqual(new double[] { -17, 12, -14.32, 5, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 35, -9, 13.83, 12.76, 8.86, -1.49, -7 }, ds.LoadFromDataFile(path));


        }
    }
}
