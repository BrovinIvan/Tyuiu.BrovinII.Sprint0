using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BrovinII.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BrovinII.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Инорь";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Инорь", res);
        }
    }
}
