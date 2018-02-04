using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Pet_filter
{
    class Login
    {
        public static void LoginReply(Packet packet)
        {
            byte result = packet.ReadBYTE();
            if (result == 1)
            {
                uint id = packet.ReadDWORD();
                string ip = packet.ReadSTRING("ascii");
                ushort port = packet.ReadWORD();
                
                Agent.xfer_remote_ip = ip;
                Agent.xfer_remote_port = port;
                Packet new_packet = new Packet(0xA102, true);
                new_packet.AddBYTE(result);
                new_packet.AddDWORD(id);
                new_packet.AddSTRING("127.0.0.1", "ascii");
                new_packet.AddWORD((ushort)Globals.ListenPort);
                Thread sss = new Thread(Agent.AgentThread);
                sss.Start();
                Gateway.SendToClient(new_packet);
            }
            else
            { // error
                Gateway.SendToClient(packet);
            }
        }
    }
}
