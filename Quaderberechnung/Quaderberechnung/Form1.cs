using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quaderberechnung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_berechnen_Click(object sender, EventArgs e)
        {
     

            double volumen;
            double oberfläche;
            double raumdiagonale;

            if (
                double.TryParse(txt_seite_a.Text, out double seite_a) &&
                double.TryParse(txt_seite_b.Text, out double seite_b) &&
                double.TryParse(txt_seite_c.Text, out double seite_c)
                    )
            {
                if (seite_a <= 0 || seite_b <= 0 || seite_c <= 0)
                {
                    MessageBox.Show("Alle Werte müssen größer als 0 sein.");
                }
                else
                {
                    volumen = seite_a * seite_b * seite_c;
                    lbl_volumen.Text = volumen.ToString();

                    oberfläche = 2*(seite_a * seite_b + seite_b * seite_c + seite_a * seite_c);
                    lbl_oberfläche.Text = oberfläche.ToString();

                    raumdiagonale = Math.Sqrt((Math.Pow(seite_a, 2)) + (Math.Pow(seite_b, 2)) + (Math.Pow(seite_c, 2)));
                    raumdiagonale = Math.Round(raumdiagonale, 2);
                    lbl_raumdiagonale.Text = raumdiagonale.ToString();



                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie in allen Fäldern gültige Zahlen ein.");
            }

            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_seite_a.Clear();
            txt_seite_b.Clear();
            txt_seite_c.Clear();
            lbl_volumen.Text = "";
            lbl_oberfläche.Text = "";
            lbl_raumdiagonale.Text = "";
        }
    }
}
