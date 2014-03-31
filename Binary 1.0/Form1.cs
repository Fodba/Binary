using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_1._0
{
    public partial class Binary : Form
    {
        DateTime heureLocale;
        public Binary()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            heureLocale = DateTime.Now;
            decoupeHeure(heureLocale);
        }

        private void decoupeHeure(DateTime heure)
        {
            int Heure = heure.Hour;
            int min = heure.Minute;
            int secondes = heure.Second;
            //MessageBox.Show(heure.ToString());
        }
        private void afficheHeureComplete()
        {

        }
        private void afficheHeures()
        {

        }
        private void afficheMinutes()
        {

        }
        private void afficheSecondes(int secondes)
        {

        }
    }
}
