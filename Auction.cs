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
    public partial class Auction : Form
    {
        private List<Player> players;
        private Panel[] panels;
        private Panel lastPanel = null;
        private int current_val = 0;
        private Player current_top = null;
        private bool finished = false;

        public int Current_val { get => current_val; set => current_val = value; }
        public Player Current_top { get => current_top; set => current_top = value; }
        public bool Finished { get => finished; set => finished = value; }

        public Auction(List<Player> players, int starting)
        {
            InitializeComponent();
            this.players = players;
            current_val = starting - 1;
        }

        private void Auction_Load(object sender, EventArgs e)
        {
            lbl_current_value.Text = "$" + Current_val.ToString();
            panels = new Panel[5] { panel1, panel2, panel3, panel4, panel5 };

            // load player details
            for (int i = 0; i < panels.Length; i++)
            {
                if (players.Count > i)
                {
                    panels[i].Visible = true;
                    Label name = (Label)this.Controls.Find("p" + (i + 1).ToString() + "_name", true)[0];
                    PictureBox icon = (PictureBox)this.Controls.Find("p" + (i + 1).ToString() + "_icon", true)[0];
                    name.Text = players[i].Name;
                    icon.Image = players[i].Icon;
                }
            }
        }

        private void amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox t_p = (TextBox)sender;
                int p_num = Convert.ToInt16(t_p.Name.Substring(1, 1));
                Player player = players.Find(x => x.Pos == p_num);
                if (player != null)
                {
                    try
                    {
                        int text = Convert.ToInt32(t_p.Text);
                        if (text > Current_val)
                        {
                            if (lastPanel != null && lastPanel.Enabled == true)
                                lastPanel.BackColor = Color.FromArgb(205, 230, 208);

                            lastPanel = panels[p_num - 1];
                            lastPanel.BackColor = Color.Lime;

                            Current_val = text;
                            lbl_current_value.Text = "$" + Current_val.ToString();

                            lbx_history.Items.Add($"{player.Name} bid {Current_val}");

                            Current_top = player;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if (Current_top != null && Current_val > 0)
            {
                finished = true;
                Close();
            }
        }

        private void out_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int p_num = Convert.ToInt16(pb.Name.Substring(1, 1));
            Player player = players.Find(x => x.Pos == p_num);
            if (player != null)
            {
                panels[p_num - 1].Enabled = false;
                panels[p_num - 1].BackColor = Color.Gray;
            }
        }
    }
}
