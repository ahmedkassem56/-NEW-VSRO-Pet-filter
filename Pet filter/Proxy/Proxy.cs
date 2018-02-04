using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Pet_filter
{
    class Proxy
    {
        public static void Start()
        {
            Thread ss = new Thread(Gateway.GatewayThread);
            ss.Start();
        }
    }
}
