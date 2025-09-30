using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YarkovSD.Sprint1.Task2.V16.Lib;

namespace Tyuiu.YarkovSD.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.Cicle(x);
            Assert.AreEqual(4, res);
        }
    }
}
