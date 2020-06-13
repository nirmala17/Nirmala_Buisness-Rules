using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest
{
    interface IPayment
    {
         bool ShipingService(string ordername);
    }
}
