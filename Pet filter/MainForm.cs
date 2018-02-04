using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pet_filter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Globals.Main = this;
            Globals.LoadSettings();
            Globals.GetPort();
            TxtFiles.LoadFiles();
            new System.Threading.Thread(CountThread).Start();
            Proxy.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Globals.SRO_Client.Kill();
            }
            catch { }
            Environment.Exit(0);
        }

        private void addToPickedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (string item in alllist.SelectedItems)
            {
                if (!pickeditems.Items.Contains(item))
                    pickeditems.Items.Add(item);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            object[] items = new object[pickeditems.SelectedItems.Count];
            pickeditems.SelectedItems.CopyTo(items, 0);
            foreach (string item in items)
            {
                pickeditems.Items.Remove(item);
            }
        }
        public void SetFormTitle(string s)
        {
            this.Text += " - " + s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemData[] items = new ItemData[Globals.items.Values.Count];
            Globals.items.Values.CopyTo(items, 0);
            List<ItemData> checkedItems = new List<ItemData>();
            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i].Name == "Gold")
                {
                    if (gold.Checked)
                        checkedItems.Add(items[i]);
                }
                else if ((items[i].PK2Name.StartsWith("ITEM_EU") || items[i].PK2Name.StartsWith("ITEM_CH")) && !items[i].Name.Contains("[RARE]"))
                {
                    if (equip.Checked)
                        checkedItems.Add(items[i]);
                }
                else if (items[i].Name.Contains("[RARE]") && (items[i].PK2Name.StartsWith("ITEM_EU") || items[i].PK2Name.StartsWith("ITEM_CH")))
                {
                    if (equip_rare.Checked)
                        checkedItems.Add(items[i]);
                }
                else if (items[i].PK2Name.StartsWith("ITEM_ETC_ARCHEMY_MAGICTABLET") || items[i].PK2Name.StartsWith("ITEM_ETC_ARCHEMY_ATTRTABLET"))
                {
                    if (tablets.Checked)
                        checkedItems.Add(items[i]);
                }
                else if (items[i].PK2Name.StartsWith("ITEM_ETC_ARCHEMY_MAGICSTONE") || items[i].PK2Name.StartsWith("ITEM_ETC_ARCHEMY_ATTRSTONE"))
                {
                    if (stones.Checked)
                        checkedItems.Add(items[i]);
                }
                else if (items[i].PK2Name.StartsWith("ITEM_ETC_ARCHEMY_REINFORCE_RECIPE"))
                {
                    if (elixir.Checked)
                        checkedItems.Add(items[i]);
                }
                else if (items[i].PK2Name.StartsWith("ITEM_QSP") || items[i].PK2Name.StartsWith("ITEM_QNO"))
                {
                    if (quests.Checked)
                        checkedItems.Add(items[i]);
                }
                else
                {
                    if (other.Checked)
                        checkedItems.Add(items[i]);
                }
            }
            List<string> final = new List<string>();
            alllist.Items.Clear();
            if (lvl1.Text != "" && lvl2.Text != "")
            {
                int lvl_1 = int.Parse(lvl1.Text);
                int lvl_2 = int.Parse(lvl2.Text);

                for (int i = 0; i < checkedItems.Count(); i++)
                {
                    if (checkedItems[i].PK2Name.StartsWith("ITEM_EU") || checkedItems[i].PK2Name.StartsWith("ITEM_CH"))
                    {
                        if (checkedItems[i].Lvl >= lvl_1 && checkedItems[i].Lvl <= lvl_2)
                        {
                            final.Add(checkedItems[i].Name);
                        }
                        else
                        { }
                    }
                    else
                    {
                        final.Add(checkedItems[i].Name);
                    }
                }

                alllist.Items.AddRange((object[])final.ToArray());
            }
            else
            {
                for (int i = 0; i < checkedItems.Count(); i++)
                {
                    alllist.Items.Add(checkedItems[i].Name);
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globals.PetSpawned) return;
            Globals.started = true;
            button1.Enabled = false;
            button2.Enabled = true;
            if (!Globals.startThread.IsAlive)
                Globals.startThread.Start();
        }

        public static void CountThread()
        {
            while (true)
            {
                try
                {
                    Globals.Main.counter.Text = Globals.NearItems.Count.ToString();
                }
                catch { }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Globals.started = false;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (search_name.Text == "") return;
            ItemData[] items = Globals.items.Values.ToArray();
            List<string> Result = new List<string>();
            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i].Name.ToLower().Contains(search_name.Text.ToLower()))
                    Result.Add(items[i].Name);
            }
            alllist.Items.Clear();
            alllist.Items.AddRange(Result.ToArray());
        }

        private void abotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool was created by NoN_Stop for Myth SRO.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Globals.charName == "") return;
            List<string> save = new List<string>();
            for (int i = 0; i < pickeditems.Items.Count; i++)
            {
                save.Add(pickeditems.Items[i].ToString());
            }
            System.IO.File.WriteAllLines(Environment.CurrentDirectory + "\\configs\\" + Globals.charName + ".ini", save);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Globals.SRO_Path = openFileDialog.FileName;
                Globals.settings.WriteValue("settings", "ClientPath", Globals.SRO_Path);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Globals.SRO_Path != "" && System.IO.File.Exists(Globals.SRO_Path))
            {
                new Loader().StartClient(Globals.SRO_Path);
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Globals.SRO_Path = openFileDialog.FileName;
                    Globals.settings.WriteValue("settings", "ClientPath", Globals.SRO_Path);
                    new Loader().StartClient(Globals.SRO_Path);
                    button6.Enabled = false;
                    button7.Enabled = false;
                }
            }
        }
    }
}
