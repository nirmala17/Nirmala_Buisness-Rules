using System;
using codetest;
using codetest.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codetests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestPaymentProcess()
        {
            PaymentProcess PS = new PaymentProcess();
            string ordername = "Book";
            Ps.ShipingService(ordername);
        }
    }
}
