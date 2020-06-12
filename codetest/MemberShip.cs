using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codetest
{
    public class MemberShip:IMembership
    {
       public MemberShip() { }

        public void NewMemberShip()
        {
            // for new membership
            //Activate memebership
            SendEmail();
        }

        public void UpgradeMemberShip()
        {
            //upgrade membership
            SendEmail();
        }

        public void SendEmail()
        {
            // send a email using smtp server
        }
    }
}