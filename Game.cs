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
    public partial class Game : Form
    {
        // Global Variables
        private int _xPos;
        private int _yPos;
        private bool _dragging;

        private List<Player> players;
        private bool[] options;
        private List<Property> properties;

        private Property selected_prop;
        private Player selected_player;
        private PictureBox[] pv_houses;

        private int total_laps = 0;
        private int total_turns = 0;
        private int free_money = 0;
        private bool start_game = false;

        private Random rand = new Random();
        private List<string> random_good_stuff;
        private List<string> random_bad_stuff;

        private const int GOOD_CHANCE = 10;
        private const int BAD_CHANCE = 20;

        private Color default_backcolor = Color.FromArgb(205, 230, 208);

        private PictureBox find_icon;
        private int flash_count;

        private enum TrustFields
        {
            None,
            Lap,
            Jail,
            Prop_Buy,
            Prop_Sell,
            House_Buy,
            House_Sell,
            Hotel_Buy,
            Hotel_Sell,
            Mortgage,
            Unmortgage,
            Loan_Taken,
            Loan_Paid,
            Reinvest_On,
            Reinvest_Off,
            Insurance_On,
            Insurance_Off
        }

        public Game(List<Player> players, bool[] options)
        {
            InitializeComponent();
            this.players = players;
            this.options = options;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            properties = new List<Property>();
            properties.Add(new Property("p_01_1", Color.FromArgb(149, 84, 54), value: 60, house_value: 50));
            properties.Add(new Property("p_01_2", Color.FromArgb(149, 84, 54), value: 60, house_value: 50));
            properties.Add(new Property("p_02_1", Color.FromArgb(170, 224, 250), value: 100, house_value: 50));
            properties.Add(new Property("p_02_2", Color.FromArgb(170, 224, 250), value: 100, house_value: 50));
            properties.Add(new Property("p_02_3", Color.FromArgb(170, 224, 250), value: 120, house_value: 50));
            properties.Add(new Property("p_03_1", Color.FromArgb(217, 58, 150), value: 140, house_value: 100));
            properties.Add(new Property("p_03_2", Color.FromArgb(217, 58, 150), value: 140, house_value: 100));
            properties.Add(new Property("p_03_3", Color.FromArgb(217, 58, 150), value: 160, house_value: 100));
            properties.Add(new Property("p_04_1", Color.FromArgb(247, 148, 29), value: 180, house_value: 100));
            properties.Add(new Property("p_04_2", Color.FromArgb(247, 148, 29), value: 180, house_value: 100));
            properties.Add(new Property("p_04_3", Color.FromArgb(247, 148, 29), value: 200, house_value: 100));
            properties.Add(new Property("p_05_1", Color.FromArgb(237, 27, 36), value: 220, house_value: 150));
            properties.Add(new Property("p_05_2", Color.FromArgb(237, 27, 36), value: 220, house_value: 150));
            properties.Add(new Property("p_05_3", Color.FromArgb(237, 27, 36), value: 240, house_value: 150));
            properties.Add(new Property("p_06_1", Color.FromArgb(254, 242, 0), value: 260, house_value: 150));
            properties.Add(new Property("p_06_2", Color.FromArgb(254, 242, 0), value: 260, house_value: 150));
            properties.Add(new Property("p_06_3", Color.FromArgb(254, 242, 0), value: 280, house_value: 150));
            properties.Add(new Property("p_07_1", Color.FromArgb(31, 178, 90), value: 300, house_value: 200));
            properties.Add(new Property("p_07_2", Color.FromArgb(31, 178, 90), value: 300, house_value: 200));
            properties.Add(new Property("p_07_3", Color.FromArgb(31, 178, 90), value: 320, house_value: 200));
            properties.Add(new Property("p_08_1", Color.FromArgb(1, 113, 187), value: 350, house_value: 200));
            properties.Add(new Property("p_08_2", Color.FromArgb(1, 113, 187), value: 400, house_value: 200));
            properties.Add(new Property("p_09_1", Color.White, Properties.Resources.electric, true, value: 150));
            properties.Add(new Property("p_09_2", Color.White, Properties.Resources.water_works, true, value: 150));
            properties.Add(new Property("p_10_1", Color.White, Properties.Resources.railway, true, value: 200));
            properties.Add(new Property("p_10_2", Color.White, Properties.Resources.railway2, true, value: 200));
            properties.Add(new Property("p_10_3", Color.White, Properties.Resources.railway3, true, value: 200));
            properties.Add(new Property("p_10_4", Color.White, Properties.Resources.railway4, true, value: 200));

            // random good stuff
            random_good_stuff = new List<string>();
            random_good_stuff.Add("Grant [player] $50");
            random_good_stuff.Add("Grant [player] $100");
            random_good_stuff.Add("Grant [player] $150");
            random_good_stuff.Add("1 House for Auction - Starting $50");
            random_good_stuff.Add("2 Houses for Auction - Starting $100");
            random_good_stuff.Add("Grant [player] 1 House for $50");
            random_good_stuff.Add("Grant [player] 1 House for $100");
            random_good_stuff.Add("Grant [player] 1 Hotel for $400");
            random_good_stuff.Add("Grant [player] move to any space");
            random_good_stuff.Add("Grant [player] Trust +10");
            random_good_stuff.Add("Grant [player] Trust +20");

            // random bad stuff
            random_bad_stuff = new List<string>();
            random_bad_stuff.Add("Charge [player] $50");
            random_bad_stuff.Add("Charge [player] $100");
            random_bad_stuff.Add("Charge [player] $150");
            random_bad_stuff.Add("Earthquake");
            random_bad_stuff.Add("Tornado");
            random_bad_stuff.Add("Flood");
            random_bad_stuff.Add("Cyclone");
            random_bad_stuff.Add("Typhoon");
            random_bad_stuff.Add("Send [player] to Jail");
            random_bad_stuff.Add("Revoke [player] 1 House");

            //temp for testing
            //players.Add(new Player("Void", 1, "Car"));
            //players.Add(new Player("Bwap", 2, "Shoe"));
            //players.Add(new Player("Ciera", 3, "Hat"));

            for (int i = 0; i < players.Count; i++)
            {
                string base_player = "p_player_";
                Panel p = (Panel)this.Controls.Find(base_player + (i + 1).ToString(), true)[0];

                p.Visible = true;
                Label name = (Label)this.Controls.Find("p" + (i + 1) + "_name", true)[0];
                PictureBox icon = (PictureBox)this.Controls.Find("p" + (i + 1) + "_icon", true)[0];

                if (name != null) name.Text = players[i].Name;
                if (icon != null) icon.Image = players[i].Icon;
            }

            foreach (Player pl in players)
            {
                pv_player.Items.Add(pl.Name);
                UpdatePlayer(pl);
            }
            pv_player.SelectedIndex = 0;

            pv_houses = new PictureBox[4] { pv_h1, pv_h2, pv_h3, pv_h4 };

            // options setup
            if (options[0]) // continuous free money
            {
                lbl_freemoney.Visible = true;
                lbx_free_money.Visible = true;
            }

            if (options[1]) // double go
            {
                p1_lap_400.Visible = true;
                p2_lap_400.Visible = true;
                p3_lap_400.Visible = true;
                p4_lap_400.Visible = true;
                p5_lap_400.Visible = true;
            }

            // attach icon boxes to the players
            int counter = 0;
            foreach (Player p in players)
            {
                switch (p.Icon_type)
                {
                    case "Car":
                        p.Icon_box = icon_move_car;
                        icon_move_car.Tag = counter;
                        icon_move_car.Visible = true;
                        break;
                    case "Hat":
                        p.Icon_box = icon_move_hat;
                        icon_move_hat.Tag = counter;
                        icon_move_hat.Visible = true;
                        break;
                    case "Shoe":
                        p.Icon_box = icon_move_shoe;
                        icon_move_shoe.Tag = counter;
                        icon_move_shoe.Visible = true;
                        break;
                    case "Thimble":
                        p.Icon_box = icon_move_thimble;
                        icon_move_thimble.Tag = counter;
                        icon_move_thimble.Visible = true;
                        break;
                    case "Dog":
                        p.Icon_box = icon_move_dog;
                        icon_move_dog.Tag = counter;
                        icon_move_dog.Visible = true;
                        break;
                    default:
                        break;
                }

                counter++;
            }

            // start game
            start_game = true;
        }

        #region pieces_move

        private void MovePlayer_MouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (null == c) return;
            _dragging = false;
            Do_Turn();

            int tag = Convert.ToInt16((sender as PictureBox).Tag);

            CheckJail(tag);
            Player player = players[tag];
            selected_player = player;
            Update_PlayerView(player);
            pv_player.SelectedIndex = player.Pos - 1;
        }

        private void MovePlayer_MouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _yPos;
            c.Left = e.X + c.Left - _xPos;
            c.BackColor = Color.FromArgb(192, 255, 192);
            c.BringToFront();
        }

        private void MovePlayer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            _dragging = true;
            _xPos = e.X;
            _yPos = e.Y;
        }

        #endregion

        private void property_Click(object sender, EventArgs e)
        {
            // clear the controls
            foreach (PictureBox pvh in pv_houses)
                pvh.Image = null;
            pv_owner_icon.Image = null;
            pv_owner_name.Text = "";

            // setup the property
            Panel p = (Panel)sender;
            string p_code = p.Name;
            Property prop = properties.Find(x => x.Id == p_code);
            selected_prop = prop;

            string[] prop_split = p_code.Split('_');

            p_propertyview.Visible = true;
            pv_close.Visible = true;
            pv_num.Text = prop_split[2];
            
            if (prop.Special)
            {
                pv_colour.Visible = false;
                pv_h1.Visible = false;
                pv_h2.Visible = false;
                pv_h3.Visible = false;
                pv_h4.Visible = false;
            }
            else
            {
                pv_colour.Visible = true;
                pv_h1.Visible = true;
                pv_h2.Visible = true;
                pv_h3.Visible = true;
                pv_h4.Visible = true;

                pv_colour.BackColor = prop.Color;
                pv_h1.BackColor = prop.Color;
                pv_h2.BackColor = prop.Color;
                pv_h3.BackColor = prop.Color;
                pv_h4.BackColor = prop.Color;
            }

            if (prop.Owner != null)
            {
                Player pl = prop.Owner;
                pv_owner_name.Text = pl.Name;
                pv_owner_icon.Image = pl.Icon;
                pv_player.SelectedItem = pl.Name;
                pv_buy.Enabled = false;
                pv_mortgage.Enabled = true;
                pv_sold.Enabled = true;
                pv_house_plus.Enabled = true;
                pv_house_minus.Enabled = true;

                pv_mortgage.Enabled = (prop.Houses == 0 && prop.Hotel == 0) ? true : false;

                if (prop.Mortgage)
                {
                    pv_mortgage.Enabled = false;
                    pv_unmortgage.Enabled = true;
                }

                // setup houses
                if (selected_prop.Hotel == 1)
                {
                    for (int i = 0; i < pv_houses.Length; i++)
                        pv_houses[i].Image = null;

                    pv_houses[1].Image = Globals.assets["Hotel"];
                }
                else
                {
                    for (int i = 0; i < selected_prop.Houses; i++)
                        pv_houses[i].Image = Globals.assets["House"];
                }
            }
            else
            {
                pv_buy.Enabled = true;
                pv_mortgage.Enabled = false;
                pv_unmortgage.Enabled = false;
                pv_sold.Enabled = false;
                pv_house_plus.Enabled = false;
                pv_house_minus.Enabled = false;
            }
        }

        private void pv_buy_Click(object sender, EventArgs e)
        {
            if (selected_prop.Owner == null)
            {
                // find player
                Player pl = players.Find(x => x.Name == pv_player.SelectedItem.ToString());

                if (pl.Lap_props < pl.Max_props)
                {
                    selected_prop.Owner = pl;
                    selected_player = pl;

                    string ps = "p" + pl.Pos + "_" + selected_prop.Id;
                    PictureBox player_property = (PictureBox)this.Controls.Find(ps, true)[0];
                    player_property.BackColor = Color.Lime;

                    pv_owner_name.Text = pl.Name;
                    pv_owner_icon.Image = pl.Icon;
                    pv_player.SelectedItem = pl.Name;
                    pv_buy.Enabled = false;
                    pv_mortgage.Enabled = true;
                    pv_sold.Enabled = true;
                    pv_house_plus.Enabled = true;
                    pv_house_minus.Enabled = true;

                    // add to insurance value
                    pl.Insurance += selected_prop.Insurance_value;
                    TextBox player_insurance = (TextBox)this.Controls.Find("p" + pl.Pos + "_insurance", true)[0];
                    player_insurance.Text = pl.Insurance.ToString();

                    // set the image on the property to the buyers icon
                    PictureBox prop_owner = (PictureBox)this.Controls.Find("ow_" + selected_prop.Id, true)[0];
                    prop_owner.Image = selected_prop.Owner.Icon;

                    // trust
                    UpdateTrust(pl, TrustFields.Prop_Buy);

                    //update stats
                    pl.Current_owned++;
                    pl.Stats_owned++;
                    pl.Lap_props++;
                    Update_PlayerView(pl);
                }
                else
                {
                    MessageBox.Show(pl.Name + " has reached the max properties this lap.");
                }
            }
        }

        private void pv_mortgage_Click(object sender, EventArgs e)
        {
            selected_prop.Mortgage = true;
            pv_unmortgage.Enabled = true;
            pv_mortgage.Enabled = false;
            pv_house_plus.Enabled = false;
            pv_house_minus.Enabled = false;

            string ps = "p" + selected_prop.Owner.Pos + "_" + selected_prop.Id;
            PictureBox player_property = (PictureBox)this.Controls.Find(ps, true)[0];
            player_property.BackColor = default_backcolor;
            player_property.Image = Globals.assets["Mortgage"];

            Panel prop_panel = (Panel)this.Controls.Find(selected_prop.Id, true)[0];
            prop_panel.BackgroundImage = Globals.assets["DeedMortgage"];

            UpdateTrust(selected_prop.Owner, TrustFields.Mortgage);

            //update stats
            selected_prop.Owner.Current_mortgaged++;
            selected_prop.Owner.Stats_mortgaged++;
            Update_PlayerView(selected_prop.Owner);
        }

        private void pv_unmortgage_Click(object sender, EventArgs e)
        {
            selected_prop.Mortgage = false;
            pv_unmortgage.Enabled = false;
            pv_mortgage.Enabled = true;
            pv_house_plus.Enabled = true;
            pv_house_minus.Enabled = true;

            string ps = "p" + selected_prop.Owner.Pos + "_" + selected_prop.Id;
            PictureBox player_property = (PictureBox)this.Controls.Find(ps, true)[0];
            player_property.Image = null;
            player_property.BackColor = Color.Lime;

            Panel prop_panel = (Panel)this.Controls.Find(selected_prop.Id, true)[0];
            prop_panel.BackgroundImage = null;

            if (selected_prop.Special)
                prop_panel.BackgroundImage = selected_prop.Bg;

            UpdateTrust(selected_prop.Owner, TrustFields.Unmortgage);

            //update stats
            selected_prop.Owner.Current_mortgaged--;
            Update_PlayerView(selected_prop.Owner);
        }

        private void pv_sold_Click(object sender, EventArgs e)
        {
            SellProperty();
        }

        private void SellProperty()
        {
            if (selected_prop.Owner != null)
            {
                pv_owner_name.Text = "";
                pv_owner_icon.Image = null;
                pv_player.SelectedIndex = 0;
                pv_buy.Enabled = true;
                pv_mortgage.Enabled = false;
                pv_unmortgage.Enabled = false;
                pv_sold.Enabled = false;
                pv_house_plus.Enabled = false;
                pv_house_minus.Enabled = false;

                // clear the controls
                foreach (PictureBox pvh in pv_houses)
                    pvh.Image = null;

                if (selected_prop.Mortgage)
                {
                    Panel prop_panel = (Panel)this.Controls.Find(selected_prop.Id, true)[0];
                    prop_panel.BackgroundImage = null;

                    if (selected_prop.Special)
                        prop_panel.BackgroundImage = selected_prop.Bg;

                    selected_prop.Owner.Current_mortgaged--;
                }

                if (selected_prop.Houses > 0 || selected_prop.Hotel > 0)
                {
                    // find the controls
                    PictureBox h1 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h1", true)[0];
                    PictureBox h2 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h2", true)[0];
                    PictureBox h3 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h3", true)[0];
                    PictureBox h4 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h4", true)[0];

                    PictureBox[] hArr = new PictureBox[4] { h1, h2, h3, h4 };

                    foreach (PictureBox pvh in hArr)
                        pvh.Image = null;

                    selected_prop.Owner.Current_houses -= selected_prop.Houses;
                    selected_prop.Owner.Current_hotels -= selected_prop.Hotel;

                    int hhtotal = selected_prop.Houses + selected_prop.Hotel;
                    for (int i = 0; i < hhtotal; i++)
                        UpdateTrust(selected_prop.Owner, TrustFields.House_Sell);
                }

                // set the image on the property to the buyers icon
                PictureBox prop_owner = (PictureBox)this.Controls.Find("ow_" + selected_prop.Id, true)[0];
                prop_owner.Image = null;

                string ps = "p" + selected_prop.Owner.Pos + "_" + selected_prop.Id;
                PictureBox player_property = (PictureBox)this.Controls.Find(ps, true)[0];
                player_property.Image = null;
                player_property.BackColor = default_backcolor;

                UpdateTrust(selected_prop.Owner, TrustFields.Prop_Sell);

                // deduct from insurance value
                selected_prop.Owner.Insurance -= selected_prop.Insurance_value;
                TextBox player_insurance = (TextBox)this.Controls.Find("p" + selected_prop.Owner.Pos + "_insurance", true)[0];
                player_insurance.Text = selected_prop.Owner.Insurance.ToString();

                //update stats
                selected_prop.Owner.Current_owned--;
                Update_PlayerView(selected_prop.Owner);

                selected_prop.Clear();
            }
        }

        private void playerlap_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string b_code = b.Name;
            b_code = b_code.Substring(1, 1);

            Player player = players.Find(x => x.Pos == Convert.ToInt16(b_code));
            if (player != null)
            {
                Do_Lap(player, 200);
            }
        }

        private void playerlap400_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string b_code = b.Name;
            b_code = b_code.Substring(1, 1);

            Player player = players.Find(x => x.Pos == Convert.ToInt16(b_code));
            if (player != null)
            {
                Do_Lap(player, 400);
            }
        }

        // THE BIG FUCK OFF LAP FUNCTION =================================================================================================
        private void Do_Lap(Player player, int amount)
        {
            player.Lap_props = 0;
            player.Lap_houses = 0;

            int amount_to_add = amount - (player.Has_insurance ? player.Insurance : 0);

            // update loan
            int prev_loan = player.Loan;
            int curr_loan = player.Loan + (int)(player.Loan * player.Loan_interest);
            player.Loan += curr_loan - prev_loan;
            TextBox player_loan = (TextBox)this.Controls.Find("p" + player.Pos + "_loan", true)[0];
            player_loan.Text = player.Loan.ToString();

            // update savings
            int prev_savings = player.Savings;
            int diff_savings = 0;
            int curr_savings = 0;

            // check re-investment
            CheckBox player_reinvest = (CheckBox)this.Controls.Find("p" + player.Pos + "_reinvest", true)[0];
            if (player_reinvest.Checked)
                diff_savings = (int)((player.Savings + amount_to_add) * (1 + player.Savings_interest)) - player.Savings;
            else
                diff_savings = (int)(player.Savings * (1 + player.Savings_interest)) - player.Savings;

            curr_savings = player.Savings + diff_savings;
            player.Savings = curr_savings;

            TextBox player_savings = (TextBox)this.Controls.Find("p" + player.Pos + "_savings", true)[0];
            player_savings.Text = player.Savings.ToString();

            // Stats
            player.Stats_laps++;
            if (curr_loan > prev_loan)
                player.Stats_loan += (curr_loan - prev_loan);

            if (curr_savings > prev_savings)
                player.Stats_savings += (curr_savings - prev_savings);

            // update trust fields
            UpdateTrust(player, TrustFields.Lap);

            // UI Updates
            UpdatePlayer(player);
            Update_PlayerView(player);

            string output = $"Player {player.Pos} has finished a Lap.\n" +
                $"Loan: {prev_loan} -> {curr_loan}\n" +
                $"Savings: {prev_savings} -> {curr_savings}\n\n" +
                $"Insurance: {(player.Has_insurance ? player.Insurance.ToString() : "N/A")}\n\n";

            if (player.Has_insurance)
                player.Stats_insurance += player.Insurance;

            if (player_reinvest.Checked)
                output += $"No payment required";
            else
                output += $"Pay Player ${amount_to_add}";

            MessageBox.Show(output, "Player Lap");

            total_laps++;

            // Free Money
            if (options[0])
            {
                if (total_laps % players.Count == 0)
                {
                    MessageBox.Show($"Add ${lbx_free_money.Items[free_money]} to Center", "Lap");
                    if (free_money < lbx_free_money.Items.Count - 1)
                    {
                        lbx_free_money.SetItemChecked(free_money, true);
                        free_money++;
                    }
                }
            }
        }

        //========================================================================================================================================

        private void UpdatePlayer(Player player)
        {
            TextBox player_trust = (TextBox)this.Controls.Find("p" + player.Pos + "_trust", true)[0];
            TextBox player_loan = (TextBox)this.Controls.Find("p" + player.Pos + "_loan", true)[0];
            Label player_loan_int = (Label)this.Controls.Find("p" + player.Pos + "_loan_int", true)[0];
            TextBox player_savings = (TextBox)this.Controls.Find("p" + player.Pos + "_savings", true)[0];
            Label player_savings_int = (Label)this.Controls.Find("p" + player.Pos + "_savings_int", true)[0];
            TextBox player_insurance = (TextBox)this.Controls.Find("p" + player.Pos + "_insurance", true)[0];

            player_trust.Text = player.Trust.ToString();
            player_loan.Text = player.Loan.ToString();
            player_loan_int.Text = "@ " + player.Loan_interest.ToString();
            player_savings.Text = player.Savings.ToString();
            player_savings_int.Text = "@ " + player.Savings_interest.ToString();
            player_insurance.Text = player.Insurance.ToString();
        }

        private void pv_close_Click(object sender, EventArgs e)
        {
            p_propertyview.Visible = false;
            pv_close.Visible = false;
        }

        private void plv_close_Click(object sender, EventArgs e)
        {
            p_playerview.Visible = false;
            plv_close.Visible = false;
        }

        private void p_player_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            string p_code = p.Name;
            string[] p_splits = p_code.Split('_');
            int pos = Convert.ToInt16(p_splits[2]);

            Player player = players.Find(x => x.Pos == pos);
            if (player != null)
            {
                selected_player = player;

                Update_PlayerView(player);
            }
        }

        private void Update_PlayerView(Player player)
        {
            if (player == selected_player)
            {
                plv_icon.Image = player.Icon;
                plv_name.Text = player.Name;

                p_playerview.Visible = true;
                plv_close.Visible = true;

                plv_owned.Text = player.Current_owned.ToString();
                plv_mortgaged.Text = player.Current_mortgaged.ToString();
                plv_houses.Text = player.Current_houses.ToString();
                plv_hotels.Text = player.Current_hotels.ToString();
                plv_statlaps.Text = player.Stats_laps.ToString();
                plv_statownded.Text = player.Stats_owned.ToString();
                plv_statmortgaged.Text = player.Stats_mortgaged.ToString();
                plv_stathouses.Text = player.Stats_houses.ToString();
                plv_stathotels.Text = player.Stats_hotels.ToString();
                plv_statinsurance.Text = player.Stats_insurance.ToString();
                plv_statloan.Text = player.Stats_loan.ToString();
                plv_statsavings.Text = player.Stats_savings.ToString();
                plv_lap_props.Text = player.Lap_props.ToString() + "/" + player.Max_props.ToString();
                plv_lap_houses.Text = player.Lap_houses.ToString() + "/" + player.Max_houses.ToString();
            }

            UpdatePlayer(player);
        }

        private void pv_house_plus_Click(object sender, EventArgs e)
        {
            if (selected_prop.Special == false)
            {
                if (selected_prop.Owner != null)
                {
                    if (selected_prop.Owner.Lap_houses < selected_prop.Owner.Max_houses)
                    {
                        // find the controls
                        PictureBox h1 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h1", true)[0];
                        PictureBox h2 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h2", true)[0];
                        PictureBox h3 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h3", true)[0];
                        PictureBox h4 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h4", true)[0];

                        PictureBox[] hArr = new PictureBox[4] { h1, h2, h3, h4 };

                        // 

                        if (selected_prop.Houses == 4 && selected_prop.Hotel == 1)
                        {
                            return;
                        }

                        // add hotel
                        if (selected_prop.Houses == 4 && selected_prop.Hotel == 0)
                        {
                            selected_prop.Hotel += 1;
                            selected_prop.Owner.Current_hotels += 1;
                            selected_prop.Owner.Stats_hotels += 1;
                            UpdateTrust(selected_prop.Owner, TrustFields.Hotel_Buy);
                        }

                        // add houses
                        if (selected_prop.Houses < 4)
                        {
                            selected_prop.Houses += 1;
                            selected_prop.Owner.Current_houses += 1;
                            selected_prop.Owner.Stats_houses += 1;
                            UpdateTrust(selected_prop.Owner, TrustFields.House_Buy);
                        }

                        if (selected_prop.Hotel == 1)
                        {
                            for (int i = 0; i < pv_houses.Length; i++)
                            {
                                pv_houses[i].Image = null;
                                hArr[i].Image = null;
                            }

                            pv_houses[1].Image = Globals.assets["Hotel"];
                            hArr[1].Image = Globals.assets["Hotel"];
                        }
                        else
                        {
                            for (int i = 0; i < selected_prop.Houses; i++)
                            {
                                pv_houses[i].Image = Globals.assets["House"];
                                hArr[i].Image = Globals.assets["House"];
                            }
                        }

                        if (selected_prop.Houses > 0 || selected_prop.Hotel > 0)
                        {
                            pv_mortgage.Enabled = false;
                        }

                        selected_prop.Owner.Lap_houses++;

                        //update stats
                        Update_PlayerView(selected_prop.Owner);
                    }
                    else
                    {
                        MessageBox.Show(selected_prop.Owner.Name + " has reached the max house/hotels this lap.");
                    }
                }
            }
        }

        private void pv_house_minus_Click(object sender, EventArgs e)
        {
            SellHouse();
        }

        private void SellHouse()
        {
            if (selected_prop.Special == false)
            {
                if (selected_prop.Owner != null)
                {
                    // find the controls
                    PictureBox h1 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h1", true)[0];
                    PictureBox h2 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h2", true)[0];
                    PictureBox h3 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h3", true)[0];
                    PictureBox h4 = (PictureBox)this.Controls.Find(selected_prop.Id + "_h4", true)[0];

                    PictureBox[] hArr = new PictureBox[4] { h1, h2, h3, h4 };

                    // no houses or hotels to remove
                    if (selected_prop.Houses == 0 && selected_prop.Hotel == 0)
                    {
                        return;
                    }

                    // remove houses
                    if (selected_prop.Houses > 0 && selected_prop.Hotel == 0)
                    {
                        selected_prop.Owner.Current_houses -= 1;
                        selected_prop.Houses -= 1;
                        UpdateTrust(selected_prop.Owner, TrustFields.House_Sell);
                    }

                    // remove hotel
                    if (selected_prop.Houses == 4 && selected_prop.Hotel == 1)
                    {
                        selected_prop.Owner.Current_hotels -= 1;
                        selected_prop.Hotel -= 1;
                        UpdateTrust(selected_prop.Owner, TrustFields.Hotel_Sell);
                    }

                    for (int i = 0; i < pv_houses.Length; i++)
                    {
                        pv_houses[i].Image = null;
                        hArr[i].Image = null;
                    }

                    for (int i = 0; i < selected_prop.Houses; i++)
                    {
                        pv_houses[i].Image = Globals.assets["House"];
                        hArr[i].Image = Globals.assets["House"];
                    }

                    if (selected_prop.Houses == 0)
                    {
                        pv_mortgage.Enabled = true;
                    }

                    //update stats
                    Update_PlayerView(selected_prop.Owner);
                }
            }
        }

        private void reinvest_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            string b_code = b.Name;
            b_code = b_code.Substring(1, 1);

            Player player = players.Find(x => x.Pos == Convert.ToInt16(b_code));
            if (player != null)
            {
                if (b.Checked)
                {
                    player.Reinvest = true;
                    UpdateTrust(player, TrustFields.Reinvest_On);
                }
                else
                {
                    player.Reinvest = false;
                    UpdateTrust(player, TrustFields.Reinvest_Off);
                }
            }

            UpdatePlayer(player);
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (start_game)
                {
                    TextBox t = (TextBox)sender;
                    string t_n = t.Name;
                    t_n = t_n.Substring(1);
                    string[] t_split = t_n.Split('_');

                    if (t.Text != "")
                    {
                        Player player = players[Convert.ToInt16(t_split[0]) - 1];

                        int prev = 0;
                        int curr = Convert.ToInt16(t.Text);
                        switch (t_split[1])
                        {
                            case "trust":
                                player.Trust = Convert.ToInt16(t.Text);
                                UpdateTrust(player, TrustFields.None);
                                break;
                            case "loan":
                                prev = player.Loan;
                                player.Loan = Convert.ToInt16(t.Text);
                                if (curr > prev)
                                {
                                    player.Stats_loan += curr - prev;
                                    UpdateTrust(player, TrustFields.Loan_Taken);
                                }
                                else
                                    UpdateTrust(player, TrustFields.Loan_Paid);
                                break;
                            case "savings":
                                prev = player.Savings;
                                player.Savings = Convert.ToInt16(t.Text);
                                if (curr > prev)
                                    player.Stats_savings += curr - prev;
                                break;
                            case "insurance":
                                prev = player.Insurance;
                                player.Insurance = Convert.ToInt16(t.Text);
                                if (curr > prev)
                                    player.Stats_insurance += curr - prev;
                                break;
                        }

                        Update_PlayerView(player);
                    }
                }
            }
        }

        private void btn_turn_Click(object sender, EventArgs e)
        {
            Do_Turn();
        }
        private void Do_Turn()
        {
            total_turns++;

            int g_r = rand.Next(GOOD_CHANCE);
            int b_r = rand.Next(BAD_CHANCE);

            btn_turn.Text = $"Turn     {g_r} | {b_r}";
            // Random Events
            // Good
            if (options[2])
            {
                if (g_r == 0)
                {
                    Player p = players[rand.Next(players.Count)];
                    string item = random_good_stuff[rand.Next(random_good_stuff.Count)];
                    item = item.Replace("[player]", p.Name);
                    MessageBox.Show(item, "Random Event - Good");
                    // auctions
                    if (item.Contains("Auction"))
                    {
                        int auction_num = Convert.ToInt16(item.Substring(0, 1));
                        for (int i = 0; i < auction_num; i++)
                        {
                            string starting = item.Substring(item.IndexOf("$") + 1);
                            RunAuction(Convert.ToInt32(starting));
                        }
                    }

                    // trust
                    if (item.Contains("Trust"))
                    {
                        int amount = Convert.ToInt16(item.Substring(item.IndexOf("+") + 1));
                        p.Trust += amount;
                        TextBox player_trust = (TextBox)this.Controls.Find("p" + p.Pos + "_trust", true)[0];
                        player_trust.Text = p.Trust.ToString();
                    }
                }
            }

            // Bad
            if (options[3])
            {
                if (b_r == 0)
                {
                    Player p = players[rand.Next(players.Count)];
                    string item = random_bad_stuff[rand.Next(random_bad_stuff.Count)];
                    item = item.Replace("[player]", p.Name);

                    // disasters
                    if (item.Contains("Earthquake"))
                        RunBad("Earthquake");
                    else
                    if (item.Contains("Tornado"))
                        RunBad("Tornado");
                    else
                    if (item.Contains("Flood"))
                        RunBad("Flood");
                    else
                    if (item.Contains("Cyclone"))
                        RunBad("Flood");
                    else
                    if (item.Contains("Typhoon"))
                        RunBad("Typhoon");
                    else
                        MessageBox.Show(item, "Random Event - Bad");

                    // jail
                    if (item.Contains("Jail"))
                    {
                        if (p.In_jail == false)
                        {
                            p.In_jail = true;
                            p.Icon_box.Location = new Point(70, 1245);
                            CheckBox player_jail = (CheckBox)this.Controls.Find("p" + p.Pos + "_jail", true)[0];
                            player_jail.Checked = true;
                            p.Icon_box.BringToFront();
                        }
                    }
                }
            }
        }

        private void RunAuction(int starting)
        {
            using (Auction a = new Auction(players, starting))
            {
                a.ShowDialog();
                if (a.Finished)
                {
                    MessageBox.Show($"{a.Current_top.Name} has won the auction for ${a.Current_val}", "Auction Action");
                }
            }
        }

        private void RunBad(string disaster)
        {
            using (Disaster d = new Disaster(disaster, properties, players))
            {
                d.ShowDialog();
                if (d.Finished)
                {
                    MessageBox.Show(d.Damage_list, "Disaster Rundown");

                    DoDisasterTasks(d.Task_list);
                }
            }
        }

        private void DoDisasterTasks(List<string> tasks)
        {
            foreach (string s in tasks)
            {
                string[] task_split = s.Split('|');
                Property prop = properties.Find(x => x.Id == task_split[0]);
                selected_prop = prop;

                switch (task_split[1])
                {
                    case "hotel":
                    case "house":
                        SellHouse();
                        break;
                    case "street":
                        if (prop.Hotel == 0 && prop.Houses == 0)
                            SellProperty();
                        break;
                }
            }
        }

        private void btnAuction_Click(object sender, EventArgs e)
        {
            using (Auction a = new Auction(players, 1))
            {
                a.ShowDialog();
                if (a.Finished)
                {
                    MessageBox.Show($"{a.Current_top.Name} has won the auction for ${a.Current_val}", "Auction Action");
                }
            }
        }

        private void insure_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            string b_code = b.Name;
            b_code = b_code.Substring(1, 1);

            Player player = players.Find(x => x.Pos == Convert.ToInt16(b_code));
            if (player != null)
            {
                player.Has_insurance = b.Checked;
                TextBox player_insurance = (TextBox)this.Controls.Find("p" + player.Pos + "_insurance", true)[0];
                player_insurance.Enabled = player.Has_insurance ? true : false;
                if (player.Has_insurance)
                    UpdateTrust(player, TrustFields.Insurance_On);
                else
                    UpdateTrust(player, TrustFields.Insurance_Off);

                UpdatePlayer(player);
            }
        }

        private void jail_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = (CheckBox)sender;
            string b_code = b.Name;
            b_code = b_code.Substring(1, 1);

            Player player = players.Find(x => x.Pos == Convert.ToInt16(b_code));
            if (player != null)
            {
                Label player_jailturn = (Label)this.Controls.Find("p" + player.Pos + "_jailturn", true)[0];
                player_jailturn.Text = "Turn 0";
                player.In_jail = b.Checked ? true : false;
                player.Jail_turn = 0;
                if (player.In_jail)
                    UpdateTrust(player, TrustFields.Jail);

                UpdatePlayer(player);
            }
        }

        private void CheckJail(int pos)
        {
            Player player = players[pos];
            if (player.In_jail)
            {
                player.Jail_turn++;

                Label player_jailturn = (Label)this.Controls.Find("p" + player.Pos + "_jailturn", true)[0];
                player_jailturn.Text = "Turn " + player.Jail_turn;
            }
        }

        private void btnFinishGame_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to finish?", "Finished Game?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (Finish f = new Finish(properties, players))
                {
                    f.ShowDialog();
                }
            }
        }

        private void btnTrustModifiers_Click(object sender, EventArgs e)
        {
            using (Trust_Modifiers t = new Trust_Modifiers())
            {
                t.ShowDialog();
            }
        }

        private void UpdateTrust(Player player, TrustFields field)
        {
            player.Savings_interest = 0.05;
            player.Loan_interest = 0.1;

            switch (field)
            {
                case TrustFields.Lap:
                    player.Trust += Globals.trust_lap;
                    break;
                case TrustFields.Jail:
                    player.Trust += Globals.trust_jail;
                    break;
                case TrustFields.Prop_Buy:
                    player.Trust += Globals.trust_prop_buy;
                    break;
                case TrustFields.Prop_Sell:
                    player.Trust += Globals.trust_prop_sell;
                    break;
                case TrustFields.House_Buy:
                    player.Trust += Globals.trust_house_buy;
                    break;
                case TrustFields.House_Sell:
                    player.Trust += Globals.trust_house_sell;
                    break;
                case TrustFields.Hotel_Buy:
                    player.Trust += Globals.trust_hotel_buy;
                    break;
                case TrustFields.Hotel_Sell:
                    player.Trust += Globals.trust_hotel_sell;
                    break;
                case TrustFields.Mortgage:
                    player.Trust += Globals.trust_mortgage;
                    break;
                case TrustFields.Unmortgage:
                    player.Trust += Globals.trust_unmortgage;
                    break;
                case TrustFields.Loan_Taken:
                    player.Trust += Globals.trust_loan_taken;
                    break;
                case TrustFields.Loan_Paid:
                    player.Trust += Globals.trust_loan_paid;
                    break;
                case TrustFields.Reinvest_On:
                    player.Trust += Globals.trust_reinvest_on;
                    break;
                case TrustFields.Reinvest_Off:
                    player.Trust += Globals.trust_reinvest_off;
                    break;
                case TrustFields.Insurance_On:
                    player.Trust += Globals.trust_insurance_on;
                    break;
                case TrustFields.Insurance_Off:
                    player.Trust += Globals.trust_insurance_off;
                    break;
            }

            if (player.Trust < 50)
                player.Trust = 50;

            if (player.Trust > 200)
                player.Trust = 200;

            // calculate interest based on trust
            // very bad
            if (player.Trust < 75)
            {
                player.Savings_interest = 0.02;
                player.Loan_interest = 0.13;
                player.Max_props = 2;
                player.Max_houses = 3;
            }
            // bad
            else if (player.Trust >= 75 && player.Trust < 100)
            {
                player.Savings_interest = 0.04;
                player.Loan_interest = 0.11;
                player.Max_props = 3;
                player.Max_houses = 4;
            }
            // normal (default)
            else if (player.Trust >= 100 && player.Trust < 125)
            {
                player.Savings_interest = 0.05;
                player.Loan_interest = 0.1;
                player.Max_props = 3;
                player.Max_houses = 5;
            }
            // good
            else if (player.Trust >= 125 && player.Trust < 150)
            {
                player.Savings_interest = 0.07;
                player.Loan_interest = 0.08;
                player.Max_props = 3;
                player.Max_houses = 6;
            }
            // very good
            else
            {
                player.Savings_interest = 0.09;
                player.Loan_interest = 0.05;
                player.Max_props = 4;
                player.Max_houses = 8;
            }

            if (player.Reinvest)
            {
                player.Savings_interest += 0.05;
            }

            Update_PlayerView(player);
        }

        private void icon_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            string pb_code = pb.Name;
            pb_code = pb_code.Substring(1, 1);

            Player player = players.Find(x => x.Pos == Convert.ToInt16(pb_code));
            if (player != null)
            {
                find_icon = player.Icon_box;
                flash_count = 0;
                timer_findicon.Start();
            }
        }

        private void timer_findicon_Tick(object sender, EventArgs e)
        {
            flash_count++;

            if (flash_count % 2 == 1)
                find_icon.BackColor = Color.FromArgb(192, 0, 192);
            else
                find_icon.BackColor = Color.FromArgb(192, 255, 192);

            if (flash_count >= 12)
            {
                timer_findicon.Stop();
            }
        }

        private void btnPauseGame_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to pause the game?\nThis will save the current state and close the game.", "Pause Game?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // save game to file
            }
        }
    }
}
