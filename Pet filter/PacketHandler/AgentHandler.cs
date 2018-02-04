using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
namespace Pet_filter
{
    class AgentHandler
    {
        public static int groupspawn_count = 0;
        public static byte groupspawn_type = 0;
        public static void RemotePacketHandler(Packet packet)  // Agent server S -> C packet handler
        {
            try
            {
                switch (packet.Opcode)
                {
                    case 0x5000:
                    case 0x9000:
                        break;
                    case 0x3013:
                        Globals.char_data = new Packet(packet);
                        Agent.SendToClient(packet);
                        break;
                    case 0x3020:
                        byte[] bytes = packet.GetBytes();
                        Globals.UniqueID = new byte[] { bytes[0], bytes[1], bytes[2], bytes[3] };
                        Parser.ParseCharData(Globals.char_data);
                        Agent.SendToClient(packet);
                        break;
                    case 0x30C8:
                        Parser.ParsePetSpawn(packet);
                        Agent.SendToClient(packet);
                        break;
                    case 0x30C9:
                        Parser.ParsePetDeSpawn(packet);
                        Agent.SendToClient(packet);
                        break;
                    case 0x3019:
                        if (Globals.started)
                            Parser.ParseSingleSpawn(packet);
                        Agent.SendToClient(packet);
                        break;
                    case 0x3017:
                        groupspawn_type = packet.ReadBYTE();
                        groupspawn_count = (int)packet.ReadWORD();
                        Agent.SendToClient(packet);
                        break;
                    case 0x3015:
                        if (groupspawn_type == 0x02)
                        {
                            for (int i = 0; i < groupspawn_count; i++)
                            {
                                uint objectID = packet.ReadDWORD();
                                if (Globals.NearItems.Contains(objectID))
                                {
                                    Globals.NearItems.Remove(objectID);
                                }
                            }
                        }
                        Agent.SendToClient(packet);
                        break;
                    case 0x3016:
                        Parser.ParseSingleDispawn(packet);
                        Agent.SendToClient(packet);
                        break;
                    default:
                        Agent.SendToClient(packet);
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }


        public static void LocalPacketHandler(Packet packet) // Agent server C -> S handler
        {
            switch (packet.Opcode)
            {
                case 0x5000:
                case 0x9000:
                case 0x2001:
                    break;
                default:
                    Agent.SendToServer(packet);
                    break;
            }
        }


    }
}
