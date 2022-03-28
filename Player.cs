using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Banker
{
    public class Player
    {
        private string name;
        private int pos;
        private string icon_type;
        private Image icon;
        private PictureBox icon_box;

        private int trust;

        private bool has_loan;
        private int loan;
        private double loan_interest;

        private bool has_savings;
        private int savings;
        private double savings_interest;
        private bool reinvest;

        private bool has_insurance;
        private int insurance;

        private int current_owned;
        private int current_mortgaged;
        private int current_houses;
        private int current_hotels;

        private int stats_laps;
        private int stats_owned;
        private int stats_mortgaged;
        private int stats_houses;
        private int stats_hotels;
        private int stats_insurance;
        private int stats_loan;
        private int stats_savings;

        private bool in_jail;
        private int jail_turn;

        // lap stuff
        private int lap_props;
        private int lap_houses;
        private int max_props;
        private int max_houses;

        public Player(string name, int pos, string icon_type, int trust = 100, bool has_loan = false, int loan = 0, double loan_interest = 0.1, bool has_savings = false, int savings = 0
            , double savings_interest = 0.05, int insurance = 0)
        {
            this.name = name;
            this.pos = pos;
            this.icon_type = icon_type;

            switch (icon_type)
            {
                case "Car":
                    icon = Globals.assets["Car"];
                    break;
                case "Hat":
                    icon = Globals.assets["Hat"];
                    break;
                case "Shoe":
                    icon = Globals.assets["Shoe"];
                    break;
                case "Thimble":
                    icon = Globals.assets["Thimble"];
                    break;
                case "Dog":
                    icon = Globals.assets["Dog"];
                    break;
                default:
                    break;
            }

            this.trust = trust;
            this.has_loan = has_loan;
            this.loan = loan;
            this.loan_interest = loan_interest;
            this.has_savings = has_savings;
            this.savings = savings;
            this.savings_interest = savings_interest;
            this.insurance = insurance;
            has_insurance = false;
            icon_box = null;
            in_jail = false;
            jail_turn = 0;

            lap_props = 0;
            lap_houses = 0;
            max_props = 3;
            max_houses = 5;
        }

        public string Name { get => name; set => name = value; }
        public int Pos { get => pos; set => pos = value; }
        public Image Icon { get => icon; set => icon = value; }
        public int Trust { get => trust; set => trust = value; }
        public bool Has_loan { get => has_loan; set => has_loan = value; }
        public int Loan { get => loan; set => loan = value; }
        public double Loan_interest { get => loan_interest; set => loan_interest = value; }
        public bool Has_savings { get => has_savings; set => has_savings = value; }
        public int Savings { get => savings; set => savings = value; }
        public double Savings_interest { get => savings_interest; set => savings_interest = value; }
        public int Insurance { get => insurance; set => insurance = value; }
        public int Current_owned { get => current_owned; set => current_owned = value; }
        public int Current_mortgaged { get => current_mortgaged; set => current_mortgaged = value; }
        public int Current_houses { get => current_houses; set => current_houses = value; }
        public int Current_hotels { get => current_hotels; set => current_hotels = value; }
        public int Stats_laps { get => stats_laps; set => stats_laps = value; }
        public int Stats_houses { get => stats_houses; set => stats_houses = value; }
        public int Stats_hotels { get => stats_hotels; set => stats_hotels = value; }
        public int Stats_insurance { get => stats_insurance; set => stats_insurance = value; }
        public int Stats_loan { get => stats_loan; set => stats_loan = value; }
        public int Stats_savings { get => stats_savings; set => stats_savings = value; }
        public int Stats_owned { get => stats_owned; set => stats_owned = value; }
        public int Stats_mortgaged { get => stats_mortgaged; set => stats_mortgaged = value; }
        public bool Has_insurance { get => has_insurance; set => has_insurance = value; }
        public PictureBox Icon_box { get => icon_box; set => icon_box = value; }
        public string Icon_type { get => icon_type; set => icon_type = value; }
        public bool In_jail { get => in_jail; set => in_jail = value; }
        public int Jail_turn { get => jail_turn; set => jail_turn = value; }
        public int Lap_props { get => lap_props; set => lap_props = value; }
        public int Lap_houses { get => lap_houses; set => lap_houses = value; }
        public int Max_props { get => max_props; set => max_props = value; }
        public int Max_houses { get => max_houses; set => max_houses = value; }
        public bool Reinvest { get => reinvest; set => reinvest = value; }
    }
}
