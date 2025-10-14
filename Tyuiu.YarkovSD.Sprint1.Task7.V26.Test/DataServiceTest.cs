using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YarkovSD.Sprint1.Task7.V26.Lib;

namespace Tyuiu.YarkovSD.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double z = 0;
            double y = -7;
            double wait = 155/102;
            var res = ds.Calculate(z, y);
            Assert.AreEqual(wait, res);
        }
    }
}