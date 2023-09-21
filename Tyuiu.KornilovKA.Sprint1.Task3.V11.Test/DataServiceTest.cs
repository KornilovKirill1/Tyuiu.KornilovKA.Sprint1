using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KornilovKA.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = -2;
            double x2 = 1;
            double x3 = 5;
            double y1 = 5;
            double y2 = 7;
            double y3 = -3;
            double wait = 19;
            var res = ds.TriangleArea(x1, x2, x3, y1, y2, y3);
            Assert.AreEqual(wait, res);
        }
    }
}
