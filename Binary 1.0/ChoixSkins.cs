using System;
using System.Drawing;
using System.Windows.Forms;

namespace Binary_1._0
{
    public partial class ChoixSkins : Form
    {
        private DateTime heureLocale;
        /// <summary>
        /// couleur des carrés indiquant l'heure.
        /// </summary>
        private Color Horloge = new Color();
        /// <summary>
        /// couleur du background.
        /// </summary>
        private Color Background = new Color();

        /// <summary>
        /// variable servant à receptionner la fenetre principale.
        /// </summary>
        private Binary monParent = new Binary();

        /// <summary>
        /// constructeur.
        /// </summary>
        /// <param name="parent">fenetre principal passée en paramètre</param>
        public ChoixSkins(Binary parent)
        {
            InitializeComponent();
            /// on range la fenetre principale dans la variable "monParent"
            monParent = parent;
            /// et on initialise les variable de la fentre actuelle pour garder 
            /// la config de la fenetre principale.
            Horloge = parent.CouleurHorloge;
            Background = parent.CouleurBackground;


            timer1.Interval = 500;
            timer1.Enabled = true;
            timer1.Start();
        }

        /// <summary>
        /// mise à jour de la couleur de l'horloge de la zone d'essai.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Horloge_Click(object sender, EventArgs e)
        {
            Label lab = (Label)sender;
            Horloge = lab.BackColor;
        }
        /// <summary>
        /// remise à zéro de l'horloge de la zone d'essai.
        /// </summary>
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

        /// <summary>
        /// mise à jour du background de la zone d'essai.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Background_Click(object sender, EventArgs e)
        {
            Label lab = (Label)sender;
            Background = lab.BackColor;
            testCouleurBackground(Background);
        }
        /// <summary>
        /// test du background dans la zone d'essai.
        /// </summary>
        private void testCouleurBackground(Color couleur)
        {
            this.groupBoxRendu.BackColor = couleur;
        }

        /// <summary>
        /// transmission des nouveaux paramètres à la fenetre principale
        /// grace à l'événement "BackColorChanged".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            /// on modifie la couleur du background de la fenetre principale.
            monParent.BackColor = Background;
            /// et la couleur des carrés de l'horloge.
            monParent.CouleurHorloge = Horloge;
        }


        /// <summary>
        /// mise à jour de l'horloge de la zone d'essai.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            heureLocale = DateTime.Now;
            afficheSecondes(heureLocale);
        }
    }
}
