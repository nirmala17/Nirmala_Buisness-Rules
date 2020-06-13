using System;
using codetest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codeunittest
{
    [TestClass]
    public class UnitTest1
    {
      

    
           [TestMethod]
        public void  PaackingSlipforProduct()
        {
            Paymentprocess p = new Paymentprocess();

            bool isSuccessed = p.ShipingService("phsyical");
                              
            //Assert
            Assert.IsTrue(isSuccessed);
        }


        [TestMethod]
        public void PaackingSlipforBook()
        {
            Paymentprocess p = new Paymentprocess();

            bool isSuccessed = p.ShipingService("Bo");

            //Assert
            Assert.IsTrue(isSuccessed);
        }
    }
}
