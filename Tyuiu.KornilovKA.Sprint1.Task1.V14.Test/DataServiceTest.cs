using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint1.Task1.V14.Lib;

namespace Tyuiu.KornilovKA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.0;
            double b = 2.0;
            double c = 2.0;

            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(2.5, res);
        }
    }
}
