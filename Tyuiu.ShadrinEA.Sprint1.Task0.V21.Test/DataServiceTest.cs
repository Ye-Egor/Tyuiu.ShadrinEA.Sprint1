using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint1.Task2.V21.Lib;

namespace Tyuiu.ShadrinEA.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 2;
            int y = 3;

            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(6, res);
        }
    }
}
