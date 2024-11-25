using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suites_Numériques
{
    public partial class Interface_Arithmetique : Form
    {
        suite_arithmetique suite;
        List<RadioButton> Bouttons = new List<RadioButton>(4);
        int rang_terme;
        int rang_premierTerme;
        int rang_rang;
        int rang_raison1;
        int rang_raison2;
        int rang_somme;

        public Interface_Arithmetique()
        {
            InitializeComponent();
            nouvelle_suite();
            Bouttons.Add(radioBtn_NonMonotone);
            Bouttons.Add(radioBtn_Croissante);
            Bouttons.Add(radioBtn_Décroissante);
            Bouttons.Add(radioBtn_Constante);
        }

        private void btn_nouvelle_terme_Click(object sender, EventArgs e)
        {
            nouvelle_suite();
        }

        private void btn_valider_terme_Click(object sender, EventArgs e)
        {
            string reponse = textBox_reponse_terme.Text;
            int solution = suite.TermeDeRang(rang_terme);

            Correction(reponse, solution, label_verif_terme);
        }

        private void btn_nouvelle_premierTerme_Click(object sender, EventArgs e)
        {
            nouvelle_suite();
        }

        private void btn_valider_premierTerme_Click(object sender, EventArgs e)
        {
            string reponse = textBox_reponse_premierTerme.Text;
            int solution = suite.Premier;

            Correction(reponse, solution, label_verif_premierTerme);
        }

        private void btn_nouvelle_rang_Click(object sender, EventArgs e)
        {
            nouvelle_suite();
        }

        private void btn_valider_rang_Click(object sender, EventArgs e)
        {
            string reponse = textBox_reponse_rang.Text;
            int solution = rang_rang;

            Correction(reponse, solution, label_verif_rang);
        }

        private void btn_nouvelle_raison_Click(object sender, EventArgs e)
        {
            nouvelle_suite();
        }

        private void btn_valider_raison_Click(object sender, EventArgs e)
        {
            string reponse = $"{textBox_reponseR_raison.Text.Trim()}$${textBox_reponse_raison.Text.Trim()}";
            string solution = $"{suite.Raison}$${suite.Premier}";

            Correction(reponse, solution, label_verif_raison);
        }

        private void btn_nouvelle_somme_Click(object sender, EventArgs e)
        {
            nouvelle_suite();
        }

        private void btn_valider_somme_Click(object sender, EventArgs e)
        {
            string reponse = textBox_reponse_somme.Text;
            int solution = suite.SommeDesTermes(rang_somme);

            Correction(reponse, solution, label_verif_somme);
        }

        private void btn_nouvelle_monotonie_Click(object sender, EventArgs e)
        {
            nouvelle_suite();
        }

        private void btn_valider_monotonie_Click(object sender, EventArgs e)
        {
            string reponse = "";

            // On cherche le bouton sélectionné
            foreach (RadioButton btn in Bouttons)
            {
                if (btn.Checked)
                {
                    reponse = btn.Name.Split('_')[1];

                    break;
                }
            }

            string solution = suite.Monotonie();

            Correction(reponse, solution, label_verif_monotonie);
        }


        // Fonctions
        private void nouvelle_suite()
        {
            //  Fonction pour initialiser des suites,
            //  instancie un nouvel objet suite et choisi aléatoirement des termes pour les différentes questions

            // Initialisation des vleurs
            suite = new suite_arithmetique();

            rang_terme = Program.GenererAleatoire(1, 16);
            rang_premierTerme = Program.GenererAleatoire(1, 16);
            rang_rang = Program.GenererAleatoire(1, 16);
            rang_raison1 = Program.GenererAleatoire(1, 15);
            rang_raison2 = Program.GenererAleatoire(rang_raison1 + 1, 16);
            rang_somme = Program.GenererAleatoire(1, 16);


            // Mise à jour des champs 

            MaJ_UnTerme();
            MaJ_premierTerme();
            MaJ_rang();
            MaJ_raison();
            MaJ_somme();
            MaJ_monotonie();

        }

        private void MaJ_UnTerme()
        {
            // Permet de mettre à jour les champs de l'onglet Un Terme
            label_U0_terme.Text = $"U\u2080 : {suite.Premier}";
            label_r_terme.Text = $"r : {suite.Raison}";
            label_question_terme.Text = "Quelle est la valeur du terme de rang " + rang_terme + " ?";
            label_verif_terme.Text = "";
            textBox_reponse_terme.Text = "";
        }

        private void MaJ_premierTerme()
        {
            // Permet de mettre à jour les champs de l'onglet Un Terme
            label_information_premierTerme.Text = $"Soit la suite arithmétique (Uₙ) définie par le terme (U{Program.MettreEnIndice(rang_rang)}) et de raison r :";
            label_rang_premierTerme.Text = $"U{Program.MettreEnIndice(rang_rang)} : {suite.TermeDeRang(rang_premierTerme)}";
            label_r_premierTerme.Text = $"r : {suite.Raison}";
            label_verif_premierTerme.Text = "";
            textBox_reponse_premierTerme.Text = "";
        }

        private void MaJ_rang()
        {
            // Permet de mettre à jour les champs de l'onglet Rang
            label_U0_rang.Text = $"U\u2080 : {suite.Premier}";
            label_r_rang.Text = $"r : {suite.Raison}";
            label_question_rang.Text = $"Quelle est le rang du terme de valeur {suite.TermeDeRang(rang_rang)} ?";
            label_verif_rang.Text = "";
            textBox_reponse_rang.Text = "";
        }

        private void MaJ_raison()
        {
            // Permet de mettre à jour les champs de l'onglet raison
            label_information_raison.Text = $"Soit la suite arithmétique (Uₙ) définie par les termes U{Program.MettreEnIndice(rang_raison1)} et U{Program.MettreEnIndice(rang_raison2)}";
            label_U1_raison.Text = $"U{Program.MettreEnIndice(rang_raison1)} : {suite.TermeDeRang(rang_raison1)}";
            label_U2_raison.Text = $"U{Program.MettreEnIndice(rang_raison2)} : {suite.TermeDeRang(rang_raison2)}";
            label_question_raison.Text = "Quelles sont les valeurs de la raison r et du premier terme U\u2080 ?";
            label_reponseR_raison.Text = "r :";
            textBox_reponseR_raison.Text = "";
            label_reponse_raison.Text = "U\u2080 :";
            textBox_reponse_raison.Text = "";
            label_verif_raison.Text = "";
        }

        private void MaJ_somme()
        {
            // Permet de mettre à jour les champs de l'onglet somme
            label_U0_somme.Text = $"U\u2080 : {suite.Premier}";
            label_r_somme.Text = $"r : {suite.Raison}";
            label_question_somme.Text = $"Quelle est la somme des {rang_somme +1} premiers termes ?";
            label_reponse_somme.Text = $"S{Program.MettreEnIndice(rang_somme)} :";
            textBox_reponse_somme.Text = "";
            label_verif_somme.Text = "";
        }

        private void MaJ_monotonie()
        {
            // Permet de mettre à jour les champs de l'onglet monotonie
            label_U0_monotonie.Text = $"U\u2080 : {suite.Premier}";
            label_r_monotonie.Text = $"r : {suite.Raison}";
            label_question_monotonie.Text = "Quel est la monotonie de la suite ?";
            label_verif_monotonie.Text = "";
            foreach (RadioButton btn in Bouttons)
            {
                btn.Checked = false;
            }
        }


        private void Correction(string reponse, int solution, Label monLabel)
        {
            // Fonction pour vérifier la réponse donnée par l'utilisateur en fonction de la solution (entier)
            // et mettre à jour le label de vérification
            reponse = reponse.Trim();
            if (reponse == "")
            {
                return;
            }
            if (Int32.TryParse(reponse, out int int_reponse))
            {
                if (int_reponse == solution)
                {
                    monLabel.Text = "Réponse correcte";
                    monLabel.ForeColor = Color.Blue;
                }
                else
                {
                    monLabel.Text = "Réponse incorrecte";
                    monLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Format de la réponse non valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Correction(string reponse, string solution, Label monLabel)
        {
            // Fonction pour vérifier la réponse donnée par l'utilisateur en fonction de la solution (chaine)
            // et mettre à jour le label de vérification
            reponse = reponse.Trim();
            if (reponse == "")
            {
                return;
            }
            if (reponse == solution)
            {
                monLabel.Text = "Réponse correcte";
                monLabel.ForeColor = Color.Blue;
            }
            else
            {
                monLabel.Text = "Réponse incorrecte";
                monLabel.ForeColor = Color.Red;
            }
        }
    }
}
