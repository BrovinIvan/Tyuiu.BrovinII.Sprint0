using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.BrovinII.Sprint0.Task4.V0.Lib;

namespace Tyuiu.BrovinII.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubstractValid()
        {
            Assert.AreEqual(10, DataService.Addition(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(10, DataService.Addition(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(10, DataService.Addition(9, 3));
        }
    }
}
