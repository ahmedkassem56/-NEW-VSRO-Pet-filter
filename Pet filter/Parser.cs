using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Pet_filter
{
    class Parser
    {
        public static void ParsePetSpawn(Packet packet)
        {
            uint id = packet.ReadDWORD();
            uint model = packet.ReadDWORD();
            if (TxtFiles.IsPet(model))
            {
                Globals.SendNotice("Grab Pet Spawned");
                Globals.Pet = id;
                Globals.PetSpawned = true;
            }
        }

        public static void ParseSingleSpawn(Packet packet)
        {
            uint model = packet.ReadDWORD();
            if (!Globals.items.Keys.Contains(ModelToStr(model))) return;
            ItemData item = Globals.items[ModelToStr(model)];
            byte has_owner = 0;
            uint owner = 0;
            uint Object = 0;
            if (item.Name == "Gold")
            {
                uint amount = packet.ReadDWORD();
                Object = packet.ReadDWORD();
                packet.ReadBYTE();
                packet.ReadBYTE();
                packet.ReadSINGLE();
                packet.ReadSINGLE();
                packet.ReadSINGLE();
                packet.ReadWORD();
                has_owner = packet.ReadBYTE();
                if (has_owner == 0x01)
                    owner = packet.ReadDWORD();
            }
            else if (item.PK2Name.StartsWith("ITEM_CH") || item.PK2Name.StartsWith("ITEM_EU"))
            {
                byte plus = packet.ReadBYTE();
                Object = packet.ReadDWORD();
                packet.ReadBYTE();
                packet.ReadBYTE();
                packet.ReadSINGLE();
                packet.ReadSINGLE();
                packet.ReadSINGLE();
                packet.ReadWORD();
                has_owner = packet.ReadBYTE();
                if (has_owner == 0x01)
                    owner = packet.ReadDWORD();
            }
            else
            {
                Object = packet.ReadDWORD();
                packet.ReadBYTE();
                packet.ReadBYTE();
                packet.ReadSINGLE();
                packet.ReadSINGLE();
                packet.ReadSINGLE();
                packet.ReadWORD();
                has_owner = packet.ReadBYTE();
                if (has_owner == 0x01)
                    owner = packet.ReadDWORD();
            }

            if (has_owner == 0x01 && (owner == Globals.AccountID || (int)owner == -1) && Globals.Main.pickeditems.Items.Contains(item.Name))
            {
                Globals.NearItems.Add(Object);
            }

            else if (has_owner == 0x00 && Globals.Main.pickeditems.Items.Contains(item.Name))
            {
                Globals.NearItems.Add(Object);
            }

            if (item.PK2Name.Contains("RARE"))
            {
                Globals.SendNotice("SoX Dropped!");
            }
        }
        public static void ParseSingleDispawn(Packet packet)
        {
            uint objectID = packet.ReadDWORD();
            if (Globals.NearItems.Contains(objectID))
            {
                Globals.NearItems.Remove(objectID);
            }
        }

        public static void ParsePetDeSpawn(Packet packet)
        {
            /*if (packet.ReadDWORD() == Globals.Pet)
            {
                Globals.SendNotice("Grab Pet Dispawned");
                Globals.Pet = 0;
                Globals.PetSpawned = false;
            }*/
        }
        public static void ParseCharData(Packet packet)
        {
            /*byte[] data = packet.GetBytes();
            StringBuilder strinq = new StringBuilder();
            for (int i = 0; i < data.Count(); i++)
            {
                strinq.Append(data[i].ToString("X2"));
            }
            File.WriteAllText("chardataaaaaaa.txt", strinq.ToString());*/
            int index;
            if ((index = IndexOf(packet.GetBytes(), Globals.UniqueID)) != -1)
            {
                packet.Position = index;
                uint char_id = packet.ReadDWORD();
                byte xsec = packet.ReadBYTE();
                byte ysec = packet.ReadBYTE();
                float xpos = packet.ReadSINGLE();
                float zpos = packet.ReadSINGLE();
                float ypos = packet.ReadSINGLE();
                packet.ReadBYTE(0x18);
                Globals.charName = packet.ReadSTRING("ascii");
                Globals.Main.Text = "[Myth] Petfilter - " + Globals.charName;
                #region Load items
                if (System.IO.File.Exists(Environment.CurrentDirectory + "\\configs\\" + Globals.charName + ".ini"))
                {
                    string[] items = System.IO.File.ReadAllLines(Environment.CurrentDirectory + "\\configs\\" + Globals.charName + ".ini");
                    Globals.Main.pickeditems.Items.Clear();
                    Globals.Main.pickeditems.Items.AddRange(items);
                }
                #endregion
                packet.ReadSTRING("ascii");
                packet.ReadBYTE(0x19);
                Globals.AccountID = packet.ReadDWORD();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error in char data");
            }
        }

        public static int IndexOf(byte[] arrayToSearchThrough, byte[] patternToFind)
        {
            if (patternToFind.Length > arrayToSearchThrough.Length)
                return -1;
            for (int i = 0; i < arrayToSearchThrough.Length - patternToFind.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < patternToFind.Length; j++)
                {
                    if (arrayToSearchThrough[i + j] != patternToFind[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
            }
            return -1;
        }

        public static string ModelToStr(uint model)
        {
            return Inverse(model.ToString("X8"));
        }

        public static string Inverse(string model)
        {
            string s1 = model.Substring(0, 2);
            string s2 = model.Substring(2, 2);
            string s3 = model.Substring(4, 2);
            string s4 = model.Substring(6, 2);
            model = s4 + s3 + s2 + s1;
            return model;
        }
    }
}
