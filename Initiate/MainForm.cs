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
    public partial class MainForm : Form
    {
        public static List<PlayerwithProperties> Players= new List<PlayerwithProperties>();
        LinkedList<string> OrderedPlayers = new LinkedList<string>();
        SortedList<int, PlayerwithProperties> keyValuePairs = new SortedList<int, PlayerwithProperties>();
        public MainForm()
        {
            InitializeComponent();
            try
            {
                string text = System.IO.File.ReadAllText(@"Players.txt");
                if (text != null)
                    Players = JsonConvert.DeserializeObject<List<PlayerwithProperties>>(text);
                UpdateListbox();
            } catch(Exception eee)
            { }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            UpdateListbox();
            base.OnGotFocus(e);
         
        }

        private void UpdateListbox()
        {
            List<string> Names = new List<string>();
            foreach (PlayerwithProperties p in Players)
            {
                Names.Add(p.Name);
            }
            listBox1.Items.AddRange(Names.ToArray());
        }

        private static readonly Random getrandom = new Random();
       
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
        private void Configure_Click(object sender, EventArgs e)
        {
            Configure configure = new Configure();
            
            configure.Show();
        }

        private void Step_Click(object sender, EventArgs e)
        {
            if (OrderedPlayers.Count>1)
            {
                string buff = OrderedPlayers.First();
                OrderedPlayers.RemoveFirst();
                OrderedPlayers.AddLast(buff);
                buff = null;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(OrderedPlayers.ToArray());
                listBox1.SetSelected(0, true);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReCalc_Click(object sender, EventArgs e)
        {
            UpdateListbox();
            keyValuePairs = new SortedList<int, PlayerwithProperties>();
            foreach (PlayerwithProperties p in Players)
            {
                
                p.Dice = GetRandomNumber(1, 10);
                int DiceResult = p.Wit + p.Dexterity + p.Dice;
                
                PutToRow(DiceResult, p);
            }
            OrderedPlayers.Clear();
           foreach (PlayerwithProperties Player in keyValuePairs.Values)
            {
                string PlayerString = "Игрок:" +Player.Name+" Ловкость: "+Player.Dexterity+" Сообразительность: " + Player.Wit+" Бросок: " + Player.Dice + " Сумма: " + (Player.Dexterity+Player.Wit+Player.Dice);
                OrderedPlayers.AddFirst(PlayerString);
              
            }
            OrderedPlayers.AddLast("------------Конец Хода-------------");
            listBox1.Items.Clear();
            listBox1.Items.AddRange(OrderedPlayers.ToArray());
            if (listBox1.Items.Count>0)
                listBox1.SetSelected(0, true);
        }

         void PutToRow(int DiceResult, PlayerwithProperties Player)
        {
            if (!keyValuePairs.Keys.Contains(DiceResult))
                keyValuePairs.Add(DiceResult, Player);
            else
                PutToRow(DiceResult + 1, Player);
        }

    }
}
