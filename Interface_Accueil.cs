using System;
using System.Windows.Forms;

namespace Suites_Numériques
{
    public partial class Interface_Accueil : Form
    {
        public Interface_Accueil()
        {
            InitializeComponent();
        }

        private void toolStrip_Arithmetiques_Click(object sender, EventArgs e)
        {
            // S'exécute lorsqu'on clique sur le bouton "Arithmétiques", ouvre l'interface pour les suites arithmétiques
            Interface_Arithmetique arithmetique = new Interface_Arithmetique();
            arithmetique.ShowDialog();
        }

        private void toolStrip_Geometrique_Click(object sender, EventArgs e)
        {
            // S'exécute lorsqu'on clique sur le bouton "Géométriques", ouvre l'interface pour les suites géométriques
            Interface_Geometrique geometrique = new Interface_Geometrique();
            geometrique.ShowDialog();
        }

        private void toolStrip_SansContrainte_Click(object sender, EventArgs e)
        {
            // S'exécute lors du clic sur le bouton "Sans contrainte", ouvre l'interface pour l'initialisation du jeu sans contrainte
            Interface_InitialisationJeu initialisationJeu = new Interface_InitialisationJeu(false);
            initialisationJeu.ShowDialog();
        }

        private void toolStrip_AvecContrainte_Click(object sender, EventArgs e)
        {
            // S'exécute lors du clic sur le bouton "Avec contrainte", ouvre l'interface pour l'initialisation du jeu avec contrainte
            Interface_InitialisationJeu initialisationJeu = new Interface_InitialisationJeu(true);
            initialisationJeu.ShowDialog();
        }

        private void menuStrip_Meilleurs_temps_Click(object sender, EventArgs e)
        {
            // S'exécute lors du clic sur le bouton "Meilleurs temps", ouvre l'interface pour les meilleurs temps
            Interface_MeilleurScore meilleurScore = new Interface_MeilleurScore();
            meilleurScore.ShowDialog();
        }
    }
}
