using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures.Domain
{
    public class Rock: IFlyable
    {

        public string TakeOff()
        {
            return "Getting launched!";
        }
        public string Land() => "Hitting target";

        
    }
}
