
using Newtonsoft.Json;
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
            ListBoxOfPlayers.Items.Clear();
            foreach (PlayerwithProperties p in MainForm.Players)
            {
                Names.Add(p.Name);
            }
            ListBoxOfPlayers.Items.AddRange(Names.ToArray());
            
        }

        private void Done_Click(object sender, EventArgs e)
        {
            string s = JsonConvert.SerializeObject(MainForm.Players);
            System.IO.File.WriteAllText(@"Players.txt", s);
     
            this.Close();
        }

     

        private void Add_Click(object sender, EventArgs e)
        {
            PlayerwithProperties playerwithProperties = new PlayerwithProperties();
            DexterityBox.BackColor = Color.White;
            WitBox.BackColor = Color.White;
            NameBox.BackColor = Color.White;
            playerwithProperties.Name = NameBox.Text;
            if (NameBox.Text.Equals(""))
            {
                NameBox.BackColor = Color.Coral;
                return;
            }
            foreach (PlayerwithProperties p in MainForm.Players)
            {
                if (p.Name.Equals(NameBox.Text))
                {
                    NameBox.BackColor = Color.Coral;
                    return;
                }
            }
           
            try
            {
                playerwithProperties.Dexterity = Convert.ToInt32(DexterityBox.Text);
            }
            catch (Exception eee)
            {
                DexterityBox.BackColor = Color.Coral;
                return;
            }
            try
            {
                playerwithProperties.Wit = Convert.ToInt32(WitBox.Text);
            }
            catch (Exception eee)
            {
                WitBox.BackColor = Color.Coral;
                return;
            }
            MainForm.Players.Add(playerwithProperties);

            UpdateListbox();

        }

       

        private void Delete_Click(object sender, EventArgs e)
        {
            for (int x = ListBoxOfPlayers.SelectedIndices.Count - 1; x >= 0; x--)
            {
                int idx = ListBoxOfPlayers.SelectedIndices[x];
                MainForm.Players.RemoveAt(idx);
                ListBoxOfPlayers.Items.RemoveAt(idx);
            }
        }
    }
}
