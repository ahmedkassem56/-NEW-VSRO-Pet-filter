using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace Pet_filter
{
    class GatewayHandler
    {
        public static void RemotePacketHandler(Packet packet) // Gateway S -> C packet handler
        {
            switch (packet.Opcode)
            {
                case 0x5000:
                case 0x9000:
                    break;
                case 0xA102:
                    Login.LoginReply(packet);
                    break;
                default:
                    Gateway.SendToClient(packet);
                    break;
            }
        }
        public static void LocalPacketHandler(Packet packet) // Gateway C -> S packet handler
        {
            switch (packet.Opcode)
            {
                case 0x5000:
                case 0x9000:
                case 0x2001:
                    break;
                default:
                    Gateway.SendToServer(packet);
                    break;
            }
        }

    }
}
