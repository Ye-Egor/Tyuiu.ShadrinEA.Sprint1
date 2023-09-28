using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShadrinEA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.ShadrinEA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "A good genius";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(value);
            string wait = " good genius";
            Assert.AreEqual(wait, res);

        }
    }
}
