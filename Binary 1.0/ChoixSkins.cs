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
    public partial class ChoixSkins : Form
    {
        private DateTime heureLocale;
        private Color Horloge = new Color();
        private Color Background = new Color();
        private Binary monParent = new Binary();
        public ChoixSkins(Binary parent)
        {
            InitializeComponent();
            monParent = parent;
            Horloge = parent.CouleurHorloge;
            Background = parent.CouleurBackground;
            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Horloge_Click(object sender, EventArgs e)
        {
            Label lab = (Label)sender;
            Horloge = lab.BackColor;
        }

        private void testCouleurHorloge(Color couleur)
        {
            //afficheSecondes(couleur);
        }

        private void Background_Click(object sender, EventArgs e)
        {
            Label lab = (Label)sender;
            Background = lab.BackColor;
            testCouleurBackground(Background);
        }

        private void testCouleurBackground(Color couleur)
        {
            this.groupBoxRendu.BackColor = couleur;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monParent.BackColor = Background;
            monParent.CouleurHorloge = Horloge;
        }

        private void afficheSecondes(DateTime heure)
        {
            heureLocale = DateTime.Now;
            int dizaine = heureLocale.Second / 10;
            int unite = heureLocale.Second % 10;
            reinitialiseSecondes();
            switch (unite)
            {
                case 0:
                    break;
                case 1:
                    RenduUnite1.BackColor = Horloge;
                    break;
                case 2:
                    RenduUnite2.BackColor = Horloge;
                    break;
                case 3:
                    RenduUnite1.BackColor = Horloge;
                    RenduUnite2.BackColor = Horloge;
                    break;
                case 4:
                    RenduUnite3.BackColor = Horloge;
                    break;
                case 5:
                    RenduUnite1.BackColor = Horloge;
                    RenduUnite3.BackColor = Horloge;
                    break;
                case 6:
                    RenduUnite1.BackColor = Horloge;
                    RenduUnite2.BackColor = Horloge;
                    RenduUnite3.BackColor = Horloge;
                    break;
                case 7:
                    RenduUnite4.BackColor = Horloge;
                    break;
                case 8:
                    RenduUnite1.BackColor = Horloge;
                    RenduUnite4.BackColor = Horloge;
                    break;
                case 9:
                    RenduUnite1.BackColor = Horloge;
                    RenduUnite2.BackColor = Horloge;
                    RenduUnite4.BackColor = Horloge;
                    break;
            }
            switch (dizaine)
            {
                case 0:
                    break;
                case 1:
                    RenduDizaine1.BackColor = Horloge;
                    break;
                case 2:
                    RenduDizaine2.BackColor = Horloge;
                    break;
                case 3:
                    RenduDizaine1.BackColor = Horloge;
                    RenduDizaine2.BackColor = Horloge;
                    break;
                case 4:
                    RenduDizaine3.BackColor = Horloge;
                    break;
                case 5:
                    RenduDizaine1.BackColor = Horloge;
                    RenduDizaine3.BackColor = Horloge;
                    break;
            }
        }
        private void reinitialiseSecondes()
        {
            RenduUnite1.BackColor = this.groupBoxRendu.BackColor;
            RenduUnite2.BackColor = this.groupBoxRendu.BackColor;
            RenduUnite3.BackColor = this.groupBoxRendu.BackColor;
            RenduUnite4.BackColor = this.groupBoxRendu.BackColor;
            RenduDizaine1.BackColor = this.groupBoxRendu.BackColor;
            RenduDizaine2.BackColor = this.groupBoxRendu.BackColor;
            RenduDizaine3.BackColor = this.groupBoxRendu.BackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            heureLocale = DateTime.Now;
            afficheSecondes(heureLocale);
        }
    }
}
