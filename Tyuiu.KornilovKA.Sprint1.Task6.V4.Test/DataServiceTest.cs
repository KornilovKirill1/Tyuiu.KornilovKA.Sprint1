using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.KornilovKA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string value = "кожаный, песчаный, соломенный, торжественный";
            string wait = "соломенный, торжественный";

            string res = ds.CheckDoubleN(value);
            Assert.AreEqual(wait, res);
        }
    }
}
