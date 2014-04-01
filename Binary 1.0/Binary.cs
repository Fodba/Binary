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
        private ChoixSkins Choisir;
        public Color CouleurHorloge;
        public Color CouleurBackground;
        public Binary soi;
        public Binary()
        {
            InitializeComponent();
            this.CouleurHorloge = Color.Black;
            this.CouleurBackground = Color.MidnightBlue;
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void initSoi()
        {
            //soi = new Binary();
            soi = this;
            soi.BackColor = CouleurBackground;
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
                    HeureUnite1.BackColor = CouleurHorloge;
                    break;
                case 2:
                    HeureUnite2.BackColor = CouleurHorloge;
                    break;
                case 3:
                    HeureUnite1.BackColor = CouleurHorloge;
                    HeureUnite2.BackColor = CouleurHorloge;
                    break;
                case 4:
                    HeureUnite3.BackColor = CouleurHorloge;
                    break;
                case 5:
                    HeureUnite1.BackColor = CouleurHorloge;
                    HeureUnite3.BackColor = CouleurHorloge;
                    break;
                case 6:
                    HeureUnite1.BackColor = CouleurHorloge;
                    HeureUnite2.BackColor = CouleurHorloge;
                    HeureUnite3.BackColor = CouleurHorloge;
                    break;
                case 7:
                    HeureUnite4.BackColor = CouleurHorloge;
                    break;
                case 8:
                    HeureUnite1.BackColor = CouleurHorloge;
                    HeureUnite4.BackColor = CouleurHorloge;
                    break;
                case 9:
                    HeureUnite1.BackColor = CouleurHorloge;
                    HeureUnite2.BackColor = CouleurHorloge;
                    HeureUnite4.BackColor = CouleurHorloge;
                    break;
            }
            switch (dizaine)
            {
                case 0:
                    break;
                case 1:
                    HeureDizaine1.BackColor = CouleurHorloge;
                    break;
                case 2:
                    HeureDizaine2.BackColor = CouleurHorloge;
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
                    MinuteUnite1.BackColor = CouleurHorloge;
                    break;
                case 2:
                    MinuteUnite2.BackColor = CouleurHorloge;
                    break;
                case 3:
                    MinuteUnite1.BackColor = CouleurHorloge;
                    MinuteUnite2.BackColor = CouleurHorloge;
                    break;
                case 4:
                    MinuteUnite3.BackColor = CouleurHorloge;
                    break;
                case 5:
                    MinuteUnite1.BackColor = CouleurHorloge;
                    MinuteUnite3.BackColor = CouleurHorloge;
                    break;
                case 6:
                    MinuteUnite1.BackColor = CouleurHorloge;
                    MinuteUnite2.BackColor = CouleurHorloge;
                    MinuteUnite3.BackColor = CouleurHorloge;
                    break;
                case 7:
                    MinuteUnite4.BackColor = CouleurHorloge;
                    break;
                case 8:
                    MinuteUnite1.BackColor = CouleurHorloge;
                    MinuteUnite4.BackColor = CouleurHorloge;
                    break;
                case 9:
                    MinuteUnite1.BackColor = CouleurHorloge;
                    MinuteUnite2.BackColor = CouleurHorloge;
                    MinuteUnite4.BackColor = CouleurHorloge;
                    break;
            }
            switch (dizaine)
            {
                case 0:
                    break;
                case 1:
                    MinuteDizaine1.BackColor = CouleurHorloge;
                    break;
                case 2:
                    MinuteDizaine2.BackColor = CouleurHorloge;
                    break;
                case 3:
                    MinuteDizaine1.BackColor = CouleurHorloge;
                    MinuteDizaine2.BackColor = CouleurHorloge;
                    break;
                case 4:
                    MinuteDizaine3.BackColor = CouleurHorloge;
                    break;
                case 5:
                    MinuteDizaine1.BackColor = CouleurHorloge;
                    MinuteDizaine3.BackColor = CouleurHorloge;
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
                    secondeUnite1.BackColor = CouleurHorloge;
                    break;
                case 2:
                    secondeUnite2.BackColor = CouleurHorloge;
                    break;
                case 3:
                    secondeUnite1.BackColor = CouleurHorloge;
                    secondeUnite2.BackColor = CouleurHorloge;
                    break;
                case 4:
                    secondeUnite3.BackColor = CouleurHorloge;
                    break;
                case 5:
                    secondeUnite1.BackColor = CouleurHorloge;
                    secondeUnite3.BackColor = CouleurHorloge;
                    break;
                case 6:
                    secondeUnite1.BackColor = CouleurHorloge;
                    secondeUnite2.BackColor = CouleurHorloge;
                    secondeUnite3.BackColor = CouleurHorloge;
                    break;
                case 7:
                    secondeUnite4.BackColor = CouleurHorloge;
                    break;
                case 8:
                    secondeUnite1.BackColor = CouleurHorloge;
                    secondeUnite4.BackColor = CouleurHorloge;
                    break;
                case 9:
                    secondeUnite1.BackColor = CouleurHorloge;
                    secondeUnite2.BackColor = CouleurHorloge;
                    secondeUnite4.BackColor = CouleurHorloge;
                    break;
            }
            switch (dizaine)
            {
                case 0:
                    break;
                case 1:
                    secondeDizaine1.BackColor = CouleurHorloge;
                    break;
                case 2:
                    secondeDizaine2.BackColor = CouleurHorloge;
                    break;
                case 3:
                    secondeDizaine1.BackColor = CouleurHorloge;
                    secondeDizaine2.BackColor = CouleurHorloge;
                    break;
                case 4:
                    secondeDizaine3.BackColor = CouleurHorloge;
                    break;
                case 5:
                    secondeDizaine1.BackColor = CouleurHorloge;
                    secondeDizaine3.BackColor = CouleurHorloge;
                    break;
            }
        }


        private void reinitialiseSecondes()
        {
            secondeUnite1.BackColor = this.BackColor;
            secondeUnite2.BackColor = this.BackColor;
            secondeUnite3.BackColor = this.BackColor;
            secondeUnite4.BackColor = this.BackColor;
            secondeDizaine1.BackColor = this.BackColor;
            secondeDizaine2.BackColor = this.BackColor;
            secondeDizaine3.BackColor = this.BackColor;
        }
        private void reinitialiseMinutes()
        {
            MinuteUnite1.BackColor = this.BackColor;
            MinuteUnite2.BackColor = this.BackColor;
            MinuteUnite3.BackColor = this.BackColor;
            MinuteUnite4.BackColor = this.BackColor;
            MinuteDizaine1.BackColor = this.BackColor;
            MinuteDizaine2.BackColor = this.BackColor;
            MinuteDizaine3.BackColor = this.BackColor;
        }
        private void reinitialiseHeures()
        {
            HeureUnite1.BackColor = this.BackColor;
            HeureUnite2.BackColor = this.BackColor;
            HeureUnite3.BackColor = this.BackColor;
            HeureUnite4.BackColor = this.BackColor;
            HeureDizaine1.BackColor = this.BackColor;
            HeureDizaine2.BackColor = this.BackColor;
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
            if (e.KeyValue == (char)Keys.S)
            {
                initSoi();
                Choisir = new ChoixSkins(soi);
                Choisir.ShowDialog();
                reinitialiseHeures();
                reinitialiseMinutes();
                reinitialiseSecondes();
            }
        }

        private void Binary_BackColorChanged(object sender, EventArgs e)
        {
            soi.groupBoxHeures.BackColor = this.BackColor;
            soi.groupBoxMinutes.BackColor = this.BackColor;
            soi.groupBoxSecondes.BackColor = this.BackColor;
        }
    }
}
