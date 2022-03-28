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
    public partial class Startup : Form
    {

        private Point location_start = new Point(626, 208);
        private int player_count;

        private List<int> pos_available = new List<int> { 1, 2, 3, 4, 5 };
        private Panel[] player_pannels;
        private ComboBox[] pos_boxes;

        List<Player> players;
        bool[] options = new bool[4] { true, true, false, false };

        private Size stage1_max = new Size(851, 318);
        private Size stage2_max = new Size(851, 465);

        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            pos_boxes = new ComboBox[5] { p1_pos, p2_pos, p3_pos, p4_pos, p5_pos };
            player_pannels = new Panel[5] { panel1, panel2, panel3, panel4, panel5 };
            combo_players.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // setup all the players into the global list
                players = new List<Player>();
                Player[] playerArr = new Player[player_count];

                if (player_count >= 2)
                {
                    Player p1 = new Player(p1_name.Text, Convert.ToInt16(p1_pos.SelectedItem.ToString()), p1_icon_select.SelectedItem.ToString());
                    playerArr[p1.Pos - 1] = p1;
                    Player p2 = new Player(p2_name.Text, Convert.ToInt16(p2_pos.SelectedItem.ToString()), p2_icon_select.SelectedItem.ToString());
                    playerArr[p2.Pos - 1] = p2;
                }

                if (player_count >= 3)
                {
                    Player p3 = new Player(p3_name.Text, Convert.ToInt16(p3_pos.SelectedItem.ToString()), p3_icon_select.SelectedItem.ToString());
                    playerArr[p3.Pos - 1] = p3;
                }

                if (player_count >= 4)
                {
                    Player p4 = new Player(p4_name.Text, Convert.ToInt16(p4_pos.SelectedItem.ToString()), p4_icon_select.SelectedItem.ToString());
                    playerArr[p4.Pos - 1] = p4;
                }

                if (player_count >= 5)
                {
                    Player p5 = new Player(p5_name.Text, Convert.ToInt16(p5_pos.SelectedItem.ToString()), p5_icon_select.SelectedItem.ToString());
                    playerArr[p5.Pos - 1] = p5;
                }

                players = playerArr.ToList();

                // start the game
                if (players.Count >= 2)
                {
                    Game game = new Game(players, options);
                    game.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void pos_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    List<int> pos_available2 = new List<int>();
        //    foreach (int i in pos_available)
        //    {
        //        pos_available2.Add(i);
        //    }


        //    foreach (ComboBox c in pos_boxes)
        //    {
        //        if (c.SelectedIndex != -1)
        //        {
        //            int selected = Convert.ToInt16(c.SelectedItem.ToString());
        //            pos_available2.Remove(selected);
        //        }

        //        c.Items.Clear();

        //        foreach (int i in pos_available2)
        //        {
        //            c.Items.Add(i);
        //        }
        //    }
        }

        private void icon_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox s = (ComboBox)sender;
            string option = s.Name.Substring(0, s.Name.IndexOf('_'));

            var p = this.Controls.Find(option + "_icon", true);
            PictureBox pi = (PictureBox)p[0];

            switch (s.SelectedItem.ToString())
            {
                case "Car":
                    pi.Image = Properties.Resources.icon_car;
                    break;
                case "Hat":
                    pi.Image = Properties.Resources.icon_hat;
                    break;
                case "Shoe":
                    pi.Image = Properties.Resources.icon_shoe;
                    break;
                case "Thimble":
                    pi.Image = Properties.Resources.icon_thimbell;
                    break;
                case "Dog":
                    pi.Image = Properties.Resources.icon_dog;
                    break;
            }
        }

        private void combo_players_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = combo_players.SelectedIndex + 2;

            for (int i = 0; i < player_pannels.Length; i++)
            {
                player_pannels[i].Visible = false;
            }

            for (int i = 0; i < num; i++)
            {
                player_pannels[i].Visible = true;
            }

            player_count = num;
        }

        private void option_freemoney_CheckedChanged(object sender, EventArgs e)
        {
            options[0] = option_freemoney.Checked;
        }

        private void option_doublego_CheckedChanged(object sender, EventArgs e)
        {
            options[1] = option_doublego.Checked;
        }

        private void option_randomgood_CheckedChanged(object sender, EventArgs e)
        {
            options[2] = option_randomgood.Checked;
        }

        private void option_randombad_CheckedChanged(object sender, EventArgs e)
        {
            options[3] = option_randombad.Checked;
        }
    }
}
