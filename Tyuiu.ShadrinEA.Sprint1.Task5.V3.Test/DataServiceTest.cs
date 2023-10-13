using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ShadrinEA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 234675;

            var res = ds.Calculate(k);
            Assert.AreEqual(6, res);
        }
    }
}
