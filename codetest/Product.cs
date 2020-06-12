using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codetest
{
    public class Product : IPackingSlip,ICommission
    {
        public Product()
        {
        }

        public void GenaratePackingSlip(string ordername)
        {

            PayCommission();
         
        }
        public void PayCommission()
        {
        }
    }
}