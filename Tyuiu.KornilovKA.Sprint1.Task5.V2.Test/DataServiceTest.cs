using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KornilovKA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double temp = 35;
            int wait = 2;

            int res = ds.FahrenheitToСelsius(temp);
            Assert.AreEqual(wait, res);
        }
    }
}
