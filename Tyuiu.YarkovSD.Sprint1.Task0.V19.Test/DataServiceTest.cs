using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.YarkovSD.Sprint1.Task0.V19.Lib;

namespace Tyuiu.YarkovSD.Sprint1.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
