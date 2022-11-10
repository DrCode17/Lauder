using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lauder1
{
    public partial class Form1 : Form
    {
        int szamlalo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            szamlalo++;
            var szam1 = int.Parse(szam1_tb.Text);
            var szam2 = int.Parse(szam2_tb.Text);
            if (szamlalo % 2 == 0)
            {
                koszon_lbl.Text = " ";
            }
            else
            {
                /*
                int osszeg = szam1 + szam2;
                koszon_lbl.Text = osszeg.ToString();
                int osztas = szam1 / szam2;
                koszon_lbl.Text = osztas.ToString();
                int szorzat = szam1 * szam2;
                koszon_lbl.Text = szorzat.ToString();
                int kulonbseg = szam1 - szam2;
                koszon_lbl.Text = kulonbseg.ToString();*/
                int maradek = szam1 % szam2;
                koszon_lbl.Text = maradek.ToString();

            }
        }
    }
}
