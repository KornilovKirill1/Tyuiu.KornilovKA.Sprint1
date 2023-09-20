using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint1.Task2.V28.Lib;

namespace Tyuiu.KornilovKA.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 20;
            var res = ds.ConvertCelsiusToKelvin(value);
            Assert.AreEqual(293, res);
        }
    }
}
