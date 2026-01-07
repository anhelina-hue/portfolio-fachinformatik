using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzingebrauchsrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
            double gefahren = double.Parse(txt_gefahren.Text);
            double verbrauch = double.Parse(txt_verbraucht.Text);

            // Verbrauch pro 100 km
            double pro_100_km = (100 * verbrauch) / gefahren;
            pro_100_km = Math.Round(pro_100_km, 2);

            //Miles per gallon
            double miles_per_gallon = (gefahren / 1.609) / (verbrauch / 3.785);
            miles_per_gallon = Math.Round(miles_per_gallon, 2);

            txt_pro_100_km.Text = pro_100_km.ToString();

            txt_miles_per_gallon.Text = miles_per_gallon.ToString(); 
        }
    }
}
