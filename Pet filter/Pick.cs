using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
namespace Pet_filter
{
    class Pick
    {
        public static Stopwatch picktimer = new Stopwatch();
        public static void PickThread()
        {
            while (true)
            {
                try
                {

                    if (Globals.started && Globals.NearItems.Count > 0 && Globals.PetSpawned)
                    {

                       /* uint item = NextItem();
                        Globals.NearItems[item].Tries++;
                        PickItem(item);
                        picktimer.Restart();*/
                        uint[] aroundItems = new uint[Globals.NearItems.Count];
                        Globals.NearItems.CopyTo(aroundItems, 0);
                        for (int i = 0; i < aroundItems.Count(); i++)
                        {
                            if (aroundItems[i] != 0)
                            {
                                Thread pick = new Thread(PickThread2);
                                pick.Start(aroundItems[i]);
                                pick.Join();
                            }

                        }
                    }
                }
                catch { }
                System.Threading.Thread.Sleep(1);
            }
        }
        public static void PickThread2(object id)
        {
            uint objectID = (uint)id;
            while (Globals.NearItems.Contains(objectID) && Globals.started && Globals.PetSpawned)
            {
                if (picktimer.ElapsedMilliseconds > 1500 || !picktimer.IsRunning)
                {
                   // Globals.NearItems[objectID].Tries++;
                    PickItem(objectID);
                    picktimer.Reset();
                    picktimer.Start();
                }
                Thread.Sleep(1);
            }
        }
        public static void PickItem(uint objectID)
        {
            Packet p = new Packet(0x70C5);
            p.AddDWORD(Globals.Pet);
            p.AddBYTE(8);
            p.AddDWORD(objectID);
            Agent.SendToServer(p);
        }
        /*public static uint NextItem()
        {
            foreach (var item in Globals.NearItems)
            {
                if (item.Key != 0 && item.Value != null && item.Value.ObjectID != 0)
                    return item.Value.ObjectID;
            }
            return 0;
        }*/
    }
}
