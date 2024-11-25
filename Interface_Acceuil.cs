using System;
using System.Windows.Forms;

namespace Suites_Numériques
{
    public partial class Interface_Acceuil : Form
    {
        public Interface_Acceuil()
        {
            InitializeComponent();
        }

        private void toolStrip_Arithmetiques_Click(object sender, EventArgs e)
        {
            Interface_Arithmetique arithmetique = new Interface_Arithmetique();
            arithmetique.ShowDialog();
        }

        private void toolStrip_Geometrique_Click(object sender, EventArgs e)
        {
            Interface_Geometrique geometrique = new Interface_Geometrique();
            geometrique.ShowDialog();
        }

        private void toolStrip_SansContrainte_Click(object sender, EventArgs e)
        {
            Interface_InitialisationJeu initialisationJeu = new Interface_InitialisationJeu(false);
            initialisationJeu.ShowDialog();
        }

        private void toolStrip_AvecContrainte_Click(object sender, EventArgs e)
        {
            Interface_InitialisationJeu initialisationJeu = new Interface_InitialisationJeu(true);
            initialisationJeu.ShowDialog();
        }

        private void menuStrip_Meilleurs_temps_Click(object sender, EventArgs e)
        {
            Interface_MeilleurScore meilleurScore = new Interface_MeilleurScore();
            meilleurScore.ShowDialog();
        }
    }
}
