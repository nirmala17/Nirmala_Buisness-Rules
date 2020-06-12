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

        public void VideoType(string type, string ordername)
        {
            switch (type)
            {
                case "learningto Ski":
                    Addvideo();
                    break;
                default:
                    GenaratePackingSlip(ordername);
                    break;
            }
        }

        public void Addvideo(string ordername)
        {
            //Add free Add video
            GenaratePackingSlip(ordername);
        }

        public void GeneratePackingSlip(string ordername)
        {
            //generating packing slip based on order name

        }
    }
}