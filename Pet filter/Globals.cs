using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace Pet_filter
{
    class Globals
    {
        public static MainForm Main;
        public static Dictionary<string,ItemData> items = new Dictionary<string,ItemData>();
        public static List<string> pets = new List<string>();
        public static Thread startThread = new Thread(Pick.PickThread);
        public static string SRO_Path = "";
        public static string IP = "";
        public static string Locale = "";
        public static Process SRO_Client;
        #region GetIP method
        public static void LoadSettings()
        {
            try
            {
                IP = "login.mythonline.eu";
                Locale = "22";
                SRO_Path = settings.ReadValue("settings", "ClientPath");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("[IP Settings Error]:" + ex.Message);
            }
            
        }
        #endregion
        public static int ListenPort = 0;
        #region GetPort method
        public static void GetPort()
        {
            for (int i = 1600; i < 2000; i++)
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), i));
                    socket.Close();
                    ListenPort = i;
                    Main.port_label.Text = i + "";
                    break;
                }
                catch { i += 4; }
            }
        }
        #endregion
 
        #region LoginType  
        public static enumLoginType LoginType = enumLoginType.Client;
        public enum enumLoginType
        {
            Client,
            Clientless
        }
        #endregion
        public static List<uint> NearItems = new List<uint>();

        public static string charName = "";

        public static uint Pet;
        public static bool PetSpawned;
        public static uint AccountID;
        public static byte[] UniqueID;
        public static bool started = false;
        public static Packet char_data;
        public static INI settings = new INI(Environment.CurrentDirectory + @"\configs\settings.ini");
        public static void SendNotice(string msg)
        {
            Packet notice = new Packet(0x3026);
            notice.AddBYTE(7);
            notice.AddSTRING(msg, "ascii");
            Agent.SendToClient(notice);
        }


    }
}
