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
    public partial class Trust_Modifiers : Form
    {
        public Trust_Modifiers()
        {
            InitializeComponent();
        }

        private void Trust_Modifiers_Load(object sender, EventArgs e)
        {
            num_lap.Value = Globals.trust_lap;
            num_jail.Value = Globals.trust_jail;
            num_prop_buy.Value = Globals.trust_prop_buy;
            num_prop_sell.Value = Globals.trust_prop_sell;
            num_house_buy.Value = Globals.trust_house_buy;
            num_house_sell.Value = Globals.trust_house_sell;
            num_hotel_buy.Value = Globals.trust_hotel_buy;
            num_hotel_sell.Value = Globals.trust_hotel_sell;
            num_mortgage.Value = Globals.trust_mortgage;
            num_unmortgage.Value = Globals.trust_unmortgage;
            num_loan_taken.Value = Globals.trust_loan_taken;
            num_loan_paid.Value = Globals.trust_loan_paid;
            num_reinvest_on.Value = Globals.trust_reinvest_on;
            num_reinvest_off.Value = Globals.trust_reinvest_off;
            num_insurance_on.Value = Globals.trust_insurance_on;
            num_insurance_off.Value = Globals.trust_insurance_off;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.trust_lap = (int)num_lap.Value;
            Globals.trust_jail = (int)num_jail.Value;
            Globals.trust_prop_buy = (int)num_prop_buy.Value;
            Globals.trust_prop_sell = (int)num_prop_sell.Value;
            Globals.trust_house_buy = (int)num_house_buy.Value;
            Globals.trust_house_sell = (int)num_house_sell.Value;
            Globals.trust_hotel_buy = (int)num_house_buy.Value;
            Globals.trust_hotel_sell = (int)num_house_sell.Value;
            Globals.trust_mortgage = (int)num_mortgage.Value;
            Globals.trust_unmortgage = (int)num_unmortgage.Value;
            Globals.trust_loan_taken = (int)num_loan_taken.Value;
            Globals.trust_loan_paid = (int)num_loan_paid.Value;
            Globals.trust_reinvest_on = (int)num_reinvest_on.Value;
            Globals.trust_reinvest_off = (int)num_reinvest_off.Value;
            Globals.trust_insurance_on = (int)num_insurance_on.Value;
            Globals.trust_insurance_off = (int)num_insurance_off.Value;

            Close();
        }
    }
}
