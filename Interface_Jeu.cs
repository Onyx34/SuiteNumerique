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
    public partial class Interface_Jeu : Form
    {
        // Attributs
        suite_arithmetique suiteArithmetique;
        suite_geometrique suiteGeometrique;
        List<RadioButton> Bouttons = new List<RadioButton>(4);
        int rang;
        int rang2;
        int suite; // 0 pour arithmétique, 1 pour géométrique

        // Constructeurs
        public Interface_Jeu()
        {
            InitializeComponent();
        }
        internal Interface_Jeu(joueur joueur, int tour, int question, bool AvecChrono, int suite)
        {
            InitializeComponent();

            // Inititalisation des champs de linterface
            Bouttons.Add(radioBtn_NonMonotone);
            Bouttons.Add(radioBtn_Croissante);
            Bouttons.Add(radioBtn_Décroissante);
            Bouttons.Add(radioBtn_Constante);

            foreach (RadioButton btn in Bouttons)
            {
                btn.Checked = false;
            }
            textBox_reponse1.Text = "";
            textBox_reponse2.Text = "";

            if (tour == 1)
            {
                label_joueur.Text = "Joueur 1 :";
            }
            else
            {
                label_joueur.Text = "Joueur 2 :";
            }
            label_nom.Text = joueur.Pseudo;
            label_score.Text = joueur.Score.ToString();
            tabPage.Text = $"Question N°{question}/6";

            // Appeel de la méthode pour initialiser la question en fonction du numéro de la question
            switch (question)
            {
                case 1:
                    InitialiserQuestion1();
                    break;
                case 2:
                    InitialiserQuestion2();
                    break;
                case 3:
                    InitialiserQuestion3();
                    break;
                case 4:
                    InitialiserQuestion4();
                    break;
                case 5:
                    InitialiserQuestion5();
                    break;
                case 6:
                    InitialiserQuestion6();
                    break;
            }


        }

        // Methodes
        private void InitialiserQuestion1()
        {
            // Question 1 = Calculer un terme de rang

            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;


            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";

            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = $"Quel est la valeur du terme de rang {rang}";
            label_reponse1.Text = "Réponse :";

        }

        private void InitialiserQuestion2()
        {
            // Question 2 = Calculer le premier terme
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) définie par le terme U{Program.MettreEnIndice(rang)} et de raison r :";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteArithmetique.TermeDeRang(rang)}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) définie par le terme U{Program.MettreEnIndice(rang)} et de raison r :";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteGeometrique.TermeDeRang(rang)}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = $"Quel est la valeur du premier terme U\u2080 ?";
            label_reponse1.Text = "Réponse :";

        }

        private void InitialiserQuestion3()
        {
            // Question 3 = Trouver le rang d'un terme
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = $"Quel est le rang du terme de valeur {suiteArithmetique.TermeDeRang(rang)} ?";
            label_reponse1.Text = "Réponse :";
        }

        private void InitialiserQuestion4()
        {
            // Question 4 = Calculer la raison et le premier terme
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 9);
                rang2 = Program.GenererAleatoire(rang, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) définie par les termes U{Program.MettreEnIndice(rang)} et U{Program.MettreEnIndice(rang2)}";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteArithmetique.TermeDeRang(rang)}";
                label_enonce2.Text = $"U{Program.MettreEnIndice(rang2)} : {suiteArithmetique.TermeDeRang(rang2)}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 4);
                rang2 = Program.GenererAleatoire(rang, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) définie par les termes U{Program.MettreEnIndice(rang)} et U{Program.MettreEnIndice(rang2)}";
                label_enonce1.Text = $"U{Program.MettreEnIndice(rang)} : {suiteGeometrique.TermeDeRang(rang)}";
                label_enonce2.Text = $"U{Program.MettreEnIndice(rang2)} : {suiteGeometrique.TermeDeRang(rang2)}";
            }

            label_question.Text = "Quelles sont les valeurs de la raison et du premier terme U\u2080 ?";
            label_reponse1.Text = "r :";
            label_reponse2.Text = "U\u2080 :";
        }

        private void InitialiserQuestion5()
        {
            // Question 5 = Calculer la somme des termes
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;
            groupBox_monotonie.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 8);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 4);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = $"Quelle est la somme des {rang + 1} premiers termes de la suite ?";
            label_reponse1.Text = "Réponse :";
        }

        private void InitialiserQuestion6()
        {
            // Question 6 = Trouver la monotonie
            label_reponse1.Visible = false;
            textBox_reponse1.Visible = false;
            label_reponse2.Visible = false;
            textBox_reponse2.Visible = false;

            if (suite == 0)
            {
                suiteArithmetique = new suite_arithmetique();
                rang = Program.GenererAleatoire(1, 10);
                label_enonce.Text = $"Soit la suite arithmétique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteArithmetique.Premier}";
                label_enonce2.Text = $"r : {suiteArithmetique.Raison}";
            }
            else
            {
                suiteGeometrique = new suite_geometrique();
                rang = Program.GenererAleatoire(1, 5);
                label_enonce.Text = $"Soit la suite géométrique (Uₙ) de premier terme U\u2080 et de raison r :";
                label_enonce1.Text = $"U\u2080 : {suiteGeometrique.Premier}";
                label_enonce2.Text = $"r : {suiteGeometrique.Raison}";
            }

            label_question.Text = "Quelle est la monotonie de la suite ?";
        }
    }
}
