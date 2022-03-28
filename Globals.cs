using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Banker
{
    public static class Globals
    {
        public static Dictionary<string, Image> assets = new Dictionary<string, Image>();

        public static int trust_lap = 2;
        public static int trust_jail = -10;
        public static int trust_prop_buy = 5;
        public static int trust_prop_sell = -10;
        public static int trust_house_buy = 5;
        public static int trust_house_sell = -7;
        public static int trust_hotel_buy = 7;
        public static int trust_hotel_sell = -9;
        public static int trust_mortgage = -10;
        public static int trust_unmortgage = 5;
        public static int trust_loan_taken = -4;
        public static int trust_loan_paid = 3;
        public static int trust_reinvest_on = 6;
        public static int trust_reinvest_off = -9;
        public static int trust_insurance_on = 6;
        public static int trust_insurance_off = -9;

        public static void AssetSetup()
        {
            assets.Add("Car", Properties.Resources.icon_car);
            assets.Add("Hat", Properties.Resources.icon_hat);
            assets.Add("Shoe", Properties.Resources.icon_shoe);
            assets.Add("Thimble", Properties.Resources.icon_thimbell);
            assets.Add("Dog", Properties.Resources.icon_dog);
            assets.Add("House", Properties.Resources.house);
            assets.Add("Hotel", Properties.Resources.hotel);
            assets.Add("Mortgage", Properties.Resources.small_mortgage);
            assets.Add("DeedMortgage", Properties.Resources.mortgage1);
        }
    }
}
