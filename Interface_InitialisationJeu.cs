using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suites_Numériques
{
    public partial class Interface_InitialisationJeu : Form
    {
        bool chrono = false;
        joueur joueur1;
        joueur joueur2;
        int tour = 1; // 1 pour le joueur 1, 2 pour le joueur 2
        int question = 1;
        int nbQuestions = 6;
        int suite = 0; // 0 pour arithmétique, 1 pour géométrique

        //Constructeurs
        public Interface_InitialisationJeu()
        {
            InitializeComponent();
        }
        public Interface_InitialisationJeu(bool AvecChrono)
        {
            InitializeComponent();
            chrono = AvecChrono;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // Récupération pseudo et mot de passe du joueur 1
            string pseudo1 = textBox_pseudo1.Text;
            pseudo1 = pseudo1.Trim();
            pseudo1 = pseudo1.Replace('\t', '_');
            string mdp1 = textBox_mdp1.Text;
            if (mdp1.Contains('\t')) //Contrôle pour ne pas qu'il y ai de tabulation dans le mot de passe
            {
                MessageBox.Show("Le mot de passe ne doit pas contenir de tabulation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupération pseudo et mot de passe du joueur 2
            string pseudo2 = textBox_pseudo2.Text;
            pseudo2 = pseudo2.Trim();
            pseudo2 = pseudo2.Replace(' ', '_');
            pseudo2 = pseudo2.Replace('\t', '_');
            if (pseudo1 == pseudo2)
            {
                MessageBox.Show("Les pseudos ne peuvent pas être identiques", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mdp2 = textBox_mdp2.Text;
            if (mdp2.Contains('\t')) //Contrôle pour ne pas qu'il n'y ai pas de tabulation dans le mot de passe
            {
                MessageBox.Show("Le mot de passe ne doit pas contenir de tabulation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Contrôle de champs vite
            if (pseudo1 == "" || pseudo2 == "" || mdp1 == "" || mdp2 == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Création des joueurs
            joueur1 = new joueur(pseudo1);
            joueur2 = new joueur(pseudo2);

            // Contrôle des mots de passes
            bool authJoueur1 = joueur1.Authentification(mdp1);
            bool authJoueur2 = joueur2.Authentification(mdp2);
            if (chrono)
            {
                if (authJoueur1 && authJoueur2)
                {
                    // Récupération du type de suite
                    if (radioBtn_arithmetique.Checked)
                    {
                        suite = 0;
                    }
                    else
                    {
                        suite = 1;
                    }

                    // Création d'une partie
                    JouerPartie();
                }
                else
                {
                    if (!authJoueur1)
                    {
                        MessageBox.Show("Erreur d'authentification pour le joueur 1", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!authJoueur2)
                    {
                        MessageBox.Show("Erreur d'authentification pour le joueur 2", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Dans le cas où il n'y a pas de chrono, on ne vérifie pas les mots de passes car on ne les enregistre pas les scores
                JouerPartie();
            }


        }

        private void JouerPartie()
        {
            // Fonction permettant le déroulement de la partie
            // Fait appel à jouerQuestion pour chaque question

            for (question = 1; question <= nbQuestions; question++)
            {
                for (tour = 1; tour <= 2; tour++)
                {
                    if (tour == 1)
                    {
                        JouerQuestion(joueur1, question);
                    }
                    else
                    {
                        JouerQuestion(joueur2, question);
                    }
                }
            }

            // Fin de la partie
            Interface_Scores scores = new Interface_Scores(joueur1, joueur2);

            // Met à jour les meilleurs scores dans le fichier joueurs (pour les jeux avec chrono)
            if (chrono)
            {
                joueur1.MettreAJourScore();
                joueur2.MettreAJourScore();
            }

            // Affiche les scores
            scores.ShowDialog();
            if (scores.DialogResult == DialogResult.OK)
            {
                // Reset les scores pour relancer une partie
                joueur1.Score = 0;
                joueur2.Score = 0;
            }
            else
            {
                // Retour au menu
                this.Close();
            }
        }

        private void JouerQuestion(joueur joueur, int QuestionNum)
        {
            // Fonction permettant le déroulement d'une question
            // Fait appel à Interface_Jeu pour chaque question
            MessageBox.Show($"{joueur.Pseudo}, c'est à vous !", "Prêt ?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Interface_Jeu jeu = new Interface_Jeu(joueur1, joueur2, tour, QuestionNum, chrono, suite);
            jeu.ShowDialog();
        }
    }
}
