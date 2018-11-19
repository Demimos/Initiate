﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initiate
{
    public partial class Configure : Form
    {

        public Configure()
        {
            InitializeComponent();
            try
            {
                string text = System.IO.File.ReadAllText(@"Players.txt");
                if (text != null)
                    MainForm.Players = JsonConvert.DeserializeObject<List<PlayerwithProperties>>(text);
                UpdateListbox();
            }
            catch (Exception eee)
            {

            }
        }

        

        private void UpdateListbox()
        {
            List<string> Names = new List<string>();
            listBox1.Items.Clear();
            foreach (PlayerwithProperties p in MainForm.Players)
            {
                Names.Add(p.Name);
            }
            listBox1.Items.AddRange(Names.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = JsonConvert.SerializeObject(MainForm.Players);
            System.IO.File.WriteAllText(@"Players.txt", s);
     
            this.Close();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerwithProperties playerwithProperties = new PlayerwithProperties();
            DexterityBox.BackColor = Color.White;
            WitBox.BackColor = Color.White;
            playerwithProperties.Name = NameBox.Text;
            try
            {
                playerwithProperties.Dexterity = Convert.ToInt32(DexterityBox.Text);
            }
            catch (Exception eee)
            {
                DexterityBox.BackColor = Color.Red;
                return;
            }
            try
            {
                playerwithProperties.Wit = Convert.ToInt32(WitBox.Text);
            }
            catch (Exception eee)
            {
                WitBox.BackColor = Color.Red;
                return;
            }
            MainForm.Players.Add(playerwithProperties);

            UpdateListbox();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int x = listBox1.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = listBox1.SelectedIndices[x];
                MainForm.Players.RemoveAt(idx);
                listBox1.Items.RemoveAt(idx);
            }
        }
    }
}
