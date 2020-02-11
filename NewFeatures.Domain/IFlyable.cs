using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatures.Domain
{
    public interface IFlyable
    {
        public string TakeOff(); 

        public string Fly() => "Flying";

        public string Land() => "Going down steadily";

    }
}
