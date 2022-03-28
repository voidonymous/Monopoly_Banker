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
    public partial class Finish : Form
    {

        private List<Player> players;
        private List<Property> properties;
        private Size[] sizes;
        private List<Statistics> statistics;

        public Finish(List<Property> properties, List<Player> players)
        {
            InitializeComponent();
            this.properties = properties;
            this.players = players;
        }

        private void Finish_Load(object sender, EventArgs e)
        {
            sizes = new Size[5] { new Size(442, 477), new Size(442, 477), new Size(654, 477), new Size(864, 477), new Size(1075, 477) };

            // initilize the statistics list
            statistics = new List<Statistics>();

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

                    Statistics s = new Statistics(players[i], list);
                    statistics.Add(s);
                }
            }

            ViewStats();
        }

        private void addmoney_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != "")
            {
                string b_code = tb.Name;
                b_code = b_code.Substring(1, 1);

                Player player = players.Find(x => x.Pos == Convert.ToInt16(b_code));
                if (player != null)
                {
                    Statistics s = statistics.Find(x => x.Player.Pos == player.Pos);
                    if (s != null)
                    {
                        try
                        {
                            s.Money = Convert.ToInt32(tb.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Input Error");
                        }
                    }
                }

                ViewStats();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            foreach (Statistics s in statistics)
            {
                s.Clear();
            }

            foreach (Property p in properties)
            {
                if (p.Owner != null)
                {
                    Statistics s = statistics.Find(x => x.Player.Pos == p.Owner.Pos);

                    if (p.Special == false)
                    {
                        if (p.Hotel == 1)
                        {
                            s.Hotels++;
                            s.Total_value += p.House_value;
                        }

                        for (int i = 0; i < p.Houses; i++)
                        {
                            s.Houses++;
                            s.Total_value += p.House_value;
                        }
                    }

                    s.Properties++;
                    if (p.Mortgage) // add half value since it is mortgaged
                        s.Total_value += (p.Value / 2);
                    else
                        s.Total_value += p.Value;
                }
            }

            foreach (Statistics s in statistics)
            {
                s.Total_value += s.Money;
                s.Total_value -= s.Player.Loan;
                s.Total_value += s.Player.Savings;
            }

            ViewStats();
        }

        private void ViewStats()
        {
            foreach (Statistics s in statistics)
            {
                s.List.Items.Clear();

                s.List.Items.Add("Remaining Money: " + s.Money);
                s.List.Items.Add("Total Properties: " + s.Properties);
                s.List.Items.Add("Total Houses: " + s.Houses);
                s.List.Items.Add("Total Hotels: " + s.Hotels);
                s.List.Items.Add("Total Value: " + s.Total_value);
                s.List.Items.Add("");
                s.List.Items.Add("Current Stats");
                s.List.Items.Add("Current Owned: " + s.Player.Current_owned);
                s.List.Items.Add("Current Houses: " + s.Player.Current_houses);
                s.List.Items.Add("Current Hotels: " + s.Player.Current_hotels);
                s.List.Items.Add("Properties Mortgaged: " + s.Player.Current_mortgaged);
                s.List.Items.Add("");
                s.List.Items.Add("Game Stats");
                s.List.Items.Add("Game Owned: " + s.Player.Stats_owned);
                s.List.Items.Add("Game House: " + s.Player.Stats_houses);
                s.List.Items.Add("Game Hotels: " + s.Player.Stats_hotels);
                s.List.Items.Add("Loan: " + s.Player.Stats_loan);
                s.List.Items.Add("Properties Mortgaged: " + s.Player.Stats_mortgaged);
                s.List.Items.Add("Savings: " + s.Player.Stats_savings);
                s.List.Items.Add("Total Laps: " + s.Player.Stats_laps);
                s.List.Items.Add("Insurance Paid: " + s.Player.Stats_insurance);
                
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to finish?\n\nYou can close this using the x to continue your game.", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    public class Statistics
    {
        Player player;
        int properties;
        int houses;
        int hotels;
        int total_value;
        ListBox list;
        int money;

        public Statistics(Player player, ListBox list)
        {
            hotels = 0;
            houses = 0;
            properties = 0;
            total_value = 0;
            money = 0;
            this.list = list;
            this.player = player;
        }

        public void Clear()
        {
            hotels = 0;
            houses = 0;
            properties = 0;
            total_value = 0;
        }

        public Player Player { get => player; set => player = value; }
        public int Properties { get => properties; set => properties = value; }
        public int Houses { get => houses; set => houses = value; }
        public int Hotels { get => hotels; set => hotels = value; }
        public ListBox List { get => list; set => list = value; }
        public int Total_value { get => total_value; set => total_value = value; }
        public int Money { get => money; set => money = value; }
    }
}
