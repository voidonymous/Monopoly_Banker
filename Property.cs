using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Banker
{
    public class Property
    {
        private string id;
        private Color color;
        private Image bg;
        private bool special;
        private int value;
        private bool mortgage;
        private int insurance_value;
        private int houses;
        private int hotel;
        private int house_value;

        private Player owner;

        public Property(string id, Color color, Image bg = null, bool special = false, int value = 0, bool mortgage = false, int houses = 0, int hotel = 0, int house_value = 0)
        {
            this.Id = id;
            this.color = color;
            this.Bg = bg;
            this.special = special;
            this.Value = value;
            this.Mortgage = mortgage;
            this.Houses = houses;
            this.Hotel = hotel;
            owner = null;
            insurance_value = (int)(value / 10.0);
            this.house_value = house_value;
        }

        public string Id { get => id; set => id = value; }
        public int Value { get => value; set => this.value = value; }
        public bool Mortgage { get => mortgage; set => mortgage = value; }
        public int Houses { get => houses; set => houses = value; }
        public int Hotel { get => hotel; set => hotel = value; }
        public Color Color { get => color; set => color = value; }
        public bool Special { get => special; set => special = value; }
        public Player Owner { get => owner; set => owner = value; }
        public Image Bg { get => bg; set => bg = value; }
        public int Insurance_value { get => insurance_value; set => insurance_value = value; }
        public int House_value { get => house_value; set => house_value = value; }

        public void Clear()
        {
            value = 0;
            mortgage = false;
            houses = 0;
            hotel = 0;
            owner = null;
        }
    }
}
