using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint1.Task3.V3.Lib;

namespace Tyuiu.ShadrinEA.Sprint1.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 9;
            double y = 7.5;
            double z = 5;

            var res = ds.ParallelepipedVolume(x,y,z);
            Assert.AreEqual(337.5, res);
        }
    }
}
