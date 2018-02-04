using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Pet_filter
{
    class TxtFiles
    {
        public static void LoadFiles()
        {
            #region parse_items
            string[] items = File.ReadAllLines(Environment.CurrentDirectory + @"\data\parse_items.txt");
            foreach (string item in items)
            {

                if (item.StartsWith("//")) continue;
                string[] s = item.Split(',');
                ItemData i = new ItemData();
                try
                {
                    i.ID = s[0];
                    i.PK2Name = s[1];
                    i.Name = s[2];
                    i.Lvl = int.Parse(s[3]);
                    Globals.items.Add(i.ID, i);
                }
                catch
                {

                    //System.Windows.Forms.MessageBox.Show("LoadFiles Error on item: "+ s[0]);
                }
            }
            #endregion

            #region pets
            string[] pets = File.ReadAllLines(Environment.CurrentDirectory + @"\data\pets.txt");
            for (int i = 0; i < pets.Count(); i++)
            {
                Globals.pets.Add(pets[i].Substring(0, 8));
            }
            #endregion
        }

        public static bool IsPet(uint model)
        {
            if (Globals.pets.Contains(Parser.ModelToStr(model)))
                return true;
            return false;
        }
    }
}
