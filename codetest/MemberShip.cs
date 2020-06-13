using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codetest
{
    public class MemberShip:IMembership,IEmail
    {
       public MemberShip() { }

        public bool NewMemberShip()
        {
            // for new membership
            //Activate memebership
            Console.WriteLine("User Membership is Activated");
            SendEmail();
            return true;
        }

        public bool UpgradeMemberShip()
        {
            //upgrade membership
            Console.WriteLine("User Membership is Upgraded");
            SendEmail();
            return true;
        }

        public bool SendEmail()
        {
            // send a email using smtp server
            Console.WriteLine("Mail Sent to  User  regarding  Activating/Upgrading Membership");
            return true;
        }
    }
}