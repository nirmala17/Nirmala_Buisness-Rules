using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codetest
{
    public class Video: IPackingSlip
    {
        public Video()
        { }

        public bool VideoType(string type, string ordername)
        {
            switch (type)
            {
                case "learningto Ski":
                    Addvideo(ordername);
                    break;
                default:
                    GenaratePackingSlip(ordername);
                    break;
            }
            return true;
        }

        public bool Addvideo(string ordername)
        {
            //Add free Add video

            Console.WriteLine("Free First Aid video Added Sucessfully");
            GenaratePackingSlip(ordername);
            return true;
        }

        public bool GenaratePackingSlip(string ordername)
        {
            //generating packing slip based on order name
            Console.WriteLine("Packing Slip genaerated Sucessfully");
            return true;

        }
    }
}