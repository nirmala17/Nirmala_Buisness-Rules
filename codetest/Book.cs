using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codetest
{
    public class Book:IPackingSlip,ICommission
    {
        public Book()
        { }

       
        public void GenaratePackingSlip(string  ordername)
        {
            PayCommission();
            //after paying commision 
            // //generating duplicate packing slip based on order name  intimate for royal department

        }

        public void PayCommission()
        {
            //paying comission foragent
        }
    }
}