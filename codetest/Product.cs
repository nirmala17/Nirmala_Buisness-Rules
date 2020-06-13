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

        public bool GenaratePackingSlip(string ordername)
        {

            PayCommission();
            Console.WriteLine("Packing Slip generated Sucessfully");
            return true;

        }
        public bool  PayCommission()
        {
            Console.WriteLine("Commission is Payed Agent Sucessfully");
            return true;
        }
    }
}