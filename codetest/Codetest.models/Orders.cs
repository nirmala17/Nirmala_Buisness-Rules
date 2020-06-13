using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codetest.Codetest.models
{
    public class Orders
    {
       
        public int OrderID { get; set; }
       
        public string OrderName { get; set; }
      
        public string OrderDescription { get; set; }

        public DateTime OrderDate { get; set; }
    }
}