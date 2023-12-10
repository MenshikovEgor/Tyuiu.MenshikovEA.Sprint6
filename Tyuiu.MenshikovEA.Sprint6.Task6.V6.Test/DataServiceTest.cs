using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint6.Task6.V6.Lib;

namespace Tyuiu.MenshikovEA.Sprint6.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask6V6.txt";

            string res = ds.CollectTextFromFile(path);

            Assert.AreEqual("YebQ HbJcPW", res);
        }
    }
}
