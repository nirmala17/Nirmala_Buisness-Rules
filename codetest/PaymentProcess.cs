using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using codetest.Codetest.models;

namespace codetest
{
  
    public class Paymentprocess : IPayment
    {
       


        public Paymentprocess()
        {
           
        }


        Product p = new Product();
        Book b = new Book();
        MemberShip M = new MemberShip();
        Video v = new Video();
        Orders Or = new Orders();

        public bool ShipingService(string ordername)
        {
          
            // Payment for Physical product call Product class
            // Payment for Book call book class
            // payment for Membership/Upgrade call Membership class
            // payment for Video call Video class

         
            switch (Or.OrderName)
            {

                case "Physical":
                  return  p.GenaratePackingSlip(Or.OrderName);
                   

                case "book":
                   return b.GenaratePackingSlip(Or.OrderName);
                  
                case "Membership":
                  return  M.NewMemberShip();
                   
                case "UpgradeMembership":
                   return M.UpgradeMemberShip();
                   
                case "Video":
                  return  v.VideoType("videotype", Or.OrderName);
                   
                default:

                    return false;
            }
        

    }


    }

  
}