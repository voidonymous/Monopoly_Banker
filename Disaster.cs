using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Banker
{
    public partial class Disaster : Form
    {
        private bool finished = false;
        private string damage_list = "";
        private List<string> task_list;
        private List<Property> properties;
        private List<Player> players;
        private List<Damages> damages;
        private Size[] sizes;
        private const int DESTRUCTION_CHANCE = 5;

        public bool Finished { get => finished; set => finished = value; }
        public string Damage_list { get => damage_list; set => damage_list = value; }
        public List<string> Task_list { get => task_list; set => task_list = value; }

        public Disaster(string disaster, List<Property> properties, List<Player> players)
        {
            InitializeComponent();
            lblDisaster.Text = lblDisaster.Text.Replace("[disaster]", disaster);

            char first = disaster.ToLower().Substring(0, 1)[0];
            if (first == 'a' || first == 'e' || first == 'i' || first == 'o' || first == 'u')
                lblDisaster.Text = lblDisaster.Text.Replace("A ", "An ");

            this.properties = properties;
            this.players = players;
        }

        private void Disaster_Load(object sender, EventArgs e)
        {
            sizes = new Size[5] { new Size(442, 451), new Size(442, 451), new Size(654, 451), new Size(864, 451), new Size(1075, 451) };
            Task_list = new List<string>();

            // initilize the damage list
            damages = new List<Damages>();

            // setup players
            for (int i = 0; i < 5; i++)
            {
                if (players.Count > i)
                {
                    MinimumSize = sizes[i];
                    MaximumSize = sizes[i];

                    Label name = (Label)this.Controls.Find("p" + (i + 1).ToString() + "_name", true)[0];
                    PictureBox icon = (PictureBox)this.Controls.Find("p" + (i + 1).ToString() + "_icon", true)[0];
                    ListBox list = (ListBox)this.Controls.Find("p" + (i + 1).ToString() + "_list", true)[0];
                    name.Text = players[i].Name;
                    icon.Image = players[i].Icon;

                    Damages d = new Damages(players[i], list);
                    damages.Add(d);
                }
            }

            // calculate all damages for all players
            Do_Disaster();

            foreach (Damages d in damages)
            {
                d.List.Items.Add("Streets Damaged: " + d.Properties);
                d.List.Items.Add("Houses Destroyed: " + d.Houses);
                d.List.Items.Add("Hotels Destroyed: " + d.Hotels);
                d.List.Items.Add("Insurance Value: " + d.Insurance_value);
                d.List.Items.Add("Total Value: " + d.Total_value);
            }
        }

        private void Do_Disaster()
        {
            Random rand = new Random();

            foreach (Property p in properties)
            {
                if (p.Owner != null)
                {
                    // if we are here it means that the property is owned and that it is about to have some misfortune
                    Damages d = damages.Find(x => x.Player.Pos == p.Owner.Pos);

                    // go over property itself
                    if (rand.Next(DESTRUCTION_CHANCE) == 0)
                    {
                        d.Properties++;
                        d.Items += $"{p.Id} street was damaged\n";
                        d.Insurance_value += p.Insurance_value;
                        d.Total_value += p.Value;

                        if (d.Player.Has_insurance == false)
                            Task_list.Add($"{p.Id}|street");
                    }

                    if (p.Special == false)
                    {
                        // go over hotel
                        if (p.Hotel > 0)
                        {
                            if (rand.Next(DESTRUCTION_CHANCE) == 0)
                            {
                                d.Hotels++;
                                d.Items += $"{p.Id} hotel was destroyed\n";
                                d.Insurance_value += p.Insurance_value;
                                d.Total_value += p.House_value;

                                if (d.Player.Has_insurance == false)
                                    Task_list.Add($"{p.Id}|hotel");
                            }
                        }
                        else
                        // go over houses
                        if (p.Houses > 0)
                        {
                            for (int i = 0; i < p.Houses; i++)
                            {
                                if (rand.Next(DESTRUCTION_CHANCE) == 0)
                                {
                                    d.Houses++;
                                    d.Items += $"{p.Id} house was destroyed\n";
                                    d.Insurance_value += p.Insurance_value;
                                    d.Total_value += p.House_value;

                                    if (d.Player.Has_insurance == false)
                                        Task_list.Add($"{p.Id}|house");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            Button b_p = (Button)sender;
            int p_num = Convert.ToInt16(b_p.Name.Substring(1, 1));
            Player player = players.Find(x => x.Pos == p_num);
            if (player != null)
            {
                Damages d = damages.Find(x => x.Player.Pos == player.Pos);
                MessageBox.Show(d.Items, player.Name + "'s Damages");
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            finished = true;
            string output = $"Damages:\n";

            foreach (Damages d in damages)
            {
                output += d.Player.Name + "\n";
                output += "Streets Damaged: " + d.Properties + "\n";
                output += "Houses Destroyed: " + d.Houses + "\n";
                output += "Hotels Destroyed: " + d.Hotels + "\n";
                output += "Insurance Value: " + d.Insurance_value + "\n";
                output += "Total Value: " + d.Total_value + "\n\n";
            }

            Damage_list = output;
            Close();
        }
    }

    public class Damages
    {
        Player player;
        int properties;
        int houses;
        int hotels;
        int total_value;
        int insurance_value;
        ListBox list;
        string items;

        public Damages(Player player, ListBox list)
        {
            hotels = 0;
            houses = 0;
            properties = 0;
            total_value = 0;
            insurance_value = 0;
            this.list = list;
            this.player = player;
            items = "";
        }

        public Player Player { get => player; set => player = value; }
        public int Properties { get => properties; set => properties = value; }
        public int Houses { get => houses; set => houses = value; }
        public int Hotels { get => hotels; set => hotels = value; }
        public ListBox List { get => list; set => list = value; }
        public string Items { get => items; set => items = value; }
        public int Total_value { get => total_value; set => total_value = value; }
        public int Insurance_value { get => insurance_value; set => insurance_value = value; }
    }
}
