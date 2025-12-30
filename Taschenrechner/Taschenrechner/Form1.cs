using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            double zahl1 = double.Parse(txtErsteZahl.Text);
            double zahl2 = double.Parse(txtZweiteZahl.Text);
           
               
            {
                MessageBox.Show("Geben Sie bitte eine gültige Zahln ein.");
                return;
            }
            {

            }
            double ergebnis = zahl1 + zahl2;
            txtErgebnis.Text = ergebnis.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double zahl1 = double.Parse(txtErsteZahl.Text);
            double zahl2 = double.Parse(txtZweiteZahl.Text);
            double ergebnis = zahl1 - zahl2;
            txtErgebnis.Text = ergebnis.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double zahl1 = double.Parse(txtErsteZahl.Text);
            double zahl2 = double.Parse(txtZweiteZahl.Text);
            double ergebnis = zahl1 * zahl2;
            txtErgebnis.Text = ergebnis.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double zahl1 = double.Parse(txtErsteZahl.Text);
            double zahl2 = double.Parse(txtZweiteZahl.Text);
            double ergebnis = zahl1 / zahl2;
            txtErgebnis.Text = ergebnis.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtErsteZahl.Clear();
            txtZweiteZahl.Clear();
            txtErgebnis.Clear();

        }
    }
}
