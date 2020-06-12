using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codetest
{
  
    public class Paymentprocess : IPayment
    {
       

        MemberShip objMem;

        public Paymentprocess()
        {
           
        }


        Product p = new Product();
        Book b = new Book();
        MemberShip M = new MemberShip();
        Video v = new Video();
        public void ShipingService(string ordername)
        {
          
            // Payment for Physical product call Product class
            // Payment for Book call book class
            // payment for Membership/Upgrade call Membership class
            // payment for Video call Video class

            if(ordername=="")
            {
                throw new ArgumentNullException();
                    
                    
            }
            switch (ordername)
            {

                case "Physical":
                    p.GenaratePackingSlip(ordername);
                    break;

                case "book":
                    b.GenaratePackingSlip(ordername);
                    break;
                case "Membership":
                    M.NewMemberShip();
                    break;
                case "UpgradeMembership":
                    M.UpgradeMemberShip();
                    break;
                case "Video":
                    v.VideoType("videotype",ordername);
                    break;
                default:
                  
                    break;
            }
        

    }


    }

  
}