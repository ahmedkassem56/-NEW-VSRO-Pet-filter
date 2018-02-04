namespace Pet_filter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.search_name = new System.Windows.Forms.TextBox();
            this.equip_rare = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvl1 = new System.Windows.Forms.TextBox();
            this.lvl2 = new System.Windows.Forms.TextBox();
            this.quests = new System.Windows.Forms.CheckBox();
            this.elixir = new System.Windows.Forms.CheckBox();
            this.other = new System.Windows.Forms.CheckBox();
            this.stones = new System.Windows.Forms.CheckBox();
            this.tablets = new System.Windows.Forms.CheckBox();
            this.gold = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.equip = new System.Windows.Forms.CheckBox();
            this.alllist = new System.Windows.Forms.ListBox();
            this.alllistmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToPickedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pickeditems = new System.Windows.Forms.ListBox();
            this.pickeditemsmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.alllistmenu.SuspendLayout();
            this.pickeditemsmenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listening on port:";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(583, 424);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(0, 13);
            this.port_label.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.equip_rare);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lvl1);
            this.groupBox1.Controls.Add(this.lvl2);
            this.groupBox1.Controls.Add(this.quests);
            this.groupBox1.Controls.Add(this.elixir);
            this.groupBox1.Controls.Add(this.other);
            this.groupBox1.Controls.Add(this.stones);
            this.groupBox1.Controls.Add(this.tablets);
            this.groupBox1.Controls.Add(this.gold);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.equip);
            this.groupBox1.Controls.Add(this.alllist);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 405);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Items";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.search_name);
            this.groupBox3.Location = new System.Drawing.Point(7, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 45);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item search";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // search_name
            // 
            this.search_name.Location = new System.Drawing.Point(6, 16);
            this.search_name.Name = "search_name";
            this.search_name.Size = new System.Drawing.Size(158, 20);
            this.search_name.TabIndex = 20;
            // 
            // equip_rare
            // 
            this.equip_rare.AutoSize = true;
            this.equip_rare.Location = new System.Drawing.Point(117, 38);
            this.equip_rare.Name = "equip_rare";
            this.equip_rare.Size = new System.Drawing.Size(120, 17);
            this.equip_rare.TabIndex = 18;
            this.equip_rare.Text = "Equipments [RARE]";
            this.equip_rare.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Level range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "~";
            // 
            // lvl1
            // 
            this.lvl1.Location = new System.Drawing.Point(258, 51);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(34, 20);
            this.lvl1.TabIndex = 15;
            // 
            // lvl2
            // 
            this.lvl2.Location = new System.Drawing.Point(318, 50);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(34, 20);
            this.lvl2.TabIndex = 14;
            // 
            // quests
            // 
            this.quests.AutoSize = true;
            this.quests.Location = new System.Drawing.Point(117, 83);
            this.quests.Name = "quests";
            this.quests.Size = new System.Drawing.Size(59, 17);
            this.quests.TabIndex = 12;
            this.quests.Text = "Quests";
            this.quests.UseVisualStyleBackColor = true;
            // 
            // elixir
            // 
            this.elixir.AutoSize = true;
            this.elixir.Location = new System.Drawing.Point(4, 38);
            this.elixir.Name = "elixir";
            this.elixir.Size = new System.Drawing.Size(47, 17);
            this.elixir.TabIndex = 11;
            this.elixir.Text = "Elixir";
            this.elixir.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(4, 83);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(57, 17);
            this.other.TabIndex = 10;
            this.other.Text = "Others";
            this.other.UseVisualStyleBackColor = true;
            // 
            // stones
            // 
            this.stones.AutoSize = true;
            this.stones.Location = new System.Drawing.Point(117, 60);
            this.stones.Name = "stones";
            this.stones.Size = new System.Drawing.Size(105, 17);
            this.stones.TabIndex = 9;
            this.stones.Text = "Alchemic Stones";
            this.stones.UseVisualStyleBackColor = true;
            // 
            // tablets
            // 
            this.tablets.AutoSize = true;
            this.tablets.Location = new System.Drawing.Point(4, 61);
            this.tablets.Name = "tablets";
            this.tablets.Size = new System.Drawing.Size(107, 17);
            this.tablets.TabIndex = 8;
            this.tablets.Text = "Alchemic Tablets";
            this.tablets.UseVisualStyleBackColor = true;
            // 
            // gold
            // 
            this.gold.AutoSize = true;
            this.gold.Location = new System.Drawing.Point(4, 19);
            this.gold.Name = "gold";
            this.gold.Size = new System.Drawing.Size(48, 17);
            this.gold.TabIndex = 7;
            this.gold.Text = "Gold";
            this.gold.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // equip
            // 
            this.equip.AutoSize = true;
            this.equip.Location = new System.Drawing.Point(117, 19);
            this.equip.Name = "equip";
            this.equip.Size = new System.Drawing.Size(81, 17);
            this.equip.TabIndex = 5;
            this.equip.Text = "Equipments";
            this.equip.UseVisualStyleBackColor = true;
            // 
            // alllist
            // 
            this.alllist.ContextMenuStrip = this.alllistmenu;
            this.alllist.FormattingEnabled = true;
            this.alllist.Location = new System.Drawing.Point(7, 157);
            this.alllist.Name = "alllist";
            this.alllist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.alllist.Size = new System.Drawing.Size(346, 238);
            this.alllist.TabIndex = 4;
            // 
            // alllistmenu
            // 
            this.alllistmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToPickedListToolStripMenuItem});
            this.alllistmenu.Name = "alllistmenu";
            this.alllistmenu.Size = new System.Drawing.Size(170, 26);
            // 
            // addToPickedListToolStripMenuItem
            // 
            this.addToPickedListToolStripMenuItem.Name = "addToPickedListToolStripMenuItem";
            this.addToPickedListToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addToPickedListToolStripMenuItem.Text = "Add to Picked List";
            this.addToPickedListToolStripMenuItem.Click += new System.EventHandler(this.addToPickedListToolStripMenuItem_Click);
            // 
            // pickeditems
            // 
            this.pickeditems.ContextMenuStrip = this.pickeditemsmenu;
            this.pickeditems.FormattingEnabled = true;
            this.pickeditems.Location = new System.Drawing.Point(6, 24);
            this.pickeditems.Name = "pickeditems";
            this.pickeditems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.pickeditems.Size = new System.Drawing.Size(225, 277);
            this.pickeditems.TabIndex = 5;
            // 
            // pickeditemsmenu
            // 
            this.pickeditemsmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.pickeditemsmenu.Name = "alllistmenu";
            this.pickeditemsmenu.Size = new System.Drawing.Size(114, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem1.Text = "Remove";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pickeditems);
            this.groupBox2.Location = new System.Drawing.Point(385, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 304);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picked Items";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abotToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abotToolStripMenuItem
            // 
            this.abotToolStripMenuItem.Name = "abotToolStripMenuItem";
            this.abotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abotToolStripMenuItem.Text = "About";
            this.abotToolStripMenuItem.Click += new System.EventHandler(this.abotToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(541, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(466, 392);
            this.counter.Name = "counter";
            this.counter.ReadOnly = true;
            this.counter.Size = new System.Drawing.Size(39, 20);
            this.counter.TabIndex = 24;
            this.counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Items to pick:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(385, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Start Client";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(460, 337);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(18, 23);
            this.button7.TabIndex = 27;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "MythClient.exe";
            this.openFileDialog.Filter = "Myth SRO Client|MythClient.exe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 446);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.port_label);
            this.Name = "MainForm";
            this.Text = "[Myth] Petfilter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.alllistmenu.ResumeLayout(false);
            this.pickeditemsmenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label port_label;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox alllist;
        public System.Windows.Forms.ListBox pickeditems;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ContextMenuStrip alllistmenu;
        public System.Windows.Forms.ToolStripMenuItem addToPickedListToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip pickeditemsmenu;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox lvl1;
        public System.Windows.Forms.TextBox lvl2;
        public System.Windows.Forms.CheckBox quests;
        public System.Windows.Forms.CheckBox elixir;
        public System.Windows.Forms.CheckBox other;
        public System.Windows.Forms.CheckBox stones;
        public System.Windows.Forms.CheckBox tablets;
        public System.Windows.Forms.CheckBox gold;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.CheckBox equip;
        public System.Windows.Forms.CheckBox equip_rare;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox search_name;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem abotToolStripMenuItem;
        public System.Windows.Forms.TextBox counter;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.OpenFileDialog openFileDialog;

    }
}

