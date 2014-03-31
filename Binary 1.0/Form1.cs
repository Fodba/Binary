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
        static DateTime heureLocale;
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
            afficheHeures(heure.Hour);
            afficheMinutes(heure.Minute);
            afficheSecondes(heure.Second);
            heureAnalog.Text = heure.ToString();
        }


        private void afficheHeures(int heures)
        {
            int dizaine = heures / 10;
            int unite = heures % 10;
            reinitialiseHeures();
            switch (unite)
            {
                case 0:
                    break;
                case 1:
                    HeureUnite1.BackColor = Color.Black;
                    break;
                case 2:
                    HeureUnite2.BackColor = Color.Black;
                    break;
                case 3:
                    HeureUnite1.BackColor = Color.Black;
                    HeureUnite2.BackColor = Color.Black;
                    break;
                case 4:
                    HeureUnite3.BackColor = Color.Black;
                    break;
                case 5:
                    HeureUnite1.BackColor = Color.Black;
                    HeureUnite3.BackColor = Color.Black;
                    break;
                case 6:
                    HeureUnite1.BackColor = Color.Black;
                    HeureUnite2.BackColor = Color.Black;
                    HeureUnite3.BackColor = Color.Black;
                    break;
                case 7:
                    HeureUnite4.BackColor = Color.Black;
                    break;
                case 8:
                    HeureUnite1.BackColor = Color.Black;
                    HeureUnite4.BackColor = Color.Black;
                    break;
                case 9:
                    HeureUnite1.BackColor = Color.Black;
                    HeureUnite2.BackColor = Color.Black;
                    HeureUnite4.BackColor = Color.Black;
                    break;
            }
            switch (dizaine)
            {
                case 0:
                    break;
                case 1:
                    HeureDizaine1.BackColor = Color.Black;
                    break;
                case 2:
                    HeureDizaine2.BackColor = Color.Black;
                    break;
            }
        }
        private void afficheMinutes(int minutes)
        {
            int dizaine = minutes / 10;
            int unite = minutes % 10;
            reinitialiseMinutes();
            switch (unite)
            {
                case 0:
                    break;
                case 1:
                    MinuteUnite1.BackColor = Color.Black;
                    break;
                case 2:
                    MinuteUnite2.BackColor = Color.Black;
                    break;
                case 3:
                    MinuteUnite1.BackColor = Color.Black;
                    MinuteUnite2.BackColor = Color.Black;
                    break;
                case 4:
                    MinuteUnite3.BackColor = Color.Black;
                    break;
                case 5:
                    MinuteUnite1.BackColor = Color.Black;
                    MinuteUnite3.BackColor = Color.Black;
                    break;
                case 6:
                    MinuteUnite1.BackColor = Color.Black;
                    MinuteUnite2.BackColor = Color.Black;
                    MinuteUnite3.BackColor = Color.Black;
                    break;
                case 7:
                    MinuteUnite4.BackColor = Color.Black;
                    break;
                case 8:
                    MinuteUnite1.BackColor = Color.Black;
                    MinuteUnite4.BackColor = Color.Black;
                    break;
                case 9:
                    MinuteUnite1.BackColor = Color.Black;
                    MinuteUnite2.BackColor = Color.Black;
                    MinuteUnite4.BackColor = Color.Black;
                    break;
            }
            switch (dizaine)
            {
                case 0:
                    break;
                case 1:
                    MinuteDizaine1.BackColor = Color.Black;
                    break;
                case 2:
                    MinuteDizaine2.BackColor = Color.Black;
                    break;
                case 3:
                    MinuteDizaine1.BackColor = Color.Black;
                    MinuteDizaine2.BackColor = Color.Black;
                    break;
                case 4:
                    MinuteDizaine3.BackColor = Color.Black;
                    break;
                case 5:
                    MinuteDizaine1.BackColor = Color.Black;
                    MinuteDizaine3.BackColor = Color.Black;
                    break;
            }
        }
        private void afficheSecondes(int secondes)
        {
            int dizaine = secondes / 10;
            int unite = secondes % 10;
            reinitialiseSecondes();
            switch (unite)
            {
                case 0:
                    break;
                case 1:
                    secondeUnite1.BackColor = Color.Black;
                    break;
                case 2:
                    secondeUnite2.BackColor = Color.Black;
                    break;
                case 3:
                    secondeUnite1.BackColor = Color.Black;
                    secondeUnite2.BackColor = Color.Black;
                    break;
                case 4:
                    secondeUnite3.BackColor = Color.Black;
                    break;
                case 5:
                    secondeUnite1.BackColor = Color.Black;
                    secondeUnite3.BackColor = Color.Black;
                    break;
                case 6:
                    secondeUnite1.BackColor = Color.Black;
                    secondeUnite2.BackColor = Color.Black;
                    secondeUnite3.BackColor = Color.Black;
                    break;
                case 7:
                    secondeUnite4.BackColor = Color.Black;
                    break;
                case 8:
                    secondeUnite1.BackColor = Color.Black;
                    secondeUnite4.BackColor = Color.Black;
                    break;
                case 9:
                    secondeUnite1.BackColor = Color.Black;
                    secondeUnite2.BackColor = Color.Black;
                    secondeUnite4.BackColor = Color.Black;
                    break;
            }
            switch (dizaine)
            {
                case 0:
                    break;
                case 1:
                    secondeDizaine1.BackColor = Color.Black;
                    break;
                case 2:
                    secondeDizaine2.BackColor = Color.Black;
                    break;
                case 3:
                    secondeDizaine1.BackColor = Color.Black;
                    secondeDizaine2.BackColor = Color.Black;
                    break;
                case 4:
                    secondeDizaine3.BackColor = Color.Black;
                    break;
                case 5:
                    secondeDizaine1.BackColor = Color.Black;
                    secondeDizaine3.BackColor = Color.Black;
                    break;
            }
        }


        private void reinitialiseSecondes()
        {
            secondeUnite1.BackColor = Color.MidnightBlue;
            secondeUnite2.BackColor = Color.MidnightBlue;
            secondeUnite3.BackColor = Color.MidnightBlue;
            secondeUnite4.BackColor = Color.MidnightBlue;
            secondeDizaine1.BackColor = Color.MidnightBlue;
            secondeDizaine2.BackColor = Color.MidnightBlue;
            secondeDizaine3.BackColor = Color.MidnightBlue;
        }
        private void reinitialiseMinutes()
        {
            MinuteUnite1.BackColor = Color.MidnightBlue;
            MinuteUnite2.BackColor = Color.MidnightBlue;
            MinuteUnite3.BackColor = Color.MidnightBlue;
            MinuteUnite4.BackColor = Color.MidnightBlue;
            MinuteDizaine1.BackColor = Color.MidnightBlue;
            MinuteDizaine2.BackColor = Color.MidnightBlue;
            MinuteDizaine3.BackColor = Color.MidnightBlue;
        }
        private void reinitialiseHeures()
        {
            HeureUnite1.BackColor = Color.MidnightBlue;
            HeureUnite2.BackColor = Color.MidnightBlue;
            HeureUnite3.BackColor = Color.MidnightBlue;
            HeureUnite4.BackColor = Color.MidnightBlue;
            HeureDizaine1.BackColor = Color.MidnightBlue;
            HeureDizaine2.BackColor = Color.MidnightBlue;
        }



        private void Binary_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.A)
            {
                if (heureAnalog.Visible == true)
                {
                    heureAnalog.Visible = false;
                }
                else if (heureAnalog.Visible == false)
                {
                    heureAnalog.Visible = true;
                }
            }
        }
    }
}
