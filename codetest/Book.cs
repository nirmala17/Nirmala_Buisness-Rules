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

       
        public bool GenaratePackingSlip(string  ordername)
        {
            PayCommission();
            //after paying commision 
            // //generating  packing slip 

            
            string PackingslipNo="1234";// orginal packing slip no
            Console.WriteLine("Packing Slip generated Sucessfully");
            dupilicateGenaratePackingSlip(PackingslipNo);
            return true;
        }
        //
        public void dupilicateGenaratePackingSlip(string packingslipno)
        {

            Console.WriteLine("Duplicate  Packing Slip is generated and sent to royal department");
          

        }

        public bool PayCommission()
        {
            //paying comission foragent
            Console.WriteLine("Commission is Payed Agent Sucessfully");
            return true;
        }
    }
}