using System;
using codetest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codeunittest
{
    [TestClass]
    public class UnitTest1
    {
      

        [TestMethod]
        public void TestPaymentProcess()
        {

            
                Paymentprocess p = new Paymentprocess();
            try
            {
                p.ShipingService("");
            }

           catch(Exception ex)
            {
                return;
            }

            Assert.Fail();



        }


       

    }
}
